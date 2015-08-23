using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;

namespace GeneticFaraday.GEP.Models.Organisms.Genes
{
    public class GEPGenePhenotype : GEPGenePhenotypeBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rootAminoAcid">The root IGEPAminoAcid of an IGEPGene. 
        /// The IGEPAminoAcid and its children (i.e. its IArguments)
        /// make-up the phenotype of the IGEPGene.</param>
        public GEPGenePhenotype(IGEPAminoAcid rootAminoAcid) 
            : base(rootAminoAcid)
        {
        }
    }
}
