using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.Models.Exceptions;

namespace GeneticFaraday.Models.Organisms.GeneticCodes.Codons.CodonConverters.CodonNumberConverters
{
    /// <summary>
    /// Converts an ICodon to a signed 16-bit Float (i.e. a Half-Precision Float).
    /// 
    /// Requires that the parent IGeneticCode have ICodons with a minimum length of 5 INucleotides.
    /// </summary>
    public class ConvertCodonToFloat16 : CodonNumberConverterBase
    {
        /// <summary>
        /// Sets the ICodonConverterIdentifier to "ConvertCodonToFloat16"
        /// </summary>
        public ConvertCodonToFloat16()
            : this(new CodonConverterIdentifier("ConvertCodonToFloat16"))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifier">The unique identifier of this ICodonConverter.</param>
        public ConvertCodonToFloat16(ICodonConverterIdentifier identifier) 
            : base(identifier)
        {
        }

        /// <summary>
        /// Converts an ICodon to a signed 16-bit Float (i.e. a Half-Precision Float).
        /// </summary>
        /// <param name="codon"></param>
        /// <returns></returns>
        public override IConvertedCodon ConvertCodon(ICodon codon)
        {
            return base.ConvertCodonToSignedFloat(codon: codon, maxValue: 7, wholeNumberDigits: 2);
        }
    }
}
