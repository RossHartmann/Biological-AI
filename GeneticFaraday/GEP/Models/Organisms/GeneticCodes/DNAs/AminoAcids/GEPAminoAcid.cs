using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Codons;

namespace GeneticFaraday.GEP.Models.Organisms.GeneticCodes.DNAs.AminoAcids
{
    public class GEPAminoAcid : GEPAminoAcidBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codon">The IGEPCodon that encoded for this IGEPAminoAcid.</param>
        /// <param name="useParameterlessFunction">If true, The Parameterless IFunction in the ICodon will be the IFunction
        /// that is executed.
        /// 
        /// If false, the Primary IFunction in the ICodon will be used.</param>
        public GEPAminoAcid(IGEPCodon codon, bool useParameterlessFunction) 
            : base(codon, useParameterlessFunction)
        {
        }
    }
}
