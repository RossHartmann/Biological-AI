using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.Contracts.Organisms.Genomes;
using GeneticFaraday.Models.Organisms.Genomes;

namespace GeneticFaraday.AbstractModels.Organisms.Genomes
{
    public abstract class GenomeBase : List<IGenomeUnit>, IGenome
    {
        /// <summary>
        /// The IGeneticCode to which this IGenome adheres.
        /// </summary>
        public IGeneticCode GeneticCode { get; private set; }

        protected GenomeBase(IOrganism organism)
        {
            this.GeneticCode = organism.Parent.GeneticCode;

            this.ConstructFromOrganism(organism: organism);
        }

        protected virtual void ConstructFromOrganism(IOrganism organism)
        {
            this.Clear();
            var chromosomeIndex = 0;
            foreach(var chromosome in organism)
            {
                var geneLevel = 0;
                foreach (var gene in chromosome)
                    this.FillGenomeUnits(currentGene: gene, chromosomeIndex: chromosomeIndex, geneLevel: ref geneLevel);
                

                chromosomeIndex++;
            }
        }

        protected void FillGenomeUnits(IGene currentGene, int chromosomeIndex, ref int geneLevel)
        {
            this.Add(new GenomeUnit(activeAllele: currentGene.GetActiveAllele().ShallowCopy(), inactiveAlleles: currentGene.GetInactiveAlleles().Select(a => a.ShallowCopy()), chromosomeIndex: chromosomeIndex, geneLevel: geneLevel));

            geneLevel++;

            foreach (var childGene in currentGene.GetChildGenes())
                this.FillGenomeUnits(childGene, chromosomeIndex: chromosomeIndex, geneLevel: ref geneLevel);

            geneLevel--;
        }

        /// <summary>
        /// Converts this IGenome into its string representation.
        /// </summary>
        /// <returns></returns>
        public string ToGenomeString()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            var lastChromosomeIndex = -1;
            var stringBuilder = new StringBuilder();
            var i = 0;
            foreach(var unit in this)
            {
                if(unit.ChromosomeIndex != lastChromosomeIndex)
                {
                    if (i != 0)
                        stringBuilder.Append(" }");

                    stringBuilder.Append("{ ");
                    lastChromosomeIndex = unit.ChromosomeIndex;
                }

                stringBuilder.Append("|");
                stringBuilder.Append(unit.ActiveAllele);
                stringBuilder.Append("|");

                i++;
            }

            stringBuilder.Append(" }");

            return stringBuilder.ToString();
        }
        
        public abstract IOrganism ToOrganism(IEnvironment environment);
    }
}
