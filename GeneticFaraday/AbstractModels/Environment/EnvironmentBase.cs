using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Environment.Events;
using GeneticFaraday.Contracts.Environment.GeneticOperators;
using GeneticFaraday.Contracts.Environment.GeneticOperators.MutationOperators;
using GeneticFaraday.Contracts.Metrics;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Universe;
using GeneticFaraday.GEP.Contracts.Organisms;
using GeneticFaraday.GEP.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Models.Exceptions;
using GeneticFaraday.Models.Metrics;
using GeneticFaraday.Models.Metrics.Comparers;
using GeneticFaraday.Models.Metrics.EndCriteriaEvaluators;
using GeneticFaraday.Models.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.Utility;

namespace GeneticFaraday.AbstractModels.Environment
{
    public abstract class EnvironmentBase : List<IOrganism>, IEnvironment
    {
        /// <summary>
        /// The MetricsValueIdentifier used for a Metrics Value used to indicate how fit an IOrganism is according to its behavior.
        /// </summary>
        public static readonly MetricsValueIdentifier FitnessMetricsValue = new MetricsValueIdentifier("Fitness");
        /// <summary>
        /// The MetricsValueIdentifier used for a Metrics Value used to indicate how novel an IOrganism is according to its behavior.
        /// </summary>
        public static readonly MetricsValueIdentifier NoveltyMetricsValue = new MetricsValueIdentifier("Novelty");
        /// <summary>
        /// The MetricsValueIdentifier used for a Metrics Value used to indicate how interesting an IOrganism is according to its behavior.
        /// </summary>
        public static readonly MetricsValueIdentifier InterestingnessMetricsValue = new MetricsValueIdentifier("Interestingness");
        /// <summary>
        /// The MetricsValueIdentifier used for a Metrics Value used to indicate how complex an IOrganism is according to its behavior.
        /// </summary>
        public static readonly MetricsValueIdentifier ComplexityMetricsValue = new MetricsValueIdentifier("Complexity");

        /// <summary>
        /// Compares two IOrganisms by their value.
        /// </summary>
        public IComparer<IOrganism> OrganismValueComparer { get; private set; }

        protected EnvironmentBase(IEnvironmentIdentifier identifier, IEnvironmentState state, 
            IMetricsEvaluator metricsEvaluator, IEndCriteriaEvaluator endCriteriaEvaluator,
            IComparer<IOrganism> organismValueComparer)
        {
            this.Identifier = identifier;
            this.State = state;
            this.MetricsEvaluator = metricsEvaluator;
            this.EndCriteriaEvaluator = endCriteriaEvaluator;
            this.OrganismValueComparer = organismValueComparer;
        }

        #region IPopulation
        
        /// <summary>
        /// Occurs when the Population in the Environment is initialized.
        /// </summary>
        public event EventHandler<PopulationInitializedEventArgs> PopulationInitialized;
        protected void OnPopulationInitialized(PopulationInitializedEventArgs e)
        {
            if (this.PopulationInitialized != null)
                this.PopulationInitialized(this, e);
        }

        public IEnvironment ParentIEnvironment
        {
            get { return this; }
        }

        /// <summary>
        /// Adds the specified IOrganism to this Environment. Sets the IOrganism's Parent
        /// to this IEnvironment.
        /// </summary>
        /// <param name="organism"></param>
        /// <returns>The added IOrganism.</returns>
        new public virtual IOrganism Add(IOrganism organism)
        {
            organism.Parent = this;
            base.Add(organism);
            return organism;
        }

        #endregion

        #region IEnvironment

        /// <summary>
        /// The IUniverse to which this Environment belongs.
        /// </summary>
        public IUniverse Parent { get; set; }

        /// <summary>
        /// The IGeneticCode to which all IOrganisms in this IEnvironment adhere.
        /// </summary>
        public IGeneticCode GeneticCode { get { return this.Parent.GeneticCode; } }

        /// <summary>
        /// The Current Generation of the Population in this Environment.
        /// </summary>
        public int CurrentGeneration { get; protected set; }

        /// <summary>
        /// The Stopwatch that tracks the elapsed time of the IEnvironment.
        /// </summary>
        public Stopwatch Stopwatch { get; protected set; }

