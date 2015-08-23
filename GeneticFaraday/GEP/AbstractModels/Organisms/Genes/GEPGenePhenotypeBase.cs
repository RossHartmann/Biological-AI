using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.Genes
{
    public abstract class GEPGenePhenotypeBase : GenePhenotypeBase, IGEPGenePhenotype
    {
        /// <summary>
        /// The root IGEPAminoAcid of an IGEPGene. 
        /// The IGEPAminoAcid and its children (i.e. its IArguments)
        /// make-up the phenotype of the IGEPGene.
        /// </summary>
        public IGEPAminoAcid RootAminoAcid { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rootAminoAcid">The root IGEPAminoAcid of an IGEPGene. 
        /// The IGEPAminoAcid and its children (i.e. its IArguments)
        /// make-up the phenotype of the IGEPGene.</param>
        protected GEPGenePhenotypeBase(IGEPAminoAcid rootAminoAcid)
        {
            this.RootAminoAcid = rootAminoAcid;
        }
    }
}
