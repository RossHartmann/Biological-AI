using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.Functions.Parameters;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions.Parameters;

namespace GeneticFaraday.GEP.Models.Organisms.GeneticCodes.Functions.Parameters
{
    public class Parameter : ParameterBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameterType">The type of an IParameter.</param>
        /// <param name="converterIdentifier">Only used if the ParameterType is ParameterType.ConvertedCodon.
        /// 
        /// The ICodonConverter as identified by this ICodonConverterIdentifier
        /// will be used to convert an ICodon and will then be passed to
        /// the IArgument that this IParameter defines.</param>
        public Parameter(ParameterType parameterType, 
            ICodonConverterIdentifier converterIdentifier = null) 
            : base(parameterType, converterIdentifier)
        {
        }

        /// <summary>
        /// Creates a shallow copy of this IParameter.
        /// </summary>
        /// <returns></returns>
        public override IParameter ShallowCopy()
        {
            return new Parameter(parameterType: this.ParameterType,
                                 converterIdentifier: this.ConverterIdentifier == null ? null : this.ConverterIdentifier.ShallowCopy());
        }
    }
}
