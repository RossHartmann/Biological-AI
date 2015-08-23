using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.CodonConverters;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Presenters.Presenters.GeneticCodes;
using GeneticFaradayApplication.Repositories.Contracts;
using GeneticFaradayApplication.Repositories.Repositories;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes;

namespace GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes
{
    public abstract class GeneticCodeEditorPresenterBase : PresenterBase<IGeneticCodeEditorView, IGeneticCodeEditorModel>, IGeneticCodeEditorPresenter
    {
        public INucleotidesPresenter NucleotidesPresenter { get { return this.View.NucleotidesPresenter; } }
        public IFunctionsPresenter FunctionsPresenter { get { return this.FunctionsPresenter; } }
        public ICodonsPresenter CodonsPresenter { get { return this.CodonsPresenter; } }
        public ICodonConvertersPresenter CodonConvertersPresenter { get { return this.CodonConvertersPresenter; } }

        protected GeneticCodeEditorPresenterBase(IGeneticCodeEditorView view, IGeneticCodeEditorModel model)
            : base(view: view, model: model)
        {
            this.View.NewGeneticCode += View_NewGeneticCode;
            this.View.LoadGeneticCode += View_LoadGeneticCode;
            this.View.SaveGeneticCode += View_SaveGeneticCode;
            this.View.CloseRequested += View_CloseRequested;

            this.UpdateViewFromModel();
        }

        void View_CloseRequested(object sender, EventArgs e)
        {
            this.View.Close();
        }

        void View_SaveGeneticCode(object sender, EventArgs e)
        {
            // Update the basic information about the genetic code.
            throw new NotImplementedException();
        }

        void View_LoadGeneticCode(object sender, EventArgs e)
        {
            var geneticCodeSelector = new GeneticCodeSelectorPresenter();
            geneticCodeSelector.ShowDialog();

            var selectedGeneticCode = geneticCodeSelector.View.SelectedGeneticCodeName;
            if (!string.IsNullOrEmpty(selectedGeneticCode))
            {
                this.Model = this.Model.Load(new RepositoryArgs(RepositoryType.Database, fileName: null, databaseIdentifiers: new List<string>() { selectedGeneticCode }));
                this.UpdateViewFromModel();
            }
        }

        void View_NewGeneticCode(object sender, EventArgs e)
        {
            this.Model.New();
            this.UpdateViewFromModel();
        }

        /// <summary>
        /// Updates the values in the View to match the Model.
        /// </summary>
        public override void UpdateViewFromModel()
        {
            this.View.GeneticCodeName = this.Model.GeneticCode.Name;
            this.View.CodonLength = this.Model.GeneticCode.CodonLength;
            this.View.MaxParameterfulFunctionsInDNA = this.Model.GeneticCode.MaxParameterfulFunctionsInDNA;
            this.View.MaxRecursionLevel = this.Model.GeneticCode.MaxRecursionLevel;

            this.View.DNAHeadLength = this.Model.GeneticCode.DNAHeadLength;
            this.View.DNATailLength = this.Model.GeneticCode.DNATailLength;
            this.View.DNATotalLength = this.Model.GeneticCode.DNALength;
        }

    }
}

