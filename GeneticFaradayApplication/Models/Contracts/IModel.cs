using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Repositories.Contracts;

namespace GeneticFaradayApplication.Models.Contracts
{
    public interface IModel<TModel> : IRepository<TModel> where TModel : IModel<TModel>
    {
        /// <summary>
        /// Sets the values of the IModel to their original values.
        /// </summary>
        void New();
    }
}
