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
    public class CodonsCreatorPresenter : CodonsCreatorPresenterBase
    {
        public CodonsCreatorPresenter(string geneticCodeName) 
            : base(geneticCodeName)
        {
        }

        public CodonsCreatorPresenter(string geneticCodeName, 
            ICodonsCreatorView view, ICodonsCreatorModel model) 
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
