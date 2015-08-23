using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaradayApplication.Models.Contracts.GeneticCodes.Functions
{
    public interface IFunctionsModel : IModel<IFunctionsModel>
    {
        List<IFunctionBaseIdentifier> AvailableFunctions { get; }
    }
}
