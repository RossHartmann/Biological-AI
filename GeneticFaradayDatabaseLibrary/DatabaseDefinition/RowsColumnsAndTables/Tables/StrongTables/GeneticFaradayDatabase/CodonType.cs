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
        /// The type of a Codon.
        /// </summary>
        public static CodonTypeTable CodonTypeTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.CodonTypeTable.Instance; }
        }

        /// <summary>
        /// The type of a Codon.
        /// </summary>
        [Serializable]
        public static partial class CodonType
        {
            /// <summary>
            /// PK_CodonTypeID varchar(20) UNIQUE PRIMARY KEY,
            /// </summary>
            public static CodonTypeTable.PK_CodonTypeIDColumn PK_CodonTypeID
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTypeTable.PK_CodonTypeID; }
            }

            /// <summary>
            /// Creates a row in the CodonType table.
            /// </summary>
            public static Row ToRow()
            {
                return new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTypeTable, new Column[] { }, new object[] { });
            }
        }
    }

    /// <summary>
    /// The type of a Codon.
    /// </summary>
    [Serializable]
    public sealed partial class CodonTypeTable : TableDefinition
    {
        /// <summary>
        /// The single instance of the CodonTypeTable.
        /// </summary>
        public static readonly CodonTypeTable Instance = new CodonTypeTable();

        /// <summary>
        /// PK_CodonTypeID varchar(20) UNIQUE PRIMARY KEY,
        /// </summary>
        public PK_CodonTypeIDColumn PK_CodonTypeID { get; private set; }

        /// <summary>
        /// PK_CodonTypeID varchar(20) UNIQUE PRIMARY KEY,
        /// </summary>
        public PK_CodonTypeIDColumn PrimaryColumn
        {
            get { return this.PK_CodonTypeID; }
        }

        #region Strong Column Classes
        /// <summary>
        /// PK_CodonTypeID varchar(20) UNIQUE PRIMARY KEY,
        /// </summary>
        [Serializable]
        public sealed partial class PK_CodonTypeIDColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the PK_CodonTypeID column.
            /// </summary>
            public PK_CodonTypeIDColumn()
                : base()
            {

            }

            /// <summary>
            /// PK_CodonTypeID
            /// </summary>
            public override string Name
            {
                get { return "PK_CodonTypeID"; }
            }

            /// <summary>
            /// Codon Type Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Codon Type Identifier"; }
            }

            /// <summary>
            /// PK_CodonTypeID varchar(20) UNIQUE PRIMARY KEY,
            /// </summary>
            public override string Description
            {
                get { return "PK_CodonTypeID varchar(20) UNIQUE PRIMARY KEY,"; }
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
            /// 20
            /// </summary>
            public override int? Length
            {
                get { return 20; }
            }

            /// <summary>
            /// CodonTypeTable
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
            /// global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.CodonType.GetValuesAsStrings()
            /// </summary>
            public override IEnumerable<string> GetEnumColumnValuesAsStrings()
            {
                return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.CodonType.GetValuesAsStrings();
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
        /// Constructs the single instance of the CodonTypeTable.
        /// </summary>
        public CodonTypeTable()
            : base()
        {
            this.PK_CodonTypeID = new PK_CodonTypeIDColumn() { TableDefinition = this };
            this.Columns = new ColumnCollection(this, this.PrimaryColumn, new Column[] { });
            this.AddRangeToColumnsDefiningUniqueness(new Column[] { this.PK_CodonTypeID });
            this.AddRangeToSummaryColumns(new Column[] { this.PK_CodonTypeID });
            this.AddRangeToStructuralColumns(new Column[] { });
            this.AddRangeToPascalCaseColumns(new Column[] { });
        }





        /// <summary>
        /// dmcodontype
        /// </summary>
        public override string TableAlias
        {
            get { return "dmcodontype"; }
        }

        /// <summary>
        /// CodonType
        /// </summary>
        public override string TableName
        {
            get { return "CodonType"; }
        }

        /// <summary>
        /// The type of a Codon.
        /// </summary>
        public override string TableDescription
        {
            get { return "The type of a Codon."; }
        }

        /// <summary>
        /// The Columns that make up this CodonTypeTable.
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