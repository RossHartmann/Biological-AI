using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;

namespace GeneticFaraday.Models.Organisms.GeneticCodes.Codons
{
    public class GEPCodon : GEPCodonBase
    {
        public GEPCodon(IGEPGeneticCode geneticCode, ICodonIdentifier codonIdentifier, CodonType codonType, 
            IEnumerable<INucleotideIdentifier> nucleotides, IFunctionPair functions) 
            : base(geneticCode, codonIdentifier, codonType, nucleotides, functions)
        {
        }

        public GEPCodon(IGEPGeneticCode geneticCode, ICodonIdentifier codonIdentifier, CodonType codonType, 
            IEnumerable<INucleotide> nucleotides, IFunctionPair functions) 
            : base(geneticCode, codonIdentifier, codonType, nucleotides, functions)
        {
        }
    }
}
