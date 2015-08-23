using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes;

namespace GeneticFaradayApplication.Presenters.Contracts.GeneticCodes
{
    public interface IGeneticCodeCreatorPresenter : IPresenter<IGeneticCodeCreatorView, IGeneticCodeCreatorModel>
    {
    }
}
