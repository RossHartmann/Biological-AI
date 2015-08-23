using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Universe.Events;

namespace GeneticFaraday.Contracts.Universe
{
    /// <summary>
    /// The IUniverse is the Universe in which the GA will run.
    /// It contains the globally common elements for the problem 
    /// being solved.
    /// 
    /// The IUniverse can support multiple IEnvironments. It can run multiple
    /// IEnvironments at the same time. It can handle migrations. It can raise
    /// events such as when one IEnvironments reaches its end criteria.
    /// </summary>
    public interface IUniverse : IEnvironmentCollection
    {
        /// <summary>
        /// Begins running all of the IEnvironments in this IUniverse.
        /// </summary>
        void Run();

        /// <summary>
        /// Stops all of the IEnvironments in this IUniverse.
        /// </summary>
        void StopAll();

        /// <summary>
        /// Occurs when any IEnvironment in this IUniverse meets its End Criteria.
        /// </summary>
        event EventHandler<AnyEnvironmentEndsEventArgs> AnyEnvironmentEnds;

        /// <summary>
        /// Occurs when the IUniverse stops all of its IEnvironments.
        /// </summary>
        event EventHandler<UniverseStoppedEventArgs> Stopped;

        /// <summary>
        /// The IGeneticCode to which all IOrganisms in this IUniverse adhere.
        /// </summary>
        IGeneticCode GeneticCode { get; }
    }
}
