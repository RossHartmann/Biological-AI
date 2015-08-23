using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Genes;

namespace GeneticFaraday.Models.Organisms.Genes
{
    public struct GeneIdentifier : IGeneIdentifier
    {
        /// <summary>
        /// The Identifier
        /// </summary>
        public string Identifier { get; private set; }

        public GeneIdentifier(string identifier)
            : this()
        {
            this.Identifier = identifier;
        }

        public bool Equals(IGeneIdentifier other)
        {
            if (other == null)
                return false;
            else if (other is GeneIdentifier)
                return this.Identifier == ((GeneIdentifier)other).Identifier;
            else
                return false;
        }

        public static bool operator ==(GeneIdentifier geneIdentifierOne, GeneIdentifier geneIdentifierTwo)
        {
            return geneIdentifierOne.Equals(geneIdentifierTwo);
        }

        public static bool operator !=(GeneIdentifier geneIdentifierOne, GeneIdentifier geneIdentifierTwo)
        {
            return !(geneIdentifierOne == geneIdentifierTwo);
        }

        public bool Equals(GeneIdentifier other)
        {
            return string.Equals(Identifier, other.Identifier);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is GeneIdentifier && Equals((GeneIdentifier)obj);
        }

        public override int GetHashCode()
        {
            return (Identifier != null ? Identifier.GetHashCode() : 0);
        }
    }
}
