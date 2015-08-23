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
        /// The identifier of a Registry.
        /// </summary>
        public static RegistryIdentifierTable RegistryIdentifierTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.RegistryIdentifierTable.Instance; }
        }

        /// <summary>
        /// The identifier of a Registry.
        /// </summary>
        [Serializable]
        public static partial class RegistryIdentifier
        {
            /// <summary>
            /// The ID of a Registry
            /// </summary>
            public static RegistryIdentifierTable.PK_RegistryIdentifierIDColumn PK_RegistryIdentifierID
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifierTable.PK_RegistryIdentifierID; }
            }

            /// <summary>
            /// Creates a row in the RegistryIdentifier table.
            /// </summary>
            public static Row ToRow()
            {
                return new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifierTable, new Column[] { }, new object[] { });
            }
        }
    }

    /// <summary>
    /// The identifier of a Registry.
    /// </summary>
    [Serializable]
    public sealed partial class RegistryIdentifierTable : TableDefinition
    {
        /// <summary>
        /// The single instance of the RegistryIdentifierTable.
        /// </summary>
        public static readonly RegistryIdentifierTable Instance = new RegistryIdentifierTable();

        /// <summary>
        /// The ID of a Registry
        /// </summary>
        public PK_RegistryIdentifierIDColumn PK_RegistryIdentifierID { get; private set; }

        /// <summary>
        /// The ID of a Registry
        /// </summary>
        public PK_RegistryIdentifierIDColumn PrimaryColumn
        {
            get { return this.PK_RegistryIdentifierID; }
        }

        #region Strong Column Classes
        /// <summary>
        /// The ID of a Registry
        /// </summary>
        [Serializable]
        public sealed partial class PK_RegistryIdentifierIDColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the PK_RegistryIdentifierID column.
            /// </summary>
            public PK_RegistryIdentifierIDColumn()
                : base()
            {

            }

            /// <summary>
            /// PK_RegistryIdentifierID
            /// </summary>
            public override string Name
            {
                get { return "PK_RegistryIdentifierID"; }
            }

            /// <summary>
            /// Registry Identifier Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Registry Identifier Identifier"; }
            }

            /// <summary>
            /// The ID of a Registry
            /// </summary>
            public override string Description
            {
                get { return "The ID of a Registry"; }
            }

            /// <summary>
            /// PrimaryKey
            /// </summary>
            public override ColumnType ColumnType
            {
                get { return ColumnType.PrimaryKey; }
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
            /// RegistryIdentifierTable
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
            /// global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.RegistryIdentifier.GetValuesAsStrings()
            /// </summary>
            public override IEnumerable<string> GetEnumColumnValuesAsStrings()
            {
                return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.RegistryIdentifier.GetValuesAsStrings();
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
        /// Constructs the single instance of the RegistryIdentifierTable.
        /// </summary>
        public RegistryIdentifierTable()
            : base()
        {
            this.PK_RegistryIdentifierID = new PK_RegistryIdentifierIDColumn() { TableDefinition = this };
            this.Columns = new ColumnCollection(this, this.PrimaryColumn, new Column[] { });
            this.AddRangeToColumnsDefiningUniqueness(new Column[] { this.PK_RegistryIdentifierID });
            this.AddRangeToSummaryColumns(new Column[] { this.PK_RegistryIdentifierID });
            this.AddRangeToStructuralColumns(new Column[] { });
            this.AddRangeToPascalCaseColumns(new Column[] { });
        }





        /// <summary>
        /// dmregistryidentifier
        /// </summary>
        public override string TableAlias
        {
            get { return "dmregistryidentifier"; }
        }

        /// <summary>
        /// RegistryIdentifier
        /// </summary>
        public override string TableName
        {
            get { return "RegistryIdentifier"; }
        }

        /// <summary>
        /// The identifier of a Registry.
        /// </summary>
        public override string TableDescription
        {
            get { return "The identifier of a Registry."; }
        }

        /// <summary>
        /// The Columns that make up this RegistryIdentifierTable.
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