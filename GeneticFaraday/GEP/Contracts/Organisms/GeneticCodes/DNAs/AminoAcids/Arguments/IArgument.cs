using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions.Parameters;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments
{
    /// <summary>
    /// IArgument is the actual argument that will be passed to 
    /// an IAminoAcid (i.e. to the actual function call by an ICodon).
    /// 
    /// IParameter is the defnition of the parameter to which this IArgument will
    /// be passings its value.
    /// </summary>
    public interface IArgument
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
        IArgumentUnevaluatedValue UnevaluatedValue { get; set; }

        /// <summary>
        /// The evaluated value of the IArgument.
        /// To be set upon IAminoAcid execution (i.e. Phenotype execution).
        /// </summary>
        IArgumentValue Value { get; set; }

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
        bool SetArgumentValueAsEvaluatedAminoAcid(IGEPGene executingGene, IGEPGeneSurroundings geneSurroundings);

        /// <summary>
        /// Sets the IAminoAcid in this.Value to the IAminoAcid as gathered from this.UnevaluatedValue.
        /// </summary>
        void SetArgumentValueAsAminoAcid();

        /// <summary>
        /// Converts the IGEPCodon in this.UnevaluatedValue to its IConvertedCodon form.
        /// Sets the IConvertedCodon value to the result of the conversion.
        /// </summary>
        /// <param name="executingGene">The IGEPGene that is currently populating this IArgument.</param>
        /// <param name="parameter">The IParameter that is associated with this IArgument.</param>
        void SetArgumentValueAsConvertedCodon(IGEPGene executingGene, IParameter parameter);
    }
}
