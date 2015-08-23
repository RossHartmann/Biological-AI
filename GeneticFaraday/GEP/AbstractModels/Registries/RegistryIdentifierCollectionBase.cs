using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.AbstractModels.Registries
{
    public abstract class RegistryIdentifierCollectionBase : List<IRegistryIdentifier>, IRegistryIdentifierCollection
    {
        protected RegistryIdentifierCollectionBase() : base()
        {
            
        }
        protected RegistryIdentifierCollectionBase(IEnumerable<IRegistryIdentifier> registries) 
            : base(collection: registries)
        {

        }
    }
}
