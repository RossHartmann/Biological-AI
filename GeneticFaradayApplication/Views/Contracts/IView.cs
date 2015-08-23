using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaradayApplication.Views.Contracts
{
    public interface IView
    {
        void Close();
        void Show();
        void ShowDialog();

        void ShowError(string message, string title);

        /// <summary>
        /// Occurs when the user requests to close the View.
        /// </summary>
        event EventHandler CloseRequested;
    }
}
