using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;

namespace GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons
{
    public interface ICodon : IList<INucleotide>, IEquatable<ICodon>, IComparable<ICodon>
    {
        /// <summary>
        /// The unique Identiifer of this ICodon
        /// </summary>
        ICodonIdentifier CodonIdentifier { get; }

        /// <summary>
        /// The type of the ICodon.
        /// </summary>
        CodonType CodonType { get; set; }

        /// <summary>
        /// Converts this ICodon to a IConvertedCodon as specified by the given ICodonConverterIdentifier.
        /// </summary>
        /// <param name="geneticCode"></param>
        /// <param name="codonConverterIdentifier"></param>
        /// <returns>The converted IConvertedCodon.</returns>
        IConvertedCodon Convert(IGeneticCode geneticCode, ICodonConverterIdentifier codonConverterIdentifier);
    }
}
