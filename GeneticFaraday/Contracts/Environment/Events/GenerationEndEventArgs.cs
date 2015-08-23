using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Environment.Events
{
    public class GenerationEndEventArgs : EventArgs
    {
        /// <summary>
        /// The IEnvironment whose generation just ended.
        /// </summary>
        public IEnvironment Environment { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="environment">The IEnvironment whose generation just ended.</param>
        public GenerationEndEventArgs(IEnvironment environment)
        {
            this.Environment = environment;
        }
    }
}
