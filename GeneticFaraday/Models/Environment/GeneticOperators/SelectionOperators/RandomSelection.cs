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
    /// Returns a random IOrganism from the given IPopulation.
    /// </summary>
    public class RandomSelection : SelectionOperatorBase
    {
        public RandomSelection(int chanceOfUseRating) : base(chanceOfUseRating)
        {
        }

        public override IOrganism Execute(IPopulation population)
        {
            return population.RandomElement();
        }
    }
}
