using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaraday.Models.Organisms.GeneticCodes.Nucleotides;

namespace GeneticFaraday.Contracts.Organisms.GeneticCodes
{
    public interface IGeneticCode
    {
        /// <summary>
        /// A dictionary of all of the valid INucleotides in the IGeneticCode.
        /// </summary>
        /// <remarks>The Key of the dictionary is the INucleotideIdentifier of
        /// the INucleotide (such as "U" or "A" or "G" or "C" or "4" or "23", etc).
        /// Value is the INucleotide.</remarks>
        SortedList<INucleotideIdentifier, INucleotide> Nucleotides { get; }

        /// <summary>
        /// Gets the ICodon as specified by the given ICodonIdentifier.
        /// </summary>
        /// <param name="codonIdentifier"></param>
        /// <returns></returns>
        ICodon GetCodon(ICodonIdentifier codonIdentifier);

        /// <summary>
        /// Gets all of the identifiers of all of the ICodons in the IGeneticCode.
        /// </summary>
        /// <returns></returns>
        List<ICodonIdentifier> GetAllCodonIdentifiers();

        /// <summary>
        /// Sets the ICodon as specified by the given ICodonIdentifier to the specified CodonType.
        /// </summary>
        /// <param name="codonIdentifier"></param>
        /// <param name="codonType"></param>
        void SetCodonType(ICodonIdentifier codonIdentifier, CodonType codonType);



        /// <summary>
        /// A dictionary of all of the valid ICodonConverters in the IGeneticCode.
        /// </summary>
        SortedList<ICodonConverterIdentifier, ICodonConverter> CodonConverters { get; }

        /// <summary>
        /// The length of every ICodon in the IGeneticCode.
        /// 
        /// All ICodons must be of this length.
        /// </summary>
        int CodonLength { get; }

        /// <summary>
        /// Converts the specified ICodon using the specified ICodonConverterIdentifier.
        /// </summary>
        /// <param name="codon"></param>
        /// <param name="codonConverterIdentifier"></param>
        /// <returns></returns>
        IConvertedCodon ConvertCodon(ICodon codon, ICodonConverterIdentifier codonConverterIdentifier);

        /// <summary>
        /// Adds the specified INucleotide to the IGeneticCode.
        /// </summary>
        /// <param name="nucleotide"></param>
        void AddNucleotide(INucleotide nucleotide);

        /// <summary>
        /// Adds the specified ICodon to the IGeneticCode.
        /// </summary>
        /// <param name="codon"></param>
        void AddCodon(ICodon codon);

        /// <summary>
        /// Adds the specified ICodonConverter to the IGeneticCode.
        /// 
        /// Sets the Parent of the given ICodonConverter.
        /// </summary>
        /// <param name="codonConverter"></param>
        void AddCodonConverter(ICodonConverter codonConverter);

        /// <summary>
        /// Gets all of the ICodons that have a CodonType of Stop.
        /// </summary>
        /// <returns></returns>
        IEnumerable<ICodon> GetStopCodons();

        /// <summary>
        /// Returns a random ICodon in the IGeneticCode.
        /// </summary>
        /// <returns></returns>
        ICodon GetRandomCodon();

        /// <summary>
        /// Returns a random INucleotide in the IGeneticCode.
        /// </summary>
        /// <returns></returns>
        INucleotide GetRandomNucleotide();
        
        /// <summary>
        /// Returns the Last INucleotide in the IGeneticCode.
        /// </summary>
        /// <returns></returns>
        INucleotide GetLastNucleotide();

        /// <summary>
        /// Returns the First INucleotide in the IGeneticCode.
        /// </summary>
        /// <returns></returns>
        INucleotide GetFirstNucleotide();

        /// <summary>
        /// Gets the next INucleotide after the given INucleotide.
        /// 
        /// Returns null if the given INucleotide is the last INucleotide.
        /// </summary>
        /// <param name="currentNucleotide"></param>
        /// <returns></returns>
        INucleotide GetNextNucleotide(INucleotide currentNucleotide);

        /// <summary>
        /// Gets the previous INucleotide before the given INucleotide.
        /// 
        /// Returns null if the given INucleotide is the first INucleotide.
        /// </summary>
        /// <param name="currentNucleotide"></param>
        /// <returns></returns>
        INucleotide GetPreviousNucleotide(INucleotide currentNucleotide);

        /// <summary>
        /// Increments the specified sequence of INucleotides.
        /// </summary>
        /// <param name="sequence"></param>
        void IncrementNucleotideSequence(IList<INucleotide> sequence);

        /// <summary>
        /// Decrements the specified sequence of INucleotides.
        /// </summary>
        /// <param name="sequence"></param>
        void DecrementNucleotideSequence(IList<INucleotide> sequence);

        /// <summary>
        /// Gets the first INucleotide Sequence that will code for the first ICodon (e.g. "AAA")
        /// </summary>
        /// <returns></returns>
        IList<INucleotide> GetFirstNucleotideSequence();

        /// <summary>
        /// Indicates whether the given INucleotide Sequence is the last sequence (e.g. "ZZZ").
        /// </summary>
        /// <param name="sequence"></param>
        /// <returns></returns>
        bool IsLastNucleotideSequence(IEnumerable<INucleotide> sequence);

        /// <summary>
        /// Indicates whether the given INucleotide Sequence is the first sequence (e.g. "AAA").
        /// </summary>
        /// <param name="sequence"></param>
        /// <returns></returns>
        bool IsFirstNucleotideSequence(IEnumerable<INucleotide> sequence);

        /// <summary>
        /// Gets the appropriate nucleotides from the given Codon name.
        /// 
        /// Returns true on success, false on failure.
        /// </summary>
        /// <param name="codonName"></param>
        /// <param name="nucleotides"></param>
        /// <returns></returns>
        bool GetNucleotidesFromCodonName(string codonName, out List<INucleotide> nucleotides);
    }
}
