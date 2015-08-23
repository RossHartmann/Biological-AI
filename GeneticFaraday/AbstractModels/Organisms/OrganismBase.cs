using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Metrics;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genomes;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.Contracts.Organisms.Phenomes;
using GeneticFaraday.GEP.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Models.Organisms.Genes;
using GeneticFaraday.Utility;

namespace GeneticFaraday.AbstractModels.Organisms
{
    public abstract class OrganismBase : List<IChromosome>, IOrganism
    {
        protected OrganismBase() : this(new IChromosome[] { })
        {
            
        }

        protected OrganismBase(IEnumerable<IChromosome> collection)
            : base(collection: collection)
        {
            this.UniqueStringGenerator = new UniqueStringGenerator();
        }

        /// <summary>
        /// Creates a shallow copy of this IOrganism.
        /// </summary>
        /// <returns></returns>
        public abstract IOrganism ShallowCopy();

        /// <summary>
        /// Adds the specified IChromosome to this IOrganism and
        /// sets its Parent.
        /// </summary>
        /// <param name="chromosome"></param>
        /// <returns></returns>
        new public IChromosome Add(IChromosome chromosome)
        {
            chromosome.Parent = this;
            base.Add(chromosome);
            return chromosome;
        }

        /// <summary>
        /// The parent of the IOrganism.
        /// </summary>
        public IEnvironment Parent { get; set; }

        protected UniqueStringGenerator UniqueStringGenerator { get; set; }

        /// <summary>
        /// Returns the next unique identifier for an IGene in this IOrganism.
        /// </summary>
        /// <returns></returns>
        public IGeneIdentifier GetNextUniqueGeneIdentifier()
        {
            return new GeneIdentifier(identifier: this.UniqueStringGenerator.GetNextString());
        }

        /// <summary>
        /// Assigns unique IGeneIdentifier to each IGene in each IChromosome in 
        /// this IOrganism.
        /// </summary>
        public void AssignGeneIdentifiers()
        {
            foreach (var chromosome in this)
                chromosome.AssignGeneIdentifiers();
        }


        public IEnumerable<IChromosome> GetChromosomes()
        {
            var enumerator = this.GetEnumerator();
            while (enumerator.MoveNext())
                yield return enumerator.Current;
        }

        /// <summary>
        /// Converts this IOrganism to its corresponding IGenome.
        /// </summary>
        /// <returns></returns>
        public abstract IGenome ToGenome();

        /// <summary>
        /// Converts this IOrganism to its corresponding IPhenome.
        /// </summary>
        /// <returns></returns>
        public abstract IPhenome ToPhenome(ISurroundings surroundings);


        /// <summary>
        /// The Metrics used to measure the "value" of the IOrganism.
        /// </summary>
        public IMetrics Metrics { get; set; }

        /// <summary>
        /// Given the IOrganism's immediate surroundsings (i.e. the "input"), 
        /// Makes the IOrganism "live" which results in its Behavior (i.e. the "ouput").
        /// </summary>
        /// <param name="surroundings"></param>
        /// <returns></returns>
        public abstract IBehavior Behave(ISurroundings surroundings);
    }
}
