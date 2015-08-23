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
    /// The identifier of the Codon Converter.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "")]
    public sealed partial class CodonConverterIdentifierRowSerializableContainer : StrongRowSerializableContainer
    {
        /// <summary>
        /// The ID of a Codon Converter
        /// </summary>
        [XmlElement(ElementName = "PK_CodonConverterIdentifierID")]
        public System.String PK_CodonConverterIdentifierID;

        /// <summary>
        /// Constructs an instance of this CodonConverterIdentifierRowSerializableContainer from the given CodonConverterIdentifierRow.
        /// </summary>
        /// <param name="codonConverterIdentifierRow">The identifier of the Codon Converter.</param>
        public CodonConverterIdentifierRowSerializableContainer(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow codonConverterIdentifierRow)
            : this()
        {
            this.PK_CodonConverterIdentifierID = codonConverterIdentifierRow.PK_CodonConverterIdentifierID;
        }

        /// <summary>
        /// Constructs an empty instance of a CodonConverterIdentifierRowSerializableContainer
        /// </summary>
        public CodonConverterIdentifierRowSerializableContainer()
        {

        }

        /// <summary>
        /// Converts the CodonConverterIdentifierRowSerializableContainer to the a CodonConverterIdentifierRow.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow ToCodonConverterIdentifierRowStrongRow()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow(this);
        }

        /// <summary>
        /// Converts the StrongRowSerializableContainer to the appropriate StrongRow.
        /// </summary>
        public override StrongRow ToStrongRow()
        {
            return this.ToCodonConverterIdentifierRowStrongRow();
        }
    }
}