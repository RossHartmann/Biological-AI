using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments
{
    /// <summary>
    /// The evaluated value of an IArgument.
    /// 
    /// To be set upon IAminoAcid execution (i.e. Phenotype execution).
    /// </summary>
    public interface IArgumentValue
    {
        /// <summary>
        /// If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of EvaluatedAminoAcid, 
        /// this is the value of the evaluated IAminoAcid.
        /// </summary>
        IAminoAcidResult EvaluatedAminoAcid { get; }

        /// <summary>
        /// If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of AminoAcid, 
        /// this is the IAminoAcid that will be passed.
        /// </summary>
        IGEPAminoAcid AminoAcid { get; }

        /// <summary>
        /// If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of ConvertedCodon 
        /// then this is the converted IConvertedCodon.
        /// </summary>
        IConvertedCodon ConvertedCodon { get; }
    }
}
