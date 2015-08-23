using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.DNAs;

namespace GeneticFaraday.Contracts.Organisms.Genomes
{
    /// <summary>
    /// Each IGenomeUnit is a "unit" of an IGenome. Essentially, each
    /// IGenomeUnit holds an IGene and information about where the IGene
    /// belongs in the IGenome.
    /// </summary>
    public interface IGenomeUnit
    {
        /// <summary>
        /// 0 Corresponds with the top-level IGenes that belong directly to IChromosomes.
        /// 1+ Corresponds with the IGenes that belong to the IGenes at level 1.
        /// </summary>
        int GeneLevel { get; }

        /// <summary>
        /// The IChromosome to which the IGene belongs. 
        /// 0 corresponds with the 1st IChromosome. 
        /// 1 corresponds with the 2nd IChromosome.
        /// </summary>
        int ChromosomeIndex { get; }

        /// <summary>
        /// The active IAllele at this IGenomeUnit position in the IGenome.
        /// 
        /// This active IAllele is the IAllele whose DNA will be used to create the IGene's Phenotype.
        /// </summary>
        IAllele ActiveAllele { get; set; }

        /// <summary>
        /// The inactive IAlleles at this IGenomeUnit position in the IGenome.
        /// These are the IAlleles that will not be used in the IGene's phenotype.
        /// </summary>
        List<IAllele> InactiveAlleles { get; }
    }
}
