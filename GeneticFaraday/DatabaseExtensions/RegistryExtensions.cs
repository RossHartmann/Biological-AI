using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Registries;
using GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows;

namespace GeneticFaraday.DatabaseExtensions
{
    public static class RegistryExtensions
    {
        public static FunctionRegistryRow ToFunctionRegistryRow(this IRegistryIdentifier source, int functionPrimaryKey, int geneticCodePrimaryKey)
        {
            return new FunctionRegistryRow(theFunction: functionPrimaryKey, registry: source.ToString(), geneticCode: geneticCodePrimaryKey);
        }
    }
}