        /// <summary>
        /// The State of the Environment.
        /// </summary>
        public IEnvironmentState State { get; protected set; }

        /// <summary>
        /// The Unique Identifier of this IEnvironment.
        /// </summary>
        public IEnvironmentIdentifier Identifier { get; protected set; }

        /// <summary>
        /// Used to evaluate the IOrganisms in the Environment.
        /// 
        /// This essentially contains the "Fitness Function", the "Novelty Function",
        /// the "Complexity Function, etc.
        /// </summary>
        public IMetricsEvaluator MetricsEvaluator { get; protected set; }

        /// <summary>
        /// Used to evaluate whether the search has reached its End Criteria.
        /// </summary>
        public IEndCriteriaEvaluator EndCriteriaEvaluator { get; protected set; }
        
        /// <summary>
        /// Occurs when the Environment is done being initialized.
        /// </summary>
        public event EventHandler<EnvironmentInitializedEventArgs> EnvironmentInitialized;
        protected void OnEnvironmentInitialized(EnvironmentInitializedEventArgs e)
        {
            if (this.EnvironmentInitialized != null)
                this.EnvironmentInitialized(this, e);
        }

        public event EventHandler<EnvironmentStartEventArgs> EnvironmentStart;
        protected void OnEnvironmentStart(EnvironmentStartEventArgs e)
        {
            if (this.EnvironmentStart != null)
                this.EnvironmentStart(this, e);
        }

        /// <summary>
        /// Occurs when the End Criteria is met according to the IEndCriteriaEvaluator.
        /// </summary>
        public event EventHandler<EnvironmentEndEventArgs> EnvironmentEnd;
        protected void OnEnvironmentEnd(EnvironmentEndEventArgs e)
        {
            if (this.EnvironmentEnd != null)
                this.EnvironmentEnd(this, e);
        }

        /// <summary>
        /// Occurs when a new Generation begins.
        /// </summary>
        public event EventHandler<GenerationStartEventArgs> GenerationStart;
        protected void OnGenerationStart(GenerationStartEventArgs e)
        {
            if (this.GenerationStart != null)
                this.GenerationStart(this, e);
        }

        /// <summary>
        /// Occurs when the current Generation ends.
        /// </summary>
        public event EventHandler<GenerationEndEventArgs> GenerationEnd;
        protected void OnGenerationEnd(GenerationEndEventArgs e)
        {
            if (this.GenerationEnd != null)
                this.GenerationEnd(this, e);
        }
        #endregion

        private readonly object EndCriteriaEvaluatorLock = new object();

        /// <summary>
        /// Returns the most valuable IOrganism in this IEnvironment by using this.OrganismValueComparer.
        /// 
        /// The IPopulation does not need to be sorted.
        /// </summary>
        /// <returns>Returns the most valuable IOrganism in this IEnvironment by using this.OrganismValueComparer.
        /// 
        /// The IPopulation does not need to be sorted.</returns>
        public virtual IOrganism GetMostValuableOrganism()
        {
            return this.GetMostValuableOrganism(this.OrganismValueComparer);
        }

        /// <summary>
        /// Gets the most valuable IOrganism in this IEnvironment by using the given IComparer.
        /// </summary>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public virtual IOrganism GetMostValuableOrganism(IComparer<IOrganism> comparer)
        {
            return this.OrderBy(o => o, comparer).Last();
        }

        /// <summary>
        /// Returns the least valuable IOrganism in this IEnvironment by using this.OrganismValueComparer.
        /// 
        /// The IPopulation does not need to be sorted.
        /// </summary>
        /// <returns>Returns the least valuable IOrganism in this IEnvironment by using this.OrganismValueComparer.
        /// 
        /// The IPopulation does not need to be sorted.</returns>
        public virtual IOrganism GetLeastValuableOrganism()
        {
            return this.GetLeastValuableOrganism(this.OrganismValueComparer);
        }

        /// <summary>
        /// Gets the least valuable IOrganism in this IEnvironment by using the given IComparer.
        /// </summary>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public virtual IOrganism GetLeastValuableOrganism(IComparer<IOrganism> comparer)
        {
            return this.OrderBy(o => o, comparer).First();
        }

