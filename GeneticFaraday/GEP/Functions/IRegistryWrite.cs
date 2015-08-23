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
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions.Parameters;
using GeneticFaraday.GEP.Contracts.Registries;
using GeneticFaraday.GEP.Models.Exceptions;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.Functions.Parameters;
using UtilityData.LINQ;

namespace GeneticFaraday.GEP.Functions
{
    public static partial class Functions
    {
        public static partial class IRegistryWrite
        {
            public static IAminoAcidResult RegistryWriteConvertedCodon(IFunctionExecutionData functionExecutionData, params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var registry = functionExecutionData.AvailableRegistries[0];
                var arg = arguments[0].Value.ConvertedCodon.Value.ToDouble();

                var aminoAcidResult = new AminoAcidResult(value: arg);
                registry.Write(aminoAcidResult);

                return aminoAcidResult;
            }

            public static IAminoAcidResult RegistryWriteEvaluatedAminoAcid(IFunctionExecutionData functionExecutionData, params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var registry = functionExecutionData.AvailableRegistries[0];
                var arg = arguments[0].Value.EvaluatedAminoAcid.Value;

                var aminoAcidResult = new AminoAcidResult(value: arg);
                registry.Write(aminoAcidResult);

                return aminoAcidResult;
            }


            public static List<IFunction> GetWriteFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers,
                IEnumerable<ICodonConverterIdentifier> codonConverters, double weightInGeneticCode)
            {
                weightInGeneticCode /= 2d;

                var registryWriteConvertedCodonFunctions =
                    FunctionFactory.CreatePermutationsOfFunction(
                        executeMethod: Functions.IRegistryWrite.RegistryWriteConvertedCodon,
                        functionBaseName: "WriteRegistry",
                        functionArea: "Write Registry",
                        getFunctionName:
                            (registryPermutation, codonConverterPermutation) => "WriteTo" + registryPermutation.First(),
                        allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                        allRegistryIdentifiers: allRegistryIdentifiers,
                        codonConverters: codonConverters,
                        numberOfRegistriesUsedInFunction: 1,
                        weightInGeneticCode: weightInGeneticCode,
                        onlyUseWriteableRegistries: true,
                        parameters: new Parameter(ParameterType.ConvertedCodon));

                var registryWriteEvaluatedAminoAcidFunctions =
                    FunctionFactory.CreatePermutationsOfFunction(
                        executeMethod: Functions.IRegistryWrite.RegistryWriteEvaluatedAminoAcid,
                        functionBaseName: "WriteRegistry",
                        functionArea: "Write Registry",
                        getFunctionName:
                            (registryPermutation, codonConverterPermutation) => "WriteTo" + registryPermutation.First(),
                        allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                        allRegistryIdentifiers: allRegistryIdentifiers,
                        codonConverters: codonConverters,
                        numberOfRegistriesUsedInFunction: 1,
                        weightInGeneticCode: weightInGeneticCode,
                        onlyUseWriteableRegistries: true,
                        parameters: new Parameter(ParameterType.EvaluatedAminoAcid));

                var functions = new List<IFunction>();
                functions.AddRange(registryWriteConvertedCodonFunctions);
                functions.AddRange(registryWriteEvaluatedAminoAcidFunctions);

                return functions;
            }
        }
    }
}
