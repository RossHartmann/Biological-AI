using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons
{
    [Serializable]
    public enum CodonType
    {
        /// <summary>
        /// Indicates that the ICodon is a Standard ICodon.
        /// </summary>
        Standard,
        /// <summary>
        /// Indicates that the ICodon signals that the IDNA should stop
        /// gathering IFunctions with parameters.
        /// </summary>
        Stop
    }
}
