using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.Environments;
using GeneticFaradayApplication.Models.Models.Environments;
using GeneticFaradayApplication.Presenters.Contracts.Environments;
using GeneticFaradayApplication.Views.Contracts.Environments;
using GeneticFaradayApplication.Views.Views.Environments;

namespace GeneticFaradayApplication.Presenters.AbstractPresenters.Environments
{
    public abstract class EnvironmentEditorPresenterBase : PresenterBase<IEnvironmentEditorView, IEnvironmentEditorModel>, IEnvironmentEditorPresenter
    {
        protected EnvironmentEditorPresenterBase()
            : this(new EnvironmentEditorView(), new EnvironmentEditorModel())
        {
        }

        protected EnvironmentEditorPresenterBase(IEnvironmentEditorView view, IEnvironmentEditorModel model) 
            : base(view, model)
        {
        }
    }
}


