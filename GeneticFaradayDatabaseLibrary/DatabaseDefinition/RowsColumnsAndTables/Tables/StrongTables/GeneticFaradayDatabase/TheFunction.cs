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
        /// A Function.
        /// </summary>
        public static TheFunctionTable TheFunctionTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.TheFunctionTable.Instance; }
        }

        /// <summary>
        /// A Function.
        /// </summary>
        [Serializable]
        public static partial class TheFunction
        {
            /// <summary>
            /// PK_FunctionID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public static TheFunctionTable.PK_FunctionIDColumn PK_FunctionID
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.PK_FunctionID; }
            }

            /// <summary>
            /// The unique FunctionIdentifier of the Function.
            /// </summary>
            public static TheFunctionTable.FunctionIdentifierColumn FunctionIdentifier
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.FunctionIdentifier; }
            }

            /// <summary>
            /// The GeneticCode to which this Function applies.
            /// </summary>
            public static TheFunctionTable.GeneticCodeColumn GeneticCode
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.GeneticCode; }
            }

            /// <summary>
            /// The human-readable name of the Function. Doesn't necessarily uniquely identify this Function.
            /// </summary>
            public static TheFunctionTable.NameColumn Name
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.Name; }
            }

            /// <summary>
            /// The base human-readable name of the Function. this is a more general name for the Function (than this.Name).
            /// </summary>
            public static TheFunctionTable.BaseNameColumn BaseName
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.BaseName; }
            }

            /// <summary>
            /// The Weight of the Function in the GeneticCode. The higher the weight, the more Codons that will encode for this Function.
            /// </summary>
            public static TheFunctionTable.WeightInGeneticCodeColumn WeightInGeneticCode
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.WeightInGeneticCode; }
            }

            /// <summary>
            /// The name of the ExecuteMethod delegate that will be used to execute this Function.
            /// </summary>
            public static TheFunctionTable.ExecuteMethodNameColumn ExecuteMethodName
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.ExecuteMethodName; }
            }

            /// <summary>
            /// The area of the IFunction such as \"Arithmetic\" or \"
            /// </summary>
            public static TheFunctionTable.AreaColumn Area
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.Area; }
            }

            /// <summary>
            /// Creates a row in the TheFunction table.
            /// </summary>
            /// <param name="functionIdentifier">The unique FunctionIdentifier of the Function.</param>
            /// <param name="geneticCode">The GeneticCode to which this Function applies.</param>
            /// <param name="name">The human-readable name of the Function. Doesn't necessarily uniquely identify this Function.</param>
            /// <param name="baseName">The base human-readable name of the Function. this is a more general name for the Function (than this.Name).</param>
            /// <param name="weightInGeneticCode">The Weight of the Function in the GeneticCode. The higher the weight, the more Codons that will encode for this Function.</param>
            /// <param name="executeMethodName">The name of the ExecuteMethod delegate that will be used to execute this Function.</param>
            /// <param name="area">The area of the IFunction such as \"Arithmetic\" or \"</param>
            public static Row ToRow(System.String functionIdentifier, System.Int32 geneticCode, System.String name, System.String baseName, System.Double weightInGeneticCode, System.String executeMethodName, System.String area)
            {
                return new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable, new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.FunctionIdentifier, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.GeneticCode, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.Name, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.BaseName, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.WeightInGeneticCode, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.ExecuteMethodName, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable.Area }, new object[] { functionIdentifier, geneticCode, name, baseName, weightInGeneticCode, executeMethodName, area });
            }
        }
    }

    /// <summary>
    /// A Function.
    /// </summary>
    [Serializable]
    public sealed partial class TheFunctionTable : TableDefinition
    {
        /// <summary>
        /// The single instance of the TheFunctionTable.
        /// </summary>
        public static readonly TheFunctionTable Instance = new TheFunctionTable();

        /// <summary>
        /// PK_FunctionID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_FunctionIDColumn PK_FunctionID { get; private set; }

        /// <summary>
        /// The unique FunctionIdentifier of the Function.
        /// </summary>
        public FunctionIdentifierColumn FunctionIdentifier { get; private set; }

        /// <summary>
        /// The GeneticCode to which this Function applies.
        /// </summary>
        public GeneticCodeColumn GeneticCode { get; private set; }

        /// <summary>
        /// The human-readable name of the Function. Doesn't necessarily uniquely identify this Function.
        /// </summary>
        public NameColumn Name { get; private set; }

        /// <summary>
        /// The base human-readable name of the Function. this is a more general name for the Function (than this.Name).
        /// </summary>
        public BaseNameColumn BaseName { get; private set; }

        /// <summary>
        /// The Weight of the Function in the GeneticCode. The higher the weight, the more Codons that will encode for this Function.
        /// </summary>
        public WeightInGeneticCodeColumn WeightInGeneticCode { get; private set; }

        /// <summary>
        /// The name of the ExecuteMethod delegate that will be used to execute this Function.
        /// </summary>
        public ExecuteMethodNameColumn ExecuteMethodName { get; private set; }

        /// <summary>
        /// The area of the IFunction such as \"Arithmetic\" or \"
        /// </summary>
        public AreaColumn Area { get; private set; }

        /// <summary>
        /// PK_FunctionID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_FunctionIDColumn PrimaryColumn
        {
            get { return this.PK_FunctionID; }
        }

        #region Strong Column Classes
        /// <summary>
        /// PK_FunctionID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [Serializable]
        public sealed partial class PK_FunctionIDColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the PK_FunctionID column.
            /// </summary>
            public PK_FunctionIDColumn()
                : base()
            {

            }

            /// <summary>
            /// PK_FunctionID
            /// </summary>
            public override string Name
            {
                get { return "PK_FunctionID"; }
            }

            /// <summary>
            /// The Function Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "The Function Identifier"; }
            }

            /// <summary>
            /// PK_FunctionID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public override string Description
            {
                get { return "PK_FunctionID int IDENTITY (1,1) PRIMARY KEY,"; }
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
            /// TheFunctionTable
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
        /// The unique FunctionIdentifier of the Function.
        /// </summary>
        [Serializable]
        public sealed partial class FunctionIdentifierColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the FunctionIdentifier column.
            /// </summary>
            public FunctionIdentifierColumn()
                : base()
            {

            }

            /// <summary>
            /// FunctionIdentifier
            /// </summary>
            public override string Name
            {
                get { return "FunctionIdentifier"; }
            }

            /// <summary>
            /// Function Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Function Identifier"; }
            }

            /// <summary>
            /// The unique FunctionIdentifier of the Function.
            /// </summary>
            public override string Description
            {
                get { return "The unique FunctionIdentifier of the Function."; }
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
            /// TheFunctionTable
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
            /// TheFunctionTable
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

        /// <summary>
        /// The human-readable name of the Function. Doesn't necessarily uniquely identify this Function.
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
            /// The human-readable name of the Function. Doesn't necessarily uniquely identify this Function.
            /// </summary>
            public override string Description
            {
                get { return "The human-readable name of the Function. Doesn't necessarily uniquely identify this Function."; }
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
            /// TheFunctionTable
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
        /// The base human-readable name of the Function. this is a more general name for the Function (than this.Name).
        /// </summary>
        [Serializable]
        public sealed partial class BaseNameColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the BaseName column.
            /// </summary>
            public BaseNameColumn()
                : base()
            {

            }

            /// <summary>
            /// BaseName
            /// </summary>
            public override string Name
            {
                get { return "BaseName"; }
            }

            /// <summary>
            /// Base Name
            /// </summary>
            public override string DisplayText
            {
                get { return "Base Name"; }
            }

            /// <summary>
            /// The base human-readable name of the Function. this is a more general name for the Function (than this.Name).
            /// </summary>
            public override string Description
            {
                get { return "The base human-readable name of the Function. this is a more general name for the Function (than this.Name)."; }
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
            /// TheFunctionTable
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
        /// The Weight of the Function in the GeneticCode. The higher the weight, the more Codons that will encode for this Function.
        /// </summary>
        [Serializable]
        public sealed partial class WeightInGeneticCodeColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the WeightInGeneticCode column.
            /// </summary>
            public WeightInGeneticCodeColumn()
                : base()
            {

            }

            /// <summary>
            /// WeightInGeneticCode
            /// </summary>
            public override string Name
            {
                get { return "WeightInGeneticCode"; }
            }

            /// <summary>
            /// Weight In Genetic Code
            /// </summary>
            public override string DisplayText
            {
                get { return "Weight In Genetic Code"; }
            }

            /// <summary>
            /// The Weight of the Function in the GeneticCode. The higher the weight, the more Codons that will encode for this Function.
            /// </summary>
            public override string Description
            {
                get { return "The Weight of the Function in the GeneticCode. The higher the weight, the more Codons that will encode for this Function."; }
            }

            /// <summary>
            /// Normal
            /// </summary>
            public override ColumnType ColumnType
            {
                get { return ColumnType.Normal; }
            }

            /// <summary>
            /// Decimal
            /// </summary>
            public override SQLDbType SQLValueType
            {
                get { return SQLDbType.Decimal; }
            }

            /// <summary>
            /// Number
            /// </summary>
            public override ValueBaseType ValueBaseType
            {
                get { return ValueBaseType.Number; }
            }

            /// <summary>
            /// System.Double
            /// </summary>
            public override Type ValueType
            {
                get { return typeof(System.Double); }
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
            /// TheFunctionTable
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
        /// The name of the ExecuteMethod delegate that will be used to execute this Function.
        /// </summary>
        [Serializable]
        public sealed partial class ExecuteMethodNameColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the ExecuteMethodName column.
            /// </summary>
            public ExecuteMethodNameColumn()
                : base()
            {

            }

            /// <summary>
            /// ExecuteMethodName
            /// </summary>
            public override string Name
            {
                get { return "ExecuteMethodName"; }
            }

            /// <summary>
            /// Execute Method Name
            /// </summary>
            public override string DisplayText
            {
                get { return "Execute Method Name"; }
            }

            /// <summary>
            /// The name of the ExecuteMethod delegate that will be used to execute this Function.
            /// </summary>
            public override string Description
            {
                get { return "The name of the ExecuteMethod delegate that will be used to execute this Function."; }
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
            /// TheFunctionTable
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
        /// The area of the IFunction such as \"Arithmetic\" or \"
        /// </summary>
        [Serializable]
        public sealed partial class AreaColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the Area column.
            /// </summary>
            public AreaColumn()
                : base()
            {

            }

            /// <summary>
            /// Area
            /// </summary>
            public override string Name
            {
                get { return "Area"; }
            }

            /// <summary>
            /// Area
            /// </summary>
            public override string DisplayText
            {
                get { return "Area"; }
            }

            /// <summary>
            /// The area of the IFunction such as \"Arithmetic\" or \"
            /// </summary>
            public override string Description
            {
                get { return "The area of the IFunction such as \"Arithmetic\" or \""; }
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
            /// TheFunctionTable
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
        /// Constructs the single instance of the TheFunctionTable.
        /// </summary>
        public TheFunctionTable()
            : base()
        {
            this.PK_FunctionID = new PK_FunctionIDColumn() { TableDefinition = this };
            this.FunctionIdentifier = new FunctionIdentifierColumn() { TableDefinition = this };
            this.GeneticCode = new GeneticCodeColumn() { TableDefinition = this };
            this.Name = new NameColumn() { TableDefinition = this };
            this.BaseName = new BaseNameColumn() { TableDefinition = this };
            this.WeightInGeneticCode = new WeightInGeneticCodeColumn() { TableDefinition = this };
            this.ExecuteMethodName = new ExecuteMethodNameColumn() { TableDefinition = this };
            this.Area = new AreaColumn() { TableDefinition = this };
            this.Columns = new ColumnCollection(this, this.PrimaryColumn, new Column[] { this.FunctionIdentifier, this.GeneticCode, this.Name, this.BaseName, this.WeightInGeneticCode, this.ExecuteMethodName, this.Area });
            this.AddRangeToColumnsDefiningUniqueness(new Column[] { this.FunctionIdentifier, this.GeneticCode });
            this.AddRangeToSummaryColumns(new Column[] { this.FunctionIdentifier, this.GeneticCode });
            this.AddRangeToStructuralColumns(new Column[] { });
            this.AddRangeToPascalCaseColumns(new Column[] { });
        }





        /// <summary>
        /// dmthefunction
        /// </summary>
        public override string TableAlias
        {
            get { return "dmthefunction"; }
        }

        /// <summary>
        /// TheFunction
        /// </summary>
        public override string TableName
        {
            get { return "TheFunction"; }
        }

        /// <summary>
        /// A Function.
        /// </summary>
        public override string TableDescription
        {
            get { return "A Function."; }
        }

        /// <summary>
        /// The Columns that make up this TheFunctionTable.
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