        /// <summary>
        /// Sorts this Environment by each of the Environment's IOrganism's
        /// IMetrics.Value Value from the lowest Value (element 0) to the highest Value (element n).
        /// </summary>
        public virtual void SortByValueAscending()
        {
            this.Sort(this.OrganismValueComparer);
        }


        /// <summary>
        /// Sets the Proportion and ProportionSumInPopulation for each of the IMetricsValues in 
        /// the IMetrics for each of the IOrganisms in this IPopulation.
        /// </summary>
        public virtual void SetIMetricsValueProportions()
        {
            foreach(var metricsValue in this.First().Metrics.Keys)
                this.SetProportionsForIMetricValue(o => o.Metrics[metricsValue], comparer: this.MetricsEvaluator.GetComparerForIMetricsValue(metricsValue));
            
            this.SetProportionsForIMetricValue(o => o.Metrics.Value, comparer: this.OrganismValueComparer);
        }

        /// <summary>
        /// Sets the Proportion and ProportionSumInPopulation for the IMetricsValue as specified by the
        /// given metricsValueFunc for each of the IOrganisms in this IPopulation.
        /// </summary>
        /// <param name="metricsValueFunc">Locates the IMetricsValue owner of the Proportions within an IOrganism</param>
        /// <param name="comparer">The IComparer used to compare two IOrganisms with the IMetricsValue as specified by the
        /// given metricsValueFunc.</param>
        protected virtual void SetProportionsForIMetricValue(Func<IOrganism, IMetricsValue> metricsValueFunc, IComparer<IOrganism> comparer)
        {
            var leastValuableValue = metricsValueFunc(this.GetLeastValuableOrganism(comparer: comparer)).Value;

            var sum = this.Sum(organism => Math.Abs(leastValuableValue - metricsValueFunc(organism).Value));

            foreach (var organism in this)
                metricsValueFunc(organism).Proportion =
                    sum == 0
                        ? 1d / this.Count
                        : Math.Abs(leastValuableValue - metricsValueFunc(organism).Value) / sum;

            var proportionSum = 0d;
            foreach (var organism in this)
            {
                proportionSum += metricsValueFunc(organism).Proportion;
                metricsValueFunc(organism).ProportionSumInPopulation = proportionSum;
            }



            /*
            var sum = this.Sum(organism => metricsValueFunc(organism).Value);

            foreach (var organism in this)
                metricsValueFunc(organism).Proportion =
                    sum == 0
                        ? 1d/this.Count
                        : metricsValueFunc(organism).Value/sum;

            var proportionSum = 0d;
            foreach (var organism in this)
            {
                proportionSum += metricsValueFunc(organism).Proportion;
                metricsValueFunc(organism).ProportionSumInPopulation = proportionSum;
            }*/
        }


        /// <summary>
        /// Calculates the IMetrics of each of the IOrganisms in this IPopulation
        /// using the given IMetricsEvaluator.
        /// </summary>
        public virtual void CalculateMetrics(IMetricsEvaluator metricsEvaluator)
        {
            foreach (var organism in this)
            {
                organism.Metrics = metricsEvaluator.GetMetrics(organism);
                if (organism.Metrics.Any(m => double.IsNaN(m.Value.Value) || double.IsInfinity(m.Value.Value) || m.Value.Value < 0) || 
                    (double.IsNaN(organism.Metrics.Value.Value) || double.IsInfinity(organism.Metrics.Value.Value) || organism.Metrics.Value.Value < 0))
                    throw new Exception("One of the IMetrics of this IOrganism was NaN, Infinity or Negative. The MetricsEvaluator should protect against such values.");
            }
        }

        /// <summary>
        /// Calculates the IMetricValues for the IMetrics for each of the IOrganisms in this IPopulation
        /// then sorts the IPopulation by Value.
        /// </summary>
        public virtual void CalculateMetricsAndSortPopulation()
        {
            this.CalculateMetrics(this.MetricsEvaluator);
            this.SetIMetricsValueProportions();
            this.SortByValueAscending();
        }

