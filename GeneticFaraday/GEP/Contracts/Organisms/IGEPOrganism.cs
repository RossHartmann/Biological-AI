using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms.Chromosomes;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Contracts.Organisms
{
    public interface IGEPOrganism : IOrganism, IGEPChromosomeCollection
    {
        new IGEPEnvironment Parent { get; set; }

        /// <summary>
        /// This IRegistry stores the intermediate calculations of an IGEPOrganism run.
        /// It is the "scratch pad" for all IGEPGenes in this IGEPOrganism.
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Global Registries.
        /// </summary>
        IRegistry GlobalRegistry { get; }

        /// <summary>
        /// This IRegistry stores the "Results" of an IGEPOrganism run.
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Global Registries.
        /// </summary>
        IRegistry ResultsRegistry { get; }

        /// <summary>
        /// Given the IGEPOrganism's immediate surroundings (i.e. the "input"), 
        /// "Runs" the IGEPOrganism which results in its Behavior (i.e. the "ouput").
        /// </summary>
        /// <returns></returns>
        IGEPBehavior Behave(IGEPSurroundings surroundings);

        
    }
}
