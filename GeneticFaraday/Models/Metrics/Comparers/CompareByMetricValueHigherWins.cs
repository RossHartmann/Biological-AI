using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Metrics;
using GeneticFaraday.Contracts.Organisms;

namespace GeneticFaraday.Models.Metrics.Comparers
{
    /// <summary>
    /// Compares the specified IMetricValue of two IOrganisms. The higher value is greater.
    /// </summary>
    public class CompareByMetricValueHigherWins : IComparer<IOrganism>
    {
        public IMetricsValueIdentifier MetricsValueIdentifier { get; private set; }

        public CompareByMetricValueHigherWins(IMetricsValueIdentifier metricsValueIdentifier)
        {
            this.MetricsValueIdentifier = metricsValueIdentifier;
        }

        public int Compare(IOrganism x, IOrganism y)
        {
            if (x.Metrics[this.MetricsValueIdentifier].Value > y.Metrics[this.MetricsValueIdentifier].Value)
                return 1;
            else if (x.Metrics[this.MetricsValueIdentifier].Value < y.Metrics[this.MetricsValueIdentifier].Value)
                return -1;
            else
                return 0;
        }
    }
}
