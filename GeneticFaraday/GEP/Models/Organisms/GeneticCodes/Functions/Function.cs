using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Models.Organisms.GeneticCodes.Functions
{
    public class Function : FunctionBase
    {
        /// <summary>
        /// Creates a FunctionIdentifier based on the name of the given FunctionExecute.
        /// </summary>
        /// <param name="name">The human-readable name of the IFunction. Doesn't necessarily uniquely identify this IFunction.</param>
        /// <param name="executeMethod"></param>
        /// <param name="parameterCount"></param>
        /// <param name="availableRegistries"></param>
        /// <param name="weightInGeneticCode"></param>
        /// <param name="baseName"></param>
        public Function(string name, string baseName, string area, FunctionExecute executeMethod, 
            int parameterCount, IRegistryIdentifierCollection availableRegistries = null,
            double weightInGeneticCode = 1.0d)
            : this(functionIdentifier: new FunctionIdentifier(executeMethod.Method.Name), name: name, baseName: baseName,
            area: area,
            executeMethod: executeMethod, parameterCount: parameterCount, availableRegistries: availableRegistries, 
            weightInGeneticCode: weightInGeneticCode)
        {
            
        }

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
        public Function(IFunctionIdentifier functionIdentifier, string name, string baseName, string area, FunctionExecute executeMethod, 
            int parameterCount, IRegistryIdentifierCollection availableRegistries = null,
            double weightInGeneticCode = 1.0d)
            : base(functionIdentifier: functionIdentifier,name: name, baseName: baseName, area: area, executeMethod: executeMethod,
            parameterCount: parameterCount, availableRegistries: availableRegistries, 
            weightInGeneticCode: weightInGeneticCode)
        {
        }
    }
}
