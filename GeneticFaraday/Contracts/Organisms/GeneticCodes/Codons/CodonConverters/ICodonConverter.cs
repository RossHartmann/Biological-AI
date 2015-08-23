using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters
{
    public interface ICodonConverter : IEquatable<ICodonConverter>, IComparable<ICodonConverter>
    {
        /// <summary>
        /// The IGeneticCode to which this ICodonConverter belongs.
        /// </summary>
        IGeneticCode Parent { get; set; }

        /// <summary>
        /// The unique identifier of this ICodonConverter.
        /// </summary>
        ICodonConverterIdentifier Identifier { get; }

        /// <summary>
        /// Converts the given ICodon to an IConvertedCodon.
        /// </summary>
        /// <param name="codon"></param>
        /// <returns></returns>
        IConvertedCodon ConvertCodon(ICodon codon);
    }
}
