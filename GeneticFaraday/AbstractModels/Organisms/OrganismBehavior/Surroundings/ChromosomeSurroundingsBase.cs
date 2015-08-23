using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;

namespace GeneticFaraday.AbstractModels.Organisms.OrganismBehavior.Surroundings
{
    public abstract class ChromosomeSurroundingsBase : IChromosomeSurroundings
    {
        /// <summary>
        /// The data passed to the parent IOrganism.
        /// </summary>
        public ISurroundings OrganismSurroundings { get; private set; }

        protected ChromosomeSurroundingsBase(ISurroundings organismSurroundings)
        {
            this.OrganismSurroundings = organismSurroundings;
        }
    }
}
