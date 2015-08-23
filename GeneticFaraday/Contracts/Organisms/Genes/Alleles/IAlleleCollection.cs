using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Organisms.Genes.Alleles
{
    public interface IAlleleCollection : IList<IAllele>
    {
        /// <summary>
        /// Adds the specified IAllele to the IAlleleCollection.
        /// </summary>
        /// <param name="allele"></param>
        /// <returns>The added IAllele.</returns>
        new IAllele Add(IAllele allele);

        /// <summary>
        /// Returns the IAllele at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        IAllele AlleleAt(int index);
    }
}
