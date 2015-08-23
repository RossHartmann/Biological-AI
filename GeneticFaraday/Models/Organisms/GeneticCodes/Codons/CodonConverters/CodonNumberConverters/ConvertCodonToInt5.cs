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
    /// Converts a Codon to a signed 5-bit integer (max value of 31)
    /// </summary>
    public class ConvertCodonToInt5 : CodonNumberConverterBase
    {
        /// <summary>
        /// Sets the ICodonConverterIdentifier to "ConvertCodonToInt5"
        /// </summary>
        public ConvertCodonToInt5()
            : this(new CodonConverterIdentifier("ConvertCodonToInt5"))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifier">The unique identifier of this ICodonConverter.</param>
        public ConvertCodonToInt5(ICodonConverterIdentifier identifier) 
            : base(identifier)
        {
        }

        /// <summary>
        /// Converts an ICodon to a signed 5-bit integer (max value of 31)
        /// </summary>
        /// <param name="codon"></param>
        /// <returns></returns>
        public override IConvertedCodon ConvertCodon(ICodon codon)
        {
            return base.ConvertCodonToSignedInteger(codon: codon, maxValue: 31);
        }
    }
}
