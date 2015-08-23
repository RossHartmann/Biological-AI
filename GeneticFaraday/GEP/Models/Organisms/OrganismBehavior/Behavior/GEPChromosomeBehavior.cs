using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Organisms.OrganismBehavior.Behavior;

namespace GeneticFaraday.GEP.Models.Organisms.OrganismBehavior.Behavior
{
    public class GEPChromosomeBehavior : GEPChromosomeBehaviorBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="success">Indicates whether the run of the IGEPChromosome was a success.
        /// 
        /// It might not be a success if a max level of recursion is reached or
        /// perhaps if the IGEPChromosome did not reach some minimum fitness.</param>
        public GEPChromosomeBehavior(bool success) 
            : base(success)
        {
        }
    }
}
