using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Environment;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Metrics;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Environment.CallableGenesProviders;
using GeneticFaraday.GEP.Contracts.Organisms;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Registries;
using GeneticFaraday.GEP.Contracts.Universe;
using GeneticFaraday.GEP.Models.Registries;

namespace GeneticFaraday.GEP.AbstractModels.Environment
{
    public abstract class GEPEnvironmentBase : EnvironmentBase, IGEPEnvironment, IGEPPopulation
    {
        new public IGEPUniverse Parent { get { return (IGEPUniverse)base.Parent; } set { base.Parent = value; } }

        /// <summary>
        /// The IRegistryIdentifier of the primary LocalRegistry for each IGEPGene.
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Global Registries.
        /// </summary>
        public IRegistryIdentifier LocalRegistryIdentifier { get; private set; }
        /// <summary>
        /// The IRegistryIdentifier of the primary GlobalRegistry for the IGEPOrganism.
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Global Registries.
        /// </summary>
        public IRegistryIdentifier GlobalRegistryIdentifier { get; private set; }
        /// <summary>
        /// The IRegistryIdentifier of the primary ResultsRegistry for the IGEPOrganism
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Global Registries.
        /// </summary>
        public IRegistryIdentifier ResultsRegistryIdentifier { get; private set; }
        /// <summary>
        /// The IRegistryIdentifier of the primary InputRegistry for the IGEPOrganism.
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Global Registries.
        /// </summary>
        public IRegistryIdentifier InputRegistryIdentifier { get; private set; }
        /// <summary>
        /// The IRegistryIdentifier of the primary LocalGlobalRegistry for each IGEPChromosome.
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Global Registries.
        /// </summary>
        public IRegistryIdentifier LocalGlobalRegistryIdentifier { get; private set; }

        /// <summary>
        /// An Array of all of the IRegistryIdentifiers for all of the possible IRegistries in this IGEPEnvironment.
        /// </summary>
        public IRegistryIdentifier[] AllRegistryIdentifiers { get; private set; }

        /// <summary>
        /// An Array of all of the IRegistryIdentifiers for all of the IRegistries in this IGEPEnvironment that are NOT
        /// ReadOnly.
        /// </summary>
        public IRegistryIdentifier[] AllWriteableRegistryIdentifiers { get; private set; }

        /// <summary>
        /// The ICallableGenesProvider that gets the IGEPGenes that can be called by the given IGEPGene.
        /// </summary>
        /// <returns></returns>
        public ICallableGenesProvider CallableGenesProvider { get; private set; }

        /// <summary>
        /// The IGeneticCode to which all IOrganisms in the IGEPEnvironment must adhere.
        /// </summary>
        new public IGEPGeneticCode GeneticCode { get { return this.Parent.GeneticCode; } }

        
        new public IEnumerator<IGEPOrganism> GetEnumerator()
        {
            var baseEnumerator = base.GetEnumerator();
            while (baseEnumerator.MoveNext())
                yield return (IGEPOrganism)baseEnumerator.Current;
        }

        /// <summary>
        /// The provided IOrganism must be an IGEPOrganism.
        /// </summary>
        /// <param name="item"></param>
        new public void Add(IOrganism item)
        {
            this.Add((IGEPOrganism) item);
        }

        public void Add(IGEPOrganism item)
        {
            base.Add(organism: item);
        }

        public bool Contains(IGEPOrganism item)
        {
            return base.Contains(item: item);
        }

        public void CopyTo(IGEPOrganism[] array, int arrayIndex)
        {
            base.CopyTo(array: array, arrayIndex: arrayIndex);
        }

        public bool Remove(IGEPOrganism item)
        {
            return base.Remove(item: item);
        }

        public bool IsReadOnly { get { return false; } }

        public int IndexOf(IGEPOrganism item)
        {
            return base.IndexOf(item: item);
        }

        public void Insert(int index, IGEPOrganism item)
        {
            base.Insert(index: index, item: item);
        }

        new public IGEPOrganism this[int index]
        {
            get { return (IGEPOrganism)base[index]; }
            set { base[index] = value; }
        }

        new public IGEPEnvironment ParentIEnvironment { get { return this; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="state"></param>
        /// <param name="metricsEvaluator"></param>
        /// <param name="endCriteriaEvaluator"></param>
        /// <param name="getCallableGenes">Gets the IGEPGenes that can be called by the given IGEPGene.</param>
        protected GEPEnvironmentBase(IEnvironmentIdentifier identifier, IEnvironmentState state,
            IMetricsEvaluator metricsEvaluator, IEndCriteriaEvaluator endCriteriaEvaluator,
            IComparer<IOrganism> organismValueComparer,
            ICallableGenesProvider callableGenesProvider) :
            base(identifier, state, metricsEvaluator, endCriteriaEvaluator, organismValueComparer)
        {
            this.AllRegistryIdentifiers = GetAllRegistryIdentifiers();

            this.AllWriteableRegistryIdentifiers = GetAllWriteableRegistryIdentifiers();

            this.GlobalRegistryIdentifier = new RegistryIdentifier("Global");
            this.InputRegistryIdentifier = new RegistryIdentifier("Input");
            this.LocalGlobalRegistryIdentifier = new RegistryIdentifier("LocalGlobal");
            this.LocalRegistryIdentifier = new RegistryIdentifier("Local");
            this.ResultsRegistryIdentifier = new RegistryIdentifier("Results");
            
            this.CallableGenesProvider = callableGenesProvider;
        }

        public static IRegistryIdentifier[] GetAllRegistryIdentifiers()
        {
            return new IRegistryIdentifier[]
                       {
                           new RegistryIdentifier("Global"),
                           new RegistryIdentifier("Input"),
                           new RegistryIdentifier("LocalGlobal"),
                           new RegistryIdentifier("Local"),
                           new RegistryIdentifier("Results")
                       };
        }

        public static IRegistryIdentifier[] GetAllWriteableRegistryIdentifiers()
        {
            return new IRegistryIdentifier[]
                       {
                           new RegistryIdentifier("Global"),
                           new RegistryIdentifier("LocalGlobal"),
                           new RegistryIdentifier("Local"),
                           new RegistryIdentifier("Results")
                       };
        }
    }
}
