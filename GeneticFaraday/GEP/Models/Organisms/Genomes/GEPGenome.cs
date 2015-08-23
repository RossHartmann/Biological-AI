using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.AbstractModels.Organisms.Genomes;
using GeneticFaraday.GEP.Contracts.Organisms;

namespace GeneticFaraday.GEP.Models.Organisms.Genomes
{
    public class GEPGenome : GEPGenomeBase
    {
        public GEPGenome(IGEPOrganism organism) 
            : base(organism)
        {
        }
    }
}
