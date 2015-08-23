using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Organisms.OrganismBehavior;
using GeneticFaraday.GEP.AbstractModels.Organisms.OrganismBehavior.Behavior;

namespace GeneticFaraday.GEP.Models.Organisms.OrganismBehavior.Behavior
{
    public class GEPGeneBehavior : GEPGeneBehaviorBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="success">Indicates whether the run of the IGEPGene was a success.
        /// 
        /// It might not be a success if a max level of recursion is reached or
        /// perhaps if the IGEPGene did not reach some minimum fitness.</param>
        public GEPGeneBehavior(bool success) 
            : base(success)
        {
        }
    }
}
