using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Metrics;
using GeneticFaraday.Contracts.Organisms;

namespace GeneticFaraday.Models.Metrics.MetricsEvaluators
{
    /// <summary>
    /// Gets the IMetrics of the IOrganism.
    /// 
    /// No need to call any events in this delegate.
    /// </summary>
    /// <returns></returns>
    public delegate IMetrics GetMetrics(IOrganism organism);
}
