using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;

namespace GeneticFaradayApplication.Models.Contracts.GeneticCodes
{
    public interface IGeneticCodeEditorModel : IModel<IGeneticCodeEditorModel>
    {
        IGEPGeneticCodeUsingDatabase GeneticCode { get; }

    }
}
