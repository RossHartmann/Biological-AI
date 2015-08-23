using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.Phenomes.DebuggablePhenomes
{
    public abstract class VariableBase : IVariable
    {
        /// <summary>
        /// The name of the IVariable.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">The name of the IVariable.</param>
        protected VariableBase(string name)
        {
            this.Name = name;
        }
    }
}
