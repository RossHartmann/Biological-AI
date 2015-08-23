using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes;
using GeneticFaradayApplication.Repositories.Contracts;

namespace GeneticFaradayApplication.Models.AbstractModels.GeneticCodes
{
    public abstract class GeneticCodeCreatorModelBase : IGeneticCodeCreatorModel
    {
        public IGeneticCodeCreatorModel Load(IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Save(IGeneticCodeCreatorModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Delete(IGeneticCodeCreatorModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The Primary Key of the GeneticCode that was created.
        /// </summary>
        public int? GeneticCodePrimaryKey { get; set; }
    }
}
