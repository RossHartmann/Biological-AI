using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;

namespace GeneticFaraday.Contracts.Metrics
{
    /// <summary>
    /// Used to indicate whether the End Criteria for the Search has been met.
    /// </summary>
    public interface IEndCriteriaEvaluator
    {
        /// <summary>
        /// Indicates whether the Search End Criteria has been met.
        /// </summary>
        /// <param name="population"></param>
        /// <returns></returns>
        bool HasMetEndCriteria(IPopulation population);
    }
}
