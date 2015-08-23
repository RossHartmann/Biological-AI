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
        /// The name of the Nucleotide.
        /// </summary>
        public static NucleotideTable NucleotideTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.NucleotideTable.Instance; }
        }

        /// <summary>
        /// The name of the Nucleotide.
        /// </summary>
        [Serializable]
        public static partial class Nucleotide
        {
            /// <summary>
            /// PK_NucleotideID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public static NucleotideTable.PK_NucleotideIDColumn PK_NucleotideID
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.NucleotideTable.PK_NucleotideID; }
            }

            /// <summary>
            /// The name of the Nucleotide.
            /// </summary>
            public static NucleotideTable.NameColumn Name
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.NucleotideTable.Name; }
            }

            /// <summary>
            /// The GeneticCode to which this Nucleotide applies.
            /// </summary>
            public static NucleotideTable.GeneticCodeColumn GeneticCode
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.NucleotideTable.GeneticCode; }
            }

            /// <summary>
            /// Creates a row in the Nucleotide table.
            /// </summary>
            /// <param name="name">The name of the Nucleotide.</param>
            /// <param name="geneticCode">The GeneticCode to which this Nucleotide applies.</param>
            public static Row ToRow(System.String name, System.Int32 geneticCode)
            {
                return new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.NucleotideTable, new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.NucleotideTable.Name, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.NucleotideTable.GeneticCode }, new object[] { name, geneticCode });
            }
        }
    }

    /// <summary>
    /// The name of the Nucleotide.
    /// </summary>
    [Serializable]
    public sealed partial class NucleotideTable : TableDefinition
    {
        /// <summary>
        /// The single instance of the NucleotideTable.
        /// </summary>
        public static readonly NucleotideTable Instance = new NucleotideTable();

        /// <summary>
        /// PK_NucleotideID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_NucleotideIDColumn PK_NucleotideID { get; private set; }

        /// <summary>
        /// The name of the Nucleotide.
        /// </summary>
        public NameColumn Name { get; private set; }

        /// <summary>
        /// The GeneticCode to which this Nucleotide applies.
        /// </summary>
        public GeneticCodeColumn GeneticCode { get; private set; }

        /// <summary>
        /// PK_NucleotideID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_NucleotideIDColumn PrimaryColumn
        {
            get { return this.PK_NucleotideID; }
        }

        #region Strong Column Classes
        /// <summary>
        /// PK_NucleotideID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [Serializable]
        public sealed partial class PK_NucleotideIDColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the PK_NucleotideID column.
            /// </summary>
            public PK_NucleotideIDColumn()
                : base()
            {

            }

            /// <summary>
            /// PK_NucleotideID
            /// </summary>
            public override string Name
            {
                get { return "PK_NucleotideID"; }
            }

            /// <summary>
            /// Nucleotide Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Nucleotide Identifier"; }
            }

            /// <summary>
            /// PK_NucleotideID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public override string Description
            {
                get { return "PK_NucleotideID int IDENTITY (1,1) PRIMARY KEY,"; }
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
            /// NucleotideTable
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
        /// The name of the Nucleotide.
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
            /// The name of the Nucleotide.
            /// </summary>
            public override string Description
            {
                get { return "The name of the Nucleotide."; }
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
            /// 50
            /// </summary>
            public override int? Length
            {
                get { return 50; }
            }

            /// <summary>
            /// NucleotideTable
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
        /// The GeneticCode to which this Nucleotide applies.
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
            /// The GeneticCode to which this Nucleotide applies.
            /// </summary>
            public override string Description
            {
                get { return "The GeneticCode to which this Nucleotide applies."; }
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
            /// NucleotideTable
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
        /// Constructs the single instance of the NucleotideTable.
        /// </summary>
        public NucleotideTable()
            : base()
        {
            this.PK_NucleotideID = new PK_NucleotideIDColumn() { TableDefinition = this };
            this.Name = new NameColumn() { TableDefinition = this };
            this.GeneticCode = new GeneticCodeColumn() { TableDefinition = this };
            this.Columns = new ColumnCollection(this, this.PrimaryColumn, new Column[] { this.Name, this.GeneticCode });
            this.AddRangeToColumnsDefiningUniqueness(new Column[] { this.Name, this.GeneticCode });
            this.AddRangeToSummaryColumns(new Column[] { this.Name, this.GeneticCode });
            this.AddRangeToStructuralColumns(new Column[] { });
            this.AddRangeToPascalCaseColumns(new Column[] { });
        }





        /// <summary>
        /// dmnucleotide
        /// </summary>
        public override string TableAlias
        {
            get { return "dmnucleotide"; }
        }

        /// <summary>
        /// Nucleotide
        /// </summary>
        public override string TableName
        {
            get { return "Nucleotide"; }
        }

        /// <summary>
        /// The name of the Nucleotide.
        /// </summary>
        public override string TableDescription
        {
            get { return "The name of the Nucleotide."; }
        }

        /// <summary>
        /// The Columns that make up this NucleotideTable.
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