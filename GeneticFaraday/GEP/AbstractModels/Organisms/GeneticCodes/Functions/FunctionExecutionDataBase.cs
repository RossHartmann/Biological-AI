using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.Functions
{
    public abstract class FunctionExecutionDataBase : IFunctionExecutionData
    {
        /// <summary>
        /// The IGeneticCode used by the IDNA of the executing IGEPAllele.
        /// </summary>
        public IGEPGeneticCode GeneticCode { get { return this.ExecutingAllele.Parent.GeneticCode; } }
        
        /// <summary>
        /// The IGEPAllele that is executing the IFunction.
        /// </summary>
        public IGEPAllele ExecutingAllele { get; private set; }

        /// <summary>
        /// The IRegistries that are readable and writable by the executing IFunction.
        /// </summary>
        public IRegistryCollection AvailableRegistries { get; private set; }

        /// <summary>
        /// The IGEPGenes that can be called by the executing IGene.
        /// </summary>
        public IList<IGEPGene> CallableGenes { get; private set; }

        /// <summary>
        /// The IGeneExecutionData for each IGEPGene in the parent IGEPOrganism.
        /// </summary>
        public IDictionary<IGeneIdentifier, IGeneExecutionData> GeneExecutionDataDictionary { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="executingAllele">The IGEPAllele that is executing the IFunction.</param>
        /// <param name="availableRegistries">The IRegistries that are readable and writable by the executing IFunction.</param>
        /// <param name="callableGenes">The IGEPGenes that can be called by the executing IGene.</param>
        /// <param name="geneExecutionDataDictionary">The IGeneExecutionData for each IGEPGene in the parent IGEPOrganism.</param>
        protected FunctionExecutionDataBase(IGEPAllele executingAllele, IRegistryCollection availableRegistries,
            IList<IGEPGene> callableGenes, IDictionary<IGeneIdentifier, IGeneExecutionData> geneExecutionDataDictionary)
        {
            this.ExecutingAllele = executingAllele;
            this.AvailableRegistries = availableRegistries;
            this.CallableGenes = callableGenes;
            this.GeneExecutionDataDictionary = geneExecutionDataDictionary;
        }
    }
}
