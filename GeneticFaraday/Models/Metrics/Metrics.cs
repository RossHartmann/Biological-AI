using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Metrics;
using GeneticFaraday.Contracts.Metrics;

namespace GeneticFaraday.Models.Metrics
{
    public class Metrics : MetricsBase
    {
        public override IMetrics ShallowCopy()
        {
            var copy = new Metrics()
                           {
                               Value = this.Value.ShallowCopy()
                           };
            foreach(var metricsValuePair in this)
                copy.Add(metricsValuePair.Key, metricsValuePair.Value);
            return copy;
        }
    }
}
