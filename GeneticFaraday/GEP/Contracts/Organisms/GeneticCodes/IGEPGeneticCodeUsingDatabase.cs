using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes
{
    /// <summary>
    /// A GEPGeneticCode that stores ICodons in a database.
    /// </summary>
    public interface IGEPGeneticCodeUsingDatabase : IGEPGeneticCode
    {
        /// <summary>
        /// The unique name of the IGEPGeneticCode.
        /// </summary>
        string Name { get; }
    }
}
