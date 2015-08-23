using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts;
using GeneticFaradayApplication.Presenters.Contracts;
using GeneticFaradayApplication.Views.Contracts;

namespace GeneticFaradayApplication.Presenters.AbstractPresenters
{
    public abstract class PresenterBase<TView, TModel> : IPresenter<TView, TModel> where TView : IView where TModel : IModel<TModel>
    {
        public TView View { get; protected set; }
        public TModel Model { get; protected set; }

        protected PresenterBase(TView view, TModel model)
        {
            this.View = view;
            this.Model = model;
        }

        public abstract void UpdateViewFromModel();

        public abstract void UpdateModelFromView();

        public void Show()
        {
            this.View.Show();
        }

        public void ShowDialog()
        {
            this.View.ShowDialog();
        }
    }
}
