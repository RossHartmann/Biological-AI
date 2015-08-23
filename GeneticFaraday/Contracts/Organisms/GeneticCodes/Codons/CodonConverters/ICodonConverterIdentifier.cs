using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters
{
    public interface ICodonConverterIdentifier : IIdentifier, IShallowCopyable<ICodonConverterIdentifier>, IEquatable<ICodonConverterIdentifier>, IComparable<ICodonConverterIdentifier>
    {
    }
}
