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
    /// A Parameter to a Function.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "")]
    public sealed partial class ParameterRowSerializableContainer : StrongRowSerializableContainer
    {
        /// <summary>
        /// PK_ParameterID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        [XmlElement(ElementName = "PK_ParameterID")]
        public System.Int32 PK_ParameterID;

        /// <summary>
        /// The Parameter Type of the Parameter.
        /// </summary>
        [XmlElement(ElementName = "ParameterType")]
        public System.String ParameterType;

        /// <summary>
        /// Only used if the ParameterType is ParameterType.ConvertedCodon. The ICodonConverter as identified by this ICodonConverterIdentifier will be used to convert an ICodon and will then be passed to the IArgument that this IParameter defines.
        /// </summary>
        [XmlElement(ElementName = "CodonConverterIdentifier")]
        public System.String CodonConverterIdentifier;

        /// <summary>
        /// The function to which the Parameter belongs.
        /// </summary>
        [XmlElement(ElementName = "ParentFunction")]
        public System.Int32 ParentFunction;

        /// <summary>
        /// The index of the Parameter in the parent Function.
        /// </summary>
        [XmlElement(ElementName = "ParameterIndex")]
        public System.Int32 ParameterIndex;

        /// <summary>
        /// The GeneticCode to which this Function applies.
        /// </summary>
        [XmlElement(ElementName = "GeneticCode")]
        public System.Int32 GeneticCode;

        /// <summary>
        /// An instance of the ParentFunctionRow that stores the values that are referenced by the foreign key column "ParentFunction".
        /// </summary>
        [XmlElement(ElementName = "ParentFunctionRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.TheFunctionRowSerializableContainer ParentFunctionRowSerializableContainer;

        /// <summary>
        /// An instance of the GeneticCodeRow that stores the values that are referenced by the foreign key column "GeneticCode".
        /// </summary>
        [XmlElement(ElementName = "GeneticCodeRow")]
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer GeneticCodeRowSerializableContainer;

        /// <summary>
        /// Constructs an instance of this ParameterRowSerializableContainer from the given ParameterRow.
        /// </summary>
        /// <param name="parameterRow">A Parameter to a Function.</param>
        public ParameterRowSerializableContainer(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow parameterRow)
            : this()
        {
            this.PK_ParameterID = parameterRow.PK_ParameterID;
            this.ParameterType = parameterRow.ParameterType;
            this.CodonConverterIdentifier = parameterRow.CodonConverterIdentifier;
            this.ParentFunction = parameterRow.ParentFunction;
            this.ParameterIndex = parameterRow.ParameterIndex;
            this.GeneticCode = parameterRow.GeneticCode;
            if (!parameterRow.IsParentFunctionRowNull)
                this.ParentFunctionRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.TheFunctionRowSerializableContainer(parameterRow.ParentFunctionRow);
            if (!parameterRow.IsGeneticCodeRowNull)
                this.GeneticCodeRowSerializableContainer = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer(parameterRow.GeneticCodeRow);
        }

        /// <summary>
        /// Constructs an empty instance of a ParameterRowSerializableContainer
        /// </summary>
        public ParameterRowSerializableContainer()
        {

        }

        /// <summary>
        /// Converts the ParameterRowSerializableContainer to the a ParameterRow.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow ToParameterRowStrongRow()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow(this);
        }

        /// <summary>
        /// Converts the StrongRowSerializableContainer to the appropriate StrongRow.
        /// </summary>
        public override StrongRow ToStrongRow()
        {
            return this.ToParameterRowStrongRow();
        }
    }
}