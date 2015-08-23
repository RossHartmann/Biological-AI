using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Functions;

namespace GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Functions
{
    public interface IFunctionsPresenter : IPresenter<IFunctionsView, IFunctionsModel>
    {
    }
}
