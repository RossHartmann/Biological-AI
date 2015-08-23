using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters
{
    public interface IConvertedCodon
    {
        /// <summary>
        /// The value after a ICodon is converted by an ICodonConverter.
        /// </summary>
        object Value { get; }
    }
}
