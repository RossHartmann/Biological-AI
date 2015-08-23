using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms;
using GeneticFaraday.GEP.Contracts.Organisms.Chromosomes;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions.Parameters;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes;
using GeneticFaraday.GEP.Contracts.Registries;
using GeneticFaraday.GEP.Contracts.Universe;
using GeneticFaraday.GEP.Models.Organisms.Genes;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Models.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.GEP.Models.Organisms.Phenomes.DebuggablePhenomes;
using GeneticFaraday.GEP.Models.Registries;
using GeneticFaraday.Models.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Utility;
using UtilityData.Exceptions.DatabaseExceptions;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.Genes
{
    public abstract class GEPGeneBase : GeneBase, IGEPGene
    {
        IEnumerator<IGEPAllele> IEnumerable<IGEPAllele>.GetEnumerator()
        {
            var baseEnumerator = base.Alleles.GetEnumerator();
            while (baseEnumerator.MoveNext())
                yield return (IGEPAllele)baseEnumerator.Current;
        }

        IEnumerator<IGEPGene> IEnumerable<IGEPGene>.GetEnumerator()
        {
            var baseEnumerator = base.ChildGenes.GetEnumerator();
            while (baseEnumerator.MoveNext())
                yield return (IGEPGene)baseEnumerator.Current;
        }

        /// <summary>
        /// The provided IGene must be an IGEPGene.
        /// </summary>
        /// <param name="item"></param>
        new public void Add(IGene item)
        {
            this.Add((IGEPGene) item);
        }

        public void Add(IGEPGene item)
        {
            item.ParentGene = this;
            item.Parent = this.Parent;
            this.ChildGenes.Add(item: item);
        }

        /// <summary>
        /// The provided IAllele must be an IGEPAllele.
        /// </summary>
        /// <param name="item"></param>
        new public void Add(IAllele item)
        {
            base.Add(allele: item);
        }

        public void Add(IGEPAllele item)
        {
            this.Add(item: item as IAllele);
        }

        void ICollection<IGEPAllele>.Clear()
        {
            this.Alleles.Clear();
        }

        public bool Contains(IGEPAllele item)
        {
            return this.Alleles.Contains(item: item);
        }

        public void CopyTo(IGEPAllele[] array, int arrayIndex)
        {
            this.Alleles.CopyTo(array: array, arrayIndex: arrayIndex);
        }

        public bool Remove(IGEPAllele item)
        {
            return this.Alleles.Remove(item: item);
        }

        int ICollection<IGEPAllele>.Count { get { return this.Alleles.Count; } }

        void ICollection<IGEPGene>.Clear()
        {
            this.ChildGenes.Clear();
        }

        public bool Contains(IGEPGene item)
        {
            return this.ChildGenes.Contains(item: item);
        }

        public void CopyTo(IGEPGene[] array, int arrayIndex)
        {
            this.ChildGenes.CopyTo(array: array, arrayIndex: arrayIndex);
        }

        public bool Remove(IGEPGene item)
        {
            return this.ChildGenes.Remove(item: item);
        }

        int ICollection<IGEPGene>.Count { get { return this.ChildGenes.Count; } }

        public int IndexOf(IGEPGene item)
        {
            return this.ChildGenes.IndexOf(item: item);
        }

        public void Insert(int index, IGEPGene item)
        {
            this.ChildGenes.Insert(index: index, item: item);
        }

        public int IndexOf(IGEPAllele item)
        {
            return this.Alleles.IndexOf(item: item);
        }

        public void Insert(int index, IGEPAllele item)
        {
            this.Alleles.Insert(index: index, item: item);
        }

        void IList<IGEPAllele>.RemoveAt(int index)
        {
            this.Alleles.RemoveAt(index: index);
        }

        IGEPAllele IList<IGEPAllele>.this[int index]
        {
            get { return (IGEPAllele)this.Alleles[index]; }
            set { this.Alleles[index] = value; }
        }

        void IList<IGEPGene>.RemoveAt(int index)
        {
            this.ChildGenes.RemoveAt(index: index);
        }

        IGEPGene IList<IGEPGene>.this[int index]
        {
            get { return (IGEPGene)this.ChildGenes[index]; }
            set { this.ChildGenes[index] = value; }
        }

        new public IGEPChromosome Parent { get { return (IGEPChromosome)base.Parent; } set { base.Parent = value; } }

        new public IGEPGene ParentGene { get { return (IGEPGene)base.ParentGene; } set { base.ParentGene = value; } }

        new public IGEPOrganism ParentOrganism { get { return this.Parent.Parent; } }

        new public IGEPEnvironment ParentEnvironment { get { return this.ParentOrganism.Parent; } }

        new public IGEPUniverse ParentUniverse { get { return this.ParentEnvironment.Parent; } }


        /// <summary>
        /// The IGEPGeneticCode to which this IGEPGene adheres.
        /// </summary>
        new public IGEPGeneticCode GeneticCode { get { return this.ParentUniverse.GeneticCode; } }

        /// <summary>
        /// The Local Registry for the IGEPGene.
        /// This will be reset every time this IGEPGene is executed.
        /// </summary>
        public IRegistry LocalRegistry { get; private set; }


        protected GEPGeneBase(IGEPEnvironment environment)
        {
            this.LocalRegistry = new Registry(identifier: environment.LocalRegistryIdentifier,
                                              registryType: RegistryType.Local, readOnly: false);
        }

        /// <summary>
        /// Gets the IRegistry with the specified IRegistryIdentifier.
        /// 
        /// This design allows for adding multiple IRegistries of the same RegistryType but
        /// with different IRegistryIdentifiers. We could, for example, have two separate Global Registries
        /// and the executing IFunction will call the appropriate Global Registry based on its IRegistryIdentifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public abstract IRegistry GetRegistry(IRegistryIdentifier identifier, IGEPGeneSurroundings geneSurroundings);

        /// <summary>
        /// Clears all of the Local IRegistries that belong to this IGEPGene.
        /// </summary>
        public virtual void ClearLocalRegistries()
        {
            this.LocalRegistry.Clear();
        }

        /// <summary>
        /// Given the IGEPGene's immediate surroundings (i.e. the "input"), 
        /// "Runs" the IGEPGene which results in its Behavior (i.e. the "ouput").
        /// </summary>
        /// <returns></returns>
        public virtual IGEPGeneBehavior Behave(IGEPGeneSurroundings surroundings)
        {
            this.ClearLocalRegistries();

            var geneExecutionData = surroundings.GeneExecutionDataDictionary[this.Identifier];
            geneExecutionData.RecursionLevel++;

            if (geneExecutionData.RecursionLevel >= this.ParentEnvironment.GeneticCode.MaxRecursionLevel)
            {
                geneExecutionData.RecursionLevel--;
                return new GEPGeneBehavior(success: false);
            }

            var phenotype = (IGEPGenePhenotype)this.CreatePhenotype();
            var result = this.ExecuteAminoAcid(aminoAcid: phenotype.RootAminoAcid, geneSurroundings: surroundings);

            geneExecutionData.RecursionLevel--;

            return new GEPGeneBehavior(success: result != null);
        }

        /// <summary>
        /// Returns the IGEPGenePhenotype of this IGEPGene. The root IGEPAminoAcid and its children
        /// make-up the phenotype of the IGEPGene.
        /// </summary>
        /// <returns></returns>
        public override IGenePhenotype CreatePhenotype()
        {
            var nextCodonIndex = 0;
            var useOnlyParameterlessFunctions = false;
            return new GEPGenePhenotype(this.GetNextAminoAcid(ref nextCodonIndex, ref useOnlyParameterlessFunctions));
        }

        /// <summary>
        /// Recursively gathers the next IGEPAminoAcid in the Genotype (i.e. the DNA) of this IGEPGene.
        /// </summary>
        /// <param name="nextNucleotideIndex"></param>
        /// <param name="useOnlyParameterlessFunctions"></param>
        /// <returns></returns>
        protected virtual IGEPAminoAcid GetNextAminoAcid(ref int nextNucleotideIndex, ref bool useOnlyParameterlessFunctions)
        {
            var codon = this.GetNextCodon(ref nextNucleotideIndex, ref useOnlyParameterlessFunctions);

            var aminoAcid = new GEPAminoAcid(codon: codon, 
                useParameterlessFunction: useOnlyParameterlessFunctions);

            // If this Codon is a Stop Codon then we should 
            // only gather Parameterless Functions from the next IAminoAcid on out.
            if (codon.CodonType == CodonType.Stop)
                useOnlyParameterlessFunctions = true;

            // We will need to fill all of the function's arguments.
            var function = this.GeneticCode.FunctionSet[aminoAcid.Function];
            if(function.ParameterCount > 0)
                this.AddUnevaluatedArgumentsToAminoAcid(aminoAcid: aminoAcid, function: function,
                                                        nextNucleotideIndex: ref nextNucleotideIndex,
                                                        useOnlyParameterlessFunctions: ref useOnlyParameterlessFunctions);
            
            return aminoAcid;
        }

        /// <summary>
        /// Adds the necessary IArguments (as determined by the IParameters of the given IFunction) to the
        /// given IGEPAminoAcid.
        /// </summary>
        /// <param name="aminoAcid"></param>
        /// <param name="function"></param>
        /// <param name="nextNucleotideIndex"></param>
        /// <param name="useOnlyParameterlessFunctions"></param>
        protected virtual void AddUnevaluatedArgumentsToAminoAcid(IGEPAminoAcid aminoAcid, IFunction function, 
            ref int nextNucleotideIndex, ref bool useOnlyParameterlessFunctions)
        {
            foreach (var parameter in function)
            {
                if (parameter.ParameterType == ParameterType.AminoAcid ||
                    parameter.ParameterType == ParameterType.EvaluatedAminoAcid)
                {
                    aminoAcid.Add(this.GetIArgumentWithNextAminoAcid(nextNucleotideIndex: ref nextNucleotideIndex,
                                                                     useOnlyParameterlessFunctions: ref
                                                                         useOnlyParameterlessFunctions));
                }
                else if (parameter.ParameterType == ParameterType.ConvertedCodon)
                {
                    aminoAcid.Add(this.GetIArgumentWithNextCodon(nextNucleotideIndex: ref nextNucleotideIndex,
                                                                     useOnlyParameterlessFunctions: ref
                                                                         useOnlyParameterlessFunctions));
                }
                else
                {
                    throw new ValueNotYetSupported(parameter.ParameterType, typeof(ParameterType));
                }
            }
        }

        /// <summary>
        /// Creates an IArgument by reading the next IGEPCodon starting from the next nucleotide index.
        /// </summary>
        /// <param name="nextNucleotideIndex"></param>
        /// <param name="useOnlyParameterlessFunctions"></param>
        /// <returns></returns>
        protected virtual IArgument GetIArgumentWithNextCodon(ref int nextNucleotideIndex, ref bool useOnlyParameterlessFunctions)
        {
            return new Argument(
                new ArgumentUnevaluatedValue(
                    this.GetNextCodon(nucleotideIndex: ref nextNucleotideIndex,
                                      useOnlyParameterlessFunctions: ref
                                          useOnlyParameterlessFunctions)));
        }

        /// <summary>
        /// Creates an IArgument by creating an IGEPAminoAcid starting from the next nucleotide index.
        /// </summary>
        /// <param name="nextNucleotideIndex"></param>
        /// <param name="useOnlyParameterlessFunctions"></param>
        /// <returns></returns>
        protected virtual IArgument GetIArgumentWithNextAminoAcid(ref int nextNucleotideIndex, ref bool useOnlyParameterlessFunctions)
        {
            return new Argument(
                new ArgumentUnevaluatedValue(this.GetNextAminoAcid(ref nextNucleotideIndex,
                                                              ref useOnlyParameterlessFunctions)));
        }


        /// <summary>
        /// Gets the next IGEPCodon starting at the given nucleotide index.
        /// </summary>
        /// <param name="nucleotideIndex"></param>
        /// <param name="useOnlyParameterlessFunctions">If true, indicates that we should only gather Parameterless Functions (this
        /// will be true if we're in the "tail" of the DNA or if we've met a Stop Codon.</param>
        /// <returns></returns>
        protected virtual IGEPCodon GetNextCodon(ref int nucleotideIndex, ref bool useOnlyParameterlessFunctions)
        {
            var codonIdentifier = "";

            // Get the identifier of the Codon
            var activeAllele = this.GetActiveAllele();
            for (var j = 0; j < this.GeneticCode.CodonLength; j++)
                codonIdentifier += activeAllele.DNA[nucleotideIndex + j].Identifier;

            // Go to the next codon
            nucleotideIndex += this.GeneticCode.CodonLength;

            // Determine if we're in the tail of the DNA. If we are, then we will only use
            // parameterless functions.
            if (nucleotideIndex > this.GeneticCode.DNAHeadLength)
                useOnlyParameterlessFunctions = true;

            return (IGEPCodon)this.GeneticCode.GetCodon(new CodonIdentifier(codonIdentifier));
        }

        /// <summary>
        /// Executes the given IAminoAcid and returns the IAminoAcidResult.
        /// 
        /// Returns null if the Max Recursion Level was reached.
        /// </summary>
        /// <param name="aminoAcid">The IAminoAcid to evaluate.</param>
        /// <param name="geneSurroundings">The IGEPGeneSurroundings that were passed to the executing IGEPGene.</param>
        /// <returns></returns>
        public virtual IAminoAcidResult ExecuteAminoAcid(IGEPAminoAcid aminoAcid, IGEPGeneSurroundings geneSurroundings)
        {
            var function = this.GeneticCode.FunctionSet[aminoAcid.Function];

            if (function.ParameterCount > 0)
                if (!this.SetArgumentValuesOfAminoAcid(aminoAcid: aminoAcid, function: function, geneSurroundings: geneSurroundings))
                    return null;

            var functionExecutionData = new FunctionExecutionData(executingAllele: (IGEPAllele)this.GetActiveAllele(), 
                availableRegistries: this.GetRegistriesForFunction(function: function, geneSurroundings: geneSurroundings), 
                callableGenes: this.ParentEnvironment.CallableGenesProvider.GetCallableGenes(this),
                geneExecutionDataDictionary: geneSurroundings.GeneExecutionDataDictionary);

            return function.ExecuteMethod(functionExecutionData: functionExecutionData, arguments: aminoAcid.ToArray());
        }

        /// <summary>
        /// Sets the IArgumentValue for each of the IArguments in the given IGEPAminoAcid.
        /// Matches the IArguments based on the IParameters of the given IFunction.
        /// </summary>
        /// <param name="aminoAcid"></param>
        /// <param name="function"></param>
        /// <param name="geneSurroundings">The IGEPGeneSurroundings that were passed to the executing IGEPGene.</param>
        /// <returns></returns>
        protected virtual bool SetArgumentValuesOfAminoAcid(IGEPAminoAcid aminoAcid, IFunction function, IGEPGeneSurroundings geneSurroundings)
        {
            var i = 0;
            foreach (var parameter in function)
            {
                var argument = aminoAcid[i];

                if (parameter.ParameterType == ParameterType.EvaluatedAminoAcid)
                {
                    if (!argument.SetArgumentValueAsEvaluatedAminoAcid(executingGene: this, geneSurroundings: geneSurroundings))
                        return false;
                }
                else if (parameter.ParameterType == ParameterType.AminoAcid)
                {
                    argument.SetArgumentValueAsAminoAcid();
                }
                else if (parameter.ParameterType == ParameterType.ConvertedCodon)
                {
                    argument.SetArgumentValueAsConvertedCodon(executingGene: this, parameter: parameter);
                }
                else
                    throw new ValueNotYetSupported(parameter.ParameterType, typeof(ParameterType));

                i++;
            }

            return true;
        }


        /// <summary>
        /// Gets a collection of IRegistries for the AvailableRegistries of the given IFunction.
        /// </summary>
        /// <param name="function"></param>
        /// <returns></returns>
        protected virtual IRegistryCollection GetRegistriesForFunction(IFunction function, IGEPGeneSurroundings geneSurroundings)
        {
            if(function.AvailableRegistries == null)
                return new RegistryCollection();
            else
                return new RegistryCollection(function.AvailableRegistries.Select(r => this.GetRegistry(r, geneSurroundings: geneSurroundings)));
        }

        /// <summary>
        /// Gets all of the IRegistries currently available to this IGEPGene.
        /// </summary>
        /// <param name="surroundings">The data passed to this IGEPGeneSurroundings during execution.</param>
        /// <returns></returns>
        public virtual IRegistryCollection GetAllRegistries(IGEPGeneSurroundings surroundings)
        {
            return new RegistryCollection(this.ParentEnvironment.AllRegistryIdentifiers.Select(r => this.GetRegistry(r, surroundings)));
        }

        /// <summary>
        /// Converts this IGEPGene to its corresponding IDebuggableGene. An IDebuggableGene is an IGene that 
        /// treats the IGene's phenotype as a "program". An IDebuggableGene can be "stepped" into.
        /// </summary>
        /// <returns></returns>
        public IDebuggableGene ToDebuggableGene(IGEPGeneSurroundings surroundings)
        {
            this.ClearLocalRegistries();

            var geneExecutionData = surroundings.GeneExecutionDataDictionary[this.Identifier];
            geneExecutionData.RecursionLevel++;

            if (geneExecutionData.RecursionLevel >= this.ParentEnvironment.GeneticCode.MaxRecursionLevel)
            {
                geneExecutionData.RecursionLevel--;
                return null;
            }

            var phenotype = (IGEPGenePhenotype)this.CreatePhenotype();
            geneExecutionData.RecursionLevel--;

            var debuggableGene = new DebuggableGene();
            this.DebugAminoAcidAndAddToDebuggableGene(debuggableGene: debuggableGene,
                                                      uniqueStringGenerator: new UniqueStringGenerator(),
                                                      aminoAcid: phenotype.RootAminoAcid,
                                                      geneSurroundings: surroundings);

            return debuggableGene;
        }

        /// <summary>
        /// Sets the argument values for the given IGEPAminoAcid when it is being debugged.
        /// </summary>
        /// <param name="debuggableGene"></param>
        /// <param name="uniqueStringGenerator"></param>
        /// <param name="aminoAcid"></param>
        /// <param name="function"></param>
        /// <param name="geneSurroundings"></param>
        /// <param name="debuggableAminoAcidArguments"></param>
        /// <returns></returns>
        protected virtual bool SetDebugArgumentValuesOfAminoAcid(IDebuggableGene debuggableGene, UniqueStringGenerator uniqueStringGenerator, 
            IGEPAminoAcid aminoAcid, IFunction function, IGEPGeneSurroundings geneSurroundings, out IDebuggableAminoAcidCollection debuggableAminoAcidArguments)
        {
            debuggableAminoAcidArguments = new DebuggableAminoAcidCollection();
            var i = 0;
            foreach (var parameter in function)
            {
                var argument = aminoAcid[i];

                if (parameter.ParameterType == ParameterType.EvaluatedAminoAcid)
                {
                    if (!argument.SetArgumentValueAsEvaluatedAminoAcid(executingGene: this, geneSurroundings: geneSurroundings))
                        return false;

                    var debuggableAminoAcid = this.DebugAminoAcidAndAddToDebuggableGene(debuggableGene: debuggableGene, uniqueStringGenerator: uniqueStringGenerator, aminoAcid: argument.UnevaluatedValue.AminoAcid, geneSurroundings: geneSurroundings);
                    if (debuggableAminoAcid == null)
                        return false;

                    debuggableAminoAcidArguments.Add(debuggableAminoAcid);
                }
                else if (parameter.ParameterType == ParameterType.AminoAcid)
                {
                    argument.SetArgumentValueAsAminoAcid();
                    debuggableAminoAcidArguments.Add(null);
                }
                else if (parameter.ParameterType == ParameterType.ConvertedCodon)
                {
                    argument.SetArgumentValueAsConvertedCodon(executingGene: this, parameter: parameter);
                    debuggableAminoAcidArguments.Add(null);
                }
                else
                    throw new ValueNotYetSupported(parameter.ParameterType, typeof(ParameterType));

                i++;
            }

            return true;
        }

        /// <summary>
        /// Creates an IDebuggableAminoAcid and adds it to the given IDebuggableGene.
        /// Adds all arguments as subsequent steps to the given IDebuggableGene.
        /// 
        /// Returns the IDebuggableAminoAcid that was created.
        /// </summary>
        /// <param name="debuggableGene"></param>
        /// <param name="uniqueStringGenerator"></param>
        /// <param name="aminoAcid"></param>
        /// <param name="geneSurroundings"></param>
        protected virtual IDebuggableAminoAcid DebugAminoAcidAndAddToDebuggableGene(IDebuggableGene debuggableGene, UniqueStringGenerator uniqueStringGenerator, IGEPAminoAcid aminoAcid, IGEPGeneSurroundings geneSurroundings)
        {
            var function = this.GeneticCode.FunctionSet[aminoAcid.Function];

            IDebuggableAminoAcidCollection debuggableAminoAcidArguments;
            if (!SetDebugArgumentValuesOfAminoAcid(debuggableGene: debuggableGene, uniqueStringGenerator: uniqueStringGenerator, 
                aminoAcid: aminoAcid, function: function, geneSurroundings: geneSurroundings, debuggableAminoAcidArguments: out debuggableAminoAcidArguments))
            {
                debuggableGene.Success = false;
                return null;
            }
            

            var functionExecutionData = new FunctionExecutionData(executingAllele: (IGEPAllele)this.GetActiveAllele(),
                availableRegistries: this.GetRegistriesForFunction(function: function, geneSurroundings: geneSurroundings),
                callableGenes: this.ParentEnvironment.CallableGenesProvider.GetCallableGenes(this),
                geneExecutionDataDictionary: geneSurroundings.GeneExecutionDataDictionary);

            var result = function.ExecuteMethod(functionExecutionData: functionExecutionData, arguments: aminoAcid.ToArray());

            var resultingVariableName = "__" + uniqueStringGenerator.GetNextString();
            var resultingVariable = new Variable(name: resultingVariableName);

            var debuggableAminoAcid = new DebuggableAminoAcid(aminoAcid: aminoAcid, result: result,
                                                              registries: new RegistryCollection(this.GetAllRegistries(surroundings: geneSurroundings).Select(r => r.ShallowCopy())),
                                                              resultingVariable: resultingVariable,
                                                              arguments: debuggableAminoAcidArguments);
            debuggableGene.AddStep(debuggableAminoAcid);

            return debuggableAminoAcid;
        }
    }
}
