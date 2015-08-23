using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;

namespace GeneticFaraday.AbstractModels.Organisms.GeneticCodes.Codons.CodonConverters
{
    public abstract class ConvertedCodonBase : IConvertedCodon
    {
        /// <summary>
        /// The value after a ICodon is converted by an ICodonConverter.
        /// </summary>
        public object Value { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value after a ICodon is converted by an ICodonConverter.</param>
        protected ConvertedCodonBase(object value)
        {
            this.Value = value;
        }
    }
}
