using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Environment.GeneticOperators.RecombinationOperators;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.GEP.Contracts.Environment.GeneticOperators.RecombinationOperators;
using GeneticFaraday.GEP.Contracts.Organisms;

namespace GeneticFaraday.GEP.AbstractModels.Environment.GeneticOperators.RecombinationOperators
{
    public abstract class GEPRecombinationOperatorBase : RecombinationOperatorBase, IGEPRecombinationOperator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parentsToRecombineCount">The number of parent IOrganisms that will be passed to 
        /// the Execute method.</param>
        /// <param name="chanceOfUseRating"></param>
        protected GEPRecombinationOperatorBase(int parentsToRecombineCount, int chanceOfUseRating) 
            : base(parentsToRecombineCount, chanceOfUseRating)
        {
        }
    }
}
