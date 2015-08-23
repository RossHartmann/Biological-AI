using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Environment.GeneticOperators.MutationOperators;
using GeneticFaraday.GEP.Contracts.Environment.GeneticOperators.MutationOperators;

namespace GeneticFaraday.GEP.AbstractModels.Environment.GeneticOperators.MutationOperators
{
    public abstract class GEPMutationOperatorBase : MutationOperatorBase, IGEPMutationOperator
    {
        protected GEPMutationOperatorBase(int chanceOfUseRating) 
            : base(chanceOfUseRating)
        {
        }
    }
}
