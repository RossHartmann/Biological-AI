using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.CodonConverters;
using GeneticFaradayApplication.Models.Models.GeneticCodes.CodonConverters;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.CodonConverters;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.CodonConverters;
using GeneticFaradayApplication.Views.Views.GeneticCodes.CodonConverters;

namespace GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes.CodonConverters
{
    public abstract class CodonConvertersPresenterBase : PresenterBase<ICodonConvertersView, ICodonConvertersModel>, ICodonConvertersPresenter
    {
        protected CodonConvertersPresenterBase()
            : this(new CodonConvertersView(), new CodonConvertersModel())
        {
        }

        protected CodonConvertersPresenterBase(ICodonConvertersView view, ICodonConvertersModel model) 
            : base(view, model)
        {
            this.View.MoveToAvailableCodonConvertersRequested += View_MoveToAvailableCodonConvertersRequested;
            this.View.MoveToSelectedCodonConvertersRequested += View_MoveToSelectedCodonConvertersRequested;
            this.View.MoveAllToAvailableCodonConvertersRequested += View_MoveAllToAvailableCodonConvertersRequested;
            this.View.MoveAllToSelectedCodonConvertersRequested += View_MoveAllToSelectedCodonConvertersRequested;

            this.UpdateViewFromModel();
        }


        public override void UpdateViewFromModel()
        {
            this.View.AvailableCodonConverters = this.Model.AvailableCodonConverters.ToArray();
        }

        void View_MoveAllToSelectedCodonConvertersRequested(object sender, EventArgs e)
        {
            var availableCodonConvertersToMove = this.View.AvailableCodonConverters;
            foreach (var function in availableCodonConvertersToMove)
                this.View.AddToSelectedCodonConverters(function);

            this.View.AvailableCodonConverters = new ICodonConverterIdentifier[] { };
        }

        void View_MoveAllToAvailableCodonConvertersRequested(object sender, EventArgs e)
        {
            var selectedFunctionsToMove = this.View.SelectedCodonConverters;
            foreach (var function in selectedFunctionsToMove)
                this.View.AddToAvailableCodonConverters(function);

            this.View.SelectedCodonConverters = new ICodonConverterIdentifier[] { };
        }

        void View_MoveToSelectedCodonConvertersRequested(object sender, Utilities.EventArgsWithModel<ICodonConverterIdentifier> e)
        {
            this.View.AddToSelectedCodonConverters(e.Model);
            this.View.RemoveFromAvailableCodonConverters(e.Model);
        }

        void View_MoveToAvailableCodonConvertersRequested(object sender, Utilities.EventArgsWithModel<ICodonConverterIdentifier> e)
        {
            this.View.AddToAvailableCodonConverters(e.Model);
            this.View.RemoveFromSelectedCodonConverters(e.Model);
        }
    }
}
