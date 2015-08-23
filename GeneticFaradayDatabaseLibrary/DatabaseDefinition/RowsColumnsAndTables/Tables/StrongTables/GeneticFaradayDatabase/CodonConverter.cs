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
        /// Converts a Codon.
        /// </summary>
        public static CodonConverterTable CodonConverterTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.CodonConverterTable.Instance; }
        }

        /// <summary>
        /// Converts a Codon.
        /// </summary>
        [Serializable]
        public static partial class CodonConverter
        {
            /// <summary>
            /// PK_CodonConverterID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public static CodonConverterTable.PK_CodonConverterIDColumn PK_CodonConverterID
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterTable.PK_CodonConverterID; }
            }

            /// <summary>
            /// The CodonConverterIdentifier of the Codon Converter.
            /// </summary>
            public static CodonConverterTable.CodonConverterIdentifierColumn CodonConverterIdentifier
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterTable.CodonConverterIdentifier; }
            }

            /// <summary>
            /// The GeneticCode to which this CodonConverter applies.
            /// </summary>
            public static CodonConverterTable.GeneticCodeColumn GeneticCode
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterTable.GeneticCode; }
            }

            /// <summary>
            /// Creates a row in the CodonConverter table.
            /// </summary>
            /// <param name="codonConverterIdentifier">The CodonConverterIdentifier of the Codon Converter.</param>
            /// <param name="geneticCode">The GeneticCode to which this CodonConverter applies.</param>
            public static Row ToRow(System.String codonConverterIdentifier, System.Int32 geneticCode)
            {
                return new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterTable, new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterTable.CodonConverterIdentifier, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterTable.GeneticCode }, new object[] { codonConverterIdentifier, geneticCode });
            }
        }
    }

    /// <summary>
    /// Converts a Codon.
    /// </summary>
    [Serializable]
    public sealed partial class CodonConverterTable : TableDefinition
    {
        /// <summary>
        /// The single instance of the CodonConverterTable.
        /// </summary>
        public static readonly CodonConverterTable Instance = new CodonConverterTable();

        /// <summary>
        /// PK_CodonConverterID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_CodonConverterIDColumn PK_CodonConverterID { get; private set; }

        /// <summary>
        /// The CodonConverterIdentifier of the Codon Converter.
        /// </summary>
        public CodonConverterIdentifierColumn CodonConverterIdentifier { get; private set; }

        /// <summary>
        /// The GeneticCode to which this CodonConverter applies.
        /// </summary>
        public GeneticCodeColumn GeneticCode { get; private set; }

        /// <summary>
        /// PK_CodonConverterID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_CodonConverterIDColumn PrimaryColumn
        {
            get { return this.PK_CodonConverterID; }
        }

        #region Strong Column Classes
        /// <summary>
        /// PK_CodonConverterID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [Serializable]
        public sealed partial class PK_CodonConverterIDColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the PK_CodonConverterID column.
            /// </summary>
            public PK_CodonConverterIDColumn()
                : base()
            {

            }

            /// <summary>
            /// PK_CodonConverterID
            /// </summary>
            public override string Name
            {
                get { return "PK_CodonConverterID"; }
            }

            /// <summary>
            /// Codon Converter Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Codon Converter Identifier"; }
            }

            /// <summary>
            /// PK_CodonConverterID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public override string Description
            {
                get { return "PK_CodonConverterID int IDENTITY (1,1) PRIMARY KEY,"; }
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
            /// CodonConverterTable
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
        /// The CodonConverterIdentifier of the Codon Converter.
        /// </summary>
        [Serializable]
        public sealed partial class CodonConverterIdentifierColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the CodonConverterIdentifier column.
            /// </summary>
            public CodonConverterIdentifierColumn()
                : base()
            {

            }

            /// <summary>
            /// CodonConverterIdentifier
            /// </summary>
            public override string Name
            {
                get { return "CodonConverterIdentifier"; }
            }

            /// <summary>
            /// Codon Converter Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Codon Converter Identifier"; }
            }

            /// <summary>
            /// The CodonConverterIdentifier of the Codon Converter.
            /// </summary>
            public override string Description
            {
                get { return "The CodonConverterIdentifier of the Codon Converter."; }
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
            /// CodonConverterTable
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
        /// The GeneticCode to which this CodonConverter applies.
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
            /// The GeneticCode to which this CodonConverter applies.
            /// </summary>
            public override string Description
            {
                get { return "The GeneticCode to which this CodonConverter applies."; }
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
            /// CodonConverterTable
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
        /// Constructs the single instance of the CodonConverterTable.
        /// </summary>
        public CodonConverterTable()
            : base()
        {
            this.PK_CodonConverterID = new PK_CodonConverterIDColumn() { TableDefinition = this };
            this.CodonConverterIdentifier = new CodonConverterIdentifierColumn() { TableDefinition = this };
            this.GeneticCode = new GeneticCodeColumn() { TableDefinition = this };
            this.Columns = new ColumnCollection(this, this.PrimaryColumn, new Column[] { this.CodonConverterIdentifier, this.GeneticCode });
            this.AddRangeToColumnsDefiningUniqueness(new Column[] { this.CodonConverterIdentifier, this.GeneticCode });
            this.AddRangeToSummaryColumns(new Column[] { this.CodonConverterIdentifier, this.GeneticCode });
            this.AddRangeToStructuralColumns(new Column[] { });
            this.AddRangeToPascalCaseColumns(new Column[] { });
        }





        /// <summary>
        /// dmcodonconverter
        /// </summary>
        public override string TableAlias
        {
            get { return "dmcodonconverter"; }
        }

        /// <summary>
        /// CodonConverter
        /// </summary>
        public override string TableName
        {
            get { return "CodonConverter"; }
        }

        /// <summary>
        /// Converts a Codon.
        /// </summary>
        public override string TableDescription
        {
            get { return "Converts a Codon."; }
        }

        /// <summary>
        /// The Columns that make up this CodonConverterTable.
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