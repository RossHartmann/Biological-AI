using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Models.Exceptions;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.Codons
{
    public abstract class GEPCodonBase : CodonBase, IGEPCodon
    {
        protected GEPCodonBase(IGEPGeneticCode geneticCode, ICodonIdentifier codonIdentifier, 
            CodonType codonType, IEnumerable<INucleotideIdentifier> nucleotides, IFunctionPair functions) 
            : base(geneticCode, codonIdentifier, codonType, nucleotides)
        {
            this.Functions = functions;
        }

        protected GEPCodonBase(IGEPGeneticCode geneticCode, ICodonIdentifier codonIdentifier, 
            CodonType codonType, IEnumerable<INucleotide> nucleotides, IFunctionPair functions) 
            : base(geneticCode, codonIdentifier, codonType, nucleotides)
        {
            this.Functions = functions;
        }

        /// <summary>
        /// The pair of IFunctions for which this ICodon encodes.
        /// </summary>
        public IFunctionPair Functions { get; private set; }

        public override string ToString()
        {
            return base.ToString() + ", " + this.Functions.ToString();
        }
    }
}
