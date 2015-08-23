using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.GEP.Models.Exceptions
{
    public class RegistryException :Exception
    {
        public RegistryException(string message) 
            : base(message)
        {
            
        }
    }
}
