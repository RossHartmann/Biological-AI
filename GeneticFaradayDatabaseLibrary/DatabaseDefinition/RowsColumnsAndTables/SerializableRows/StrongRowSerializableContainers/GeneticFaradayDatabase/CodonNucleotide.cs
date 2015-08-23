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
    /// Ties a Nucleotide to a Codon
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "")]
    public sealed partial class CodonNucleotideRowSerializableContainer : StrongRowSerializableContainer
    {
        /// <summary>
        /// PK_CodonNucleotideID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [XmlElement(ElementName = "PK_CodonNucleotideID")]
        public System.Int32 PK_CodonNucleotideID;

        /// <summary>
        /// The Codon to which the Nucleotide belongs.
        /// </summary>
        [XmlElement(ElementName = "Codon")]
        public System.Int32 Codon;

        /// <summary>
        /// The Nucleotide that belongs to the Codon.
        /// </summary>
        [XmlElement(ElementName = "Nucleotide")]
        public System.Int32 Nucleotide;

        /// <summary>
        /// The GeneticCode to which this Function applies.
        /// </summary>
        [XmlElement(ElementName = "GeneticCode")]
        public System.Int32 GeneticCode;

        /// <summary>
        /// An instance of the CodonRow that stores the values that are referenced by the foreign key column "Codon".
        /// </summary>
        [XmlElement(ElementName = "CodonRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonRowSerializableContainer CodonRowSerializableContainer;

        /// <summary>
        /// An instance of the NucleotideRow that stores the values that are referenced by the foreign key column "Nucleotide".
        /// </summary>
        [XmlElement(ElementName = "NucleotideRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.NucleotideRowSerializableContainer NucleotideRowSerializableContainer;

        /// <summary>
        /// An instance of the GeneticCodeRow that stores the values that are referenced by the foreign key column "GeneticCode".
        /// </summary>
        [XmlElement(ElementName = "GeneticCodeRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer GeneticCodeRowSerializableContainer;

        /// <summary>
        /// Constructs an instance of this CodonNucleotideRowSerializableContainer from the given CodonNucleotideRow.
        /// </summary>
        /// <param name="codonNucleotideRow">Ties a Nucleotide to a Codon</param>
        public CodonNucleotideRowSerializableContainer(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow codonNucleotideRow)
            : this()
        {
            this.PK_CodonNucleotideID = codonNucleotideRow.PK_CodonNucleotideID;
            this.Codon = codonNucleotideRow.Codon;
            this.Nucleotide = codonNucleotideRow.Nucleotide;
            this.GeneticCode = codonNucleotideRow.GeneticCode;
            if (!codonNucleotideRow.IsCodonRowNull)
                this.CodonRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonRowSerializableContainer(codonNucleotideRow.CodonRow);
            if (!codonNucleotideRow.IsNucleotideRowNull)
                this.NucleotideRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.NucleotideRowSerializableContainer(codonNucleotideRow.NucleotideRow);
            if (!codonNucleotideRow.IsGeneticCodeRowNull)
                this.GeneticCodeRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer(codonNucleotideRow.GeneticCodeRow);
        }

        /// <summary>
        /// Constructs an empty instance of a CodonNucleotideRowSerializableContainer
        /// </summary>
        public CodonNucleotideRowSerializableContainer()
        {

        }

        /// <summary>
        /// Converts the CodonNucleotideRowSerializableContainer to the a CodonNucleotideRow.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow ToCodonNucleotideRowStrongRow()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow(this);
        }

        /// <summary>
        /// Converts the StrongRowSerializableContainer to the appropriate StrongRow.
        /// </summary>
        public override StrongRow ToStrongRow()
        {
            return this.ToCodonNucleotideRowStrongRow();
        }
    }
}