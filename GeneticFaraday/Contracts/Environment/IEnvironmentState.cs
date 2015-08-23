using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment.GeneticOperators;
using GeneticFaraday.Contracts.Environment.GeneticOperators.InitializationOperators;
using GeneticFaraday.Contracts.Environment.GeneticOperators.MutationOperators;
using GeneticFaraday.Contracts.Environment.GeneticOperators.RecombinationOperators;
using GeneticFaraday.Contracts.Environment.GeneticOperators.SelectionOperators;

namespace GeneticFaraday.Contracts.Environment
{
    /// <summary>
    /// The IEnvironmentState contains IEnvironment-specific run-parameters.
    /// </summary>
    public interface IEnvironmentState
    {
        /// <summary>
        /// The IEnvironment parent to which this IEnvironmentState applies.
        /// </summary>
        IEnvironment Parent { get; set; }

        /// <summary>
        /// The size of the IPopulation in the IEnvironment
        /// </summary>
        int PopulationSize { get; set; }

        /// <summary>
        /// The number of "elite" IOrganisms that will automatically be saved from one 
        /// generation to the next. If this is 3, then the top 3 most "valuable" IOrganisms 
        /// will move to the next generation.
        /// </summary>
        int EliteCount { get; set; }

        /// <summary>
        /// The chance that an IMutationOperator will be used on a selected member of the population.
        /// </summary>
        double ChanceOfMutation { get; set; }

        /// <summary>
        /// The chance that an offspring will be created through one of the IRecombinationOperators
        /// </summary>
        double ChanceOfRecombination { get; set; }

        /// <summary>
        /// The chance that an IInitializationOperator will be used to create new random 
        /// member(s) of the IPopulation.
        /// </summary>
        double ChanceOfInitialization { get; set; }

        /// <summary>
        /// The IInitializationOperators used in the IEnvironment
        /// </summary>
        ICollection<IInitializationOperator> InitializationOperators { get; }

        /// <summary>
        /// The ISelectionOperators used in the IEnvironment
        /// </summary>
        ICollection<ISelectionOperator> SelectionOperators { get; }

        /// <summary>
        /// The IRecombinationOperators used in the IEnvironment
        /// </summary>
        ICollection<IRecombinationOperator> RecombinationOperators { get; }

        /// <summary>
        /// The IMutationOperators used in the IEnvironment
        /// </summary>
        ICollection<IMutationOperator> MutationOperators { get; }

        /// <summary>
        /// Prepares the EnvironmentStateBase for a run of the Genetic Algorithm by calculating
        /// Chance of Use for all IGeneticOperators and verifying that all variables are properly set.
        /// </summary>
        void PrepareForRun();

    }
}
