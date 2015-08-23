using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms;

namespace GeneticFaraday.Contracts.Environment.GeneticOperators.MutationOperators
{
    public interface IMutationOperator : IGeneticOperator
    {
        /// <summary>
        /// Executes the Mutation on the given IOrganism.
        /// </summary>
        /// <param name="organism">The IOrganism to mutate.</param>
        void Execute(ref IOrganism organism);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mutationOperators"></param>
        void CalculateChanceOfUse(IEnumerable<IMutationOperator> mutationOperators);
    }
}
