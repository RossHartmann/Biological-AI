using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.GeneticCodes.Codons.CodonConverters;

namespace GeneticFaraday.Models.Organisms.GeneticCodes.Codons.CodonConverters
{
    public class ConvertedCodon : ConvertedCodonBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value after a ICodon is converted by an ICodonConverter.</param>
        public ConvertedCodon(object value) 
            : base(value)
        {
        }
    }
}
