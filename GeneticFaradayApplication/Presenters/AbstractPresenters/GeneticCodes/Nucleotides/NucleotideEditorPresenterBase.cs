using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Models.Organisms.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Models.Models.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Repositories.Contracts;
using GeneticFaradayApplication.Repositories.Repositories;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Views.Views.GeneticCodes.Nucleotides;
using GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows;
using UtilityData.SQL;

namespace GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes.Nucleotides
{
    public abstract class NucleotideEditorPresenterBase : PresenterBase<INucleotideEditorView, INucleotideEditorModel>, INucleotideEditorPresenter
    {
        public string GeneticCodeName { get; protected set; }

        public bool SavedSuccessfully { get; protected set; }

        public bool EditingExistingNucleotide { get; protected set; }

        protected INucleotideEditorModel OriginalModel { get; set; }

        protected NucleotideEditorPresenterBase(string geneticCodeName, bool editingExistingNucleotide)
            : this(new NucleotideEditorView(), new NucleotideEditorModel(), geneticCodeName: geneticCodeName, editingExistingNucleotide: editingExistingNucleotide)
        {
        }

        protected NucleotideEditorPresenterBase(INucleotideEditorView view, INucleotideEditorModel model,
            string geneticCodeName, bool editingExistingNucleotide) 
            : base(view, model)
        {
            this.GeneticCodeName = geneticCodeName;
            this.EditingExistingNucleotide = editingExistingNucleotide;

            this.View.CloseRequested += View_CloseRequested;
            this.View.SaveRequested += View_SaveRequested;

            if (this.EditingExistingNucleotide)
            {
                this.OriginalModel = this.Model.ShallowCopy();
                this.UpdateViewFromModel();
            }
        }

        public override void UpdateViewFromModel()
        {
            this.View.NucleotideIdentifier = this.Model.Nucleotide.Identifier.ToString();
        }

        public override void UpdateModelFromView()
        {
            if(this.Model.GeneticCodePrimaryKey == null)
            {
                var geneticCodeRow = new GeneticCodeRow();
                Qry.SelectPrimaryKeyFrom(geneticCodeRow)
                    .Where(geneticCodeRow.NameColumn, this.GeneticCodeName)
                    .GoAndExtract(ref geneticCodeRow);
                this.Model.GeneticCodePrimaryKey = geneticCodeRow.PrimaryKey;
            }

            this.Model.GeneticCodeName = this.GeneticCodeName;
            this.Model.Nucleotide = new Nucleotide(new NucleotideIdentifier(this.View.NucleotideIdentifier));
        }

        void View_SaveRequested(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.View.NucleotideIdentifier))
            {
                this.View.ShowError("A Nucleotide Identifier must be provided.", "Invalid Nucleotide Identifier.");
                return;
            }

            this.UpdateModelFromView();

            if(this.EditingExistingNucleotide)
            {
                // If we're editing a Nucleotide but the value didn't change from the original editing, we don't need
                // to save the Nucleotide.
                if(this.OriginalModel.Nucleotide.Identifier.Equals(this.Model.Nucleotide.Identifier))
                {
                    this.View.Close();
                    return;
                }

                this.Model.Delete(this.OriginalModel, new RepositoryArgs(RepositoryType.Database));
            }
            
            this.Model.Save(this.Model, new RepositoryArgs(RepositoryType.Database));
            this.SavedSuccessfully = true;
            this.View.Close();
        }

        void View_CloseRequested(object sender, EventArgs e)
        {
            this.Model = null;
            this.View.Close();
        }

        
    }
}