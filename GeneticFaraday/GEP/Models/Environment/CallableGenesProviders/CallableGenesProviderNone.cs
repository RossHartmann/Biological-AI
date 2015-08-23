using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Environment.CallableGenesProviders;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;

namespace GeneticFaraday.GEP.Models.Environment.CallableGenesProviders
{
    /// <summary>
    /// Provides the Callable Genes (i.e. the IGenes that can be executed) by an IGene.
    /// 
    /// No callable genes will be returned.
    /// </summary>
    public class CallableGenesProviderNone : CallableGenesProviderBase
    {
        /// <summary>
        /// No callable genes will be returned.
        /// </summary>
        /// <param name="sourceGene"></param>
        /// <returns></returns>
        public override IList<IGEPGene> GetCallableGenes(IGEPGene sourceGene)
        {
            return new IGEPGene[] {};
        }
    }
}
