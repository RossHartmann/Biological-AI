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
    /// A enumeration of the values in the RegistryIdentifier table.
    /// </summary>
    [Serializable]
    public sealed partial class RegistryIdentifier : IStrongEnum
    {
        /// <summary>
        /// The name of the RegistryIdentifier enumeration value.
        /// </summary>
        private string Name { get; set; }

        /// <summary>
        /// The actual value of the RegistryIdentifier enumeration value if it were converted to an int.
        /// </summary>
        private int Value { get; set; }

        /// <summary>
        /// The Row that was queried from the database to get this enumeration value.
        /// </summary>
        public Row Row { get; private set; }

        /// <summary>
        /// The Singleton instance of the RegistryIdentifier class that contains the Enum values.
        /// </summary>
        private static readonly Dictionary<string, RegistryIdentifier> Singleton = new Dictionary<string, RegistryIdentifier>();

        /// <summary>
        /// A static constructor for the RegistryIdentifier enum table so that the static fields are only initialized when necessary.
        /// </summary>
        static RegistryIdentifier()
        {

        }

        /// <summary>
        /// Constructs an enum value for the RegistryIdentifier enum table.
        /// </summary>
        /// <param name="value">The value of the enum in the form of an integer.</param>
        /// <param name="name">The name of the enum value.</param>
        /// <param name="row">The Row that contains the Enum values.</param>
        private RegistryIdentifier(int value, string name, Row row)
        {
            this.Name = name;
            this.Value = value;
            this.Row = row;

            Singleton.Add(this.Name, this);
        }

        /// <summary>
        /// Empty constructor for XML serialization.
        /// </summary>
        private RegistryIdentifier()
        {

        }

        /// <summary>
        /// The enum value "Global" in the RegistryIdentifier table.
        /// </summary>
        public static readonly RegistryIdentifier Global = new RegistryIdentifier(value: 1, name: "Global", row: new Row(tableDefinition: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifierTable, columns: new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifier.PK_RegistryIdentifierID }, values: new object[] { "Global" }));

        /// <summary>
        /// The enum value "Input" in the RegistryIdentifier table.
        /// </summary>
        public static readonly RegistryIdentifier Input = new RegistryIdentifier(value: 2, name: "Input", row: new Row(tableDefinition: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifierTable, columns: new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifier.PK_RegistryIdentifierID }, values: new object[] { "Input" }));

        /// <summary>
        /// The enum value "Local" in the RegistryIdentifier table.
        /// </summary>
        public static readonly RegistryIdentifier Local = new RegistryIdentifier(value: 3, name: "Local", row: new Row(tableDefinition: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifierTable, columns: new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifier.PK_RegistryIdentifierID }, values: new object[] { "Local" }));

        /// <summary>
        /// The enum value "LocalGlobal" in the RegistryIdentifier table.
        /// </summary>
        public static readonly RegistryIdentifier Localglobal = new RegistryIdentifier(value: 4, name: "LocalGlobal", row: new Row(tableDefinition: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifierTable, columns: new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifier.PK_RegistryIdentifierID }, values: new object[] { "LocalGlobal" }));

        /// <summary>
        /// The enum value "Results" in the RegistryIdentifier table.
        /// </summary>
        public static readonly RegistryIdentifier Results = new RegistryIdentifier(value: 5, name: "Results", row: new Row(tableDefinition: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifierTable, columns: new Column[] { global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifier.PK_RegistryIdentifierID }, values: new object[] { "Results" }));

        /// <summary>
        /// A StrongRow used to access the information for this enum value in the RegistryIdentifier table. Returns null if this.Row is null.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow RegistryIdentifierRow
        {
            get { return (this.Row != null ? this.Row.AsStrongRow<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow>() : null); }
        }

        /// <summary>
        /// Returns all of the enum values in this RegistryIdentifier StrongEnum.
        /// </summary>
        public static IEnumerable<RegistryIdentifier> GetValues()
        {
            return Singleton.Select(pair => pair.Value as RegistryIdentifier);
        }

        /// <summary>
        /// Returns all of the enum values in this RegistryIdentifier StrongEnum as strings.
        /// </summary>
        public static IEnumerable<string> GetValuesAsStrings()
        {
            return GetValues().Select(v => v.Name);
        }

        /// <summary>
        /// Indicates whether the given value is  a valid RegistryIdentifier value.
        /// </summary>
        /// <param name="value">The string that will be tested to see if it is a valid enum.</param>
        public static bool IsValidEnum(string value)
        {
            return Singleton.ContainsKey(value);
        }

        /// <summary>
        /// Gets all of the values from this RegistryIdentifier as an IEnumerable of strings.
        /// </summary>
        public IEnumerable<string> GetAllValuesOfEnum()
        {
            return RegistryIdentifier.GetValuesAsStrings();
        }

        /// <summary>
        /// Gets all of the Rows from this RegistryIdentifier as an IEnumerable of Rows.
        /// </summary>
        public IEnumerable<Row> GetAllRowsOfEnum()
        {
            return RegistryIdentifier.GetValues().Select(v => v.Row);
        }

        /// <summary>
        /// Implicitly converts a RegistryIdentifier to a string. Returns null if the given RegistryIdentifier is null.
        /// </summary>
        /// <param name="registryIdentifier">A RegistryIdentifier that will be converted to a string.</param>
        public static implicit operator string(RegistryIdentifier registryIdentifier)
        {
            return (registryIdentifier == null ? null : registryIdentifier.ToString());
        }

        /// <summary>
        /// Implicitly converts a string to a RegistryIdentifier. Returns null if the given string is empty or null.
        /// </summary>
        /// <param name="str">A string that will be converted to a RegistryIdentifier</param>
        public static implicit operator RegistryIdentifier(string str)
        {
            if (String.IsNullOrEmpty(str))
                return null;

            RegistryIdentifier result;
            if (Singleton.TryGetValue(str, out result))
                return result;
            else
                throw new InvalidCastException();
        }

        /// <summary>
        /// Indicates whether the two RegistryIdentifier values are equal.
        /// </summary>
        /// <param name="type1">The first RegistryIdentifier to compare.</param>
        /// <param name="type2">The second RegistryIdentifier to compare.</param>
        public static bool operator ==(RegistryIdentifier type1, RegistryIdentifier type2)
        {
            if (type1.IsNullOrDBNull() && type2.IsNullOrDBNull())
                return true;
            else if (type1.IsNullOrDBNull() || type2.IsNullOrDBNull())
                return false;
            else
                return type1.Equals(type2);
        }

        /// <summary>
        /// Indicates whether the two RegistryIdentifier values are not equal.
        /// </summary>
        /// <param name="type1">The first RegistryIdentifier to compare.</param>
        /// <param name="type2">The second RegistryIdentifier to compare.</param>
        public static bool operator !=(RegistryIdentifier type1, RegistryIdentifier type2)
        {
            return !(type1 == type2);
        }

        /// <summary>
        /// Converts the RegistryIdentifier to its corresponding string value.
        /// </summary>
        public override string ToString()
        {
            return this.Name;
        }
    }
}