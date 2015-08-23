using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes
{
    /// <summary>
    /// An IDebuggableGene is an IGEPChromosome that holds the IDebuggableGene of its
    /// Main IGEPGene.
    /// </summary>
    public interface IDebuggableChromosome
    {
        /// <summary>
        /// The "main()" IDebuggableGene in the IDebuggableChromosome.
        /// </summary>
        IDebuggableGene Main { get; }
    }
}
