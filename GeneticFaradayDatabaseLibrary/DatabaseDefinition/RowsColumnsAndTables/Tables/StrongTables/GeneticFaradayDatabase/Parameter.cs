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
        /// A Parameter to a Function.
        /// </summary>
        public static ParameterTable ParameterTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.ParameterTable.Instance; }
        }

        /// <summary>
        /// A Parameter to a Function.
        /// </summary>
        [Serializable]
        public static partial class Parameter
        {
            /// <summary>
            /// PK_ParameterID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public static ParameterTable.PK_ParameterIDColumn PK_ParameterID
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable.PK_ParameterID; }
            }

            /// <summary>
            /// The Parameter Type of the Parameter.
            /// </summary>
            public static ParameterTable.ParameterTypeColumn ParameterType
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable.ParameterType; }
            }

            /// <summary>
            /// Only used if the ParameterType is ParameterType.ConvertedCodon. The ICodonConverter as identified by this ICodonConverterIdentifier will be used to convert an ICodon and will then be passed to the IArgument that this IParameter defines.
            /// </summary>
            public static ParameterTable.CodonConverterIdentifierColumn CodonConverterIdentifier
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable.CodonConverterIdentifier; }
            }

            /// <summary>
            /// The function to which the Parameter belongs.
            /// </summary>
            public static ParameterTable.ParentFunctionColumn ParentFunction
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable.ParentFunction; }
            }

            /// <summary>
            /// The index of the Parameter in the parent Function.
            /// </summary>
            public static ParameterTable.ParameterIndexColumn ParameterIndex
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable.ParameterIndex; }
            }

            /// <summary>
            /// The GeneticCode to which this Function applies.
            /// </summary>
            public static ParameterTable.GeneticCodeColumn GeneticCode
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable.GeneticCode; }
            }

            /// <summary>
            /// Creates a row in the Parameter table.
            /// </summary>
            /// <param name="parameterType">The Parameter Type of the Parameter.</param>
            /// <param name="parentFunction">The function to which the Parameter belongs.</param>
            /// <param name="parameterIndex">The index of the Parameter in the parent Function.</param>
            /// <param name="geneticCode">The GeneticCode to which this Function applies.</param>
            /// <param name="codonConverterIdentifier">Only used if the ParameterType is ParameterType.ConvertedCodon. The ICodonConverter as identified by this ICodonConverterIdentifier will be used to convert an ICodon and will then be passed to the IArgument that this IParameter defines.</param>
            public static Row ToRow(StrongEnums.ParameterType parameterType, System.Int32 parentFunction, System.Int32 parameterIndex, System.Int32 geneticCode, StrongEnums.CodonConverterIdentifier codonConverterIdentifier = null)
            {
                return new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable, new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable.ParameterType, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable.ParentFunction, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable.ParameterIndex, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable.GeneticCode, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable.CodonConverterIdentifier }, new object[] { parameterType, parentFunction, parameterIndex, geneticCode, codonConverterIdentifier });
            }
        }
    }

    /// <summary>
    /// A Parameter to a Function.
    /// </summary>
    [Serializable]
    public sealed partial class ParameterTable : TableDefinition
    {
        /// <summary>
        /// The single instance of the ParameterTable.
        /// </summary>
        public static readonly ParameterTable Instance = new ParameterTable();

        /// <summary>
        /// PK_ParameterID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_ParameterIDColumn PK_ParameterID { get; private set; }

        /// <summary>
        /// The Parameter Type of the Parameter.
        /// </summary>
        public ParameterTypeColumn ParameterType { get; private set; }

        /// <summary>
        /// Only used if the ParameterType is ParameterType.ConvertedCodon. The ICodonConverter as identified by this ICodonConverterIdentifier will be used to convert an ICodon and will then be passed to the IArgument that this IParameter defines.
        /// </summary>
        public CodonConverterIdentifierColumn CodonConverterIdentifier { get; private set; }

        /// <summary>
        /// The function to which the Parameter belongs.
        /// </summary>
        public ParentFunctionColumn ParentFunction { get; private set; }

        /// <summary>
        /// The index of the Parameter in the parent Function.
        /// </summary>
        public ParameterIndexColumn ParameterIndex { get; private set; }

        /// <summary>
        /// The GeneticCode to which this Function applies.
        /// </summary>
        public GeneticCodeColumn GeneticCode { get; private set; }

        /// <summary>
        /// PK_ParameterID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public PK_ParameterIDColumn PrimaryColumn
        {
            get { return this.PK_ParameterID; }
        }

        #region Strong Column Classes
        /// <summary>
        /// PK_ParameterID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [Serializable]
        public sealed partial class PK_ParameterIDColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the PK_ParameterID column.
            /// </summary>
            public PK_ParameterIDColumn()
                : base()
            {

            }

            /// <summary>
            /// PK_ParameterID
            /// </summary>
            public override string Name
            {
                get { return "PK_ParameterID"; }
            }

            /// <summary>
            /// Parameter Identifier
            /// </summary>
            public override string DisplayText
            {
                get { return "Parameter Identifier"; }
            }

            /// <summary>
            /// PK_ParameterID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public override string Description
            {
                get { return "PK_ParameterID int IDENTITY (1,1) PRIMARY KEY,"; }
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
            /// ParameterTable
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
        /// The Parameter Type of the Parameter.
        /// </summary>
        [Serializable]
        public sealed partial class ParameterTypeColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the ParameterType column.
            /// </summary>
            public ParameterTypeColumn()
                : base()
            {
                this.AcceptableValueDomain = new List<object> { "AminoAcid", "ConvertedCodon", "EvaluatedAminoAcid" };
            }

            /// <summary>
            /// ParameterType
            /// </summary>
            public override string Name
            {
                get { return "ParameterType"; }
            }

            /// <summary>
            /// Parameter Type
            /// </summary>
            public override string DisplayText
            {
                get { return "Parameter Type"; }
            }

            /// <summary>
            /// The Parameter Type of the Parameter.
            /// </summary>
            public override string Description
            {
                get { return "The Parameter Type of the Parameter."; }
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
            /// StrongEnums.ParameterType
            /// </summary>
            public override Type ValueType
            {
                get { return typeof(StrongEnums.ParameterType); }
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
            /// ParameterTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTypeTable.PK_ParameterTypeID
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTypeTable.PK_ParameterTypeID; }
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
        /// Only used if the ParameterType is ParameterType.ConvertedCodon. The ICodonConverter as identified by this ICodonConverterIdentifier will be used to convert an ICodon and will then be passed to the IArgument that this IParameter defines.
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
                this.AcceptableValueDomain = new List<object> { "ConvertCodonToDecimal", "ConvertCodonToFloat16", "ConvertCodonToInt16", "ConvertCodonToInt3", "ConvertCodonToInt5" };
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
            /// Only used if the ParameterType is ParameterType.ConvertedCodon. The ICodonConverter as identified by this ICodonConverterIdentifier will be used to convert an ICodon and will then be passed to the IArgument that this IParameter defines.
            /// </summary>
            public override string Description
            {
                get { return "Only used if the ParameterType is ParameterType.ConvertedCodon. The ICodonConverter as identified by this ICodonConverterIdentifier will be used to convert an ICodon and will then be passed to the IArgument that this IParameter defines."; }
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
            /// StrongEnums.CodonConverterIdentifier
            /// </summary>
            public override Type ValueType
            {
                get { return typeof(StrongEnums.CodonConverterIdentifier); }
            }

            /// <summary>
            /// True
            /// </summary>
            public override bool CanBeNull
            {
                get { return true; }
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
            /// ParameterTable
            /// </summary>
            public override TableDefinition TableDefinition { get; set; }

            /// <summary>
            /// global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifierTable.PK_CodonConverterIdentifierID
            /// </summary>
            public override Column ForeignColumnReference
            {
                get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifierTable.PK_CodonConverterIdentifierID; }
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
        /// The function to which the Parameter belongs.
        /// </summary>
        [Serializable]
        public sealed partial class ParentFunctionColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the ParentFunction column.
            /// </summary>
            public ParentFunctionColumn()
                : base()
            {

            }

            /// <summary>
            /// ParentFunction
            /// </summary>
            public override string Name
            {
                get { return "ParentFunction"; }
            }

            /// <summary>
            /// Parent Function
            /// </summary>
            public override string DisplayText
            {
                get { return "Parent Function"; }
            }

            /// <summary>
            /// The function to which the Parameter belongs.
            /// </summary>
            public override string Description
            {
                get { return "The function to which the Parameter belongs."; }
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
            /// ParameterTable
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
        /// The index of the Parameter in the parent Function.
        /// </summary>
        [Serializable]
        public sealed partial class ParameterIndexColumn : Column
        {
            /// <summary>
            /// Constructs an instance of the ParameterIndex column.
            /// </summary>
            public ParameterIndexColumn()
                : base()
            {

            }

            /// <summary>
            /// ParameterIndex
            /// </summary>
            public override string Name
            {
                get { return "ParameterIndex"; }
            }

            /// <summary>
            /// Parameter Index
            /// </summary>
            public override string DisplayText
            {
                get { return "Parameter Index"; }
            }

            /// <summary>
            /// The index of the Parameter in the parent Function.
            /// </summary>
            public override string Description
            {
                get { return "The index of the Parameter in the parent Function."; }
            }

            /// <summary>
            /// Normal
            /// </summary>
            public override ColumnType ColumnType
            {
                get { return ColumnType.Normal; }
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
            /// ParameterTable
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
            /// ParameterTable
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
        /// Constructs the single instance of the ParameterTable.
        /// </summary>
        public ParameterTable()
            : base()
        {
            this.PK_ParameterID = new PK_ParameterIDColumn() { TableDefinition = this };
            this.ParameterType = new ParameterTypeColumn() { TableDefinition = this };
            this.CodonConverterIdentifier = new CodonConverterIdentifierColumn() { TableDefinition = this };
            this.ParentFunction = new ParentFunctionColumn() { TableDefinition = this };
            this.ParameterIndex = new ParameterIndexColumn() { TableDefinition = this };
            this.GeneticCode = new GeneticCodeColumn() { TableDefinition = this };
            this.Columns = new ColumnCollection(this, this.PrimaryColumn, new Column[] { this.ParameterType, this.CodonConverterIdentifier, this.ParentFunction, this.ParameterIndex, this.GeneticCode });
            this.AddRangeToColumnsDefiningUniqueness(new Column[] { this.ParentFunction, this.ParameterIndex });
            this.AddRangeToSummaryColumns(new Column[] { this.ParentFunction, this.ParameterIndex });
            this.AddRangeToStructuralColumns(new Column[] { });
            this.AddRangeToPascalCaseColumns(new Column[] { });
        }





        /// <summary>
        /// dmparameter
        /// </summary>
        public override string TableAlias
        {
            get { return "dmparameter"; }
        }

        /// <summary>
        /// Parameter
        /// </summary>
        public override string TableName
        {
            get { return "Parameter"; }
        }

        /// <summary>
        /// A Parameter to a Function.
        /// </summary>
        public override string TableDescription
        {
            get { return "A Parameter to a Function."; }
        }

        /// <summary>
        /// The Columns that make up this ParameterTable.
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