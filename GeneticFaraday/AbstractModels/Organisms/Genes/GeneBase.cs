using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.Contracts.Universe;

namespace GeneticFaraday.AbstractModels.Organisms.Genes
{
    public abstract class GeneBase : IGene
    {
        public List<IGene> ChildGenes { get; protected set; }
        public List<IAllele> Alleles { get; protected set; }

        /// <summary>
        /// Creates a shallow copy of this IGene.
        /// </summary>
        /// <returns></returns>
        public abstract IGene ShallowCopy();

        protected GeneBase()
        {
            this.ChildGenes = new List<IGene>();
            this.Alleles = new List<IAllele>();
        }

        /// <summary>
        /// Adds the specified IAllele to this IGene and
        /// sets its Parent.
        /// </summary>
        /// <param name="allele"></param>
        /// <returns></returns>
        public IAllele Add(IAllele allele)
        {
            allele.Parent = this;
            this.Alleles.Add(allele);
            return allele;
        }

        /// <summary>
        /// Returns the IAllele at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public IAllele AlleleAt(int index)
        {
            return this.Alleles[index];
        }


        /// <summary>
        /// The parent IChromosome of the IGene.
        /// </summary>
        public IChromosome Parent { get; set; }

        public IOrganism ParentOrganism { get { return this.Parent.Parent; } }

        public IEnvironment ParentEnvironment { get { return this.ParentOrganism.Parent; } }

        public IUniverse ParentUniverse { get { return this.ParentEnvironment.Parent; } }

        /// <summary>
        /// The IGeneticCode to which this IGene adheres.
        /// </summary>
        public IGeneticCode GeneticCode { get { return this.ParentUniverse.GeneticCode; } }

        /// <summary>
        /// If true, this IGene's direct parent is the IChromosome (and it does not belong to
        /// another IGene).
        /// </summary>
        public bool IsRootLevel { get { return this.ParentGene == null; } }

        /// <summary>
        /// If this IGene belongs to another IGene, this is the owning IGene.
        /// </summary>
        public IGene ParentGene { get; set; }


        /// <summary>
        /// Randomizes the DNA of the IAlleles that belong to this IGene.
        /// 
        /// The Randomized IDNA will be of the same length as it is when calling this method.
        /// </summary>
        public void RandomizeAlleles()
        {
            foreach(var allele in this.Alleles)
                allele.Randomize();
        }

        /// <summary>
        /// The unique identifier of this IGene that will be used to 
        /// uniquely identify this gene in the parent IOrganism.
        /// </summary>
        public IGeneIdentifier Identifier { get; private set; }

        /// <summary>
        /// Sets the Identifier of this IGene to the next unique IGeneIdentifier.
        /// </summary>
        public virtual void AssignIdentifier()
        {
            this.Identifier = this.ParentOrganism.GetNextUniqueGeneIdentifier();
        }

        /// <summary>
        /// Assigns the Identifiers to all of the children IGenes of this IGene.
        /// </summary>
        public virtual void AssignIdentifiersToChildren()
        {
            foreach (var childGene in this.ChildGenes)
            {
                childGene.AssignIdentifiersToChildren();
                childGene.AssignIdentifier();
            }
        }

        /// <summary>
        /// Returns the unique identifiers of all of the Child IGenes
        /// that belong to this IGene. If no IGenes belong to this IGene, the
        /// resulting IEnumerable will be empty.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<IGeneIdentifier> GetIdentifiersOfChildGenes()
        {
            var identifiers = new List<IGeneIdentifier>();
            foreach (var gene in this.ChildGenes)
            {
                identifiers.AddRange(gene.GetIdentifiersOfChildGenes());
                identifiers.Add(gene.Identifier);
            }
            return identifiers;
        }

        /// <summary>
        /// Given the IGene's immediate surroundings (i.e. the "input"), 
        /// "Runs" the IGene which results in its Behavior (i.e. the "ouput").
        /// </summary>
        /// <param name="surroundings"></param>
        /// <returns></returns>
        public abstract IGeneBehavior Behave(IGeneSurroundings surroundings);

