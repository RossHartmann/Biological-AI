using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Views.Views.GeneticCodes.Nucleotides;

namespace GeneticFaradayApplication.Presenters.Presenters.GeneticCodes.Nucleotides
{
    public class NucleotideEditorPresenter : NucleotideEditorPresenterBase
    {
        public NucleotideEditorPresenter(string geneticCodeName, bool editingExistingNucleotide)
            : base(geneticCodeName, editingExistingNucleotide: editingExistingNucleotide)
        {
        }

        public NucleotideEditorPresenter(INucleotideEditorModel model, string geneticCodeName,
            bool editingExistingNucleotide)
            : this(new NucleotideEditorView(), model, geneticCodeName, editingExistingNucleotide: editingExistingNucleotide)
        {
        }

        public NucleotideEditorPresenter(INucleotideEditorView view, INucleotideEditorModel model, string geneticCodeName, 
            bool editingExistingNucleotide)
            : base(view, model, geneticCodeName, editingExistingNucleotide: editingExistingNucleotide)
        {
        }

    }
}
