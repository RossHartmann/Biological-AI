using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaradayApplication.Utilities;

namespace GeneticFaradayApplication.Views.Contracts.GeneticCodes.CodonConverters
{
    public interface ICodonConvertersView : IView
    {
        ICodonConverterIdentifier[] AvailableCodonConverters { get; set; }
        ICodonConverterIdentifier[] SelectedCodonConverters { get; set; }

        void AddToAvailableCodonConverters(ICodonConverterIdentifier codonConverter);
        void AddToSelectedCodonConverters(ICodonConverterIdentifier codonConverter);

        void RemoveFromAvailableCodonConverters(ICodonConverterIdentifier codonConverter);
        void RemoveFromSelectedCodonConverters(ICodonConverterIdentifier codonConverter);


        event EventHandler<EventArgsWithModel<ICodonConverterIdentifier>> MoveToAvailableCodonConvertersRequested;
        event EventHandler<EventArgsWithModel<ICodonConverterIdentifier>> MoveToSelectedCodonConvertersRequested;

        event EventHandler MoveAllToAvailableCodonConvertersRequested;
        event EventHandler MoveAllToSelectedCodonConvertersRequested;
    }
}