        /// <summary>
        /// Gets the IAllele of the IGene that is active among all of the different
        /// IAlleles that belong to this IGene.
        /// 
        /// This active IAllele is the IAllele whose DNA will be used.
        /// </summary>
        /// <returns></returns>
        public abstract IAllele GetActiveAllele();

        /// <summary>
        /// Gets the IAlleles of the IGene that are NOT active (i.e will not be used
        /// in the IGene's phenotype).
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<IAllele> GetInactiveAlleles();

        public IEnumerable<IGene> GetChildGenes()
        {
            return this.ChildGenes;
        }

        /// <summary>
        /// Assigns this.Parent for each child IGene to the top-level IGene's this.Parent.
        /// </summary>
        public void ReassignChildrenChromosomeParent()
        {
            foreach(var child in this.ChildGenes)
            {
                child.Parent = this.Parent;
                child.ReassignChildrenChromosomeParent();
            }
        }

        public abstract IGenePhenotype CreatePhenotype();

        #region List<IGene>

        

        public IEnumerator<IGene> GetEnumerator()
        {
            return this.ChildGenes.GetEnumerator();
        }

        void ICollection<IGene>.Add(IGene item)
        {
            this.Add(gene: item);
        }

        /// <summary>
        /// Returns the IGene at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public IGene GeneAt(int index)
        {
            return this.ChildGenes[index];
        }

        void ICollection<IGene>.Clear()
        {
            this.ChildGenes.Clear();
        }

        public IGene Add(IGene gene)
        {
            gene.Parent = this.Parent;
            gene.ParentGene = this;
            this.ChildGenes.Add(gene);
            return gene;
        }

        public bool Contains(IGene item)
        {
            return this.ChildGenes.Contains(item: item);
        }

        public void CopyTo(IGene[] array, int arrayIndex)
        {
            this.ChildGenes.CopyTo(array: array, arrayIndex: arrayIndex);
        }

        public bool Remove(IGene item)
        {
            return this.ChildGenes.Remove(item: item);
        }

        int ICollection<IGene>.Count { get { return this.ChildGenes.Count; } }

        public bool IsReadOnly { get { return false; } }

        public int IndexOf(IGene item)
        {
            return this.ChildGenes.IndexOf(item: item);
        }

        public void Insert(int index, IGene item)
        {
            this.ChildGenes.Insert(index: index, item: item);
        }

        void IList<IGene>.RemoveAt(int index)
        {
            this.ChildGenes.RemoveAt(index: index);
        }

        public int IndexOf(IAllele item)
        {
            return this.Alleles.IndexOf(item: item);
        }

        public void Insert(int index, IAllele item)
        {
            this.Alleles.Insert(index: index, item: item);
        }

        public IGene this[int index]
        {
            get { return this.ChildGenes[index]; }
            set { this.ChildGenes[index] = value; }
        }

        #endregion


        #region List<IAllele>

        IEnumerator<IAllele> IEnumerable<IAllele>.GetEnumerator()
        {
            return this.Alleles.GetEnumerator();
        }

        void ICollection<IAllele>.Add(IAllele item)
        {
            this.Add(allele: item);
        }

        void IList<IAllele>.RemoveAt(int index)
        {
            this.Alleles.RemoveAt(index: index);
        }

        IAllele IList<IAllele>.this[int index]
        {
            get { return this.Alleles[index]; }
            set { this.Alleles[index] = value; }
        }

        void ICollection<IAllele>.Clear()
        {
            this.Alleles.Clear();
        }

        public bool Contains(IAllele item)
        {
            return this.Alleles.Contains(item: item);
        }

        public void CopyTo(IAllele[] array, int arrayIndex)
        {
            this.Alleles.CopyTo(array: array, arrayIndex: arrayIndex);
        }

        public bool Remove(IAllele item)
        {
            return this.Alleles.Remove(item: item);
        }

        int ICollection<IAllele>.Count { get { return this.Alleles.Count; } }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
