using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.OrganismBehavior.Surroundings
{
    public abstract class GEPSurroundingsBase : SurroundingsBase, IGEPSurroundings
    {
        /// <summary>
        /// The Input IRegistry that will be filled with data and 
        /// then provided to the IGEPOrganism.
        /// 
        /// Using IGEPGene's "GetRegistry(IRegistryIdentifier identifier)" allows us, however, to have
        /// multiple IRegistries of the same RegistryType but different IRegistryIdentifiers. We could, for
        /// example, have 2 Input Registries.
        /// </summary>
        public IRegistry InputRegistry { get; private set; }

        protected GEPSurroundingsBase(IRegistry inputRegistry)
        {
            this.InputRegistry = inputRegistry;
        }
    }
}
