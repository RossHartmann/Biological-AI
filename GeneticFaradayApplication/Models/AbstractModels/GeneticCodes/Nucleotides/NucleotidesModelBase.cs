using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Repositories.Contracts;

namespace GeneticFaradayApplication.Models.AbstractModels.GeneticCodes.Nucleotides
{
    public abstract class NucleotidesModelBase : INucleotidesModel
    {
        public INucleotidesModel Load(IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Save(INucleotidesModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Delete(INucleotidesModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            throw new NotImplementedException();
        }
    }
}
