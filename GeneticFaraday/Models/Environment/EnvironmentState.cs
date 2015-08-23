using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Environment;

namespace GeneticFaraday.Models.Environment
{
    public class EnvironmentState : EnvironmentStateBase
    {
        public EnvironmentState(int populationSize, int eliteCount) 
            : base(populationSize, eliteCount)
        {
        }
    }
}
