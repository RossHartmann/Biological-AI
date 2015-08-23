using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.DNAs;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaraday.Models.Organisms.GeneticCodes.DNAs;
using GeneticFaraday.Models.Organisms.GeneticCodes.Nucleotides;
using GeneticFaraday.Utility;

namespace GeneticFaraday.AbstractModels.Organisms.GeneticCodes.DNAs
{
    public abstract class DNABase : List<INucleotide>, IDNA
    {
        protected DNABase() : base()
        {
            
        }

        protected DNABase(IEnumerable<INucleotide> nucleotides)
            : base(nucleotides)
        {
            
        }

        public bool Equals(IDNA other)
        {
            if (this.Length != other.Length)
                return false;

            for(var i = 0; i < this.Length; i++)
                if (!this[i].Equals(other[i]))
                    return false;

            return true;
        }

        public int Length { get { return this.Count; } }

        public IAllele Parent { get; set; }

        /// <summary>
        /// The IGeneticCode to which this IDNA adheres.
        /// </summary>
        public IGeneticCode GeneticCode { get { return this.Parent.GeneticCode; } }

        /// <summary>
        /// Resets and randomizes the INucleotides of this IDNA Sequence.
        /// The Randomized IDNA will be of the same length as it is when calling this method.
        /// </summary>
        public void Randomize()
        {
            var dnaLength = this.Length;
            this.Clear();

            for (var i = 0; i < dnaLength; i++)
                this.AddRandomNucleotide();
        }


        /// <summary>
        /// Adds the specified ICodon to the end of this IDNA.
        /// </summary>
        /// <param name="codon"></param>
        public void AddCodon(ICodon codon)
        {
            this.AddRange(codon);
        }

        /// <summary>
        /// Adds the specified ICodon to the end of this IDNA.
        /// </summary>
        /// <param name="codonIdentifier"></param>
        public void AddCodon(ICodonIdentifier codonIdentifier)
        {
            this.AddCodon(this.GeneticCode.GetCodon(codonIdentifier));
        }

        /// <summary>
        /// Adds the specified INucleotide to the end of this IDNA.
        /// </summary>
        /// <param name="nucleotide"></param>
        public void AddNucleotide(INucleotide nucleotide)
        {
            this.Add(nucleotide);
        }

        /// <summary>
        /// Adds the specified INucleotide to the end of this IDNA.
        /// </summary>
        /// <param name="nucleotideIdentifier"></param>
        public void AddNucleotide(INucleotideIdentifier nucleotideIdentifier)
        {
            this.Add(this.GeneticCode.Nucleotides[nucleotideIdentifier]);
        }

        /// <summary>
        /// Selects a random INucleotide in this IDNA Sequence
        /// and changes its value to a random other INucleotide.
        /// </summary>
        public void RandomlyFlipNucleotide()
        {
            this.RandomlyFlipNucleotide(this.RandomIndex());
        }

        /// <summary>
        /// Changes the value of the specified INucleotide to a random other INucleotide
        /// </summary>
        /// <param name="nucleotideIndex"></param>
        public void RandomlyFlipNucleotide(int nucleotideIndex)
        {
            while(true)
            {
                var newNucleotide = this.GeneticCode.GetRandomNucleotide();
                if (!newNucleotide.Equals(this[nucleotideIndex]))
                {
                    this[nucleotideIndex] = newNucleotide;
                    break;
                }
            }

            
        }

        /// <summary>
        /// Changes the value of the specified INucleotide to the next INucleotide. If it is already
        /// at the maximum value, it will be changed to the minimum value and the next INucleotide to the
        /// left will be incremented 1.
        /// </summary>
        /// <param name="nucleotideIndex"></param>
        public void IncrementNucleotide(int nucleotideIndex)
        {
            var toBeIncremented = this.SubList(0, nucleotideIndex + 1);

            // Only increment it if it can be incremented
            if (!this.GeneticCode.IsLastNucleotideSequence(toBeIncremented))
            {
                this.GeneticCode.IncrementNucleotideSequence(toBeIncremented);

                var newNucleotides = toBeIncremented;
                newNucleotides.AddRange(this.SubList(nucleotideIndex + 1));

                this.Clear();
                this.AddRange(newNucleotides);
            }
        }

        /// <summary>
        /// Changes the value of the specified INucleotide to the previous INucleotide. If it is already
        /// at the minimum value, it will be changed to the maximum value and the INucleotide to the
        /// right will be decremented by 1.
        /// </summary>
        /// <param name="nucleotideIndex"></param>
        public void DecrementNucleotide(int nucleotideIndex)
        {
            var toBeDecremented = this.SubList(0, nucleotideIndex + 1);

            // Only increment it if it can be incremented
            if (!this.GeneticCode.IsFirstNucleotideSequence(toBeDecremented))
            {
                this.GeneticCode.DecrementNucleotideSequence(toBeDecremented);

                var newNucleotides = toBeDecremented;
                newNucleotides.AddRange(this.SubList(nucleotideIndex + 1));

                this.Clear();
                this.AddRange(newNucleotides);
            }
        }

        /// <summary>
        /// Adds a random INucleotide to the end of this IDNA.
        /// </summary>
        public void AddRandomNucleotide()
        {
            this.AddNucleotide(this.GeneticCode.GetRandomNucleotide());
        }

        public virtual IDNA ShallowCopy()
        {
            var other = new DNA();
            foreach (var nucleotide in this)
                other.AddNucleotide(nucleotide);
            return other;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            foreach (var nucleotide in this)
                stringBuilder.Append(nucleotide.ToString());
            return stringBuilder.ToString();
        }
    }
}



