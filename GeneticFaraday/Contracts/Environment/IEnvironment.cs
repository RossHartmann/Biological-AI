using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using GeneticFaraday.Contracts.Environment.Events;
using GeneticFaraday.Contracts.Metrics;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Universe;

namespace GeneticFaraday.Contracts.Environment
{
    /// <summary>
    /// The IEnvironment contains the environmentally-specific information.
    /// 
    /// The IEnvironment will not contain GA global constants or global methods.
    /// Those will be contained in the IUniverse.
    /// </summary>
    public interface IEnvironment : IPopulation
    {
        /// <summary>
        /// The parent IUniverse of the IEnvironment.
        /// </summary>
        IUniverse Parent { get; set; }

        /// <summary>
        /// The IGeneticCode to which all IOrganisms in this IEnvironment adhere.
        /// </summary>
        IGeneticCode GeneticCode { get; }

        /// <summary>
        /// The Current Generation of the IEnvironment.
        /// </summary>
        int CurrentGeneration { get; }

        /// <summary>
        /// The Stopwatch that tracks the elapsed time of the IEnvironment.
        /// </summary>
        Stopwatch Stopwatch { get; }

        /// <summary>
        /// The State of the Environment.
        /// </summary>
        IEnvironmentState State { get; }

        /// <summary>
        /// The Identifier of the IEnvironment
        /// </summary>
        IEnvironmentIdentifier Identifier { get; }

        /// <summary>
        /// Used to evaluate the IOrganisms in the IPopulation.
        /// 
        /// This essentially contains the "Fitness Function", the "Novelty Function",
        /// the "Complexity Function, etc.
        /// </summary>
        IMetricsEvaluator MetricsEvaluator { get; }

        /// <summary>
        /// Used to evaluate whether the search has reached its End Criteria.
        /// </summary>
        IEndCriteriaEvaluator EndCriteriaEvaluator { get; }

        /// <summary>
        /// Compares two IOrganisms by their value.
        /// </summary>
        IComparer<IOrganism> OrganismValueComparer { get; }

        /// <summary>
        /// Initializes the IEnvironment.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Runs the search until the End Criteria is met according to the IEndCriteriaEvaluator.
        /// </summary>
        void Run();

        /// <summary>
        /// Stops the IEnvironment during its run.
        /// </summary>
        void Stop();

        /// <summary>
        /// Runs 1 generation of the IOrganisms in the IPopulation.
        /// </summary>
        void RunGeneration();

        /// <summary>
        /// Selects a set number of IOrganisms using randomly chosen ISelectionOperators.
        /// 
        /// Gets shallow copies of the chosen IOrganisms.
        /// </summary>
        /// <param name="individualsToSelectCount">The number of individuals to select.</param>
        /// <returns></returns>
        List<IOrganism> SelectIOrganisms(int individualsToSelectCount);

        /// <summary>
        /// Mutates the given IOrganism.
        /// </summary>
        /// <param name="organism"></param>
        void MutateIOrganism(ref IOrganism organism);

        /// <summary>
        /// Recombines a number of IOrganisms in this IEnvironment's IPopulation and returns
        /// the recombined IOrganisms.
        /// 
        /// Returns shallow copies of the recombined IOrganisms.
        /// </summary>
        /// <returns></returns>
        List<IOrganism> RecombineIOrganisms();

        /// <summary>
        /// Initializes a number of IOrganisms in this IEnvironment's IPopulation and returns
        /// the newly initialized IOrganisms.
        /// </summary>
        /// <returns></returns>
        List<IOrganism> InitializeIOrganisms();

        
        /// <summary>
        /// Occurs when the Environment is done being initialized.
        /// </summary>
        event EventHandler<EnvironmentInitializedEventArgs> EnvironmentInitialized;

        /// <summary>
        /// Occurs when the Environment begins running (before being initialized).
        /// </summary>
        event EventHandler<EnvironmentStartEventArgs> EnvironmentStart;

        /// <summary>
        /// Occurs when the End Criteria is met according to the IEndCriteriaEvaluator.
        /// </summary>
        event EventHandler<EnvironmentEndEventArgs> EnvironmentEnd;

        /// <summary>
        /// Occurs when a new Generation begins.
        /// </summary>
        event EventHandler<GenerationStartEventArgs> GenerationStart;

        /// <summary>
        /// Occurs when the current Generation ends.
        /// </summary>
        event EventHandler<GenerationEndEventArgs> GenerationEnd;
    }
}
