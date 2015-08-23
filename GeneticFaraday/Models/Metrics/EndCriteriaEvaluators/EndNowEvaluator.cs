using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Metrics;

namespace GeneticFaraday.Models.Metrics.EndCriteriaEvaluators
{
    /// <summary>
    /// Always returns true for HasMetEndCriteria()
    /// </summary>
    public class EndNowEvaluator : IEndCriteriaEvaluator
    {
        public bool HasMetEndCriteria(IPopulation population)
        {
            return true;
        }
    }
}
