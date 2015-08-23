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
    /// Meets end criteria when the specified IMetricValue has reached
    /// a specified value.
    /// </summary>
    public class EndAfterMetricValueMetEvaluator : IEndCriteriaEvaluator
    {
        /// <summary>
        /// The Metric Value of interest.
        /// </summary>
        public IMetricsValueIdentifier MetricValueIdentifier { get; private set; }

        /// <summary>
        /// The value that the IMetricsValue must reach in order for
        /// the end criteria to have been met.
        /// </summary>
        public double Value { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="metricValueIdentifier">The Metric Value of interest.</param>
        /// <param name="value">The value that the IMetricsValue must reach in order for
        /// the end criteria to have been met.</param>
        public EndAfterMetricValueMetEvaluator(IMetricsValueIdentifier metricValueIdentifier, double value)
        {
            this.MetricValueIdentifier = metricValueIdentifier;
            this.Value = value;
        }

        /// <summary>
        /// Evaluates End Criteria based on the IMetricValue of the IOrganisms.
        /// </summary>
        /// <param name="population"></param>
        /// <returns></returns>
        public bool HasMetEndCriteria(IPopulation population)
        {
            return population.Any(o => o.Metrics[this.MetricValueIdentifier].Value >= this.Value);
        }
    }
}
