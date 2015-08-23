using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.GEP.Models.Exceptions
{
    public class InvalidArgumentCount : Exception
    {
        public InvalidArgumentCount(string message = "Invalid Argument Count.") 
            : base(message: message)
        {
            
        }
    }
}
