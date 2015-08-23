using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Models.Exceptions
{
    public class GeneticCodeException : Exception
    {
        public GeneticCodeException(string message) : base(message)
        {
            
        }
    }
}
