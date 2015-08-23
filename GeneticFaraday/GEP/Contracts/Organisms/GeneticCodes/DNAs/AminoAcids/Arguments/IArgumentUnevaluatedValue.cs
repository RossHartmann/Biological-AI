using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Codons;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments
{
    /// <summary>
    /// The unevaluated value of an IArgument.
    /// 
    /// This will be set while the Genotype of the IOrganism is being parsed
    /// into the Phenotype.
    /// 
    /// The IArgument's IArgumentValue will be set upon 
    /// IAminoAcid execution (i.e. Phenotype execution).
    /// </summary>
    public interface IArgumentUnevaluatedValue
    {
        /// <summary>
        /// If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of EvaluatedAminoAcid 
        /// then this is the IAminoAcid that will be evaluated.
        /// 
        /// If the ParameterType is AminoAcid, this is the IAminoAcid that will be
        /// passed.
        /// </summary>
        IGEPAminoAcid AminoAcid { get; }

        /// <summary>
        /// If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of ConvertedCodon 
        /// then this is the ICodon that will be converted.
        /// </summary>
        IGEPCodon Codon { get; }
    }
}
