using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;

namespace GeneticFaraday.AbstractModels.Organisms.Chromosomes
{
    public abstract class ChromosomeBase : List<IGene>, IChromosome
    {
        /// <summary>
        /// Creates a shallow copy of this IChromosome.
        /// </summary>
        /// <returns></returns>
        public abstract IChromosome ShallowCopy();

        /// <summary>
        /// Adds the specified IGene to this IChromosome and
        /// sets its Parent.
        /// </summary>
        /// <param name="gene"></param>
        /// <returns></returns>
        new public IGene Add(IGene gene)
        {
            gene.Parent = this;
            base.Add(gene);
            return gene;
        }

        /// <summary>
        /// Returns the IGene at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public IGene GeneAt(int index)
        {
            return this[index];
        }

        /// <summary>
        /// The parent of the IChromosome.
        /// </summary>
        public IOrganism Parent { get; set; }

        public IEnvironment ParentEnvironment { get { return this.Parent.Parent; } }

        /// <summary>
        /// Returns the unique IGeneIdentifier of all of the IGenes
        /// that belong to this IChromosome. If no IGenes belong to this IChromosome, the
        /// resulting IEnumerable will be empty.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<IGeneIdentifier> GetIdentifiersOfGenes()
        {
            var geneIdentifiers = new List<IGeneIdentifier>();
            foreach(var gene in this)
            {
                geneIdentifiers.Add(gene.Identifier);
                geneIdentifiers.AddRange(gene.GetIdentifiersOfChildGenes());
            }
            return geneIdentifiers;
        }

        /// <summary>
        /// Assigns unique IGeneIdentifiers to each IGene in this IChromosome.
        /// </summary>
        public virtual void AssignGeneIdentifiers()
        {
            foreach(var gene in this)
            {
                gene.AssignIdentifier();
                gene.AssignIdentifiersToChildren();
            }
        }

        public abstract IChromosomeBehavior Behave(IChromosomeSurroundings surroundings);

        /// <summary>
        /// Gets all of the IGenes that belong to this IChromosome.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<IGene> GetGenes()
        {
            var enumerator = this.GetEnumerator();
            while (enumerator.MoveNext())
                yield return enumerator.Current;
        }
    }
}

