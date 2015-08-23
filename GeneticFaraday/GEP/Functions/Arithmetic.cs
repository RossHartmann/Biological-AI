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
        public static partial class Arithmetic
        {
            #region Sum

            public static IAminoAcidResult Sum2EvaluatedAminoAcids(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;
                var arg2 = arguments[1].Value.EvaluatedAminoAcid.Value;
                return new AminoAcidResult(arg1 + arg2);
            }

            public static IAminoAcidResult Sum2ConvertedCodons(IFunctionExecutionData functionExecutionData,
                                                               params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();
                var arg2 = arguments[1].Value.ConvertedCodon.Value.ToDouble();
                return new AminoAcidResult(arg1 + arg2);
            }

            public static IAminoAcidResult SumEvaluatedAminoAcidAndConvertedCodon(
                IFunctionExecutionData functionExecutionData, params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;
                var arg2 = arguments[1].Value.ConvertedCodon.Value.ToDouble();
                return new AminoAcidResult(arg1 + arg2);
            }

            public static IAminoAcidResult SumConvertedCodonAndEvaluatedAminoAcid(
                IFunctionExecutionData functionExecutionData, params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();
                var arg2 = arguments[1].Value.EvaluatedAminoAcid.Value;
                return new AminoAcidResult(arg1 + arg2);
            }

            public static List<IFunction> GetSumFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers, 
                IEnumerable<ICodonConverterIdentifier> codonConverters, double weightInGeneticCode)
            {
                return
                    FunctionFactory.GetFunctionsWith2Parameters(
                        allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                        allRegistryIdentifiers: allRegistryIdentifiers,
                        codonConverters: codonConverters,
                        functionBaseName: "Sum",
                        getFunctionName: (registryPermutation, codonConverterPermutation) => "Sum",
                        functionArea: "Arithmetic",
                        twoConvertedCodons: Sum2ConvertedCodons,
                        evaluatedAminoAcidAndConvertedCodon: SumEvaluatedAminoAcidAndConvertedCodon,
                        convertedCodonAndEvaluatedAminoAcid: SumConvertedCodonAndEvaluatedAminoAcid,
                        twoEvaluatedAminoAcids: Sum2EvaluatedAminoAcids,
                        weightInGeneticCode: weightInGeneticCode);
            }

            #endregion

            #region Difference

            public static IAminoAcidResult Difference2EvaluatedAminoAcids(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;
                var arg2 = arguments[1].Value.EvaluatedAminoAcid.Value;
                return new AminoAcidResult(arg1 - arg2);
            }

            public static IAminoAcidResult Difference2ConvertedCodons(IFunctionExecutionData functionExecutionData,
                                                               params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();
                var arg2 = arguments[1].Value.ConvertedCodon.Value.ToDouble();
                return new AminoAcidResult(arg1 - arg2);
            }

            public static IAminoAcidResult DifferenceEvaluatedAminoAcidAndConvertedCodon(
                IFunctionExecutionData functionExecutionData, params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;
                var arg2 = arguments[1].Value.ConvertedCodon.Value.ToDouble();
                return new AminoAcidResult(arg1 - arg2);
            }

            public static IAminoAcidResult DifferenceConvertedCodonAndEvaluatedAminoAcid(
                IFunctionExecutionData functionExecutionData, params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();
                var arg2 = arguments[1].Value.EvaluatedAminoAcid.Value;
                return new AminoAcidResult(arg1 - arg2);
            }

            public static List<IFunction> GetDifferenceFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers,
                IEnumerable<ICodonConverterIdentifier> codonConverters, double weightInGeneticCode)
            {
                return
                    FunctionFactory.GetFunctionsWith2Parameters(
                        allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                        allRegistryIdentifiers: allRegistryIdentifiers,
                        codonConverters: codonConverters, functionBaseName: "Difference",
                        getFunctionName: (registryPermutation, codonConverterPermutation) => "Difference",
                        functionArea: "Arithmetic",
                        twoConvertedCodons: Difference2ConvertedCodons,
                        evaluatedAminoAcidAndConvertedCodon: DifferenceEvaluatedAminoAcidAndConvertedCodon,
                        convertedCodonAndEvaluatedAminoAcid: DifferenceConvertedCodonAndEvaluatedAminoAcid,
                        twoEvaluatedAminoAcids: Difference2EvaluatedAminoAcids,
                        weightInGeneticCode: weightInGeneticCode);
            }

            #endregion

            #region Multiply

            public static IAminoAcidResult Multiply2EvaluatedAminoAcids(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;
                var arg2 = arguments[1].Value.EvaluatedAminoAcid.Value;
                return new AminoAcidResult(arg1 * arg2);
            }

            public static IAminoAcidResult Multiply2ConvertedCodons(IFunctionExecutionData functionExecutionData,
                                                               params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();
                var arg2 = arguments[1].Value.ConvertedCodon.Value.ToDouble();
                return new AminoAcidResult(arg1 * arg2);
            }

            public static IAminoAcidResult MultiplyEvaluatedAminoAcidAndConvertedCodon(
                IFunctionExecutionData functionExecutionData, params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;
                var arg2 = arguments[1].Value.ConvertedCodon.Value.ToDouble();
                return new AminoAcidResult(arg1 * arg2);
            }

            public static IAminoAcidResult MultiplyConvertedCodonAndEvaluatedAminoAcid(
                IFunctionExecutionData functionExecutionData, params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();
                var arg2 = arguments[1].Value.EvaluatedAminoAcid.Value;
                return new AminoAcidResult(arg1 * arg2);
            }

            public static List<IFunction> GetMultiplyFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers,
                IEnumerable<ICodonConverterIdentifier> codonConverters, double weightInGeneticCode)
            {
                return
                    FunctionFactory.GetFunctionsWith2Parameters(
                        allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                        allRegistryIdentifiers: allRegistryIdentifiers,
                        codonConverters: codonConverters, functionBaseName: "Multiply",
                        getFunctionName: (registryPermutation, codonConverterPermutation) => "Multiply",
                        functionArea: "Arithmetic",
                        twoConvertedCodons: Multiply2ConvertedCodons,
                        evaluatedAminoAcidAndConvertedCodon: MultiplyEvaluatedAminoAcidAndConvertedCodon,
                        convertedCodonAndEvaluatedAminoAcid: MultiplyConvertedCodonAndEvaluatedAminoAcid,
                        twoEvaluatedAminoAcids: Multiply2EvaluatedAminoAcids,
                        weightInGeneticCode: weightInGeneticCode);
            }

            #endregion

            #region Divide

            public static IAminoAcidResult Divide2EvaluatedAminoAcids(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;
                var arg2 = arguments[1].Value.EvaluatedAminoAcid.Value;

                if (arg2 == 0)
                    return null;

                return new AminoAcidResult(arg1 / arg2);
            }

            public static IAminoAcidResult Divide2ConvertedCodons(IFunctionExecutionData functionExecutionData,
                                                               params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();
                var arg2 = arguments[1].Value.ConvertedCodon.Value.ToDouble();

                if (arg2 == 0)
                    return null;

                return new AminoAcidResult(arg1 / arg2);
            }

            public static IAminoAcidResult DivideEvaluatedAminoAcidAndConvertedCodon(
                IFunctionExecutionData functionExecutionData, params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;
                var arg2 = arguments[1].Value.ConvertedCodon.Value.ToDouble();

                if (arg2 == 0)
                    return null;

                return new AminoAcidResult(arg1 / arg2);
            }

            public static IAminoAcidResult DivideConvertedCodonAndEvaluatedAminoAcid(
                IFunctionExecutionData functionExecutionData, params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();
                var arg2 = arguments[1].Value.EvaluatedAminoAcid.Value;

                if (arg2 == 0)
                    return null;

                return new AminoAcidResult(arg1 / arg2);
            }

            public static List<IFunction> GetDivideFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers,
                IEnumerable<ICodonConverterIdentifier> codonConverters, double weightInGeneticCode)
            {
                return
                    FunctionFactory.GetFunctionsWith2Parameters(
                        allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                        allRegistryIdentifiers: allRegistryIdentifiers,
                        codonConverters: codonConverters, functionBaseName: "Divide",
                        getFunctionName: (registryPermutation, codonConverterPermutation) => "Divide",
                        functionArea: "Arithmetic",
                        twoConvertedCodons: Divide2ConvertedCodons,
                        evaluatedAminoAcidAndConvertedCodon: DivideEvaluatedAminoAcidAndConvertedCodon,
                        convertedCodonAndEvaluatedAminoAcid: DivideConvertedCodonAndEvaluatedAminoAcid,
                        twoEvaluatedAminoAcids: Divide2EvaluatedAminoAcids,
                        weightInGeneticCode: weightInGeneticCode);
            }

            #endregion

            #region Power

            public static IAminoAcidResult Power2EvaluatedAminoAcids(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;
                var arg2 = arguments[1].Value.EvaluatedAminoAcid.Value;
                return new AminoAcidResult(Math.Pow(arg1, arg2));
            }

            public static IAminoAcidResult Power2ConvertedCodons(IFunctionExecutionData functionExecutionData,
                                                               params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();
                var arg2 = arguments[1].Value.ConvertedCodon.Value.ToDouble();

                return new AminoAcidResult(Math.Pow(arg1, arg2));
            }

            public static IAminoAcidResult PowerEvaluatedAminoAcidAndConvertedCodon(
                IFunctionExecutionData functionExecutionData, params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;
                var arg2 = arguments[1].Value.ConvertedCodon.Value.ToDouble();
                return new AminoAcidResult(Math.Pow(arg1, arg2));
            }

            public static IAminoAcidResult PowerConvertedCodonAndEvaluatedAminoAcid(
                IFunctionExecutionData functionExecutionData, params IArgument[] arguments)
            {
                if (arguments.Length != 2)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();
                var arg2 = arguments[1].Value.EvaluatedAminoAcid.Value;
                return new AminoAcidResult(Math.Pow(arg1, arg2));
            }

            public static List<IFunction> GetPowerFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers,
                IEnumerable<ICodonConverterIdentifier> codonConverters, double weightInGeneticCode)
            {
                return
                    FunctionFactory.GetFunctionsWith2Parameters(
                        allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                        allRegistryIdentifiers: allRegistryIdentifiers,
                        codonConverters: codonConverters, functionBaseName: "Power",
                        getFunctionName: (registryPermutation, codonConverterPermutation) => "Power",
                        functionArea: "Arithmetic",
                        twoConvertedCodons: Power2ConvertedCodons,
                        evaluatedAminoAcidAndConvertedCodon: PowerEvaluatedAminoAcidAndConvertedCodon,
                        convertedCodonAndEvaluatedAminoAcid: PowerConvertedCodonAndEvaluatedAminoAcid,
                        twoEvaluatedAminoAcids: Power2EvaluatedAminoAcids,
                        weightInGeneticCode: weightInGeneticCode);
            }

            #endregion

            #region Square

            public static IAminoAcidResult SquareEvaluatedAminoAcid(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;

                return new AminoAcidResult(Math.Pow(arg1, 2));
            }

            public static IAminoAcidResult SquareConvertedCodons(IFunctionExecutionData functionExecutionData,
                                                               params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();

                return new AminoAcidResult(Math.Pow(arg1, 2));
            }

            public static List<IFunction> GetSquareFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers,
                IEnumerable<ICodonConverterIdentifier> codonConverters, double weightInGeneticCode)
            {
                return
                    FunctionFactory.GetFunctionsWith1Parameter(
                        allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                        allRegistryIdentifiers: allRegistryIdentifiers,
                        codonConverters: codonConverters, functionBaseName: "Square",
                        getFunctionName: (registryPermutation, codonConverterPermutation) => "Square",
                        functionArea: "Arithmetic",
                        evaluatedAminoAcid: SquareEvaluatedAminoAcid,
                        convertedCodons: SquareConvertedCodons,
                        weightInGeneticCode: weightInGeneticCode);
            }

            #endregion

            #region SquareRoot

            public static IAminoAcidResult SquareRootEvaluatedAminoAcid(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;

                return new AminoAcidResult(Math.Sqrt(arg1));
            }

            public static IAminoAcidResult SquareRootConvertedCodons(IFunctionExecutionData functionExecutionData,
                                                               params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();

                return new AminoAcidResult(Math.Sqrt(arg1));
            }

            public static List<IFunction> GetSquareRootFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers,
                IEnumerable<ICodonConverterIdentifier> codonConverters, double weightInGeneticCode)
            {
                return
                    FunctionFactory.GetFunctionsWith1Parameter(
                        allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                        allRegistryIdentifiers: allRegistryIdentifiers,
                        codonConverters: codonConverters, functionBaseName: "SquareRoot",
                        getFunctionName: (registryPermutation, codonConverterPermutation) => "SquareRoot",
                        functionArea: "Arithmetic",
                        evaluatedAminoAcid: SquareRootEvaluatedAminoAcid,
                        convertedCodons: SquareRootConvertedCodons,
                        weightInGeneticCode: weightInGeneticCode);
            }

            #endregion

            #region Negate

            public static IAminoAcidResult NegateEvaluatedAminoAcid(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;

                return new AminoAcidResult(-arg1);
            }

            public static IAminoAcidResult NegateConvertedCodons(IFunctionExecutionData functionExecutionData,
                                                               params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();

                return new AminoAcidResult(-arg1);
            }

            public static List<IFunction> GetNegateFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers,
                IEnumerable<ICodonConverterIdentifier> codonConverters, double weightInGeneticCode)
            {
                return
                    FunctionFactory.GetFunctionsWith1Parameter(
                        allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                        allRegistryIdentifiers: allRegistryIdentifiers,
                        codonConverters: codonConverters, functionBaseName: "Negate",
                        getFunctionName: (registryPermutation, codonConverterPermutation) => "Negate",
                        functionArea: "Arithmetic",
                        evaluatedAminoAcid: NegateEvaluatedAminoAcid,
                        convertedCodons: NegateConvertedCodons,
                        weightInGeneticCode: weightInGeneticCode);
            }

            #endregion

            #region Force Negate

            public static IAminoAcidResult ForceNegateEvaluatedAminoAcid(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;

                return new AminoAcidResult(-Math.Abs(arg1));
            }

            public static IAminoAcidResult ForceNegateConvertedCodons(IFunctionExecutionData functionExecutionData,
                                                               params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();

                return new AminoAcidResult(-Math.Abs(arg1));
            }

            public static List<IFunction> GetForceNegateFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers,
                IEnumerable<ICodonConverterIdentifier> codonConverters, double weightInGeneticCode)
            {
                return
                    FunctionFactory.GetFunctionsWith1Parameter(
                        allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                        allRegistryIdentifiers: allRegistryIdentifiers,
                        codonConverters: codonConverters, functionBaseName: "ForceNegate",
                        getFunctionName: (registryPermutation, codonConverterPermutation) => "ForceNegate",
                        functionArea: "Arithmetic",
                        evaluatedAminoAcid: ForceNegateEvaluatedAminoAcid,
                        convertedCodons: ForceNegateConvertedCodons,
                        weightInGeneticCode: weightInGeneticCode);
            }

            #endregion

            #region Absolute

            public static IAminoAcidResult AbsoluteEvaluatedAminoAcid(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;

                return new AminoAcidResult(Math.Abs(arg1));
            }

            public static IAminoAcidResult AbsoluteConvertedCodons(IFunctionExecutionData functionExecutionData,
                                                               params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();

                return new AminoAcidResult(Math.Abs(arg1));
            }

            public static List<IFunction> GetAbsoluteFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers,
                IEnumerable<ICodonConverterIdentifier> codonConverters, double weightInGeneticCode)
            {
                return
                    FunctionFactory.GetFunctionsWith1Parameter(
                        allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                        allRegistryIdentifiers: allRegistryIdentifiers,
                        codonConverters: codonConverters, functionBaseName: "Absolute",
                        getFunctionName: (registryPermutation, codonConverterPermutation) => "Absolute",
                        functionArea: "Arithmetic",
                        evaluatedAminoAcid: AbsoluteEvaluatedAminoAcid,
                        convertedCodons: AbsoluteConvertedCodons,
                        weightInGeneticCode: weightInGeneticCode);
            }

            #endregion

            #region RoundToNearestWholeNumber

            public static IAminoAcidResult RoundToNearestWholeNumberEvaluatedAminoAcid(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;

                return new AminoAcidResult(Math.Round(arg1, 0));
            }

            public static IAminoAcidResult RoundToNearestWholeNumberConvertedCodons(IFunctionExecutionData functionExecutionData,
                                                               params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();

                return new AminoAcidResult(Math.Round(arg1, 0));
            }

            public static List<IFunction> GetRoundToNearestWholeNumberFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers,
                IEnumerable<ICodonConverterIdentifier> codonConverters, double weightInGeneticCode)
            {
                return
                    FunctionFactory.GetFunctionsWith1Parameter(
                        allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                        allRegistryIdentifiers: allRegistryIdentifiers,
                        codonConverters: codonConverters, functionBaseName: "RoundToNearestWholeNumber",
                        getFunctionName: (registryPermutation, codonConverterPermutation) => "RoundToNearestWholeNumber",
                        functionArea: "Arithmetic",
                        evaluatedAminoAcid: RoundToNearestWholeNumberEvaluatedAminoAcid,
                        convertedCodons: RoundToNearestWholeNumberConvertedCodons,
                        weightInGeneticCode: weightInGeneticCode);
            }

            #endregion

            #region Successor

            public static IAminoAcidResult SuccessorEvaluatedAminoAcid(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;

                return new AminoAcidResult(arg1 + 1);
            }

            public static IAminoAcidResult SuccessorConvertedCodons(IFunctionExecutionData functionExecutionData,
                                                               params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();

                return new AminoAcidResult(arg1 + 1);
            }

            public static List<IFunction> GetSuccessorFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers,
                IEnumerable<ICodonConverterIdentifier> codonConverters, double weightInGeneticCode)
            {
                return
                    FunctionFactory.GetFunctionsWith1Parameter(
                        allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                        allRegistryIdentifiers: allRegistryIdentifiers,
                        codonConverters: codonConverters, functionBaseName: "Successor",
                        getFunctionName: (registryPermutation, codonConverterPermutation) => "Successor",
                        functionArea: "Arithmetic",
                        evaluatedAminoAcid: SuccessorEvaluatedAminoAcid,
                        convertedCodons: SuccessorConvertedCodons,
                        weightInGeneticCode: weightInGeneticCode);
            }

            #endregion

            #region Predecessor

            public static IAminoAcidResult PredecessorEvaluatedAminoAcid(IFunctionExecutionData functionExecutionData,
                                                                   params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.EvaluatedAminoAcid.Value;

                return new AminoAcidResult(arg1 - 1);
            }

            public static IAminoAcidResult PredecessorConvertedCodons(IFunctionExecutionData functionExecutionData,
                                                               params IArgument[] arguments)
            {
                if (arguments.Length != 1)
                    throw new InvalidArgumentCount();

                var arg1 = arguments[0].Value.ConvertedCodon.Value.ToDouble();

                return new AminoAcidResult(arg1 - 1);
            }

            public static List<IFunction> GetPredecessorFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers,
                IEnumerable<ICodonConverterIdentifier> codonConverters, double weightInGeneticCode)
            {
                return
                    FunctionFactory.GetFunctionsWith1Parameter(
                        allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                        allRegistryIdentifiers: allRegistryIdentifiers,
                        codonConverters: codonConverters, functionBaseName: "Predecessor",
                        getFunctionName: (registryPermutation, codonConverterPermutation) => "Predecessor",
                        functionArea: "Arithmetic",
                        evaluatedAminoAcid: PredecessorEvaluatedAminoAcid,
                        convertedCodons: PredecessorConvertedCodons,
                        weightInGeneticCode: weightInGeneticCode);
            }

            #endregion
        }
    }
}

