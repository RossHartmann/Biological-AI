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
        /// The type of Parameter.
        /// </summary>
        public static ParameterTypeTable ParameterTypeTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.ParameterTypeTable.Instance; }
        }

        /// <summary>
        /// The type of Parameter.
        /// </summary>
        [Serializable]
        public static partial class ParameterType
        {
            /// <summary>
            /// PK_ParameterTypeID varchar(50) UNIQUE PRIMARY KEY,
            /// </summary>
            public static ParameterTypeTable.PK_ParameterTypeIDColumn PK_ParameterTypeID
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTypeTable.PK_ParameterTypeID; }
            }

            /// <summary>
            /// Creates a row in the ParameterType table.
            /// </summary>
            public static Row ToRow()
            {
                return new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTypeTable, new Column[] { }, new object[] { });
            }
        }
    }

    /// <summary>
    /// The type of Parameter.
    /// </summary>
    [Serializable]
    public sealed partial class ParameterTypeTable : TableDefinition
    {
        /// <summary>
        /// The single instance of the ParameterTypeTable.
        /// </summary>
        public static readonly ParameterTypeTable Instance = new ParameterTypeTable();

        /// <summary>
        /// PK_ParameterTypeID varchar(50) UNIQUE PRIMARY KEY,
        /// </summary>
        public PK_ParameterTypeIDColumn PK_ParameterTypeID { get; private set; }

        /// <summary>
        /// PK_ParameterTypeID varchar(50) UNIQUE PRIMARY KEY,
        /// </summary>
        public PK_ParameterTypeIDColumn PrimaryColumn
        {
            get { return this.PK_ParameterTypeID; }
        }

        #region Strong Column Classes
        /// <summary>
        /// PK_ParameterTypeID varchar(50) UNIQUE PRIMARY KEY,
        /// </summary>
        [Serializable]
        public sealed partial class PK_ParameterTypeIDColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the PK_ParameterTypeID column.
            /// </summary>
            public PK_ParameterTypeIDColumn()
                : base()
            {

            }

            /// <summary>
            /// PK_ParameterTypeID
            /// </summary>
            public override string Name
            {
                get { return "PK_ParameterTypeID"; }
            }

            /// <summary>
            /// Parameter Type Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Parameter Type Identifier"; }
            }

            /// <summary>
            /// PK_ParameterTypeID varchar(50) UNIQUE PRIMARY KEY,
            /// </summary>
            public override string Description
            {
                get { return "PK_ParameterTypeID varchar(50) UNIQUE PRIMARY KEY,"; }
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
            /// 50
            /// </summary>
            public override int? Length
            {
                get { return 50; }
            }

            /// <summary>
            /// ParameterTypeTable
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
            /// global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.ParameterType.GetValuesAsStrings()
            /// </summary>
            public override IEnumerable<string> GetEnumColumnValuesAsStrings()
            {
                return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.ParameterType.GetValuesAsStrings();
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
        /// Constructs the single instance of the ParameterTypeTable.
        /// </summary>
        public ParameterTypeTable()
            : base()
        {
            this.PK_ParameterTypeID = new PK_ParameterTypeIDColumn() { TableDefinition = this };
            this.Columns = new ColumnCollection(this, this.PrimaryColumn, new Column[] { });
            this.AddRangeToColumnsDefiningUniqueness(new Column[] { this.PK_ParameterTypeID });
            this.AddRangeToSummaryColumns(new Column[] { this.PK_ParameterTypeID });
            this.AddRangeToStructuralColumns(new Column[] { });
            this.AddRangeToPascalCaseColumns(new Column[] { });
        }





        /// <summary>
        /// dmparametertype
        /// </summary>
        public override string TableAlias
        {
            get { return "dmparametertype"; }
        }

        /// <summary>
        /// ParameterType
        /// </summary>
        public override string TableName
        {
            get { return "ParameterType"; }
        }

        /// <summary>
        /// The type of Parameter.
        /// </summary>
        public override string TableDescription
        {
            get { return "The type of Parameter."; }
        }

        /// <summary>
        /// The Columns that make up this ParameterTypeTable.
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