using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.Phenomes.DebuggablePhenomes
{
    public abstract class DebuggableGeneBase : IDebuggableGene
    {
        /// <summary>
        /// Indicates whether the IDebuggableGene was created successfully. 
        /// If false, the recursive level may have surpassed the maximum recursive level.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// The index of the currently viewed IDebuggableAminoAcid.
        /// </summary>
        protected int StepIndex { get; set; }

        /// <summary>
        /// The IDebuggableAminoAcid steps of this IDebuggableGene.
        /// </summary>
        protected List<IDebuggableAminoAcid> Steps { get; set; } 

        protected DebuggableGeneBase()
        {
            this.Steps = new List<IDebuggableAminoAcid>();
            this.Success = true;
        }

        public IEnumerator<IDebuggableAminoAcid> GetEnumerator()
        {
            return this.Steps.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Gets the "steps" of the IDebuggableGene "program."
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IDebuggableAminoAcid> GetSteps()
        {
            return this.Steps;
        }

        /// <summary>
        /// Adds the specified IDebuggableAminoAcid to this IDebuggableGene.
        /// </summary>
        /// <param name="step"></param>
        public void AddStep(IDebuggableAminoAcid step)
        {
            this.Steps.Add(step);
        }

        /// <summary>
        /// The current IDebuggableAminoAcid that is being viewed.
        /// </summary>
        public IDebuggableAminoAcid CurrentStep { get { return this.Steps[this.StepIndex]; } }

        /// <summary>
        /// Sets the CurrentStep to the next step.
        /// 
        /// Returns true on success. Returns false on failure.
        /// </summary>
        /// <returns></returns>
        public bool StepForward()
        {
            if (this.StepIndex + 1 >= this.Steps.Count)
                return false;

            this.StepIndex++;
            return true;
        }

        /// <summary>
        /// Sets the CurrentStep to the previous step.
        /// 
        /// Returns true on success. Returns false on failure.
        /// </summary>
        /// <returns></returns>
        public bool StepBackward()
        {
            if (this.StepIndex <= 0)
                return false;

            this.StepIndex--;
            return true;
        }

        /// <summary>
        /// Converts this IDebuggableGene to a string.
        /// </summary>
        /// <param name="geneticCode">The IGeneticCode to which the IDebuggableAminoAcid adheres.</param>
        /// <param name="printIVariablesAsValues">If true, all IVariable names will be replaced
        /// by their corresponding value. If false, the IVariable name will be printed.</param>
        /// <returns></returns>
        public string ToDebuggablePhenomeString(IGEPGeneticCode geneticCode, bool printIVariablesAsValues)
        {
            var program = new StringBuilder();
            foreach (var step in this.Steps)
            {
                var stepText = step.GetDebuggableAminoAcidString(geneticCode: geneticCode, printIVariablesAsValues: printIVariablesAsValues);

                program.Append(stepText.Replace("__", ""));
                program.Append("\n");
            }

            return program.ToString();
        }

    }
}
