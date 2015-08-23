using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions.Parameters;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes;
using GeneticFaraday.GEP.Contracts.Registries;
using UtilityData.Exceptions.DatabaseExceptions;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.Phenomes.DebuggablePhenomes
{
    /// <summary>
    /// IDebuggableAminoAcid is a "step" in an IDebuggableGene.
    /// It is a snapshot in time of the information about an IGene's
    /// execution.
    /// </summary>
    public abstract class DebuggableAminoAcidBase : IDebuggableAminoAcid
    {
        /// <summary>
        /// The IAminoAcid that is being executed at this point in the
        /// IOrganism's execution.
        /// </summary>
        public IGEPAminoAcid AminoAcid { get; private set; }

        /// <summary>
        /// A shallow copy of all if the relevant IRegistries in the 
        /// IOrganism at this step in the IOrganism's execution.
        /// </summary>
        public IRegistryCollection Registries { get; private set; }

        /// <summary>
        /// The Result of executing the IAminoAcid at this step in the
        /// IOrganism's execution.
        /// </summary>
        public IAminoAcidResult Result { get; private set; }

        /// <summary>
        /// The Arguments to the IAminoAcid at this step in the IOrganism's
        /// execution.
        /// </summary>
        public IDebuggableAminoAcidCollection Arguments { get; private set; }

        /// <summary>
        /// The named result of the IDebuggableAminoAcid.
        /// </summary>
        public IVariable ResultingVariable { get; private set; }

        protected DebuggableAminoAcidBase(IGEPAminoAcid aminoAcid, IAminoAcidResult result,
            IRegistryCollection registries, IVariable resultingVariable, IDebuggableAminoAcidCollection arguments)
        {
            this.AminoAcid = aminoAcid;
            this.Result = result;
            this.Registries = registries;
            this.ResultingVariable = resultingVariable;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Gets the IDebuggableAminoAcid as a string.
        /// This is the function, its evaluated arguments and its resulting variable name.
        /// </summary>
        /// <param name="geneticCode">The IGeneticCode to which the IDebuggableAminoAcid adheres.</param>
        /// <param name="printIVariablesAsValues">If true, all argument IVariable names will be replaced
        /// by their corresponding value. If false, the argument IVariable names will be printed.</param>
        /// <returns></returns>
        public string GetDebuggableAminoAcidString(IGEPGeneticCode geneticCode, bool printIVariablesAsValues)
        {
            var function = geneticCode.FunctionSet[this.AminoAcid.Function];

            var stepString = "var " + this.ResultingVariable.Name + " = " + function.Name + "(";

            for (var i = 0; i < this.AminoAcid.Count; i++)
            {
                var parameter = function[i];

                if(parameter.ParameterType == ParameterType.AminoAcid)
                {
                    stepString += "AminoAcid: " + geneticCode.FunctionSet[this.AminoAcid[i].Value.AminoAcid.Function].Name;
                }
                else if (parameter.ParameterType == ParameterType.EvaluatedAminoAcid)
                {
                    if (printIVariablesAsValues)
                        stepString += this.AminoAcid[i].Value.EvaluatedAminoAcid.Value;
                    else
                        stepString += this.Arguments[i].ResultingVariable.Name;
                }
                else if (parameter.ParameterType == ParameterType.ConvertedCodon)
                {
                    stepString += this.AminoAcid[i].Value.ConvertedCodon.Value;
                }
                else
                {
                    throw new ValueNotYetSupported(parameter.ParameterType, typeof (ParameterType));
                }

                if (i + 1 < this.AminoAcid.Count)
                    stepString += ", ";
            }
            stepString += ");";

            stepString += " == " + this.Result.Value;
            return stepString;
        }
    }
}
