using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaradayApplication.Views.Contracts.Universes
{
    public interface IEnvironmentSummaryView : IView
    {
        event EventHandler EditEnvironmentRequested;
    }
}
