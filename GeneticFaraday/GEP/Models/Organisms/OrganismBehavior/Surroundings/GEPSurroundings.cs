using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Models.Organisms.OrganismBehavior.Surroundings
{
    public class GEPSurroundings : GEPSurroundingsBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputRegistry">The Input IRegistry that will be filled with data and 
        /// then provided to the IGEPOrganism.
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Input Registries.</param>
        public GEPSurroundings(IRegistry inputRegistry) 
            : base(inputRegistry)
        {
        }
    }
}
