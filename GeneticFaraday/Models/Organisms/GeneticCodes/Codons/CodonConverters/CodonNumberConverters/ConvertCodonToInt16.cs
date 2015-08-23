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
    /// Converts an ICodon to a signed Int16 IConvertedCodon.
    /// </summary>
    public class ConvertCodonToInt16 : CodonNumberConverterBase
    {
        /// <summary>
        /// Sets the ICodonConverterIdentifier to "ConvertCodonToInt16"
        /// </summary>
        public ConvertCodonToInt16()
            : this(new CodonConverterIdentifier("ConvertCodonToInt16"))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifier">The unique identifier of this ICodonConverter.</param>
        public ConvertCodonToInt16(ICodonConverterIdentifier identifier) 
            : base(identifier)
        {
        }

        /// <summary>
        /// Converts the given ICodon to an IConvertedCodon.
        /// </summary>
        /// <param name="codon"></param>
        /// <returns></returns>
        public override IConvertedCodon ConvertCodon(ICodon codon)
        {
            return base.ConvertCodonToSignedInteger(codon: codon, maxValue: short.MaxValue);
        }
    }
}
