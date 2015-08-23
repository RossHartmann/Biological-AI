using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Repositories.AbstractRepositories;
using GeneticFaradayApplication.Repositories.Contracts;

namespace GeneticFaradayApplication.Repositories.Repositories
{
    public class RepositoryEventArgs : RepositoryEventArgsBase
    {
        public RepositoryEventArgs(IRepositoryArgs arguments) 
            : base(arguments)
        {
        }
    }
}
