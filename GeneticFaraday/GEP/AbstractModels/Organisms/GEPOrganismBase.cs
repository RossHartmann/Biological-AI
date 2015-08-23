using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Metrics;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms;
using GeneticFaraday.GEP.Contracts.Organisms.Chromosomes;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Registries;
using GeneticFaraday.GEP.Models.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.GEP.Models.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Models.Registries;

namespace GeneticFaraday.GEP.AbstractModels.Organisms
{
    public abstract class GEPOrganismBase : OrganismBase, IGEPOrganism
    {
        protected GEPOrganismBase(IGEPEnvironment environment)
            : this(environment: environment, collection: new IGEPChromosome[] { })
        {

        }

        protected GEPOrganismBase(IGEPEnvironment environment, IEnumerable<IGEPChromosome> collection)
            : base(collection: collection)
        {
            this.GlobalRegistry = new Registry(identifier: environment.GlobalRegistryIdentifier, registryType: RegistryType.Global, readOnly: false);
            this.ResultsRegistry = new Registry(identifier: environment.ResultsRegistryIdentifier, registryType: RegistryType.Result, readOnly: false);
        }

        new public IEnumerator<IGEPChromosome> GetEnumerator()
        {
            var baseEnumerator = base.GetEnumerator();
            while (baseEnumerator.MoveNext())
                yield return (IGEPChromosome)baseEnumerator.Current;
        }

        /// <summary>
        /// The provided IChromosome must be an IGEPChromosome
        /// </summary>
        /// <param name="item"></param>
        new public void Add(IChromosome item)
        {
            this.Add((IGEPChromosome) item);
        }

        public void Add(IGEPChromosome item)
        {
            item.Parent = this;
            base.Add(chromosome: item);
        }

        public bool Contains(IGEPChromosome item)
        {
            return base.Contains(item: item);
        }

        public void CopyTo(IGEPChromosome[] array, int arrayIndex)
        {
            base.CopyTo(array: array, arrayIndex: arrayIndex);
        }

        public bool Remove(IGEPChromosome item)
        {
            return base.Remove(item: item);
        }

        public bool IsReadOnly { get { return false; } }
        public int IndexOf(IGEPChromosome item)
        {
            return base.IndexOf(item: item);
        }

        public void Insert(int index, IGEPChromosome item)
        {
            base.Insert(index: index, item: item);
        }

        new public IGEPChromosome this[int index]
        {
            get { return (IGEPChromosome)base[index]; }
            set { base[index] = value; }
        }

        new public IGEPEnvironment Parent { get { return (IGEPEnvironment)base.Parent; } set { base.Parent = value; } }

        public IRegistry GlobalRegistry { get; private set; }
        public IRegistry ResultsRegistry { get; private set; }

        /// <summary>
        /// Given the IGEPOrganism's immediate surroundings (i.e. the "input"), 
        /// "Runs" the IGEPOrganism which results in its Behavior (i.e. the "ouput").
        /// </summary>
        /// <returns></returns>
        public IGEPBehavior Behave(IGEPSurroundings surroundings)
        {
            this.GlobalRegistry.Clear();
            this.ResultsRegistry.Clear();

            this.AssignGeneIdentifiers();

            var success = true;
            foreach (var chromosome in this)
            {
                if (!chromosome.Behave(new GEPChromosomeSurroundings(surroundings)).Success)
                {
                    success = false;
                    break;
                }
            }

            return new GEPBehavior(success: success); ;
        }

        
    }
}
