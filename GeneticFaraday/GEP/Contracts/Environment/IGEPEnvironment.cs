using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Environment.CallableGenesProviders;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Registries;
using GeneticFaraday.GEP.Contracts.Universe;

namespace GeneticFaraday.GEP.Contracts.Environment
{
    public interface IGEPEnvironment : IEnvironment
    {
        /// <summary>
        /// The parent IGEPUniverse of the IGEPEnvironment.
        /// </summary>
        new IGEPUniverse Parent { get; set; }

        /// <summary>
        /// The IRegistryIdentifier of the primary LocalRegistry for each IGEPGene.
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Global Registries.
        /// </summary>
        IRegistryIdentifier LocalRegistryIdentifier { get; }
        /// <summary>
        /// The IRegistryIdentifier of the primary GlobalRegistry for the IGEPOrganism.
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Global Registries.
        /// </summary>
        IRegistryIdentifier GlobalRegistryIdentifier { get; }
        /// <summary>
        /// The IRegistryIdentifier of the primary ResultsRegistry for the IGEPOrganism
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Global Registries.
        /// </summary>
        IRegistryIdentifier ResultsRegistryIdentifier { get; }
        /// <summary>
        /// The IRegistryIdentifier of the primary InputRegistry for the IGEPOrganism.
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Global Registries.
        /// </summary>
        IRegistryIdentifier InputRegistryIdentifier { get; }
        /// <summary>
        /// The IRegistryIdentifier of the primary LocalGlobalRegistry for each IGEPChromosome.
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Global Registries.
        /// </summary>
        IRegistryIdentifier LocalGlobalRegistryIdentifier { get; }

        /// <summary>
        /// An Array of all of the IRegistryIdentifiers for all of the possible IRegistries in this IGEPEnvironment.
        /// </summary>
        IRegistryIdentifier[] AllRegistryIdentifiers { get; }

        /// <summary>
        /// An Array of all of the IRegistryIdentifiers for all of the IRegistries in this IGEPEnvironment that are NOT
        /// ReadOnly.
        /// </summary>
        IRegistryIdentifier[] AllWriteableRegistryIdentifiers { get; }

        /// <summary>
        /// The IGEPGeneticCode to which all IGEPOrganisms in the IGEPEnvironment must adhere.
        /// </summary>
        new IGEPGeneticCode GeneticCode { get; }

        /// <summary>
        /// The ICallableGenesProvider that gets the IGEPGenes that can be called by the given IGEPGene.
        /// </summary>
        /// <returns></returns>
        ICallableGenesProvider CallableGenesProvider { get; }
    }
}
