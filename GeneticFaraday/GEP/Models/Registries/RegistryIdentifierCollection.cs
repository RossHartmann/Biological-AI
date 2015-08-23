using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Registries;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Models.Registries
{
    public class RegistryIdentifierCollection : RegistryIdentifierCollectionBase
    {
        public RegistryIdentifierCollection() : base()
        {
            
        }

        public RegistryIdentifierCollection(IEnumerable<IRegistryIdentifier> registries)
            : base(registries: registries)
        {

        }
    }
}
