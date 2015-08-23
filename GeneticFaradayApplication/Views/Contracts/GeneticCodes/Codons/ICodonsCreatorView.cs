using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.CodonConverters;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Functions;

namespace GeneticFaradayApplication.Views.Contracts.GeneticCodes.Codons
{
    public interface ICodonsCreatorView : IView
    {
        double StopCodonPercentage { get; set; }
        int RedundancyRating { get; set; }

        double MaxCodonCount { get; set; }
        double CurrentCodonsCreated { get; set; }

        IFunctionsPresenter FunctionsPresenter { get; }
        ICodonConvertersPresenter CodonConvertersPresenter { get; }

        /// <summary>
        /// The functions for which the Codons will encode.
        /// </summary>
        List<IFunction> Functions { get; set; }

        event EventHandler FunctionsCreated;

        void DisableControls();
    }
}
