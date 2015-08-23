using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Repositories.Contracts;

namespace GeneticFaradayApplication.Repositories.AbstractRepositories
{
    public abstract class RepositoryArgsBase : IRepositoryArgs
    {
        /// <summary>
        /// The file name of the entity to load or save.
        /// </summary>
        public string FileName { get; protected set; }

        /// <summary>
        /// The unique identifier of the entity to load or save.
        /// </summary>
        public List<string> DatabaseIdentifiers { get; protected set; }

        /// <summary>
        /// The type of Repository
        /// </summary>
        public RepositoryType RepositoryType { get; protected set; }

        protected RepositoryArgsBase(RepositoryType repositoryType, string fileName, List<string> databaseIdentifiers)
        {
            this.RepositoryType = repositoryType;
            this.FileName = fileName;
            this.DatabaseIdentifiers = databaseIdentifiers;
        }
    }
}
