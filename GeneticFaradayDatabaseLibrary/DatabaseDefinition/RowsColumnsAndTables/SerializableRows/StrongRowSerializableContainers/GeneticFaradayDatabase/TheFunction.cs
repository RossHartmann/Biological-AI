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
    /// A Function.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "")]
    public sealed partial class TheFunctionRowSerializableContainer : StrongRowSerializableContainer
    {
        /// <summary>
        /// PK_FunctionID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [XmlElement(ElementName = "PK_FunctionID")]
        public System.Int32 PK_FunctionID;

        /// <summary>
        /// The unique FunctionIdentifier of the Function.
        /// </summary>
        [XmlElement(ElementName = "FunctionIdentifier")]
        public System.String FunctionIdentifier;

        /// <summary>
        /// The GeneticCode to which this Function applies.
        /// </summary>
        [XmlElement(ElementName = "GeneticCode")]
        public System.Int32 GeneticCode;

        /// <summary>
        /// The human-readable name of the Function. Doesn't necessarily uniquely identify this Function.
        /// </summary>
        [XmlElement(ElementName = "Name")]
        public System.String Name;

        /// <summary>
        /// The base human-readable name of the Function. this is a more general name for the Function (than this.Name).
        /// </summary>
        [XmlElement(ElementName = "BaseName")]
        public System.String BaseName;

        /// <summary>
        /// The Weight of the Function in the GeneticCode. The higher the weight, the more Codons that will encode for this Function.
        /// </summary>
        [XmlElement(ElementName = "WeightInGeneticCode")]
        public System.Double WeightInGeneticCode;

        /// <summary>
        /// The name of the ExecuteMethod delegate that will be used to execute this Function.
        /// </summary>
        [XmlElement(ElementName = "ExecuteMethodName")]
        public System.String ExecuteMethodName;

        /// <summary>
        /// The area of the IFunction such as \"Arithmetic\" or \"
        /// </summary>
        [XmlElement(ElementName = "Area")]
        public System.String Area;

        /// <summary>
        /// An instance of the GeneticCodeRow that stores the values that are referenced by the foreign key column "GeneticCode".
        /// </summary>
        [XmlElement(ElementName = "GeneticCodeRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer GeneticCodeRowSerializableContainer;

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow that stores the values of the ForeignKey Strong Row if it were joined to the TheFunctionRow on the Foreign Key Column "ParentFunction". TheFunctionRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Parameter_ParentFunctionRow ForeignKeyStrongRow.
        /// </summary>
        [XmlElement(ElementName = "ForeignKeyRow_Parameter_ParentFunctionRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.ParameterRowSerializableContainer ForeignKeyRow_Parameter_ParentFunctionRowSerializableContainer;

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow that stores the values of the ForeignKey Strong Row if it were joined to the TheFunctionRow on the Foreign Key Column "TheFunction". TheFunctionRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_FunctionRegistry_TheFunctionRow ForeignKeyStrongRow.
        /// </summary>
        [XmlElement(ElementName = "ForeignKeyRow_FunctionRegistry_TheFunctionRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionRegistryRowSerializableContainer ForeignKeyRow_FunctionRegistry_TheFunctionRowSerializableContainer;

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow that stores the values of the ForeignKey Strong Row if it were joined to the TheFunctionRow on the Foreign Key Column "PrimaryFunction". TheFunctionRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_FunctionPair_PrimaryFunctionRow ForeignKeyStrongRow.
        /// </summary>
        [XmlElement(ElementName = "ForeignKeyRow_FunctionPair_PrimaryFunctionRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionPairRowSerializableContainer ForeignKeyRow_FunctionPair_PrimaryFunctionRowSerializableContainer;

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow that stores the values of the ForeignKey Strong Row if it were joined to the TheFunctionRow on the Foreign Key Column "ParameterlessFunction". TheFunctionRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_FunctionPair_ParameterlessFunctionRow ForeignKeyStrongRow.
        /// </summary>
        [XmlElement(ElementName = "ForeignKeyRow_FunctionPair_ParameterlessFunctionRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionPairRowSerializableContainer ForeignKeyRow_FunctionPair_ParameterlessFunctionRowSerializableContainer;

        /// <summary>
        /// Constructs an instance of this TheFunctionRowSerializableContainer from the given TheFunctionRow.
        /// </summary>
        /// <param name="theFunctionRow">A Function.</param>
        public TheFunctionRowSerializableContainer(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow theFunctionRow)
            : this()
        {
            this.PK_FunctionID = theFunctionRow.PK_FunctionID;
            this.FunctionIdentifier = theFunctionRow.FunctionIdentifier;
            this.GeneticCode = theFunctionRow.GeneticCode;
            this.Name = theFunctionRow.Name;
            this.BaseName = theFunctionRow.BaseName;
            this.WeightInGeneticCode = theFunctionRow.WeightInGeneticCode;
            this.ExecuteMethodName = theFunctionRow.ExecuteMethodName;
            this.Area = theFunctionRow.Area;
            if (!theFunctionRow.IsGeneticCodeRowNull)
                this.GeneticCodeRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer(theFunctionRow.GeneticCodeRow);
            if (!theFunctionRow.IsForeignKeyRow_Parameter_ParentFunctionRowNull)
                this.ForeignKeyRow_Parameter_ParentFunctionRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.ParameterRowSerializableContainer(theFunctionRow.ForeignKeyRow_Parameter_ParentFunctionRow);
            if (!theFunctionRow.IsForeignKeyRow_FunctionRegistry_TheFunctionRowNull)
                this.ForeignKeyRow_FunctionRegistry_TheFunctionRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionRegistryRowSerializableContainer(theFunctionRow.ForeignKeyRow_FunctionRegistry_TheFunctionRow);
            if (!theFunctionRow.IsForeignKeyRow_FunctionPair_PrimaryFunctionRowNull)
                this.ForeignKeyRow_FunctionPair_PrimaryFunctionRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionPairRowSerializableContainer(theFunctionRow.ForeignKeyRow_FunctionPair_PrimaryFunctionRow);
            if (!theFunctionRow.IsForeignKeyRow_FunctionPair_ParameterlessFunctionRowNull)
                this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionPairRowSerializableContainer(theFunctionRow.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow);
        }

        /// <summary>
        /// Constructs an empty instance of a TheFunctionRowSerializableContainer
        /// </summary>
        public TheFunctionRowSerializableContainer()
        {

        }

        /// <summary>
        /// Converts the TheFunctionRowSerializableContainer to the a TheFunctionRow.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow ToTheFunctionRowStrongRow()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow(this);
        }

        /// <summary>
        /// Converts the StrongRowSerializableContainer to the appropriate StrongRow.
        /// </summary>
        public override StrongRow ToStrongRow()
        {
            return this.ToTheFunctionRowStrongRow();
        }
    }
}