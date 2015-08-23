using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Models.AbstractModels.GeneticCodes.Nucleotides;

namespace GeneticFaradayApplication.Models.Models.GeneticCodes.Nucleotides
{
    public class NucleotideEditorModel : NucleotideEditorModelBase
    {
        public NucleotideEditorModel() : base()
        {
            
        }

        public NucleotideEditorModel(INucleotide nucleotide, string geneticCodeName, int? geneticCodePrimaryKey)
            : base(nucleotide: nucleotide, geneticCodeName: geneticCodeName, geneticCodePrimaryKey: geneticCodePrimaryKey)
        {
        }

        
    }
}
