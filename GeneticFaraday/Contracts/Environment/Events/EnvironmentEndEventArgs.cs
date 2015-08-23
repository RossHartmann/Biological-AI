using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Environment.Events
{
    public class EnvironmentEndEventArgs : EventArgs
    {
        /// <summary>
        /// The IEnvironment that just ended.
        /// </summary>
        public IEnvironment Environment { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="environment">The IEnvironment that just ended.</param>
        public EnvironmentEndEventArgs(IEnvironment environment)
        {
            this.Environment = environment;
        }
    }
}
