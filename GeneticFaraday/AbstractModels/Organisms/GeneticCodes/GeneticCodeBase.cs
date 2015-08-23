using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaraday.Models.Organisms.GeneticCodes.Nucleotides;
using GeneticFaraday.Utility;

namespace GeneticFaraday.AbstractModels.Organisms.GeneticCodes
{
    public abstract class GeneticCodeBase : IGeneticCode
    {
        /// <summary>
        /// A dictionary of all of the valid INucleotides in the IGeneticCode.
        /// </summary>
        /// <remarks>The Key of the dictionary is the INucleotideIdentifier of
        /// the INucleotide (such as "U" or "A" or "G" or "C" or "4" or "23", etc).
        /// Value is the INucleotide.</remarks>
        public SortedList<INucleotideIdentifier, INucleotide> Nucleotides { get; private set; }

        /// <summary>
        /// A dictionary of all of the valid ICodonConverters in the IGeneticCode.
        /// </summary>
        public SortedList<ICodonConverterIdentifier, ICodonConverter> CodonConverters { get; private set; }

        /// <summary>
        /// The length of every ICodon in the IGeneticCode (as measured in INucleotides).
        /// 
        /// All ICodons must be of this length.
        /// </summary>
        public int CodonLength { get; protected set; }

        protected GeneticCodeBase() : this(codonLength: 0)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codonLength">The length of every ICodon in the IGeneticCode.
        /// 
        /// All ICodons must be of this length.</param>
        protected GeneticCodeBase(int codonLength)
        {
            this.CodonLength = codonLength;
            this.Nucleotides = new SortedList<INucleotideIdentifier, INucleotide>();
            this.CodonConverters = new SortedList<ICodonConverterIdentifier, ICodonConverter>();
        }

        /// <summary>
        /// Gets all of the identifiers of all of the ICodons in the IGeneticCode.
        /// </summary>
        /// <returns></returns>
        public abstract List<ICodonIdentifier> GetAllCodonIdentifiers();

        /// <summary>
        /// Sets the ICodon as specified by the given ICodonIdentifier to the specified CodonType.
        /// </summary>
        /// <param name="codonIdentifier"></param>
        /// <param name="codonType"></param>
        public abstract void SetCodonType(ICodonIdentifier codonIdentifier, CodonType codonType);

        /// <summary>
        /// Gets the ICodon as specified by the given ICodonIdentifier.
        /// </summary>
        /// <param name="codonIdentifier"></param>
        /// <returns></returns>
        public abstract ICodon GetCodon(ICodonIdentifier codonIdentifier);

        /// <summary>
        /// Converts the specified ICodon using the specified ICodonConverterIdentifier.
        /// </summary>
        /// <param name="codon"></param>
        /// <param name="codonConverterIdentifier"></param>
        /// <returns></returns>
        public IConvertedCodon ConvertCodon(ICodon codon, ICodonConverterIdentifier codonConverterIdentifier)
        {
            return this.CodonConverters[codonConverterIdentifier].ConvertCodon(codon);
        }
        
        /// <summary>
        /// Adds a Nucleotide with a NucleotideIdentifier where the Identifier is the given nucleotideIdentifier string.
        /// </summary>
        /// <param name="nucleotideIdentifier"></param>
        public void AddNucleotide(string nucleotideIdentifier)
        {
            this.AddNucleotide(new Nucleotide(new NucleotideIdentifier(identifier: nucleotideIdentifier)));
        }

        /// <summary>
        /// Adds the specified INucleotide to the IGeneticCode.
        /// </summary>
        /// <param name="nucleotide"></param>
        public void AddNucleotide(INucleotide nucleotide)
        {
            this.Nucleotides.Add(key: nucleotide.Identifier, value: nucleotide);
        }

        /// <summary>
        /// Adds the specified ICodon to the IGeneticCode.
        /// </summary>
        /// <param name="codon"></param>
        public abstract void AddCodon(ICodon codon);

        /// <summary>
        /// Adds the specified ICodonConverter to the IGeneticCode.
        /// 
        /// Sets the Parent of the given ICodonConverter.
        /// </summary>
        /// <param name="codonConverter"></param>
        public void AddCodonConverter(ICodonConverter codonConverter)
        {
            codonConverter.Parent = this;
            this.CodonConverters.Add(key: codonConverter.Identifier, value: codonConverter);
        }

        /// <summary>
        /// Gets all of the ICodons that have a CodonType of Stop.
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<ICodon> GetStopCodons();

        /// <summary>
        /// Returns a random ICodon in the IGeneticCode.
        /// </summary>
        /// <returns></returns>
        public abstract ICodon GetRandomCodon();

        /// <summary>
        /// Returns a random INucleotide in the IGeneticCode.
        /// </summary>
        /// <returns></returns>
        public INucleotide GetRandomNucleotide()
        {
            return this.Nucleotides.Values.RandomElement();
        }

        /// <summary>
        /// Returns the Last INucleotide in the IGeneticCode.
        /// </summary>
        /// <returns></returns>
        public INucleotide GetLastNucleotide()
        {
            return this.Nucleotides.Values[this.Nucleotides.Count - 1];
        }

