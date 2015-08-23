using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaraday.Models.Organisms.GeneticCodes.Nucleotides;
using GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows;

namespace GeneticFaraday.DatabaseExtensions
{
    public static class NucleotideExtensions
    {
        /// <summary>
        /// Converts the source NucleotideRow to an INucleotide.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static INucleotide ToNucleotide(this NucleotideRow source)
        {
            return new Nucleotide(new NucleotideIdentifier(source.Name));
        }

        public static CodonNucleotideRow ToCodonNucleotideRow(this INucleotide source, int nucleotidePrimaryKey, int codonPrimaryKey, int geneticCodePrimaryKey)
        {
            return new CodonNucleotideRow(nucleotide: nucleotidePrimaryKey, codon: codonPrimaryKey, geneticCode: geneticCodePrimaryKey);
        }
    }
}
