using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Environment.GeneticOperators;
using GeneticFaraday.Contracts.Environment.GeneticOperators.InitializationOperators;
using GeneticFaraday.Contracts.Organisms;

namespace GeneticFaraday.AbstractModels.Environment.GeneticOperators.InitializationOperators
{
    public abstract class InitializationOperatorBase : GeneticOperatorBase, IInitializationOperator
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
        protected InitializationOperatorBase(int chanceOfUseRating) : 
            base(chanceOfUseRating)
        {
        }

        /// <summary>
        /// Creates (i.e. initializes) one or more IOrganisms.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
        public abstract List<IOrganism> Execute(IEnvironment environment);

        public virtual void CalculateChanceOfUse(IEnumerable<IInitializationOperator> initializationOperators)
        {
            base.CalculateChanceOfUse(initializationOperators);
        }
    }
}
