using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GeneticFaraday.DatabaseExtensions;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes;
using GeneticFaradayApplication.Models.AbstractModels.GeneticCodes.CodonConverters;
using GeneticFaradayApplication.Models.AbstractModels.GeneticCodes.Codons;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Models.Models.GeneticCodes.Codons;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Presenters.Presenters.GeneticCodes.CodonConverters;
using GeneticFaradayApplication.Presenters.Presenters.GeneticCodes.Functions;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Views.Views.GeneticCodes.Codons;
using UtilityData.SQL;

namespace GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes.Codons
{
    public abstract class CodonsCreatorPresenterBase : PresenterBase<ICodonsCreatorView, ICodonsCreatorModel>, ICodonsCreatorPresenter
    {
        /// <summary>
        /// The unique name of the genetic code.
        /// </summary>
        public string GeneticCodeName { get; set; }

        /// <summary>
        /// The functions for which the Codons will encode.
        /// </summary>
        public List<IFunction> Functions
        {
            get { return this.View.Functions; }
            set { this.View.Functions = value; }
        }

        protected CodonsCreatorPresenterBase(string geneticCodeName)
            : this(geneticCodeName, new CodonsCreatorView(new FunctionsPresenter(), new CodonConvertersPresenter()), new CodonsCreatorModel())
        {
        }

        protected CodonsCreatorPresenterBase(string geneticCodeName, ICodonsCreatorView view, ICodonsCreatorModel model) 
            : base(view, model)
        {
            this.View.FunctionsCreated += View_FunctionsCreated;

            this.View.RedundancyRating = 100;
            this.View.StopCodonPercentage = .01;

            this.GeneticCodeName = geneticCodeName;

            /*
            var nucleotideRow = new NucleotideRow();
            var nucleotides = Qry.SelectAllFrom(nucleotideRow)
                .InnerJoinOn(nucleotideRow.GeneticCodeRowColumn)
                .Where(nucleotideRow.GeneticCodeRow.NameColumn, this.GeneticCodeName)
                .GoAndExtractMultiple<NucleotideRow>();
            if(nucleotides.Count <= 0)
            {
                this.View.ShowError("The Genetic Code must have one or more Nucleotides before creating Codons.",
                                    "Missing Nucleotides");
                return;
            }
             */
        }

        void View_FunctionsCreated(object sender, EventArgs e)
        {
            MessageBox.Show("Creating Codons...", "Please Wait", MessageBoxButton.OK, MessageBoxImage.Information);

            this.View.DisableControls();

            /*
            var task = new Task(() =>
                                    {

                                        var geneticCodeRow = new GeneticCodeRow();
                                        Qry.SelectAllFrom(geneticCodeRow)
                                            .Where(geneticCodeRow.NameColumn, this.GeneticCodeName)
                                            .GoAndExtract(ref geneticCodeRow);

                                        var nucleotideRow = new NucleotideRow();
                                        var nucleotides = Qry.SelectAllFrom(nucleotideRow)
                                            .Where(nucleotideRow.GeneticCodeColumn, geneticCodeRow.PrimaryKey)
                                            .GoAndExtractMultiple<NucleotideRow>()
                                            .Select(r => r.ToNucleotide())
                                            .ToList();

                                        if (nucleotides.Count <= 0)
                                        {
                                            this.View.ShowError("The Genetic Code must have one or more Nucleotides before creating Codons.",
                                                                "Missing Nucleotides");
                                            return;
                                        }

                                        var geneticCode = new GEPGeneticCodeUsingDatabase(geneticCodePrimaryKey: geneticCodeRow.PrimaryKey,
                                            codonLength: geneticCodeRow.CodonLength,
                                            maxParameterfulFunctionsInDNA: geneticCodeRow.MaxParameterfulFunctionsInDNA);

                                        foreach (var nucleotide in nucleotides)
                                            geneticCode.AddNucleotide(nucleotide);


                                        DM.GeneticCode.DeleteAllDependentRows(geneticCodePrimaryKey: geneticCodeRow.PrimaryKey);


                                        // delete all codon converters from the genetic code
                                        // add all new codon converters
                                        var codonConverterIdentifiers = this.View.CodonConvertersPresenter.View.SelectedCodonConverters;
                                        foreach (var codonConverterIdentifier in codonConverterIdentifiers)
                                        {
                                            var codonConverter = CodonConvertersModelBase.GetCodonConverter(codonConverterIdentifier);
                                            geneticCode.AddCodonConverter(codonConverter);
                                            var codonConverterRow = codonConverter.ToCodonConverterRow(geneticCodeRow.PrimaryKey);
                                            codonConverterRow.InsertOnlyIfNecessary();
                                        }

                                        // Delete all functions from the genetic code
                                        // add all new functions
                                        foreach (var function in this.Functions)
                                        {
                                            geneticCode.AddFunction(function);
                                            var functionRow = function.ToFunctionRow(geneticCodeRow.PrimaryKey);
                                            functionRow.InsertOnlyIfNecessary();

                                            var i = 0;
                                            foreach (var parameter in function)
                                            {
                                                var parameterRow = parameter.ToParameterRow(parameterIndex: i,
                                                                                            functionPrimaryKey: functionRow.PrimaryKey,
                                                                                            geneticCodePrimaryKey: geneticCodeRow.PrimaryKey);
                                                parameterRow.InsertOnlyIfNecessary();
                                                i++;
                                            }

                                            if (function.AvailableRegistries != null)
                                            {
                                                foreach (var registry in function.AvailableRegistries)
                                                {
                                                    var registryRow = registry.ToFunctionRegistryRow(functionPrimaryKey: functionRow.PrimaryKey,
                                                                                                     geneticCodePrimaryKey: geneticCodeRow.PrimaryKey);
                                                    registryRow.InsertOnlyIfNecessary();
                                                }
                                            }
                                        }

                                        this.View.MaxCodonCount = Math.Pow(nucleotides.Count, geneticCodeRow.CodonLength);

                                        geneticCode.AutoAssignCodonsToAminoAcids(percentageStopCodons: this.View.StopCodonPercentage,
                                                                                 redundancyRating: this.View.RedundancyRating,
                                                                                 onCodonAdded: () => this.View.CurrentCodonsCreated++);

                                        this.View.Close();
                                    });

            task.Start();
             */

        }
    }
}

