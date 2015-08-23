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
        /// Ties a Nucleotide to a Codon
        /// </summary>
        public static CodonNucleotideTable CodonNucleotideTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.CodonNucleotideTable.Instance; }
        }

        /// <summary>
        /// Ties a Nucleotide to a Codon
        /// </summary>
        [Serializable]
        public static partial class CodonNucleotide
        {
            /// <summary>
            /// PK_CodonNucleotideID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public static CodonNucleotideTable.PK_CodonNucleotideIDColumn PK_CodonNucleotideID
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotideTable.PK_CodonNucleotideID; }
            }

            /// <summary>
            /// The Codon to which the Nucleotide belongs.
            /// </summary>
            public static CodonNucleotideTable.CodonColumn Codon
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotideTable.Codon; }
            }

            /// <summary>
            /// The Nucleotide that belongs to the Codon.
            /// </summary>
            public static CodonNucleotideTable.NucleotideColumn Nucleotide
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotideTable.Nucleotide; }
            }

            /// <summary>
            /// The GeneticCode to which this Function applies.
            /// </summary>
            public static CodonNucleotideTable.GeneticCodeColumn GeneticCode
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotideTable.GeneticCode; }
            }

            /// <summary>
            /// Creates a row in the CodonNucleotide table.
            /// </summary>
            /// <param name="codon">The Codon to which the Nucleotide belongs.</param>
            /// <param name="nucleotide">The Nucleotide that belongs to the Codon.</param>
            /// <param name="geneticCode">The GeneticCode to which this Function applies.</param>
            public static Row ToRow(System.Int32 codon, System.Int32 nucleotide, System.Int32 geneticCode)
            {
                return new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotideTable, new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotideTable.Codon, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotideTable.Nucleotide, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotideTable.GeneticCode }, new object[] { codon, nucleotide, geneticCode });
            }
        }
    }

    /// <summary>
    /// Ties a Nucleotide to a Codon
    /// </summary>
    [Serializable]
    public sealed partial class CodonNucleotideTable : TableDefinition
    {
        /// <summary>
        /// The single instance of the CodonNucleotideTable.
        /// </summary>
        public static readonly CodonNucleotideTable Instance = new CodonNucleotideTable();

        /// <summary>
        /// PK_CodonNucleotideID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_CodonNucleotideIDColumn PK_CodonNucleotideID { get; private set; }

        /// <summary>
        /// The Codon to which the Nucleotide belongs.
        /// </summary>
        public CodonColumn Codon { get; private set; }

        /// <summary>
        /// The Nucleotide that belongs to the Codon.
        /// </summary>
        public NucleotideColumn Nucleotide { get; private set; }

        /// <summary>
        /// The GeneticCode to which this Function applies.
        /// </summary>
        public GeneticCodeColumn GeneticCode { get; private set; }

        /// <summary>
        /// PK_CodonNucleotideID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_CodonNucleotideIDColumn PrimaryColumn
        {
            get { return this.PK_CodonNucleotideID; }
        }

        #region Strong Column Classes
        /// <summary>
        /// PK_CodonNucleotideID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [Serializable]
        public sealed partial class PK_CodonNucleotideIDColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the PK_CodonNucleotideID column.
            /// </summary>
            public PK_CodonNucleotideIDColumn()
                : base()
            {

            }

            /// <summary>
            /// PK_CodonNucleotideID
            /// </summary>
            public override string Name
            {
                get { return "PK_CodonNucleotideID"; }
            }

            /// <summary>
            /// Codon Nucleotide Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Codon Nucleotide Identifier"; }
            }

            /// <summary>
            /// PK_CodonNucleotideID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public override string Description
            {
                get { return "PK_CodonNucleotideID int IDENTITY (1,1) PRIMARY KEY,"; }
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
            /// CodonNucleotideTable
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
        /// The Codon to which the Nucleotide belongs.
        /// </summary>
        [Serializable]
        public sealed partial class CodonColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the Codon column.
            /// </summary>
            public CodonColumn()
                : base()
            {

            }

            /// <summary>
            /// Codon
            /// </summary>
            public override string Name
            {
                get { return "Codon"; }
            }

            /// <summary>
            /// Codon
            /// </summary>
            public override string DisplayText
            {
                get { return "Codon"; }
            }

            /// <summary>
            /// The Codon to which the Nucleotide belongs.
            /// </summary>
            public override string Description
            {
                get { return "The Codon to which the Nucleotide belongs."; }
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
            /// CodonNucleotideTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable.PK_CodonID
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable.PK_CodonID; }
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
        /// The Nucleotide that belongs to the Codon.
        /// </summary>
        [Serializable]
        public sealed partial class NucleotideColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the Nucleotide column.
            /// </summary>
            public NucleotideColumn()
                : base()
            {

            }

            /// <summary>
            /// Nucleotide
            /// </summary>
            public override string Name
            {
                get { return "Nucleotide"; }
            }

            /// <summary>
            /// Nucleotide
            /// </summary>
            public override string DisplayText
            {
                get { return "Nucleotide"; }
            }

            /// <summary>
            /// The Nucleotide that belongs to the Codon.
            /// </summary>
            public override string Description
            {
                get { return "The Nucleotide that belongs to the Codon."; }
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
            /// CodonNucleotideTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.NucleotideTable.PK_NucleotideID
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.NucleotideTable.PK_NucleotideID; }
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
            /// CodonNucleotideTable
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
        /// Constructs the single instance of the CodonNucleotideTable.
        /// </summary>
        public CodonNucleotideTable()
            : base()
        {
            this.PK_CodonNucleotideID = new PK_CodonNucleotideIDColumn() { TableDefinition = this };
            this.Codon = new CodonColumn() { TableDefinition = this };
            this.Nucleotide = new NucleotideColumn() { TableDefinition = this };
            this.GeneticCode = new GeneticCodeColumn() { TableDefinition = this };
            this.Columns = new ColumnCollection(this, this.PrimaryColumn, new Column[] { this.Codon, this.Nucleotide, this.GeneticCode });
            this.AddRangeToColumnsDefiningUniqueness(new Column[] { this.Codon, this.Nucleotide });
            this.AddRangeToSummaryColumns(new Column[] { this.Codon, this.Nucleotide });
            this.AddRangeToStructuralColumns(new Column[] { });
            this.AddRangeToPascalCaseColumns(new Column[] { });
        }





        /// <summary>
        /// dmcodonnucleotide
        /// </summary>
        public override string TableAlias
        {
            get { return "dmcodonnucleotide"; }
        }

        /// <summary>
        /// CodonNucleotide
        /// </summary>
        public override string TableName
        {
            get { return "CodonNucleotide"; }
        }

        /// <summary>
        /// Ties a Nucleotide to a Codon
        /// </summary>
        public override string TableDescription
        {
            get { return "Ties a Nucleotide to a Codon"; }
        }

        /// <summary>
        /// The Columns that make up this CodonNucleotideTable.
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