using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;

namespace GeneticFaraday.AbstractModels.Organisms.OrganismBehavior.Surroundings
{
    public abstract class GeneSurroundingsBase : IGeneSurroundings
    {
        /// <summary>
        /// The data passed to the parent IChromosome.
        /// </summary>
        public IChromosomeSurroundings ChromosomeSurroundings { get; private set; }

        protected GeneSurroundingsBase(IChromosomeSurroundings chromosomeSurroundings)
        {
            this.ChromosomeSurroundings = chromosomeSurroundings;
        }
    }
}
