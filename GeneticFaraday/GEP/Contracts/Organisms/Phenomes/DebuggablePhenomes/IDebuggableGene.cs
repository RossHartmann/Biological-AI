using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Phenomes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;

namespace GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes
{
    /// <summary>
    /// An IDebuggableGene is an IGene that treats the IGene's phenotype
    /// as a "program". An IDebuggableGene can be "stepped" into.
    /// </summary>
    public interface IDebuggableGene : IPhenome, IEnumerable<IDebuggableAminoAcid>
    {
        /// <summary>
        /// Indicates whether the IDebuggableGene was created successfully. 
        /// If false, the recursive level may have surpassed the maximum recursive level.
        /// </summary>
        bool Success { get; set; }

        /// <summary>
        /// Gets the "steps" of the IDebuggableGene "program."
        /// </summary>
        IEnumerable<IDebuggableAminoAcid> GetSteps();

        /// <summary>
        /// Adds the specified IDebuggableAminoAcid to this IDebuggableGene.
        /// </summary>
        /// <param name="step"></param>
        void AddStep(IDebuggableAminoAcid step);

        /// <summary>
        /// The current IDebuggableAminoAcid that is being viewed.
        /// </summary>
        IDebuggableAminoAcid CurrentStep { get; }

        /// <summary>
        /// Sets the CurrentStep to the next step.
        /// 
        /// Returns true on success. Returns false on failure.
        /// </summary>
        bool StepForward();

        /// <summary>
        /// Sets the CurrentStep to the previous step.
        /// 
        /// Returns true on success. Returns false on failure.
        /// </summary>
        bool StepBackward();

        /// <summary>
        /// Converts this IDebuggableGene to a string.
        /// </summary>
        /// <param name="geneticCode">The IGeneticCode to which the IDebuggableAminoAcid adheres.</param>
        /// <param name="printIVariablesAsValues">If true, all IVariable names will be replaced
        /// by their corresponding value. If false, the IVariable names will be printed.</param>
        /// <returns></returns>
        string ToDebuggablePhenomeString(IGEPGeneticCode geneticCode, bool printIVariablesAsValues);
    }
}
