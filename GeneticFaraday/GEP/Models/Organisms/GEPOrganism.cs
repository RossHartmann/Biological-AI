using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Contracts.Organisms.Genomes;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.Contracts.Organisms.Phenomes;
using GeneticFaraday.GEP.AbstractModels.Organisms;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms.Chromosomes;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Models.Organisms.Genomes;
using GeneticFaraday.GEP.Models.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Models.Organisms.Phenomes;
using GeneticFaraday.Utility;

namespace GeneticFaraday.GEP.Models.Organisms
{
    public class GEPOrganism : GEPOrganismBase
    {
        public GEPOrganism(IGEPEnvironment environment)
            : base(environment: environment)
        {
            
        }

        public GEPOrganism(IGEPEnvironment environment, IEnumerable<IGEPChromosome> collection)
            : base(environment: environment, collection: collection)
        {
        }

        public override IOrganism ShallowCopy()
        {
            var organism = new GEPOrganism(this.Parent, this.ToArray().Select(c => ((IGEPChromosome) c.ShallowCopy())));
            foreach (var chromosome in organism)
                chromosome.Parent = organism;
            return organism;
        }

        /// <summary>
        /// Converts this IOrganism to its corresponding IGEPGenome.
        /// </summary>
        /// <returns></returns>
        public override IGenome ToGenome()
        {
            return new GEPGenome(this);
        }

        /// <summary>
        /// Converts this IOrganism to its corresponding IPhenome.
        /// </summary>
        /// <returns></returns>
        public override IPhenome ToPhenome(ISurroundings surroundings)
        {
            return new GEPPhenome(organism: this, surroundings: (IGEPSurroundings)surroundings);
        }

        /// <summary>
        /// Given the IOrganism's immediate surroundsings (i.e. the "input"), 
        /// "Runs" the IOrganism which results in its Behavior (i.e. the "ouput").
        /// </summary>
        /// <param name="surroundings"></param>
        /// <returns></returns>
        public override IBehavior Behave(ISurroundings surroundings)
        {
            return base.Behave((IGEPSurroundings) surroundings);
        }

    }
}
