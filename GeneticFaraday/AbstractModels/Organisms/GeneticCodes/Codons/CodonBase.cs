using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaraday.Models.Exceptions;
using UtilityData.LINQ;

namespace GeneticFaraday.AbstractModels.Organisms.GeneticCodes.Codons
{
    public abstract class CodonBase :  ICodon
    {
        /// <summary>
        /// The Nucleotides that make up this ICodon.
        /// </summary>
        protected List<INucleotide> Nucleotides { get; private set; }

        /// <summary>
        /// The unique Identiifer of this ICodon.
        /// </summary>
        public ICodonIdentifier CodonIdentifier { get; private set; }

        /// <summary>
        /// The type of the ICodon.
        /// </summary>
        public CodonType CodonType { get; set; }

        protected CodonBase(IGeneticCode geneticCode, ICodonIdentifier codonIdentifier, CodonType codonType,
            IEnumerable<INucleotideIdentifier> nucleotides) :
            this(geneticCode: geneticCode, codonIdentifier: codonIdentifier, codonType: codonType,
            nucleotides: nucleotides.Select(i => geneticCode.Nucleotides[i]))
        {
        }

        protected CodonBase(IGeneticCode geneticCode, ICodonIdentifier codonIdentifier, CodonType codonType,
            IEnumerable<INucleotide> nucleotides)
        {
            this.CodonIdentifier = codonIdentifier;
            this.CodonType = codonType;
            this.Nucleotides = nucleotides as List<INucleotide> ?? nucleotides.ToList();

            if (this.Nucleotides.Count() != geneticCode.CodonLength)
                throw new GeneticCodeException("All Codons must be of the specified CodonLength in the Genetic Code.");
        }

        /// <summary>
        /// Converts this ICodon to a IConvertedCodon as specified by the given ICodonConverterIdentifier.
        /// </summary>
        /// <param name="geneticCode"></param>
        /// <param name="codonConverterIdentifier"></param>
        /// <returns>The converted IConvertedCodon.</returns>
        public IConvertedCodon Convert(IGeneticCode geneticCode, ICodonConverterIdentifier codonConverterIdentifier)
        {
            return geneticCode.ConvertCodon(codon: this, codonConverterIdentifier: codonConverterIdentifier);
        }

        public override string ToString()
        {
            return "{ " + this.Nucleotides.Select(n => n.Identifier.ToString()).ConcatContents() + " }, " + this.CodonType;
        }

        public IEnumerator<INucleotide> GetEnumerator()
        {
            return this.Nucleotides.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(ICodon other)
        {
            return this.CodonIdentifier.CompareTo(other.CodonIdentifier);
        }

        public bool Equals(ICodon other)
        {
            return this.CodonIdentifier.Equals(other.CodonIdentifier);
        }

        public static bool operator ==(CodonBase codonOne, CodonBase codonTwo)
        {
            if ((object)codonOne == null ^ (object)codonTwo == null)
                return false;
            return (object)codonOne == null || codonOne.Equals(codonTwo);
        }

        public static bool operator !=(CodonBase codonOne, CodonBase codonTwo)
        {
            return !(codonOne == codonTwo);
        }

        protected bool Equals(CodonBase other)
        {
            return Equals(CodonIdentifier, other.CodonIdentifier);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CodonBase)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (Nucleotides != null ? Nucleotides.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (CodonIdentifier != null ? CodonIdentifier.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ CodonType.GetHashCode();
                return hashCode;
            }
        }

        public void Add(INucleotide item)
        {
            this.Nucleotides.Add(item: item);
        }

        public void Clear()
        {
            this.Nucleotides.Clear();
        }

        public bool Contains(INucleotide item)
        {
            return this.Nucleotides.Contains(item: item);
        }

        public void CopyTo(INucleotide[] array, int arrayIndex)
        {
            this.Nucleotides.CopyTo(array: array, arrayIndex: arrayIndex);
        }

        public bool Remove(INucleotide item)
        {
            return this.Nucleotides.Remove(item: item);
        }

        public int Count { get { return this.Nucleotides.Count; } }

        public bool IsReadOnly { get { return false; } }

        public int IndexOf(INucleotide item)
        {
            return this.Nucleotides.IndexOf(item: item);
        }

        public void Insert(int index, INucleotide item)
        {
            this.Nucleotides.Insert(index: index, item: item);
        }

        public void RemoveAt(int index)
        {
            this.Nucleotides.RemoveAt(index: index);
        }

        public INucleotide this[int index]
        {
            get { return this.Nucleotides[index]; }
            set { this.Nucleotides[index] = value; }
        }
    }
}
