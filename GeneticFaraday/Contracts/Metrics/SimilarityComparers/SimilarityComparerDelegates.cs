using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;

namespace GeneticFaraday.Contracts.Metrics.SimilarityComparers
{
    /// <summary>
    /// Gets the percentage that IOrganism one and IOrganism two are similar.
    /// 100% would be identical and 0% would indicate that the IOrganisms share nothing.
    /// </summary>
    /// <param name="one">The first IOrganism to compare.</param>
    /// <param name="two">The second IOrganism to compare.</param>
    /// <returns>The percentage that IOrganism one and IOrganism two are similar.
    /// 100% would be identical and 0% would indicate that the IOrganisms share nothing.</returns>
    public delegate double GetPercentageIOrganismSimilarity(IOrganism one, IOrganism two);

    /// <summary>
    /// Gets the percentage that IChromosome one and IChromosome two are similar.
    /// 100% would be identical and 0% would indicate that the IChromosomes share nothing.
    /// </summary>
    /// <param name="one">The first IChromosome to compare.</param>
    /// <param name="two">The second IChromosome to compare.</param>
    /// <returns>The percentage that IChromosome one and IChromosome two are similar.
    /// 100% would be identical and 0% would indicate that the IChromosomes share nothing.</returns>
    public delegate double GetPercentageIChromosomeSimilarity(IChromosome one, IChromosome two);

    /// <summary>
    /// Gets the percentage that IGene one and IGene two are similar.
    /// 100% would be identical and 0% would indicate that the IGenes share nothing.
    /// </summary>
    /// <param name="one">The first IGene to compare.</param>
    /// <param name="two">The second IGene to compare.</param>
    /// <returns>The percentage that IGene one and IGene two are similar.
    /// 100% would be identical and 0% would indicate that the IGenes share nothing.</returns>
    public delegate double GetPercentageIGeneSimilarity(IGene one, IGene two);

    /// <summary>
    /// Gets the percentage that IAllele one and IAllele two are similar.
    /// 100% would be identical and 0% would indicate that the IAlleles share nothing.
    /// </summary>
    /// <param name="one">The first IAllele to compare.</param>
    /// <param name="two">The second IAllele to compare.</param>
    /// <returns>The percentage that IAllele one and IAllele two are similar.
    /// 100% would be identical and 0% would indicate that the IAlleles share nothing.</returns>
    public delegate double GetPercentageIAlleleSimilarity(IAllele one, IAllele two);
}
