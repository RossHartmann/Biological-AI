using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.Models.Organisms.GeneticCodes.Codons;
using GeneticFaraday.Utility;
using GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows;
using GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables;
using UtilityData.LINQ;
using UtilityData.SQL;
using GeneticFaraday.DatabaseExtensions;

namespace GeneticFaraday.GEP.Models.Organisms.GeneticCodes
{
    /// <summary>
    /// a GEPGeneticCode that stores Codons in a database.
    /// </summary>
    public class GEPGeneticCodeUsingDatabase : GEPGeneticCodeBase, IGEPGeneticCodeUsingDatabase
    {
        /// <summary>
        /// The unique name of the IGEPGeneticCode.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The Primary Key of the Genetic Code in the GeneticFaradayDatabase.
        /// </summary>
        public int? GeneticCodePrimaryKey { get; private set; }

        /// <summary>
        /// Initializes the Genetic Code from the given genetic code primary key.
        /// </summary>
        /// <param name="geneticCodePrimaryKey"></param>
        public GEPGeneticCodeUsingDatabase(int geneticCodePrimaryKey)
            : base()
        {
            this.Initialize(geneticCodePrimaryKey: geneticCodePrimaryKey);
        }
        
        /// <summary>
        /// Initializes the Genetic Code from the given unique genetic code name.
        /// </summary>
        /// <param name="geneticCodeName"></param>
        public GEPGeneticCodeUsingDatabase(string geneticCodeName)
            : base()
        {
            this.Initialize(geneticCodeName: geneticCodeName);
        }

