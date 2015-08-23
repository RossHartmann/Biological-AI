using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes;
using GeneticFaradayApplication.Models.Contracts;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes;
using GeneticFaradayApplication.Models.Models.GeneticCodes;
using GeneticFaradayApplication.Presenters.Presenters.GeneticCodes;
using GeneticFaradayApplication.Repositories.Contracts;
using UtilityData.LINQ;
using UtilityData.SQL;

namespace GeneticFaradayApplication.Models.AbstractModels.GeneticCodes
{
    public abstract class GeneticCodeEditorModelBase : IGeneticCodeEditorModel
    {
        public IGEPGeneticCodeUsingDatabase GeneticCode { get; protected set; }

        protected GeneticCodeEditorModelBase(int geneticCodePrimaryKey)
            : this(geneticCode: new GEPGeneticCodeUsingDatabase(geneticCodePrimaryKey: geneticCodePrimaryKey))
        {

        }

        protected GeneticCodeEditorModelBase(string geneticCodeName) : this(geneticCode: new GEPGeneticCodeUsingDatabase(geneticCodeName: geneticCodeName))
        {
            
        }

        protected GeneticCodeEditorModelBase(IGEPGeneticCodeUsingDatabase geneticCode)
        {
            this.GeneticCode = geneticCode;
        }

        public IGeneticCodeEditorModel Load(IRepositoryArgs args)
        {
            if(args.RepositoryType == RepositoryType.Database)
            {
                return new GeneticCodeEditorModel(args.DatabaseIdentifiers.First());
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public void Save(IGeneticCodeEditorModel model, IRepositoryArgs args)
        {
            if (args.RepositoryType == RepositoryType.Database)
            {
                throw new NotImplementedException("Save the GeneticCode to the database");
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public void Delete(IGeneticCodeEditorModel model, IRepositoryArgs args)
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            var geneticCodeCreator = new GeneticCodeCreatorPresenter();
            geneticCodeCreator.ShowDialog();

            if(geneticCodeCreator.Model.GeneticCodePrimaryKey != null)
                this.GeneticCode = new GEPGeneticCodeUsingDatabase(geneticCodePrimaryKey: -1);
        }
    }
}
