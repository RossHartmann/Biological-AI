using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Universe;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;

namespace GeneticFaraday.GEP.Contracts.Universe
{
    public interface IGEPUniverse : IUniverse, IGEPEnvironmentCollection
    {
        /// <summary>
        /// The IGEPGeneticCode to which all IGEPOrganisms in this IGEPUniverse adhere.
        /// </summary>
        new IGEPGeneticCode GeneticCode { get; }
    }
}
