using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Registries;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Models.Registries
{
    public class Registry : RegistryBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="registryType"></param>
        /// <param name="readOnly">Indicates whether the IRegistry is ReadOnly. If true, an exception will be thrown if the IRegistry
        /// attempts a write.</param>
        public Registry(IRegistryIdentifier identifier, RegistryType registryType, bool readOnly) 
            : base(identifier: identifier, registryType: registryType, readOnly: readOnly)
        {
        }

        public override IRegistry ShallowCopy()
        {
            return new Registry(identifier: this.Identifier.ShallowCopy(), registryType: this.RegistryType, readOnly: this.ReadOnly)
            {
                LowerValues = new List<IAminoAcidResult>(this.LowerValues),
                UpperValues = new List<IAminoAcidResult>(this.UpperValues),
                CurrentNeedlePosition = this.CurrentNeedlePosition
            };
        }
    }
}
