using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.Phenomes.DebuggablePhenomes
{
    public class DebuggableAminoAcidCollectionBase : List<IDebuggableAminoAcid>, IDebuggableAminoAcidCollection
    {
    }
}
