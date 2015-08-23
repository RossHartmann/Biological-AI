using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaraday.Models.Organisms.GeneticCodes.Nucleotides;

namespace GeneticFaraday.Models.Organisms.GeneticCodes.Codons.CodonConverters
{
    public struct CodonConverterIdentifier : ICodonConverterIdentifier
    {
        /// <summary>
        /// The Identifier
        /// </summary>
        public string Identifier { get; private set; }

        public CodonConverterIdentifier(string identifier)
            : this()
        {
            this.Identifier = identifier;
        }

        public bool Equals(ICodonConverterIdentifier other)
        {
            if (other == null)
                return false;
            else if (other is CodonConverterIdentifier)
                return this.Identifier == ((CodonConverterIdentifier)other).Identifier;
            else
                return false;
        }

        public static bool operator ==(CodonConverterIdentifier codonConverterIdentifierOne, CodonConverterIdentifier codonConverterIdentifierTwo)
        {
            return codonConverterIdentifierOne.Equals(codonConverterIdentifierTwo);
        }

        public static bool operator !=(CodonConverterIdentifier codonConverterIdentifierOne, CodonConverterIdentifier codonConverterIdentifierTwo)
        {
            return !(codonConverterIdentifierOne == codonConverterIdentifierTwo);
        }

        public bool Equals(NucleotideIdentifier other)
        {
            return string.Equals(Identifier, other.Identifier);
        }

        

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is CodonConverterIdentifier && Equals((CodonConverterIdentifier)obj);
        }

        public override int GetHashCode()
        {
            return (Identifier != null ? Identifier.GetHashCode() : 0);
        }

        public int CompareTo(ICodonConverterIdentifier other)
        {
            return this.Identifier.CompareTo(other.ToString());
        }

        public ICodonConverterIdentifier ShallowCopy()
        {
            return new CodonConverterIdentifier(this.Identifier);
        }

        public override string ToString()
        {
            return this.Identifier;
        }
    }
}
