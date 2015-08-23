using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts;
using GeneticFaraday.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Contracts.Organisms.Chromosomes
{
    public interface IGEPChromosome : IChromosome
    {
        /// <summary>
        /// The Main() IGEPGene that will be executed when this IGEPChromosome
        /// is executed.
        /// </summary>
        IGEPGene Main { get; }

        new IGEPOrganism Parent { get; set; }

        /// <summary>
        /// The IGEPEnvironment to which the IGEPChromosome belongs.
        /// </summary>
        new IGEPEnvironment ParentEnvironment { get; }

        /// <summary>
        /// This IRegistry is only available to the IGEPChromosome
        /// that is running and all of its children IGEPGenes.
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Global Registries.
        /// </summary>
        IRegistry LocalGlobalRegistry { get; }

        /// <summary>
        /// Given the IGEPChromosome's immediate surroundings (i.e. the "input"), 
        /// "Runs" the IGEPChromosome which results in its Behavior (i.e. the "ouput").
        /// </summary>
        /// <returns></returns>
        IGEPChromosomeBehavior Behave(IGEPChromosomeSurroundings surroundings);

        /// <summary>
        /// Adds the specified IGEPGene to this IGEPChromosome. Returns the added IGEPGene.
        /// </summary>
        /// <param name="gene"></param>
        /// <returns></returns>
        IGEPGene Add(IGEPGene gene);

        /// <summary>
        /// Converts this IGEPChromosome to its corresponding IDebuggableChromosome. An IDebuggableChromosome is an IChromosome that 
        /// treats the IChromosome's IGenes as a "program". An IDebuggableChromosome can be "stepped" into.
        /// </summary>
        /// <returns></returns>
        IDebuggableChromosome ToDebuggableChromosome(IGEPChromosomeSurroundings surroundings);
    }
}
