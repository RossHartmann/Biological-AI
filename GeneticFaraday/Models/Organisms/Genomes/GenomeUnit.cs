using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.Genomes;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;

namespace GeneticFaraday.Models.Organisms.Genomes
{
    public class GenomeUnit : GenomeUnitBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inactiveAlleles">The inactive IAlleles at this IGenomeUnit position in the IGenome.
        /// These are the IAlleles that will not be used in the IGene's phenotype.</param>
        /// <param name="chromosomeIndex">The IChromosome to which the IGene belongs. 
        /// 0 corresponds with the 1st IChromosome. 
        /// 1 corresponds with the 2nd IChromosome.</param>
        /// <param name="geneLevel">0 Corresponds with the top-level IGenes that belong directly to IChromosomes.
        /// 1+ Corresponds with the IGenes that belong to the IGenes at level 1.</param>
        /// <param name="activeAllele">The active IAllele at this IGenomeUnit position in the IGenome.
        /// 
        /// This active IAllele is the IAllele whose DNA will be used to create the IGene's Phenotype.</param>
        public GenomeUnit(IAllele activeAllele, IEnumerable<IAllele> inactiveAlleles, 
            int chromosomeIndex, int geneLevel)
            : base(activeAllele: activeAllele, inactiveAlleles: inactiveAlleles, 
        chromosomeIndex: chromosomeIndex, geneLevel: geneLevel)
        {
        }
    }
}
