using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings
{
    public interface IChromosomeSurroundings
    {
        /// <summary>
        /// The data passed to the parent IOrganism.
        /// </summary>
        ISurroundings OrganismSurroundings { get; }
    }
}
