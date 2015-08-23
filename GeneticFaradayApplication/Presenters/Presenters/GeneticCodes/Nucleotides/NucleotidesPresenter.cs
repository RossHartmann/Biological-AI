using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Nucleotides;

namespace GeneticFaradayApplication.Presenters.Presenters.GeneticCodes.Nucleotides
{
    public class NucleotidesPresenter : NucleotidesPresenterBase
    {
        public NucleotidesPresenter(string geneticCodeName) : base(geneticCodeName)
        {
        }

        public NucleotidesPresenter(INucleotidesView view, INucleotidesModel model, string geneticCodeName) 
            : base(view, model, geneticCodeName)
        {
        }

        public override void UpdateViewFromModel()
        {
            throw new NotImplementedException();
        }

        public override void UpdateModelFromView()
        {
            throw new NotImplementedException();
        }
    }
}
