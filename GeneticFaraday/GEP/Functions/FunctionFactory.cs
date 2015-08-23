using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions.Parameters;
using GeneticFaraday.GEP.Contracts.Registries;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.Functions.Parameters;
using GeneticFaraday.GEP.Models.Registries;
using UtilityData.LINQ;

namespace GeneticFaraday.GEP.Functions
{
    public static class FunctionFactory
    {
        public static List<List<IRegistryIdentifier>> GetRegistryPermutations(IEnumerable<IRegistryIdentifier> possibleRegistries, int numberOfRegistriesInEachPermutation)
        {
            var registryPermutations = new List<List<IRegistryIdentifier>>();
            if (numberOfRegistriesInEachPermutation > 0)
            {
                registryPermutations = Utility.Algorithms.GetPermuations(elementsToPermutate: possibleRegistries,
                                                  numberOfElementsInPermutations: numberOfRegistriesInEachPermutation);
            }
            return registryPermutations;
        }

        public static List<List<ICodonConverterIdentifier>> GetCodonConverterPermutations(IEnumerable<ICodonConverterIdentifier> possibleCodonConverters, int numberOfCodonConvertersInEachPermutation)
        {
            var codonConverterPermutations = new List<List<ICodonConverterIdentifier>>();
            if (numberOfCodonConvertersInEachPermutation > 0)
            {
                codonConverterPermutations = Utility.Algorithms.GetPermuations(elementsToPermutate: possibleCodonConverters,
                                                  numberOfElementsInPermutations: numberOfCodonConvertersInEachPermutation);
            }
            return codonConverterPermutations;
        }

        public static List<IFunction> CreatePermutationsOfFunction(IGEPEnvironment environment, FunctionExecute executeMethod, string functionBaseName, string functionArea, Func<List<IRegistryIdentifier>, List<ICodonConverterIdentifier>, string> getFunctionName,
            int numberOfRegistriesUsedInFunction = 0, bool onlyUseWriteableRegistries = false,
            double weightInGeneticCode = 1.0d, params IParameter[] parameters)
        {
            return CreatePermutationsOfFunction(executeMethod: executeMethod,
                                                getFunctionName: getFunctionName,
                                                functionBaseName: functionBaseName,
                                                functionArea: functionArea,
                                                allWriteableRegistryIdentifiers: environment.AllWriteableRegistryIdentifiers,
                                                allRegistryIdentifiers: environment.AllRegistryIdentifiers,
                                                numberOfRegistriesUsedInFunction: numberOfRegistriesUsedInFunction,
                                                codonConverters: environment.GeneticCode.CodonConverters.Keys,
                                                weightInGeneticCode: weightInGeneticCode, parameters: parameters);
        }

        /// <summary>
        /// Uses all of the possible IRegistries from the IGEPEnvironment (uses only the non-ReadOnly 
        /// IRegistries if onlyUseWriteableRegistries is true).
        /// Uses all of the possible ICodonConverters from the given IGEPEnvironment.
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="executeMethod"></param>
        /// <param name="numberOfRegistriesUsedInFunction"></param>
        /// <param name="weightInGeneticCode"></param>
        /// <param name="onlyUseWriteableRegistries">If true, only non-ReadOnly IRegistries will be included in the
        /// possibleRegistries.</param>
        /// <param name="getFunctionName">Given a collection of IRegistryIdentifiers and ICodonConverters (either can be null), determines the human-readable name of the over-arching IFunction.
        /// This doesn't necessarily need to uniquely identify any of the IFunctions.</param>
        /// <param name="functionBaseName">The base human-readable name of the IFunction. this is a more general name for the Function (than this.Name).</param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static List<IFunction> CreatePermutationsOfFunction(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers, IEnumerable<ICodonConverterIdentifier> codonConverters, FunctionExecute executeMethod, 
            string functionBaseName, string functionArea, Func<List<IRegistryIdentifier>, List<ICodonConverterIdentifier>, string> getFunctionName,
            int numberOfRegistriesUsedInFunction = 0, bool onlyUseWriteableRegistries = false,
            double weightInGeneticCode = 1.0d, params IParameter[] parameters)
        {
            return CreatePermutationsOfFunction(executeMethod: executeMethod,
                                                getFunctionName: getFunctionName,
                                                functionBaseName: functionBaseName,
                                                functionArea: functionArea,
                                                possibleRegistries:
                                                    numberOfRegistriesUsedInFunction == 0
                                                        ? null
                                                        : onlyUseWriteableRegistries
                                                              ? allWriteableRegistryIdentifiers
                                                              : allRegistryIdentifiers,
                                                numberOfRegistriesUsedInFunction: numberOfRegistriesUsedInFunction,
                                                possibleCodonConverters: codonConverters,
                                                weightInGeneticCode: weightInGeneticCode, parameters: parameters);
        }

