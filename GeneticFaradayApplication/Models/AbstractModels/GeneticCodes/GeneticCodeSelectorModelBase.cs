using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes;
using GeneticFaradayApplication.Models.Models.GeneticCodes;
using GeneticFaradayApplication.Repositories.Contracts;
using UtilityData.SQL;

namespace GeneticFaradayApplication.Models.AbstractModels.GeneticCodes
{
    public abstract class GeneticCodeSelectorModelBase : IGeneticCodeSelectorModel
    {
        /// <summary>
        /// The names of the Genetic Codes from which the user can select.
        /// </summary>
        public string[] AvailableGeneticCodeNames { get; protected set; }

        protected GeneticCodeSelectorModelBase()
        {
            /*
            this.AvailableGeneticCodeNames = Qry.SelectFrom(DM.GeneticCode.Name)
                                                .Go()
                                                .GetValuesInColumn(DM.GeneticCode.Name)
                                                .Select(o => o.ToString())
                                                .ToArray();
             */
        }

        public IGeneticCodeSelectorModel Load(IRepositoryArgs args)
        {
            return new GeneticCodeSelectorModel();
        }

        public void Save(IGeneticCodeSelectorModel model, IRepositoryArgs args)
        {
        }

        public void Delete(IGeneticCodeSelectorModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void New()
        {
        }
    }
}
