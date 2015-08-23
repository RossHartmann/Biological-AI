using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Models.Exceptions;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.Functions;

namespace GeneticFaraday.GEP.Functions
{
    public static partial class Functions
    {
        public static partial class Constants
        {
            public static IAminoAcidResult True(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 0)
                    throw new InvalidArgumentCount();

                return new AminoAcidResult(1);
            }

            public static IAminoAcidResult False(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 0)
                    throw new InvalidArgumentCount();

                return new AminoAcidResult(0);
            }

            public static IAminoAcidResult Two(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 0)
                    throw new InvalidArgumentCount();

                return new AminoAcidResult(2);
            }

            public static IAminoAcidResult Three(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 0)
                    throw new InvalidArgumentCount();

                return new AminoAcidResult(3);
            }


            public static List<IFunction> GetConstantsFunctions(double weightInGeneticCode)
            {
                var functions = new List<IFunction>();

                functions.Add(new Function(name: "True", baseName: "True", area: "Constants",
                                           functionIdentifier: new FunctionIdentifier("True"), executeMethod: True,
                                           parameterCount: 0, weightInGeneticCode: weightInGeneticCode));

                functions.Add(new Function(name: "False", baseName: "False", area: "Constants",
                                           functionIdentifier: new FunctionIdentifier("False"), executeMethod: False,
                                           parameterCount: 0, weightInGeneticCode: weightInGeneticCode));

                functions.Add(new Function(name: "Two", baseName: "Two", area: "Constants",
                                           functionIdentifier: new FunctionIdentifier("Two"), executeMethod: Two,
                                           parameterCount: 0, weightInGeneticCode: weightInGeneticCode));

                functions.Add(new Function(name: "Three", baseName: "Three", area: "Constants",
                                           functionIdentifier: new FunctionIdentifier("Three"), executeMethod: Three,
                                           parameterCount: 0, weightInGeneticCode: weightInGeneticCode));

                return functions;
            }
        }
    }
}
