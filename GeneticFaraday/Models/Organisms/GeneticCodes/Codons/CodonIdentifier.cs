using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;

namespace GeneticFaraday.Models.Organisms.GeneticCodes.Codons
{
    public struct CodonIdentifier : ICodonIdentifier
    {
        /// <summary>
        /// The Identifier
        /// </summary>
        public string Identifier { get; private set; }

        public CodonIdentifier(string identifier)
            : this()
        {
            this.Identifier = identifier;
        }

        public bool Equals(ICodonIdentifier other)
        {
            if (other == null)
                return false;
            else if (other is CodonIdentifier)
                return this.Identifier == ((CodonIdentifier)other).Identifier;
            else
                return false;
        }

        public static bool operator ==(CodonIdentifier codonIdentifierOne, CodonIdentifier codonIdentifierTwo)
        {
            return codonIdentifierOne.Equals(codonIdentifierTwo);
        }

        public static bool operator !=(CodonIdentifier codonIdentifierOne, CodonIdentifier codonIdentifierTwo)
        {
            return !(codonIdentifierOne == codonIdentifierTwo);
        }

        public bool Equals(CodonIdentifier other)
        {
            return string.Equals(Identifier, other.Identifier);
        }

        public int CompareTo(ICodonIdentifier other)
        {
            return this.Identifier.CompareTo(other.ToString());
        }

        public ICodonIdentifier ShallowCopy()
        {
            return new CodonIdentifier(this.Identifier);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is CodonIdentifier && Equals((CodonIdentifier)obj);
        }

        public override int GetHashCode()
        {
            return (Identifier != null ? Identifier.GetHashCode() : 0);
        }

        public override string ToString()
        {
            return this.Identifier;
        }
    }
}
