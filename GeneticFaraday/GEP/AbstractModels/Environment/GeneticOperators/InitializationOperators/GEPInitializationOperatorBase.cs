using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Environment.GeneticOperators.InitializationOperators;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Environment.GeneticOperators.InitializationOperators;
using GeneticFaraday.GEP.Contracts.Organisms;

namespace GeneticFaraday.GEP.AbstractModels.Environment.GeneticOperators.InitializationOperators
{
    public abstract class GEPInitializationOperatorBase : InitializationOperatorBase, IGEPInitializationOperator
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
        protected GEPInitializationOperatorBase(int chanceOfUseRating) 
            : base(chanceOfUseRating)
        {
        }

        /// <summary>
        /// The given IEnvironment must be an IGEPEnvironment.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
        public override List<IOrganism> Execute(IEnvironment environment)
        {
            return this.Execute((IGEPEnvironment) environment).Cast<IOrganism>().ToList();
        }

        /// <summary>
        /// Creates (i.e. initializes) one or more IGEPOrganisms.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
        public abstract List<IGEPOrganism> Execute(IGEPEnvironment environment);
    }
}








