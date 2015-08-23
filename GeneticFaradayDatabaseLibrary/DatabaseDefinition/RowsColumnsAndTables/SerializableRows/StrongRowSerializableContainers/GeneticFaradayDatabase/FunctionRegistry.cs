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
    /// A Registry that is available to a Function.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "")]
    public sealed partial class FunctionRegistryRowSerializableContainer : StrongRowSerializableContainer
    {
        /// <summary>
        /// PK_FunctionRegistryID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [XmlElement(ElementName = "PK_FunctionRegistryID")]
        public System.Int32 PK_FunctionRegistryID;

        /// <summary>
        /// The Function to which the Registry is available.
        /// </summary>
        [XmlElement(ElementName = "TheFunction")]
        public System.Int32 TheFunction;

        /// <summary>
        /// The identifier of the Registry that is available to the Function.
        /// </summary>
        [XmlElement(ElementName = "Registry")]
        public System.String Registry;

        /// <summary>
        /// The GeneticCode to which this Function applies.
        /// </summary>
        [XmlElement(ElementName = "GeneticCode")]
        public System.Int32 GeneticCode;

        /// <summary>
        /// An instance of the TheFunctionRow that stores the values that are referenced by the foreign key column "TheFunction".
        /// </summary>
        [XmlElement(ElementName = "TheFunctionRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.TheFunctionRowSerializableContainer TheFunctionRowSerializableContainer;

        /// <summary>
        /// An instance of the GeneticCodeRow that stores the values that are referenced by the foreign key column "GeneticCode".
        /// </summary>
        [XmlElement(ElementName = "GeneticCodeRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer GeneticCodeRowSerializableContainer;

        /// <summary>
        /// Constructs an instance of this FunctionRegistryRowSerializableContainer from the given FunctionRegistryRow.
        /// </summary>
        /// <param name="functionRegistryRow">A Registry that is available to a Function.</param>
        public FunctionRegistryRowSerializableContainer(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow functionRegistryRow)
            : this()
        {
            this.PK_FunctionRegistryID = functionRegistryRow.PK_FunctionRegistryID;
            this.TheFunction = functionRegistryRow.TheFunction;
            this.Registry = functionRegistryRow.Registry;
            this.GeneticCode = functionRegistryRow.GeneticCode;
            if (!functionRegistryRow.IsTheFunctionRowNull)
                this.TheFunctionRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.TheFunctionRowSerializableContainer(functionRegistryRow.TheFunctionRow);
            if (!functionRegistryRow.IsGeneticCodeRowNull)
                this.GeneticCodeRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer(functionRegistryRow.GeneticCodeRow);
        }

        /// <summary>
        /// Constructs an empty instance of a FunctionRegistryRowSerializableContainer
        /// </summary>
        public FunctionRegistryRowSerializableContainer()
        {

        }

        /// <summary>
        /// Converts the FunctionRegistryRowSerializableContainer to the a FunctionRegistryRow.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow ToFunctionRegistryRowStrongRow()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow(this);
        }

        /// <summary>
        /// Converts the StrongRowSerializableContainer to the appropriate StrongRow.
        /// </summary>
        public override StrongRow ToStrongRow()
        {
            return this.ToFunctionRegistryRowStrongRow();
        }
    }
}