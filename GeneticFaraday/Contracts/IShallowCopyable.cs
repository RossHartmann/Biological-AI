using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts
{
    public interface IShallowCopyable<out T>
    {
        /// <summary>
        /// Creates a Shallow Copy of the T.
        /// </summary>
        /// <returns>A Shallow Copy of the T</returns>
        T ShallowCopy();
    }
}
