using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes.Codons;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Codons;

namespace GeneticFaradayApplication.Presenters.Presenters.GeneticCodes.Codons
{
    public class CodonsPresenter : CodonsPresenterBase
    {
        public CodonsPresenter(string geneticCodeName) : base(geneticCodeName)
        {
        }

        public CodonsPresenter(string geneticCodeName, ICodonsView view, ICodonsModel model) 
            : base(geneticCodeName, view, model)
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
