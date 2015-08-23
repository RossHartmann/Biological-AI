using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs;

namespace GeneticFaraday.GEP.Contracts.Organisms.Genes.Alleles
{
    public interface IGEPAllele : IAllele
    {
        new IGEPGene Parent { get; set; }

        /// <summary>
        /// The IGEPGeneticCode to which this IGEPAllele adheres.
        /// </summary>
        new IGEPGeneticCode GeneticCode { get; }

        /// <summary>
        /// The DNA sequence of the IGEPAllele.
        /// </summary>
        new IGEPDNA DNA { get; }
    }
}
