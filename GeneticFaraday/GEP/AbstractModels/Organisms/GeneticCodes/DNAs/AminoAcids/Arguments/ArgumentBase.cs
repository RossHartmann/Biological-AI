using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions.Parameters;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments
{
    /// <summary>
    /// IArgument is the actual argument that will be passed to 
    /// an IAminoAcid (i.e. to the actual function call by an ICodon).
    /// 
    /// IParameter is the defnition of the parameter to which this IArgument will
    /// be passings its value.
    /// </summary>
    public abstract class ArgumentBase : IArgument
    {
        /// <summary>
        /// The unevaluated value of the IArgument.
        /// 
        /// This will be set while the Genotype of the IOrganism is being parsed
        /// into the Phenotype.
        /// 
        /// The IArgument's IArgumentValue will be set upon 
        /// IAminoAcid execution (i.e. Phenotype execution).
        /// </summary>
        public IArgumentUnevaluatedValue UnevaluatedValue { get; set; }

        /// <summary>
        /// The evaluated value of the IArgument.
        /// To be set upon IAminoAcid execution (i.e. Phenotype execution).
        /// </summary>
        public IArgumentValue Value { get; set; }

        /// <summary>
        /// Sets the "EvaluatedAminoAcid" IAminoAcidResult in this.Value to the evaluated IAminoAcid 
        /// where the IAminoAcid is gathered from this.UnevaluatedValue.
        /// 
        /// Returns true on success. Returns false if the unevaluated IAminoAcid surpassed the recursion
        /// maximum.
        /// </summary>
        /// <param name="executingGene">The IGEPGene that is currently populating this IArgument.</param>
        /// <param name="geneSurroundings">The IGEPGeneSurroundings that were passed to the executing IGEPGene.</param>
        /// <returns></returns>
        public bool SetArgumentValueAsEvaluatedAminoAcid(IGEPGene executingGene, IGEPGeneSurroundings geneSurroundings)
        {
            var aminoAcidResult = executingGene.ExecuteAminoAcid(aminoAcid: this.UnevaluatedValue.AminoAcid,
                                                                geneSurroundings: geneSurroundings);

            // If the IArgument couldn't be evaluated because of
            // a "stack overflow" then return false to indicate that
            // the recursion level was surpassed.
            if (aminoAcidResult == null)
                return false;

            this.Value = new ArgumentValue(evaluatedAminoAcid: aminoAcidResult);
            return true;
        }

        /// <summary>
        /// Sets the IAminoAcid in this.Value to the IAminoAcid as gathered from this.UnevaluatedValue.
        /// </summary>
        public void SetArgumentValueAsAminoAcid()
        {
            this.Value = new ArgumentValue(aminoAcid: this.UnevaluatedValue.AminoAcid);
        }

        /// <summary>
        /// Converts the IGEPCodon in this.UnevaluatedValue to its IConvertedCodon form.
        /// Sets the IConvertedCodon value to the result of the conversion.
        /// </summary>
        public void SetArgumentValueAsConvertedCodon(IGEPGene executingGene, IParameter parameter)
        {
            this.Value =
                        new ArgumentValue(
                            convertedCodon:
                                this.UnevaluatedValue.Codon.Convert(geneticCode: executingGene.GeneticCode,
                                                                        codonConverterIdentifier:
                                                                            parameter.ConverterIdentifier));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unevaluatedValue">The unevaluated value of the IArgument.
        /// 
        /// This will be set while the Genotype of the IOrganism is being parsed
        /// into the Phenotype.
        /// 
        /// The IArgument's IArgumentValue will be set upon 
        /// IAminoAcid execution (i.e. Phenotype execution).</param>
        protected ArgumentBase(IArgumentUnevaluatedValue unevaluatedValue)
        {
            this.UnevaluatedValue = unevaluatedValue;
        }
    }
}
