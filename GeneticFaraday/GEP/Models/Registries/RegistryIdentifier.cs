using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Models.Registries
{
    public struct RegistryIdentifier : IRegistryIdentifier
    {
        /// <summary>
        /// The Identifier
        /// </summary>
        public string Identifier { get; private set; }

        public RegistryIdentifier(string identifier)
            : this()
        {
            this.Identifier = identifier;
        }

        public bool Equals(IRegistryIdentifier other)
        {
            if (other == null)
                return false;
            else if (other is RegistryIdentifier)
                return this.Identifier == ((RegistryIdentifier)other).Identifier;
            else
                return false;
        }

        public static bool operator ==(RegistryIdentifier registryIdentifierOne, RegistryIdentifier registryIdentifierTwo)
        {
            return registryIdentifierOne.Equals(registryIdentifierTwo);
        }

        public static bool operator !=(RegistryIdentifier registryIdentifierOne, RegistryIdentifier registryIdentifierTwo)
        {
            return !(registryIdentifierOne == registryIdentifierTwo);
        }

        public bool Equals(RegistryIdentifier other)
        {
            return string.Equals(Identifier, other.Identifier);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is RegistryIdentifier && Equals((RegistryIdentifier)obj);
        }

        public override int GetHashCode()
        {
            return (Identifier != null ? Identifier.GetHashCode() : 0);
        }

        public IRegistryIdentifier ShallowCopy()
        {
            return new RegistryIdentifier(this.Identifier);
        }

        public int CompareTo(IRegistryIdentifier other)
        {
            return this.Identifier.CompareTo(other.ToString());
        }

        public override string ToString()
        {
            return this.Identifier;
        }

    }
}
