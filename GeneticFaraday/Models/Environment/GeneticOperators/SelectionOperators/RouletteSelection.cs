using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Environment.GeneticOperators.SelectionOperators;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Utility;

namespace GeneticFaraday.Models.Environment.GeneticOperators.SelectionOperators
{
    /// <summary>
    /// Uses Roulette Selection to select an IOrganism in the IPopulation according to its
    /// Value.
    /// </summary>
    public class RouletteSelection : SelectionOperatorBase
    {
        public RouletteSelection(int chanceOfUseRating)
            : base(chanceOfUseRating)
        {
        }

        public override IOrganism Execute(IPopulation population)
        {
            var target = Randomizer.NextDouble();

            foreach (var organism in population)
                if (organism.Metrics.Value.ProportionSumInPopulation > target)
                    return organism;

            return population.Last();
        }
    }
}
