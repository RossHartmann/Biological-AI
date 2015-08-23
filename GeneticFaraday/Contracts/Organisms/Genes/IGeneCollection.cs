using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Organisms.Genes
{
    public interface IGeneCollection : IList<IGene>
    {
        /// <summary>
        /// Adds the specified IGene to the IGeneCollection.
        /// </summary>
        /// <param name="gene"></param>
        /// <returns>The added IGene.</returns>
        new IGene Add(IGene gene);

        /// <summary>
        /// Returns the IGene at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        IGene GeneAt(int index);
    }
}
