using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Functions;

namespace GeneticFaradayApplication.Views.Contracts.GeneticCodes.Functions
{
    public interface IFunctionWeightView : IView
    {
        double WeightInGeneticCode { get; set; }
        void SetFunctionName(string functionName);

        IFunctionBaseIdentifier FunctionBaseIdentifier { get; set; }
    }
}
