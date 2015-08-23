using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions
{
    /// <summary>
    /// A pair of IFunctionIdentifiers that identify a pair of IFunctions.
    /// 
    /// The Primary IFunction can have any amount of parameters.
    /// The secondary IFunction is parameterless.
    /// </summary>
    public interface IFunctionPair
    {
        /// <summary>
        /// The identifier of the Primary Function in this IFunctionPair.
        /// The IFunction can have any number of parameters (or no parameters).
        /// 
        /// This is the IFunction for which the ICodon primarily encodes.
        /// </summary>
        IFunctionIdentifier PrimaryFunction { get; }

        /// <summary>
        /// The identifier of a Parameterless IFunction that will be used if a parameterless
        /// IFunction is required.
        /// 
        /// If a ICodon is in the "tail" of the IDNA (i.e. in the portion of the IDNA that will only 
        /// accept "terminal" IFunctions), it will use this parameterless IFunction.
        /// </summary>
        IFunctionIdentifier ParameterlessFunction { get; }
    }
}
