using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes
{
    /// <summary>
    /// An IVariable is the named result of an IDebuggableAminoAcid.
    /// </summary>
    public interface IVariable
    {
        /// <summary>
        /// The name of the IVariable.
        /// </summary>
        string Name { get; }
    }
}
