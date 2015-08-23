using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.GEP.AbstractModels.Environment.GeneticOperators.MutationOperators;
using GeneticFaraday.GEP.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Utility;

namespace GeneticFaraday.GEP.Models.Environment.GeneticOperators.MutationOperators
{
    /// <summary>
    /// Mutates a number of INucleotides (as randomly determined by the
    /// minimum and maximum) in the IGEPOrganism's Main IGEPGene.
    /// </summary>
    public class GEPMainGeneRandomizeNucleotides : GEPMutationOperatorBase
    {
        /// <summary>
        /// The minimum number of INucleotides that can be mutated.
        /// </summary>
        public int MinimumNucleotidesToMutate { get; set; }
        /// <summary>
        /// The maximum number of INucleotides that can be mutated.
        /// </summary>
        public int MaximumNucleotidesToMutate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chanceOfUseRating"></param>
        /// <param name="minimumNucleotidesToMutate">The minimum number of INucleotides that can be mutated.</param>
        /// <param name="maximumNucleotidesToMutate">The maximum number of INucleotides that can be mutated.</param>
        public GEPMainGeneRandomizeNucleotides(int chanceOfUseRating,
            int minimumNucleotidesToMutate, int maximumNucleotidesToMutate)
            : base(chanceOfUseRating)
        {
            this.MinimumNucleotidesToMutate = minimumNucleotidesToMutate;
            this.MaximumNucleotidesToMutate = maximumNucleotidesToMutate;
        }

        public override void Execute(ref IOrganism organism)
        {
            var chromosome = (IGEPChromosome)organism[0];
            var main = chromosome.Main;
            var dna = main.GetActiveAllele().DNA;

            var nucleotidesToMutateCount = Randomizer.Next(this.MinimumNucleotidesToMutate,
                                                           this.MaximumNucleotidesToMutate + 1);

            for (var i = 0; i < nucleotidesToMutateCount; i++)
                dna.RandomlyFlipNucleotide();
        }
    }
}
