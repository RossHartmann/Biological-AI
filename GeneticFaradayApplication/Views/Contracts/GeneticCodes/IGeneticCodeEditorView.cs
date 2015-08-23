using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.CodonConverters;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Repositories.Contracts;

namespace GeneticFaradayApplication.Views.Contracts.GeneticCodes
{
    public interface IGeneticCodeEditorView : IView, IBasicGeneticCodeInfoView
    {
        INucleotidesPresenter NucleotidesPresenter { get; }
        ICodonsPresenter CodonsPresenter { get; }
        

        #region Events

        /// <summary>
        /// Occurs when a new Genetic Code is requested.
        /// </summary>
        event EventHandler NewGeneticCode;

        /// <summary>
        /// Occurs when a new Genetic Code is requested.
        /// </summary>
        event EventHandler LoadGeneticCode;

        /// <summary>
        /// Occurs when a Genetic Code is saved.
        /// </summary>
        event EventHandler SaveGeneticCode;

        #endregion
    }
}