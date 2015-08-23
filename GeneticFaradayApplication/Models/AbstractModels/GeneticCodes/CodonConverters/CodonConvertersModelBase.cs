using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.Models.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.Models.Organisms.GeneticCodes.Codons.CodonConverters.CodonNumberConverters;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.CodonConverters;
using GeneticFaradayApplication.Repositories.Contracts;
using UtilityData.Exceptions.DatabaseExceptions;

namespace GeneticFaradayApplication.Models.AbstractModels.GeneticCodes.CodonConverters
{
    public abstract class CodonConvertersModelBase : ICodonConvertersModel
    {
        public List<ICodonConverterIdentifier> AvailableCodonConverters { get; private set; }

        protected CodonConvertersModelBase()
        {
            this.AvailableCodonConverters = CodonConvertersModelBase.GetCodonConverterIdentifiers();
        }

        public static List<ICodonConverterIdentifier> GetCodonConverterIdentifiers()
        {
            return new List<ICodonConverterIdentifier>
                                              {
                                                  new CodonConverterIdentifier("ConvertCodonToInt3"),
                                                  new CodonConverterIdentifier("ConvertCodonToInt5"),
                                                  new CodonConverterIdentifier("ConvertCodonToInt16"),
                                                  new CodonConverterIdentifier("ConvertCodonToFloat16"),
                                                  new CodonConverterIdentifier("ConvertCodonToDecimal"),
                                              };
        }

        public static ICodonConverter GetCodonConverter(ICodonConverterIdentifier codonConverterIdentifier)
        {
            var identifier = codonConverterIdentifier.ToString();
            if (identifier == "ConvertCodonToInt3")
            {
                return new ConvertCodonToInt3();
            }
            else if (identifier == "ConvertCodonToInt5")
            {
                return new ConvertCodonToInt5();
            }
            else if (identifier == "ConvertCodonToInt16")
            {
                return new ConvertCodonToInt16();
            }
            else if (identifier == "ConvertCodonToFloat16")
            {
                return new ConvertCodonToFloat16();
            }
            else if (identifier == "ConvertCodonToDecimal")
            {
                return new ConvertCodonToDecimal();
            }
            else
            {
                throw new ValueNotYetSupported(identifier, typeof(ICodonConverterIdentifier));
            }
        }


        public ICodonConvertersModel Load(IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Save(ICodonConvertersModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Delete(ICodonConvertersModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            throw new NotImplementedException();
        }

        
    }
}
