using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment.Events;
using GeneticFaraday.Contracts.Metrics;
using GeneticFaraday.Contracts.Organisms;

namespace GeneticFaraday.Contracts.Environment
{
    /// <summary>
    /// An IPopulation is an Enumeration of IOrganisms
    /// </summary>
    public interface IPopulation : IList<IOrganism>
    {
        /// <summary>
        /// The IEnvironment to which the IPopulation belongs.
        /// </summary>
        IEnvironment ParentIEnvironment { get; }

        /// <summary>
        /// Adds the specified IOrganism to the IPopulation.
        /// </summary>
        /// <param name="organism"></param>
        /// <returns>The added IOrganism.</returns>
        new IOrganism Add(IOrganism organism);

        /// <summary>
        /// Initializes the IOrganisms in this IPopulation.
        /// </summary>
        void InitializePopulation(IEnvironmentState environmentState);

        /// <summary>
        /// Occurs when the Population is initialized.
        /// </summary>
        event EventHandler<PopulationInitializedEventArgs> PopulationInitialized; 

        /// <summary>
        /// Sorts this IPopulation by each of the IPopulation's IOrganism's
        /// Value from the lowest Value (element 0) to the highest Value (element n).
        /// </summary>
        void SortByValueAscending();

        /// <summary>
        /// Calculates the IMetrics of each of the IOrganisms in this IPopulation
        /// using the given IMetricsEvaluator.
        /// </summary>
        void CalculateMetrics(IMetricsEvaluator metricsEvaluator);

        /// <summary>
        /// Sets the Proportion and ProportionSumInPopulation for each of the IMetricsValues in 
        /// the IMetrics for each of the IOrganisms in this IPopulation.
        /// </summary>
        void SetIMetricsValueProportions();

        /// <summary>
        /// Returns the most valuable IOrganism in this IPopulation.
        /// </summary>
        /// <returns>The most valuable IOrganism in this IPopulation.</returns>
        IOrganism GetMostValuableOrganism();
    }
}
