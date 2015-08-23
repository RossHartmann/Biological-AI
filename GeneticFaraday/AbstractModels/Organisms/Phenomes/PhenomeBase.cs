using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.Contracts.Organisms.Phenomes;

namespace GeneticFaraday.AbstractModels.Organisms.Phenomes
{
    public abstract class PhenomeBase : IPhenome
    {
        protected PhenomeBase(IOrganism organism, ISurroundings surroundings)
        {
            this.ConstructFromOrganism(organism: organism, surroundings: surroundings);
        }

        /// <summary>
        /// Constructs the IPhenome from the given IOrganism.
        /// </summary>
        /// <param name="organism"></param>
        public abstract void ConstructFromOrganism(IOrganism organism, ISurroundings surroundings);
    }
}
