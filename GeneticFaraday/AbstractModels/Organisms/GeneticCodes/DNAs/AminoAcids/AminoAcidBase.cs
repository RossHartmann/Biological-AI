using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;

namespace GeneticFaraday.AbstractModels.Organisms.GeneticCodes.DNAs.AminoAcids
{
    public abstract class AminoAcidBase : IAminoAcid
    {
        /// <summary>
        /// The ICodon that encoded for this IAminoAcid.
        /// </summary>
        public ICodon Codon { get; private set; }

        protected AminoAcidBase(ICodon codon)
        {
            this.Codon = codon;
        }
    }
}
