using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;

namespace GeneticFaraday.GEP.Contracts.Environment.CallableGenesProviders
{
    /// <summary>
    /// Provides the Callable Genes (i.e. the IGEPGenes that can be executed) by an IGEPGene.
    /// </summary>
    public interface ICallableGenesProvider
    {
        /// <summary>
        /// Returns the IGEPGenes that can be executed by the given source IGEPGene.
        /// </summary>
        /// <param name="sourceGene"></param>
        /// <returns></returns>
        IList<IGEPGene> GetCallableGenes(IGEPGene sourceGene);
    }
}
