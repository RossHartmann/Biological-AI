using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;

namespace GeneticFaraday.GEP.Models.Organisms.OrganismBehavior.Surroundings
{
    public class GEPChromosomeSurroundings : GEPChromosomeSurroundingsBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="organismSurroundings">The data passed to the parent IGEPOrganism.</param>
        public GEPChromosomeSurroundings(IGEPSurroundings organismSurroundings) 
            : base(organismSurroundings)
        {
        }
    }
}
