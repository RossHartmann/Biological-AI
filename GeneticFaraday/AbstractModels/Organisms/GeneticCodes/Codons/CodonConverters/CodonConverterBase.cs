using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;

namespace GeneticFaraday.AbstractModels.Organisms.GeneticCodes.Codons.CodonConverters
{
    public abstract class CodonConverterBase : ICodonConverter
    {
        /// <summary>
        /// The IGeneticCode to which this ICodonConverter belongs.
        /// </summary>
        public IGeneticCode Parent { get; set; }

        /// <summary>
        /// The unique identifier of this ICodonConverter.
        /// </summary>
        public ICodonConverterIdentifier Identifier { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifier">The unique identifier of this ICodonConverter.</param>
        protected CodonConverterBase(ICodonConverterIdentifier identifier)
        {
            this.Identifier = identifier;
        }

        public bool Equals(ICodonConverter other)
        {
            return other != null && this.Identifier.Equals(other.Identifier);
        }

        public static bool operator ==(CodonConverterBase codonConverterBaseOne, CodonConverterBase codonConverterBaseTwo)
        {
            return codonConverterBaseOne.Equals(codonConverterBaseTwo);
        }

        public static bool operator !=(CodonConverterBase codonConverterBaseOne, CodonConverterBase codonConverterBaseTwo)
        {
            return !(codonConverterBaseOne == codonConverterBaseTwo);
        }

        protected bool Equals(CodonConverterBase other)
        {
            return Equals(Identifier, other.Identifier);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CodonConverterBase)obj);
        }

        public override int GetHashCode()
        {
            return (Identifier != null ? Identifier.GetHashCode() : 0);
        }

        public int CompareTo(ICodonConverter other)
        {
            return this.Identifier.CompareTo(other.Identifier);
        }

        /// <summary>
        /// Converts the given ICodon to an IConvertedCodon.
        /// </summary>
        /// <param name="codon"></param>
        /// <returns></returns>
        public abstract IConvertedCodon ConvertCodon(ICodon codon);
    }
}
