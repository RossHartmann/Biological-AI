using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Models.Organisms.GeneticCodes.Functions
{
    public class FunctionExecutionData : FunctionExecutionDataBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="executingAllele">The IGEPAllele that is executing the IFunction.</param>
        /// <param name="availableRegistries">The IRegistries that are readable and writable by the executing IFunction.</param>
        /// <param name="callableGenes">The IGEPGenes that can be called by the executing IGene.</param>
        /// <param name="geneExecutionDataDictionary">The IGeneExecutionData for each IGEPGene in the parent IGEPOrganism.</param>
        public FunctionExecutionData(IGEPAllele executingAllele, 
            IRegistryCollection availableRegistries, IList<IGEPGene> callableGenes, 
            IDictionary<IGeneIdentifier, IGeneExecutionData> geneExecutionDataDictionary) : base(executingAllele, availableRegistries, callableGenes, geneExecutionDataDictionary)
        {
        }
    }
}
