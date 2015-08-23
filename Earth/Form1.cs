using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneticFaraday.Contracts.Metrics;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.GEP.Contracts.Organisms;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions.Parameters;
using GeneticFaraday.GEP.Contracts.Organisms.Phenomes;
using GeneticFaraday.GEP.Contracts.Registries;
using GeneticFaraday.GEP.Contracts.Universe;
using GeneticFaraday.GEP.Functions;
using GeneticFaraday.GEP.Models.Environment;
using GeneticFaraday.GEP.Models.Environment.CallableGenesProviders;
using GeneticFaraday.GEP.Models.Environment.GeneticOperators.InitializationOperators;
using GeneticFaraday.GEP.Models.Environment.GeneticOperators.MutationOperators;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.Functions.Parameters;
using GeneticFaraday.GEP.Models.Organisms.OrganismBehavior.Surroundings;
using GeneticFaraday.GEP.Models.Registries;
using GeneticFaraday.GEP.Models.Universe;
using GeneticFaraday.Models.Environment;
using GeneticFaraday.Models.Environment.EnvironmentIdentifiers;
using GeneticFaraday.Models.Environment.GeneticOperators.SelectionOperators;
using GeneticFaraday.Models.Metrics;
using GeneticFaraday.Models.Metrics.Comparers;
using GeneticFaraday.Models.Metrics.EndCriteriaEvaluators;
using GeneticFaraday.Models.Metrics.MetricsEvaluators;
using GeneticFaraday.Models.Organisms.GeneticCodes.Codons.CodonConverters.CodonNumberConverters;
using GeneticFaraday.Utility;
using UtilityData;
using UtilityData.Database;
using UtilityData.LINQ;
using UtilityData.SQL;
using GeneticFaraday.DatabaseExtensions;

