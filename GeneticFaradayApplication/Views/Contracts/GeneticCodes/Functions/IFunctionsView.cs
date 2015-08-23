using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Utilities;

namespace GeneticFaradayApplication.Views.Contracts.GeneticCodes.Functions
{
    public interface IFunctionsView : IView
    {
        IFunctionBaseIdentifier[] AvailableFunctions { get; set; }
        IFunctionBaseIdentifier[] SelectedFunctions { get; set; }

        void AddToAvailableFunctions(IFunctionBaseIdentifier function);
        void AddToSelectedFunctions(IFunctionBaseIdentifier function);

        void RemoveFromAvailableFunctions(IFunctionBaseIdentifier function);
        void RemoveFromSelectedFunctions(IFunctionBaseIdentifier function);


        event EventHandler<EventArgsWithModel<IFunctionBaseIdentifier>> MoveToAvailableFunctionsRequested;
        event EventHandler<EventArgsWithModel<IFunctionBaseIdentifier>> MoveToSelectedFunctionsRequested;

        event EventHandler MoveAllToAvailableFunctionsRequested;
        event EventHandler MoveAllToSelectedFunctionsRequested;
    }
}
