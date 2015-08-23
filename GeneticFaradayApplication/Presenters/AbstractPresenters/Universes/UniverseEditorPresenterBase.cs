using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.Universes;
using GeneticFaradayApplication.Models.Models.Universes;
using GeneticFaradayApplication.Presenters.Contracts.Universes;
using GeneticFaradayApplication.Presenters.Presenters.Universes;
using GeneticFaradayApplication.Views.Contracts.Universes;
using GeneticFaradayApplication.Views.Views.Universes;

namespace GeneticFaradayApplication.Presenters.AbstractPresenters.Universes
{
    public abstract class UniverseEditorPresenterBase : PresenterBase<IUniverseEditorView, IUniverseEditorModel>, IUniverseEditorPresenter
    {
        public IUniverseEditorModel Model { get; private set; }

        private int NextElementIndex { get; set; }

        protected UniverseEditorPresenterBase() 
            : this(new UniverseEditorView(), new UniverseEditorModel())
        {
        }

        protected UniverseEditorPresenterBase(IUniverseEditorView view, IUniverseEditorModel model) 
            : base(view, model)
        {
            this.View.AddEnvironmentRequested += View_AddEnvironmentRequested;

            this.View_AddEnvironmentRequested(null, new EventArgs());
        }

        void View_AddEnvironmentRequested(object sender, EventArgs e)
        {
            var presenter = new EnvironmentSummaryPresenter();
            this.View.AddEnvironment(presenter, "Environment " + this.NextElementIndex++);
        }
        
    }
}
