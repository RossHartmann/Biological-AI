using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Organisms.Chromosomes
{
    public interface IChromosomeCollection : IList<IChromosome>
    {
        /// <summary>
        /// Adds the specified IChromosome to the IChromosomeCollection.
        /// </summary>
        /// <param name="chromosome"></param>
        /// <returns>The added IChromosome.</returns>
        new IChromosome Add(IChromosome chromosome);
    }
}
