using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Metrics;
using GeneticFaraday.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genomes;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.Contracts.Organisms.Phenomes;
using GeneticFaraday.GEP.Contracts.Organisms.Chromosomes;

namespace GeneticFaraday.Contracts.Organisms
{
    public interface IOrganism : IShallowCopyable<IOrganism>, IChromosomeCollection
    {
        /// <summary>
        /// The parent of the IOrganism.
        /// </summary>
        IEnvironment Parent { get; set; }

        /// <summary>
        /// Returns the next unique identifier for an IGene in this IOrganism.
        /// </summary>
        /// <returns></returns>
        IGeneIdentifier GetNextUniqueGeneIdentifier();

        /// <summary>
        /// Assigns unique IGeneIdentifier to each IGene in each IChromosome in 
        /// this IOrganism.
        /// </summary>
        void AssignGeneIdentifiers();

        /// <summary>
        /// The Metrics used to measure the "value" of the IOrganism.
        /// </summary>
        IMetrics Metrics { get; set; }

        /// <summary>
        /// Given the IOrganism's immediate surroundings (i.e. the "input"), 
        /// Makes the IOrganism "live" which results in its Behavior (i.e. the "ouput").
        /// </summary>
        /// <returns></returns>
        IBehavior Behave(ISurroundings surroundings);

        /// <summary>
        /// Gets all of the IChromosomes that belong to this IOrganism.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IChromosome> GetChromosomes();

        /// <summary>
        /// Converts this IOrganism to its corresponding IGenome.
        /// </summary>
        /// <returns></returns>
        IGenome ToGenome();

        /// <summary>
        /// Converts this IOrganism to its corresponding IPhenome.
        /// </summary>
        /// <returns></returns>
        IPhenome ToPhenome(ISurroundings surroundings);
    }
}
