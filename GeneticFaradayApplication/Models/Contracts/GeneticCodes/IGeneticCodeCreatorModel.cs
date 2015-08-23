using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaradayApplication.Models.Contracts.GeneticCodes
{
    public interface IGeneticCodeCreatorModel : IModel<IGeneticCodeCreatorModel>
    {
        /// <summary>
        /// The Primary Key of the GeneticCode that was created.
        /// </summary>
        int? GeneticCodePrimaryKey { get; set; }
    }
}
