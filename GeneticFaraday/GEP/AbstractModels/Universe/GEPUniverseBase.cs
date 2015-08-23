using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Universe;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Universe;

namespace GeneticFaraday.GEP.AbstractModels.Universe
{
    public abstract class GEPUniverseBase : UniverseBase, IGEPUniverse
    {
        /// <summary>
        /// The IGEPGeneticCode to which all IGEPOrganisms in this IGEPUniverse adhere.
        /// </summary>
        new public IGEPGeneticCode GeneticCode { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="geneticCode">The IGEPGeneticCode to which all IGEPOrganisms in this IGEPUniverse adhere.</param>
        protected GEPUniverseBase(IGEPGeneticCode geneticCode) 
            : base(geneticCode)
        {
            this.GeneticCode = geneticCode;
        }

        new public IEnumerator<IGEPEnvironment> GetEnumerator()
        {
            return this.Cast<IGEPEnvironment>().GetEnumerator();
        }

        /// <summary>
        /// The added IEnvironment must be an IGEPEnvironment.
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
        new public IGEPEnvironment Add(IEnvironment environment)
        {
            return (IGEPEnvironment)base.Add(environment);
        }

        public IGEPEnvironment Add(IGEPEnvironment environment)
        {
            return this.Add(environment as IEnvironment);
        }
    }
}
