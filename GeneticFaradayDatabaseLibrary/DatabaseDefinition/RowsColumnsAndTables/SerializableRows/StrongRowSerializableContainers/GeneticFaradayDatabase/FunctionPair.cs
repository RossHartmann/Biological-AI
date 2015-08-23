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
    /// A pair of functions where the second function is parameterless.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "")]
    public sealed partial class FunctionPairRowSerializableContainer : StrongRowSerializableContainer
    {
        /// <summary>
        /// PK_FunctionPairID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [XmlElement(ElementName = "PK_FunctionPairID")]
        public System.Int32 PK_FunctionPairID;

        /// <summary>
        /// The identifier of the Primary Function in this IFunctionPair. The IFunction can have any number of parameters (or no parameters). This is the IFunction for which the ICodon primarily encodes.
        /// </summary>
        [XmlElement(ElementName = "PrimaryFunction")]
        public System.Int32 PrimaryFunction;

        /// <summary>
        /// The identifier of a Parameterless IFunction that will be used if a parameterless IFunction is required. If a ICodon is in the \"tail\" of the IDNA (i.e. in the portion of the IDNA that will only accept \"terminal\" IFunctions), it will use this parameterless IFunction.
        /// </summary>
        [XmlElement(ElementName = "ParameterlessFunction")]
        public System.Int32 ParameterlessFunction;

        /// <summary>
        /// The unique FunctionIdentifier of the Primary Function.
        /// </summary>
        [XmlElement(ElementName = "PrimaryFunctionIdentifier")]
        public System.String PrimaryFunctionIdentifier;

        /// <summary>
        /// The unique FunctionIdentifier of the Parameterless Function.
        /// </summary>
        [XmlElement(ElementName = "ParameterlessFunctionIdentifier")]
        public System.String ParameterlessFunctionIdentifier;

        /// <summary>
        /// The GeneticCode to which this Function applies.
        /// </summary>
        [XmlElement(ElementName = "GeneticCode")]
        public System.Int32 GeneticCode;

        /// <summary>
        /// An instance of the PrimaryFunctionRow that stores the values that are referenced by the foreign key column "PrimaryFunction".
        /// </summary>
        [XmlElement(ElementName = "PrimaryFunctionRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.TheFunctionRowSerializableContainer PrimaryFunctionRowSerializableContainer;

        /// <summary>
        /// An instance of the ParameterlessFunctionRow that stores the values that are referenced by the foreign key column "ParameterlessFunction".
        /// </summary>
        [XmlElement(ElementName = "ParameterlessFunctionRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.TheFunctionRowSerializableContainer ParameterlessFunctionRowSerializableContainer;

        /// <summary>
        /// An instance of the GeneticCodeRow that stores the values that are referenced by the foreign key column "GeneticCode".
        /// </summary>
        [XmlElement(ElementName = "GeneticCodeRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer GeneticCodeRowSerializableContainer;

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow that stores the values of the ForeignKey Strong Row if it were joined to the FunctionPairRow on the Foreign Key Column "FunctionPair". FunctionPairRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Codon_FunctionPairRow ForeignKeyStrongRow.
        /// </summary>
        [XmlElement(ElementName = "ForeignKeyRow_Codon_FunctionPairRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonRowSerializableContainer ForeignKeyRow_Codon_FunctionPairRowSerializableContainer;

        /// <summary>
        /// Constructs an instance of this FunctionPairRowSerializableContainer from the given FunctionPairRow.
        /// </summary>
        /// <param name="functionPairRow">A pair of functions where the second function is parameterless.</param>
        public FunctionPairRowSerializableContainer(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow functionPairRow)
            : this()
        {
            this.PK_FunctionPairID = functionPairRow.PK_FunctionPairID;
            this.PrimaryFunction = functionPairRow.PrimaryFunction;
            this.ParameterlessFunction = functionPairRow.ParameterlessFunction;
            this.PrimaryFunctionIdentifier = functionPairRow.PrimaryFunctionIdentifier;
            this.ParameterlessFunctionIdentifier = functionPairRow.ParameterlessFunctionIdentifier;
            this.GeneticCode = functionPairRow.GeneticCode;
            if (!functionPairRow.IsPrimaryFunctionRowNull)
                this.PrimaryFunctionRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.TheFunctionRowSerializableContainer(functionPairRow.PrimaryFunctionRow);
            if (!functionPairRow.IsParameterlessFunctionRowNull)
                this.ParameterlessFunctionRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.TheFunctionRowSerializableContainer(functionPairRow.ParameterlessFunctionRow);
            if (!functionPairRow.IsGeneticCodeRowNull)
                this.GeneticCodeRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer(functionPairRow.GeneticCodeRow);
            if (!functionPairRow.IsForeignKeyRow_Codon_FunctionPairRowNull)
                this.ForeignKeyRow_Codon_FunctionPairRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonRowSerializableContainer(functionPairRow.ForeignKeyRow_Codon_FunctionPairRow);
        }

        /// <summary>
        /// Constructs an empty instance of a FunctionPairRowSerializableContainer
        /// </summary>
        public FunctionPairRowSerializableContainer()
        {

        }

        /// <summary>
        /// Converts the FunctionPairRowSerializableContainer to the a FunctionPairRow.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow ToFunctionPairRowStrongRow()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow(this);
        }

        /// <summary>
        /// Converts the StrongRowSerializableContainer to the appropriate StrongRow.
        /// </summary>
        public override StrongRow ToStrongRow()
        {
            return this.ToFunctionPairRowStrongRow();
        }
    }
}