        /// <summary>
        /// Initializes the IOrganisms in the Population in this Environment.
        /// </summary>
        /// <param name="environmentState"></param>
        public virtual void InitializePopulation(IEnvironmentState environmentState)
        {
            Randomizer.Reset();

            this.Clear();

            while(this.Count < environmentState.PopulationSize)
                foreach (var offspring in this.InitializeIOrganisms().TakeWhile(offspring => this.Count < environmentState.PopulationSize))
                    this.Add(offspring);

            this.CalculateMetricsAndSortPopulation();

            this.OnPopulationInitialized(new PopulationInitializedEventArgs());
        }

        /// <summary>
        /// Initializes the IEnvironment.
        /// </summary>
        public virtual void Initialize()
        {
            this.State.PrepareForRun();

            this.InitializePopulation(this.State);

            this.OnEnvironmentInitialized(new EnvironmentInitializedEventArgs());
        }


        /// <summary>
        /// Selects a set number of IOrganisms using randomly chosen ISelectionOperators.
        /// 
        /// Gets shallow copies of the chosen IOrganisms.
        /// </summary>
        /// <param name="individualsToSelectCount">The number of individuals to select.</param>
        /// <returns></returns>
        public virtual List<IOrganism> SelectIOrganisms(int individualsToSelectCount)
        {
            if (this.State.SelectionOperators.Count <= 0)
                throw new GeneticOperatorException("At least 1 ISelectionOperator must be provided.");

            var chosenParents = new List<IOrganism>();
            for (var i = 0; i < individualsToSelectCount; i++)
            {
                var selectionOperatorSumPosition = Randomizer.NextDouble();

                var chosenSelectionOperator =
                        this.State.SelectionOperators.FirstOrDefault(selectionOperator =>
                                                                                selectionOperatorSumPosition <=
                                                                                selectionOperator.ChanceOfUseSumPosition);
                
                if(chosenSelectionOperator == null)
                {
                    // Account for the fact that i will be incremented in the for loop. 
                    // We didn't find a proper ISelectionOperator so we need to retry.
                    i--;
                    continue;
                }

                // Add a copy of the parent to the chosenParents
                var copyChosenParent = chosenSelectionOperator.Execute(this).ShallowCopy();
                copyChosenParent.Parent = this;
                chosenParents.Add(copyChosenParent);
            }

            return chosenParents;
        }

        /// <summary>
        /// Stops the IEnvironment during its run by setting the EndCriteriaEvaluator to an instance
        /// of an EndNowEvaluator.
        /// </summary>
        public virtual void Stop()
        {
            lock (this.EndCriteriaEvaluatorLock)
                this.EndCriteriaEvaluator = new EndNowEvaluator();
        }

        /// <summary>
        /// Runs the search until the End Criteria is met according to the IEndCriteriaEvaluator.
        /// </summary>
        public virtual void Run()
        {
            this.Stopwatch = new Stopwatch();
            this.Stopwatch.Start();
            this.CurrentGeneration = 0;

            this.Initialize();

            while(true)
            {
                var metEndCriteria = false;
                lock (this.EndCriteriaEvaluatorLock)
                    metEndCriteria = this.EndCriteriaEvaluator.HasMetEndCriteria(this);

                if (metEndCriteria)
                    break;

                this.RunGeneration();
            }

            this.Stopwatch.Stop();
            this.OnEnvironmentEnd(new EnvironmentEndEventArgs(this));
        }

        /// <summary>
        /// Moves the Elite IOrganisms from this IPopulation to the given IList.
        /// Creates a shallow copy of each Elite IOrganism.
        /// </summary>
        /// <param name="newPopulation"></param>
        protected virtual void MoveElitesToNewPopulation(IList<IOrganism> newPopulation)
        {
            for (var i = 0; i < this.State.EliteCount; i++)
            {
                var eliteCopy = this[this.Count - 1 - i].ShallowCopy();
                eliteCopy.Parent = this;
                newPopulation.Add(eliteCopy);
            }
        }

