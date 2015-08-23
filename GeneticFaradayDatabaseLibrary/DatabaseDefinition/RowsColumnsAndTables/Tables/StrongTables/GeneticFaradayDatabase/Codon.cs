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
        /// A Codon in the Genetic Code.
        /// </summary>
        public static CodonTable CodonTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.CodonTable.Instance; }
        }

        /// <summary>
        /// A Codon in the Genetic Code.
        /// </summary>
        [Serializable]
        public static partial class Codon
        {
            /// <summary>
            /// PK_CodonID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public static CodonTable.PK_CodonIDColumn PK_CodonID
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable.PK_CodonID; }
            }

            /// <summary>
            /// The CodonIdentifier of this Codon.
            /// </summary>
            public static CodonTable.NameColumn Name
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable.Name; }
            }

            /// <summary>
            /// The GeneticCode to which this Codon applies.
            /// </summary>
            public static CodonTable.GeneticCodeColumn GeneticCode
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable.GeneticCode; }
            }

            /// <summary>
            /// The pair of Functions for which this Codon encodes.
            /// </summary>
            public static CodonTable.FunctionPairColumn FunctionPair
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable.FunctionPair; }
            }

            /// <summary>
            /// The type of Codon.
            /// </summary>
            public static CodonTable.CodonTypeColumn CodonType
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable.CodonType; }
            }

            /// <summary>
            /// Creates a row in the Codon table.
            /// </summary>
            /// <param name="name">The CodonIdentifier of this Codon.</param>
            /// <param name="geneticCode">The GeneticCode to which this Codon applies.</param>
            /// <param name="functionPair">The pair of Functions for which this Codon encodes.</param>
            /// <param name="codonType">The type of Codon.</param>
            public static Row ToRow(System.String name, System.Int32 geneticCode, System.Int32 functionPair, StrongEnums.CodonType codonType)
            {
                return new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable, new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable.Name, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable.GeneticCode, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable.FunctionPair, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable.CodonType }, new object[] { name, geneticCode, functionPair, codonType });
            }
        }
    }

    /// <summary>
    /// A Codon in the Genetic Code.
    /// </summary>
    [Serializable]
    public sealed partial class CodonTable : TableDefinition
    {
        /// <summary>
        /// The single instance of the CodonTable.
        /// </summary>
        public static readonly CodonTable Instance = new CodonTable();

        /// <summary>
        /// PK_CodonID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_CodonIDColumn PK_CodonID { get; private set; }

        /// <summary>
        /// The CodonIdentifier of this Codon.
        /// </summary>
        public NameColumn Name { get; private set; }

        /// <summary>
        /// The GeneticCode to which this Codon applies.
        /// </summary>
        public GeneticCodeColumn GeneticCode { get; private set; }

        /// <summary>
        /// The pair of Functions for which this Codon encodes.
        /// </summary>
        public FunctionPairColumn FunctionPair { get; private set; }

        /// <summary>
        /// The type of Codon.
        /// </summary>
        public CodonTypeColumn CodonType { get; private set; }

        /// <summary>
        /// PK_CodonID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_CodonIDColumn PrimaryColumn
        {
            get { return this.PK_CodonID; }
        }

        #region Strong Column Classes
        /// <summary>
        /// PK_CodonID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [Serializable]
        public sealed partial class PK_CodonIDColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the PK_CodonID column.
            /// </summary>
            public PK_CodonIDColumn()
                : base()
            {

            }

            /// <summary>
            /// PK_CodonID
            /// </summary>
            public override string Name
            {
                get { return "PK_CodonID"; }
            }

            /// <summary>
            /// Codon Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Codon Identifier"; }
            }

            /// <summary>
            /// PK_CodonID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public override string Description
            {
                get { return "PK_CodonID int IDENTITY (1,1) PRIMARY KEY,"; }
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
            /// CodonTable
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
        /// The CodonIdentifier of this Codon.
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
            /// The CodonIdentifier of this Codon.
            /// </summary>
            public override string Description
            {
                get { return "The CodonIdentifier of this Codon."; }
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
            /// CodonTable
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
        /// The GeneticCode to which this Codon applies.
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
            /// The GeneticCode to which this Codon applies.
            /// </summary>
            public override string Description
            {
                get { return "The GeneticCode to which this Codon applies."; }
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
            /// CodonTable
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
        /// The pair of Functions for which this Codon encodes.
        /// </summary>
        [Serializable]
        public sealed partial class FunctionPairColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the FunctionPair column.
            /// </summary>
            public FunctionPairColumn()
                : base()
            {

            }

            /// <summary>
            /// FunctionPair
            /// </summary>
            public override string Name
            {
                get { return "FunctionPair"; }
            }

            /// <summary>
            /// Function Pair
            /// </summary>
            public override string DisplayText
            {
                get { return "Function Pair"; }
            }

            /// <summary>
            /// The pair of Functions for which this Codon encodes.
            /// </summary>
            public override string Description
            {
                get { return "The pair of Functions for which this Codon encodes."; }
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
            /// CodonTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable.PK_FunctionPairID
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable.PK_FunctionPairID; }
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
        /// The type of Codon.
        /// </summary>
        [Serializable]
        public sealed partial class CodonTypeColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the CodonType column.
            /// </summary>
            public CodonTypeColumn()
                : base()
            {
                this.AcceptableValueDomain = new List<object> { "Standard", "Stop" };
            }

            /// <summary>
            /// CodonType
            /// </summary>
            public override string Name
            {
                get { return "CodonType"; }
            }

            /// <summary>
            /// Codon Type
            /// </summary>
            public override string DisplayText
            {
                get { return "Codon Type"; }
            }

            /// <summary>
            /// The type of Codon.
            /// </summary>
            public override string Description
            {
                get { return "The type of Codon."; }
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
            /// StrongEnums.CodonType
            /// </summary>
            public override Type ValueType
            {
                get { return typeof(StrongEnums.CodonType); }
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
            /// 20
            /// </summary>
            public override int? Length
            {
                get { return 20; }
            }

            /// <summary>
            /// CodonTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTypeTable.PK_CodonTypeID
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTypeTable.PK_CodonTypeID; }
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
        #endregion

        /// <summary>
        /// Constructs the single instance of the CodonTable.
        /// </summary>
        public CodonTable()
            : base()
        {
            this.PK_CodonID = new PK_CodonIDColumn() { TableDefinition = this };
            this.Name = new NameColumn() { TableDefinition = this };
            this.GeneticCode = new GeneticCodeColumn() { TableDefinition = this };
            this.FunctionPair = new FunctionPairColumn() { TableDefinition = this };
            this.CodonType = new CodonTypeColumn() { TableDefinition = this };
            this.Columns = new ColumnCollection(this, this.PrimaryColumn, new Column[] { this.Name, this.GeneticCode, this.FunctionPair, this.CodonType });
            this.AddRangeToColumnsDefiningUniqueness(new Column[] { this.Name, this.GeneticCode });
            this.AddRangeToSummaryColumns(new Column[] { this.Name, this.GeneticCode });
            this.AddRangeToStructuralColumns(new Column[] { });
            this.AddRangeToPascalCaseColumns(new Column[] { });
        }





        /// <summary>
        /// dmcodon
        /// </summary>
        public override string TableAlias
        {
            get { return "dmcodon"; }
        }

        /// <summary>
        /// Codon
        /// </summary>
        public override string TableName
        {
            get { return "Codon"; }
        }

        /// <summary>
        /// A Codon in the Genetic Code.
        /// </summary>
        public override string TableDescription
        {
            get { return "A Codon in the Genetic Code."; }
        }

        /// <summary>
        /// The Columns that make up this CodonTable.
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