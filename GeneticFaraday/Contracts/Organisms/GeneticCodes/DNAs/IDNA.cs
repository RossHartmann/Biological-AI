using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;

namespace GeneticFaraday.Contracts.Organisms.GeneticCodes.DNAs
{
    /// <summary>
    /// The "DNA" of an IAllele.
    /// </summary>
    public interface IDNA : IShallowCopyable<IDNA>, INucleotideCollection, IEquatable<IDNA>
    {
        /// <summary>
        /// The Length of the IDNA.
        /// </summary>
        int Length { get; }

        /// <summary>
        /// The IAllele that owns this IDNA.
        /// </summary>
        IAllele Parent { get; set; }

        /// <summary>
        /// The IGeneticCode to which this IDNA adheres.
        /// </summary>
        IGeneticCode GeneticCode { get; }

        /// <summary>
        /// Resets and Randomizes this DNA sequence.
        /// 
        /// The Randomized IDNA will be of the same length as it is when calling this method.
        /// </summary>
        void Randomize();

        /// <summary>
        /// Adds the specified ICodon to the end of this IDNA.
        /// </summary>
        /// <param name="codon"></param>
        void AddCodon(ICodon codon);

        /// <summary>
        /// Adds the specified ICodon to the end of this IDNA.
        /// </summary>
        /// <param name="codonIdentifier"></param>
        void AddCodon(ICodonIdentifier codonIdentifier);

        /// <summary>
        /// Adds the specified INucleotide to the end of this IDNA.
        /// </summary>
        /// <param name="nucleotide"></param>
        void AddNucleotide(INucleotide nucleotide);

        /// <summary>
        /// Adds the specified INucleotide to the end of this IDNA.
        /// </summary>
        /// <param name="nucleotideIdentifier"></param>
        void AddNucleotide(INucleotideIdentifier nucleotideIdentifier);

        /// <summary>
        /// Selects a random INucleotide in this IDNA Sequence
        /// and changes its value to a random other INucleotide.
        /// </summary>
        void RandomlyFlipNucleotide();

        /// <summary>
        /// Changes the value of the specified INucleotide to a random other INucleotide
        /// </summary>
        /// <param name="nucleotideIndex"></param>
        void RandomlyFlipNucleotide(int nucleotideIndex);

        /// <summary>
        /// Changes the value of the specified INucleotide to the next INucleotide. If it is already
        /// at the maximum value, it will be changed to the minimum value and the next INucleotide to the
        /// left will be incremented 1.
        /// </summary>
        /// <param name="nucleotideIndex"></param>
        void IncrementNucleotide(int nucleotideIndex);

        /// <summary>
        /// Changes the value of the specified INucleotide to the previous INucleotide. If it is already
        /// at the minimum value, it will be changed to the maximum value and the INucleotide to the
        /// right will be decremented by 1.
        /// </summary>
        /// <param name="nucleotideIndex"></param>
        void DecrementNucleotide(int nucleotideIndex);

        /// <summary>
        /// Adds a random INucleotide to the end of this IDNA.
        /// </summary>
        void AddRandomNucleotide();

    }
}
