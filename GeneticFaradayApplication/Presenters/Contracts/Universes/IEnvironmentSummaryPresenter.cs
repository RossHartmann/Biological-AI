using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.Universes;
using GeneticFaradayApplication.Views.Contracts.Universes;

namespace GeneticFaradayApplication.Presenters.Contracts.Universes
{
    public interface IEnvironmentSummaryPresenter : IPresenter<IEnvironmentSummaryView, IEnvironmentSummaryModel>
    {
    }
}
