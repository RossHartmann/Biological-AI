using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.Universes;
using GeneticFaradayApplication.Repositories.Contracts;

namespace GeneticFaradayApplication.Models.AbstractModels.Universes
{
    public abstract class EnvironmentSummaryModelBase : IEnvironmentSummaryModel
    {
        public IEnvironmentSummaryModel Load(IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Save(IEnvironmentSummaryModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnvironmentSummaryModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            throw new NotImplementedException();
        }
    }
}
