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
    /// An IEndCriteriaEvaluator that evaluates End Criteria based
    /// on the Current Elapsed Time of an IEnvironment.
    /// </summary>
    public class EndAfterElapsedTimeEvaluator : IEndCriteriaEvaluator
    {
        /// <summary>
        /// When this Elapsed Time Span is reached by the calling IEnvironment, the 
        /// End Criteria will be met.
        /// </summary>
        public TimeSpan ElapsedTimeSpan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elapsedTimeSpan">When this Elapsed Time Span is reached by the calling IEnvironment, the 
        /// End Criteria will be met.</param>
        public EndAfterElapsedTimeEvaluator(TimeSpan elapsedTimeSpan)
        {
            this.ElapsedTimeSpan = elapsedTimeSpan;
        }

        /// <summary>
        /// Evaluates End Criteria based
        /// on the Current Elapsed Time of an IEnvironment.
        /// </summary>
        /// <param name="population"></param>
        /// <returns></returns>
        public bool HasMetEndCriteria(IPopulation population)
        {
            return population.ParentIEnvironment.Stopwatch.Elapsed.CompareTo(this.ElapsedTimeSpan) <= 0;
        }
    }
}
