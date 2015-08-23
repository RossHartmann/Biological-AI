using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.AbstractModels.Registries
{
    public abstract class RegistryCollectionBase : List<IRegistry>, IRegistryCollection
    {
        protected RegistryCollectionBase() : base()
        {
            
        }
        protected RegistryCollectionBase(IEnumerable<IRegistry> registries) 
            : base(collection: registries)
        {

        }
    }
}
