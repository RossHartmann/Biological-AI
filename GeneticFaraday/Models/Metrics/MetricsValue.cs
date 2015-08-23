using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Metrics;
using GeneticFaraday.Contracts.Metrics;

namespace GeneticFaraday.Models.Metrics
{
    public class MetricsValue : MetricsValueBase
    {
        public override IMetricsValue ShallowCopy()
        {
            return new MetricsValue()
                       {
                           Value = this.Value,
                           Proportion = this.Proportion,
                           ProportionSumInPopulation = this.ProportionSumInPopulation
                       };
        }
    }
}
