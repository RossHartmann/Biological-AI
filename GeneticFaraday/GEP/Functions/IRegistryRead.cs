using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Contracts.Registries;
using GeneticFaraday.GEP.Models.Exceptions;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.DNAs.AminoAcids;

namespace GeneticFaraday.GEP.Functions
{
    public static partial class Functions
    {
        public static partial class IRegistryRead
        {
            public static IAminoAcidResult RegistryRead(IFunctionExecutionData functionExecutionData, params IArgument[] arguments)
            {
                if (arguments.Length != 0)
                    throw new InvalidArgumentCount();

                var registry = functionExecutionData.AvailableRegistries[0];
                return registry.Read();
            }

            public static List<IFunction> GetReadFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers,
                IEnumerable<ICodonConverterIdentifier> codonConverters, double weightInGeneticCode)
            {
                var registryReadFunctions =
                    FunctionFactory.CreatePermutationsOfFunction(executeMethod: Functions.IRegistryRead.RegistryRead,
                                                                 functionBaseName: "ReadRegistry",
                                                                 functionArea: "Read Registry",
                                                                 getFunctionName:
                                                                     (registryPermutation, codonConverterPermutation) =>
                                                                     "ReadFrom" + registryPermutation.First(),
                                                                 allWriteableRegistryIdentifiers:
                                                                     allWriteableRegistryIdentifiers,
                                                                 allRegistryIdentifiers: allRegistryIdentifiers,
                                                                 codonConverters: codonConverters,
                                                                 weightInGeneticCode: weightInGeneticCode,
                                                                 numberOfRegistriesUsedInFunction: 1);

                var functions = new List<IFunction>();
                functions.AddRange(registryReadFunctions);

                return functions;
            }
        }
    }
}