        /// <summary>
        /// Creates the permutations of the IFunction as defined by the given parameters.
        /// 
        /// Does not add any IParameters except the ICodonConverter parameters (where applicable).
        /// </summary>
        /// <param name="executeMethod"></param>
        /// <param name="getFunctionName">Given a collection of IRegistryIdentifiers and ICodonConverters (either can be null), determines the human-readable name of the over-arching IFunction.
        /// This doesn't necessarily need to uniquely identify any of the IFunctions.</param>
        /// <param name="possibleRegistries"></param>
        /// <param name="numberOfRegistriesUsedInFunction"></param>
        /// <param name="possibleCodonConverters"></param>
        /// <param name="parameters"></param>
        /// <param name="weightInGeneticCode"></param>
        /// <param name="functionBaseName">The base human-readable name of the IFunction. this is a more general name for the Function (than this.Name).</param>
        /// <returns></returns>
        public static List<IFunction> CreatePermutationsOfFunction(FunctionExecute executeMethod, string functionBaseName, string functionArea, Func<List<IRegistryIdentifier>, List<ICodonConverterIdentifier>, string> getFunctionName,
            IEnumerable<IRegistryIdentifier> possibleRegistries = null, int numberOfRegistriesUsedInFunction = 0, IEnumerable<ICodonConverterIdentifier> possibleCodonConverters = null,
            double weightInGeneticCode = 1.0d, params IParameter[] parameters)
        {
            var functions = new List<IFunction>();

            var numberOfCodonConvertersUsedInFunction = parameters == null ? 0 : parameters.Count(p => p.ParameterType == ParameterType.ConvertedCodon);

            var registryPermutations = GetRegistryPermutations(possibleRegistries: possibleRegistries,
                                                               numberOfRegistriesInEachPermutation:
                                                                   numberOfRegistriesUsedInFunction);

            var codonConverterPermutations = GetCodonConverterPermutations(possibleCodonConverters: possibleCodonConverters,
                                                               numberOfCodonConvertersInEachPermutation:
                                                                   numberOfCodonConvertersUsedInFunction);

            if(numberOfRegistriesUsedInFunction > 0 && numberOfCodonConvertersUsedInFunction > 0)
            {
                AddRegistryAndCodonConverterPermutationsToFunction(functions: functions,
                                                                   functionBaseName: functionBaseName,
                                                                   functionArea: functionArea,
                                                                   getFunctionName: getFunctionName,
                                                                   codonConverterPermutations:
                                                                       codonConverterPermutations,
                                                                   executeMethod: executeMethod,
                                                                   parameters: parameters,
                                                                   weightInGeneticCode: weightInGeneticCode,
                                                                   registryPermutations: registryPermutations);
            }
            else if(numberOfRegistriesUsedInFunction > 0)
            {
                AddRegistryPermutationsToFunction(functions: functions,
                                                  functionBaseName: functionBaseName,
                                                  functionArea: functionArea,
                                                  getFunctionName: getFunctionName,
                                                  registryPermutations: registryPermutations,
                                                  executeMethod: executeMethod,
                                                  parameters: parameters,
                                                  weightInGeneticCode: weightInGeneticCode);
            }
            else if(numberOfCodonConvertersUsedInFunction > 0)
            {
                AddCodonConverterPermutationsToFunction(functions: functions,
                                                        functionBaseName: functionBaseName,
                                                        functionArea: functionArea,
                                                        getFunctionName: getFunctionName,
                                                        codonConverterPermutations: codonConverterPermutations,
                                                        executeMethod: executeMethod,
                                                        parameters: parameters,
                                                        weightInGeneticCode: weightInGeneticCode);
            }
            else
            {
                AddFunction(functions: functions,
                            functionBaseName: functionBaseName,
                            functionArea: functionArea,
                            getFunctionName: getFunctionName,
                            executeMethod: executeMethod,
                            parameters: parameters,
                            weightInGeneticCode: weightInGeneticCode);
            }

            return functions;
        }

