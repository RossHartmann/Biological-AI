using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.Chromosomes;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms;
using GeneticFaraday.GEP.Contracts.Organisms.Chromosomes;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes;
using GeneticFaraday.GEP.Contracts.Registries;
using GeneticFaraday.GEP.Models.Organisms.OrganismBehavior;
using GeneticFaraday.GEP.Models.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.GEP.Models.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Models.Organisms.Phenomes.DebuggablePhenomes;
using GeneticFaraday.GEP.Models.Registries;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.Chromosomes
{
    public abstract class GEPChromosomeBase : ChromosomeBase, IGEPChromosome
    {
        /// <summary>
        /// The Main() IGene that will be executed when this IChromosome
        /// is executed.
        /// </summary>
        public IGEPGene Main { get; protected set; }

        new public IGEPOrganism Parent { get { return (IGEPOrganism)base.Parent; } set { base.Parent = value; } }

        new public IGEPEnvironment ParentEnvironment { get { return this.Parent.Parent; } }

        /// <summary>
        /// The Local Global Registry for the IGEPChromosome.
        /// This will be new for every unique IGEPChromosome and will be
        /// shared among all IGEPGenes that belong to this IGEPChromosome.
        /// </summary>
        public IRegistry LocalGlobalRegistry { get; private set; }

        /// <summary>
        /// Given the IGEPChromosome's immediate surroundings (i.e. the "input"), 
        /// "Runs" the IGEPChromosome which results in its Behavior (i.e. the "ouput").
        /// </summary>
        /// <returns></returns>
        public virtual IGEPChromosomeBehavior Behave(IGEPChromosomeSurroundings surroundings)
        {
            this.LocalGlobalRegistry.Clear();

            var geneBehavior = this.Main.Behave(new GEPGeneSurroundings(chromosomeSurroundings: surroundings,
                                                     geneExecutionDataDictionary:
                                                         this.CreateGeneExecutionDataDictionary()));
            return new GEPChromosomeBehavior(success: geneBehavior.Success);
        }

        /// <summary>
        /// The provided IGene must be an IGEPGene.
        /// </summary>
        /// <param name="gene"></param>
        /// <returns></returns>
        new public IGEPGene Add(IGene gene)
        {
            return this.Add((IGEPGene) gene);
        }

        public IGEPGene Add(IGEPGene gene)
        {
            gene.Parent = this;
            base.Add(gene);
            return gene;
        }

        /// <summary>
        /// Converts this IGEPChromosome to its corresponding IDebuggableChromosome. An IDebuggableChromosome is an IChromosome that 
        /// treats the IChromosome's IGenes as a "program". An IDebuggableChromosome can be "stepped" into.
        /// </summary>
        /// <returns></returns>
        public IDebuggableChromosome ToDebuggableChromosome(IGEPChromosomeSurroundings surroundings)
        {
            this.LocalGlobalRegistry.Clear();

            var debuggableMain = this.Main.ToDebuggableGene(new GEPGeneSurroundings(surroundings, this.CreateGeneExecutionDataDictionary()));
            return new DebuggableChromosome(debuggableMain);
        }

        /// <summary>
        /// Gets all of the IGenes that belong to this IChromosome.
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<IGene> GetGenes()
        {
            yield return this.Main;
        }

        protected IDictionary<IGeneIdentifier, IGeneExecutionData> CreateGeneExecutionDataDictionary()
        {
            return this.GetIdentifiersOfGenes().ToDictionary(geneIdentifier => geneIdentifier,
                                                             geneIdentifier => ((IGeneExecutionData)new GeneExecutionData()));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="main">The Main() IGene that will be executed when this IChromosome
        /// is executed.</param>
        /// <param name="environment"></param>
        protected GEPChromosomeBase(IGEPEnvironment environment, IGEPGene main)
        {
            this.Main = main;
            this.Main.Parent = this;
            this.LocalGlobalRegistry = new Registry(identifier: environment.LocalGlobalRegistryIdentifier, registryType: RegistryType.LocalGlobal, readOnly: false);
        }

        /// <summary>
        /// Assigns unique IGeneIdentifiers to each IGene in this IChromosome
        /// as well as the Main IGene.
        /// </summary>
        public override void AssignGeneIdentifiers()
        {
            base.AssignGeneIdentifiers();

            this.Main.AssignIdentifiersToChildren();
            this.Main.AssignIdentifier();
        }

        /// <summary>
        /// Returns the unique IGeneIdentifier of all of the IGenes
        /// that belong to this IChromosome. 
        /// 
        /// Also gets the IGeneIdentifier of the Main IGene.
        /// 
        /// If no IGenes belong to this IChromosome, the
        /// resulting IEnumerable will be empty.
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<IGeneIdentifier> GetIdentifiersOfGenes()
        {
            var list = base.GetIdentifiersOfGenes().ToList();
            list.Add(this.Main.Identifier);
            return list;
        }
    }
}
