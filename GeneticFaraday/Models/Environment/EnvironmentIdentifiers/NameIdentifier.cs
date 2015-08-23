using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;

namespace GeneticFaraday.Models.Environment.EnvironmentIdentifiers
{
    public class NameIdentifier : IEnvironmentIdentifier
    {
        /// <summary>
        /// The name of the IEnvironment.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">The name of the IEnvironment.</param>
        public NameIdentifier(string name)
        {
            this.Name = name;
        }

        public bool Equals(IEnvironmentIdentifier other)
        {
            if (other == null)
                return false;
            else if (other is NameIdentifier)
                return this.Name == ((NameIdentifier)other).Name;
            else
                return false;
        }
    }
}
