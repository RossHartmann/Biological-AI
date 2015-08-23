using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaraday.Models.Exceptions;
using GeneticFaraday.Models.Organisms.GeneticCodes.Codons.CodonConverters;
using UtilityData.Exceptions.DatabaseExceptions;

namespace GeneticFaraday.AbstractModels.Organisms.GeneticCodes.Codons.CodonConverters
{
    public abstract class CodonNumberConverterBase : CodonConverterBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifier">The unique identifier of this ICodonConverter.</param>
        protected CodonNumberConverterBase(ICodonConverterIdentifier identifier) 
            : base(identifier)
        {
        }

        /// <summary>
        /// Gets the value at the given digit place (assuming that 0 is the far right digit
        /// and n is the far left digit where 0 is 0 in binary and 8 is 100 in binary).
        /// 
        /// These digits ARE zero-based.
        /// </summary>
        /// <param name="digitPlace">0 for far right digit place. n for far left.</param>
        /// <param name="numberOfNucleotides">The number of nucleotides in the IGeneticCode (this is
        /// the same as the "base." Binary is base 2).</param>
        /// <returns></returns>
        protected static int GetBaseValueAtDigitPlace(int digitPlace, int numberOfNucleotides)
        {
            return (int)Math.Pow(numberOfNucleotides, digitPlace);
        }

        /// <summary>
        /// Gets the value of the given INucleotide in the parent IGeneticCode.
        /// The INucleotide's value is determined by its index position in the IGeneticCode's
        /// list of INucleotides.
        /// 
        /// The 0th INucleotide has a value of 0.
        /// The nth INucleotide has a value of n.
        /// </summary>
        /// <param name="nucleotide"></param>
        /// <returns></returns>
        protected int GetValueOfNucleotide(INucleotide nucleotide)
        {
            for (var i = 0; i < this.Parent.Nucleotides.Count; i++)
                if (this.Parent.Nucleotides.Values[i].Equals(nucleotide))
                    return i;

            throw new ValueNotYetSupported(nucleotide, typeof(INucleotide));
        }

        /// <summary>
        /// Converts the specified ICodon to a signed integer with a max value of the specified maxValue.
        /// </summary>
        /// <param name="codon"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        protected IConvertedCodon ConvertCodonToSignedInteger(ICodon codon, int maxValue)
        {
            // Don't process the first INucleotide because we will use it as our
            // "signed" position to indicate whether the int is positive or negative
            var value = 0;
            var actualNucleotidePosition = 1;
            for (var digitPlace = codon.Count - 2; digitPlace >= 0; digitPlace--)
            {
                var baseValueAtDigitPlace = GetBaseValueAtDigitPlace(digitPlace, this.Parent.Nucleotides.Count);
                var nucleotideValue = this.GetValueOfNucleotide(codon[actualNucleotidePosition]);

                value += baseValueAtDigitPlace * nucleotideValue;
                actualNucleotidePosition++;
            }

            // Determine if the int is positive or negative based on the "signed" place
            var signedValue = this.GetValueOfNucleotide(codon[0]);
            var isNegative = signedValue < (this.Parent.Nucleotides.Count / 2);

            value = value > maxValue ? value % maxValue : value;
            return new ConvertedCodon(isNegative ? -value : value);
        }

        /// <summary>
        /// Converts the specified ICodon to a signed float with a max value of the specified maxValue and can have a
        /// maximum of "wholeNumberDigits" digits to the left of the decimal point.
        /// </summary>
        /// <param name="codon"></param>
        /// <param name="maxValue">The maximum value of the resulting signed float.</param>
        /// <param name="wholeNumberDigits">The number of digits to the left of the decimal place that the resulting float can potentially have.</param>
        /// <returns></returns>
        protected IConvertedCodon ConvertCodonToSignedFloat(ICodon codon, int maxValue, int wholeNumberDigits)
        {
            // We will add 1 digit to account for the "signed" position at the start of the ICodon.
            // The rest of the digit places will be beyond the decimal point.
            var nucleotidesBeforeDecimalPoint = wholeNumberDigits + 1;

            var minimumCodonLength = nucleotidesBeforeDecimalPoint + 1;
            if (this.Parent.CodonLength < minimumCodonLength)
                throw new CodonConverterException("The current CodonNumberConverterBase requires that the parent IGeneticCode have ICodons with a minimum length of " + minimumCodonLength + " INucleotides.");

            
            var value = 0f;

            // Process the "whole" numbers that are after the "signed" place
            var actualNucleotidePosition = 1;
            for (var digitPlace = nucleotidesBeforeDecimalPoint - (this.Parent.CodonLength - nucleotidesBeforeDecimalPoint); digitPlace >= 0; digitPlace--)
            {
                var baseValueAtDigitPlace = GetBaseValueAtDigitPlace(digitPlace, this.Parent.Nucleotides.Count);
                var nucleotideValue = this.GetValueOfNucleotide(codon[actualNucleotidePosition]);

                value += baseValueAtDigitPlace * nucleotideValue;
                actualNucleotidePosition++;
            }

            // Process the "decimal" numbers that are after the decimal point.
            for (var digitPlace = 1; digitPlace <= this.Parent.CodonLength - nucleotidesBeforeDecimalPoint; digitPlace++)
            {
                var baseValueAtDigitPlace = 1f / GetBaseValueAtDigitPlace(digitPlace, this.Parent.Nucleotides.Count);
                var nucleotideValue = this.GetValueOfNucleotide(codon[actualNucleotidePosition]);

                value += baseValueAtDigitPlace * nucleotideValue;
                actualNucleotidePosition++;
            }

            // Determine if the float is positive or negative based on the "signed" place
            var signedValue = this.GetValueOfNucleotide(codon[0]);
            var isNegative = signedValue < (this.Parent.Nucleotides.Count / 2);

            //value = value > float.MaxValue ? float.MaxValue : value;
            value = value > maxValue ? value % maxValue : value;
            return new ConvertedCodon(isNegative ? -value : value);
        }
    }
}
