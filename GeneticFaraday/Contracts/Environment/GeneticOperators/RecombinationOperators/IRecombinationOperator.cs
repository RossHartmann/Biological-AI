using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment.GeneticOperators.MutationOperators;
using GeneticFaraday.Contracts.Organisms;

namespace GeneticFaraday.Contracts.Environment.GeneticOperators.RecombinationOperators
{
    public interface IRecombinationOperator : IGeneticOperator
    {
        /// <summary>
        /// The number of parent IOrganisms that will be passed to 
        /// the Execute method.
        /// </summary>
        int ParentsToRecombineCount { get; }

        /// <summary>
        /// Recombines the given parent IOrganisms to produce the 
        /// returned IOrganisms.
        /// </summary>
        /// <param name="parents"></param>
        /// <returns></returns>
        List<IOrganism> Execute(List<IOrganism> parents);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recombinationOperators"></param>
        void CalculateChanceOfUse(IEnumerable<IMutationOperator> recombinationOperators);
    }
}
