using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms;

namespace GeneticFaraday.Models.Metrics.Comparers
{
    /// <summary>
    /// Compares the Value of two IOrganisms. The lower value is greater.
    /// </summary>
    public class CompareByValueLowerWins : IComparer<IOrganism>
    {
        public int Compare(IOrganism x, IOrganism y)
        {
            if (x.Metrics.Value.Value < y.Metrics.Value.Value)
                return 1;
            else if (x.Metrics.Value.Value > y.Metrics.Value.Value)
                return -1;
            else
                return 0;
        }
    }

}
