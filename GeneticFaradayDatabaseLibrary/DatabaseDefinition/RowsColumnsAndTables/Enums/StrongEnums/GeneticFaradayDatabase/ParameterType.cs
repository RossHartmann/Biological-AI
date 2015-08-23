using System;
using System.Collections.Generic;
using System.Linq;
using UtilityData.Database;
using UtilityData.Database.Rows;
using GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows;
using UtilityData.LINQ;

namespace GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongEnums
{
    /// <summary>
    /// A enumeration of the values in the ParameterType table.
    /// </summary>
    [Serializable]
    public sealed partial class ParameterType : IStrongEnum
    {
        /// <summary>
        /// The name of the ParameterType enumeration value.
        /// </summary>
        private string Name { get; set; }

        /// <summary>
        /// The actual value of the ParameterType enumeration value if it were converted to an int.
        /// </summary>
        private int Value { get; set; }

        /// <summary>
        /// The Row that was queried from the database to get this enumeration value.
        /// </summary>
        public Row Row { get; private set; }

        /// <summary>
        /// The Singleton instance of the ParameterType class that contains the Enum values.
        /// </summary>
        private static readonly Dictionary<string, ParameterType> Singleton = new Dictionary<string, ParameterType>();

        /// <summary>
        /// A static constructor for the ParameterType enum table so that the static fields are only initialized when necessary.
        /// </summary>
        static ParameterType()
        {

        }

        /// <summary>
        /// Constructs an enum value for the ParameterType enum table.
        /// </summary>
        /// <param name="value">The value of the enum in the form of an integer.</param>
        /// <param name="name">The name of the enum value.</param>
        /// <param name="row">The Row that contains the Enum values.</param>
        private ParameterType(int value, string name, Row row)
        {
            this.Name = name;
            this.Value = value;
            this.Row = row;

            Singleton.Add(this.Name, this);
        }

        /// <summary>
        /// Empty constructor for XML serialization.
        /// </summary>
        private ParameterType()
        {

        }

        /// <summary>
        /// The enum value "AminoAcid" in the ParameterType table.
        /// </summary>
        public static readonly ParameterType Aminoacid = new ParameterType(value: 1, name: "AminoAcid", row: new Row(tableDefinition: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTypeTable, columns: new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterType.PK_ParameterTypeID }, values: new object[] { "AminoAcid" }));

        /// <summary>
        /// The enum value "ConvertedCodon" in the ParameterType table.
        /// </summary>
        public static readonly ParameterType Convertedcodon = new ParameterType(value: 2, name: "ConvertedCodon", row: new Row(tableDefinition: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTypeTable, columns: new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterType.PK_ParameterTypeID }, values: new object[] { "ConvertedCodon" }));

        /// <summary>
        /// The enum value "EvaluatedAminoAcid" in the ParameterType table.
        /// </summary>
        public static readonly ParameterType Evaluatedaminoacid = new ParameterType(value: 3, name: "EvaluatedAminoAcid", row: new Row(tableDefinition: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTypeTable, columns: new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterType.PK_ParameterTypeID }, values: new object[] { "EvaluatedAminoAcid" }));

        /// <summary>
        /// A StrongRow used to access the information for this enum value in the ParameterType table. Returns null if this.Row is null.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow ParameterTypeRow
        {
            get { return (this.Row != null ? this.Row.AsStrongRow<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow>() : null); }
        }

        /// <summary>
        /// Returns all of the enum values in this ParameterType StrongEnum.
        /// </summary>
        public static IEnumerable<ParameterType> GetValues()
        {
            return Singleton.Select(pair => pair.Value as ParameterType);
        }

        /// <summary>
        /// Returns all of the enum values in this ParameterType StrongEnum as strings.
        /// </summary>
        public static IEnumerable<string> GetValuesAsStrings()
        {
            return GetValues().Select(v => v.Name);
        }

        /// <summary>
        /// Indicates whether the given value is  a valid ParameterType value.
        /// </summary>
        /// <param name="value">The string that will be tested to see if it is a valid enum.</param>
        public static bool IsValidEnum(string value)
        {
            return Singleton.ContainsKey(value);
        }

        /// <summary>
        /// Gets all of the values from this ParameterType as an IEnumerable of strings.
        /// </summary>
        public IEnumerable<string> GetAllValuesOfEnum()
        {
            return ParameterType.GetValuesAsStrings();
        }

        /// <summary>
        /// Gets all of the Rows from this ParameterType as an IEnumerable of Rows.
        /// </summary>
        public IEnumerable<Row> GetAllRowsOfEnum()
        {
            return ParameterType.GetValues().Select(v => v.Row);
        }

        /// <summary>
        /// Implicitly converts a ParameterType to a string. Returns null if the given ParameterType is null.
        /// </summary>
        /// <param name="parameterType">A ParameterType that will be converted to a string.</param>
        public static implicit operator string(ParameterType parameterType)
        {
            return (parameterType == null ? null : parameterType.ToString());
        }

        /// <summary>
        /// Implicitly converts a string to a ParameterType. Returns null if the given string is empty or null.
        /// </summary>
        /// <param name="str">A string that will be converted to a ParameterType</param>
        public static implicit operator ParameterType(string str)
        {
            if (String.IsNullOrEmpty(str))
                return null;

            ParameterType result;
            if (Singleton.TryGetValue(str, out result))
                return result;
            else
                throw new InvalidCastException();
        }

        /// <summary>
        /// Indicates whether the two ParameterType values are equal.
        /// </summary>
        /// <param name="type1">The first ParameterType to compare.</param>
        /// <param name="type2">The second ParameterType to compare.</param>
        public static bool operator ==(ParameterType type1, ParameterType type2)
        {
            if (type1.IsNullOrDBNull() && type2.IsNullOrDBNull())
                return true;
            else if (type1.IsNullOrDBNull() || type2.IsNullOrDBNull())
                return false;
            else
                return type1.Equals(type2);
        }

        /// <summary>
        /// Indicates whether the two ParameterType values are not equal.
        /// </summary>
        /// <param name="type1">The first ParameterType to compare.</param>
        /// <param name="type2">The second ParameterType to compare.</param>
        public static bool operator !=(ParameterType type1, ParameterType type2)
        {
            return !(type1 == type2);
        }

        /// <summary>
        /// Converts the ParameterType to its corresponding string value.
        /// </summary>
        public override string ToString()
        {
            return this.Name;
        }
    }
}