namespace Earth
{
    public partial class Form1 : Form
    {
        private IGEPUniverse Universe { get; set; }
        private IGEPGeneticCode GeneticCode { get; set; }
        public Form1()
        {
            InitializeComponent();

            /*
            var sqlConnectionDetails = new SQLConnectionDetails(DatabaseType.MSSQL, System.Configuration.ConfigurationManager.ConnectionStrings["Production"].ConnectionString);
            SM.Initialize(sqlConnectionDetails.Server, recordAllSQLTransactions: false);
            DM.Initialize(new SqlConnection(sqlConnectionDetails.ConnectionString).Database, sqlConnectionDetails, new SessionManager());

             */
            var environmentState = new EnvironmentState(populationSize: 500, eliteCount: 3)
                                       {
                                           ChanceOfInitialization = .1,
                                           ChanceOfRecombination = 0,
                                           ChanceOfMutation = .9,
                                       };

            var environment = new GEPEnvironment(identifier: new NameIdentifier("Forest"),
                                                 state: environmentState,
                                                 metricsEvaluator:
                                                     new MetricsEvaluator(MetricsFunction, (one, two) => 1,
                                                                          (one, two) => 1, (one, two) => 1,
                                                                          (one, two) => 1),
                                                 endCriteriaEvaluator:
                                                     new EndAfterGenerationsEvaluator(generationAtWhichToEnd: 1000),
                                                     /*new EndAfterValueMetEvaluator(40000), */
                                                organismValueComparer: new CompareByValueLowerWins(),
                                                     callableGenesProvider: new CallableGenesProviderFirstLevelChildren());


            environmentState.InitializationOperators.Add(new GEPRandomOneGeneInitializationOperator(100));
            
            environmentState.SelectionOperators.Add(new RandomSelection(5));
            environmentState.SelectionOperators.Add(new TournamentSelection(25));
            environmentState.SelectionOperators.Add(new RouletteSelection(70));

            environmentState.MutationOperators.Add(new GEPMainGeneOneNucleotide(30));
            environmentState.MutationOperators.Add(new GEPMainGeneIncrementNucleotide(25));
            environmentState.MutationOperators.Add(new GEPMainGeneDecrementNucleotide(25));
            environmentState.MutationOperators.Add(new GEPMainGeneRandomizeNucleotides(20, minimumNucleotidesToMutate: 2, maximumNucleotidesToMutate: 4));




            var geneticCode = new GEPGeneticCodeUsingDatabase(codonLength: 6, maxParameterfulFunctionsInDNA: 20);

            geneticCode.AddNucleotide("A");
            geneticCode.AddNucleotide("B");
            geneticCode.AddNucleotide("C");
            geneticCode.AddNucleotide("D");
            geneticCode.AddNucleotide("E");
            geneticCode.AddNucleotide("F");
            geneticCode.AddNucleotide("G");
            geneticCode.AddNucleotide("H");

            geneticCode.AddCodonConverter(new ConvertCodonToInt3());
            geneticCode.AddCodonConverter(new ConvertCodonToInt5());
            geneticCode.AddCodonConverter(new ConvertCodonToInt16());
            geneticCode.AddCodonConverter(new ConvertCodonToFloat16());
            geneticCode.AddCodonConverter(new ConvertCodonToDecimal());


            var executeMethods = new List<MethodInfo>();

            var nestedTypes = typeof (GeneticFaraday.GEP.Functions.Functions).GetNestedTypes();
            foreach(var type in nestedTypes)
                executeMethods.AddRange(type.GetMethods());

            /*
            var functionRowTemplate = new TheFunctionRow();
            var functionRows = Qry.SelectAllFrom(functionRowTemplate)
                .LeftOuterJoinSelectingAllOn(functionRowTemplate.ForeignKeyRow_Parameter_ParentFunctionRowColumn)
                .LeftOuterJoinSelectingAllOn(functionRowTemplate.ForeignKeyRow_FunctionRegistry_TheFunctionRowColumn)
                .GoAndExtractMultiple<TheFunctionRow>();

            for (var i = 0; i < functionRows.Count; i++)
            {
                var functionRow = functionRows[i];
                var applicableRows = new List<TheFunctionRow>();
                while (i + 1 < functionRows.Count && functionRows[i + 1].PrimaryKey == functionRow.PrimaryKey)
                {
                    applicableRows.Add(functionRows[i + 1]);
                    i++;
                }

                var uniqueParameters = applicableRows.Where(r => !r.ForeignKeyRow_Parameter_ParentFunctionRow.IsPrimaryKeyNullOrEmpty)
                    .Select(r => r.ForeignKeyRow_Parameter_ParentFunctionRow)
                    .Distinct(r => r.PrimaryKey);

                var uniqueRegistryIdentifiers = applicableRows.Where(r => !r.ForeignKeyRow_FunctionRegistry_TheFunctionRow.IsPrimaryKeyNullOrEmpty)
                    .Select(r => r.ForeignKeyRow_FunctionRegistry_TheFunctionRow)
                    .Distinct(r => r.PrimaryKey);

                geneticCode.AddFunction(functionRow.ToFunction(uniqueParameters, uniqueRegistryIdentifiers, executeMethods));
            }
            */

            var universe = new GEPUniverse(geneticCode: geneticCode);

            universe.Add(environment);
            environment.GenerationEnd += environment_GenerationEnd;
            universe.AnyEnvironmentEnds += universe_AnyEnvironmentEnds;







            /*

            geneticCode.AddFunctions(Functions.Arithmetic.GetSumFunctions(environment: environment, weightInGeneticCode: 3));

            geneticCode.AddFunctions(Functions.IRegistryRead.GetReadFunctions(environment: environment, weightInGeneticCode: 4));
            geneticCode.AddFunctions(Functions.IRegistryWrite.GetWriteFunctions(environment: environment, weightInGeneticCode: 2));
            
            
            geneticCode.AddFunctions(Functions.Arithmetic.GetDifferenceFunctions(environment: environment, weightInGeneticCode: .5));
            geneticCode.AddFunctions(Functions.Arithmetic.GetMultiplyFunctions(environment: environment, weightInGeneticCode: .25));
            geneticCode.AddFunctions(Functions.Arithmetic.GetDivideFunctions(environment: environment, weightInGeneticCode: .25));
            
            geneticCode.AddFunctions(Functions.Arithmetic.GetSquareFunctions(environment: environment, weightInGeneticCode: 3));
            geneticCode.AddFunctions(Functions.Arithmetic.GetPowerFunctions(environment: environment, weightInGeneticCode: 3));

            
            geneticCode.AddFunctions(Functions.Arithmetic.GetSquareRootFunctions(environment: environment, weightInGeneticCode: .25));
            geneticCode.AddFunctions(Functions.Arithmetic.GetNegateFunctions(environment: environment, weightInGeneticCode: .25));
            geneticCode.AddFunctions(Functions.Arithmetic.GetForceNegateFunctions(environment: environment, weightInGeneticCode: .25));
            geneticCode.AddFunctions(Functions.Arithmetic.GetAbsoluteFunctions(environment: environment, weightInGeneticCode: .25));
            geneticCode.AddFunctions(Functions.Arithmetic.GetRoundToNearestWholeNumberFunctions(environment: environment, weightInGeneticCode: .25));
            geneticCode.AddFunctions(Functions.Arithmetic.GetSuccessorFunctions(environment: environment, weightInGeneticCode: .25));
            geneticCode.AddFunctions(Functions.Arithmetic.GetPredecessorFunctions(environment: environment, weightInGeneticCode: .25));
            
            geneticCode.AddFunctions(Functions.Constants.GetConstantsFunctions(weightInGeneticCode: 3));

            geneticCode.AutoAssignCodonsToAminoAcids(percentageStopCodons: .01, redundancyRating: 100);
             */
            this.GeneticCode = geneticCode;




            var distinctFunctionsByFunctionName = this.GeneticCode.FunctionSet.Values.Distinct(pair => pair.Name);
            foreach (var function in distinctFunctionsByFunctionName)
                function_names_combo_box.Items.Add(function.Name);
            function_names_combo_box.SelectedIndexChanged += function_names_combo_box_SelectedIndexChanged;

            var distinctFunctionsByFunctionBaseName = this.GeneticCode.FunctionSet.Values.Distinct(pair => pair.BaseName);
            foreach (var function in distinctFunctionsByFunctionBaseName)
                function_base_name_combo_box.Items.Add(function.BaseName);

            var distinctFunctionIdentifiers = this.GeneticCode.FunctionSet.Values.Select(p => p.Identifier);
            foreach (var function in distinctFunctionIdentifiers)
                function_identifiers_combo_box.Items.Add(function);


            this.Universe = universe;
            universe.Run();
        }

