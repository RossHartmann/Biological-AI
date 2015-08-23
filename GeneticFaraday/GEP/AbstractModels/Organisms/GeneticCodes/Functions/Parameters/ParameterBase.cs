using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions.Parameters;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.Functions.Parameters
{
    public abstract class ParameterBase : IParameter
    {
        public abstract IParameter ShallowCopy();

        /// <summary>
        /// The type of an IParameter.
        /// </summary>
        public ParameterType ParameterType { get; private set; }

        /// <summary>
        /// Only used if the ParameterType is ParameterType.ConvertedCodon.
        /// 
        /// The ICodonConverter as identified by this ICodonConverterIdentifier
        /// will be used to convert an ICodon and will then be passed to
        /// the IArgument that this IParameter defines.
        /// </summary>
        public ICodonConverterIdentifier ConverterIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameterType">The type of an IParameter.</param>
        /// <param name="converterIdentifier">Only used if the ParameterType is ParameterType.ConvertedCodon.
        /// 
        /// The ICodonConverter as identified by this ICodonConverterIdentifier
        /// will be used to convert an ICodon and will then be passed to
        /// the IArgument that this IParameter defines.</param>
        protected ParameterBase(ParameterType parameterType, ICodonConverterIdentifier converterIdentifier = null)
        {
            this.ParameterType = parameterType;
            this.ConverterIdentifier = converterIdentifier;
        }
    }
}
