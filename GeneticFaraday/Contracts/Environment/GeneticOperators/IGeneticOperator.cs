using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Environment.GeneticOperators
{
    /// <summary>
    /// An IGeneticOperator is an Operator used by the Genetic Algorithm.
    /// </summary>
    public interface IGeneticOperator
    {
        /// <summary>
        /// This is simply a number which indicates the relative chance that this
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
        /// will be chosen.
        /// </summary>
        int ChanceOfUseRating { get; }

        /// <summary>
        /// The chance that this IGeneticOperator will be chosen among other IGeneticOperators
        /// of its same type (such as among all of the other ISelectionOperators)
        /// 
        /// Between 0 and 1. 1 being 100% and 0 being 0%.
        /// </summary>
        double ChanceOfUse { get; }

        /// <summary>
        /// The "position" of this IGeneticOperator in relation to all other IGeneticOperators.
        /// Used when determining whether this IGeneticOperator will be used. 
        /// If we have 3 IGeneticOperators and one has a 20% the other has a 30% and the
        /// other has a 50% then the ChanceOfUseSumPosition of each of those IGeneticOperators
        /// (respectively) is 20, 50, 100 (calculated by going through each IGeneticOperator
        /// and adding its ChanceOfUse)
        /// </summary>
        double ChanceOfUseSumPosition { get; set; }

        void CalculateChanceOfUse(IEnumerable<IGeneticOperator> initializationOperators);
    }
}
