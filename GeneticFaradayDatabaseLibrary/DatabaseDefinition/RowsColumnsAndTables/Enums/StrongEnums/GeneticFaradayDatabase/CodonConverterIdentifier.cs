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
    /// A enumeration of the values in the CodonConverterIdentifier table.
    /// </summary>
    [Serializable]
    public sealed partial class CodonConverterIdentifier : IStrongEnum
    {
        /// <summary>
        /// The name of the CodonConverterIdentifier enumeration value.
        /// </summary>
        private string Name { get; set; }

        /// <summary>
        /// The actual value of the CodonConverterIdentifier enumeration value if it were converted to an int.
        /// </summary>
        private int Value { get; set; }

        /// <summary>
        /// The Row that was queried from the database to get this enumeration value.
        /// </summary>
        public Row Row { get; private set; }

        /// <summary>
        /// The Singleton instance of the CodonConverterIdentifier class that contains the Enum values.
        /// </summary>
        private static readonly Dictionary<string, CodonConverterIdentifier> Singleton = new Dictionary<string, CodonConverterIdentifier>();

        /// <summary>
        /// A static constructor for the CodonConverterIdentifier enum table so that the static fields are only initialized when necessary.
        /// </summary>
        static CodonConverterIdentifier()
        {

        }

        /// <summary>
        /// Constructs an enum value for the CodonConverterIdentifier enum table.
        /// </summary>
        /// <param name="value">The value of the enum in the form of an integer.</param>
        /// <param name="name">The name of the enum value.</param>
        /// <param name="row">The Row that contains the Enum values.</param>
        private CodonConverterIdentifier(int value, string name, Row row)
        {
            this.Name = name;
            this.Value = value;
            this.Row = row;

            Singleton.Add(this.Name, this);
        }

        /// <summary>
        /// Empty constructor for XML serialization.
        /// </summary>
        private CodonConverterIdentifier()
        {

        }

        /// <summary>
        /// The enum value "ConvertCodonToDecimal" in the CodonConverterIdentifier table.
        /// </summary>
        public static readonly CodonConverterIdentifier Convertcodontodecimal = new CodonConverterIdentifier(value: 1, name: "ConvertCodonToDecimal", row: new Row(tableDefinition: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifierTable, columns: new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifier.PK_CodonConverterIdentifierID }, values: new object[] { "ConvertCodonToDecimal" }));

        /// <summary>
        /// The enum value "ConvertCodonToFloat16" in the CodonConverterIdentifier table.
        /// </summary>
        public static readonly CodonConverterIdentifier Convertcodontofloat16 = new CodonConverterIdentifier(value: 2, name: "ConvertCodonToFloat16", row: new Row(tableDefinition: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifierTable, columns: new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifier.PK_CodonConverterIdentifierID }, values: new object[] { "ConvertCodonToFloat16" }));

        /// <summary>
        /// The enum value "ConvertCodonToInt16" in the CodonConverterIdentifier table.
        /// </summary>
        public static readonly CodonConverterIdentifier Convertcodontoint16 = new CodonConverterIdentifier(value: 3, name: "ConvertCodonToInt16", row: new Row(tableDefinition: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifierTable, columns: new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifier.PK_CodonConverterIdentifierID }, values: new object[] { "ConvertCodonToInt16" }));

        /// <summary>
        /// The enum value "ConvertCodonToInt3" in the CodonConverterIdentifier table.
        /// </summary>
        public static readonly CodonConverterIdentifier Convertcodontoint3 = new CodonConverterIdentifier(value: 4, name: "ConvertCodonToInt3", row: new Row(tableDefinition: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifierTable, columns: new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifier.PK_CodonConverterIdentifierID }, values: new object[] { "ConvertCodonToInt3" }));

        /// <summary>
        /// The enum value "ConvertCodonToInt5" in the CodonConverterIdentifier table.
        /// </summary>
        public static readonly CodonConverterIdentifier Convertcodontoint5 = new CodonConverterIdentifier(value: 5, name: "ConvertCodonToInt5", row: new Row(tableDefinition: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifierTable, columns: new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifier.PK_CodonConverterIdentifierID }, values: new object[] { "ConvertCodonToInt5" }));

        /// <summary>
        /// A StrongRow used to access the information for this enum value in the CodonConverterIdentifier table. Returns null if this.Row is null.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow CodonConverterIdentifierRow
        {
            get { return (this.Row != null ? this.Row.AsStrongRow<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow>() : null); }
        }

        /// <summary>
        /// Returns all of the enum values in this CodonConverterIdentifier StrongEnum.
        /// </summary>
        public static IEnumerable<CodonConverterIdentifier> GetValues()
        {
            return Singleton.Select(pair => pair.Value as CodonConverterIdentifier);
        }

        /// <summary>
        /// Returns all of the enum values in this CodonConverterIdentifier StrongEnum as strings.
        /// </summary>
        public static IEnumerable<string> GetValuesAsStrings()
        {
            return GetValues().Select(v => v.Name);
        }

        /// <summary>
        /// Indicates whether the given value is  a valid CodonConverterIdentifier value.
        /// </summary>
        /// <param name="value">The string that will be tested to see if it is a valid enum.</param>
        public static bool IsValidEnum(string value)
        {
            return Singleton.ContainsKey(value);
        }

        /// <summary>
        /// Gets all of the values from this CodonConverterIdentifier as an IEnumerable of strings.
        /// </summary>
        public IEnumerable<string> GetAllValuesOfEnum()
        {
            return CodonConverterIdentifier.GetValuesAsStrings();
        }

        /// <summary>
        /// Gets all of the Rows from this CodonConverterIdentifier as an IEnumerable of Rows.
        /// </summary>
        public IEnumerable<Row> GetAllRowsOfEnum()
        {
            return CodonConverterIdentifier.GetValues().Select(v => v.Row);
        }

        /// <summary>
        /// Implicitly converts a CodonConverterIdentifier to a string. Returns null if the given CodonConverterIdentifier is null.
        /// </summary>
        /// <param name="codonConverterIdentifier">A CodonConverterIdentifier that will be converted to a string.</param>
        public static implicit operator string(CodonConverterIdentifier codonConverterIdentifier)
        {
            return (codonConverterIdentifier == null ? null : codonConverterIdentifier.ToString());
        }

        /// <summary>
        /// Implicitly converts a string to a CodonConverterIdentifier. Returns null if the given string is empty or null.
        /// </summary>
        /// <param name="str">A string that will be converted to a CodonConverterIdentifier</param>
        public static implicit operator CodonConverterIdentifier(string str)
        {
            if (String.IsNullOrEmpty(str))
                return null;

            CodonConverterIdentifier result;
            if (Singleton.TryGetValue(str, out result))
                return result;
            else
                throw new InvalidCastException();
        }

        /// <summary>
        /// Indicates whether the two CodonConverterIdentifier values are equal.
        /// </summary>
        /// <param name="type1">The first CodonConverterIdentifier to compare.</param>
        /// <param name="type2">The second CodonConverterIdentifier to compare.</param>
        public static bool operator ==(CodonConverterIdentifier type1, CodonConverterIdentifier type2)
        {
            if (type1.IsNullOrDBNull() && type2.IsNullOrDBNull())
                return true;
            else if (type1.IsNullOrDBNull() || type2.IsNullOrDBNull())
                return false;
            else
                return type1.Equals(type2);
        }

        /// <summary>
        /// Indicates whether the two CodonConverterIdentifier values are not equal.
        /// </summary>
        /// <param name="type1">The first CodonConverterIdentifier to compare.</param>
        /// <param name="type2">The second CodonConverterIdentifier to compare.</param>
        public static bool operator !=(CodonConverterIdentifier type1, CodonConverterIdentifier type2)
        {
            return !(type1 == type2);
        }

        /// <summary>
        /// Converts the CodonConverterIdentifier to its corresponding string value.
        /// </summary>
        public override string ToString()
        {
            return this.Name;
        }
    }
}