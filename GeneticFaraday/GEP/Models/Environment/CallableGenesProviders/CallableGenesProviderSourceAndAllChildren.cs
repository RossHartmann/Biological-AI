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
    /// The callable genes will be the source gene and all of the source gene's 
    /// children and their children's children, etc.
    /// </summary>
    public class CallableGenesProviderSourceAndAllChildren : CallableGenesProviderBase
    {
        /// <summary>
        /// The callable genes will be the source gene and all of the source gene's 
        /// children and their children's children, etc.
        /// </summary>
        /// <param name="sourceGene"></param>
        /// <returns></returns>
        public override IList<IGEPGene> GetCallableGenes(IGEPGene sourceGene)
        {
            var callableGenes = new List<IGEPGene>() { sourceGene };
            foreach (IGEPGene childGene in sourceGene.GetChildGenes())
                callableGenes.AddRange(this.GetCallableGenes(childGene));
            return callableGenes;
        }
    }
}
