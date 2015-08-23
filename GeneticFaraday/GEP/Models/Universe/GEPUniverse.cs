using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Universe;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;

namespace GeneticFaraday.GEP.Models.Universe
{
    public class GEPUniverse : GEPUniverseBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="geneticCode">The IGEPGeneticCode to which all IGEPOrganisms in this IGEPUniverse adhere.</param>
        public GEPUniverse(IGEPGeneticCode geneticCode) 
            : base(geneticCode)
        {
        }
    }
}
