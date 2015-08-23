using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.AbstractModels.Organisms.Chromosomes;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;

namespace GeneticFaraday.GEP.Models.Organisms.Chromosomes
{
    public class GEPChromosome : GEPChromosomeBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="main">The Main() IGene that will be executed when this IChromosome
        /// is executed.</param>
        /// <param name="environment"></param>
        public GEPChromosome(IGEPEnvironment environment, IGEPGene main)
            : base(environment: environment, main:main)
        {
        }

        public override IChromosome ShallowCopy()
        {
            var mainCopy = (IGEPGene) this.Main.ShallowCopy();
            var copy = new GEPChromosome(this.ParentEnvironment, mainCopy);
            mainCopy.Parent = copy;
            mainCopy.ReassignChildrenChromosomeParent();

            return copy;
        }

        public override IChromosomeBehavior Behave(IChromosomeSurroundings surroundings)
        {
            return base.Behave((IGEPChromosomeSurroundings) surroundings);
        }
    }
}
