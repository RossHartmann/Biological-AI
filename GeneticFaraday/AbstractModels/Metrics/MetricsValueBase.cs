using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Metrics;

namespace GeneticFaraday.AbstractModels.Metrics
{
    public abstract class MetricsValueBase : IMetricsValue
    {
        public abstract IMetricsValue ShallowCopy();

        /// <summary>
        /// The unique identifier of this IMetricsValue.
        /// </summary>
        public IMetricsValueIdentifier Identifier { get; set; }

        /// <summary>
        /// The Value of the Metric.
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// The value measured proportionally to the other IOrganisms in the IPopulation.
        /// If there are 3 IOrganisms in the IPopulation with an IMetricsValue of 3, 5, and 7 
        /// then the Proportions (respectively) would be 3/15, 5/15, 7/15. 
        /// </summary>
        public double Proportion { get; set; }

        /// <summary>
        /// Calculated by enumerating through each IOrganism in the IPopulation and summing the Proportions for
        /// this IMetricValue and then setting the ProportionSumInPopulation to the current ProportionSum.
        /// 
        /// This basically sets up a pie graph so that you can pick a double between 0.0 and 1.0 and the IOrganism
        /// with the most valuable IMetricValue will most likely be chosen because it will occupy the largest piece 
        /// of the pie. We use this with roulette selection.
        /// 
        /// If we select a double between 0.0 and 1.0, we can go through each of the IOrganisms and see which IOrganism
        /// has a ProportionSumInPopulation less than or equal to our number. That IOrganism is the chosen 
        /// IOrganism. (Helpful while executing ISelectionOperators)
        /// </summary>
        public double ProportionSumInPopulation { get; set; }
    }
}
