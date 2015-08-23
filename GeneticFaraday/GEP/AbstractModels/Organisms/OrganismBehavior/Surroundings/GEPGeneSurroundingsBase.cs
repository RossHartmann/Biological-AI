using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.OrganismBehavior.Surroundings
{
    public abstract class GEPGeneSurroundingsBase : GeneSurroundingsBase, IGEPGeneSurroundings
    {
        /// <summary>
        /// The data passed to the parent IGEPChromosome.
        /// </summary>
        new public IGEPChromosomeSurroundings ChromosomeSurroundings { get { return (IGEPChromosomeSurroundings)base.ChromosomeSurroundings; } }

        /// <summary>
        /// The IGeneExecutionData for each IGEPGene in the parent IGEPOrganism.
        /// </summary>
        public IDictionary<IGeneIdentifier, IGeneExecutionData> GeneExecutionDataDictionary { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chromosomeSurroundings">The data passed to the parent IGEPChromosome.</param>
        /// <param name="geneExecutionDataDictionary">The IGeneExecutionData for each IGEPGene in the parent IGEPOrganism.</param>
        protected GEPGeneSurroundingsBase(IGEPChromosomeSurroundings chromosomeSurroundings,
            IDictionary<IGeneIdentifier, IGeneExecutionData> geneExecutionDataDictionary) 
            : base(chromosomeSurroundings)
        {
            this.GeneExecutionDataDictionary = geneExecutionDataDictionary;
        }
    }
}
