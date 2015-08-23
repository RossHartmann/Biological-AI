using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes;
using UtilityData.SQL;

namespace GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes
{
    public abstract class GeneticCodeSelectorPresenterBase : PresenterBase<IGeneticCodeSelectorView, IGeneticCodeSelectorModel>, IGeneticCodeSelectorPresenter
    {
        protected GeneticCodeSelectorPresenterBase(IGeneticCodeSelectorView view, IGeneticCodeSelectorModel model)
            : base(view: view, model: model)
        {
            this.View.AvailableGeneticCodeNames = this.Model.AvailableGeneticCodeNames;
            this.View.CloseRequested += View_CloseRequested;
            this.View.OKButtonClicked += View_OKButtonClicked;
        }

        void View_OKButtonClicked(object sender, EventArgs e)
        {
            this.View.Close();
        }

        void View_CloseRequested(object sender, EventArgs e)
        {
            this.View.Close();
        }

        public override void UpdateViewFromModel()
        {
            throw new NotImplementedException();
        }
    }
}
