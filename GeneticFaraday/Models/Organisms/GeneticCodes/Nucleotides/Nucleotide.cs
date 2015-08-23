using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;

namespace GeneticFaraday.Models.Organisms.GeneticCodes.Nucleotides
{
    public struct Nucleotide : INucleotide
    {
        /// <summary>
        /// The unique identifier of this INucleotide.
        /// </summary>
        public INucleotideIdentifier Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifier">The display text of the INucleotide such as 
        /// "A" "G" "U" "C" "4" "237", etc.</param>
        public Nucleotide(INucleotideIdentifier identifier)
            : this()
        {
            this.Identifier = identifier;
        }

        public int CompareTo(INucleotide other)
        {
            return this.Identifier.CompareTo(other.Identifier);
        }

        public override string ToString()
        {
            return this.Identifier.ToString();
        }

        public bool Equals(INucleotide other)
        {
            return this.Identifier.Equals(other.Identifier);
        }

        public static bool operator ==(Nucleotide nucleotideOne, Nucleotide nucleotideTwo)
        {
            return nucleotideOne.Equals(nucleotideTwo);
        }

        public static bool operator !=(Nucleotide nucleotideOne, Nucleotide nucleotideTwo)
        {
            return !(nucleotideOne == nucleotideTwo);
        }

        public bool Equals(Nucleotide other)
        {
            return string.Equals(Identifier, other.Identifier);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Nucleotide && Equals((Nucleotide)obj);
        }

        public override int GetHashCode()
        {
            return (Identifier != null ? Identifier.GetHashCode() : 0);
        }

    }
}
