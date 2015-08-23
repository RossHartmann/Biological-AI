
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Models.Exceptions;
using GeneticFaraday.Models.Exceptions;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.Functions
{
    public abstract class FunctionPairBase : IFunctionPair
    {
        /// <summary>
        /// The identifier of the Primary Function in this IFunctionPair.
        /// The IFunction can have any number of parameters (or no parameters).
        /// 
        /// This is the IFunction for which the ICodon primarily encodes.
        /// </summary>
        public IFunctionIdentifier PrimaryFunction { get; private set; }

        /// <summary>
        /// The identifier of a Parameterless IFunction that will be used if a parameterless
        /// IFunction is required.
        /// 
        /// If a ICodon is in the "tail" of the IDNA (i.e. in the portion of the IDNA that will only 
        /// accept "terminal" IFunctions), it will use this parameterless IFunction.
        /// </summary>
        public IFunctionIdentifier ParameterlessFunction { get; private set; }

        protected FunctionPairBase(IGEPGeneticCode geneticCode, IFunctionIdentifier primaryFunction, 
            IFunctionIdentifier parameterlessFunction)
        {
            this.PrimaryFunction = primaryFunction;
            this.ParameterlessFunction = parameterlessFunction;

            if (this.PrimaryFunction == null || this.ParameterlessFunction == null)
                throw new GeneticCodeException("Both the Primary Function and the Parameterless Function must be provided.");

            if (!geneticCode.FunctionSet[this.ParameterlessFunction].IsParameterless)
                throw new GeneticCodeException("The given Parameterless Function must actually be parameterless.");
        }
    }
}
