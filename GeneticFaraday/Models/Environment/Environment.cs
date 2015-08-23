using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Environment;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Metrics;
using GeneticFaraday.Contracts.Organisms;

namespace GeneticFaraday.Models.Environment
{
    public class Environment : EnvironmentBase
    {
        public Environment(IEnvironmentIdentifier identifier, IEnvironmentState state,
            IMetricsEvaluator metricsEvaluator, IEndCriteriaEvaluator endCriteriaEvaluator,
            IComparer<IOrganism> organismValueComparer) :
            base(identifier, state, metricsEvaluator, endCriteriaEvaluator, organismValueComparer)
        {
        }

    }
}
