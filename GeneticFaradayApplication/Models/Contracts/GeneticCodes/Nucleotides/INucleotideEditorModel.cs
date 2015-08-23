using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;

namespace GeneticFaradayApplication.Models.Contracts.GeneticCodes.Nucleotides
{
    public interface INucleotideEditorModel : IModel<INucleotideEditorModel>, IShallowCopyable<INucleotideEditorModel>
    {
        /// <summary>
        /// The INucleotide.
        /// </summary>
        INucleotide Nucleotide { get; set; }

        /// <summary>
        /// The name of the owning Genetic Code.
        /// </summary>
        string GeneticCodeName { get; set; }

        /// <summary>
        /// The Primary key of the Genetic Code to which the Nucleotide belongs.
        /// </summary>
        int? GeneticCodePrimaryKey { get; set; }
    }
}
