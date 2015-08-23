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
    /// A Codon in the Genetic Code.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "")]
    public sealed partial class CodonRowSerializableContainer : StrongRowSerializableContainer
    {
        /// <summary>
        /// PK_CodonID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [XmlElement(ElementName = "PK_CodonID")]
        public System.Int32 PK_CodonID;

        /// <summary>
        /// The CodonIdentifier of this Codon.
        /// </summary>
        [XmlElement(ElementName = "Name")]
        public System.String Name;

        /// <summary>
        /// The GeneticCode to which this Codon applies.
        /// </summary>
        [XmlElement(ElementName = "GeneticCode")]
        public System.Int32 GeneticCode;

        /// <summary>
        /// The pair of Functions for which this Codon encodes.
        /// </summary>
        [XmlElement(ElementName = "FunctionPair")]
        public System.Int32 FunctionPair;

        /// <summary>
        /// The type of Codon.
        /// </summary>
        [XmlElement(ElementName = "CodonType")]
        public System.String CodonType;

        /// <summary>
        /// An instance of the GeneticCodeRow that stores the values that are referenced by the foreign key column "GeneticCode".
        /// </summary>
        [XmlElement(ElementName = "GeneticCodeRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer GeneticCodeRowSerializableContainer;

        /// <summary>
        /// An instance of the FunctionPairRow that stores the values that are referenced by the foreign key column "FunctionPair".
        /// </summary>
        [XmlElement(ElementName = "FunctionPairRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionPairRowSerializableContainer FunctionPairRowSerializableContainer;

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow that stores the values of the ForeignKey Strong Row if it were joined to the CodonRow on the Foreign Key Column "Codon". CodonRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_CodonNucleotide_CodonRow ForeignKeyStrongRow.
        /// </summary>
        [XmlElement(ElementName = "ForeignKeyRow_CodonNucleotide_CodonRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonNucleotideRowSerializableContainer ForeignKeyRow_CodonNucleotide_CodonRowSerializableContainer;

        /// <summary>
        /// Constructs an instance of this CodonRowSerializableContainer from the given CodonRow.
        /// </summary>
        /// <param name="codonRow">A Codon in the Genetic Code.</param>
        public CodonRowSerializableContainer(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow codonRow)
            : this()
        {
            this.PK_CodonID = codonRow.PK_CodonID;
            this.Name = codonRow.Name;
            this.GeneticCode = codonRow.GeneticCode;
            this.FunctionPair = codonRow.FunctionPair;
            this.CodonType = codonRow.CodonType;
            if (!codonRow.IsGeneticCodeRowNull)
                this.GeneticCodeRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer(codonRow.GeneticCodeRow);
            if (!codonRow.IsFunctionPairRowNull)
                this.FunctionPairRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionPairRowSerializableContainer(codonRow.FunctionPairRow);
            if (!codonRow.IsForeignKeyRow_CodonNucleotide_CodonRowNull)
                this.ForeignKeyRow_CodonNucleotide_CodonRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonNucleotideRowSerializableContainer(codonRow.ForeignKeyRow_CodonNucleotide_CodonRow);
        }

        /// <summary>
        /// Constructs an empty instance of a CodonRowSerializableContainer
        /// </summary>
        public CodonRowSerializableContainer()
        {

        }

        /// <summary>
        /// Converts the CodonRowSerializableContainer to the a CodonRow.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow ToCodonRowStrongRow()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow(this);
        }

        /// <summary>
        /// Converts the StrongRowSerializableContainer to the appropriate StrongRow.
        /// </summary>
        public override StrongRow ToStrongRow()
        {
            return this.ToCodonRowStrongRow();
        }
    }
}