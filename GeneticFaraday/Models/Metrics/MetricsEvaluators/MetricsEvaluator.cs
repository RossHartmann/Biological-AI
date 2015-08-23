using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Metrics;
using GeneticFaraday.Contracts.Metrics;
using GeneticFaraday.Contracts.Metrics.Events;
using GeneticFaraday.Contracts.Metrics.SimilarityComparers;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;

namespace GeneticFaraday.Models.Metrics.MetricsEvaluators
{
    public class MetricsEvaluator : MetricsEvaluatorBase
    {
        private GetMetrics GetMetricsDelegate { get; set; }
        private GetPercentageIOrganismSimilarity GetPercentageIOrganismSimilarityDelegate { get; set; }
        private GetPercentageIAlleleSimilarity GetPercentageIAlleleSimilarityDelegate { get; set; }
        private GetPercentageIGeneSimilarity GetPercentageIGeneSimilarityDelegate { get; set; }
        private GetPercentageIChromosomeSimilarity GetPercentageIChromosomeSimilarityDelegate { get; set; }

        /// <summary>
        /// Creates an instance of a MetricsEvaluator.
        /// </summary>
        /// <param name="getMetrics">Gets the IMetrics of the IOrganism.
        /// 
        /// No need to call any events in this delegate.</param>
        /// <param name="getPercentageIAlleleSimilarity">Gets the percentage that IAllele one and IAllele two are similar.
        /// 100% would be identical and 0% would indicate that the IAlleles share nothing.</param>
        /// <param name="getPercentageIGeneSimilarity">Gets the percentage that IGene one and IGene two are similar.
        /// 100% would be identical and 0% would indicate that the IGenes share nothing.</param>
        /// <param name="getPercentageIChromosomeSimilarity">Gets the percentage that IChromosome one and IChromosome two are similar.
        /// 100% would be identical and 0% would indicate that the IChromosomes share nothing.</param>
        /// <param name="getPercentageIOrganismSimilarity">Gets the percentage that IOrganism one and IOrganism two are similar.
        /// 100% would be identical and 0% would indicate that the IOrganisms share nothing.</param>
        /// <param name="metricValueComparers">The IComparers for each IMetricsValue as identified by the IMetricsValueIdentifier key.</param>
        public MetricsEvaluator(GetMetrics getMetrics, GetPercentageIAlleleSimilarity getPercentageIAlleleSimilarity,
            GetPercentageIGeneSimilarity getPercentageIGeneSimilarity,
            GetPercentageIChromosomeSimilarity getPercentageIChromosomeSimilarity, 
            GetPercentageIOrganismSimilarity getPercentageIOrganismSimilarity, 
            params KeyValuePair<IMetricsValueIdentifier, IComparer<IOrganism>>[] metricValueComparers)
            : base()
        {
            this.GetMetricsDelegate = getMetrics;
            this.GetPercentageIOrganismSimilarityDelegate = getPercentageIOrganismSimilarity;
            this.GetPercentageIChromosomeSimilarityDelegate = getPercentageIChromosomeSimilarity;
            this.GetPercentageIGeneSimilarityDelegate = getPercentageIGeneSimilarity;
            this.GetPercentageIAlleleSimilarityDelegate = getPercentageIAlleleSimilarity;

            foreach(var pair in metricValueComparers)
                base.MetricsValueComparers.Add(pair.Key, pair.Value);
        }

        

        /// <summary>
        /// Gets the IMetrics of the IOrganism.
        /// 
        /// Calls OnEvaluationStart on start and calls OnEvaluationEnd on end.
        /// </summary>
        /// <returns></returns>
        public override IMetrics GetMetrics(IOrganism organism)
        {
            this.OnEvaluationStart(new StartMetricsEvaluationEventArgs());

            var metrics = this.GetMetricsDelegate(organism: organism);

            this.OnEvaluationEnd(new EndMetricsEvaluationEventArgs());

            return metrics;
        }

        /// <summary>
        /// Gets the percentage that IOrganism one and IOrganism two are similar.
        /// 100% would be identical and 0% would indicate that the IOrganisms share nothing.
        /// </summary>
        /// <param name="one">The first IOrganism to compare.</param>
        /// <param name="two">The second IOrganism to compare.</param>
        /// <returns>The percentage that IOrganism one and IOrgnaism two are similar.
        /// 100% would be identical and 0% would indicate that the IOrganisms share nothing.</returns>
        public override double GetPercentageIOrganismSimilarity(IOrganism one, IOrganism two)
        {
            return this.GetPercentageIOrganismSimilarityDelegate(one: one, two: two);
        }

        /// <summary>
        /// Gets the percentage that IChromosome one and IChromosome two are similar.
        /// 100% would be identical and 0% would indicate that the IChromosomes share nothing.
        /// </summary>
        /// <param name="one">The first IChromosome to compare.</param>
        /// <param name="two">The second IChromosome to compare.</param>
        /// <returns>The percentage that IChromosome one and IChromosome two are similar.
        /// 100% would be identical and 0% would indicate that the IChromosomes share nothing.</returns>
        public override double GetPercentageIChromosomeSimilarity(IChromosome one, IChromosome two)
        {
            return this.GetPercentageIChromosomeSimilarityDelegate(one: one, two: two);
        }

        /// <summary>
        /// Gets the percentage that IGene one and IGene two are similar.
        /// 100% would be identical and 0% would indicate that the IGenes share nothing.
        /// </summary>
        /// <param name="one">The first IGene to compare.</param>
        /// <param name="two">The second IGene to compare.</param>
        /// <returns>The percentage that IGene one and IGene two are similar.
        /// 100% would be identical and 0% would indicate that the IGenes share nothing.</returns>
        public override double GetPercentageIGeneSimilarity(IGene one, IGene two)
        {
            return this.GetPercentageIGeneSimilarityDelegate(one: one, two: two);
        }

        /// <summary>
        /// Gets the percentage that IAllele one and IAllele two are similar.
        /// 100% would be identical and 0% would indicate that the IAlleles share nothing.
        /// </summary>
        /// <param name="one">The first IAllele to compare.</param>
        /// <param name="two">The second IAllele to compare.</param>
        /// <returns>The percentage that IAllele one and IAllele two are similar.
        /// 100% would be identical and 0% would indicate that the IAlleles share nothing.</returns>
        public override double GetPercentageIAlleleSimilarity(IAllele one, IAllele two)
        {
            return this.GetPercentageIAlleleSimilarityDelegate(one: one, two: two);
        }
    }
}