        private static void AddFunction(List<IFunction> functions, string functionBaseName, string functionArea, Func<List<IRegistryIdentifier>, List<ICodonConverterIdentifier>, string> getFunctionName,
            IEnumerable<IParameter> parameters,
            FunctionExecute executeMethod, double weightInGeneticCode = 1.0d)
        {
            var functionIdentifier = executeMethod.Method.Name;
            var parameterCount = parameters == null ? 0 : parameters.Count();

            var function = new Function(functionIdentifier: new FunctionIdentifier(functionIdentifier), baseName: functionBaseName, area: functionArea, name: getFunctionName(null, null),
                                        executeMethod: executeMethod, parameterCount: parameterCount,
                                        availableRegistries: new RegistryIdentifierCollection(),
                                        weightInGeneticCode: weightInGeneticCode);

            if (parameterCount > 0)
                function.AddRange(parameters.Select(parameter => parameter.ShallowCopy()));

            functions.Add(function);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="functions"></param>
        /// <param name="getFunctionName">Given a collection of IRegistryIdentifiers and ICodonConverters (either can be null), determines the human-readable name of the over-arching IFunction.
        /// This doesn't necessarily need to uniquely identify any of the IFunctions.</param>
        /// <param name="registryPermutations"></param>
        /// <param name="codonConverterPermutations"></param>
        /// <param name="parameters"></param>
        /// <param name="executeMethod"></param>
        /// <param name="weightInGeneticCode"></param>
        /// <param name="functionBaseName">The base human-readable name of the IFunction. this is a more general name for the Function (than this.Name).</param>
        private static void AddRegistryAndCodonConverterPermutationsToFunction(List<IFunction> functions, string functionBaseName, string functionArea, Func<List<IRegistryIdentifier>, List<ICodonConverterIdentifier>, string> getFunctionName, 
            List<List<IRegistryIdentifier>> registryPermutations,
            List<List<ICodonConverterIdentifier>> codonConverterPermutations, IEnumerable<IParameter> parameters,
            FunctionExecute executeMethod, double weightInGeneticCode = 1.0d)
        {
            // Adjust the weight of the genetic code so that all of the permutations have a summed value of the given weight.
            weightInGeneticCode /= registryPermutations.Count*codonConverterPermutations.Count;

            var parameterCount = parameters == null ? 0 : parameters.Count();
            foreach (var registryPermutation in registryPermutations)
            {
                foreach (var codonConverterPermutation in codonConverterPermutations)
                {
                    var functionIdentifier = executeMethod.Method.Name +
                                             (codonConverterPermutation.Select(r => r.ToString()).ConcatContents()) +
                                             (registryPermutation.Select(r => r.ToString()).ConcatContents());

                    var function = new Function(functionIdentifier: new FunctionIdentifier(functionIdentifier), baseName: functionBaseName, area: functionArea, name: getFunctionName(registryPermutation, codonConverterPermutation),
                                                executeMethod: executeMethod, parameterCount: parameterCount,
                                                availableRegistries: new RegistryIdentifierCollection(registries: registryPermutation),
                                                weightInGeneticCode: weightInGeneticCode);

                    if (parameterCount > 0)
                    {
                        var i = 0;
                        foreach (var parameter in parameters)
                        {
                            var copy = parameter.ShallowCopy();
                            if (copy.ParameterType == ParameterType.ConvertedCodon)
                            {
                                copy.ConverterIdentifier = codonConverterPermutation[i];
                                i++;
                            }
                            function.Add(copy);
                        }
                    }

                    functions.Add(function);
                }
            }
        }

        private static void AddRegistryPermutationsToFunction(List<IFunction> functions, string functionBaseName, string functionArea, Func<List<IRegistryIdentifier>, List<ICodonConverterIdentifier>, string> getFunctionName, List<List<IRegistryIdentifier>> registryPermutations,
            FunctionExecute executeMethod, IEnumerable<IParameter> parameters, double weightInGeneticCode = 1.0d)
        {
            // Adjust the weight of the genetic code so that all of the permutations have a summed value of the given weight.
            weightInGeneticCode /= registryPermutations.Count;

            var parameterCount = parameters == null ? 0 : parameters.Count();
            foreach (var registryPermutation in registryPermutations)
            {
                var functionIdentifier = executeMethod.Method.Name + (registryPermutation.Select(r => r.ToString()).ConcatContents());

                var function = new Function(functionIdentifier: new FunctionIdentifier(functionIdentifier), name: getFunctionName(registryPermutation, null), area: functionArea,
                                            executeMethod: executeMethod, parameterCount: parameterCount,
                                            baseName: functionBaseName,
                                            availableRegistries:
                                                new RegistryIdentifierCollection(registries: registryPermutation),
                                            weightInGeneticCode: weightInGeneticCode);

                if (parameterCount > 0)
                    function.AddRange(parameters.Select(parameter => parameter.ShallowCopy()));

                functions.Add(function);
            }
        }

        private static void AddCodonConverterPermutationsToFunction(List<IFunction> functions, string functionBaseName, string functionArea, Func<List<IRegistryIdentifier>, List<ICodonConverterIdentifier>, string> getFunctionName, List<List<ICodonConverterIdentifier>> codonConverterPermutations,
            FunctionExecute executeMethod, IEnumerable<IParameter> parameters, double weightInGeneticCode = 1.0d)
        {
            // Adjust the weight of the genetic code so that all of the permutations have a summed value of the given weight.
            weightInGeneticCode /= codonConverterPermutations.Count;

            var parameterCount = parameters == null ? 0 : parameters.Count();
            foreach (var codonConverterPermutation in codonConverterPermutations)
            {
                var functionIdentifier = executeMethod.Method.Name + (codonConverterPermutation.Select(r => r.ToString()).ConcatContents());

                var function = new Function(functionIdentifier: new FunctionIdentifier(functionIdentifier),
                                            name: getFunctionName(null, codonConverterPermutation),
                                            baseName: functionBaseName,
                                            area: functionArea,
                                            executeMethod: executeMethod, parameterCount: parameterCount,
                                            availableRegistries: new RegistryIdentifierCollection(),
                                            weightInGeneticCode: weightInGeneticCode);

                if (parameterCount > 0)
                {
                    var i = 0;
                    foreach (var parameter in parameters)
                    {
                        var copy = parameter.ShallowCopy();
                        if (copy.ParameterType == ParameterType.ConvertedCodon)
                        {
                            copy.ConverterIdentifier = codonConverterPermutation[i];
                            i++;
                        }
                        function.Add(copy);
                    }
                }

                functions.Add(function);
            }
        }

        /*
        private static List<List<IRegistryIdentifier>> GetRegistryPermuations(List<IRegistryIdentifier> registryPermutation, IEnumerable<IRegistryIdentifier> possibleRegistries, int depth, int numberOfRegistriesUsedInFunction)
        {
            var permutations = new List<List<IRegistryIdentifier>>();
            foreach(var registry in possibleRegistries)
            {
                var permutationList = new List<IRegistryIdentifier>(registryPermutation);
                permutationList.Add(registry);

                if (depth + 1 < numberOfRegistriesUsedInFunction)
                {
                    var childPermutations = GetRegistryPermuations(registryPermutation: permutationList,
                                                                   possibleRegistries: possibleRegistries,
                                                                   depth: depth + 1,
                                                                   numberOfRegistriesUsedInFunction:
                                                                       numberOfRegistriesUsedInFunction);
                    permutations.AddRange(childPermutations);
                }
                else
                {
                    permutations.Add(permutationList);
                }
            }

            return permutations;
        }

        private static List<ICodonConverterIdentifier> GetCodonConverterPermuations(List<ICodonConverterIdentifier> codonConverterPermutation, IEnumerable<ICodonConverterIdentifier> possibleCodonConverters, int depth, int numberOfCodonConvertersUsedInFunction)
        {
            throw new NotImplementedException();
        }
        */

        public static List<IFunction> GetFunctionsWith2Parameters(IGEPEnvironment environment, string functionBaseName, string functionArea, Func<List<IRegistryIdentifier>, List<ICodonConverterIdentifier>, string> getFunctionName,
            FunctionExecute twoConvertedCodons, FunctionExecute evaluatedAminoAcidAndConvertedCodon, FunctionExecute convertedCodonAndEvaluatedAminoAcid, FunctionExecute twoEvaluatedAminoAcids,
            double weightInGeneticCode)
        {
            return
                GetFunctionsWith2Parameters(
                    allWriteableRegistryIdentifiers: environment.AllWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: environment.AllRegistryIdentifiers,
                    codonConverters: environment.GeneticCode.CodonConverters.Keys,
                    functionBaseName: functionBaseName, functionArea: functionArea, getFunctionName: getFunctionName,
                    twoConvertedCodons: twoConvertedCodons, twoEvaluatedAminoAcids: twoEvaluatedAminoAcids,
                    convertedCodonAndEvaluatedAminoAcid: convertedCodonAndEvaluatedAminoAcid,
                    weightInGeneticCode: weightInGeneticCode,
                    evaluatedAminoAcidAndConvertedCodon: evaluatedAminoAcidAndConvertedCodon);
        }

        public static List<IFunction> GetFunctionsWith2Parameters(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers, IEnumerable<ICodonConverterIdentifier> codonConverters, string functionBaseName, string functionArea, Func<List<IRegistryIdentifier>, List<ICodonConverterIdentifier>, string> getFunctionName,
            FunctionExecute twoConvertedCodons, FunctionExecute evaluatedAminoAcidAndConvertedCodon, FunctionExecute convertedCodonAndEvaluatedAminoAcid, FunctionExecute twoEvaluatedAminoAcids,
            double weightInGeneticCode)
        {
            weightInGeneticCode /= 4d;

            var functionWith2CodonConverters =
                FunctionFactory.CreatePermutationsOfFunction(executeMethod: twoConvertedCodons,
                                                        functionBaseName: functionBaseName,
                                                        functionArea: functionArea,
                                                        getFunctionName: getFunctionName,
                                                        weightInGeneticCode: weightInGeneticCode,
                                                         allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                                                         allRegistryIdentifiers: allRegistryIdentifiers,
                                                         codonConverters: codonConverters,
                                                         parameters:
                                                             new IParameter[]
                                                                     {
                                                                         new Parameter(ParameterType.ConvertedCodon),
                                                                         new Parameter(ParameterType.ConvertedCodon)
                                                                     });

            var functionWithEvaluatedAminoAcidAndCodonConverter =
                FunctionFactory.CreatePermutationsOfFunction(executeMethod: evaluatedAminoAcidAndConvertedCodon,
                                                            functionBaseName: functionBaseName,
                                                            functionArea: functionArea,
                                                            getFunctionName: getFunctionName,
                                                            weightInGeneticCode: weightInGeneticCode,
                                                             allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                                                             allRegistryIdentifiers: allRegistryIdentifiers,
                                                             codonConverters: codonConverters,
                                                             parameters:
                                                                 new IParameter[]
                                                                     {
                                                                         new Parameter(ParameterType.EvaluatedAminoAcid),
                                                                         new Parameter(ParameterType.ConvertedCodon)
                                                                     });

            var functionWithConvertedCodonAndEvaluatedAminoAcid =
                FunctionFactory.CreatePermutationsOfFunction(executeMethod: convertedCodonAndEvaluatedAminoAcid,
                                                            functionBaseName: functionBaseName,
                                                            functionArea: functionArea,
                                                            getFunctionName: getFunctionName,
                                                            weightInGeneticCode: weightInGeneticCode,
                                                             allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                                                             allRegistryIdentifiers: allRegistryIdentifiers,
                                                             codonConverters: codonConverters,
                                                             parameters:
                                                                 new IParameter[]
                                                                     {
                                                                         new Parameter(ParameterType.ConvertedCodon),
                                                                         new Parameter(ParameterType.EvaluatedAminoAcid)
                                                                     });

            var functionWithEvaluatedAminoAcids =
                FunctionFactory.CreatePermutationsOfFunction(executeMethod: twoEvaluatedAminoAcids,
                                                            functionBaseName: functionBaseName,
                                                            functionArea: functionArea,
                                                            getFunctionName: getFunctionName,
                                                            weightInGeneticCode: weightInGeneticCode,
                                                             allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                                                             allRegistryIdentifiers: allRegistryIdentifiers,
                                                             codonConverters: codonConverters,
                                                             parameters:
                                                                 new IParameter[]
                                                                     {
                                                                         new Parameter(ParameterType.EvaluatedAminoAcid),
                                                                         new Parameter(ParameterType.EvaluatedAminoAcid)
                                                                     });

            var functions = new List<IFunction>();
            functions.AddRange(functionWith2CodonConverters);
            functions.AddRange(functionWithEvaluatedAminoAcidAndCodonConverter);
            functions.AddRange(functionWithConvertedCodonAndEvaluatedAminoAcid);
            functions.AddRange(functionWithEvaluatedAminoAcids);

            return functions;
        }

        public static List<IFunction> GetFunctionsWith1Parameter(IGEPEnvironment environment,
            string functionBaseName, string functionArea, Func<List<IRegistryIdentifier>, List<ICodonConverterIdentifier>, string> getFunctionName,
            FunctionExecute evaluatedAminoAcid, FunctionExecute convertedCodons, double weightInGeneticCode)
        {
            return
                GetFunctionsWith1Parameter(
                    allWriteableRegistryIdentifiers: environment.AllWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: environment.AllRegistryIdentifiers,
                    codonConverters: environment.GeneticCode.CodonConverters.Keys, functionBaseName: functionBaseName,
                    functionArea: functionArea,
                    convertedCodons: convertedCodons, evaluatedAminoAcid: evaluatedAminoAcid,
                    getFunctionName: getFunctionName, weightInGeneticCode: weightInGeneticCode);
        }

        public static List<IFunction> GetFunctionsWith1Parameter(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers, IEnumerable<ICodonConverterIdentifier> codonConverters, 
            string functionBaseName, string functionArea, Func<List<IRegistryIdentifier>, List<ICodonConverterIdentifier>, string> getFunctionName,
            FunctionExecute evaluatedAminoAcid, FunctionExecute convertedCodons, double weightInGeneticCode)
        {
            weightInGeneticCode /= 2d;

            var functionWithCodonConverter =
                FunctionFactory.CreatePermutationsOfFunction(executeMethod: convertedCodons,
                                                        functionBaseName: functionBaseName,
                                                        functionArea: functionArea,
                                                        getFunctionName: getFunctionName,
                                                        weightInGeneticCode: weightInGeneticCode,
                                                         allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                                                             allRegistryIdentifiers: allRegistryIdentifiers,
                                                             codonConverters: codonConverters,
                                                         parameters:
                                                             new IParameter[]
                                                                     {
                                                                         new Parameter(ParameterType.ConvertedCodon)
                                                                     });

            var functionWithEvaluatedAminoAcid =
                FunctionFactory.CreatePermutationsOfFunction(executeMethod: evaluatedAminoAcid,
                                                            functionBaseName: functionBaseName,
                                                            functionArea: functionArea,
                                                            getFunctionName: getFunctionName,
                                                            weightInGeneticCode: weightInGeneticCode,
                                                             allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                                                             allRegistryIdentifiers: allRegistryIdentifiers,
                                                             codonConverters: codonConverters,
                                                             parameters:
                                                                 new IParameter[]
                                                                     {
                                                                         new Parameter(ParameterType.EvaluatedAminoAcid)
                                                                     });

            var functions = new List<IFunction>();
            functions.AddRange(functionWithCodonConverter);
            functions.AddRange(functionWithEvaluatedAminoAcid);

            return functions;
        }
    }
}


