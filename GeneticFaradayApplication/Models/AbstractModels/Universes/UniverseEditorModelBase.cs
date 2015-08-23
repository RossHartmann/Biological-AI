using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.Universes;
using GeneticFaradayApplication.Repositories.Contracts;

namespace GeneticFaradayApplication.Models.AbstractModels.Universes
{
    public abstract class UniverseEditorModelBase : IUniverseEditorModel
    {
        public IUniverseEditorModel Load(IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Save(IUniverseEditorModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Delete(IUniverseEditorModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            throw new NotImplementedException();
        }
    }
}
