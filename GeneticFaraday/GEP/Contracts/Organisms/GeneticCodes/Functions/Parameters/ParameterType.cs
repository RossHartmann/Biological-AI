using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions.Parameters
{
    /// <summary>
    /// The type of an IParameter.
    /// </summary>
    public enum ParameterType
    {
        /// <summary>
        /// Indicates that the value given to the IParameter at run-time
        /// should be the result of the evaluation of an Amino Acid (i.e.
        /// the result of executing an Amino Acid).
        /// </summary>
        EvaluatedAminoAcid,
        /// <summary>
        /// Indicates that the value given to the IParameter at run-time
        /// should be an IAminoAcid (i.e. an actual function).
        /// </summary>
        AminoAcid,
        /// <summary>
        /// Indicates that the value given to the IParameter at run-time
        /// should be an IConvertedCodon as converted by the ICodonConverter
        /// as specified by the ICodonConverterIdentifier in this IParameter.
        /// </summary>
        ConvertedCodon
    }
}
