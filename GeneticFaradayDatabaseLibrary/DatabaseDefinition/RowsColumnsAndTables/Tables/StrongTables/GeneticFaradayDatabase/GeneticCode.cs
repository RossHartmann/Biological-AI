using System;
using System.Data;
using System.Collections.Generic;
using UtilityData.Database;
using UtilityData.Database.Tables;
using UtilityData.SQL;
using UtilityData.Database.Rows;
using UtilityData.Database.Contracts;
using UtilityData.SQLing;

namespace GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables
{
    /// <summary>
    /// The Database Master Class
    /// </summary>
    public static partial class DM
    {
        /// <summary>
        /// The rules to which an Organism must abide.
        /// </summary>
        public static GeneticCodeTable GeneticCodeTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.GeneticCodeTable.Instance; }
        }

        /// <summary>
        /// The rules to which an Organism must abide.
        /// </summary>
        [Serializable]
        public static partial class GeneticCode
        {
            /// <summary>
            /// PK_GeneticCodeID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public static GeneticCodeTable.PK_GeneticCodeIDColumn PK_GeneticCodeID
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable.PK_GeneticCodeID; }
            }

            /// <summary>
            /// The name of the Genetic Code.
            /// </summary>
            public static GeneticCodeTable.NameColumn Name
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable.Name; }
            }

            /// <summary>
            /// The length of every Codon in the GeneticCode. All Codons must be of this length.
            /// </summary>
            public static GeneticCodeTable.CodonLengthColumn CodonLength
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable.CodonLength; }
            }

            /// <summary>
            /// The maximum number of IFunctions that take parameters that can be used in an IAllele's IDNA. After (or before) this number of IFunctions (with parameters) have been called, the rest of the IFunctions in the IDNA will not accept any parameters (i.e. they  will be terminals).
            /// </summary>
            public static GeneticCodeTable.MaxParameterfulFunctionsInDNAColumn MaxParameterfulFunctionsInDNA
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable.MaxParameterfulFunctionsInDNA; }
            }

            /// <summary>
            /// The number of IParameters used by the IFunction that has the most parameters.
            /// </summary>
            public static GeneticCodeTable.MaximumFunctionInputsUsedColumn MaximumFunctionInputsUsed
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable.MaximumFunctionInputsUsed; }
            }

            /// <summary>
            /// The maximum recursion level that's allowable. If this value is reached by an IGEPGene, the execution of the IGEPGene will be aborted.
            /// </summary>
            public static GeneticCodeTable.MaxRecursionLevelColumn MaxRecursionLevel
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable.MaxRecursionLevel; }
            }

            /// <summary>
            /// Creates a row in the GeneticCode table.
            /// </summary>
            /// <param name="name">The name of the Genetic Code.</param>
            /// <param name="codonLength">The length of every Codon in the GeneticCode. All Codons must be of this length.</param>
            /// <param name="maxParameterfulFunctionsInDNA">The maximum number of IFunctions that take parameters that can be used in an IAllele's IDNA. After (or before) this number of IFunctions (with parameters) have been called, the rest of the IFunctions in the IDNA will not accept any parameters (i.e. they  will be terminals).</param>
            /// <param name="maximumFunctionInputsUsed">The number of IParameters used by the IFunction that has the most parameters.</param>
            /// <param name="maxRecursionLevel">The maximum recursion level that's allowable. If this value is reached by an IGEPGene, the execution of the IGEPGene will be aborted.</param>
            public static Row ToRow(System.String name, System.Int32 codonLength, System.Int32 maxParameterfulFunctionsInDNA, System.Int32 maximumFunctionInputsUsed, System.Int32 maxRecursionLevel)
            {
                return new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable, new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable.Name, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable.CodonLength, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable.MaxParameterfulFunctionsInDNA, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable.MaximumFunctionInputsUsed, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable.MaxRecursionLevel }, new object[] { name, codonLength, maxParameterfulFunctionsInDNA, maximumFunctionInputsUsed, maxRecursionLevel });
            }
        }
    }

    /// <summary>
    /// The rules to which an Organism must abide.
    /// </summary>
    [Serializable]
    public sealed partial class GeneticCodeTable : TableDefinition
    {
        /// <summary>
        /// The single instance of the GeneticCodeTable.
        /// </summary>
        public static readonly GeneticCodeTable Instance = new GeneticCodeTable();

        /// <summary>
        /// PK_GeneticCodeID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_GeneticCodeIDColumn PK_GeneticCodeID { get; private set; }

        /// <summary>
        /// The name of the Genetic Code.
        /// </summary>
        public NameColumn Name { get; private set; }

        /// <summary>
        /// The length of every Codon in the GeneticCode. All Codons must be of this length.
        /// </summary>
        public CodonLengthColumn CodonLength { get; private set; }

        /// <summary>
        /// The maximum number of IFunctions that take parameters that can be used in an IAllele's IDNA. After (or before) this number of IFunctions (with parameters) have been called, the rest of the IFunctions in the IDNA will not accept any parameters (i.e. they  will be terminals).
        /// </summary>
        public MaxParameterfulFunctionsInDNAColumn MaxParameterfulFunctionsInDNA { get; private set; }

        /// <summary>
        /// The number of IParameters used by the IFunction that has the most parameters.
        /// </summary>
        public MaximumFunctionInputsUsedColumn MaximumFunctionInputsUsed { get; private set; }

        /// <summary>
        /// The maximum recursion level that's allowable. If this value is reached by an IGEPGene, the execution of the IGEPGene will be aborted.
        /// </summary>
        public MaxRecursionLevelColumn MaxRecursionLevel { get; private set; }

        /// <summary>
        /// PK_GeneticCodeID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_GeneticCodeIDColumn PrimaryColumn
        {
            get { return this.PK_GeneticCodeID; }
        }

        #region Strong Column Classes
        /// <summary>
        /// PK_GeneticCodeID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [Serializable]
        public sealed partial class PK_GeneticCodeIDColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the PK_GeneticCodeID column.
            /// </summary>
            public PK_GeneticCodeIDColumn()
                : base()
            {

            }

            /// <summary>
            /// PK_GeneticCodeID
            /// </summary>
            public override string Name
            {
                get { return "PK_GeneticCodeID"; }
            }

            /// <summary>
            /// Genetic Code Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Genetic Code Identifier"; }
            }

            /// <summary>
            /// PK_GeneticCodeID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public override string Description
            {
                get { return "PK_GeneticCodeID int IDENTITY (1,1) PRIMARY KEY,"; }
            }

            /// <summary>
            /// PrimaryKey
            /// </summary>
            public override ColumnType ColumnType
            {
                get { return ColumnType.PrimaryKey; }
            }

            /// <summary>
            /// Int
            /// </summary>
            public override SQLDbType SQLValueType
            {
                get { return SQLDbType.Int; }
            }

            /// <summary>
            /// Number
            /// </summary>
            public override ValueBaseType ValueBaseType
            {
                get { return ValueBaseType.Number; }
            }

            /// <summary>
            /// System.Int32
            /// </summary>
            public override Type ValueType
            {
                get { return typeof(System.Int32); }
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool CanBeNull
            {
                get { return false; }
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool Unique
            {
                get { return false; }
            }

            /// <summary>
            /// 
            /// </summary>
            public override int? Length
            {
                get { return null; }
            }

            /// <summary>
            /// GeneticCodeTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// null
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return null; }
            }

            /// <summary>
            /// null
            /// </summary>
            public override IEnumerable<string> GetEnumColumnValuesAsStrings()
            {
                return null;
            }

            /// <summary>
            /// True
            /// </summary>
            public override bool IsIncrementingIdentity
            {
                get { return true; }
            }

            /// <summary>
            /// If true, this column refers to an enum column and is constrained by the values in that enum table.<para></para><para></para>HasValueDomainConstraint: False
            /// </summary>
            public override bool HasValueDomainConstraint
            {
                get { return false; }
            }

            /// <summary>
            /// True
            /// </summary>
            public override bool AvailableInEndUserReports
            {
                get { return true; }
            }

            /// <summary>
            /// No Default Value
            /// </summary>
            public override bool HasDefaultValue
            {
                get { return false; }
            }

            /// <summary>
            /// No Default Value (i.e. "null")
            /// </summary>
            public override object DefaultValue
            {
                get { return null; }
            }

            /// <summary>
            /// JoinType.InnerJoin
            /// </summary>
            public override JoinType JoinTypeToForeignColumn
            {
                get { return JoinType.InnerJoin; }
            }

            /// <summary>
            /// RelationshipType.Undefined
            /// </summary>
            public override RelationshipType RelationToForeignTable
            {
                get { return RelationshipType.Undefined; }
            }
        }

        /// <summary>
        /// The name of the Genetic Code.
        /// </summary>
        [Serializable]
        public sealed partial class NameColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the Name column.
            /// </summary>
            public NameColumn()
                : base()
            {

            }

            /// <summary>
            /// Name
            /// </summary>
            public override string Name
            {
                get { return "Name"; }
            }

            /// <summary>
            /// Name
            /// </summary>
            public override string DisplayText
            {
                get { return "Name"; }
            }

            /// <summary>
            /// The name of the Genetic Code.
            /// </summary>
            public override string Description
            {
                get { return "The name of the Genetic Code."; }
            }

            /// <summary>
            /// Normal
            /// </summary>
            public override ColumnType ColumnType
            {
                get { return ColumnType.Normal; }
            }

            /// <summary>
            /// VarChar
            /// </summary>
            public override SQLDbType SQLValueType
            {
                get { return SQLDbType.VarChar; }
            }

            /// <summary>
            /// String
            /// </summary>
            public override ValueBaseType ValueBaseType
            {
                get { return ValueBaseType.String; }
            }

            /// <summary>
            /// System.String
            /// </summary>
            public override Type ValueType
            {
                get { return typeof(System.String); }
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool CanBeNull
            {
                get { return false; }
            }

            /// <summary>
            /// True
            /// </summary>
            public override bool Unique
            {
                get { return true; }
            }

            /// <summary>
            /// 200
            /// </summary>
            public override int? Length
            {
                get { return 200; }
            }

            /// <summary>
            /// GeneticCodeTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// null
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return null; }
            }

            /// <summary>
            /// null
            /// </summary>
            public override IEnumerable<string> GetEnumColumnValuesAsStrings()
            {
                return null;
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool IsIncrementingIdentity
            {
                get { return false; }
            }

            /// <summary>
            /// If true, this column refers to an enum column and is constrained by the values in that enum table.<para></para><para></para>HasValueDomainConstraint: False
            /// </summary>
            public override bool HasValueDomainConstraint
            {
                get { return false; }
            }

            /// <summary>
            /// True
            /// </summary>
            public override bool AvailableInEndUserReports
            {
                get { return true; }
            }

            /// <summary>
            /// No Default Value
            /// </summary>
            public override bool HasDefaultValue
            {
                get { return false; }
            }

            /// <summary>
            /// No Default Value (i.e. "null")
            /// </summary>
            public override object DefaultValue
            {
                get { return null; }
            }

            /// <summary>
            /// JoinType.InnerJoin
            /// </summary>
            public override JoinType JoinTypeToForeignColumn
            {
                get { return JoinType.InnerJoin; }
            }

            /// <summary>
            /// RelationshipType.Undefined
            /// </summary>
            public override RelationshipType RelationToForeignTable
            {
                get { return RelationshipType.Undefined; }
            }
        }

        /// <summary>
        /// The length of every Codon in the GeneticCode. All Codons must be of this length.
        /// </summary>
        [Serializable]
        public sealed partial class CodonLengthColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the CodonLength column.
            /// </summary>
            public CodonLengthColumn()
                : base()
            {

            }

            /// <summary>
            /// CodonLength
            /// </summary>
            public override string Name
            {
                get { return "CodonLength"; }
            }

            /// <summary>
            /// Codon Length
            /// </summary>
            public override string DisplayText
            {
                get { return "Codon Length"; }
            }

            /// <summary>
            /// The length of every Codon in the GeneticCode. All Codons must be of this length.
            /// </summary>
            public override string Description
            {
                get { return "The length of every Codon in the GeneticCode. All Codons must be of this length."; }
            }

            /// <summary>
            /// Normal
            /// </summary>
            public override ColumnType ColumnType
            {
                get { return ColumnType.Normal; }
            }

            /// <summary>
            /// Int
            /// </summary>
            public override SQLDbType SQLValueType
            {
                get { return SQLDbType.Int; }
            }

            /// <summary>
            /// Number
            /// </summary>
            public override ValueBaseType ValueBaseType
            {
                get { return ValueBaseType.Number; }
            }

            /// <summary>
            /// System.Int32
            /// </summary>
            public override Type ValueType
            {
                get { return typeof(System.Int32); }
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool CanBeNull
            {
                get { return false; }
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool Unique
            {
                get { return false; }
            }

            /// <summary>
            /// 
            /// </summary>
            public override int? Length
            {
                get { return null; }
            }

            /// <summary>
            /// GeneticCodeTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// null
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return null; }
            }

            /// <summary>
            /// null
            /// </summary>
            public override IEnumerable<string> GetEnumColumnValuesAsStrings()
            {
                return null;
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool IsIncrementingIdentity
            {
                get { return false; }
            }

            /// <summary>
            /// If true, this column refers to an enum column and is constrained by the values in that enum table.<para></para><para></para>HasValueDomainConstraint: False
            /// </summary>
            public override bool HasValueDomainConstraint
            {
                get { return false; }
            }

            /// <summary>
            /// True
            /// </summary>
            public override bool AvailableInEndUserReports
            {
                get { return true; }
            }

            /// <summary>
            /// No Default Value
            /// </summary>
            public override bool HasDefaultValue
            {
                get { return false; }
            }

            /// <summary>
            /// No Default Value (i.e. "null")
            /// </summary>
            public override object DefaultValue
            {
                get { return null; }
            }

            /// <summary>
            /// JoinType.InnerJoin
            /// </summary>
            public override JoinType JoinTypeToForeignColumn
            {
                get { return JoinType.InnerJoin; }
            }

            /// <summary>
            /// RelationshipType.Undefined
            /// </summary>
            public override RelationshipType RelationToForeignTable
            {
                get { return RelationshipType.Undefined; }
            }
        }

        /// <summary>
        /// The maximum number of IFunctions that take parameters that can be used in an IAllele's IDNA. After (or before) this number of IFunctions (with parameters) have been called, the rest of the IFunctions in the IDNA will not accept any parameters (i.e. they  will be terminals).
        /// </summary>
        [Serializable]
        public sealed partial class MaxParameterfulFunctionsInDNAColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the MaxParameterfulFunctionsInDNA column.
            /// </summary>
            public MaxParameterfulFunctionsInDNAColumn()
                : base()
            {

            }

            /// <summary>
            /// MaxParameterfulFunctionsInDNA
            /// </summary>
            public override string Name
            {
                get { return "MaxParameterfulFunctionsInDNA"; }
            }

            /// <summary>
            /// Max Parameterful Functions In D N A
            /// </summary>
            public override string DisplayText
            {
                get { return "Max Parameterful Functions In D N A"; }
            }

            /// <summary>
            /// The maximum number of IFunctions that take parameters that can be used in an IAllele's IDNA. After (or before) this number of IFunctions (with parameters) have been called, the rest of the IFunctions in the IDNA will not accept any parameters (i.e. they  will be terminals).
            /// </summary>
            public override string Description
            {
                get { return "The maximum number of IFunctions that take parameters that can be used in an IAllele's IDNA. After (or before) this number of IFunctions (with parameters) have been called, the rest of the IFunctions in the IDNA will not accept any parameters (i.e. they  will be terminals)."; }
            }

            /// <summary>
            /// Normal
            /// </summary>
            public override ColumnType ColumnType
            {
                get { return ColumnType.Normal; }
            }

            /// <summary>
            /// Int
            /// </summary>
            public override SQLDbType SQLValueType
            {
                get { return SQLDbType.Int; }
            }

            /// <summary>
            /// Number
            /// </summary>
            public override ValueBaseType ValueBaseType
            {
                get { return ValueBaseType.Number; }
            }

            /// <summary>
            /// System.Int32
            /// </summary>
            public override Type ValueType
            {
                get { return typeof(System.Int32); }
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool CanBeNull
            {
                get { return false; }
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool Unique
            {
                get { return false; }
            }

            /// <summary>
            /// 
            /// </summary>
            public override int? Length
            {
                get { return null; }
            }

            /// <summary>
            /// GeneticCodeTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// null
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return null; }
            }

            /// <summary>
            /// null
            /// </summary>
            public override IEnumerable<string> GetEnumColumnValuesAsStrings()
            {
                return null;
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool IsIncrementingIdentity
            {
                get { return false; }
            }

            /// <summary>
            /// If true, this column refers to an enum column and is constrained by the values in that enum table.<para></para><para></para>HasValueDomainConstraint: False
            /// </summary>
            public override bool HasValueDomainConstraint
            {
                get { return false; }
            }

            /// <summary>
            /// True
            /// </summary>
            public override bool AvailableInEndUserReports
            {
                get { return true; }
            }

            /// <summary>
            /// No Default Value
            /// </summary>
            public override bool HasDefaultValue
            {
                get { return false; }
            }

            /// <summary>
            /// No Default Value (i.e. "null")
            /// </summary>
            public override object DefaultValue
            {
                get { return null; }
            }

            /// <summary>
            /// JoinType.InnerJoin
            /// </summary>
            public override JoinType JoinTypeToForeignColumn
            {
                get { return JoinType.InnerJoin; }
            }

            /// <summary>
            /// RelationshipType.Undefined
            /// </summary>
            public override RelationshipType RelationToForeignTable
            {
                get { return RelationshipType.Undefined; }
            }
        }

        /// <summary>
        /// The number of IParameters used by the IFunction that has the most parameters.
        /// </summary>
        [Serializable]
        public sealed partial class MaximumFunctionInputsUsedColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the MaximumFunctionInputsUsed column.
            /// </summary>
            public MaximumFunctionInputsUsedColumn()
                : base()
            {

            }

            /// <summary>
            /// MaximumFunctionInputsUsed
            /// </summary>
            public override string Name
            {
                get { return "MaximumFunctionInputsUsed"; }
            }

            /// <summary>
            /// Maximum Function Inputs Used
            /// </summary>
            public override string DisplayText
            {
                get { return "Maximum Function Inputs Used"; }
            }

            /// <summary>
            /// The number of IParameters used by the IFunction that has the most parameters.
            /// </summary>
            public override string Description
            {
                get { return "The number of IParameters used by the IFunction that has the most parameters."; }
            }

            /// <summary>
            /// Normal
            /// </summary>
            public override ColumnType ColumnType
            {
                get { return ColumnType.Normal; }
            }

            /// <summary>
            /// Int
            /// </summary>
            public override SQLDbType SQLValueType
            {
                get { return SQLDbType.Int; }
            }

            /// <summary>
            /// Number
            /// </summary>
            public override ValueBaseType ValueBaseType
            {
                get { return ValueBaseType.Number; }
            }

            /// <summary>
            /// System.Int32
            /// </summary>
            public override Type ValueType
            {
                get { return typeof(System.Int32); }
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool CanBeNull
            {
                get { return false; }
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool Unique
            {
                get { return false; }
            }

            /// <summary>
            /// 
            /// </summary>
            public override int? Length
            {
                get { return null; }
            }

            /// <summary>
            /// GeneticCodeTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// null
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return null; }
            }

            /// <summary>
            /// null
            /// </summary>
            public override IEnumerable<string> GetEnumColumnValuesAsStrings()
            {
                return null;
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool IsIncrementingIdentity
            {
                get { return false; }
            }

            /// <summary>
            /// If true, this column refers to an enum column and is constrained by the values in that enum table.<para></para><para></para>HasValueDomainConstraint: False
            /// </summary>
            public override bool HasValueDomainConstraint
            {
                get { return false; }
            }

            /// <summary>
            /// True
            /// </summary>
            public override bool AvailableInEndUserReports
            {
                get { return true; }
            }

            /// <summary>
            /// No Default Value
            /// </summary>
            public override bool HasDefaultValue
            {
                get { return false; }
            }

            /// <summary>
            /// No Default Value (i.e. "null")
            /// </summary>
            public override object DefaultValue
            {
                get { return null; }
            }

            /// <summary>
            /// JoinType.InnerJoin
            /// </summary>
            public override JoinType JoinTypeToForeignColumn
            {
                get { return JoinType.InnerJoin; }
            }

            /// <summary>
            /// RelationshipType.Undefined
            /// </summary>
            public override RelationshipType RelationToForeignTable
            {
                get { return RelationshipType.Undefined; }
            }
        }

        /// <summary>
        /// The maximum recursion level that's allowable. If this value is reached by an IGEPGene, the execution of the IGEPGene will be aborted.
        /// </summary>
        [Serializable]
        public sealed partial class MaxRecursionLevelColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the MaxRecursionLevel column.
            /// </summary>
            public MaxRecursionLevelColumn()
                : base()
            {

            }

            /// <summary>
            /// MaxRecursionLevel
            /// </summary>
            public override string Name
            {
                get { return "MaxRecursionLevel"; }
            }

            /// <summary>
            /// Max Recursion Level
            /// </summary>
            public override string DisplayText
            {
                get { return "Max Recursion Level"; }
            }

            /// <summary>
            /// The maximum recursion level that's allowable. If this value is reached by an IGEPGene, the execution of the IGEPGene will be aborted.
            /// </summary>
            public override string Description
            {
                get { return "The maximum recursion level that's allowable. If this value is reached by an IGEPGene, the execution of the IGEPGene will be aborted."; }
            }

            /// <summary>
            /// Normal
            /// </summary>
            public override ColumnType ColumnType
            {
                get { return ColumnType.Normal; }
            }

            /// <summary>
            /// Int
            /// </summary>
            public override SQLDbType SQLValueType
            {
                get { return SQLDbType.Int; }
            }

            /// <summary>
            /// Number
            /// </summary>
            public override ValueBaseType ValueBaseType
            {
                get { return ValueBaseType.Number; }
            }

            /// <summary>
            /// System.Int32
            /// </summary>
            public override Type ValueType
            {
                get { return typeof(System.Int32); }
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool CanBeNull
            {
                get { return false; }
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool Unique
            {
                get { return false; }
            }

            /// <summary>
            /// 
            /// </summary>
            public override int? Length
            {
                get { return null; }
            }

            /// <summary>
            /// GeneticCodeTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// null
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return null; }
            }

            /// <summary>
            /// null
            /// </summary>
            public override IEnumerable<string> GetEnumColumnValuesAsStrings()
            {
                return null;
            }

            /// <summary>
            /// False
            /// </summary>
            public override bool IsIncrementingIdentity
            {
                get { return false; }
            }

            /// <summary>
            /// If true, this column refers to an enum column and is constrained by the values in that enum table.<para></para><para></para>HasValueDomainConstraint: False
            /// </summary>
            public override bool HasValueDomainConstraint
            {
                get { return false; }
            }

            /// <summary>
            /// True
            /// </summary>
            public override bool AvailableInEndUserReports
            {
                get { return true; }
            }

            /// <summary>
            /// No Default Value
            /// </summary>
            public override bool HasDefaultValue
            {
                get { return false; }
            }

            /// <summary>
            /// No Default Value (i.e. "null")
            /// </summary>
            public override object DefaultValue
            {
                get { return null; }
            }

            /// <summary>
            /// JoinType.InnerJoin
            /// </summary>
            public override JoinType JoinTypeToForeignColumn
            {
                get { return JoinType.InnerJoin; }
            }

            /// <summary>
            /// RelationshipType.Undefined
            /// </summary>
            public override RelationshipType RelationToForeignTable
            {
                get { return RelationshipType.Undefined; }
            }
        }
        #endregion

        /// <summary>
        /// Constructs the single instance of the GeneticCodeTable.
        /// </summary>
        public GeneticCodeTable()
            : base()
        {
            this.PK_GeneticCodeID = new PK_GeneticCodeIDColumn() { TableDefinition = this };
            this.Name = new NameColumn() { TableDefinition = this };
            this.CodonLength = new CodonLengthColumn() { TableDefinition = this };
            this.MaxParameterfulFunctionsInDNA = new MaxParameterfulFunctionsInDNAColumn() { TableDefinition = this };
            this.MaximumFunctionInputsUsed = new MaximumFunctionInputsUsedColumn() { TableDefinition = this };
            this.MaxRecursionLevel = new MaxRecursionLevelColumn() { TableDefinition = this };
            this.Columns = new ColumnCollection(this, this.PrimaryColumn, new Column[] { this.Name, this.CodonLength, this.MaxParameterfulFunctionsInDNA, this.MaximumFunctionInputsUsed, this.MaxRecursionLevel });
            this.AddRangeToColumnsDefiningUniqueness(new Column[] { this.Name });
            this.AddRangeToSummaryColumns(new Column[] { this.Name });
            this.AddRangeToStructuralColumns(new Column[] { });
            this.AddRangeToPascalCaseColumns(new Column[] { });
        }





        /// <summary>
        /// dmgeneticcode
        /// </summary>
        public override string TableAlias
        {
            get { return "dmgeneticcode"; }
        }

        /// <summary>
        /// GeneticCode
        /// </summary>
        public override string TableName
        {
            get { return "GeneticCode"; }
        }

        /// <summary>
        /// The rules to which an Organism must abide.
        /// </summary>
        public override string TableDescription
        {
            get { return "The rules to which an Organism must abide."; }
        }

        /// <summary>
        /// The Columns that make up this GeneticCodeTable.
        /// </summary>
        public override ColumnCollection Columns { get; protected set; }

        /// <summary>
        /// The database that holds this table.
        /// </summary>
        public override Database Database
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Database; }
        }
    }
}