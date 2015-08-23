using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes.Functions;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Functions;

namespace GeneticFaradayApplication.Presenters.Presenters.GeneticCodes.Functions
{
    public class FunctionWeightPresenter : FunctionWeightPresenterBase
    {
        public FunctionWeightPresenter(IFunctionBaseIdentifier functionBaseIdentifier) 
            : base(functionBaseIdentifier)
        {
        }

        public FunctionWeightPresenter(IFunctionBaseIdentifier functionBaseIdentifier, 
            IFunctionWeightView view, IFunctionWeightModel model) 
            : base(functionBaseIdentifier, view, model)
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
