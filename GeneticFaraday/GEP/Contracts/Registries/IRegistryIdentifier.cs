using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts;

namespace GeneticFaraday.GEP.Contracts.Registries
{
    public interface IRegistryIdentifier : IShallowCopyable<IRegistryIdentifier>, IEquatable<IRegistryIdentifier>, IComparable<IRegistryIdentifier>
    {
    }
}
