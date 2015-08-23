using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.DNAs;
using GeneticFaraday.GEP.Contracts.Organisms.Genes.Alleles;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs
{
    public interface IGEPDNA : IDNA
    {
        /// <summary>
        /// The IGEPAllele that owns this IDNA.
        /// </summary>
        new IGEPAllele Parent { get; set; }

        /// <summary>
        /// The IGEPGeneticCode to which this IGEPDNA adheres.
        /// </summary>
        new IGEPGeneticCode GeneticCode { get; }
    }
}
