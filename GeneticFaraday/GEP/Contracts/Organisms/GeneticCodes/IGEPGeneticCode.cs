using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;

namespace GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes
{
    public interface IGEPGeneticCode : IGeneticCode
    {
        /// <summary>
        /// A dictionary of all of the valid IFunctions in the IGEPGeneticCode.
        /// </summary>
        SortedList<IFunctionIdentifier, IFunction> FunctionSet { get; }



        /// <summary>
        /// Converts the specified IGEPCodon using the specified ICodonConverterIdentifier.
        /// </summary>
        /// <param name="codon"></param>
        /// <param name="codonConverterIdentifier"></param>
        /// <returns></returns>
        IConvertedCodon ConvertCodon(IGEPCodon codon, ICodonConverterIdentifier codonConverterIdentifier);

        /// <summary>
        /// The maximum number of IFunctions that take parameters 
        /// that can be used in an IAllele's IDNA. After (or before) this 
        /// number of IFunctions (with parameters) have been called, the rest
        /// of the IFunctions in the IDNA will not accept any parameters (i.e. they 
        /// will be terminals).
        /// </summary>
        int MaxParameterfulFunctionsInDNA { get; }


        /// <summary>
        /// The number of IParameters used by the IFunction that has the most parameters.
        /// </summary>
        int MaximumFunctionInputsUsed { get; }

        /// <summary>
        /// The maximum recursion level that's allowable. If this value is reached by an
        /// IGEPGene, the execution of the IGEPGene will be aborted.
        /// </summary>
        int MaxRecursionLevel { get; }


        /// <summary>
        /// The Length of the "head" of a sequence of IDNA as measured in INucleotides.
        /// The "head" can use IFunctions with or without Parameters.
        /// </summary>
        int DNAHeadLength { get; }

        /// <summary>
        /// The Length of the "tail" of a sequence of IDNA as measured in INucleotides.
        /// The "tail" can only use IFunctions without Parameters.
        /// </summary>
        int DNATailLength { get; }

        /// <summary>
        /// The length of all IDNA.
        /// </summary>
        int DNALength { get; }

        /// <summary>
        /// Adds the specified ICodon to the IGEPGeneticCode.
        /// 
        /// The given ICodon must be an IGEPCodon.
        /// </summary>
        /// <param name="codon"></param>
        new void AddCodon(ICodon codon);

        /// <summary>
        /// Adds the specified IGEPCodon to the IGEPGeneticCode.
        /// </summary>
        /// <param name="codon"></param>
        void AddCodon(IGEPCodon codon);

        /// <summary>
        /// Adds the specified IFunctions to the IGEPGeneticCode.
        /// </summary>
        /// <param name="functions"></param>
        void AddFunctions(IEnumerable<IFunction> functions);

        /// <summary>
        /// Adds the specified IFunction to the IGEPGeneticCode.
        /// </summary>
        /// <param name="function"></param>
        void AddFunction(IFunction function);

        /// <summary>
        /// Retrieves the first IGEPCodon of the specified CodonType that primarily 
        /// encodes for the IFunction as identified
        /// by the given IFunctionIdentifier.
        /// </summary>
        /// <param name="functionIdentifier"></param>
        /// <param name="codonType"></param>
        /// <returns></returns>
        IGEPCodon GetCodonEncodingFunction(IFunctionIdentifier functionIdentifier, CodonType codonType = CodonType.Standard);

        /// <summary>
        /// Returns all of the Parameterless IFunctions in the IGEPGeneticCode.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IFunction> GetParameterlessFunctions();

        /// <summary>
        /// Creates this IGEPGeneticCode based on the current INucleotides and IFunctions in the IGEPGeneticCode.
        /// </summary>
        /// <param name="percentageStopCodons">The percentage of the total IGEPCodons that will be Stop IGEPCodons.</param>
        /// <param name="redundancyRating">A redundancy rating of 0 means that each IFunction with a Weight of 1 will not be repeated before the next IFunction is added. 
        /// A redundancy rating of 0 means that an IFunction Weight of 1 will result in adding one IFunction and then moving to the next when going from one ICodon to the next.
        /// 
        /// A redundancy rating of 1 means that each function with a Weight of 1 will be repeated once before moving to the next codon.
        /// </param>
        /// <param name="onCodonAdded">The function to call when a Codon is added.</param>
        void AutoAssignCodonsToAminoAcids(double percentageStopCodons, int redundancyRating = 10, Action onCodonAdded = null);
    }
}
