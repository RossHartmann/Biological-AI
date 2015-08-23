using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons
{
    public interface ICodonIdentifier : IIdentifier, IShallowCopyable<ICodonIdentifier>, IEquatable<ICodonIdentifier>, IComparable<ICodonIdentifier>
    {
    }
}
