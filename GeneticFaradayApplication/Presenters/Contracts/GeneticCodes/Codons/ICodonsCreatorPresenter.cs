using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Codons;

namespace GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Codons
{
    public interface ICodonsCreatorPresenter : IPresenter<ICodonsCreatorView, ICodonsCreatorModel>
    {
        /// <summary>
        /// The functions for which the Codons will encode.
        /// </summary>
        List<IFunction> Functions { get; set; }

        /// <summary>
        /// The unique name of the genetic code.
        /// </summary>
        string GeneticCodeName { get; set; }
    }
}
