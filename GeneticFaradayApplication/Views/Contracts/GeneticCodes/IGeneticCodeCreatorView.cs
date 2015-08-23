using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaradayApplication.Views.Contracts.GeneticCodes
{
    public interface IGeneticCodeCreatorView : IView, IBasicGeneticCodeInfoView
    {
        event EventHandler OKButtonClicked;
    }
}
