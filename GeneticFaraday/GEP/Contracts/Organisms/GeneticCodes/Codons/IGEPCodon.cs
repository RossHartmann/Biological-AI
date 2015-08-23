using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Codons
{
    public interface IGEPCodon : ICodon
    {
        /// <summary>
        /// The pair of IFunctions for which this ICodon encodes.
        /// </summary>
        IFunctionPair Functions { get; }


    }
}
