using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Nucleotides;

namespace GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Nucleotides
{
    public interface INucleotideEditorPresenter : IPresenter<INucleotideEditorView, INucleotideEditorModel>
    {
        string GeneticCodeName { get; }

        /// <summary>
        /// If true, the Nucleotide was saved. If false, an early exit occurred.
        /// </summary>
        bool SavedSuccessfully { get; }

        /// <summary>
        /// If true, we are editing an existing nucleotide.
        /// If false, we are creating a new nucleotide.
        /// </summary>
        bool EditingExistingNucleotide { get; }
    }
}
