using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Organisms.Phenomes.DebuggablePhenomes;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes;

namespace GeneticFaraday.GEP.Models.Organisms.Phenomes.DebuggablePhenomes
{
    public class DebuggableChromosome : DebuggableChromosomeBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="main">The "main()" IDebuggableGene in the IDebuggableChromosome.</param>
        public DebuggableChromosome(IDebuggableGene main) 
            : base(main)
        {
        }
    }
}
