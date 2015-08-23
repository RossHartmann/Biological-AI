using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms;

namespace GeneticFaraday.Contracts.Environment.GeneticOperators.InitializationOperators
{
    public interface IInitializationOperator : IGeneticOperator
    {
        /// <summary>
        /// Creates (i.e. initializes) one or more IOrganisms.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
        List<IOrganism> Execute(IEnvironment environment);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initializationOperators"></param>
        void CalculateChanceOfUse(IEnumerable<IInitializationOperator> initializationOperators);
    }
}
