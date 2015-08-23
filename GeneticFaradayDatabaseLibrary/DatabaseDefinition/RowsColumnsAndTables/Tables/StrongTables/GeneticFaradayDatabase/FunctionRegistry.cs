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
        /// A Registry that is available to a Function.
        /// </summary>
        public static FunctionRegistryTable FunctionRegistryTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.FunctionRegistryTable.Instance; }
        }

        /// <summary>
        /// A Registry that is available to a Function.
        /// </summary>
        [Serializable]
        public static partial class FunctionRegistry
        {
            /// <summary>
            /// PK_FunctionRegistryID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public static FunctionRegistryTable.PK_FunctionRegistryIDColumn PK_FunctionRegistryID
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistryTable.PK_FunctionRegistryID; }
            }

            /// <summary>
            /// The Function to which the Registry is available.
            /// </summary>
            public static FunctionRegistryTable.TheFunctionColumn TheFunction
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistryTable.TheFunction; }
            }

            /// <summary>
            /// The identifier of the Registry that is available to the Function.
            /// </summary>
            public static FunctionRegistryTable.RegistryColumn Registry
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistryTable.Registry; }
            }

            /// <summary>
            /// The GeneticCode to which this Function applies.
            /// </summary>
            public static FunctionRegistryTable.GeneticCodeColumn GeneticCode
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistryTable.GeneticCode; }
            }

            /// <summary>
            /// Creates a row in the FunctionRegistry table.
            /// </summary>
            /// <param name="theFunction">The Function to which the Registry is available.</param>
            /// <param name="registry">The identifier of the Registry that is available to the Function.</param>
            /// <param name="geneticCode">The GeneticCode to which this Function applies.</param>
            public static Row ToRow(System.Int32 theFunction, StrongEnums.RegistryIdentifier registry, System.Int32 geneticCode)
            {
                return new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistryTable, new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistryTable.TheFunction, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistryTable.Registry, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistryTable.GeneticCode }, new object[] { theFunction, registry, geneticCode });
            }
        }
    }

    /// <summary>
    /// A Registry that is available to a Function.
    /// </summary>
    [Serializable]
    public sealed partial class FunctionRegistryTable : TableDefinition
    {
        /// <summary>
        /// The single instance of the FunctionRegistryTable.
        /// </summary>
        public static readonly FunctionRegistryTable Instance = new FunctionRegistryTable();

        /// <summary>
        /// PK_FunctionRegistryID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_FunctionRegistryIDColumn PK_FunctionRegistryID { get; private set; }

        /// <summary>
        /// The Function to which the Registry is available.
        /// </summary>
        public TheFunctionColumn TheFunction { get; private set; }

        /// <summary>
        /// The identifier of the Registry that is available to the Function.
        /// </summary>
        public RegistryColumn Registry { get; private set; }

        /// <summary>
        /// The GeneticCode to which this Function applies.
        /// </summary>
        public GeneticCodeColumn GeneticCode { get; private set; }

        /// <summary>
        /// PK_FunctionRegistryID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_FunctionRegistryIDColumn PrimaryColumn
        {
            get { return this.PK_FunctionRegistryID; }
        }

        #region Strong Column Classes
        /// <summary>
        /// PK_FunctionRegistryID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [Serializable]
        public sealed partial class PK_FunctionRegistryIDColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the PK_FunctionRegistryID column.
            /// </summary>
            public PK_FunctionRegistryIDColumn()
                : base()
            {

            }

            /// <summary>
            /// PK_FunctionRegistryID
            /// </summary>
            public override string Name
            {
                get { return "PK_FunctionRegistryID"; }
            }

            /// <summary>
            /// Function Registry Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Function Registry Identifier"; }
            }

            /// <summary>
            /// PK_FunctionRegistryID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public override string Description
            {
                get { return "PK_FunctionRegistryID int IDENTITY (1,1) PRIMARY KEY,"; }
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
            /// FunctionRegistryTable
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
        /// The Function to which the Registry is available.
        /// </summary>
        [Serializable]
        public sealed partial class TheFunctionColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the TheFunction column.
            /// </summary>
            public TheFunctionColumn()
                : base()
            {

            }

            /// <summary>
            /// TheFunction
            /// </summary>
            public override string Name
            {
                get { return "TheFunction"; }
            }

            /// <summary>
            /// The Function
            /// </summary>
            public override string DisplayText
            {
                get { return "The Function"; }
            }

            /// <summary>
            /// The Function to which the Registry is available.
            /// </summary>
            public override string Description
            {
                get { return "The Function to which the Registry is available."; }
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
            /// FunctionRegistryTable
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
        /// The identifier of the Registry that is available to the Function.
        /// </summary>
        [Serializable]
        public sealed partial class RegistryColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the Registry column.
            /// </summary>
            public RegistryColumn()
                : base()
            {
                this.AcceptableValueDomain = new List<object> { "Global", "Input", "Local", "LocalGlobal", "Results" };
            }

            /// <summary>
            /// Registry
            /// </summary>
            public override string Name
            {
                get { return "Registry"; }
            }

            /// <summary>
            /// Registry
            /// </summary>
            public override string DisplayText
            {
                get { return "Registry"; }
            }

            /// <summary>
            /// The identifier of the Registry that is available to the Function.
            /// </summary>
            public override string Description
            {
                get { return "The identifier of the Registry that is available to the Function."; }
            }

            /// <summary>
            /// ForeignKey
            /// </summary>
            public override ColumnType ColumnType
            {
                get { return ColumnType.ForeignKey; }
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
            /// StrongEnums.RegistryIdentifier
            /// </summary>
            public override Type ValueType
            {
                get { return typeof(StrongEnums.RegistryIdentifier); }
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
            /// FunctionRegistryTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifierTable.PK_RegistryIdentifierID
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifierTable.PK_RegistryIdentifierID; }
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
            /// If true, this column refers to an enum column and is constrained by the values in that enum table.<para></para><para></para>HasValueDomainConstraint: True
            /// </summary>
            public override bool HasValueDomainConstraint
            {
                get { return true; }
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
            /// FunctionRegistryTable
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
        /// Constructs the single instance of the FunctionRegistryTable.
        /// </summary>
        public FunctionRegistryTable()
            : base()
        {
            this.PK_FunctionRegistryID = new PK_FunctionRegistryIDColumn() { TableDefinition = this };
            this.TheFunction = new TheFunctionColumn() { TableDefinition = this };
            this.Registry = new RegistryColumn() { TableDefinition = this };
            this.GeneticCode = new GeneticCodeColumn() { TableDefinition = this };
            this.Columns = new ColumnCollection(this, this.PrimaryColumn, new Column[] { this.TheFunction, this.Registry, this.GeneticCode });
            this.AddRangeToColumnsDefiningUniqueness(new Column[] { this.TheFunction, this.Registry });
            this.AddRangeToSummaryColumns(new Column[] { this.TheFunction, this.Registry });
            this.AddRangeToStructuralColumns(new Column[] { });
            this.AddRangeToPascalCaseColumns(new Column[] { });
        }





        /// <summary>
        /// dmfunctionregistry
        /// </summary>
        public override string TableAlias
        {
            get { return "dmfunctionregistry"; }
        }

        /// <summary>
        /// FunctionRegistry
        /// </summary>
        public override string TableName
        {
            get { return "FunctionRegistry"; }
        }

        /// <summary>
        /// A Registry that is available to a Function.
        /// </summary>
        public override string TableDescription
        {
            get { return "A Registry that is available to a Function."; }
        }

        /// <summary>
        /// The Columns that make up this FunctionRegistryTable.
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