using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Metrics;

namespace GeneticFaraday.AbstractModels.Metrics
{
    public abstract class EndCriteriaEvaluatorBase : IEndCriteriaEvaluator
    {
        public abstract bool HasMetEndCriteria(IPopulation population);
    }
}
