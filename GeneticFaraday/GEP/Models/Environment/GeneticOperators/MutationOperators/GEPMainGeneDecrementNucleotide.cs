﻿using System;
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
    /// Decrements 1 INucleotide in the IGEPOrganism's Main IGEPGene.
    /// </summary>
    public class GEPMainGeneDecrementNucleotide : GEPMutationOperatorBase
    {
        public GEPMainGeneDecrementNucleotide(int chanceOfUseRating)
            : base(chanceOfUseRating)
        {
        }

        public override void Execute(ref IOrganism organism)
        {
            var chromosome = (IGEPChromosome)organism[0];
            var main = chromosome.Main;
            var activeAlleleDNA = main.GetActiveAllele().DNA;
            activeAlleleDNA.DecrementNucleotide(activeAlleleDNA.RandomIndex());
        }
    }
}
