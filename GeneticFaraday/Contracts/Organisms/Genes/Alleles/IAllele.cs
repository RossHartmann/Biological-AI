using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.DNAs;
using GeneticFaraday.Contracts.Organisms.Genomes;

namespace GeneticFaraday.Contracts.Organisms.Genes.Alleles
{
    /// <summary>
    /// An IAllele is a version of an IGene.
    /// 
    /// To get the similarity between two IAlleles, see IMetricsEvaluator's
    /// "GetPercentageIAlleleSimilarity()"
    /// </summary>
    public interface IAllele : IShallowCopyable<IAllele>, IEquatable<IAllele>
    {
        /// <summary>
        /// The parent IGene of this IAllele.
        /// </summary>
        IGene Parent { get; set; }

        /// <summary>
        /// Only applicable if this IAllele belongs to an IGenome rather than an IOrganism.
        /// This should be set if the IAllele does not belong to an IGene.
        /// </summary>
        IGenome ParentGenome { get; set; }

        /// <summary>
        /// The IGeneticCode to which this IAllele adheres.
        /// </summary>
        IGeneticCode GeneticCode { get; }

        /// <summary>
        /// If true, the child must inherit 2 of these IAlleles (i.e. 2 of 
        /// this version of the IGene), in order for this IAllele to be expressed
        /// as the IGene.
        /// 
        /// If false, the child must only inherit 1 of these IAlleles (i.e. 1 of
        /// this version of the IGene) in order for this IAllele to be expressed
        /// as the IGene.
        /// </summary>
        bool IsRecessive { get; set; }

        /// <summary>
        /// The DNA sequence of the IAllele.
        /// </summary>
        IDNA DNA { get; }

        /// <summary>
        /// Resets and randomizes the DNA of this IAllele.
        /// 
        /// The Randomized IDNA will be of the same length as it is when calling this method.
        /// </summary>
        void Randomize();

    }
}
