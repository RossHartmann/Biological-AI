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
    /// Converts a Codon.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "")]
    public sealed partial class CodonConverterRowSerializableContainer : StrongRowSerializableContainer
    {
        /// <summary>
        /// PK_CodonConverterID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [XmlElement(ElementName = "PK_CodonConverterID")]
        public System.Int32 PK_CodonConverterID;

        /// <summary>
        /// The CodonConverterIdentifier of the Codon Converter.
        /// </summary>
        [XmlElement(ElementName = "CodonConverterIdentifier")]
        public System.String CodonConverterIdentifier;

        /// <summary>
        /// The GeneticCode to which this CodonConverter applies.
        /// </summary>
        [XmlElement(ElementName = "GeneticCode")]
        public System.Int32 GeneticCode;

        /// <summary>
        /// An instance of the GeneticCodeRow that stores the values that are referenced by the foreign key column "GeneticCode".
        /// </summary>
        [XmlElement(ElementName = "GeneticCodeRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer GeneticCodeRowSerializableContainer;

        /// <summary>
        /// Constructs an instance of this CodonConverterRowSerializableContainer from the given CodonConverterRow.
        /// </summary>
        /// <param name="codonConverterRow">Converts a Codon.</param>
        public CodonConverterRowSerializableContainer(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow codonConverterRow)
            : this()
        {
            this.PK_CodonConverterID = codonConverterRow.PK_CodonConverterID;
            this.CodonConverterIdentifier = codonConverterRow.CodonConverterIdentifier;
            this.GeneticCode = codonConverterRow.GeneticCode;
            if (!codonConverterRow.IsGeneticCodeRowNull)
                this.GeneticCodeRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer(codonConverterRow.GeneticCodeRow);
        }

        /// <summary>
        /// Constructs an empty instance of a CodonConverterRowSerializableContainer
        /// </summary>
        public CodonConverterRowSerializableContainer()
        {

        }

        /// <summary>
        /// Converts the CodonConverterRowSerializableContainer to the a CodonConverterRow.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow ToCodonConverterRowStrongRow()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow(this);
        }

        /// <summary>
        /// Converts the StrongRowSerializableContainer to the appropriate StrongRow.
        /// </summary>
        public override StrongRow ToStrongRow()
        {
            return this.ToCodonConverterRowStrongRow();
        }
    }
}