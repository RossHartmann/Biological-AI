using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions
{
    public interface IFunctionExecutionData
    {
        /// <summary>
        /// The IGeneticCode used by the IDNA of the executing IGEPAllele.
        /// </summary>
        IGEPGeneticCode GeneticCode { get; }

        /// <summary>
        /// The IGEPAllele that is executing the IFunction.
        /// </summary>
        IGEPAllele ExecutingAllele { get; }

        /// <summary>
        /// The IRegistries that are readable and writable by the executing IFunction.
        /// </summary>
        IRegistryCollection AvailableRegistries { get; }

        /// <summary>
        /// The IGEPGenes that can be called by the executing IGene.
        /// </summary>
        IList<IGEPGene> CallableGenes { get; }

        /// <summary>
        /// The IGeneExecutionData for each IGEPGene in the parent IGEPOrganism.
        /// </summary>
        IDictionary<IGeneIdentifier, IGeneExecutionData> GeneExecutionDataDictionary { get; }
    }
}
