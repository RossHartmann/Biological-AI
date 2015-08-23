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
    /// The type of a Codon.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "")]
    public sealed partial class CodonTypeRowSerializableContainer : StrongRowSerializableContainer
    {
        /// <summary>
        /// PK_CodonTypeID varchar(20) UNIQUE PRIMARY KEY,
        /// </summary>
        [XmlElement(ElementName = "PK_CodonTypeID")]
        public System.String PK_CodonTypeID;

        /// <summary>
        /// Constructs an instance of this CodonTypeRowSerializableContainer from the given CodonTypeRow.
        /// </summary>
        /// <param name="codonTypeRow">The type of a Codon.</param>
        public CodonTypeRowSerializableContainer(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow codonTypeRow)
            : this()
        {
            this.PK_CodonTypeID = codonTypeRow.PK_CodonTypeID;
        }

        /// <summary>
        /// Constructs an empty instance of a CodonTypeRowSerializableContainer
        /// </summary>
        public CodonTypeRowSerializableContainer()
        {

        }

        /// <summary>
        /// Converts the CodonTypeRowSerializableContainer to the a CodonTypeRow.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow ToCodonTypeRowStrongRow()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow(this);
        }

        /// <summary>
        /// Converts the StrongRowSerializableContainer to the appropriate StrongRow.
        /// </summary>
        public override StrongRow ToStrongRow()
        {
            return this.ToCodonTypeRowStrongRow();
        }
    }
}