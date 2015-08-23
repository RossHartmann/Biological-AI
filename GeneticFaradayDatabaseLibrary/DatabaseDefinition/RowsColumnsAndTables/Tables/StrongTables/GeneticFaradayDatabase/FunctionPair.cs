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
        /// A pair of functions where the second function is parameterless.
        /// </summary>
        public static FunctionPairTable FunctionPairTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.FunctionPairTable.Instance; }
        }

        /// <summary>
        /// A pair of functions where the second function is parameterless.
        /// </summary>
        [Serializable]
        public static partial class FunctionPair
        {
            /// <summary>
            /// PK_FunctionPairID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public static FunctionPairTable.PK_FunctionPairIDColumn PK_FunctionPairID
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable.PK_FunctionPairID; }
            }

            /// <summary>
            /// The identifier of the Primary Function in this IFunctionPair. The IFunction can have any number of parameters (or no parameters). This is the IFunction for which the ICodon primarily encodes.
            /// </summary>
            public static FunctionPairTable.PrimaryFunctionColumn PrimaryFunction
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable.PrimaryFunction; }
            }

            /// <summary>
            /// The identifier of a Parameterless IFunction that will be used if a parameterless IFunction is required. If a ICodon is in the \"tail\" of the IDNA (i.e. in the portion of the IDNA that will only accept \"terminal\" IFunctions), it will use this parameterless IFunction.
            /// </summary>
            public static FunctionPairTable.ParameterlessFunctionColumn ParameterlessFunction
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable.ParameterlessFunction; }
            }

            /// <summary>
            /// The unique FunctionIdentifier of the Primary Function.
            /// </summary>
            public static FunctionPairTable.PrimaryFunctionIdentifierColumn PrimaryFunctionIdentifier
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable.PrimaryFunctionIdentifier; }
            }

            /// <summary>
            /// The unique FunctionIdentifier of the Parameterless Function.
            /// </summary>
            public static FunctionPairTable.ParameterlessFunctionIdentifierColumn ParameterlessFunctionIdentifier
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable.ParameterlessFunctionIdentifier; }
            }

            /// <summary>
            /// The GeneticCode to which this Function applies.
            /// </summary>
            public static FunctionPairTable.GeneticCodeColumn GeneticCode
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable.GeneticCode; }
            }

            /// <summary>
            /// Creates a row in the FunctionPair table.
            /// </summary>
            /// <param name="primaryFunction">The identifier of the Primary Function in this IFunctionPair. The IFunction can have any number of parameters (or no parameters). This is the IFunction for which the ICodon primarily encodes.</param>
            /// <param name="parameterlessFunction">The identifier of a Parameterless IFunction that will be used if a parameterless IFunction is required. If a ICodon is in the \"tail\" of the IDNA (i.e. in the portion of the IDNA that will only accept \"terminal\" IFunctions), it will use this parameterless IFunction.</param>
            /// <param name="primaryFunctionIdentifier">The unique FunctionIdentifier of the Primary Function.</param>
            /// <param name="parameterlessFunctionIdentifier">The unique FunctionIdentifier of the Parameterless Function.</param>
            /// <param name="geneticCode">The GeneticCode to which this Function applies.</param>
            public static Row ToRow(System.Int32 primaryFunction, System.Int32 parameterlessFunction, System.String primaryFunctionIdentifier, System.String parameterlessFunctionIdentifier, System.Int32 geneticCode)
            {
                return new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable, new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable.PrimaryFunction, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable.ParameterlessFunction, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable.PrimaryFunctionIdentifier, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable.ParameterlessFunctionIdentifier, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable.GeneticCode }, new object[] { primaryFunction, parameterlessFunction, primaryFunctionIdentifier, parameterlessFunctionIdentifier, geneticCode });
            }
        }
    }

    /// <summary>
    /// A pair of functions where the second function is parameterless.
    /// </summary>
    [Serializable]
    public sealed partial class FunctionPairTable : TableDefinition
    {
        /// <summary>
        /// The single instance of the FunctionPairTable.
        /// </summary>
        public static readonly FunctionPairTable Instance = new FunctionPairTable();

        /// <summary>
        /// PK_FunctionPairID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_FunctionPairIDColumn PK_FunctionPairID { get; private set; }

        /// <summary>
        /// The identifier of the Primary Function in this IFunctionPair. The IFunction can have any number of parameters (or no parameters). This is the IFunction for which the ICodon primarily encodes.
        /// </summary>
        public PrimaryFunctionColumn PrimaryFunction { get; private set; }

        /// <summary>
        /// The identifier of a Parameterless IFunction that will be used if a parameterless IFunction is required. If a ICodon is in the \"tail\" of the IDNA (i.e. in the portion of the IDNA that will only accept \"terminal\" IFunctions), it will use this parameterless IFunction.
        /// </summary>
        public ParameterlessFunctionColumn ParameterlessFunction { get; private set; }

        /// <summary>
        /// The unique FunctionIdentifier of the Primary Function.
        /// </summary>
        public PrimaryFunctionIdentifierColumn PrimaryFunctionIdentifier { get; private set; }

        /// <summary>
        /// The unique FunctionIdentifier of the Parameterless Function.
        /// </summary>
        public ParameterlessFunctionIdentifierColumn ParameterlessFunctionIdentifier { get; private set; }

        /// <summary>
        /// The GeneticCode to which this Function applies.
        /// </summary>
        public GeneticCodeColumn GeneticCode { get; private set; }

        /// <summary>
        /// PK_FunctionPairID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_FunctionPairIDColumn PrimaryColumn
        {
            get { return this.PK_FunctionPairID; }
        }

        #region Strong Column Classes
        /// <summary>
        /// PK_FunctionPairID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [Serializable]
        public sealed partial class PK_FunctionPairIDColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the PK_FunctionPairID column.
            /// </summary>
            public PK_FunctionPairIDColumn()
                : base()
            {

            }

            /// <summary>
            /// PK_FunctionPairID
            /// </summary>
            public override string Name
            {
                get { return "PK_FunctionPairID"; }
            }

            /// <summary>
            /// Function Pair Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Function Pair Identifier"; }
            }

            /// <summary>
            /// PK_FunctionPairID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public override string Description
            {
                get { return "PK_FunctionPairID int IDENTITY (1,1) PRIMARY KEY,"; }
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
            /// FunctionPairTable
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
        /// The identifier of the Primary Function in this IFunctionPair. The IFunction can have any number of parameters (or no parameters). This is the IFunction for which the ICodon primarily encodes.
        /// </summary>
        [Serializable]
        public sealed partial class PrimaryFunctionColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the PrimaryFunction column.
            /// </summary>
            public PrimaryFunctionColumn()
                : base()
            {

            }

            /// <summary>
            /// PrimaryFunction
            /// </summary>
            public override string Name
            {
                get { return "PrimaryFunction"; }
            }

            /// <summary>
            /// Primary Function
            /// </summary>
            public override string DisplayText
            {
                get { return "Primary Function"; }
            }

            /// <summary>
            /// The identifier of the Primary Function in this IFunctionPair. The IFunction can have any number of parameters (or no parameters). This is the IFunction for which the ICodon primarily encodes.
            /// </summary>
            public override string Description
            {
                get { return "The identifier of the Primary Function in this IFunctionPair. The IFunction can have any number of parameters (or no parameters). This is the IFunction for which the ICodon primarily encodes."; }
            }

            /// <summary>
            /// ForeignKey
            /// </summary>
            public override ColumnType ColumnType
            {
                get { return ColumnType.ForeignKey; }
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
            /// FunctionPairTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.PK_FunctionID
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.PK_FunctionID; }
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
        /// The identifier of a Parameterless IFunction that will be used if a parameterless IFunction is required. If a ICodon is in the \"tail\" of the IDNA (i.e. in the portion of the IDNA that will only accept \"terminal\" IFunctions), it will use this parameterless IFunction.
        /// </summary>
        [Serializable]
        public sealed partial class ParameterlessFunctionColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the ParameterlessFunction column.
            /// </summary>
            public ParameterlessFunctionColumn()
                : base()
            {

            }

            /// <summary>
            /// ParameterlessFunction
            /// </summary>
            public override string Name
            {
                get { return "ParameterlessFunction"; }
            }

            /// <summary>
            /// Parameterless Function
            /// </summary>
            public override string DisplayText
            {
                get { return "Parameterless Function"; }
            }

            /// <summary>
            /// The identifier of a Parameterless IFunction that will be used if a parameterless IFunction is required. If a ICodon is in the \"tail\" of the IDNA (i.e. in the portion of the IDNA that will only accept \"terminal\" IFunctions), it will use this parameterless IFunction.
            /// </summary>
            public override string Description
            {
                get { return "The identifier of a Parameterless IFunction that will be used if a parameterless IFunction is required. If a ICodon is in the \"tail\" of the IDNA (i.e. in the portion of the IDNA that will only accept \"terminal\" IFunctions), it will use this parameterless IFunction."; }
            }

            /// <summary>
            /// ForeignKey
            /// </summary>
            public override ColumnType ColumnType
            {
                get { return ColumnType.ForeignKey; }
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
            /// FunctionPairTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.PK_FunctionID
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.PK_FunctionID; }
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
        /// The unique FunctionIdentifier of the Primary Function.
        /// </summary>
        [Serializable]
        public sealed partial class PrimaryFunctionIdentifierColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the PrimaryFunctionIdentifier column.
            /// </summary>
            public PrimaryFunctionIdentifierColumn()
                : base()
            {

            }

            /// <summary>
            /// PrimaryFunctionIdentifier
            /// </summary>
            public override string Name
            {
                get { return "PrimaryFunctionIdentifier"; }
            }

            /// <summary>
            /// Primary Function Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Primary Function Identifier"; }
            }

            /// <summary>
            /// The unique FunctionIdentifier of the Primary Function.
            /// </summary>
            public override string Description
            {
                get { return "The unique FunctionIdentifier of the Primary Function."; }
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
            /// False
            /// </summary>
            public override bool Unique
            {
                get { return false; }
            }

            /// <summary>
            /// 200
            /// </summary>
            public override int? Length
            {
                get { return 200; }
            }

            /// <summary>
            /// FunctionPairTable
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
        /// The unique FunctionIdentifier of the Parameterless Function.
        /// </summary>
        [Serializable]
        public sealed partial class ParameterlessFunctionIdentifierColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the ParameterlessFunctionIdentifier column.
            /// </summary>
            public ParameterlessFunctionIdentifierColumn()
                : base()
            {

            }

            /// <summary>
            /// ParameterlessFunctionIdentifier
            /// </summary>
            public override string Name
            {
                get { return "ParameterlessFunctionIdentifier"; }
            }

            /// <summary>
            /// Parameterless Function Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Parameterless Function Identifier"; }
            }

            /// <summary>
            /// The unique FunctionIdentifier of the Parameterless Function.
            /// </summary>
            public override string Description
            {
                get { return "The unique FunctionIdentifier of the Parameterless Function."; }
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
            /// False
            /// </summary>
            public override bool Unique
            {
                get { return false; }
            }

            /// <summary>
            /// 200
            /// </summary>
            public override int? Length
            {
                get { return 200; }
            }

            /// <summary>
            /// FunctionPairTable
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
        /// The GeneticCode to which this Function applies.
        /// </summary>
        [Serializable]
        public sealed partial class GeneticCodeColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the GeneticCode column.
            /// </summary>
            public GeneticCodeColumn()
                : base()
            {

            }

            /// <summary>
            /// GeneticCode
            /// </summary>
            public override string Name
            {
                get { return "GeneticCode"; }
            }

            /// <summary>
            /// Genetic Code
            /// </summary>
            public override string DisplayText
            {
                get { return "Genetic Code"; }
            }

            /// <summary>
            /// The GeneticCode to which this Function applies.
            /// </summary>
            public override string Description
            {
                get { return "The GeneticCode to which this Function applies."; }
            }

            /// <summary>
            /// ForeignKey
            /// </summary>
            public override ColumnType ColumnType
            {
                get { return ColumnType.ForeignKey; }
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
            /// FunctionPairTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable.PK_GeneticCodeID
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable.PK_GeneticCodeID; }
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
        /// Constructs the single instance of the FunctionPairTable.
        /// </summary>
        public FunctionPairTable()
            : base()
        {
            this.PK_FunctionPairID = new PK_FunctionPairIDColumn() { TableDefinition = this };
            this.PrimaryFunction = new PrimaryFunctionColumn() { TableDefinition = this };
            this.ParameterlessFunction = new ParameterlessFunctionColumn() { TableDefinition = this };
            this.PrimaryFunctionIdentifier = new PrimaryFunctionIdentifierColumn() { TableDefinition = this };
            this.ParameterlessFunctionIdentifier = new ParameterlessFunctionIdentifierColumn() { TableDefinition = this };
            this.GeneticCode = new GeneticCodeColumn() { TableDefinition = this };
            this.Columns = new ColumnCollection(this, this.PrimaryColumn, new Column[] { this.PrimaryFunction, this.ParameterlessFunction, this.PrimaryFunctionIdentifier, this.ParameterlessFunctionIdentifier, this.GeneticCode });
            this.AddRangeToColumnsDefiningUniqueness(new Column[] { this.PrimaryFunction, this.ParameterlessFunction });
            this.AddRangeToSummaryColumns(new Column[] { this.PrimaryFunction, this.ParameterlessFunction });
            this.AddRangeToStructuralColumns(new Column[] { });
            this.AddRangeToPascalCaseColumns(new Column[] { });
        }





        /// <summary>
        /// dmfunctionpair
        /// </summary>
        public override string TableAlias
        {
            get { return "dmfunctionpair"; }
        }

        /// <summary>
        /// FunctionPair
        /// </summary>
        public override string TableName
        {
            get { return "FunctionPair"; }
        }

        /// <summary>
        /// A pair of functions where the second function is parameterless.
        /// </summary>
        public override string TableDescription
        {
            get { return "A pair of functions where the second function is parameterless."; }
        }

        /// <summary>
        /// The Columns that make up this FunctionPairTable.
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