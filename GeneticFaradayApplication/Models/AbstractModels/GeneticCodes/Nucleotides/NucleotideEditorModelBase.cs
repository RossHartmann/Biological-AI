using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaraday.DatabaseExtensions;
using GeneticFaraday.Models.Organisms.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Models.Models.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Repositories.Contracts;
using GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows;
using UtilityData.LINQ;
using UtilityData.SQL;

namespace GeneticFaradayApplication.Models.AbstractModels.GeneticCodes.Nucleotides
{
    public abstract class NucleotideEditorModelBase : INucleotideEditorModel
    {
        public INucleotide Nucleotide { get; set; }
        public string GeneticCodeName { get; set; }
        /// <summary>
        /// The Primary key of the Genetic Code to which the Nucleotide belongs.
        /// </summary>
        public int? GeneticCodePrimaryKey { get; set; }

        protected NucleotideEditorModelBase() : this(null, null, null)
        {
            
        }

        protected NucleotideEditorModelBase(INucleotide nucleotide, string geneticCodeName, int? geneticCodePrimaryKey)
        {
            this.Nucleotide = nucleotide;
            this.GeneticCodeName = geneticCodeName;
            this.GeneticCodePrimaryKey = geneticCodePrimaryKey;
        }

        public INucleotideEditorModel Load(IRepositoryArgs args)
        {
            if(args.RepositoryType == RepositoryType.Database)
            {
                var nucleotideRow = new NucleotideRow();
                Qry.SelectAllFrom(nucleotideRow)
                    .InnerJoinSelectingStructuralOn(nucleotideRow.GeneticCodeRowColumn)
                    .Where(nucleotideRow.NameColumn, args.DatabaseIdentifiers[0])
                    .Where(nucleotideRow.GeneticCodeRow.NameColumn, args.DatabaseIdentifiers[1])
                    .GoAndExtract(ref nucleotideRow);
                return new NucleotideEditorModel(nucleotide: nucleotideRow.ToNucleotide(), 
                    geneticCodeName: nucleotideRow.GeneticCodeRow.Name,
                    geneticCodePrimaryKey: nucleotideRow.GeneticCodeRow.PrimaryKey);
            }
            else
            {
                throw new NotImplementedException();
            }
            
        }

        public void Save(INucleotideEditorModel model, IRepositoryArgs args)
        {
            if(args.RepositoryType == RepositoryType.Database)
            {
                var nucleotideRow = new NucleotideRow
                                        {
                                            Name = model.Nucleotide.Identifier.ToString(),
                                            GeneticCode = model.GeneticCodePrimaryKey.Value
                                        };
                nucleotideRow.InsertOnlyIfNecessary();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public void Delete(INucleotideEditorModel model, IRepositoryArgs args)
        {
            if(args.RepositoryType == RepositoryType.Database)
            {
                var geneticCodePrimaryKey = model.GeneticCodePrimaryKey;

                if(geneticCodePrimaryKey == null)
                {
                    var geneticCodeRow = new GeneticCodeRow();
                    Qry.SelectPrimaryKeyFrom(geneticCodeRow)
                        .Where(geneticCodeRow.NameColumn, this.GeneticCodeName)
                        .GoAndExtract(ref geneticCodeRow);
                    geneticCodePrimaryKey = geneticCodeRow.PrimaryKey;
                }

                var nucleotideRow = new NucleotideRow
                {
                    Name = model.Nucleotide.Identifier.ToString(),
                    GeneticCode = geneticCodePrimaryKey.Value
                };
                nucleotideRow.PrimaryKey = nucleotideRow.GetPrimaryKeyByColumnsDefiningUniqueness().ToInt();
                nucleotideRow.Delete();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public void New()
        {
            this.GeneticCodeName = null;
            this.Nucleotide = null;
            this.GeneticCodePrimaryKey = null;
        }

        public INucleotideEditorModel ShallowCopy()
        {
            return new NucleotideEditorModel(new Nucleotide(this.Nucleotide.Identifier.ShallowCopy()),
                                             this.GeneticCodeName, this.GeneticCodePrimaryKey);
        }

        public override string ToString()
        {
            return this.Nucleotide.Identifier.ToString();
        }
    }
}
