using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaradayApplication.Repositories.Contracts
{
    public interface IRepositoryArgs
    {
        /// <summary>
        /// The file name of the entity to load or save.
        /// </summary>
        string FileName { get; }

        /// <summary>
        /// The unique identifiers of the entity to load or save.
        /// </summary>
        List<string> DatabaseIdentifiers { get; }

        /// <summary>
        /// The type of Repository
        /// </summary>
        RepositoryType RepositoryType { get; }
    }
}
