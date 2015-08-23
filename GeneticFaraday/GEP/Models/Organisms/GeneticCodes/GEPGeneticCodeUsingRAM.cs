using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.Utility;

namespace GeneticFaraday.GEP.Models.Organisms.GeneticCodes
{
    /// <summary>
    /// a GEPGeneticCode that stores Codons in a sorted list.
    /// </summary>
    public class GEPGeneticCodeUsingRAM : GEPGeneticCodeBase
    {
        public SortedList<ICodonIdentifier, IGEPCodon> Codons { get; private set; }

        public GEPGeneticCodeUsingRAM() : base()
        {
            this.Codons = new SortedList<ICodonIdentifier, IGEPCodon>();
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
        public GEPGeneticCodeUsingRAM(int codonLength, int maxParameterfulFunctionsInDNA, int maxRecursionLevel = 2)
            : base(codonLength: codonLength, maxParameterfulFunctionsInDNA: maxParameterfulFunctionsInDNA, maxRecursionLevel: maxRecursionLevel)
        {
            this.Codons = new SortedList<ICodonIdentifier, IGEPCodon>();
        }

        public override ICodon GetCodon(ICodonIdentifier codonIdentifier)
        {
            return this.Codons[codonIdentifier];
        }

        public override void AddCodon(ICodon codon)
        {
            this.AddCodon((IGEPCodon) codon);
        }

        public override void AddCodon(IGEPCodon codon)
        {
            this.Codons.Add(codon.CodonIdentifier, codon);
        }

        public override IGEPCodon GetCodonEncodingFunction(IFunctionIdentifier functionIdentifier, CodonType codonType = CodonType.Standard)
        {
            return this.Codons.FirstOrDefault(c => c.Value.CodonType == codonType && c.Value.Functions.PrimaryFunction.Equals(functionIdentifier)).Value;
        }

        public override IEnumerable<ICodon> GetStopCodons()
        {
            return this.Codons.Values.Where(c => c.CodonType == CodonType.Stop);
        }

        public override ICodon GetRandomCodon()
        {
            return this.Codons.Values.RandomElement();
        }

        public override List<ICodonIdentifier> GetAllCodonIdentifiers()
        {
            return this.Codons.Keys.ToList();
        }

        public override void SetCodonType(ICodonIdentifier codonIdentifier, CodonType codonType)
        {
            this.Codons[codonIdentifier].CodonType = codonType;
        }
    }
}
