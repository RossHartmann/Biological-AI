using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;

namespace GeneticFaraday.Models.Organisms.GeneticCodes.Codons.CodonConverters.CodonNumberConverters
{
    /// <summary>
    /// Converts an ICodon to a signed 16-bit Float (i.e. a Half-Precision Float) that is between -1 and 1.
    /// </summary>
    public class ConvertCodonToDecimal : CodonNumberConverterBase
    {
        /// <summary>
        /// Sets the ICodonConverterIdentifier to "ConvertCodonToDecimal"
        /// </summary>
        public ConvertCodonToDecimal()
            : this(new CodonConverterIdentifier("ConvertCodonToDecimal"))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifier">The unique identifier of this ICodonConverter.</param>
        public ConvertCodonToDecimal(ICodonConverterIdentifier identifier) 
            : base(identifier)
        {
        }

        /// <summary>
        /// Converts an ICodon to a signed 16-bit Float (i.e. a Half-Precision Float) that is between -1 and 1.
        /// </summary>
        /// <param name="codon"></param>
        /// <returns></returns>
        public override IConvertedCodon ConvertCodon(ICodon codon)
        {
            return base.ConvertCodonToSignedFloat(codon: codon, maxValue: 1, wholeNumberDigits: 0);
        }
    }
}
