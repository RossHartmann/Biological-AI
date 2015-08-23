using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;

namespace GeneticFaradayApplication.Models.Contracts.GeneticCodes.CodonConverters
{
    public interface ICodonConvertersModel : IModel<ICodonConvertersModel>
    {
        List<ICodonConverterIdentifier> AvailableCodonConverters { get; }
    }
}
