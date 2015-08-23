using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Registries;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Models.Registries
{
    public class RegistryCollection : RegistryCollectionBase
    {
        public RegistryCollection() : base()
        {
            
        }

        public RegistryCollection(IEnumerable<IRegistry> registries)
            : base(registries: registries)
        {

        }
    }
}
