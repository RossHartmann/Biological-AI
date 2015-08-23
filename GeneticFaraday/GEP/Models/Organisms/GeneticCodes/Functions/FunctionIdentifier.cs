using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;

namespace GeneticFaraday.GEP.Models.Organisms.GeneticCodes.Functions
{
    public struct FunctionIdentifier : IFunctionIdentifier
    {
        /// <summary>
        /// The Identifier
        /// </summary>
        public string Identifier { get; private set; }

        public FunctionIdentifier(string identifier)
            : this()
        {
            this.Identifier = identifier;
        }

        public bool Equals(IFunctionIdentifier other)
        {
            if (other == null)
                return false;
            else if (other is FunctionIdentifier)
                return this.Identifier == ((FunctionIdentifier)other).Identifier;
            else
                return false;
        }

        public static bool operator ==(FunctionIdentifier functionIdentifierOne, FunctionIdentifier functionIdentifierTwo)
        {
            return functionIdentifierOne.Equals(functionIdentifierTwo);
        }

        public static bool operator !=(FunctionIdentifier functionIdentifierOne, FunctionIdentifier functionIdentifierTwo)
        {
            return !(functionIdentifierOne == functionIdentifierTwo);
        }

        public int CompareTo(IFunctionIdentifier other)
        {
            return this.Identifier.CompareTo(other.ToString());
        }

        public bool Equals(FunctionIdentifier other)
        {
            return string.Equals(Identifier, other.Identifier);
        }

        public IFunctionIdentifier ShallowCopy()
        {
            return new FunctionIdentifier(this.Identifier);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is FunctionIdentifier && Equals((FunctionIdentifier)obj);
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
