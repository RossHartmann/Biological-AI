using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids
{
    /// <summary>
    /// The result of executing an IAminoAcid.
    /// </summary>
    public interface IAminoAcidResult
    {
        double Value { get; }
    }
}