        void function_names_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (function_names_combo_box.SelectedItem == null)
                return;

            function_base_name_combo_box.Text = null;
            function_identifiers_combo_box.Text = null;

            var functionName = function_names_combo_box.SelectedItem.ToString();

            var codonsEncodingForFunctionWithNameCount =
                this.GeneticCode.Codons.Count(
                    c => this.GeneticCode.FunctionSet[c.Value.Functions.PrimaryFunction].Name == functionName);

            codons_encoding_primarily_for_function_name_text_box.Text =
                codonsEncodingForFunctionWithNameCount.ToString();
             * */
        }

        private void function_base_name_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (function_base_name_combo_box.SelectedItem == null)
                return;

            function_names_combo_box.Text = null;
            function_identifiers_combo_box.Text = null;

            var functionBaseName = function_base_name_combo_box.SelectedItem.ToString();

            var codonsEncodingForFunctionWithNameCount =
                this.GeneticCode.Codons.Count(
                    c => this.GeneticCode.FunctionSet[c.Value.Functions.PrimaryFunction].BaseName == functionBaseName);

            codons_encoding_primarily_for_function_name_text_box.Text =
                codonsEncodingForFunctionWithNameCount.ToString();
             */
        }

        private void function_identifiers_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (function_identifiers_combo_box.SelectedItem == null)
                return;

            function_base_name_combo_box.Text = null;
            function_names_combo_box.Text = null;

            var functionIdentifier = function_identifiers_combo_box.SelectedItem.ToString();

            var codonsEncodingForFunctionWithIdentifierCount =
                this.GeneticCode.Codons.Count(
                    c => this.GeneticCode.FunctionSet[c.Value.Functions.PrimaryFunction].Identifier.ToString() == functionIdentifier);

            codons_encoding_primarily_for_function_name_text_box.Text =
                codonsEncodingForFunctionWithIdentifierCount.ToString();
             */
        }

        

        void environment_GenerationEnd(object sender, GeneticFaraday.Contracts.Environment.Events.GenerationEndEventArgs e)
        {
            var mostValuable = (IGEPOrganism)e.Environment.GetMostValuableOrganism();

            var phenome = (IGEPPhenome)mostValuable.ToPhenome(new GEPSurroundings(this.GetInputRegistry(mostValuable, 3)));
            var programString = phenome.Chromosomes[0].Main.ToDebuggablePhenomeString(mostValuable.Parent.GeneticCode, printIVariablesAsValues: false);
            Console.WriteLine(programString);
            Console.WriteLine(mostValuable.Metrics.Value.Value);
        }

        void universe_AnyEnvironmentEnds(object sender, GeneticFaraday.Contracts.Universe.Events.AnyEnvironmentEndsEventArgs e)
        {
            var mostValuable = (IGEPOrganism)e.EnvironmentEndEventArgs.Environment.GetMostValuableOrganism();

            var phenome = (IGEPPhenome)mostValuable.ToPhenome(new GEPSurroundings(this.GetInputRegistry(mostValuable, 3)));
            var programString = phenome.Chromosomes[0].Main.ToDebuggablePhenomeString(mostValuable.Parent.GeneticCode, printIVariablesAsValues: false);
            Console.WriteLine(programString);

            var metrics = MetricsFunction(mostValuable);
            mostValuable.ResultsRegistry.MoveToZero();
            var zeroPosition = mostValuable.ResultsRegistry.Read().Value;
            Console.WriteLine(mostValuable.Metrics.Value.Value);



            var genome = mostValuable.ToGenome();
            var genomeString = genome.ToGenomeString();
            var reconvertedOrganism = genome.ToOrganism(e.EnvironmentEndEventArgs.Environment);
        }

        private IRegistry GetInputRegistry(IGEPOrganism o, double valueAtZeroPosition)
        {
            var inputRegistry = new Registry(o.Parent.InputRegistryIdentifier, RegistryType.Input, readOnly: false);
            inputRegistry.Write(new AminoAcidResult(valueAtZeroPosition));
            inputRegistry.ReadOnly = true;
            return inputRegistry;
        }

        private double Function(double input)
        {
            return Math.Pow(input, 3) + Math.Pow(input, 2) + input;
        }

        private double RateOrganism(IGEPOrganism o, IRegistry inputRegistry)
        {
            var behavior = o.Behave(new GEPSurroundings(inputRegistry));

            const double worstFitness = 15000;
            if (behavior.Success)
            {
                var resultsRegistry = o.ResultsRegistry;
                resultsRegistry.MoveToZero();
                var resultValue = resultsRegistry.Read().Value;

                if (double.IsNaN(resultValue) || double.IsInfinity(resultValue))
                    return worstFitness;

                var desiredOutput = this.Function(inputRegistry.ReadAt(0).Value);

                var fitness = Math.Abs(resultValue - desiredOutput);

                if(double.IsNaN(fitness) || double.IsInfinity(fitness))
                    return worstFitness;

                return fitness;

            }
            else
                return worstFitness;
        }

        private double GetValue(IGEPOrganism organism, params IRegistry[] inputs)
        {
            return inputs.Sum(input => RateOrganism(organism, input)) / inputs.Length;
        }

        private IMetrics MetricsFunction(IOrganism organism)
        {
            var o = (IGEPOrganism) organism;

            var value = this.GetValue(o,
                                            this.GetInputRegistry(o, 1),
                                            this.GetInputRegistry(o, 2),
                                            this.GetInputRegistry(o, 3),
                                            this.GetInputRegistry(o, 4),
                                            this.GetInputRegistry(o, 5),
                                            this.GetInputRegistry(o, 6),
                                            this.GetInputRegistry(o, 8),
                                            this.GetInputRegistry(o, 9)
                                        );

            const double worstFitness = 15000;
            if (double.IsNaN(value) || double.IsInfinity(value))
                value = worstFitness;
                

            return new Metrics() {Value = new MetricsValue() {Value = value}};
        }

        
    }
}

