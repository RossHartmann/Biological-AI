using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions.Parameters
{
    /// <summary>
    /// An IParameter is a "parameter definition." It contains the information
    /// about the parameter type.
    /// 
    /// See "IArgument" for the actual argument that will be passed to 
    /// an IAminoAcid (i.e. to the actual function call by an ICodon).
    /// </summary>
    public interface IParameter : IShallowCopyable<IParameter>
    {
        /// <summary>
        /// The type of an IParameter.
        /// </summary>
        ParameterType ParameterType { get; }

        /// <summary>
        /// Only used if the ParameterType is ParameterType.ConvertedCodon.
        /// 
        /// The ICodonConverter as identified by this ICodonConverterIdentifier
        /// will be used to convert an ICodon and will then be passed to
        /// the IArgument that this IParameter defines.
        /// </summary>
        ICodonConverterIdentifier ConverterIdentifier { get; set; }
    }
}
