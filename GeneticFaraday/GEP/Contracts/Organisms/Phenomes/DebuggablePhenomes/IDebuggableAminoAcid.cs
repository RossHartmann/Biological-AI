using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Registries;

namespace GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes
{
    /// <summary>
    /// IDebuggableAminoAcid is a "step" in an IDebuggableGene.
    /// It is a snapshot in time of the information about an IGene's
    /// execution.
    /// </summary>
    public interface IDebuggableAminoAcid
    {
        /// <summary>
        /// The IAminoAcid that is being executed at this point in the
        /// IGene's execution.
        /// </summary>
        IGEPAminoAcid AminoAcid { get; }

        /// <summary>
        /// A shallow copy of all if the relevant IRegistries in the 
        /// IOrganism at this step in the IGene's execution.
        /// </summary>
        IRegistryCollection Registries { get; }

        /// <summary>
        /// The Result of executing the IAminoAcid at this step in the
        /// IGene's execution.
        /// </summary>
        IAminoAcidResult Result { get; }

        /// <summary>
        /// The Arguments to the IAminoAcid at this step in the IGene's
        /// execution.
        /// </summary>
        IDebuggableAminoAcidCollection Arguments { get; }

        /// <summary>
        /// The named result of the IDebuggableAminoAcid.
        /// </summary>
        IVariable ResultingVariable { get; }

        /// <summary>
        /// Gets the IDebuggableAminoAcid as a string.
        /// This is the function, its evaluated arguments and its resulting variable name.
        /// </summary>
        /// <param name="geneticCode">The IGeneticCode to which the IDebuggableAminoAcid adheres.</param>
        /// <param name="printIVariablesAsValues">If true, all argument IVariable names will be replaced
        /// by their corresponding value. If false, the argument IVariable names will be printed.</param>
        /// <returns></returns>
        string GetDebuggableAminoAcidString(IGEPGeneticCode geneticCode, bool printIVariablesAsValues);
    }
}