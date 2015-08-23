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
using GeneticFaradayApplication.Views.Contracts.GeneticCodes;

namespace GeneticFaradayApplication.Presenters.Contracts.GeneticCodes
{
    public interface IGeneticCodeEditorPresenter : IPresenter<IGeneticCodeEditorView, IGeneticCodeEditorModel>
    {
        INucleotidesPresenter NucleotidesPresenter { get; }
        IFunctionsPresenter FunctionsPresenter { get; }
        ICodonsPresenter CodonsPresenter { get; }
        ICodonConvertersPresenter CodonConvertersPresenter { get; }
    }
}
