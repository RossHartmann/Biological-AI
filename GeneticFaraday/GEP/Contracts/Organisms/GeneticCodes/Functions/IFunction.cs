using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions.Parameters;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions
{
    /// <summary>
    /// An IFunction is a "function definition." It contains the information about the number
    /// of arguments to the function, how it will execute, etc.
    /// 
    /// See "IAminoAcid" for the actual function call by an ICodon.
    /// </summary>
    public interface IFunction : IParameterCollection, IEquatable<IFunction>, IComparable<IFunction>
    {
        /// <summary>
        /// The unique Identifier of the IFunction.
        /// </summary>
        IFunctionIdentifier Identifier { get; }

        /// <summary>
        /// The human-readable name of the IFunction. Doesn't necessarily uniquely identify this IFunction.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The base human-readable name of the IFunction. this is a more general name for the Function (than this.Name).
        /// </summary>
        string BaseName { get; }

        /// <summary>
        /// The area of the IFunction such as "Arithmetic" or "Registries", etc.
        /// </summary>
        string Area { get; }

        /// <summary>
        /// The number of inputs (i.e. IParameters) to this
        /// IFunction.
        /// </summary>
        int ParameterCount { get; }

        /// <summary>
        /// Indicates whether the IFunction is parameterless (i.e. has an ParameterCount of 0).
        /// </summary>
        bool IsParameterless { get; }

        /// <summary>
        /// The IRegistries that will be available to this IFunction when executing.
        /// 
        /// We can use IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" to get the appropriate
        /// IRegistry at run-time.
        /// 
        /// This design allows for adding multiple IRegistries of the same RegistryType but
        /// with different IRegistryIdentifiers. We could, for example, have two separate Global Registries
        /// and the executing IFunction will call the appropriate Global Registry based on its IRegistryIdentifier.
        /// </summary>
        IRegistryIdentifierCollection AvailableRegistries { get; }

        /// <summary>
        /// The Weight of the IFunction in the IGEPGeneticCode. The higher the weight, the 
        /// more ICodons that will encode for this IFunction.
        /// 
        /// A weight of 1 means that the IFunction is weighed the same as all other 
        /// standard IFunctions.
        /// </summary>
        double WeightInGeneticCode { get; }

        /// <summary>
        /// The method that executes the IFunction.
        /// </summary>
        FunctionExecute ExecuteMethod { get; }

        /// <summary>
        /// Adds the specified IParameter to this IFunction and returns the added IParameter.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        IParameter AddParameter(IParameter parameter);
    }
}
