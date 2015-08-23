using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.GEP.AbstractModels.Organisms.Genes.Alleles;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs;

namespace GeneticFaraday.GEP.Models.Organisms.Genes.Alleles
{
    public class GEPAllele : GEPAlleleBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dna">The DNA sequence of the IAllele.</param>
        public GEPAllele(IGEPDNA dna) 
            : base(dna)
        {
        }

        public override IAllele ShallowCopy()
        {
            var dnaCopy = (IGEPDNA)this.DNA.ShallowCopy();
            var copy = new GEPAllele(dnaCopy)
                           {
                               IsRecessive = this.IsRecessive
                           };
            dnaCopy.Parent = copy;
            return copy;
        }

    }
}
