using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Phenomes;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes;

namespace GeneticFaraday.GEP.Contracts.Organisms.Phenomes
{
    public interface IGEPPhenome : IPhenome
    {
        /// <summary>
        /// The IDebuggableChromosomes that belong to this IDebuggablePhenome.
        /// 
        /// The first IDebuggableChromosome is run first and the Chromosomes.Count-1 IDebuggableChromosome is run last.
        /// </summary>
        List<IDebuggableChromosome> Chromosomes { get; }
    }
}
