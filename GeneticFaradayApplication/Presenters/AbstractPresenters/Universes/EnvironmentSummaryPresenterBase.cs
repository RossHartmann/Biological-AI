using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.Universes;
using GeneticFaradayApplication.Models.Models.Universes;
using GeneticFaradayApplication.Presenters.Contracts.Universes;
using GeneticFaradayApplication.Presenters.Presenters.Environments;
using GeneticFaradayApplication.Views.Contracts.Universes;
using GeneticFaradayApplication.Views.Views.Universes;

namespace GeneticFaradayApplication.Presenters.AbstractPresenters.Universes
{
    public abstract class EnvironmentSummaryPresenterBase : PresenterBase<IEnvironmentSummaryView, IEnvironmentSummaryModel>, IEnvironmentSummaryPresenter
    {
        protected EnvironmentSummaryPresenterBase()
            : this(new EnvironmentSummaryView(), new EnvironmentSummaryModel())
        {
        }

        protected EnvironmentSummaryPresenterBase(IEnvironmentSummaryView view, IEnvironmentSummaryModel model) 
            : base(view, model)
        {
            this.View.EditEnvironmentRequested += View_EditEnvironmentRequested;
        }

        void View_EditEnvironmentRequested(object sender, EventArgs e)
        {
            var environmentEditorPresenter = new EnvironmentEditorPresenter();
            environmentEditorPresenter.ShowDialog();
        }

    }
}
