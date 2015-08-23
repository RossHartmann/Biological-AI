using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Repositories.Contracts;

namespace GeneticFaradayApplication.Models.AbstractModels.GeneticCodes.Functions
{
    public abstract class FunctionBaseIdentifierBase : IFunctionBaseIdentifier
    {
        public string AreaOfInterest { get; set; }
        public double WeightInGeneticCode { get; set; }

        public string Identifier { get; set; }

        protected FunctionBaseIdentifierBase(string identifier, string areaOfInterest, double weightInGeneticCode = 1)
        {
            this.Identifier = identifier;
            this.WeightInGeneticCode = weightInGeneticCode;
            this.AreaOfInterest = areaOfInterest;
        }

        public IFunctionBaseIdentifier Load(IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Save(IFunctionBaseIdentifier model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Delete(IFunctionBaseIdentifier model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return this.AreaOfInterest + " - " + this.Identifier;
        }
    }
}
