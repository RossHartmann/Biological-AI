using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.Environments;
using GeneticFaradayApplication.Views.Contracts.Environments;

namespace GeneticFaradayApplication.Presenters.Contracts.Environments
{
    public interface IEnvironmentEditorPresenter : IPresenter<IEnvironmentEditorView, IEnvironmentEditorModel>
    {
    }
}
