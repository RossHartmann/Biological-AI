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
    /// A enumeration of the values in the CodonType table.
    /// </summary>
    [Serializable]
    public sealed partial class CodonType : IStrongEnum
    {
        /// <summary>
        /// The name of the CodonType enumeration value.
        /// </summary>
        private string Name { get; set; }

        /// <summary>
        /// The actual value of the CodonType enumeration value if it were converted to an int.
        /// </summary>
        private int Value { get; set; }

        /// <summary>
        /// The Row that was queried from the database to get this enumeration value.
        /// </summary>
        public Row Row { get; private set; }

        /// <summary>
        /// The Singleton instance of the CodonType class that contains the Enum values.
        /// </summary>
        private static readonly Dictionary<string, CodonType> Singleton = new Dictionary<string, CodonType>();

        /// <summary>
        /// A static constructor for the CodonType enum table so that the static fields are only initialized when necessary.
        /// </summary>
        static CodonType()
        {

        }

        /// <summary>
        /// Constructs an enum value for the CodonType enum table.
        /// </summary>
        /// <param name="value">The value of the enum in the form of an integer.</param>
        /// <param name="name">The name of the enum value.</param>
        /// <param name="row">The Row that contains the Enum values.</param>
        private CodonType(int value, string name, Row row)
        {
            this.Name = name;
            this.Value = value;
            this.Row = row;

            Singleton.Add(this.Name, this);
        }

        /// <summary>
        /// Empty constructor for XML serialization.
        /// </summary>
        private CodonType()
        {

        }

        /// <summary>
        /// The enum value "Standard" in the CodonType table.
        /// </summary>
        public static readonly CodonType Standard = new CodonType(value: 1, name: "Standard", row: new Row(tableDefinition: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTypeTable, columns: new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonType.PK_CodonTypeID }, values: new object[] { "Standard" }));

        /// <summary>
        /// The enum value "Stop" in the CodonType table.
        /// </summary>
        public static readonly CodonType Stop = new CodonType(value: 2, name: "Stop", row: new Row(tableDefinition: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTypeTable, columns: new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonType.PK_CodonTypeID }, values: new object[] { "Stop" }));

        /// <summary>
        /// A StrongRow used to access the information for this enum value in the CodonType table. Returns null if this.Row is null.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow CodonTypeRow
        {
            get { return (this.Row != null ? this.Row.AsStrongRow<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow>() : null); }
        }

        /// <summary>
        /// Returns all of the enum values in this CodonType StrongEnum.
        /// </summary>
        public static IEnumerable<CodonType> GetValues()
        {
            return Singleton.Select(pair => pair.Value as CodonType);
        }

        /// <summary>
        /// Returns all of the enum values in this CodonType StrongEnum as strings.
        /// </summary>
        public static IEnumerable<string> GetValuesAsStrings()
        {
            return GetValues().Select(v => v.Name);
        }

        /// <summary>
        /// Indicates whether the given value is  a valid CodonType value.
        /// </summary>
        /// <param name="value">The string that will be tested to see if it is a valid enum.</param>
        public static bool IsValidEnum(string value)
        {
            return Singleton.ContainsKey(value);
        }

        /// <summary>
        /// Gets all of the values from this CodonType as an IEnumerable of strings.
        /// </summary>
        public IEnumerable<string> GetAllValuesOfEnum()
        {
            return CodonType.GetValuesAsStrings();
        }

        /// <summary>
        /// Gets all of the Rows from this CodonType as an IEnumerable of Rows.
        /// </summary>
        public IEnumerable<Row> GetAllRowsOfEnum()
        {
            return CodonType.GetValues().Select(v => v.Row);
        }

        /// <summary>
        /// Implicitly converts a CodonType to a string. Returns null if the given CodonType is null.
        /// </summary>
        /// <param name="codonType">A CodonType that will be converted to a string.</param>
        public static implicit operator string(CodonType codonType)
        {
            return (codonType == null ? null : codonType.ToString());
        }

        /// <summary>
        /// Implicitly converts a string to a CodonType. Returns null if the given string is empty or null.
        /// </summary>
        /// <param name="str">A string that will be converted to a CodonType</param>
        public static implicit operator CodonType(string str)
        {
            if (String.IsNullOrEmpty(str))
                return null;

            CodonType result;
            if (Singleton.TryGetValue(str, out result))
                return result;
            else
                throw new InvalidCastException();
        }

        /// <summary>
        /// Indicates whether the two CodonType values are equal.
        /// </summary>
        /// <param name="type1">The first CodonType to compare.</param>
        /// <param name="type2">The second CodonType to compare.</param>
        public static bool operator ==(CodonType type1, CodonType type2)
        {
            if (type1.IsNullOrDBNull() && type2.IsNullOrDBNull())
                return true;
            else if (type1.IsNullOrDBNull() || type2.IsNullOrDBNull())
                return false;
            else
                return type1.Equals(type2);
        }

        /// <summary>
        /// Indicates whether the two CodonType values are not equal.
        /// </summary>
        /// <param name="type1">The first CodonType to compare.</param>
        /// <param name="type2">The second CodonType to compare.</param>
        public static bool operator !=(CodonType type1, CodonType type2)
        {
            return !(type1 == type2);
        }

        /// <summary>
        /// Converts the CodonType to its corresponding string value.
        /// </summary>
        public override string ToString()
        {
            return this.Name;
        }
    }
}