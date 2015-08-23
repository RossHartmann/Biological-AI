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
    /// The type of Parameter.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "")]
    public sealed partial class ParameterTypeRowSerializableContainer : StrongRowSerializableContainer
    {
        /// <summary>
        /// PK_ParameterTypeID varchar(50) UNIQUE PRIMARY KEY,
        /// </summary>
        [XmlElement(ElementName = "PK_ParameterTypeID")]
        public System.String PK_ParameterTypeID;

        /// <summary>
        /// Constructs an instance of this ParameterTypeRowSerializableContainer from the given ParameterTypeRow.
        /// </summary>
        /// <param name="parameterTypeRow">The type of Parameter.</param>
        public ParameterTypeRowSerializableContainer(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow parameterTypeRow)
            : this()
        {
            this.PK_ParameterTypeID = parameterTypeRow.PK_ParameterTypeID;
        }

        /// <summary>
        /// Constructs an empty instance of a ParameterTypeRowSerializableContainer
        /// </summary>
        public ParameterTypeRowSerializableContainer()
        {

        }

        /// <summary>
        /// Converts the ParameterTypeRowSerializableContainer to the a ParameterTypeRow.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow ToParameterTypeRowStrongRow()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow(this);
        }

        /// <summary>
        /// Converts the StrongRowSerializableContainer to the appropriate StrongRow.
        /// </summary>
        public override StrongRow ToStrongRow()
        {
            return this.ToParameterTypeRowStrongRow();
        }
    }
}