using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Environment.GeneticOperators;
using GeneticFaraday.Contracts.Environment.GeneticOperators.InitializationOperators;
using GeneticFaraday.Contracts.Environment.GeneticOperators.MutationOperators;
using GeneticFaraday.Contracts.Environment.GeneticOperators.RecombinationOperators;
using GeneticFaraday.Contracts.Environment.GeneticOperators.SelectionOperators;

namespace GeneticFaraday.AbstractModels.Environment
{
    public abstract class EnvironmentStateBase : IEnvironmentState
    {
        /// <summary>
        /// The IEnvironment parent to which this IEnvironmentState applies.
        /// </summary>
        public IEnvironment Parent { get; set; }

        /// <summary>
        /// The size of the IPopulation in the IEnvironment
        /// </summary>
        public int PopulationSize { get; set; }

        /// <summary>
        /// The number of "elite" IOrganisms that will automatically be saved from one 
        /// generation to the next. If this is 3, then the top 3 most "valuable" IOrganisms 
        /// according to the IEnvironment's IMetricsEvaluator will move to the next generation.
        /// </summary>
        public int EliteCount { get; set; }

        /// <summary>
        /// The chance that an IMutationOperator will be used on a selected member of the population.
        /// </summary>
        public double ChanceOfMutation { get; set; }

        /// <summary>
        /// The chance that an offspring will be created through one of the IRecombinationOperators
        /// </summary>
        public double ChanceOfRecombination { get; set; }

        /// <summary>
        /// The chance that an IInitializationOperator will be used to create new random 
        /// member(s) of the IPopulation.
        /// </summary>
        public double ChanceOfInitialization { get; set; }

        /// <summary>
        /// The IInitializationOperators used in the IEnvironment
        /// </summary>
        public ICollection<IInitializationOperator> InitializationOperators { get; protected set; }
        /// <summary>
        /// The ISelectionOperators used in the IEnvironment
        /// </summary>
        public ICollection<ISelectionOperator> SelectionOperators { get; protected set; }
        /// <summary>
        /// The IRecombinationOperator used in the IEnvironment
        /// </summary>
        public ICollection<IRecombinationOperator> RecombinationOperators { get; protected set; }
        /// <summary>
        /// The IMutationOperators used in the IEnvironment
        /// </summary>
        public ICollection<IMutationOperator> MutationOperators { get; protected set; }


        protected EnvironmentStateBase(int populationSize, int eliteCount)
        {
            this.InitializationOperators = new List<IInitializationOperator>();
            this.SelectionOperators = new List<ISelectionOperator>();
            this.RecombinationOperators = new List<IRecombinationOperator>();
            this.MutationOperators = new List<IMutationOperator>();
            this.PopulationSize = populationSize;
            this.EliteCount = eliteCount;
        }

        /// <summary>
        /// Prepares the EnvironmentStateBase for a run of the Genetic Algorithm by calculating
        /// Chance of Use for all IGeneticOperators and verifying that all variables are properly set.
        /// </summary>
        public virtual void PrepareForRun()
        {
            this.CalculateChanceOfUseForGeneticOperators();
            this.ValidateChances();
        }

        /// <summary>
        /// Valides that the ChanceOfMutation, ChanceOfRecombination and ChanceOfInitialization all sum to 1.
        /// </summary>
        protected virtual void ValidateChances()
        {
            if (Math.Round(this.ChanceOfMutation + this.ChanceOfRecombination + this.ChanceOfInitialization, 7) != 1)
                throw new Exception("The chance of mutation, recombination and initialization must all sum to 1.");
        }

        /// <summary>
        /// Calculates the Chance of Use for all of the Genetic Operators used by the EnvironmentStateBase.
        /// </summary>
        protected virtual void CalculateChanceOfUseForGeneticOperators()
        {
            CalculateChanceOfUseForGeneticOperators(this.InitializationOperators.Cast<IGeneticOperator>().ToList());
            CalculateChanceOfUseForGeneticOperators(this.SelectionOperators.Cast<IGeneticOperator>().ToList());
            CalculateChanceOfUseForGeneticOperators(this.RecombinationOperators.Cast<IGeneticOperator>().ToList());
            CalculateChanceOfUseForGeneticOperators(this.MutationOperators.Cast<IGeneticOperator>().ToList());
        }

        /// <summary>
        /// Calculates the Chance of Use for the given Genetic Operators
        /// </summary>
        /// <param name="geneticOperators"></param>
        private static void CalculateChanceOfUseForGeneticOperators(IList<IGeneticOperator> geneticOperators)
        {
            foreach (var geneticOperator in geneticOperators)
                geneticOperator.CalculateChanceOfUse(geneticOperators);

            // Calculate all of the chanceOfUseSumPosition for each of the geneticOperators
            var chanceOfUseSumPosition = 0d;
            foreach (var geneticOperator in geneticOperators)
            {
                chanceOfUseSumPosition += geneticOperator.ChanceOfUse;
                geneticOperator.ChanceOfUseSumPosition = chanceOfUseSumPosition;
            }

            // If the last chance of use sum position didn't quite make it to 1 (100%) because 
            // of floating-point precision loss then fix it
            if (geneticOperators.Count > 0 && chanceOfUseSumPosition < 1)
                geneticOperators[geneticOperators.Count - 1].ChanceOfUseSumPosition = 1;
        }

    }
}
