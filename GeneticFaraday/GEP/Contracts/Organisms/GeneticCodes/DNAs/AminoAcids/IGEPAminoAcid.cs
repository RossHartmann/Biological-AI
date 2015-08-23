using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids
{
    /// <summary>
    /// An IAminoAcid is the actual function that will be executed and contains
    /// the values of the actual arguments that will be passed to the IFunction's
    /// parameters (as specified by the IFunction's IParameters).
    /// 
    /// See "IFunction" for the definition of the function that will be executed.
    /// </summary>
    public interface IGEPAminoAcid : IAminoAcid, IArgumentCollection
    {
        /// <summary>
        /// The IGEPCodon that encoded for this IGEPAminoAcid.
        /// </summary>
        new IGEPCodon Codon { get; }

        /// <summary>
        /// If true, The Parameterless IFunction in the ICodon will be the IFunction
        /// that is executed.
        /// 
        /// If false, the Primary IFunction in the ICodon will be used.
        /// </summary>
        bool UseParameterlessFunction { get; }

        /// <summary>
        /// The identifier of the IFunction that this IAminoAcid represents.
        /// </summary>
        IFunctionIdentifier Function { get; }
    }
}
