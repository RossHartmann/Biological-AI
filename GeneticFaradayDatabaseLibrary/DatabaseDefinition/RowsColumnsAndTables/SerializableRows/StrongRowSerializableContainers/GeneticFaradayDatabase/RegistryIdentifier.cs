using System;
using System.Collections.Generic;
using UtilityData.Database;
using UtilityData.Database.Tables;
using UtilityData.Database.Rows;
using UtilityData.SQL;
using UtilityData.LINQ;
using UtilityData.Log;
using System.Xml.Serialization;

namespace GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers
{
    /// <summary>
    /// The identifier of a Registry.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "")]
    public sealed partial class RegistryIdentifierRowSerializableContainer : StrongRowSerializableContainer
    {
        /// <summary>
        /// The ID of a Registry
        /// </summary>
        [XmlElement(ElementName = "PK_RegistryIdentifierID")]
        public System.String PK_RegistryIdentifierID;

        /// <summary>
        /// Constructs an instance of this RegistryIdentifierRowSerializableContainer from the given RegistryIdentifierRow.
        /// </summary>
        /// <param name="registryIdentifierRow">The identifier of a Registry.</param>
        public RegistryIdentifierRowSerializableContainer(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow registryIdentifierRow)
            : this()
        {
            this.PK_RegistryIdentifierID = registryIdentifierRow.PK_RegistryIdentifierID;
        }

        /// <summary>
        /// Constructs an empty instance of a RegistryIdentifierRowSerializableContainer
        /// </summary>
        public RegistryIdentifierRowSerializableContainer()
        {

        }

        /// <summary>
        /// Converts the RegistryIdentifierRowSerializableContainer to the a RegistryIdentifierRow.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow ToRegistryIdentifierRowStrongRow()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow(this);
        }

        /// <summary>
        /// Converts the StrongRowSerializableContainer to the appropriate StrongRow.
        /// </summary>
        public override StrongRow ToStrongRow()
        {
            return this.ToRegistryIdentifierRowStrongRow();
        }
    }
}