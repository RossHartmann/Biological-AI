using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Environment.GeneticOperators;
using GeneticFaraday.Contracts.Environment.GeneticOperators.SelectionOperators;
using GeneticFaraday.Contracts.Organisms;

namespace GeneticFaraday.AbstractModels.Environment.GeneticOperators.SelectionOperators
{
    public abstract class SelectionOperatorBase : GeneticOperatorBase, ISelectionOperator
    {
        /// <summary>
        /// 
        /// </summary>
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
        protected SelectionOperatorBase(int chanceOfUseRating) : 
            base(chanceOfUseRating)
        {
        }

        /// <summary>
        /// Selects an IOrganism from the given IPopulation.
        /// </summary>
        /// <param name="population"></param>
        /// <returns></returns>
        public abstract IOrganism Execute(IPopulation population);

        public virtual void CalculateChanceOfUse(IEnumerable<ISelectionOperator> selectionOperators)
        {
            base.CalculateChanceOfUse(selectionOperators);
        }
    }
}
