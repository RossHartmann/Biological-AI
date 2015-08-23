using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Repositories.Contracts;

namespace GeneticFaradayApplication.Models.AbstractModels.GeneticCodes.Functions
{
    public abstract class FunctionWeightModelBase : IFunctionWeightModel
    {
        public IFunctionWeightModel Load(IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Save(IFunctionWeightModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Delete(IFunctionWeightModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            throw new NotImplementedException();
        }
    }
}
