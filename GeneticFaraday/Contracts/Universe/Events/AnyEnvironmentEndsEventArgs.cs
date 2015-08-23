using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Universe.Events
{
    public class AnyEnvironmentEndsEventArgs : EventArgs
    {
        public Contracts.Environment.Events.EnvironmentEndEventArgs EnvironmentEndEventArgs { get; private set; }

        public AnyEnvironmentEndsEventArgs(Contracts.Environment.Events.EnvironmentEndEventArgs environmentEndEventArgs)
        {
            this.EnvironmentEndEventArgs = environmentEndEventArgs;
        }
    }
}
