using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.CodonConverters;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.CodonConverters;

namespace GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.CodonConverters
{
    public interface ICodonConvertersPresenter : IPresenter<ICodonConvertersView, ICodonConvertersModel>
    {
    }
}
