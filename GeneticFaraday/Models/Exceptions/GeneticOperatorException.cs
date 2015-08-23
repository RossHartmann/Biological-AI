using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Models.Exceptions
{
    public class GeneticOperatorException : Exception
    {
        public GeneticOperatorException(string message) 
            : base(message: message)
        {
            
        }
    }
}
