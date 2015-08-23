using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Nucleotides;

namespace GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Nucleotides
{
    public interface INucleotidesPresenter : IPresenter<INucleotidesView, INucleotidesModel>
    {
        string GeneticCodeName { get; }
    }
}
