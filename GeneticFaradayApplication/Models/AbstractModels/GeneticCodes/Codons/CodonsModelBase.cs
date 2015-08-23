using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.Models.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.Models.Organisms.GeneticCodes.Codons.CodonConverters.CodonNumberConverters;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Repositories.Contracts;
using UtilityData.Exceptions.DatabaseExceptions;

namespace GeneticFaradayApplication.Models.AbstractModels.GeneticCodes.Codons
{
    public abstract class CodonsModelBase : ICodonsModel
    {
        

        public ICodonsModel Load(IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Save(ICodonsModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Delete(ICodonsModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            throw new NotImplementedException();
        }
    }
}
