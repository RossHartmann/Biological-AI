using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.GeneticCodes.DNAs;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.DNAs;
using GeneticFaraday.GEP.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.DNAs;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.DNAs
{
    public abstract class GEPDNABase : DNABase, IGEPDNA
    {
        public override IDNA ShallowCopy()
        {
            var other = new GEPDNA();
            foreach (var nucleotide in this)
                other.AddNucleotide(nucleotide);
            return other;
        }

        /// <summary>
        /// The IGEPAllele that owns this IDNA.
        /// </summary>
        new public IGEPAllele Parent { get; set; }

        /// <summary>
        /// The IGEPGeneticCode to which this IGEPDNA adheres.
        /// </summary>
        new public IGEPGeneticCode GeneticCode { get { return this.Parent.GeneticCode; } }
    }
}
