﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides
{
    public interface INucleotideIdentifier : IIdentifier, IShallowCopyable<INucleotideIdentifier>, IEquatable<INucleotideIdentifier>, IComparable<INucleotideIdentifier>
    {
    }
}
