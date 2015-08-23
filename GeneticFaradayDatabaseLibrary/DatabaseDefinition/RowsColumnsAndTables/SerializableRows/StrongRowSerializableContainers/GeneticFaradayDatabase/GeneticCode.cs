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
    /// The rules to which an Organism must abide.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "")]
    public sealed partial class GeneticCodeRowSerializableContainer : StrongRowSerializableContainer
    {
        /// <summary>
        /// PK_GeneticCodeID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [XmlElement(ElementName = "PK_GeneticCodeID")]
        public System.Int32 PK_GeneticCodeID;

        /// <summary>
        /// The name of the Genetic Code.
        /// </summary>
        [XmlElement(ElementName = "Name")]
        public System.String Name;

        /// <summary>
        /// The length of every Codon in the GeneticCode. All Codons must be of this length.
        /// </summary>
        [XmlElement(ElementName = "CodonLength")]
        public System.Int32 CodonLength;

        /// <summary>
        /// The maximum number of IFunctions that take parameters that can be used in an IAllele's IDNA. After (or before) this number of IFunctions (with parameters) have been called, the rest of the IFunctions in the IDNA will not accept any parameters (i.e. they  will be terminals).
        /// </summary>
        [XmlElement(ElementName = "MaxParameterfulFunctionsInDNA")]
        public System.Int32 MaxParameterfulFunctionsInDNA;

        /// <summary>
        /// The number of IParameters used by the IFunction that has the most parameters.
        /// </summary>
        [XmlElement(ElementName = "MaximumFunctionInputsUsed")]
        public System.Int32 MaximumFunctionInputsUsed;

        /// <summary>
        /// The maximum recursion level that's allowable. If this value is reached by an IGEPGene, the execution of the IGEPGene will be aborted.
        /// </summary>
        [XmlElement(ElementName = "MaxRecursionLevel")]
        public System.Int32 MaxRecursionLevel;

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow that stores the values of the ForeignKey Strong Row if it were joined to the GeneticCodeRow on the Foreign Key Column "GeneticCode". GeneticCodeRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_TheFunction_GeneticCodeRow ForeignKeyStrongRow.
        /// </summary>
        [XmlElement(ElementName = "ForeignKeyRow_TheFunction_GeneticCodeRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.TheFunctionRowSerializableContainer ForeignKeyRow_TheFunction_GeneticCodeRowSerializableContainer;

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow that stores the values of the ForeignKey Strong Row if it were joined to the GeneticCodeRow on the Foreign Key Column "GeneticCode". GeneticCodeRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_CodonConverter_GeneticCodeRow ForeignKeyStrongRow.
        /// </summary>
        [XmlElement(ElementName = "ForeignKeyRow_CodonConverter_GeneticCodeRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonConverterRowSerializableContainer ForeignKeyRow_CodonConverter_GeneticCodeRowSerializableContainer;

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow that stores the values of the ForeignKey Strong Row if it were joined to the GeneticCodeRow on the Foreign Key Column "GeneticCode". GeneticCodeRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Codon_GeneticCodeRow ForeignKeyStrongRow.
        /// </summary>
        [XmlElement(ElementName = "ForeignKeyRow_Codon_GeneticCodeRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonRowSerializableContainer ForeignKeyRow_Codon_GeneticCodeRowSerializableContainer;

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow that stores the values of the ForeignKey Strong Row if it were joined to the GeneticCodeRow on the Foreign Key Column "GeneticCode". GeneticCodeRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Nucleotide_GeneticCodeRow ForeignKeyStrongRow.
        /// </summary>
        [XmlElement(ElementName = "ForeignKeyRow_Nucleotide_GeneticCodeRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.NucleotideRowSerializableContainer ForeignKeyRow_Nucleotide_GeneticCodeRowSerializableContainer;

        /// <summary>
        /// Constructs an instance of this GeneticCodeRowSerializableContainer from the given GeneticCodeRow.
        /// </summary>
        /// <param name="geneticCodeRow">The rules to which an Organism must abide.</param>
        public GeneticCodeRowSerializableContainer(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow geneticCodeRow)
            : this()
        {
            this.PK_GeneticCodeID = geneticCodeRow.PK_GeneticCodeID;
            this.Name = geneticCodeRow.Name;
            this.CodonLength = geneticCodeRow.CodonLength;
            this.MaxParameterfulFunctionsInDNA = geneticCodeRow.MaxParameterfulFunctionsInDNA;
            this.MaximumFunctionInputsUsed = geneticCodeRow.MaximumFunctionInputsUsed;
            this.MaxRecursionLevel = geneticCodeRow.MaxRecursionLevel;
            if (!geneticCodeRow.IsForeignKeyRow_TheFunction_GeneticCodeRowNull)
                this.ForeignKeyRow_TheFunction_GeneticCodeRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.TheFunctionRowSerializableContainer(geneticCodeRow.ForeignKeyRow_TheFunction_GeneticCodeRow);
            if (!geneticCodeRow.IsForeignKeyRow_CodonConverter_GeneticCodeRowNull)
                this.ForeignKeyRow_CodonConverter_GeneticCodeRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonConverterRowSerializableContainer(geneticCodeRow.ForeignKeyRow_CodonConverter_GeneticCodeRow);
            if (!geneticCodeRow.IsForeignKeyRow_Codon_GeneticCodeRowNull)
                this.ForeignKeyRow_Codon_GeneticCodeRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonRowSerializableContainer(geneticCodeRow.ForeignKeyRow_Codon_GeneticCodeRow);
            if (!geneticCodeRow.IsForeignKeyRow_Nucleotide_GeneticCodeRowNull)
                this.ForeignKeyRow_Nucleotide_GeneticCodeRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.NucleotideRowSerializableContainer(geneticCodeRow.ForeignKeyRow_Nucleotide_GeneticCodeRow);
        }

        /// <summary>
        /// Constructs an empty instance of a GeneticCodeRowSerializableContainer
        /// </summary>
        public GeneticCodeRowSerializableContainer()
        {

        }

        /// <summary>
        /// Converts the GeneticCodeRowSerializableContainer to the a GeneticCodeRow.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow ToGeneticCodeRowStrongRow()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow(this);
        }

        /// <summary>
        /// Converts the StrongRowSerializableContainer to the appropriate StrongRow.
        /// </summary>
        public override StrongRow ToStrongRow()
        {
            return this.ToGeneticCodeRowStrongRow();
        }
    }
}