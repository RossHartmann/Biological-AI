using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;

namespace GeneticFaraday.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids
{
    /// <summary>
    /// An IAminoAcid is the unit for which an ICodon encodes.
    /// 
    /// This is what a "unit" of DNA would have been if we didn't encode the DNA using Codons.
    /// Using Codons, however, allows redundancy and is better for evolution.
    /// </summary>
    public interface IAminoAcid
    {
        /// <summary>
        /// The ICodon that encoded for this IAminoAcid.
        /// </summary>
        ICodon Codon { get; }
    }
}
