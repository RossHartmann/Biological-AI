using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.Phenomes;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.GEP.Contracts.Organisms;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.Phenomes
{
    public abstract class GEPPhenomeBase : PhenomeBase, IGEPPhenome
    {
        /// <summary>
        /// The IDebuggableChromosomes that belong to this IDebuggablePhenome.
        /// 
        /// The first IDebuggableChromosome is run first and the Chromosomes.Count-1 IDebuggableChromosome is run last.
        /// </summary>
        public List<IDebuggableChromosome> Chromosomes { get; private set; }

        protected GEPPhenomeBase(IGEPOrganism organism, IGEPSurroundings surroundings)
            : base(organism: organism, surroundings: surroundings)
        {
        }

        public override void ConstructFromOrganism(IOrganism organism, GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings.ISurroundings surroundings)
        {
            this.Chromosomes = new List<IDebuggableChromosome>();
        }
        
    }
}
