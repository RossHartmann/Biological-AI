using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Repositories.Contracts;

namespace GeneticFaradayApplication.Repositories.AbstractRepositories
{
    public abstract class RepositoryEventArgsBase : EventArgs, IRepositoryEventArgs
    {
        public IRepositoryArgs Arguments { get; protected set; }

        protected RepositoryEventArgsBase(IRepositoryArgs arguments)
        {
            this.Arguments = arguments;
        }
    }
}
