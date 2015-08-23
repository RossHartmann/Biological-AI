using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;

namespace GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings
{
    public interface IGeneSurroundings
    {
        /// <summary>
        /// The data passed to the parent IChromosome.
        /// </summary>
        IChromosomeSurroundings ChromosomeSurroundings { get; }
    }
}
