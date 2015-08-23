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
    /// on the Current Generation of an IEnvironment.
    /// </summary>
    public class EndAfterGenerationsEvaluator : IEndCriteriaEvaluator
    {
        /// <summary>
        /// When this generation is reached by the calling IEnvironment, the 
        /// End Criteria will be met.
        /// </summary>
        public int GenerationAtWhichToEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="generationAtWhichToEnd">When this generation is reached by the calling IEnvironment, the 
        /// End Criteria will be met.</param>
        public EndAfterGenerationsEvaluator(int generationAtWhichToEnd)
        {
            this.GenerationAtWhichToEnd = generationAtWhichToEnd;
        }

        /// <summary>
        /// Evaluates End Criteria based
        /// on the Current Generation of an IEnvironment.
        /// </summary>
        /// <param name="population"></param>
        /// <returns></returns>
        public bool HasMetEndCriteria(IPopulation population)
        {
            return population.ParentIEnvironment.CurrentGeneration >= this.GenerationAtWhichToEnd;
        }
    }
}
