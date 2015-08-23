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
    public class ConvertCodonToInt3 : CodonNumberConverterBase
    {
        /// <summary>
        /// Sets the ICodonConverterIdentifier to "ConvertCodonToInt3"
        /// </summary>
        public ConvertCodonToInt3()
            : this(new CodonConverterIdentifier("ConvertCodonToInt3"))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifier">The unique identifier of this ICodonConverter.</param>
        public ConvertCodonToInt3(ICodonConverterIdentifier identifier) 
            : base(identifier)
        {
        }

        /// <summary>
        /// Converts an ICodon to a signed 3-bit integer (max value of 7)
        /// </summary>
        /// <param name="codon"></param>
        /// <returns></returns>
        public override IConvertedCodon ConvertCodon(ICodon codon)
        {
            return base.ConvertCodonToSignedInteger(codon: codon, maxValue: 7);
        }
    }
}
