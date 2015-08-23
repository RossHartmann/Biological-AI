using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Environment.GeneticOperators.SelectionOperators;
using GeneticFaraday.GEP.Contracts.Environment.GeneticOperators.SelectionOperators;

namespace GeneticFaraday.GEP.AbstractModels.Environment.GeneticOperators.SelectionOperators
{
    public abstract class GEPSelectionOperatorBase : SelectionOperatorBase, IGEPSelectionOperator
    {
        protected GEPSelectionOperatorBase(int chanceOfUseRating) 
            : base(chanceOfUseRating)
        {
        }
    }
}
