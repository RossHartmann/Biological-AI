using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Codons;

namespace GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Codons
{
    public interface ICodonsPresenter : IPresenter<ICodonsView, ICodonsModel>
    {
        /// <summary>
        /// The unique name of the genetic code.
        /// </summary>
        string GeneticCodeName { get; set; }
    }
}
