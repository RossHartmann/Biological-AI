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
    /// The callable genes will be the source gene and all of the source gene's immediate children.
    /// </summary>
    public class CallableGenesProviderSourceAndFirstLevelChildren : CallableGenesProviderBase
    {
        /// <summary>
        /// The callable genes will be the source gene and all of the source gene's immediate children.
        /// </summary>
        /// <param name="sourceGene"></param>
        /// <returns></returns>
        public override IList<IGEPGene> GetCallableGenes(IGEPGene sourceGene)
        {
            var callableGenes = new List<IGEPGene>() { sourceGene };
            callableGenes.AddRange(sourceGene.GetChildGenes().Cast<IGEPGene>());
            return callableGenes;
        }
    }
}
