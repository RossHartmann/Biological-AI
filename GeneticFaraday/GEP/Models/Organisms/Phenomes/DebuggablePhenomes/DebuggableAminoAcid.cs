using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Organisms.Phenomes.DebuggablePhenomes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Models.Organisms.Phenomes.DebuggablePhenomes
{
    public class DebuggableAminoAcid : DebuggableAminoAcidBase
    {
        public DebuggableAminoAcid(IGEPAminoAcid aminoAcid, IAminoAcidResult result, 
            IRegistryCollection registries, IVariable resultingVariable, IDebuggableAminoAcidCollection arguments) 
            : base(aminoAcid, result, registries, resultingVariable, arguments)
        {
        }
    }
}
