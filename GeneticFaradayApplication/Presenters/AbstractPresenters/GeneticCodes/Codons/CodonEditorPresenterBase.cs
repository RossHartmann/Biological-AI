using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Models.Models.GeneticCodes.Codons;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Views.Views.GeneticCodes.Codons;

namespace GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes.Codons
{
    public abstract class CodonEditorPresenterBase : PresenterBase<ICodonEditorView, ICodonEditorModel>, ICodonEditorPresenter
    {
        protected CodonEditorPresenterBase()
            : this(new CodonEditorView(), new CodonEditorModel())
        {
        }

        protected CodonEditorPresenterBase(ICodonEditorView view, ICodonEditorModel model) 
            : base(view, model)
        {
        }
    }
}

