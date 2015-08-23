using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Contracts.Registries;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Models.Models.GeneticCodes.Functions;
using GeneticFaradayApplication.Repositories.Contracts;
using UtilityData.Exceptions.DatabaseExceptions;

namespace GeneticFaradayApplication.Models.AbstractModels.GeneticCodes.Functions
{
    public abstract class FunctionsModelBase : IFunctionsModel
    {
        public List<IFunctionBaseIdentifier> AvailableFunctions { get; private set; }

        protected FunctionsModelBase()
        {
            this.AvailableFunctions = FunctionsModelBase.GetFunctionBaseIdentifiers();
        }

        public static List<IFunctionBaseIdentifier> GetFunctionBaseIdentifiers()
        {
            return new List<IFunctionBaseIdentifier>
                                              {
                                                  new FunctionBaseIdentifier("ReadRegistry", "Read Registry"),
                                                  new FunctionBaseIdentifier("WriteRegistry", "Write Registry"),
                                                  new FunctionBaseIdentifier("Sum", "Arithmetic"),
                                                  new FunctionBaseIdentifier("Difference", "Arithmetic"),
                                                  new FunctionBaseIdentifier("Multiply", "Arithmetic"),
                                                  new FunctionBaseIdentifier("Divide", "Arithmetic"),
                                                  new FunctionBaseIdentifier("Square", "Arithmetic"),
                                                  new FunctionBaseIdentifier("Power", "Arithmetic"),
                                                  new FunctionBaseIdentifier("SquareRoot", "Arithmetic"),
                                                  new FunctionBaseIdentifier("Negate", "Arithmetic"),
                                                  new FunctionBaseIdentifier("ForceNegate", "Arithmetic"),
                                                  new FunctionBaseIdentifier("Absolute", "Arithmetic"),
                                                  new FunctionBaseIdentifier("RoundToNearestWholeNumber", "Arithmetic"),
                                                  new FunctionBaseIdentifier("Successor", "Arithmetic"),
                                                  new FunctionBaseIdentifier("Predecessor", "Arithmetic"),
                                                  new FunctionBaseIdentifier("Constants", "Constants")
                                              };
        }

        public static List<IFunction> GetFunctions(IRegistryIdentifier[] allWriteableRegistryIdentifiers, IRegistryIdentifier[] allRegistryIdentifiers,
            ICodonConverterIdentifier[] codonConverters, IFunctionBaseIdentifier functionBaseIdentifier)
        {
            var identifier = functionBaseIdentifier.Identifier;
            if(identifier == "ReadRegistry")
            {
                return GeneticFaraday.GEP.Functions.Functions.IRegistryRead.GetReadFunctions(
                    allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: allRegistryIdentifiers,
                    codonConverters: codonConverters, weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else if(identifier == "WriteRegistry")
            {
                return GeneticFaraday.GEP.Functions.Functions.IRegistryWrite.GetWriteFunctions(allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: allRegistryIdentifiers,
                    codonConverters: codonConverters, weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else if (identifier == "Sum")
            {
                return GeneticFaraday.GEP.Functions.Functions.Arithmetic.GetSumFunctions(
                    allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: allRegistryIdentifiers,
                    codonConverters: codonConverters, weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else if (identifier == "Difference")
            {
                return GeneticFaraday.GEP.Functions.Functions.Arithmetic.GetDifferenceFunctions(allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: allRegistryIdentifiers,
                    codonConverters: codonConverters, weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else if (identifier == "Multiply")
            {
                return GeneticFaraday.GEP.Functions.Functions.Arithmetic.GetMultiplyFunctions(allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: allRegistryIdentifiers,
                    codonConverters: codonConverters, weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else if (identifier == "Divide")
            {
                return GeneticFaraday.GEP.Functions.Functions.Arithmetic.GetDivideFunctions(allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: allRegistryIdentifiers,
                    codonConverters: codonConverters, weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else if (identifier == "Square")
            {
                return GeneticFaraday.GEP.Functions.Functions.Arithmetic.GetSquareFunctions(allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: allRegistryIdentifiers,
                    codonConverters: codonConverters, weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else if (identifier == "Power")
            {
                return GeneticFaraday.GEP.Functions.Functions.Arithmetic.GetPowerFunctions(allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: allRegistryIdentifiers,
                    codonConverters: codonConverters, weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else if (identifier == "SquareRoot")
            {
                return GeneticFaraday.GEP.Functions.Functions.Arithmetic.GetSquareRootFunctions(allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: allRegistryIdentifiers,
                    codonConverters: codonConverters, weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else if (identifier == "Negate")
            {
                return GeneticFaraday.GEP.Functions.Functions.Arithmetic.GetNegateFunctions(allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: allRegistryIdentifiers,
                    codonConverters: codonConverters, weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else if (identifier == "ForceNegate")
            {
                return GeneticFaraday.GEP.Functions.Functions.Arithmetic.GetForceNegateFunctions(allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: allRegistryIdentifiers,
                    codonConverters: codonConverters, weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else if (identifier == "Absolute")
            {
                return GeneticFaraday.GEP.Functions.Functions.Arithmetic.GetAbsoluteFunctions(allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: allRegistryIdentifiers,
                    codonConverters: codonConverters, weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else if (identifier == "RoundToNearestWholeNumber")
            {
                return GeneticFaraday.GEP.Functions.Functions.Arithmetic.GetRoundToNearestWholeNumberFunctions(allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: allRegistryIdentifiers,
                    codonConverters: codonConverters, weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else if (identifier == "Successor")
            {
                return GeneticFaraday.GEP.Functions.Functions.Arithmetic.GetSuccessorFunctions(allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: allRegistryIdentifiers,
                    codonConverters: codonConverters, weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else if (identifier == "Predecessor")
            {
                return GeneticFaraday.GEP.Functions.Functions.Arithmetic.GetPredecessorFunctions(allWriteableRegistryIdentifiers: allWriteableRegistryIdentifiers,
                    allRegistryIdentifiers: allRegistryIdentifiers,
                    codonConverters: codonConverters, weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else if (identifier == "Constants")
            {
                return GeneticFaraday.GEP.Functions.Functions.Constants.GetConstantsFunctions(weightInGeneticCode: functionBaseIdentifier.WeightInGeneticCode);
            }
            else
            {
                throw new ValueNotYetSupported(identifier, typeof(IFunctionBaseIdentifier));
            }
        }

        public IFunctionsModel Load(IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Save(IFunctionsModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void Delete(IFunctionsModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            throw new NotImplementedException();
        }

        
    }
}
