using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms;

namespace GeneticFaraday.Contracts.Environment.GeneticOperators.SelectionOperators
{
    public interface ISelectionOperator : IGeneticOperator
    {
        /// <summary>
        /// Selects an IOrganism from the given IPopulation.
        /// </summary>
        /// <param name="population"></param>
        /// <returns></returns>
        IOrganism Execute(IPopulation population);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectionOperators"></param>
        void CalculateChanceOfUse(IEnumerable<ISelectionOperator> selectionOperators);
    }
}
