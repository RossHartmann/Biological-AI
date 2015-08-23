using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaradayApplication.Views.Contracts.GeneticCodes
{
    public interface IGeneticCodeSelectorView : IView
    {
        /// <summary>
        /// The name of the selected Genetic Code.
        /// </summary>
        string SelectedGeneticCodeName { get; set; }

        /// <summary>
        /// The names of the Genetic Codes from which the user can select.
        /// </summary>
        string[] AvailableGeneticCodeNames { get; set; }

        event EventHandler OKButtonClicked;
    }
}
