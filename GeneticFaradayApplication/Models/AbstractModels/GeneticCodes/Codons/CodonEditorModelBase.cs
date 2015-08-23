using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Repositories.Contracts;

namespace GeneticFaradayApplication.Models.AbstractModels.GeneticCodes.Codons
{
    public abstract class CodonEditorModelBase : ICodonEditorModel
    {
        public ICodonEditorModel Load(IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Save(ICodonEditorModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Delete(ICodonEditorModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            throw new NotImplementedException();
        }
    }
}
