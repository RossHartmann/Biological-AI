using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;

namespace GeneticFaraday.Contracts.Organisms.Chromosomes
{
    public interface IChromosome : IShallowCopyable<IChromosome>, IGeneCollection
    {
        /// <summary>
        /// The parent of the IChromosome.
        /// </summary>
        IOrganism Parent { get; set; }

        /// <summary>
        /// The IEnvironment to which the IChromosome belongs.
        /// </summary>
        IEnvironment ParentEnvironment { get; }

        /// <summary>
        /// Returns the unique IGeneIdentifier of all of the IGenes
        /// that belong to this IChromosome. If no IGenes belong to this IChromosome, the
        /// resulting IEnumerable will be empty.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IGeneIdentifier> GetIdentifiersOfGenes();

        /// <summary>
        /// Assigns unique IGeneIdentifiers to each IGene in this IChromosome.
        /// </summary>
        void AssignGeneIdentifiers();

        /// <summary>
        /// Given the IChromosome's immediate surroundings (i.e. the "input"), 
        /// "Runs" the IChromosome which results in its Behavior (i.e. the "ouput").
        /// </summary>
        /// <param name="surroundings"></param>
        /// <returns></returns>
        IChromosomeBehavior Behave(IChromosomeSurroundings surroundings);

        /// <summary>
        /// Gets all of the IGenes that belong to this IChromosome.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IGene> GetGenes();
    }
}

