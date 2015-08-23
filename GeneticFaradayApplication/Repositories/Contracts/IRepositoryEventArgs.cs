using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaradayApplication.Repositories.Contracts
{
    public interface IRepositoryEventArgs
    {
        IRepositoryArgs Arguments { get; }
    }
}
