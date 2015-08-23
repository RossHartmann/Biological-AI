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
        /// The identifier of the Codon Converter.
        /// </summary>
        public static CodonConverterIdentifierTable CodonConverterIdentifierTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.CodonConverterIdentifierTable.Instance; }
        }

        /// <summary>
        /// The identifier of the Codon Converter.
        /// </summary>
        [Serializable]
        public static partial class CodonConverterIdentifier
        {
            /// <summary>
            /// The ID of a Codon Converter
            /// </summary>
            public static CodonConverterIdentifierTable.PK_CodonConverterIdentifierIDColumn PK_CodonConverterIdentifierID
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifierTable.PK_CodonConverterIdentifierID; }
            }

            /// <summary>
            /// Creates a row in the CodonConverterIdentifier table.
            /// </summary>
            public static Row ToRow()
            {
                return new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifierTable, new Column[] { }, new object[] { });
            }
        }
    }

    /// <summary>
    /// The identifier of the Codon Converter.
    /// </summary>
    [Serializable]
    public sealed partial class CodonConverterIdentifierTable : TableDefinition
    {
        /// <summary>
        /// The single instance of the CodonConverterIdentifierTable.
        /// </summary>
        public static readonly CodonConverterIdentifierTable Instance = new CodonConverterIdentifierTable();

        /// <summary>
        /// The ID of a Codon Converter
        /// </summary>
        public PK_CodonConverterIdentifierIDColumn PK_CodonConverterIdentifierID { get; private set; }

        /// <summary>
        /// The ID of a Codon Converter
        /// </summary>
        public PK_CodonConverterIdentifierIDColumn PrimaryColumn
        {
            get { return this.PK_CodonConverterIdentifierID; }
        }

        #region Strong Column Classes
        /// <summary>
        /// The ID of a Codon Converter
        /// </summary>
        [Serializable]
        public sealed partial class PK_CodonConverterIdentifierIDColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the PK_CodonConverterIdentifierID column.
            /// </summary>
            public PK_CodonConverterIdentifierIDColumn()
                : base()
            {

            }

            /// <summary>
            /// PK_CodonConverterIdentifierID
            /// </summary>
            public override string Name
            {
                get { return "PK_CodonConverterIdentifierID"; }
            }

            /// <summary>
            /// Codon Converter Identifier Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Codon Converter Identifier Identifier"; }
            }

            /// <summary>
            /// The ID of a Codon Converter
            /// </summary>
            public override string Description
            {
                get { return "The ID of a Codon Converter"; }
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
            /// CodonConverterIdentifierTable
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
            /// global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.CodonConverterIdentifier.GetValuesAsStrings()
            /// </summary>
            public override IEnumerable<string> GetEnumColumnValuesAsStrings()
            {
                return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums.CodonConverterIdentifier.GetValuesAsStrings();
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
        /// Constructs the single instance of the CodonConverterIdentifierTable.
        /// </summary>
        public CodonConverterIdentifierTable()
            : base()
        {
            this.PK_CodonConverterIdentifierID = new PK_CodonConverterIdentifierIDColumn() { TableDefinition = this };
            this.Columns = new ColumnCollection(this, this.PrimaryColumn, new Column[] { });
            this.AddRangeToColumnsDefiningUniqueness(new Column[] { this.PK_CodonConverterIdentifierID });
            this.AddRangeToSummaryColumns(new Column[] { this.PK_CodonConverterIdentifierID });
            this.AddRangeToStructuralColumns(new Column[] { });
            this.AddRangeToPascalCaseColumns(new Column[] { });
        }





        /// <summary>
        /// dmcodonconverteridentifier
        /// </summary>
        public override string TableAlias
        {
            get { return "dmcodonconverteridentifier"; }
        }

        /// <summary>
        /// CodonConverterIdentifier
        /// </summary>
        public override string TableName
        {
            get { return "CodonConverterIdentifier"; }
        }

        /// <summary>
        /// The identifier of the Codon Converter.
        /// </summary>
        public override string TableDescription
        {
            get { return "The identifier of the Codon Converter."; }
        }

        /// <summary>
        /// The Columns that make up this CodonConverterIdentifierTable.
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