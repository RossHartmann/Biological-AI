using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Utilities;

namespace GeneticFaradayApplication.Views.Contracts.GeneticCodes.Nucleotides
{
    public interface INucleotidesView : IView
    {
        INucleotideEditorModel[] Nucleotides { get; set; }

        void AddNucleotide(INucleotideEditorModel nucleotide);
        void RemoveNucleotide(INucleotideEditorModel nucleotide);

        void ClearNucleotides();

        event EventHandler AddNucleotideRequested;
        event EventHandler<EventArgsWithModel<INucleotideEditorModel>> RemoveNucleotideRequested;
        event EventHandler ClearNucleotidesRequested;

        event EventHandler<EventArgsWithModel<INucleotideEditorModel>> ViewNucleotideRequested;
    }
}
