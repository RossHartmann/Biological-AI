using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;

namespace GeneticFaraday.GEP.Models.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments
{
    public class ArgumentUnevaluatedValue : ArgumentUnevaluatedValueBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aminoAcid">If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of EvaluatedAminoAcid 
        /// then this is the IAminoAcid that will be evaluated.
        /// 
        /// If the ParameterType is AminoAcid, this is the IAminoAcid that will be
        /// passed.</param>
        public ArgumentUnevaluatedValue(IGEPAminoAcid aminoAcid) 
            : base(aminoAcid)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codon">If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of ConvertedCodon 
        /// then this is the ICodon that will be converted.</param>
        public ArgumentUnevaluatedValue(IGEPCodon codon) 
            : base(codon)
        {
        }
    }
}
