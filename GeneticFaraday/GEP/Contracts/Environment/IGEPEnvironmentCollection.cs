using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;

namespace GeneticFaraday.GEP.Contracts.Environment
{
    public interface IGEPEnvironmentCollection : IEnumerable<IGEPEnvironment>
    {
        /// <summary>
        /// The number of IGEPEnvironment in the IUniverse.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Adds the specified IGEPEnvironment to the IGEPEnvironmentCollection.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns>The added IGEPEnvironment.</returns>
        IGEPEnvironment Add(IGEPEnvironment environment);

        /// <summary>
        /// Clears the IGEPEnvironmentCollection.
        /// </summary>
        void Clear();
    }
}
