using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes;

namespace GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes
{
    public abstract class GeneticCodeCreatorPresenterBase : PresenterBase<IGeneticCodeCreatorView, IGeneticCodeCreatorModel>, IGeneticCodeCreatorPresenter
    {
        protected GeneticCodeCreatorPresenterBase(IGeneticCodeCreatorView view, IGeneticCodeCreatorModel model) 
            : base(view, model)
        {
            this.View.OKButtonClicked += View_OKButtonClicked;
            this.View.CloseRequested += View_OKButtonClicked;
        }

        void View_OKButtonClicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.View.GeneticCodeName))
            {
                this.View.ShowError("A Genetic Code Name must be provided.", "Invalid Genetic Code Name");
                return;
            }
            /*
            // Create the genetic code if necessary. If it wasn't inserted, alert error.
            var geneticCodeRow = new GeneticCodeRow(name: this.View.GeneticCodeName, codonLength: this.View.CodonLength,
                                                    maxParameterfulFunctionsInDNA:
                                                        this.View.MaxParameterfulFunctionsInDNA,
                                                    maximumFunctionInputsUsed: 0,
                                                    maxRecursionLevel: this.View.MaxRecursionLevel);
            var inserted = geneticCodeRow.InsertOnlyIfNecessary();
            
            if (!inserted)
            {
                this.View.ShowError("A Genetic Code with the name " + this.View.GeneticCodeName + " already exists.",
                                    "Duplicate Genetic Code");
                return;
            }

            this.Model.GeneticCodePrimaryKey = geneticCodeRow.PrimaryKey;
            */
            this.View.Close();
        }

        public override void UpdateViewFromModel()
        {
            throw new NotImplementedException();
        }
    }
}
