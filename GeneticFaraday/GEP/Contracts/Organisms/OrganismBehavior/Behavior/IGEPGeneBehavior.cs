using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Behavior;

namespace GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Behavior
{
    public interface IGEPGeneBehavior : IGeneBehavior
    {
        /// <summary>
        /// Indicates whether the run of the IGEPGene was a success.
        /// 
        /// It might not be a success if a max level of recursion is reached or
        /// perhaps if the IGEPGene did not reach some minimum fitness.
        /// </summary>
        bool Success { get; }
    }
}
