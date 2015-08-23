using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Repositories.Contracts;

namespace GeneticFaradayApplication.Models.AbstractModels.GeneticCodes.Codons
{
    public abstract class CodonsCreatorModelBase : ICodonsCreatorModel
    {
        public ICodonsCreatorModel Load(IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Save(ICodonsCreatorModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Delete(ICodonsCreatorModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            throw new NotImplementedException();
        }
    }
}
