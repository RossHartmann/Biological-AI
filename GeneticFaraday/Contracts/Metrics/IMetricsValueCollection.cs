using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Metrics
{
    public interface IMetricsValueCollection : IDictionary<IMetricsValueIdentifier, IMetricsValue>
    {
    }
}
