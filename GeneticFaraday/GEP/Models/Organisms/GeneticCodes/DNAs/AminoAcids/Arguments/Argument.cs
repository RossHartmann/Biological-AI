using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments;

namespace GeneticFaraday.GEP.Models.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments
{
    public class Argument : ArgumentBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unevaluatedValue">The unevaluated value of the IArgument.
        /// 
        /// This will be set while the Genotype of the IOrganism is being parsed
        /// into the Phenotype.
        /// 
        /// The IArgument's IArgumentValue will be set upon 
        /// IAminoAcid execution (i.e. Phenotype execution).</param>
        public Argument(IArgumentUnevaluatedValue unevaluatedValue) 
            : base(unevaluatedValue)
        {
        }
    }
}
