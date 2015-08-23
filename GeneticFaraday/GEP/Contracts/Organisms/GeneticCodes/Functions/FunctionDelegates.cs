using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions
{
    public delegate IAminoAcidResult FunctionExecute(IFunctionExecutionData functionExecutionData, params IArgument[] arguments);
}
