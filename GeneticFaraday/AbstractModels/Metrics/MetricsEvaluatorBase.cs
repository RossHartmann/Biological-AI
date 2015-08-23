using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Metrics;
using GeneticFaraday.Contracts.Metrics.Events;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;

namespace GeneticFaraday.AbstractModels.Metrics
{
    public abstract class MetricsEvaluatorBase : IMetricsEvaluator
    {
        /// <summary>
        /// A Dictionary of the IComparer for each IMetricsValue as identified by the IMetricsValueIdentifier key.
        /// </summary>
        protected Dictionary<IMetricsValueIdentifier, IComparer<IOrganism>> MetricsValueComparers { get; set; } 

        protected MetricsEvaluatorBase()
        {
            this.MetricsValueComparers = new Dictionary<IMetricsValueIdentifier, IComparer<IOrganism>>();
        }

        /// <summary>
        /// Gets the IMetrics of the IOrganism.
        /// 
        /// Calls EvaluationStart at its beginning and EvaluationEnd at its end.
        /// </summary>
        /// <returns></returns>
        public abstract IMetrics GetMetrics(IOrganism organism);

        /// <summary>
        /// Gets the IComparer used to compare two IOrganisms with the IMetricsValue as specified by the given IMetricsValueIdentifier.
        /// </summary>
        /// <param name="metricsValueIdentifier"></param>
        /// <returns></returns>
        public IComparer<IOrganism> GetComparerForIMetricsValue(IMetricsValueIdentifier metricsValueIdentifier)
        {
            return this.MetricsValueComparers[metricsValueIdentifier];
        }

        /// <summary>
        /// Gets the percentage that IOrganism one and IOrganism two are similar.
        /// 100% would be identical and 0% would indicate that the IOrganisms share nothing.
        /// </summary>
        /// <param name="one">The first IOrganism to compare.</param>
        /// <param name="two">The second IOrganism to compare.</param>
        /// <returns>The percentage that IOrganism one and IOrganism two are similar.
        /// 100% would be identical and 0% would indicate that the IOrganisms share nothing.</returns>
        public abstract double GetPercentageIOrganismSimilarity(IOrganism one, IOrganism two);


        /// <summary>
        /// Gets the percentage that IChromosome one and IChromosome two are similar.
        /// 100% would be identical and 0% would indicate that the IChromosomes share nothing.
        /// </summary>
        /// <param name="one">The first IChromosome to compare.</param>
        /// <param name="two">The second IChromosome to compare.</param>
        /// <returns>The percentage that IChromosome one and IChromosome two are similar.
        /// 100% would be identical and 0% would indicate that the IChromosomes share nothing.</returns>
        public abstract double GetPercentageIChromosomeSimilarity(IChromosome one, IChromosome two);

        /// <summary>
        /// Gets the percentage that IGene one and IGene two are similar.
        /// 100% would be identical and 0% would indicate that the IGenes share nothing.
        /// </summary>
        /// <param name="one">The first IGene to compare.</param>
        /// <param name="two">The second IGene to compare.</param>
        /// <returns>The percentage that IGene one and IGene two are similar.
        /// 100% would be identical and 0% would indicate that the IGenes share nothing.</returns>
        public abstract double GetPercentageIGeneSimilarity(IGene one, IGene two);

        /// <summary>
        /// Gets the percentage that IAllele one and IAllele two are similar.
        /// 100% would be identical and 0% would indicate that the IAlleles share nothing.
        /// </summary>
        /// <param name="one">The first IAllele to compare.</param>
        /// <param name="two">The second IAllele to compare.</param>
        /// <returns>The percentage that IAllele one and IAllele two are similar.
        /// 100% would be identical and 0% would indicate that the IAlleles share nothing.</returns>
        public abstract double GetPercentageIAlleleSimilarity(IAllele one, IAllele two);


        /// <summary>
        /// Occurs when an IOrganism starts being evaluated by this IMetricsEvaluator.
        /// </summary>
        public event EventHandler<StartMetricsEvaluationEventArgs> EvaluationStart;
        protected void OnEvaluationStart(StartMetricsEvaluationEventArgs e)
        {
            if (this.EvaluationStart != null)
                this.EvaluationStart(this, e);
        }

        /// <summary>
        /// Occurs when an IOrganism is done being evaluated by this IMetricsEvaluator.
        /// </summary>
        public event EventHandler<EndMetricsEvaluationEventArgs> EvaluationEnd;
        protected void OnEvaluationEnd(EndMetricsEvaluationEventArgs e)
        {
            if (this.EvaluationEnd != null)
                this.EvaluationEnd(this, e);
        }
    }
}
