using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaradayApplication.Models.AbstractModels.GeneticCodes;

namespace GeneticFaradayApplication.Models.Models.GeneticCodes
{
    public class GeneticCodeEditorModel : GeneticCodeEditorModelBase
    {
        public GeneticCodeEditorModel(int geneticCodePrimaryKey)
            : base(geneticCodePrimaryKey: geneticCodePrimaryKey)
        {
        }

        public GeneticCodeEditorModel(string geneticCodeName) : base(geneticCodeName)
        {
        }

        public GeneticCodeEditorModel(IGEPGeneticCodeUsingDatabase geneticCode) 
            : base(geneticCode)
        {
        }
    }
}