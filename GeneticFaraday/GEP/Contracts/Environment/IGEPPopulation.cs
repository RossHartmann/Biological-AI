using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms;

namespace GeneticFaraday.GEP.Contracts.Environment
{
    public interface IGEPPopulation : IPopulation, IList<IGEPOrganism>
    {
        new IGEPEnvironment ParentIEnvironment { get; }
    }
}
