using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Metrics
{
    /// <summary>
    /// The Metrics used to measure the "value" of an IOrganism.
    /// </summary>
    public interface IMetrics : IShallowCopyable<IMetrics>, IMetricsValueCollection
    {
        /// <summary>
        /// Indicates how valuable the IOrganism is according to its other metrics.
        /// </summary>
        IMetricsValue Value { get; set; }
    }
}
