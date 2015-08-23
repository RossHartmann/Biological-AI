using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Models.Models.GeneticCodes.Codons;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Presenters.Presenters.GeneticCodes.Codons;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Views.Views.GeneticCodes.Codons;

namespace GeneticFaradayApplication.Presenters.AbstractPresenters.GeneticCodes.Codons
{
    public abstract class CodonsPresenterBase : PresenterBase<ICodonsView, ICodonsModel>, ICodonsPresenter
    {
        /// <summary>
        /// The unique name of the genetic code.
        /// </summary>
        public string GeneticCodeName { get; set; }

        protected CodonsPresenterBase(string geneticCodeName)
            : this(geneticCodeName, new CodonsView(), new CodonsModel())
        {
        }

        protected CodonsPresenterBase(string geneticCodeName, ICodonsView view, ICodonsModel model) 
            : base(view, model)
        {
            this.View.CreateCodonsRequested += View_CreateCodonsRequested;

            this.GeneticCodeName = geneticCodeName;
        }

        void View_CreateCodonsRequested(object sender, EventArgs e)
        {
            var codonsCreatorPresenter = new CodonsCreatorPresenter(this.GeneticCodeName);
            codonsCreatorPresenter.ShowDialog();
        }
    }
}
