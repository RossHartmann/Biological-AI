using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GeneticFaraday.DatabaseExtensions;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Models.Models.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Presenters.Presenters.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Repositories.Contracts;
using GeneticFaradayApplication.Repositories.Repositories;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Views.Views.GeneticCodes.Nucleotides;
using GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows;
using GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables;
using UtilityData.SQL;

namespace GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes.Nucleotides
{
    public abstract class NucleotidesPresenterBase : PresenterBase<INucleotidesView, INucleotidesModel>, INucleotidesPresenter
    {
        public string GeneticCodeName { get; protected set; }

        protected NucleotidesPresenterBase(string geneticCodeName)
            : this(new NucleotidesView(), new NucleotidesModel(), geneticCodeName)
        {
        }

        protected NucleotidesPresenterBase(INucleotidesView view, INucleotidesModel model, string geneticCodeName) 
            : base(view, model)
        {
            this.View.AddNucleotideRequested += View_AddNucleotideRequested;
            this.View.RemoveNucleotideRequested += View_RemoveNucleotideRequested;
            this.View.ClearNucleotidesRequested += View_ClearNucleotidesRequested;
            this.View.ViewNucleotideRequested += View_ViewNucleotideRequested;

            this.GeneticCodeName = geneticCodeName;

            this.PopulateNucleotidesOfView();
        }

        private void PopulateNucleotidesOfView()
        {
            var nucleotideRow = new NucleotideRow();
            var nucleotides = Qry.SelectAllFrom(nucleotideRow)
                .InnerJoinSelectingStructuralOn(nucleotideRow.GeneticCodeRowColumn)
                .Where(nucleotideRow.GeneticCodeRow.NameColumn, this.GeneticCodeName)
                .GoAndExtractMultiple<NucleotideRow>();

            foreach(var nucleotide in nucleotides)
            {
                this.View.AddNucleotide(new NucleotideEditorModel(nucleotide.ToNucleotide(),
                                                                  geneticCodeName: this.GeneticCodeName,
                                                                  geneticCodePrimaryKey:
                                                                      nucleotide.GeneticCodeRow.PrimaryKey));
            }
        }

        void View_ClearNucleotidesRequested(object sender, EventArgs e)
        {
            if (this.View.Nucleotides.Length <= 0)
                return;

            if (MessageBox.Show("Are you sure you want to delete all Nucleotides? THIS WILL DELETE ALL CODONS.", "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var geneticCodePrimaryKey = DM.GeneticCode.GetPrimaryKeyFromGeneticCodeName(this.GeneticCodeName);
                foreach (var nucleotide in this.View.Nucleotides)
                {
                    nucleotide.GeneticCodePrimaryKey = geneticCodePrimaryKey;
                    nucleotide.Delete(nucleotide, new RepositoryArgs(RepositoryType.Database));
                }

                DM.GeneticCode.DeleteAllCodonNucleotides(geneticCodePrimaryKey);
                var codonsDeleted = DM.GeneticCode.DeleteAllCodons(geneticCodePrimaryKey);
                MessageBox.Show(codonsDeleted + " Codons were deleted.", "Codons Deleted", MessageBoxButton.OK,
                                MessageBoxImage.Information);

                this.View.ClearNucleotides();
            }
        }

        void View_RemoveNucleotideRequested(object sender, Utilities.EventArgsWithModel<INucleotideEditorModel> e)
        {
            if (MessageBox.Show("Are you sure you want to delete the Nucleotide " + e.Model.Nucleotide.Identifier + "? THIS WILL DELETE ALL CODONS.", "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var geneticCodePrimaryKey = DM.GeneticCode.GetPrimaryKeyFromGeneticCodeName(this.GeneticCodeName);
                DM.GeneticCode.DeleteAllCodonNucleotides(geneticCodePrimaryKey);
                var codonsDeleted = DM.GeneticCode.DeleteAllCodons(geneticCodePrimaryKey);
                MessageBox.Show(codonsDeleted + " Codons were deleted.", "Codons Deleted", MessageBoxButton.OK,
                                MessageBoxImage.Information);

                e.Model.GeneticCodePrimaryKey = geneticCodePrimaryKey;
                e.Model.Delete(e.Model, new RepositoryArgs(RepositoryType.Database));
                this.View.RemoveNucleotide(e.Model);
            }
        }

        void View_AddNucleotideRequested(object sender, EventArgs e)
        {
            var nucleotideEditorPresenter = new NucleotideEditorPresenter(this.GeneticCodeName, editingExistingNucleotide: false);
            nucleotideEditorPresenter.ShowDialog();

            if(nucleotideEditorPresenter.SavedSuccessfully)
            {
                this.View.AddNucleotide(nucleotideEditorPresenter.Model);
            }
        }

        void View_ViewNucleotideRequested(object sender, Utilities.EventArgsWithModel<INucleotideEditorModel> e)
        {
            var nucleotideEditorPresenter = new NucleotideEditorPresenter(model:e.Model, 
                geneticCodeName: this.GeneticCodeName, editingExistingNucleotide: true);
            nucleotideEditorPresenter.ShowDialog();

            if(nucleotideEditorPresenter.SavedSuccessfully)
            {
                this.View.RemoveNucleotide(e.Model);
                this.View.AddNucleotide(nucleotideEditorPresenter.Model.ShallowCopy());
            }
        }
    }
}
