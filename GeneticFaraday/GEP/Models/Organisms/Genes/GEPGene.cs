using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.Genes;
using GeneticFaraday.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Behavior;
using GeneticFaraday.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.AbstractModels.Organisms.Genes;
using GeneticFaraday.GEP.AbstractModels.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Environment;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.Genes.Alleles;
using GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Contracts.Registries;
using UtilityData.Exceptions.DatabaseExceptions;

namespace GeneticFaraday.GEP.Models.Organisms.Genes
{
    public class GEPGene : GEPGeneBase
    {
        public GEPGene(IGEPEnvironment environment)
            : base(environment: environment)
        {
        }

        public override IGene ShallowCopy()
        {
            var copy = new GEPGene(this.ParentEnvironment);

            foreach (var childGene in this.ChildGenes)
            {
                var childGeneCopy = childGene.ShallowCopy();
                childGeneCopy.ParentGene = copy;
                copy.Add(childGeneCopy);
            }

            foreach (var allele in this.Alleles)
            {
                var alleleCopy = allele.ShallowCopy();
                alleleCopy.Parent = copy;
                copy.Add(alleleCopy);
            }

            return copy;
        }

        public override IGeneBehavior Behave(IGeneSurroundings surroundings)
        {
            return base.Behave((IGEPGeneSurroundings) surroundings);
        }

        public override IAllele GetActiveAllele()
        {
            return this.Alleles[0] as IGEPAllele;
        }

        public override IEnumerable<IAllele> GetInactiveAlleles()
        {
            return this.Alleles.Skip(1);
        }


        public override IRegistry GetRegistry(IRegistryIdentifier identifier, IGEPGeneSurroundings geneSurroundings)
        {
            if(identifier.Equals(this.ParentEnvironment.GlobalRegistryIdentifier))
            {
                return this.ParentOrganism.GlobalRegistry;
            }
            else if(identifier.Equals(this.ParentEnvironment.LocalGlobalRegistryIdentifier))
            {
                return this.Parent.LocalGlobalRegistry;
            }
            else if(identifier.Equals(this.ParentEnvironment.ResultsRegistryIdentifier))
            {
                return this.ParentOrganism.ResultsRegistry;
            }
            else if(identifier.Equals(this.ParentEnvironment.LocalRegistryIdentifier))
            {
                return this.LocalRegistry;
            }
            else if(identifier.Equals(this.ParentEnvironment.InputRegistryIdentifier))
            {
                return geneSurroundings.ChromosomeSurroundings.OrganismSurroundings.InputRegistry;
            }
            else
            {
                throw new ValueNotYetSupported(identifier, typeof (IRegistryIdentifier));
            }
        }

        
    }
}
