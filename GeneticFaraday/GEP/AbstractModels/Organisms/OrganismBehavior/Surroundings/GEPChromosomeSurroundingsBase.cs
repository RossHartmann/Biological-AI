using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.OrganismBehavior.Surroundings
{
    public abstract class GEPChromosomeSurroundingsBase : ChromosomeSurroundingsBase, IGEPChromosomeSurroundings
    {
        /// <summary>
        /// The data passed to the parent IGEPOrganism.
        /// </summary>
        new public IGEPSurroundings OrganismSurroundings { get { return (IGEPSurroundings)base.OrganismSurroundings; } }

        protected GEPChromosomeSurroundingsBase(IGEPSurroundings organismSurroundings) 
            : base(organismSurroundings)
        {
        }
    }
}
