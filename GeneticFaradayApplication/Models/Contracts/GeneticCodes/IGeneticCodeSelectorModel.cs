using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaradayApplication.Models.Contracts.GeneticCodes
{
    public interface IGeneticCodeSelectorModel : IModel<IGeneticCodeSelectorModel>
    {
        /// <summary>
        /// The names of the Genetic Codes from which the user can select.
        /// </summary>
        string[] AvailableGeneticCodeNames { get; }
    }
}
