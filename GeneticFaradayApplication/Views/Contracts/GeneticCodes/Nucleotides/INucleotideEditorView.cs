using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaradayApplication.Views.Contracts.GeneticCodes.Nucleotides
{
    public interface INucleotideEditorView : IView
    {
        string NucleotideIdentifier { get; set; }

        event EventHandler SaveRequested;
    }
}
