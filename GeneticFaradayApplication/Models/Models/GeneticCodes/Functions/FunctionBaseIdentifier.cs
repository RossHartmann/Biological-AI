using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.AbstractModels.GeneticCodes.Functions;

namespace GeneticFaradayApplication.Models.Models.GeneticCodes.Functions
{
    public class FunctionBaseIdentifier : FunctionBaseIdentifierBase
    {
        public FunctionBaseIdentifier(string identifier, string areaOfInterest, double weightInGeneticCode = 1)
            : base(identifier, areaOfInterest: areaOfInterest, weightInGeneticCode: weightInGeneticCode)
        {
        }
    }
}
