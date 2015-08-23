using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Models.Models.GeneticCodes.Functions;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Views.Views.GeneticCodes.Functions;

namespace GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes.Functions
{
    public abstract class FunctionsPresenterBase : PresenterBase<IFunctionsView, IFunctionsModel>, IFunctionsPresenter
    {
        protected FunctionsPresenterBase()
            : this(new FunctionsView(), new FunctionsModel())
        {
        }

        protected FunctionsPresenterBase(IFunctionsView view, IFunctionsModel model) 
            : base(view, model)
        {
            this.View.MoveToAvailableFunctionsRequested += View_MoveToAvailableFunctionsRequested;
            this.View.MoveToSelectedFunctionsRequested += View_MoveToSelectedFunctionsRequested;
            this.View.MoveAllToAvailableFunctionsRequested += View_MoveAllToAvailableFunctionsRequested;
            this.View.MoveAllToSelectedFunctionsRequested += View_MoveAllToSelectedFunctionsRequested;

            this.UpdateViewFromModel();
        }

        public override void UpdateViewFromModel()
        {
            this.View.AvailableFunctions = this.Model.AvailableFunctions.ToArray();
        }

        void View_MoveAllToSelectedFunctionsRequested(object sender, EventArgs e)
        {
            var availableFunctionsToMove = this.View.AvailableFunctions;
            foreach(var function in availableFunctionsToMove)
                this.View.AddToSelectedFunctions(function);

            this.View.AvailableFunctions = new IFunctionBaseIdentifier[] { };
        }

        void View_MoveAllToAvailableFunctionsRequested(object sender, EventArgs e)
        {
            var selectedFunctionsToMove = this.View.SelectedFunctions;
            foreach (var function in selectedFunctionsToMove)
                this.View.AddToAvailableFunctions(function);

            this.View.SelectedFunctions = new IFunctionBaseIdentifier[] { };
        }

        void View_MoveToSelectedFunctionsRequested(object sender, Utilities.EventArgsWithModel<IFunctionBaseIdentifier> e)
        {
            this.View.AddToSelectedFunctions(e.Model);
            this.View.RemoveFromAvailableFunctions(e.Model);
        }

        void View_MoveToAvailableFunctionsRequested(object sender, Utilities.EventArgsWithModel<IFunctionBaseIdentifier> e)
        {
            this.View.AddToAvailableFunctions(e.Model);
            this.View.RemoveFromSelectedFunctions(e.Model);
        }
    }
}
