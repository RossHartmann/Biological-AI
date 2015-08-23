using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Models.Models.GeneticCodes.Functions;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Views.Views.GeneticCodes.Functions;

namespace GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes.Functions
{
    public abstract class FunctionWeightPresenterBase : PresenterBase<IFunctionWeightView, IFunctionWeightModel>, IFunctionWeightPresenter
    {
        public IFunctionBaseIdentifier FunctionBaseIdentifier
        {
            get { return this.View.FunctionBaseIdentifier; } 
            set { this.View.FunctionBaseIdentifier = value; }
        }

        protected FunctionWeightPresenterBase(IFunctionBaseIdentifier functionBaseIdentifier)
            : this(functionBaseIdentifier, new FunctionWeightView(), new FunctionWeightModel())
        {
        }

        protected FunctionWeightPresenterBase(IFunctionBaseIdentifier functionBaseIdentifier, IFunctionWeightView view, IFunctionWeightModel model) 
            : base(view, model)
        {
            this.View.WeightInGeneticCode = functionBaseIdentifier.WeightInGeneticCode;
            this.View.SetFunctionName(functionBaseIdentifier.ToString());
            this.View.FunctionBaseIdentifier = functionBaseIdentifier;
        }
    }
}
