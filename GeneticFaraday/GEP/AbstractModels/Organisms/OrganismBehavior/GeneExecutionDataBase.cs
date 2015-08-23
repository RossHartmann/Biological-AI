using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.OrganismBehavior
{
    public abstract class GeneExecutionDataBase : IGeneExecutionData
    {
        public int RecursionLevel { get; set; }

        protected GeneExecutionDataBase()
        {
            this.RecursionLevel = 0;
        }
    }
}
