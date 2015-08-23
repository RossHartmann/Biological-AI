using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes;
using GeneticFaradayApplication.Models.Models.GeneticCodes;
using GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes;
using GeneticFaradayApplication.Presenters.Presenters.GeneticCodes.CodonConverters;
using GeneticFaradayApplication.Presenters.Presenters.GeneticCodes.Codons;
using GeneticFaradayApplication.Presenters.Presenters.GeneticCodes.Functions;
using GeneticFaradayApplication.Presenters.Presenters.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes;
using GeneticFaradayApplication.Views.Views.GeneticCodes;

namespace GeneticFaradayApplication.Presenters.Presenters.GeneticCodes
{
    public class GeneticCodeEditorPresenter : GeneticCodeEditorPresenterBase
    {
        public GeneticCodeEditorPresenter(IGeneticCodeEditorModel model)
            : this(new GeneticCodeEditorView(new NucleotidesPresenter(model.GeneticCode.Name), new CodonsPresenter(model.GeneticCode.Name)),
                model)
        {
        }

        public GeneticCodeEditorPresenter() : this(new GeneticCodeEditorModel(geneticCodeName:null))
        {
            
        }

        public GeneticCodeEditorPresenter(IGeneticCodeEditorView view, IGeneticCodeEditorModel model) 
            : base(view, model)
        {
        }

        public override void UpdateModelFromView()
        {
            throw new NotImplementedException();
        }
    }
}
