using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.Genomes;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.Chromosomes;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genomes;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms;
using GeneticFaraday.GEP.Contracts.Organisms.Chromosomes;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.Genomes;
using GeneticFaraday.GEP.Models.Organisms;
using GeneticFaraday.GEP.Models.Organisms.Chromosomes;
using GeneticFaraday.GEP.Models.Organisms.Genes;
using GeneticFaraday.Models.Organisms.Genomes;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.Genomes
{
    public abstract class GEPGenomeBase : GenomeBase, IGEPGenome
    {
        protected GEPGenomeBase(IGEPOrganism organism) 
            : base(organism)
        {
        }

        protected override void ConstructFromOrganism(IOrganism organism)
        {
            this.Clear();
            var chromosomeIndex = 0;
            foreach (IGEPChromosome chromosome in organism)
            {
                var geneLevel = 0;
                this.FillGenomeUnits(currentGene: chromosome.Main, chromosomeIndex: chromosomeIndex, geneLevel: ref geneLevel);

                chromosomeIndex++;
            }
        }

        public override IOrganism ToOrganism(IEnvironment environment)
        {
            var gepEnvironment = (IGEPEnvironment) environment;
            var organism = new GEPOrganism(environment: gepEnvironment)
                               {
                                   Parent = gepEnvironment
                               };

            // Get all of the "main" genes.
            var lastChromosomeIndex = -1;
            foreach(var unit in this)
            {
                if(unit.ChromosomeIndex != lastChromosomeIndex)
                {
                    var mainGene = this.CreateGeneFromGenomeUnit(gepEnvironment: gepEnvironment, unit: unit);

                    var chromosome = new GEPChromosome(environment: gepEnvironment, main: mainGene);
                    organism.Add(chromosome);
                    lastChromosomeIndex = unit.ChromosomeIndex;
                }
            }


            var chromosomeIndex = 0;
            foreach (var chromosome in organism)
            {
                var lastProcessedGeneLevel = 1;
                var mainGene = chromosome.Main;
                var lastProcessedGene = mainGene;
                foreach (var unit in this.Where(u => u.ChromosomeIndex == chromosomeIndex && u.GeneLevel >= 1))
                {
                    var gene = this.CreateGeneFromGenomeUnit(gepEnvironment: gepEnvironment, unit: unit);

                    // If we're moving to the next level, add the gene to the next level
                    // and go down to see if there are any others on that level
                    if (unit.GeneLevel > lastProcessedGeneLevel)
                    {
                        lastProcessedGene = (IGEPGene)lastProcessedGene.GetChildGenes().Last();
                        lastProcessedGene.Add(gene);
                    }
                    // if we're up a level, go up to that level and add the gene
                    else if (unit.GeneLevel < lastProcessedGeneLevel)
                    {
                        while(unit.GeneLevel < lastProcessedGeneLevel)
                        {
                            lastProcessedGene = lastProcessedGene.ParentGene;
                            lastProcessedGeneLevel--;
                        }

                        lastProcessedGene.Add(gene);
                    }
                        // if we're at the same level, just add the gene.
                    else
                    {
                        lastProcessedGene.Add(gene);
                    }

                    lastProcessedGeneLevel = unit.GeneLevel;
                }

                chromosomeIndex++;
            }

            return organism;
        }

        private IGEPGene CreateGeneFromGenomeUnit(IGEPEnvironment gepEnvironment, IGenomeUnit unit)
        {
            var gene = new GEPGene(environment: gepEnvironment);
            gene.Add(unit.ActiveAllele);
            foreach (var inactiveAllele in unit.InactiveAlleles)
                gene.Add(inactiveAllele);
            return gene;
        }

    }
}
