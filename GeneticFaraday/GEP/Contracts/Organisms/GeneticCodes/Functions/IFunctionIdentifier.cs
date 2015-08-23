using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions
{
    public interface IFunctionIdentifier : IIdentifier, IShallowCopyable<IFunctionIdentifier>, IEquatable<IFunctionIdentifier>, IComparable<IFunctionIdentifier>
    {
    }
}
