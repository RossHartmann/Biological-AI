using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment.GeneticOperators.InitializationOperators;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.GEP.Contracts.Organisms;

namespace GeneticFaraday.GEP.Contracts.Environment.GeneticOperators.InitializationOperators
{
    public interface IGEPInitializationOperator : IInitializationOperator
    {
        /// <summary>
        /// Creates (i.e. initializes) one or more IGEPOrganisms.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
        List<IGEPOrganism> Execute(IGEPEnvironment environment);
    }
}
