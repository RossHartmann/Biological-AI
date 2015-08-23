using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.Contracts.Organisms.Genomes;

namespace GeneticFaraday.AbstractModels.Organisms.Genomes
{
    public abstract class GenomeUnitBase : IGenomeUnit
    {
        /// <summary>
        /// 0 Corresponds with the top-level IGenes that belong directly to IChromosomes.
        /// 1+ Corresponds with the IGenes that belong to the IGenes at level 1.
        /// </summary>
        public int GeneLevel { get; private set; }

        /// <summary>
        /// The IChromosome to which the IGene belongs. 
        /// 0 corresponds with the 1st IChromosome. 
        /// 1 corresponds with the 2nd IChromosome.
        /// </summary>
        public int ChromosomeIndex { get; private set; }

        /// <summary>
        /// The active IAllele at this IGenomeUnit position in the IGenome.
        /// 
        /// This active IAllele is the IAllele whose DNA will be used to create the IGene's Phenotype.
        /// </summary>
        public IAllele ActiveAllele { get; set; }

        /// <summary>
        /// The inactive IAlleles at this IGenomeUnit position in the IGenome.
        /// These are the IAlleles that will not be used in the IGene's phenotype.
        /// </summary>
        public List<IAllele> InactiveAlleles { get; protected set; }


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
        protected GenomeUnitBase(IAllele activeAllele, IEnumerable<IAllele> inactiveAlleles, int chromosomeIndex, int geneLevel)
        {
            this.ActiveAllele = activeAllele;
            this.InactiveAlleles = inactiveAlleles as List<IAllele> ?? inactiveAlleles.ToList();
            this.GeneLevel = geneLevel;
            this.ChromosomeIndex = chromosomeIndex;
        }
    }
}
