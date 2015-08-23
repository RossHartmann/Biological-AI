using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts;
using GeneticFaradayApplication.Views.Contracts;

namespace GeneticFaradayApplication.Presenters.Contracts
{
    public interface IPresenter<out TView, out TModel> where TView : IView where TModel : IModel<TModel>
    {
        /// <summary>
        /// The View that the IPresenter presents.
        /// </summary>
        TView View { get; }

        /// <summary>
        /// The IModel that this IPresenter manipulates.
        /// </summary>
        TModel Model { get; }

        /// <summary>
        /// Updates the values in the View to match the Model.
        /// </summary>
        void UpdateViewFromModel();

        void Show();

        void ShowDialog();
    }
}
