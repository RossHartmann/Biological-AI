using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings
{
    public interface IGEPChromosomeSurroundings : IChromosomeSurroundings
    {
        /// <summary>
        /// The data passed to the parent IGEPOrganism.
        /// </summary>
        new IGEPSurroundings OrganismSurroundings { get; }
    }
}
