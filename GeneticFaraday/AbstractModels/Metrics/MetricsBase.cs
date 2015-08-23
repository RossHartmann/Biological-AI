using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Metrics;

namespace GeneticFaraday.AbstractModels.Metrics
{
    public abstract class MetricsBase : Dictionary<IMetricsValueIdentifier, IMetricsValue>, IMetrics
    {
        public abstract IMetrics ShallowCopy();
        
        /// <summary>
        /// Indicates how valuable the IOrganism is according to its other metrics.
        /// </summary>
        public IMetricsValue Value { get; set; }
    }
}
