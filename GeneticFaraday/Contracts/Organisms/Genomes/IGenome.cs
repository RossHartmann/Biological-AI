using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;

namespace GeneticFaraday.Contracts.Organisms.Genomes
{
    /// <summary>
    /// An IGenome is basically a long sequence of IGenes.
    /// 
    /// It is the "flattened" version of an IOrganism.
    /// </summary>
    public interface IGenome : IList<IGenomeUnit>
    {
        /// <summary>
        /// The IGeneticCode to which this IGenome adheres.
        /// </summary>
        IGeneticCode GeneticCode { get; }

        /// <summary>
        /// Converts this IGenome to its corresponding IOrganism.
        /// </summary>
        /// <returns></returns>
        IOrganism ToOrganism(IEnvironment environment);

        /// <summary>
        /// Converts this IGenome into its string representation.
        /// </summary>
        /// <returns></returns>
        string ToGenomeString();
    }
}
