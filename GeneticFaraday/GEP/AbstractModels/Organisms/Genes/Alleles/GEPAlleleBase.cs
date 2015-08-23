using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.Genes.Alleles;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.DNAs;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.Genes.Alleles
{
    public abstract class GEPAlleleBase : AlleleBase, IGEPAllele
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dna">The DNA sequence of the IAllele.</param>
        protected GEPAlleleBase(IGEPDNA dna) 
            : base(dna)
        {
            this.DNA = dna;
            this.DNA.Parent = this;
        }

        new public IGEPGene Parent { get { return (IGEPGene)base.Parent; } set { base.Parent = value; } }

        /// <summary>
        /// The IGEPGeneticCode to which this IGEPAllele adheres.
        /// </summary>
        new public IGEPGeneticCode GeneticCode { get { return this.Parent.GeneticCode; } }

        /// <summary>
        /// The DNA sequence of the IGEPAllele.
        /// </summary>
        new public IGEPDNA DNA { get; private set; }

    }
}
