using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;

namespace GeneticFaraday.Models.Organisms.GeneticCodes.Nucleotides
{
    public struct NucleotideIdentifier : INucleotideIdentifier
    {
        /// <summary>
        /// The Identifier
        /// </summary>
        public string Identifier { get; private set; }

        public NucleotideIdentifier(string identifier) : this()
        {
            this.Identifier = identifier;
        }

        public bool Equals(INucleotideIdentifier other)
        {
            if (other == null)
                return false;
            else if (other is NucleotideIdentifier)
                return this.Identifier == ((NucleotideIdentifier)other).Identifier;
            else
                return false;
        }

        public static bool operator ==(NucleotideIdentifier nucleotideIdentifierOne, NucleotideIdentifier nucleotideIdentifierTwo)
        {
            return nucleotideIdentifierOne.Equals(nucleotideIdentifierTwo);
        }

        public static bool operator !=(NucleotideIdentifier nucleotideIdentifierOne, NucleotideIdentifier nucleotideIdentifierTwo)
        {
            return !(nucleotideIdentifierOne == nucleotideIdentifierTwo);
        }

        public bool Equals(NucleotideIdentifier other)
        {
            return string.Equals(Identifier, other.Identifier);
        }

        

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is NucleotideIdentifier && Equals((NucleotideIdentifier)obj);
        }

        public override int GetHashCode()
        {
            return (Identifier != null ? Identifier.GetHashCode() : 0);
        }

        public int CompareTo(INucleotideIdentifier other)
        {
            return this.Identifier.CompareTo(other.ToString());
        }

        public INucleotideIdentifier ShallowCopy()
        {
            return new NucleotideIdentifier(this.Identifier);
        }

        public override string ToString()
        {
            return this.Identifier;
        }
    }
}
