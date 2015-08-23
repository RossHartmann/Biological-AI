using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Universe;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;

namespace GeneticFaraday.Models.Universe
{
    public class Universe : UniverseBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="geneticCode">The IGeneticCode to which all IOrganisms in this IUniverse adhere.</param>
        public Universe(IGeneticCode geneticCode) 
            : base(geneticCode)
        {
        }
    }
}
