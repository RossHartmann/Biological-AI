using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Presenters.Contracts.Universes;

namespace GeneticFaradayApplication.Views.Contracts.Universes
{
    public interface IUniverseEditorView : IView
    {
        void AddEnvironment(IEnvironmentSummaryPresenter environmentSummaryPresenter, string title);

        event EventHandler AddEnvironmentRequested;
    }
}
