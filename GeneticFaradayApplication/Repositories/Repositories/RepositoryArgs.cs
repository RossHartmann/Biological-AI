using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Repositories.AbstractRepositories;
using GeneticFaradayApplication.Repositories.Contracts;

namespace GeneticFaradayApplication.Repositories.Repositories
{
    public class RepositoryArgs : RepositoryArgsBase
    {
        public RepositoryArgs(RepositoryType repositoryType)
            : this(repositoryType, fileName: null, databaseIdentifiers: null)
        {
        }

        public RepositoryArgs(RepositoryType repositoryType, string fileName, List<string> databaseIdentifiers) 
            : base(repositoryType, fileName, databaseIdentifiers)
        {
        }
    }
}
