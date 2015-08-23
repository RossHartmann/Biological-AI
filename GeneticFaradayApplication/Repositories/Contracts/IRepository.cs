using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts;

namespace GeneticFaradayApplication.Repositories.Contracts
{
    public interface IRepository<TModel> where TModel : IModel<TModel>
    {
        /// <summary>
        /// Loads an IModel according to the specified arguments and returns
        /// the loaded IModel.
        /// </summary>
        /// <param name="args"></param>
        /// <returns>The loaded IModel.</returns>
        TModel Load(IRepositoryArgs args);

        /// <summary>
        /// Saves an IModel according to the specified arguments.
        /// </summary>
        /// <param name="model">The IModel to save.</param>
        /// <param name="args"></param>
        void Save(TModel model, IRepositoryArgs args);

        /// <summary>
        /// Deletes the specified IModel
        /// </summary>
        /// <param name="model"></param>
        /// <param name="args"></param>
        void Delete(TModel model, IRepositoryArgs args);
    }
}
