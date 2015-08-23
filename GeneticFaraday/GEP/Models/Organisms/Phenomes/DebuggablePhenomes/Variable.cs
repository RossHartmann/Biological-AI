using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Organisms.Phenomes.DebuggablePhenomes;

namespace GeneticFaraday.GEP.Models.Organisms.Phenomes.DebuggablePhenomes
{
    public class Variable : VariableBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">The name of the IVariable.</param>
        public Variable(string name) 
            : base(name)
        {
        }
    }
}