        public GEPGeneticCodeUsingDatabase(int geneticCodePrimaryKey, int codonLength, int maxParameterfulFunctionsInDNA, int maxRecursionLevel = 2)
            : base(
                codonLength: codonLength, maxParameterfulFunctionsInDNA: maxParameterfulFunctionsInDNA,
                maxRecursionLevel: maxRecursionLevel)
        {
            this.Initialize(geneticCodePrimaryKey: geneticCodePrimaryKey);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codonLength">The length of every ICodon in the IGeneticCode.
        /// 
        /// All ICodons must be of this length.</param>
        /// <param name="maxParameterfulFunctionsInDNA">The maximum number of IFunctions that take parameters 
        /// that can be used in an IAllele's IDNA. After (or before) this 
        /// number of IFunctions (with parameters) have been called, the rest
        /// of the IFunctions in the IDNA will not accept any parameters (i.e. they 
        /// will be terminals).</param>
        /// <param name="maxRecursionLevel">The maximum recursion level that's allowable. If this value is reached by an
        /// IGEPGene, the execution of the IGEPGene will be aborted.</param>
        public GEPGeneticCodeUsingDatabase(int codonLength, int maxParameterfulFunctionsInDNA, int maxRecursionLevel = 2)
            : base(
                codonLength: codonLength, maxParameterfulFunctionsInDNA: maxParameterfulFunctionsInDNA,
                maxRecursionLevel: maxRecursionLevel)
        {
            this.Initialize(geneticCodeName: null);
        }

        private void Initialize(int geneticCodePrimaryKey)
        {
            this.GeneticCodePrimaryKey = geneticCodePrimaryKey;

            var geneticCodeRow = new GeneticCodeRow();
            Qry.SelectAllFrom(geneticCodeRow)
                .Where(geneticCodeRow.PrimaryKeyColumn, this.GeneticCodePrimaryKey)
                .GoAndExtract(ref geneticCodeRow);

            this.Initialize(row: geneticCodeRow);
        }

        /// <summary>
        /// Initializes the Genetic Code from the given unique genetic code name of it is not null.
        /// </summary>
        /// <param name="geneticCodeName"></param>
        private void Initialize(string geneticCodeName)
        {
            this.Name = geneticCodeName;

            if (this.Name != null)
            {
                var geneticCodeRow = new GeneticCodeRow();
                Qry.SelectAllFrom(geneticCodeRow)
                    .Where(geneticCodeRow.NameColumn, this.Name)
                    .GoAndExtract(ref geneticCodeRow);

                this.Initialize(row: geneticCodeRow);
            }
        }

        private void Initialize(GeneticCodeRow row)
        {
            this.MaxParameterfulFunctionsInDNA = row.MaxParameterfulFunctionsInDNA;
            this.CodonLength = row.CodonLength;
            this.MaxRecursionLevel = row.MaxRecursionLevel;
            this.MaximumFunctionInputsUsed = row.MaximumFunctionInputsUsed;
            this.GeneticCodePrimaryKey = row.PrimaryKey;
            this.Name = row.Name;
        }

        public override ICodon GetCodon(ICodonIdentifier codonIdentifier)
        {
            var codonRow = new CodonRow();
            Qry.SelectAllFrom(codonRow)
                .InnerJoinSelectingAllOn(codonRow.FunctionPairRowColumn)
                .Where(codonRow.NameColumn, codonIdentifier.ToString())
                .GoAndExtract(ref codonRow);
            return codonRow.ToGEPCodon(this);
        }

        public override void AddCodon(ICodon codon)
        {
            this.AddCodon((IGEPCodon) codon);
        }

        public override void AddCodon(IGEPCodon codon)
        {
            var functionPairRow = new FunctionPairRow();
            var result = Qry.SelectAllFrom(functionPairRow)
                .InnerJoinOn(functionPairRow.PrimaryFunctionRowColumn)
                .InnerJoinOn(functionPairRow.ParameterlessFunctionRowColumn)
                .Where(functionPairRow.PrimaryFunctionRow.FunctionIdentifierColumn, codon.Functions.PrimaryFunction.ToString())
                .Where(functionPairRow.ParameterlessFunctionRow.FunctionIdentifierColumn, codon.Functions.ParameterlessFunction.ToString())
                .Go();
            
            if(result.IsEmpty)
                this.InsertFunctionPairIfNecessary(ref functionPairRow, codon: codon);
            else
                result.ExtractStrongRow(ref functionPairRow);

            var codonRow = new CodonRow(name: codon.CodonIdentifier.ToString(), geneticCode: this.GeneticCodePrimaryKey.Value,
                                        functionPair: functionPairRow.PrimaryKey, codonType: codon.CodonType.ToCodonType());
            codonRow.InsertIntoDatabase();

            /*
            var nucleotideRow = new NucleotideRow();
            var nucleotideRows = Qry.SelectAllFrom(nucleotideRow)
                .Where(nucleotideRow.GeneticCodeColumn, this.GeneticCodePrimaryKey.Value)
                .GoAndExtractMultiple<NucleotideRow>();

            foreach(var nucleotide in codon)
            {
                var codonNucleotideRow =
                    nucleotide.ToCodonNucleotideRow(
                        nucleotidePrimaryKey:
                            nucleotideRows.First(n => n.Name == nucleotide.Identifier.ToString()).PrimaryKey,
                        codonPrimaryKey: codonRow.PrimaryKey,
                        geneticCodePrimaryKey: this.GeneticCodePrimaryKey.Value);
                codonNucleotideRow.InsertOnlyIfNecessary();
            }
             */
        }

        private void InsertFunctionPairIfNecessary(ref FunctionPairRow functionPairRow, IGEPCodon codon)
        {
            // Insert the function pair row
            var primaryFunction = this.FunctionSet[codon.Functions.PrimaryFunction];
            var parameterlessFunction = this.FunctionSet[codon.Functions.ParameterlessFunction];

            var primaryFunctionPrimaryKey =
                primaryFunction.ToFunctionRow(this.GeneticCodePrimaryKey.Value).GetPrimaryKeyByColumnsDefiningUniqueness().ToInt();
            var parameterlessFunctionPrimaryKey =
                parameterlessFunction.ToFunctionRow(this.GeneticCodePrimaryKey.Value).GetPrimaryKeyByColumnsDefiningUniqueness().ToInt();

            functionPairRow = new FunctionPairRow(primaryFunction: primaryFunctionPrimaryKey,
                                                  parameterlessFunction: parameterlessFunctionPrimaryKey,
                                                  primaryFunctionIdentifier: primaryFunction.Identifier.ToString(),
                                                  parameterlessFunctionIdentifier:
                                                      parameterlessFunction.Identifier.ToString(),
                                                  geneticCode: this.GeneticCodePrimaryKey.Value);
            functionPairRow.InsertOnlyIfNecessary();
        }

        public override IGEPCodon GetCodonEncodingFunction(IFunctionIdentifier functionIdentifier, CodonType codonType = CodonType.Standard)
        {
            var codonRow = new CodonRow();
            Qry.SelectAllFrom(codonRow)
                .InnerJoinSelectingAllOn(codonRow.FunctionPairRowColumn)
                .InnerJoinOn(codonRow.FunctionPairRow.PrimaryFunctionRowColumn)
                .Where(codonRow.CodonTypeColumn, codonType.ToString())
                .Where(codonRow.FunctionPairRow.PrimaryFunctionRow.FunctionIdentifierColumn, functionIdentifier.ToString())
                .GoAndExtract(ref codonRow);

            return codonRow.ToGEPCodon(this);
        }

        public override IEnumerable<ICodon> GetStopCodons()
        {
            var codonRow = new CodonRow();
            var codonRows = Qry.SelectAllFrom(codonRow)
                                .InnerJoinSelectingAllOn(codonRow.FunctionPairRowColumn)
                                .Where(codonRow.CodonTypeColumn, CodonType.Stop)
                                .GoAndExtractMultiple<CodonRow>();

            return codonRows.Select(c => c.ToGEPCodon(this));
        }

        public override ICodon GetRandomCodon()
        {
            // Construct a Codon (randomly).
            var codonName = "";
            for (var i = 0; i < this.CodonLength; i++)
            {
                var nucleotide = this.Nucleotides.Values.RandomElement();
                codonName += nucleotide.Identifier.ToString();
            }

            var codonRow = new CodonRow();
            Qry.SelectAllFrom(codonRow)
                .InnerJoinSelectingAllOn(codonRow.FunctionPairRowColumn)
                .Where(codonRow.NameColumn, codonName)
                .GoAndExtract(ref codonRow);

            return codonRow.ToGEPCodon(this);
        }

        public override List<ICodonIdentifier> GetAllCodonIdentifiers()
        {
            return Qry.SelectFrom(DM.Codon.Name)
                    .Go()
                    .GetValuesInColumn(DM.Codon.Name)
                    .Select(o => (ICodonIdentifier)new CodonIdentifier(o.ToString()))
                    .ToList();
        }

        public override void SetCodonType(ICodonIdentifier codonIdentifier, CodonType codonType)
        {
            Qry.Update(DM.Codon.CodonType, codonType.ToString())
                .Where(DM.Codon.Name, codonIdentifier.ToString())
                .Go();
        }
    }
}
