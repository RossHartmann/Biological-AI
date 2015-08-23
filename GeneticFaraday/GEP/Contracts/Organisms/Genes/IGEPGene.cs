using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms.Chromosomes;
using GeneticFaraday.GEP.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes;
using GeneticFaraday.GEP.Contracts.Registries;
using GeneticFaraday.GEP.Contracts.Universe;

namespace GeneticFaraday.GEP.Contracts.Organisms.Genes
{
    public interface IGEPGene : IGene, IGEPGeneCollection, IGEPAlleleCollection
    {
        new IGEPChromosome Parent { get; set; }

        new IGEPGene ParentGene { get; set; }

        new IGEPOrganism ParentOrganism { get; }

        /// <summary>
        /// The IGEPGeneticCode to which this IGEPGene adheres.
        /// </summary>
        new IGEPGeneticCode GeneticCode { get; }

        /// <summary>
        /// The parent IGEPEnvironment of the IGEPGene.
        /// </summary>
        new IGEPEnvironment ParentEnvironment { get; }

        /// <summary>
        /// The parent IGEPUniverse of the IGEPGene.
        /// </summary>
        new IGEPUniverse ParentUniverse { get; }

        /// <summary>
        /// The Local Registry for the IGEPGene.
        /// This will be reset every time this IGEPGene is executed.
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Global Registries.
        /// </summary>
        IRegistry LocalRegistry { get; }

        /// <summary>
        /// Clears all of the Local IRegistries that belong to this IGEPGene.
        /// </summary>
        void ClearLocalRegistries();

        /// <summary>
        /// Gets all of the IRegistries currently available to this IGEPGene.
        /// </summary>
        /// <param name="surroundings">The data passed to this IGEPGeneSurroundings during execution.</param>
        /// <returns></returns>
        IRegistryCollection GetAllRegistries(IGEPGeneSurroundings surroundings);

        /// <summary>
        /// Gets the IRegistry with the specified IRegistryIdentifier.
        /// 
        /// This design allows for adding multiple IRegistries of the same RegistryType but
        /// with different IRegistryIdentifiers. We could, for example, have two separate Global Registries
        /// and the executing IFunction will call the appropriate Global Registry based on its IRegistryIdentifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        IRegistry GetRegistry(IRegistryIdentifier identifier, IGEPGeneSurroundings geneSurroundings);

        /// <summary>
        /// Given the IGEPGene's immediate surroundings (i.e. the "input"), 
        /// "Runs" the IGEPGene which results in its Behavior (i.e. the "ouput").
        /// </summary>
        /// <returns></returns>
        IGEPGeneBehavior Behave(IGEPGeneSurroundings surroundings);

        /// <summary>
        /// Executes the given IAminoAcid and returns the IAminoAcidResult.
        /// 
        /// Returns null if the Max Recursion Level was reached.
        /// </summary>
        /// <param name="aminoAcid">The IAminoAcid to evaluate.</param>
        /// <param name="geneSurroundings">The IGEPGeneSurroundings that were passed to the executing IGEPGene.</param>
        /// <returns></returns>
        IAminoAcidResult ExecuteAminoAcid(IGEPAminoAcid aminoAcid, IGEPGeneSurroundings geneSurroundings);

        /// <summary>
        /// Converts this IGEPGene to its corresponding IDebuggableGene. An IDebuggableGene is an IGene that 
        /// treats the IGene's phenotype as a "program". An IDebuggableGene can be "stepped" into.
        /// </summary>
        /// <returns></returns>
        IDebuggableGene ToDebuggableGene(IGEPGeneSurroundings surroundings);
    }
}
