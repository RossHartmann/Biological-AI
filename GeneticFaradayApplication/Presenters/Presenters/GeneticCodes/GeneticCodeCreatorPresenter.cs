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
    public class GeneticCodeCreatorPresenter : GeneticCodeCreatorPresenterBase
    {
        public GeneticCodeCreatorPresenter() : this(new GeneticCodeCreatorView(), new GeneticCodeCreatorModel())
        {
            
        }

        public GeneticCodeCreatorPresenter(IGeneticCodeCreatorView view, IGeneticCodeCreatorModel model) 
            : base(view, model)
        {
        }

        public override void UpdateModelFromView()
        {
            throw new NotImplementedException();
        }
    }
}
