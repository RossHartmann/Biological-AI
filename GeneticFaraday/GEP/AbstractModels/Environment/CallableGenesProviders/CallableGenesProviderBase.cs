using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Environment.CallableGenesProviders;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;

namespace GeneticFaraday.GEP.AbstractModels.Environment.CallableGenesProviders
{
    public abstract class CallableGenesProviderBase : ICallableGenesProvider
    {
        /// <summary>
        /// Returns the IGEPGenes that can be executed by the given source IGEPGene.
        /// </summary>
        /// <param name="sourceGene"></param>
        /// <returns></returns>
        public abstract IList<IGEPGene> GetCallableGenes(IGEPGene sourceGene);
    }
}
