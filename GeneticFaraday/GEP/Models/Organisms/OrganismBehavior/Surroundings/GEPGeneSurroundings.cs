using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.AbstractModels.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;

namespace GeneticFaraday.GEP.Models.Organisms.OrganismBehavior.Surroundings
{
    public class GEPGeneSurroundings : GEPGeneSurroundingsBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chromosomeSurroundings">The data passed to the parent IGEPChromosome.</param>
        /// <param name="geneExecutionDataDictionary">The IGeneExecutionData for each IGEPGene in the parent IGEPOrganism.</param>
        public GEPGeneSurroundings(IGEPChromosomeSurroundings chromosomeSurroundings, 
            IDictionary<IGeneIdentifier, IGeneExecutionData> geneExecutionDataDictionary) 
            : base(chromosomeSurroundings, geneExecutionDataDictionary)
        {
        }
    }
}
