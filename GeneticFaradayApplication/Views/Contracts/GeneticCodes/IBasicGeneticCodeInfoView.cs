using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaradayApplication.Views.Contracts.GeneticCodes
{
    public interface IBasicGeneticCodeInfoView
    {
        /// <summary>
        /// The unique name of the Genetic Code.
        /// </summary>
        string GeneticCodeName { get; set; }

        /// <summary>
        /// The length of every Codon in the Genetic Code. All Codons must be of this length.
        /// </summary>
        int CodonLength { get; set; }

        /// <summary>
        /// The maximum number of IFunctions that take parameters 
        /// that can be used in an IAllele's IDNA. After (or before) this 
        /// number of IFunctions (with parameters) have been called, the rest
        /// of the IFunctions in the IDNA will not accept any parameters (i.e. they 
        /// will be terminals).
        /// </summary>
        int MaxParameterfulFunctionsInDNA { get; set; }

        /// <summary>
        /// The maximum recursion level that's allowable. If this value is reached by an
        /// IGEPGene, the execution of the IGEPGene will be aborted.
        /// </summary>
        int MaxRecursionLevel { get; set; }

        int DNAHeadLength { get; set; }
        int DNATailLength { get; set; }
        int DNATotalLength { get; set; }
    }
}
