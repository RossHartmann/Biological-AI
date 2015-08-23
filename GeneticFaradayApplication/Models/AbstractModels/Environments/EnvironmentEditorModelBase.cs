using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.Environments;
using GeneticFaradayApplication.Repositories.Contracts;

namespace GeneticFaradayApplication.Models.AbstractModels.Environments
{
    public abstract class EnvironmentEditorModelBase : IEnvironmentEditorModel
    {
        public IEnvironmentEditorModel Load(IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Save(IEnvironmentEditorModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnvironmentEditorModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            throw new NotImplementedException();
        }
    }
}
