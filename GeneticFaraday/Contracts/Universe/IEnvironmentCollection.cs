using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;

namespace GeneticFaraday.Contracts.Universe
{
    /// <summary>
    /// An IEnvironmentCollection is an Enumeration of IEnvironments
    /// </summary>
    public interface IEnvironmentCollection : IEnumerable<IEnvironment>
    {
        /// <summary>
        /// The number of IEnvironments in the IUniverse.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Adds the specified IEnvironment to the IEnvironmentCollection.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns>The added IEnvironment.</returns>
        IEnvironment Add(IEnvironment environment);

        /// <summary>
        /// Clears the IEnvironmentCollection.
        /// </summary>
        void Clear();

        /// <summary>
        /// Returns the IEnvironment associated with the given IEnvironmentIdentifier.
        /// 
        /// Returns null if no IEnvironment is found with the given IEnvironmentIdentifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        IEnvironment GetEnvironment(IEnvironmentIdentifier identifier);
    }
}
