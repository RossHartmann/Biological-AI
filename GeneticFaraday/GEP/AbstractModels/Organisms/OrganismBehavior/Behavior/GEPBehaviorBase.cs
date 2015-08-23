using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.OrganismBehavior.Behaviors;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Behavior;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.OrganismBehavior.Behavior
{
    public abstract class GEPBehaviorBase : BehaviorBase, IGEPBehavior
    {
        /// <summary>
        /// Indicates whether the run of the IGEPOrganism was a success.
        /// 
        /// It might not be a success if a max level of recursion is reached or
        /// perhaps if the IGEPOrganism did not reach some minimum fitness.
        /// </summary>
        public bool Success { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="success">Indicates whether the run of the IGEPOrganism was a success.
        /// 
        /// It might not be a success if a max level of recursion is reached or
        /// perhaps if the IGEPOrganism did not reach some minimum fitness.</param>
        protected GEPBehaviorBase(bool success)
        {
            this.Success = success;
        }
    }
}
