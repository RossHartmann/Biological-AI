using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Universe;
using GeneticFaraday.Contracts.Universe.Events;

namespace GeneticFaraday.AbstractModels.Universe
{
    public abstract class UniverseBase : List<IEnvironment>, IUniverse
    {
        #region IEnvironmentCollection

        /// <summary>
        /// Adds the specified IEnvironment to this Universe and sets its Parent to this Universe.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns>The added IEnvironment.</returns>
        new public virtual IEnvironment Add(IEnvironment environment)
        {
            environment.Parent = this;
            base.Add(environment);
            return environment;
        }

        #endregion

        /// <summary>
        /// Occurs when any IEnvironment in this IUniverse meets its End Criteria.
        /// </summary>
        public event EventHandler<AnyEnvironmentEndsEventArgs> AnyEnvironmentEnds;
        protected void OnAnyEnvironmentEnds(AnyEnvironmentEndsEventArgs e)
        {
            if (this.AnyEnvironmentEnds != null)
                this.AnyEnvironmentEnds(this, e);
        }

        /// <summary>
        /// Occurs when the IUniverse stops all of its IEnvironments.
        /// </summary>
        public event EventHandler<UniverseStoppedEventArgs> Stopped;

        /// <summary>
        /// The IGeneticCode to which all IOrganisms in this IUniverse adhere.
        /// </summary>
        public IGeneticCode GeneticCode { get; protected set; }

        protected void OnStopped(UniverseStoppedEventArgs e)
        {
            if (this.Stopped != null)
                this.Stopped(this, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="geneticCode">The IGeneticCode to which all IOrganisms in this IUniverse adhere.</param>
        protected UniverseBase(IGeneticCode geneticCode)
        {
            this.GeneticCode = geneticCode;
        }

        /// <summary>
        /// Returns the IEnvironment associated with the given IEnvironmentIdentifier.
        /// 
        /// Returns null if no IEnvironment is found with the given IEnvironmentIdentifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public virtual IEnvironment GetEnvironment(IEnvironmentIdentifier identifier)
        {
            return this.FirstOrDefault(e => e.Identifier.Equals(identifier));
        }

        /// <summary>
        /// Begins running all of the IEnvironments in this IUniverse.
        /// </summary>
        public virtual void Run()
        {
            var tasks = new Task[this.Count];
            var i = 0;
            foreach (var environment in this)
            {
                environment.EnvironmentEnd += environment_EnvironmentEnd;
                tasks[i] = new Task((data) => ((IEnvironment)data).Run(), environment);
                tasks[i].Start();
                i++;
            }
        }

        protected void environment_EnvironmentEnd(object sender, Contracts.Environment.Events.EnvironmentEndEventArgs e)
        {
            this.OnAnyEnvironmentEnds(new AnyEnvironmentEndsEventArgs(environmentEndEventArgs: e));
        }

        /// <summary>
        /// Stops all of the IEnvironments in this IUniverse.
        /// </summary>
        public void StopAll()
        {
            foreach(var environment in this)
                environment.Stop();

            this.OnStopped(new UniverseStoppedEventArgs());
        }
    }
}
