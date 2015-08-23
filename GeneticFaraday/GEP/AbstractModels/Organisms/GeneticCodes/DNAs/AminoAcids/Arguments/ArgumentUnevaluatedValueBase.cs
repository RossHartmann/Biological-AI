using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments
{
    public abstract class ArgumentUnevaluatedValueBase : IArgumentUnevaluatedValue
    {
        /// <summary>
        /// If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of EvaluatedAminoAcid 
        /// then this is the IAminoAcid that will be evaluated.
        /// 
        /// If the ParameterType is AminoAcid, this is the IAminoAcid that will be
        /// passed.
        /// </summary>
        public IGEPAminoAcid AminoAcid { get; private set; }

        /// <summary>
        /// If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of ConvertedCodon 
        /// then this is the ICodon that will be converted.
        /// </summary>
        public IGEPCodon Codon { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aminoAcid">If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of EvaluatedAminoAcid 
        /// then this is the IAminoAcid that will be evaluated.
        /// 
        /// If the ParameterType is AminoAcid, this is the IAminoAcid that will be
        /// passed.</param>
        protected ArgumentUnevaluatedValueBase(IGEPAminoAcid aminoAcid)
        {
            this.AminoAcid = aminoAcid;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codon">If the IArgument's associated IParameter (i.e. the parameter to 
        /// which the argument is being passed) has a ParameterType of ConvertedCodon 
        /// then this is the ICodon that will be converted.</param>
        protected ArgumentUnevaluatedValueBase(IGEPCodon codon)
        {
            this.Codon = codon;
        }
    }
}
