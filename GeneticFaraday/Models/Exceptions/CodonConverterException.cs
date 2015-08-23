using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Models.Exceptions
{
    public class CodonConverterException : Exception
    {
        public CodonConverterException(string message) : base(message: message)
        {
            
        }
    }
}
