using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Registries;

namespace Earth
{
    public class InputOutput
    {
        public IRegistry Input { get; set; }
        public double DesiredOutput { get; set; }

        public InputOutput(IRegistry input, double desiredOutput)
        {
            this.Input = input;
            this.DesiredOutput = desiredOutput;
        }
    }
}
