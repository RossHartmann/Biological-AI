using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;

namespace GeneticFaraday.GEP.Contracts.Organisms.Genes
{
    public interface IGEPGenePhenotype : IGenePhenotype
    {
        /// <summary>
        /// The root IGEPAminoAcid of an IGEPGene. 
        /// The IGEPAminoAcid and its children (i.e. its IArguments)
        /// make-up the phenotype of the IGEPGene.
        /// </summary>
        IGEPAminoAcid RootAminoAcid { get; }
    }
}
