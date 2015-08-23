using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.Phenomes.DebuggablePhenomes
{
    public abstract class DebuggableChromosomeBase : IDebuggableChromosome
    {
        /// <summary>
        /// The "main()" IDebuggableGene in the IDebuggableChromosome.
        /// </summary>
        public IDebuggableGene Main { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="main">The "main()" IDebuggableGene in the IDebuggableChromosome.</param>
        protected DebuggableChromosomeBase(IDebuggableGene main)
        {
            this.Main = main;
        }
    }
}
