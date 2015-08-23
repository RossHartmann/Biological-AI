using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides
{
    /// <summary>
    /// An INucleotide is a piece of a IDNA Sequence (i.e. a piece of
    /// a DNA Sequence).
    /// </summary>
    public interface INucleotide : IEquatable<INucleotide>, IComparable<INucleotide>
    {
        /// <summary>
        /// The unique identifier of this INucleotide.
        /// </summary>
        INucleotideIdentifier Identifier { get; }
    }
}
