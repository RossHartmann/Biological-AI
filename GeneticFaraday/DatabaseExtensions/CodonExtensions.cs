using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.Functions;
using GeneticFaraday.Models.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Models.Organisms.GeneticCodes.Nucleotides;
using UtilityData.Exceptions.DatabaseExceptions;

namespace GeneticFaraday.DatabaseExtensions
{
    public static class CodonExtensions
    {
        /*
        public static CodonType ToCodonType(this GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.CodonType source)
        {
            if(source == GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.CodonType.Standard)
                return CodonType.Standard;
            else if(source == GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.CodonType.Stop)
                return CodonType.Stop;
            else
            {
                throw new ValueNotYetSupported(source, typeof(GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.CodonType));
            }
        }

        public static GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.CodonType ToCodonType(this CodonType source)
        {
            if (source == CodonType.Standard)
                return GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.CodonType.Standard;
            else if (source == CodonType.Stop)
                return GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.CodonType.Stop;
            else
            {
                throw new ValueNotYetSupported(source, typeof(GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.CodonType));
            }
        }

        /// <summary>
        /// Converts the source CodonRow (with its FunctionPairRow joined) to an IGEPCodon.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="geneticCode"></param>
        /// <returns></returns>
        public static IGEPCodon ToGEPCodon(this CodonRow source, IGEPGeneticCode geneticCode)
        {
            if(source.FunctionPairRow.IsPrimaryFunctionIdentifierNullOrEmpty)
                throw new Exception("The FunctionPairRow must be joined.");

            List<INucleotide> nucleotides;
            if(!geneticCode.GetNucleotidesFromCodonName(source.Name, out nucleotides))
                throw new Exception("Invalid Codon Name for this Genetic Code's Nucleotides.");

            return new GEPCodon(geneticCode: geneticCode, codonIdentifier: new CodonIdentifier(source.Name),
                                codonType: source.CodonType.ToCodonType(), nucleotides: nucleotides,
                                functions:
                                    new FunctionPair(geneticCode,
                                                     new FunctionIdentifier(
                                                         source.FunctionPairRow.PrimaryFunctionIdentifier),
                                                     new FunctionIdentifier(
                                                         source.FunctionPairRow.ParameterlessFunctionIdentifier)));
        }
         */
    }
}
