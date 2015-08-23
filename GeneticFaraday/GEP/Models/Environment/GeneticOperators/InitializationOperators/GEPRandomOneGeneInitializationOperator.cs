using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Environment.GeneticOperators.InitializationOperators;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms;
using GeneticFaraday.GEP.Models.Organisms;
using GeneticFaraday.GEP.Models.Organisms.Chromosomes;
using GeneticFaraday.GEP.Models.Organisms.Genes;
using GeneticFaraday.GEP.Models.Organisms.Genes.Alleles;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.DNAs;

namespace GeneticFaraday.GEP.Models.Environment.GeneticOperators.InitializationOperators
{
    /// <summary>
    /// Creates 1 IGEPOrganism with 1 IGEPChromosome and 1 IGEPGene.
    /// </summary>
    public class GEPRandomOneGeneInitializationOperator : GEPInitializationOperatorBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chanceOfUseRating">This is simply a number which indicates the relative chance that this
        /// IGeneticOperator will be used among the list of all of the possible
        /// IGeneticOperator of its type.
        /// 
        /// To determine the real percentage chance that this IGeneticOperator
        /// will be chosen, we sum all of the IGeneticOperator's ChanceOfUseRating then
        /// we divide this ChanceOfUseRating by the total ChanceOfUseRating of all 
        /// IGeneticOperators of its type.
        /// 
        /// This is simply a number such as 15. (This does not mean that it will be chosen
        /// 15% of the time). If there is only one other GeneticOperator and its
        /// ChanceOfUseRating is 15 then both of their chances is 50% (15/30)
        /// 
        /// See the ChanceOfUse for the percentage of the time that this GeneticOperator
        /// will be chosen.</param>
        public GEPRandomOneGeneInitializationOperator(int chanceOfUseRating) 
            : base(chanceOfUseRating)
        {
        }

        public override List<IGEPOrganism> Execute(IGEPEnvironment environment)
        {
            var dna = new GEPDNA();
            var allele = new GEPAllele(dna);
            var main = new GEPGene(environment: environment);
            main.Add(allele);

            var chromosome = new GEPChromosome(environment: environment, main: main);

            var organism = new GEPOrganism(environment: environment) { chromosome };
            organism.Parent = environment;

            for (var i = 0; i < environment.GeneticCode.DNALength; i++)
                allele.DNA.AddRandomNucleotide();




            /*
            var testAllele = new GEPAllele(new GEPDNA());
            var testGene = new GEPGene(environment: environment);
            testGene.Add(testAllele);
            main.Add(testGene);
            for (var i = 0; i < environment.GeneticCode.DNALength; i++)
                testAllele.DNA.AddRandomNucleotide();

            var test2Allele = new GEPAllele(new GEPDNA());
            var test2Gene = new GEPGene(environment: environment);
            test2Gene.Add(test2Allele);
            main.Add(test2Gene);
            for (var i = 0; i < environment.GeneticCode.DNALength; i++)
                test2Allele.DNA.AddRandomNucleotide();

            var test3Allele = new GEPAllele(new GEPDNA());
            var test3Gene = new GEPGene(environment: environment);
            test3Gene.Add(test3Allele);
            test2Gene.Add(test3Gene);
            for (var i = 0; i < environment.GeneticCode.DNALength; i++)
                test3Allele.DNA.AddRandomNucleotide();

            var test4Allele = new GEPAllele(new GEPDNA());
            var test4Gene = new GEPGene(environment: environment);
            test4Gene.Add(test4Allele);
            main.Add(test4Gene);
            for (var i = 0; i < environment.GeneticCode.DNALength; i++)
                test4Allele.DNA.AddRandomNucleotide();

            var test5Allele = new GEPAllele(new GEPDNA());
            var test5Gene = new GEPGene(environment: environment);
            test5Gene.Add(test5Allele);
            test3Gene.Add(test5Gene);
            for (var i = 0; i < environment.GeneticCode.DNALength; i++)
                test5Allele.DNA.AddRandomNucleotide();
            */


            return new List<IGEPOrganism>() { organism };
        }
    }
}
