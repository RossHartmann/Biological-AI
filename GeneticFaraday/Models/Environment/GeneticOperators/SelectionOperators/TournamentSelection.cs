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
    /// Uses Tournament Selection to select an IOrganism in the IPopulation according to its
    /// Value.
    /// </summary>
    public class TournamentSelection : SelectionOperatorBase
    {
        public TournamentSelection(int chanceOfUseRating)
            : base(chanceOfUseRating)
        {
        }

        public override IOrganism Execute(IPopulation population)
        {
            /*Selection pressure is easily adjusted by changing the tournament size. 
             * If the tournament size is larger, weak individuals have a smaller chance to be selected.*/

            // As the generations go up, the tournament should be more pressured
            
            var fighterOne = population.RandomElement();
            var fighterTwo = population.RandomElement();

            return population.ParentIEnvironment.OrganismValueComparer.Compare(fighterOne, fighterTwo) > 0 ? fighterOne : fighterTwo;
        }
    }
}
