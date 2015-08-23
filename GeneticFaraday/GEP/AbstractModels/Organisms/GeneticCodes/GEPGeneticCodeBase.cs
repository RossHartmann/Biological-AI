using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.Functions;
using GeneticFaraday.Models.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Utility;
using UtilityData.LINQ;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes
{
    public abstract class GEPGeneticCodeBase : GeneticCodeBase, IGEPGeneticCode
    {
        /// <summary>
        /// A dictionary of all of the valid IFunctions in the IGEPGeneticCode.
        /// </summary>
        public SortedList<IFunctionIdentifier, IFunction> FunctionSet { get; private set; }

        /// <summary>
        /// All of the combinations of Primary Functions and Parameterless Functions (as taken from
        /// the FunctionSet).
        /// </summary>
        public List<IFunctionPair> FunctionPairs { get; private set; }

        /// <summary>
        /// The maximum number of IFunctions that take parameters 
        /// that can be used in an IAllele's IDNA. After (or before) this 
        /// number of IFunctions (with parameters) have been called, the rest
        /// of the IFunctions in the IDNA will not accept any parameters (i.e. they 
        /// will be terminals).
        /// </summary>
        public int MaxParameterfulFunctionsInDNA { get; protected set; }

        /// <summary>
        /// The number of IParameters used by the IFunction that has the most parameters.
        /// </summary>
        public int MaximumFunctionInputsUsed { get; protected set; }

        /// <summary>
        /// The maximum recursion level that's allowable. If this value is reached by an
        /// IGEPGene, the execution of the IGEPGene will be aborted.
        /// </summary>
        public int MaxRecursionLevel { get; protected set; }

        /// <summary>
        /// The Length of the "head" of a sequence of IDNA as measured in INucleotides.
        /// The "head" can use IFunctions with or without Parameters.
        /// </summary>
        public int DNAHeadLength { get { return CalculateDNAHeadLength(maxParameterfulFunctionsInDNA: this.MaxParameterfulFunctionsInDNA, codonLength: this.CodonLength); } }

        /// <summary>
        /// The Length of the "tail" of a sequence of IDNA as measured in INucleotides.
        /// The "tail" can only use IFunctions without Parameters.
        /// </summary>
        public int DNATailLength
        {
            get { return CalculateDNATailLength(dnaHeadLength: this.DNAHeadLength, maximumFunctionInputsUsed: this.MaximumFunctionInputsUsed, codonLength: this.CodonLength); }
        }

        /// <summary>
        /// The length of all IDNA.
        /// </summary>
        public int DNALength { get { return CalculateDNALength(dnaHeadLength: this.DNAHeadLength, dnaTailLength: this.DNATailLength); } }


        public static int CalculateDNALength(int dnaHeadLength, int dnaTailLength)
        {
            return dnaHeadLength + dnaTailLength;
        }

        public static int CalculateDNAHeadLength(int maxParameterfulFunctionsInDNA, int codonLength)
        {
            return maxParameterfulFunctionsInDNA * codonLength;
        }

        public static int CalculateDNATailLength(int dnaHeadLength, int maximumFunctionInputsUsed, int codonLength)
        {
            return dnaHeadLength * (maximumFunctionInputsUsed == 0 ? 0 : maximumFunctionInputsUsed - 1) + (1 * codonLength);
        }

        protected GEPGeneticCodeBase() 
            : this(codonLength: 0, maxParameterfulFunctionsInDNA: 0, maxRecursionLevel: 0)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codonLength">The length of every ICodon in the IGeneticCode.
        /// 
        /// All ICodons must be of this length.</param>
        /// <param name="maxParameterfulFunctionsInDNA">The maximum number of IFunctions that take parameters 
        /// that can be used in an IAllele's IDNA. After (or before) this 
        /// number of IFunctions (with parameters) have been called, the rest
        /// of the IFunctions in the IDNA will not accept any parameters (i.e. they 
        /// will be terminals).</param>
        /// <param name="maxRecursionLevel">The maximum recursion level that's allowable. If this value is reached by an
        /// IGEPGene, the execution of the IGEPGene will be aborted.</param>
        protected GEPGeneticCodeBase(int codonLength, int maxParameterfulFunctionsInDNA, int maxRecursionLevel = 2) 
            : base(codonLength)
        {
            this.FunctionSet = new SortedList<IFunctionIdentifier, IFunction>();
            this.MaxParameterfulFunctionsInDNA = maxParameterfulFunctionsInDNA;
            this.FunctionPairs = new List<IFunctionPair>();
            this.MaxRecursionLevel = maxRecursionLevel;
        }

        /// <summary>
        /// Converts the specified IGEPCodon using the specified ICodonConverterIdentifier.
        /// </summary>
        /// <param name="codon"></param>
        /// <param name="codonConverterIdentifier"></param>
        /// <returns></returns>
        public IConvertedCodon ConvertCodon(IGEPCodon codon, ICodonConverterIdentifier codonConverterIdentifier)
        {
            return base.ConvertCodon(codon: codon, codonConverterIdentifier: codonConverterIdentifier);
        }



        /// <summary>
        /// Adds the specified IGEPCodon to the IGEPGeneticCode.
        /// </summary>
        /// <param name="codon"></param>
        public abstract void AddCodon(IGEPCodon codon);


        /// <summary>
        /// Adds the specified IFunctions to the IGEPGeneticCode.
        /// </summary>
        /// <param name="functions"></param>
        public void AddFunctions(IEnumerable<IFunction> functions)
        {
            foreach (var function in functions)
                this.AddFunction(function);
        }

        /// <summary>
        /// Adds the specified IFunction to the IGEPGeneticCode.
        /// </summary>
        /// <param name="function"></param>
        public void AddFunction(IFunction function)
        {
            this.FunctionSet.Add(key: function.Identifier, value: function);

            if (function.ParameterCount > this.MaximumFunctionInputsUsed)
                this.MaximumFunctionInputsUsed = function.ParameterCount;
        }

        /// <summary>
        /// Retrieves the first IGEPCodon of the specified CodonType that primarily 
        /// encodes for the IFunction as identified
        /// by the given IFunctionIdentifier.
        /// </summary>
        /// <param name="functionIdentifier"></param>
        /// <param name="codonType"></param>
        /// <returns></returns>
        public abstract IGEPCodon GetCodonEncodingFunction(IFunctionIdentifier functionIdentifier, CodonType codonType = CodonType.Standard);

        /// <summary>
        /// Returns all of the Parameterless IFunctions in the IGEPGeneticCode.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFunction> GetParameterlessFunctions()
        {
            return this.FunctionSet.Where(f => f.Value.IsParameterless).Select(f => f.Value);
        }

        /// <summary>
        /// Recalculates the FunctionPairs List.
        /// </summary>
        public void CalculateFunctionPairs()
        {
            this.FunctionPairs = new List<IFunctionPair>();

            var parameterlessFunctionIdentifiers = this.GetParameterlessFunctions().Select(f => f.Identifier);

            foreach(var primaryFunctionIdentifier in this.FunctionSet.Keys)
            {
                foreach (var parameterlessFunctionIdentifier in parameterlessFunctionIdentifiers)
                {
                    this.FunctionPairs.Add(new FunctionPair(geneticCode: this,
                                                            primaryFunction: primaryFunctionIdentifier,
                                                            parameterlessFunction: parameterlessFunctionIdentifier));
                }
            }
        }

        /// <summary>
        /// Creates this IGEPGeneticCode based on the current INucleotides and IFunctions in the IGEPGeneticCode.
        /// </summary>
        /// <param name="percentageStopCodons">The percentage of the total IGEPCodons that will be Stop IGEPCodons. This should be less than 1.</param>
        /// <param name="redundancyRating">A redundancy rating of 0 means that each IFunction with a Weight of 1 will not be repeated before the next IFunction is added. 
        /// A redundancy rating of 0 means that an IFunction Weight of 1 will result in adding one IFunction and then moving to the next when going from one ICodon to the next.
        /// 
        /// A redundancy rating of 1 means that each function with a Weight of 1 will be repeated once before moving to the next codon.
        /// </param>
        /// <param name="onCodonAdded">The function to call when a Codon is added.</param>
        public void AutoAssignCodonsToAminoAcids(double percentageStopCodons = .05, int redundancyRating = 100, Action onCodonAdded = null)
        {
            var codonsPerStandardFunction = redundancyRating + 1;

            this.CalculateFunctionPairs();
            var nextNucleotideSequence = this.GetFirstNucleotideSequence();
            
            while (!this.IsLastNucleotideSequence(nextNucleotideSequence))
            {
                foreach (var functionPair in this.FunctionPairs)
                {
                    var primaryFunction = this.FunctionSet[functionPair.PrimaryFunction];
                    var codonsPerFunction = (int)(codonsPerStandardFunction * primaryFunction.WeightInGeneticCode);

                    var done = false;
                    for (var i = 0; i < codonsPerFunction; i++)
                    {
                        if (this.IsLastNucleotideSequence(nextNucleotideSequence))
                        {
                            done = true;
                            break;
                        }

                        this.AddCodonFunctionPair(functionPair, nextNucleotideSequence.ToArray(), onCodonAdded: onCodonAdded);

                        this.IncrementNucleotideSequence(nextNucleotideSequence);
                    }

                    if (done)
                        break;
                }
            }

            this.AddCodonFunctionPair(this.FunctionPairs[this.FunctionPairs.Count - 1],
                                                    nextNucleotideSequence.ToArray(), onCodonAdded: onCodonAdded);


            this.CreateStopCodons(percentageStopCodons: percentageStopCodons);

        }

        /// <summary>
        /// Creates batches of Stop Codons in the ICodons list of this IGEPGeneticCode..
        /// </summary>
        /// <param name="percentageStopCodons">This should be less than 1.</param>
        private void CreateStopCodons(double percentageStopCodons)
        {
            if(percentageStopCodons >= 1)
                throw new Exception("The Percentage of Stop Codons must be less than 1.");

            var allCodons = this.GetAllCodonIdentifiers();

            var totalCodons = Math.Pow(this.Nucleotides.Count, this.CodonLength);

            // The Stop Codons will be in small batches since they won't encode for any IFunction.
            // We don't want any group of Stop ICodons to override any particular IFunction completely.
            var numberOfStopCodons = (int)(percentageStopCodons * totalCodons);
            const int numberOfStopCodonBatches = 50;
            var numberOfStopCodonsPerBatch = numberOfStopCodons / numberOfStopCodonBatches;

            for (var k = 0; k < numberOfStopCodonBatches; k++)
            {
                var batchStartIndex = Randomizer.Next(0, allCodons.Count - numberOfStopCodonsPerBatch);

                for (var i = batchStartIndex; i < batchStartIndex + numberOfStopCodonsPerBatch; i++)
                {
                    var codonIdentifier = allCodons[i];
                    this.SetCodonType(codonIdentifier, codonType: CodonType.Stop);
                }
            }
        }

        /// <summary>
        /// Creates an IGEPCodon for the given IFunctionPair and INucleotide Sequence.
        /// 
        /// Adds the IGEPCodon to the IGEPGeneticCode.
        /// </summary>
        /// <param name="functionPair"></param>
        /// <param name="nucleotideSequence"></param>
        private void AddCodonFunctionPair(IFunctionPair functionPair, INucleotide[] nucleotideSequence, Action onCodonAdded = null)
        {
            var codon = new GEPCodon(geneticCode: this,
                                     codonIdentifier: new CodonIdentifier(nucleotideSequence.Select(n => n.Identifier.ToString()).ConcatContents()),
                                     codonType: CodonType.Standard,
                                     nucleotides: nucleotideSequence, 
                                     functions: functionPair);

            this.AddCodon(codon);

            if (onCodonAdded != null)
                onCodonAdded();
        }


    }
}
