using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Metrics.Events;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;

namespace GeneticFaraday.Contracts.Metrics
{
    /// <summary>
    /// The IMetricEvaluator is used to evaluate an IOrganism in order to determine
    /// its IMetrics.
    /// </summary>
    public interface IMetricsEvaluator : ISimilarityComparer
    {
        /// <summary>
        /// Gets the IMetrics of the IOrganism.
        /// </summary>
        /// <returns></returns>
        IMetrics GetMetrics(IOrganism organism);

        /// <summary>
        /// Gets the IComparer used to compare two IOrganisms with the IMetricsValue as specified by the given IMetricsValueIdentifier.
        /// </summary>
        /// <param name="metricsValueIdentifier"></param>
        /// <returns></returns>
        IComparer<IOrganism> GetComparerForIMetricsValue(IMetricsValueIdentifier metricsValueIdentifier); 

        /// <summary>
        /// Occurs when an IOrganism starts being evaluated by this IMetricsEvaluator.
        /// </summary>
        event EventHandler<StartMetricsEvaluationEventArgs> EvaluationStart;

        /// <summary>
        /// Occurs when an IOrganism is done being evaluated by this IMetricsEvaluator.
        /// </summary>
        event EventHandler<EndMetricsEvaluationEventArgs> EvaluationEnd;
    }
}
