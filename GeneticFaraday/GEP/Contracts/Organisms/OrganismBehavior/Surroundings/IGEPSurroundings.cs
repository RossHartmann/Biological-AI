using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings
{
    public interface IGEPSurroundings : ISurroundings
    {
        /// <summary>
        /// The Input IRegistry that will be filled with data and 
        /// then provided to the IGEPOrganism.
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Input Registries.
        /// </summary>
        IRegistry InputRegistry { get; }

    }
}
