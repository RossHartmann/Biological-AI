﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes.DebuggablePhenomes;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.Phenomes.DebuggablePhenomes
{
    public abstract class DebuggableChromosomeCollectionBase : List<IDebuggableChromosome>, IDebuggableChromosomeCollection
    {
    }
}
