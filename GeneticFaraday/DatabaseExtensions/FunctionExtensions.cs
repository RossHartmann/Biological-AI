using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions.Parameters;
using GeneticFaraday.GEP.Contracts.Registries;
using GeneticFaraday.GEP.Functions;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.Functions.Parameters;
using GeneticFaraday.GEP.Models.Registries;
using GeneticFaraday.Models.Organisms.GeneticCodes.Codons.CodonConverters;
using UtilityData.Exceptions.DatabaseExceptions;

namespace GeneticFaraday.DatabaseExtensions
{
    public static class FunctionExtensions
    {
        /*
        public static ParameterType ToParameterType(this GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.ParameterType source)
        {
            if(source == GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.ParameterType.Aminoacid)
                return ParameterType.AminoAcid;
            else if(source == GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.ParameterType.Convertedcodon)
                return ParameterType.ConvertedCodon;
            else if(source == GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.ParameterType.Evaluatedaminoacid)
                return ParameterType.EvaluatedAminoAcid;
            else
                throw new ValueNotYetSupported(source, typeof(GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.ParameterType));
        }

        public static IParameter ToParameter(this ParameterRow parameter)
        {
            var codonConverter = parameter.IsCodonConverterIdentifierNullOrEmpty ? null as CodonConverterIdentifier? : new CodonConverterIdentifier(parameter.CodonConverterIdentifier);
            return new Parameter(parameter.ParameterType.ToParameterType(), codonConverter);
        }

        public static IRegistryIdentifier ToRegistryIdentifier(this FunctionRegistryRow functionRegistryRow)
        {
            return new RegistryIdentifier(functionRegistryRow.Registry);
        }

        public static IFunction ToFunction(this TheFunctionRow function, IEnumerable<ParameterRow> parameters, IEnumerable<FunctionRegistryRow> functionRegistryRows, IEnumerable<MethodInfo> executeMethods)
        {
            var iFunction = new Function(new FunctionIdentifier(function.FunctionIdentifier), function.Name, function.BaseName, function.Area, 
                (data, arguments) => (IAminoAcidResult)executeMethods.First(m => m.Name==function.ExecuteMethodName).Invoke(null, new object[] { data, arguments}), 
                parameters.Count(), functionRegistryRows == null ? null : new RegistryIdentifierCollection(functionRegistryRows.Select(r => r.ToRegistryIdentifier())), weightInGeneticCode: function.WeightInGeneticCode);

            if(parameters != null)
                iFunction.AddRange(parameters.Select(parameter => parameter.ToParameter()));

            return iFunction;
        }

        public static TheFunctionRow ToFunctionRow(this IFunction function, int geneticCodePrimaryKey)
        {
            return new TheFunctionRow(functionIdentifier: function.Identifier.ToString(),
                                      geneticCode: geneticCodePrimaryKey,
                                      name: function.Name, baseName: function.BaseName,
                                      weightInGeneticCode: function.WeightInGeneticCode,
                                      executeMethodName: function.ExecuteMethod.Method.Name, area: function.Area);
        }

        public static ParameterRow ToParameterRow(this IParameter parameter, int parameterIndex, int functionPrimaryKey, int geneticCodePrimaryKey)
        {
            return new ParameterRow(parameterType: parameter.ParameterType.ToString(),
                                    parentFunction: functionPrimaryKey, parameterIndex: parameterIndex,
                                    codonConverterIdentifier: parameter.ConverterIdentifier == null ? null : parameter.ConverterIdentifier.ToString(),
                                    geneticCode: geneticCodePrimaryKey);
        }
         */
    }
}
