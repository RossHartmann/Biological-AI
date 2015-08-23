using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.DNAs.AminoAcids
{
    public abstract class AminoAcidResultBase : IAminoAcidResult
    {
        public double Value { get; private set; }

        protected AminoAcidResultBase(double value)
        {
            this.Value = value;
        }
    }
}
