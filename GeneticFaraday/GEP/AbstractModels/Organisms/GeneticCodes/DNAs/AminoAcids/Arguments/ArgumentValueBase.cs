using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments
{
    public abstract class ArgumentValueBase : IArgumentValue
    {
        /// <summary>
        /// If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of EvaluatedAminoAcid, 
        /// this is the value of the evaluated IAminoAcid.
        /// </summary>
        public IAminoAcidResult EvaluatedAminoAcid { get; private set; }

        /// <summary>
        /// If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of AminoAcid, 
        /// this is the IAminoAcid that will be passed.
        /// </summary>
        public IGEPAminoAcid AminoAcid { get; private set; }

        /// <summary>
        /// If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of ConvertedCodon 
        /// then this is the converted IConvertedCodon.
        /// </summary>
        public IConvertedCodon ConvertedCodon { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="evaluatedAminoAcid">If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of EvaluatedAminoAcid, 
        /// this is the value of the evaluated IAminoAcid.</param>
        protected ArgumentValueBase(IAminoAcidResult evaluatedAminoAcid)
        {
            this.EvaluatedAminoAcid = evaluatedAminoAcid;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aminoAcid">If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of AminoAcid, 
        /// this is the IAminoAcid that will be passed.</param>
        protected ArgumentValueBase(IGEPAminoAcid aminoAcid)
        {
            this.AminoAcid = aminoAcid;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="convertedCodon">If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of ConvertedCodon 
        /// then this is the converted IConvertedCodon.</param>
        protected ArgumentValueBase(IConvertedCodon convertedCodon)
        {
            this.ConvertedCodon = convertedCodon;
        }

    }
}
