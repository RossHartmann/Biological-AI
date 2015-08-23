using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions.Parameters;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.Functions
{
    public abstract class FunctionBase : List<IParameter>, IFunction
    {
        /// <summary>
        /// The unique Identifier of the IFunction.
        /// </summary>
        public IFunctionIdentifier Identifier { get; private set; }

        /// <summary>
        /// The human-readable name of the IFunction. Doesn't necessarily uniquely identify this IFunction.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The base human-readable name of the IFunction. this is a more general name for the Function (than this.Name).
        /// </summary>
        public string BaseName { get; private set; }

        /// <summary>
        /// The area of the IFunction such as "Arithmetic" or "Registries", etc.
        /// </summary>
        public string Area { get; private set; }

        /// <summary>
        /// The number of inputs (i.e. IParameters) to this
        /// IFunction.
        /// </summary>
        public int ParameterCount { get; private set; }

        /// <summary>
        /// Indicates whether the IFunction is parameterless (i.e. has an ParameterCount of 0).
        /// </summary>
        public bool IsParameterless { get { return this.ParameterCount == 0; } }

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
        public IRegistryIdentifierCollection AvailableRegistries { get; private set; }

        /// <summary>
        /// The Weight of the IFunction in the IGEPGeneticCode. The higher the weight, the 
        /// more ICodons that will encode for this IFunction.
        /// 
        /// A weight of 1 means that the IFunction is weighed the same as all other 
        /// standard IFunctions.
        /// </summary>
        public double WeightInGeneticCode { get; private set; }

        /// <summary>
        /// The method that executes the IFunction.
        /// </summary>
        public FunctionExecute ExecuteMethod { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="functionIdentifier"></param>
        /// <param name="name">The human-readable name of the IFunction. Doesn't necessarily uniquely identify this IFunction.</param>
        /// <param name="executeMethod"></param>
        /// <param name="parameterCount"></param>
        /// <param name="availableRegistries"></param>
        /// <param name="weightInGeneticCode"></param>
        /// <param name="area">The area of the IFunction such as "Arithmetic" or "Registries", etc.</param>
        /// <param name="baseName">The base human-readable name of the IFunction. this is a more general name for the Function (than this.Name).</param>
        protected FunctionBase(IFunctionIdentifier functionIdentifier, string name, string baseName, string area,
            FunctionExecute executeMethod, 
            int parameterCount, IRegistryIdentifierCollection availableRegistries = null,
            double weightInGeneticCode = 1.0d)
        {
            this.Identifier = functionIdentifier;
            this.Name = name;
            this.BaseName = baseName;
            this.Area = area;
            this.ParameterCount = parameterCount;
            this.WeightInGeneticCode = weightInGeneticCode;
            this.AvailableRegistries = availableRegistries;
            this.ExecuteMethod = executeMethod;
        }

        /// <summary>
        /// Adds the specified IParameter to this IFunction and returns the added IParameter.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public IParameter AddParameter(IParameter parameter)
        {
            this.Add(item: parameter);
            return parameter;
        }

        public int CompareTo(IFunction other)
        {
            return this.Identifier.CompareTo(other.Identifier);
        }

        public override string ToString()
        {
            return this.Identifier.ToString();
        }

        public bool Equals(IFunction other)
        {
            return this.Identifier.Equals(other.Identifier);
        }

        public static bool operator ==(FunctionBase functionOne, FunctionBase functionTwo)
        {
            if ((object)functionOne == null ^ (object)functionTwo == null)
                return false;
            return (object)functionOne == null || functionOne.Equals(functionTwo);
        }

        public static bool operator !=(FunctionBase functionOne, FunctionBase functionTwo)
        {
            return !(functionOne == functionTwo);
        }

        protected bool Equals(FunctionBase other)
        {
            return Equals(Identifier, other.Identifier);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((FunctionBase)obj);
        }

        public override int GetHashCode()
        {
            return (Identifier != null ? Identifier.GetHashCode() : 0);
        }
    }
}
