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
    /// The name of the Nucleotide.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "")]
    public sealed partial class NucleotideRowSerializableContainer : StrongRowSerializableContainer
    {
        /// <summary>
        /// PK_NucleotideID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [XmlElement(ElementName = "PK_NucleotideID")]
        public System.Int32 PK_NucleotideID;

        /// <summary>
        /// The name of the Nucleotide.
        /// </summary>
        [XmlElement(ElementName = "Name")]
        public System.String Name;

        /// <summary>
        /// The GeneticCode to which this Nucleotide applies.
        /// </summary>
        [XmlElement(ElementName = "GeneticCode")]
        public System.Int32 GeneticCode;

        /// <summary>
        /// An instance of the GeneticCodeRow that stores the values that are referenced by the foreign key column "GeneticCode".
        /// </summary>
        [XmlElement(ElementName = "GeneticCodeRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer GeneticCodeRowSerializableContainer;

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow that stores the values of the ForeignKey Strong Row if it were joined to the NucleotideRow on the Foreign Key Column "Nucleotide". NucleotideRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_CodonNucleotide_NucleotideRow ForeignKeyStrongRow.
        /// </summary>
        [XmlElement(ElementName = "ForeignKeyRow_CodonNucleotide_NucleotideRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonNucleotideRowSerializableContainer ForeignKeyRow_CodonNucleotide_NucleotideRowSerializableContainer;

        /// <summary>
        /// Constructs an instance of this NucleotideRowSerializableContainer from the given NucleotideRow.
        /// </summary>
        /// <param name="nucleotideRow">The name of the Nucleotide.</param>
        public NucleotideRowSerializableContainer(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow nucleotideRow)
            : this()
        {
            this.PK_NucleotideID = nucleotideRow.PK_NucleotideID;
            this.Name = nucleotideRow.Name;
            this.GeneticCode = nucleotideRow.GeneticCode;
            if (!nucleotideRow.IsGeneticCodeRowNull)
                this.GeneticCodeRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer(nucleotideRow.GeneticCodeRow);
            if (!nucleotideRow.IsForeignKeyRow_CodonNucleotide_NucleotideRowNull)
                this.ForeignKeyRow_CodonNucleotide_NucleotideRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonNucleotideRowSerializableContainer(nucleotideRow.ForeignKeyRow_CodonNucleotide_NucleotideRow);
        }

        /// <summary>
        /// Constructs an empty instance of a NucleotideRowSerializableContainer
        /// </summary>
        public NucleotideRowSerializableContainer()
        {

        }

        /// <summary>
        /// Converts the NucleotideRowSerializableContainer to the a NucleotideRow.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow ToNucleotideRowStrongRow()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow(this);
        }

        /// <summary>
        /// Converts the StrongRowSerializableContainer to the appropriate StrongRow.
        /// </summary>
        public override StrongRow ToStrongRow()
        {
            return this.ToNucleotideRowStrongRow();
        }
    }
}