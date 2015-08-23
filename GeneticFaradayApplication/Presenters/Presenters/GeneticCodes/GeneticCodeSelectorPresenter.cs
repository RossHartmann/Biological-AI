using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes;
using GeneticFaradayApplication.Models.Models.GeneticCodes;
using GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes;
using GeneticFaradayApplication.Views.Views.GeneticCodes;

namespace GeneticFaradayApplication.Presenters.Presenters.GeneticCodes
{
    public class GeneticCodeSelectorPresenter : GeneticCodeSelectorPresenterBase
    {
        public GeneticCodeSelectorPresenter() 
            : base(new GeneticCodeSelectorView(), new GeneticCodeSelectorModel())
        {
        }

        public override void UpdateModelFromView()
        {
            throw new NotImplementedException();
        }
    }
}
