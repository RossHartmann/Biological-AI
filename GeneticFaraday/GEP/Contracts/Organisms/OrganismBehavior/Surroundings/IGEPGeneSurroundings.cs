using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings
{
    public interface IGEPGeneSurroundings : IGeneSurroundings
    {
        /// <summary>
        /// The data passed to the parent IGEPChromosome.
        /// </summary>
        new IGEPChromosomeSurroundings ChromosomeSurroundings { get; }

        /// <summary>
        /// The IGeneExecutionData for each IGEPGene in the parent IGEPOrganism.
        /// </summary>
        IDictionary<IGeneIdentifier, IGeneExecutionData> GeneExecutionDataDictionary { get; }
    }
}
