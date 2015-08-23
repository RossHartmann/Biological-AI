using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment.GeneticOperators;
using GeneticFaraday.Contracts.Environment.GeneticOperators.MutationOperators;
using GeneticFaraday.Contracts.Environment.GeneticOperators.RecombinationOperators;
using GeneticFaraday.Contracts.Organisms;

namespace GeneticFaraday.AbstractModels.Environment.GeneticOperators.RecombinationOperators
{
    public abstract class RecombinationOperatorBase : GeneticOperatorBase, IRecombinationOperator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parentsToRecombineCount">The number of parent IOrganisms that will be passed to 
        /// the Execute method.</param>
        /// <param name="chanceOfUseRating">This is simply a number which indicates the relative chance that this
        /// IGeneticOperator will be used among the list of all of the possible
        /// IGeneticOperator of its type.
        /// 
        /// To determine the real percentage chance that this IGeneticOperator
        /// will be chosen, we sum all of the IGeneticOperator's ChanceOfUseRating then
        /// we divide this ChanceOfUseRating by the total ChanceOfUseRating of all 
        /// IGeneticOperators of its type.
        /// 
        /// This is simply a number such as 15. (This does not mean that it will be chosen
        /// 15% of the time). If there is only one other GeneticOperator and its
        /// ChanceOfUseRating is 15 then both of their chances is 50% (15/30)
        /// 
        /// See the ChanceOfUse for the percentage of the time that this GeneticOperator
        /// will be chosen.</param>
        protected RecombinationOperatorBase(int parentsToRecombineCount, int chanceOfUseRating) : 
            base(chanceOfUseRating)
        {
            this.ParentsToRecombineCount = parentsToRecombineCount;
        }

        /// <summary>
        /// The number of parent IOrganisms that will be passed to 
        /// the Execute method.
        /// </summary>
        public int ParentsToRecombineCount { get; private set; }

        /// <summary>
        /// Recombines the given parent IOrganisms to produce the 
        /// returned IOrganisms.
        /// </summary>
        /// <param name="parents"></param>
        /// <returns></returns>
        public abstract List<IOrganism> Execute(List<IOrganism> parents);

        public virtual void CalculateChanceOfUse(IEnumerable<IMutationOperator> recombinationOperators)
        {
            base.CalculateChanceOfUse(recombinationOperators);
        }
    }
}
