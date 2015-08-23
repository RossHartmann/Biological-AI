using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.AbstractModels.Organisms.Phenomes;
using GeneticFaraday.GEP.Contracts.Organisms;
using GeneticFaraday.GEP.Contracts.Organisms.Chromosomes;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Models.Organisms.OrganismBehavior.Surroundings;

namespace GeneticFaraday.GEP.Models.Organisms.Phenomes
{
    public class GEPPhenome : GEPPhenomeBase
    {
        public GEPPhenome(IGEPOrganism organism, IGEPSurroundings surroundings)
            : base(organism: organism, surroundings: surroundings)
        {
        }

        public override void ConstructFromOrganism(IOrganism organism, ISurroundings surroundings)
        {
            base.ConstructFromOrganism(organism: organism, surroundings: surroundings);

            var o = (IGEPOrganism) organism;
            var gepSurroundings = (IGEPSurroundings) surroundings;

            foreach(IGEPChromosome chromosome in o.GetChromosomes())
            {
                var debuggableChromosome = 
                    chromosome.ToDebuggableChromosome(new GEPChromosomeSurroundings(gepSurroundings));

                this.Chromosomes.Add(debuggableChromosome);
            }
        }
    }
}
