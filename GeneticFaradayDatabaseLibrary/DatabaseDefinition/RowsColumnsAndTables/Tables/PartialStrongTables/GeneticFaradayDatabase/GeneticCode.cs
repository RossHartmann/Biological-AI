using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityData.LINQ;
using UtilityData.SQL;

namespace GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables
{
    /// <summary>
    /// The Database Master Class
    /// </summary>
    public static partial class DM
    {
        public static partial class GeneticCode
        {
            /// <summary>
            /// Deletes all of the rows that are dependent on the specified GeneticCodeRow.
            /// </summary>
            public static void DeleteAllDependentRows(int geneticCodePrimaryKey)
            {
                DM.GeneticCode.DeleteAllCodonConverters(geneticCodePrimaryKey);
                DM.GeneticCode.DeleteAllParameters(geneticCodePrimaryKey);
                DM.GeneticCode.DeleteAllFunctionRegistries(geneticCodePrimaryKey);
                DM.GeneticCode.DeleteAllCodonNucleotides(geneticCodePrimaryKey);
                DM.GeneticCode.DeleteAllCodons(geneticCodePrimaryKey);
                DM.GeneticCode.DeleteAllFunctionPairs(geneticCodePrimaryKey);
                DM.GeneticCode.DeleteAllFunctions(geneticCodePrimaryKey);
            }
            
            public static int DeleteAllCodonNucleotides(int geneticCodePrimaryKey)
            {
                return Qry.DeleteFrom(DM.CodonNucleotideTable).Where(DM.CodonNucleotide.GeneticCode, geneticCodePrimaryKey).Go().AffectedRows;
            }

            public static int DeleteAllFunctionRegistries(int geneticCodePrimaryKey)
            {
                return Qry.DeleteFrom(DM.FunctionRegistryTable).Where(DM.FunctionRegistry.GeneticCode, geneticCodePrimaryKey).Go().AffectedRows;
            }

            public static int DeleteAllParameters(int geneticCodePrimaryKey)
            {
                return Qry.DeleteFrom(DM.ParameterTable).Where(DM.Parameter.GeneticCode, geneticCodePrimaryKey).Go().AffectedRows;
            }

            /// <summary>
            /// Deletes all codons from the specified Genetic Code.
            /// 
            /// Returns the number of codons that were deleted.
            /// </summary>
            public static int DeleteAllCodons(int geneticCodePrimaryKey)
            {
                return Qry.DeleteFrom(DM.CodonTable).Where(DM.Codon.GeneticCode, geneticCodePrimaryKey).Go().AffectedRows;
            }

            public static int DeleteAllFunctionPairs(int geneticCodePrimaryKey)
            {
                return Qry.DeleteFrom(DM.FunctionPairTable).Where(DM.FunctionPair.GeneticCode, geneticCodePrimaryKey).Go().AffectedRows;
            }

            public static int DeleteAllFunctions(int geneticCodePrimaryKey)
            {
                return Qry.DeleteFrom(DM.TheFunctionTable).Where(DM.TheFunction.GeneticCode, geneticCodePrimaryKey).Go().AffectedRows;
            }

            public static int DeleteAllCodonConverters(int geneticCodePrimaryKey)
            {
                return Qry.DeleteFrom(DM.CodonConverterTable).Where(DM.CodonConverter.GeneticCode, geneticCodePrimaryKey).Go().AffectedRows;
            }

            public static int GetPrimaryKeyFromGeneticCodeName(string geneticCodeName)
            {
                return Qry.SelectPrimaryKeyFrom(DM.GeneticCodeTable).Where(DM.GeneticCode.Name, geneticCodeName).Go().FirstValue.ToInt();
            }
        }
    }
}
