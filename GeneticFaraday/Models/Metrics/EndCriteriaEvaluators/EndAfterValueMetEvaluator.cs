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
    /// Meets end criteria when the Value IMetricValue has reached
    /// a specified value.
    /// </summary>
    public class EndAfterValueMetEvaluator : IEndCriteriaEvaluator
    {
        /// <summary>
        /// The value that the "Value" IMetricsValue must reach in order for
        /// the end criteria to have been met.
        /// </summary>
        public double Value { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value that the "Value" IMetricsValue must reach in order for
        /// the end criteria to have been met.</param>
        public EndAfterValueMetEvaluator(double value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Evaluates End Criteria based on the Value of the IOrganisms' "Value" IMetricValue.
        /// </summary>
        /// <param name="population"></param>
        /// <returns></returns>
        public bool HasMetEndCriteria(IPopulation population)
        {
            return population.Any(o => o.Metrics.Value.Value >= this.Value);
        }
    }
}
