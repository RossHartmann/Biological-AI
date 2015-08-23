using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.Contracts.Universe;

namespace GeneticFaraday.Contracts.Organisms.Genes
{
    /// <summary>
    /// An IGene has the capability of adding other IGenes underneath it. An IGene acts as an IGeneCollection.
    /// It is not, however, required to have other IGenes underneath it.
    /// </summary>
    public interface IGene : IShallowCopyable<IGene>, IAlleleCollection, IGeneCollection
    {

        /// <summary>
        /// The parent IChromosome of the IGene.
        /// </summary>
        IChromosome Parent { get; set; }

        /// <summary>
        /// The parent IOrganism of the IGene.
        /// </summary>
        IOrganism ParentOrganism { get; }

        /// <summary>
        /// The parent IEnvironment of the IGene.
        /// </summary>
        IEnvironment ParentEnvironment { get; }

        /// <summary>
        /// The parent IUniverse of the IGene.
        /// </summary>
        IUniverse ParentUniverse { get; }

        /// <summary>
        /// The IGeneticCode to which this IGene adheres.
        /// </summary>
        IGeneticCode GeneticCode { get; }

        /// <summary>
        /// If true, this IGene's direct parent is the IChromosome (and it does not belong to
        /// another IGene).
        /// </summary>
        bool IsRootLevel { get; }

        /// <summary>
        /// If this IGene belongs to another IGene, this is the owning IGene.
        /// </summary>
        IGene ParentGene { get; set; }

        /// <summary>
        /// Randomizes the DNA of the IAlleles that belong to this IGene.
        /// 
        /// The Randomized IDNA will be of the same length as it is when calling this method.
        /// </summary>
        void RandomizeAlleles();

        /// <summary>
        /// The unique identifier of this IGene that will be used to 
        /// uniquely identify this gene in the parent IOrganism.
        /// </summary>
        IGeneIdentifier Identifier { get; }

        /// <summary>
        /// Sets the Identifier of this IGene to the next unique IGeneIdentifier.
        /// </summary>
        void AssignIdentifier();

        /// <summary>
        /// Assigns the Identifiers to all of the children IGenes of this IGene.
        /// </summary>
        void AssignIdentifiersToChildren();

        /// <summary>
        /// Returns the unique identifiers of all of the Child IGenes
        /// that belong to this IGene. If no IGenes belong to this IGene, the
        /// resulting IEnumerable will be empty.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IGeneIdentifier> GetIdentifiersOfChildGenes();

        /// <summary>
        /// Given the IGene's immediate surroundings (i.e. the "input"), 
        /// "Runs" the IGene which results in its Behavior (i.e. the "ouput").
        /// </summary>
        /// <param name="surroundings"></param>
        /// <returns></returns>
        IGeneBehavior Behave(IGeneSurroundings surroundings);

        /// <summary>
        /// Gets the IAllele of the IGene that is active among all of the different
        /// IAlleles that belong to this IGene.
        /// 
        /// This active IAllele is the IAllele whose DNA will be used to create the IGene's Phenotype.
        /// </summary>
        /// <returns></returns>
        IAllele GetActiveAllele();

        /// <summary>
        /// Gets the IAlleles of the IGene that are NOT active (i.e will not be used
        /// in the IGene's phenotype).
        /// </summary>
        /// <returns></returns>
        IEnumerable<IAllele> GetInactiveAlleles();

        /// <summary>
        /// Returns the IGenes that belong directly to this IGene.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IGene> GetChildGenes();

        /// <summary>
        /// Assigns this.Parent for each child IGene to the top-level IGene's this.Parent.
        /// </summary>
        void ReassignChildrenChromosomeParent();

        /// <summary>
        /// Returns the Phenotype of this IGene.
        /// </summary>
        /// <returns></returns>
        IGenePhenotype CreatePhenotype();
    }
}