        /// <summary>
        /// Returns the First INucleotide in the IGeneticCode.
        /// </summary>
        /// <returns></returns>
        public INucleotide GetFirstNucleotide()
        {
            return this.Nucleotides.Values[0];
        }

        /// <summary>
        /// Gets the next INucleotide after the given INucleotide.
        /// 
        /// Returns null if the given INucleotide is the last INucleotide.
        /// </summary>
        /// <param name="currentNucleotide"></param>
        /// <returns></returns>
        public INucleotide GetNextNucleotide(INucleotide currentNucleotide)
        {
            for (var i = 0; i < this.Nucleotides.Count; i++)
            {
                if (this.Nucleotides.Values[i].Equals(currentNucleotide))
                    return this.Nucleotides.Values[i + 1];
            }

            return null;
        }

        /// <summary>
        /// Gets the previous INucleotide before the given INucleotide.
        /// 
        /// Returns null if the given INucleotide is the first INucleotide.
        /// </summary>
        /// <param name="currentNucleotide"></param>
        /// <returns></returns>
        public INucleotide GetPreviousNucleotide(INucleotide currentNucleotide)
        {
            for (var i = this.Nucleotides.Count - 1; i > 0; i--)
            {
                if (this.Nucleotides.Values[i].Equals(currentNucleotide))
                    return this.Nucleotides.Values[i - 1];
            }

            return null;
        }

        private void _incrementNucleotideSequence(IList<INucleotide> sequence, int index)
        {
            if (!sequence[index].Equals(this.GetLastNucleotide()))
            {
                sequence[index] = this.GetNextNucleotide(sequence[index]);
            }
            else
            {
                sequence[index] = this.GetFirstNucleotide();
                this._incrementNucleotideSequence(sequence, index - 1);
            }
        }

        /// <summary>
        /// Increments the specified sequence of INucleotides.
        /// </summary>
        /// <param name="sequence"></param>
        public void IncrementNucleotideSequence(IList<INucleotide> sequence)
        {
            this._incrementNucleotideSequence(sequence, sequence.Count - 1);
        }

        private void _decrementNucleotideSequence(IList<INucleotide> sequence, int index)
        {
            if (!sequence[index].Equals(this.GetFirstNucleotide()))
            {
                sequence[index] = this.GetPreviousNucleotide(sequence[index]);
            }
            else
            {
                sequence[index] = this.GetLastNucleotide();
                this._decrementNucleotideSequence(sequence, index - 1);
            }
        }

        /// <summary>
        /// Decrements the specified sequence of INucleotides.
        /// </summary>
        /// <param name="sequence"></param>
        public void DecrementNucleotideSequence(IList<INucleotide> sequence)
        {
            this._decrementNucleotideSequence(sequence, sequence.Count - 1);
        }

        /// <summary>
        /// Gets the first INucleotide Sequence that will code for the first ICodon (e.g. "AAA")
        /// </summary>
        /// <returns></returns>
        public IList<INucleotide> GetFirstNucleotideSequence()
        {
            var nucleotideSequence = new List<INucleotide>();
            for (var i = 0; i < this.CodonLength; i++)
                nucleotideSequence.Add(this.GetFirstNucleotide());
            return nucleotideSequence;
        }

        /// <summary>
        /// Indicates whether the given INucleotide Sequence is the last sequence (e.g. "ZZZ").
        /// </summary>
        /// <param name="sequence"></param>
        /// <returns></returns>
        public bool IsLastNucleotideSequence(IEnumerable<INucleotide> sequence)
        {
            return sequence.All(nucleotide => nucleotide.Equals(this.GetLastNucleotide()));
        }

        /// <summary>
        /// Indicates whether the given INucleotide Sequence is the first sequence (e.g. "AAA").
        /// </summary>
        /// <param name="sequence"></param>
        /// <returns></returns>
        public bool IsFirstNucleotideSequence(IEnumerable<INucleotide> sequence)
        {
            return sequence.All(nucleotide => nucleotide.Equals(this.GetFirstNucleotide()));
        }

        /// <summary>
        /// Gets the appropriate nucleotides from the given Codon name.
        /// 
        /// Returns true on success, false on failure.
        /// </summary>
        /// <param name="codonName"></param>
        /// <param name="nucleotides"></param>
        /// <returns></returns>
        public bool GetNucleotidesFromCodonName(string codonName, out List<INucleotide> nucleotides)
        {
            var reversedNucleotides = this.Nucleotides.Reverse();
            var index = 0;
            nucleotides = new List<INucleotide>();
            while (index < codonName.Length)
            {
                var codonNamePortion = codonName.Substring(index);
                var success = false;
                foreach (var nucleotide in reversedNucleotides)
                {
                    if (codonNamePortion.StartsWith(nucleotide.Key.ToString()))
                    {
                        nucleotides.Add(nucleotide.Value);
                        index += nucleotide.Key.ToString().Length;
                        success = true;
                        break;
                    }
                }
                if (!success)
                    return false;
            }

            return true;
        }

    }
}
