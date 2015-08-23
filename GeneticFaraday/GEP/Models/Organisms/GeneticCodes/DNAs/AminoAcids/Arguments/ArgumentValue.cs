using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;

namespace GeneticFaraday.GEP.Models.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments
{
    public class ArgumentValue : ArgumentValueBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="evaluatedAminoAcid">If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of EvaluatedAminoAcid, 
        /// this is the value of the evaluated IAminoAcid.</param>
        public ArgumentValue(IAminoAcidResult evaluatedAminoAcid) 
            : base(evaluatedAminoAcid)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aminoAcid">If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of AminoAcid, 
        /// this is the IAminoAcid that will be passed.</param>
        public ArgumentValue(IGEPAminoAcid aminoAcid) 
            : base(aminoAcid)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="convertedCodon">If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of ConvertedCodon 
        /// then this is the converted IConvertedCodon.</param>
        public ArgumentValue(IConvertedCodon convertedCodon) 
            : base(convertedCodon)
        {
        }
    }
}
