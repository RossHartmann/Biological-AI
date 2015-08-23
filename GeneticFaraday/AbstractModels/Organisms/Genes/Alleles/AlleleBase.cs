using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.DNAs;
using GeneticFaraday.Contracts.Organisms.Genomes;

namespace GeneticFaraday.AbstractModels.Organisms.Genes.Alleles
{
    public abstract class AlleleBase : IAllele
    {
        /// <summary>
        /// Creates a shallow copy of this IAllele.
        /// </summary>
        /// <returns></returns>
        public abstract IAllele ShallowCopy();

        /// <summary>
        /// The parent IGene of this IAllele.
        /// </summary>
        public IGene Parent { get; set; }

        /// <summary>
        /// Only applicable if this IAllele belongs to an IGenome rather than an IOrganism.
        /// This should be set if the IAllele does not belong to an IGene.
        /// </summary>
        public IGenome ParentGenome { get; set; }

        /// <summary>
        /// The IGeneticCode to which this IAllele adheres.
        /// </summary>
        public IGeneticCode GeneticCode { get { return this.Parent == null ? this.ParentGenome.GeneticCode : this.Parent.GeneticCode; } }

        /// <summary>
        /// If true, the child must inherit 2 of these IAlleles (i.e. 2 of 
        /// this version of the IGene), in order for this IAllele to be expressed
        /// as the IGene.
        /// 
        /// If false, the child must only inherit 1 of these IAlleles (i.e. 1 of
        /// this version of the IGene) in order for this IAllele to be expressed
        /// as the IGene.
        /// </summary>
        public bool IsRecessive { get; set; }

        /// <summary>
        /// The DNA sequence of the IAllele.
        /// </summary>
        public IDNA DNA { get; private set; }

        /// <summary>
        /// Resets and randomizes the DNA of this IAllele.
        /// 
        /// The Randomized IDNA will be of the same length as it is when calling this method.
        /// </summary>
        public void Randomize()
        {
            this.DNA.Randomize();
        }

        public bool Equals(IAllele other)
        {
            return this.DNA.Equals(other.DNA);
        }

        protected AlleleBase(IDNA dna)
        {
            this.DNA = dna;
            this.DNA.Parent = this;
        }

        public override string ToString()
        {
            return this.DNA.ToString();
        }
    }
}
