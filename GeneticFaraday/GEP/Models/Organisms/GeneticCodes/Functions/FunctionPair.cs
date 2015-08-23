using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;

namespace GeneticFaraday.GEP.Models.Organisms.GeneticCodes.Functions
{
    public class FunctionPair : FunctionPairBase
    {
        public FunctionPair(IGEPGeneticCode geneticCode, IFunctionIdentifier primaryFunction, 
            IFunctionIdentifier parameterlessFunction) 
            : base(geneticCode, primaryFunction, parameterlessFunction)
        {
        }

        public override string ToString()
        {
            return "{ " + this.PrimaryFunction.ToString() + ", " + this.ParameterlessFunction + " }";
        }
    }
}
