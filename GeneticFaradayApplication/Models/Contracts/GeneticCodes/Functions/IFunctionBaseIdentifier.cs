using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaradayApplication.Models.Contracts.GeneticCodes.Functions
{
    public interface IFunctionBaseIdentifier : IModel<IFunctionBaseIdentifier>
    {
        string Identifier { get; set; }
        string AreaOfInterest { get; set; }
        double WeightInGeneticCode { get; set; }
    }
}