        /// <summary>
        /// Mutates the given member of the IEnvironment's IPopulation.
        /// </summary>
        /// <param name="organism"></param>
        public virtual void MutateIOrganism(ref IOrganism organism)
        {
            IMutationOperator chosenMutationOperator = null;
            while (chosenMutationOperator == null)
            {
                var mutationOperatorSumPosition = Randomizer.NextDouble();
                chosenMutationOperator =
                    this.State.MutationOperators.FirstOrDefault(mutationOperator =>
                                                                mutationOperatorSumPosition <=
                                                                mutationOperator.ChanceOfUseSumPosition);

                if (chosenMutationOperator != null)
                    chosenMutationOperator.Execute(ref organism);
            }
        }

        /// <summary>
        /// Recombines a number of IOrganisms in this IEnvironment's IPopulation and returned
        /// the recombined IOrganisms.
        /// 
        /// Returns shallow copies of the recombined IOrganisms.
        /// </summary>
        /// <returns></returns>
        public virtual List<IOrganism> RecombineIOrganisms()
        {
            while (true)
            {
                var recombinationOperatorSumPosition = Randomizer.NextDouble();

                var chosenRecombinationOperator =
                    this.State.RecombinationOperators.FirstOrDefault(recombinationOperator =>
                                                                     recombinationOperatorSumPosition <=
                                                                     recombinationOperator.
                                                                         ChanceOfUseSumPosition);

                if (chosenRecombinationOperator != null)
                {
                    // Note that the chosen parents will be shallow copies
                    var chosenParents = this.SelectIOrganisms(chosenRecombinationOperator.ParentsToRecombineCount);
                    return chosenRecombinationOperator.Execute(chosenParents);
                }
            }
        }

        /// <summary>
        /// Initializes a number of IOrganisms in this IEnvironment's IPopulation and returns
        /// the newly initialized IOrganisms.
        /// </summary>
        /// <returns></returns>
        public virtual List<IOrganism> InitializeIOrganisms()
        {
            if (this.State.SelectionOperators.Count <= 0)
                throw new GeneticOperatorException("At least 1 IInitializationOperator must be provided.");

            while (true)
            {
                // Determine which Initialization Operator we will use
                var initializationOperatorSumPosition = Randomizer.NextDouble();

                var chosenInitializationOperator =
                    this.State.InitializationOperators.FirstOrDefault(initializationOperator =>
                                                                      initializationOperatorSumPosition <=
                                                                      initializationOperator.ChanceOfUseSumPosition);

                if (chosenInitializationOperator != null)
                    return chosenInitializationOperator.Execute(this);
            }
        }

        /// <summary>
        /// Runs 1 generation of the IOrganisms in the IPopulation.
        /// </summary>
        public virtual void RunGeneration()
        {
            this.OnGenerationStart(new GenerationStartEventArgs());

            var newPopulation = new List<IOrganism>();

            if (this.State.EliteCount > 0)
                this.MoveElitesToNewPopulation(newPopulation);

            while (newPopulation.Count < this.State.PopulationSize)
            {
                // Determine which type of Operator we will use
                var operatorType = Randomizer.NextDouble();

                if (operatorType < this.State.ChanceOfMutation)
                {
                    // Note that the chosen organism will already be a shallow copy
                    var chosenOrganism = this.SelectIOrganisms(1).First();
                    this.MutateIOrganism(ref chosenOrganism);
                    newPopulation.Add(chosenOrganism);
                }
                // Recombination
                else if (operatorType < (this.State.ChanceOfMutation + this.State.ChanceOfRecombination))
                {
                    foreach (var offspring in this.RecombineIOrganisms().TakeWhile(offspring => newPopulation.Count < this.State.PopulationSize))
                        newPopulation.Add(offspring);
                }
                // Initialization
                else
                {
                    foreach (var offspring in this.InitializeIOrganisms().TakeWhile(offspring => newPopulation.Count < this.State.PopulationSize))
                        newPopulation.Add(offspring);
                }
            }

            // Update the population so that it's the "new population."
            this.Clear();
            this.AddRange(newPopulation);

            this.CalculateMetricsAndSortPopulation();

            this.OnGenerationEnd(new GenerationEndEventArgs(this));
            this.CurrentGeneration++;
        }
    }
}
