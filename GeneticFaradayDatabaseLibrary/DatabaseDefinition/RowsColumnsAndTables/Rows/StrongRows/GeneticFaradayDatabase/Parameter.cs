using System;
using System.Collections.Generic;
using UtilityData.Database;
using UtilityData.Database.Tables;
using UtilityData.Database.Rows;
using UtilityData.SQL;
using UtilityData.LINQ;
using UtilityData.Log;
using UtilityData.Domain;

namespace GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows
{
    /// <summary>
    /// A Parameter to a Function.
    /// </summary>
    [Serializable]
    public sealed partial class ParameterRow : StrongRow, IRepository<ParameterRow>, IStrongRowDescendant<ParameterRow>
    {
        /// <summary>
        /// This class provides redundant access to the values of the underlying Row in a ParameterRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        [Serializable]
        public sealed partial class ParameterRowValues
        {
            /// <summary>
            /// PK_ParameterID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PK_ParameterID
            {
                get { return this.Parent.PK_ParameterID; }
                set { this.Parent.PK_ParameterID = value; }
            }

            /// <summary>
            /// The Parameter Type of the Parameter.
            /// </summary>
            public StrongEnums.ParameterType ParameterType
            {
                get { return this.Parent.ParameterType; }
                set { this.Parent.ParameterType = value; }
            }

            /// <summary>
            /// Only used if the ParameterType is ParameterType.ConvertedCodon. The ICodonConverter as identified by this ICodonConverterIdentifier will be used to convert an ICodon and will then be passed to the IArgument that this IParameter defines.
            /// </summary>
            public StrongEnums.CodonConverterIdentifier CodonConverterIdentifier
            {
                get { return this.Parent.CodonConverterIdentifier; }
                set { this.Parent.CodonConverterIdentifier = value; }
            }

            /// <summary>
            /// The function to which the Parameter belongs.
            /// </summary>
            public System.Int32 ParentFunction
            {
                get { return this.Parent.ParentFunction; }
                set { this.Parent.ParentFunction = value; }
            }

            /// <summary>
            /// The index of the Parameter in the parent Function.
            /// </summary>
            public System.Int32 ParameterIndex
            {
                get { return this.Parent.ParameterIndex; }
                set { this.Parent.ParameterIndex = value; }
            }

            /// <summary>
            /// The GeneticCode to which this Function applies.
            /// </summary>
            public System.Int32 GeneticCode
            {
                get { return this.Parent.GeneticCode; }
                set { this.Parent.GeneticCode = value; }
            }

            /// <summary>
            /// PK_ParameterID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PrimaryKey
            {
                get { return this.PK_ParameterID; }
                set { this.PK_ParameterID = value; }
            }

            /// <summary>
            /// The parent ParameterRow whose values will be viewed and manipulated through this ParameterRowValues.
            /// </summary>
            public ParameterRow Parent { get; private set; }

            /// <summary>
            /// Constructs a ParameterRowValues from a parent ParameterRow.
            /// </summary>
            /// <param name="parent">The parent ParameterRow whose values will be viewed and manipulated through this ParameterRowValues.</param>
            public ParameterRowValues(ParameterRow parent)
            {
                this.Parent = parent;
            }
        }

        /// <summary>
        /// This property provides redundant access to the values of the underlying Row in this ParameterRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow.ParameterRowValues Values { get; private set; }

        /// <summary>
        /// The StrongRowColumn where the value of PK_ParameterID is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _pK_ParameterIDColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of PK_ParameterID is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn PK_ParameterIDColumn
        {
            get
            {
                if (this._pK_ParameterIDColumn == null)
                {
                    this.PK_ParameterIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.PK_ParameterID);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.PK_ParameterID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_ParameterID_ValueChanged);
                }

                return this._pK_ParameterIDColumn;
            }
            private set { this._pK_ParameterIDColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of ParameterType is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _parameterTypeColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of ParameterType is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn ParameterTypeColumn
        {
            get
            {
                if (this._parameterTypeColumn == null)
                {
                    this.ParameterTypeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(ParameterType_ValueChanged);
                }

                return this._parameterTypeColumn;
            }
            private set { this._parameterTypeColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of CodonConverterIdentifier is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _codonConverterIdentifierColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of CodonConverterIdentifier is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn CodonConverterIdentifierColumn
        {
            get
            {
                if (this._codonConverterIdentifierColumn == null)
                {
                    this.CodonConverterIdentifierColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(CodonConverterIdentifier_ValueChanged);
                }

                return this._codonConverterIdentifierColumn;
            }
            private set { this._codonConverterIdentifierColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of ParentFunction is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _parentFunctionColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of ParentFunction is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn ParentFunctionColumn
        {
            get
            {
                if (this._parentFunctionColumn == null)
                {
                    this.ParentFunctionColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParentFunction);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParentFunction].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(ParentFunction_ValueChanged);
                }

                return this._parentFunctionColumn;
            }
            private set { this._parentFunctionColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of ParameterIndex is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _parameterIndexColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of ParameterIndex is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn ParameterIndexColumn
        {
            get
            {
                if (this._parameterIndexColumn == null)
                {
                    this.ParameterIndexColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterIndex);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterIndex].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(ParameterIndex_ValueChanged);
                }

                return this._parameterIndexColumn;
            }
            private set { this._parameterIndexColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of GeneticCode is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _geneticCodeColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of GeneticCode is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn GeneticCodeColumn
        {
            get
            {
                if (this._geneticCodeColumn == null)
                {
                    this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.GeneticCode);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
                }

                return this._geneticCodeColumn;
            }
            private set { this._geneticCodeColumn = value; }
        }



        /// <summary>
        /// Raised when the value of PK_ParameterID has changed.<para></para><para></para>This will only fire when the value of the property PK_ParameterID is set. If the corresponding value is set through the underlying row or through the property PK_ParameterIDColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> PK_ParameterIDChanged;

        /// <summary>
        /// When raised, indicates that the value of PK_ParameterID has changed which fires the PK_ParameterIDChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PK_ParameterIDChanged event.</param>
        private void OnPK_ParameterIDChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (PK_ParameterIDChanged != null)
                PK_ParameterIDChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of ParameterType has changed.<para></para><para></para>This will only fire when the value of the property ParameterType is set. If the corresponding value is set through the underlying row or through the property ParameterTypeColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<StrongEnums.ParameterType>> ParameterTypeChanged;

        /// <summary>
        /// When raised, indicates that the value of ParameterType has changed which fires the ParameterTypeChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ParameterTypeChanged event.</param>
        private void OnParameterTypeChanged(RowValueChangedEventArgs<StrongEnums.ParameterType> e)
        {
            if (ParameterTypeChanged != null)
                ParameterTypeChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of CodonConverterIdentifier has changed.<para></para><para></para>This will only fire when the value of the property CodonConverterIdentifier is set. If the corresponding value is set through the underlying row or through the property CodonConverterIdentifierColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<StrongEnums.CodonConverterIdentifier>> CodonConverterIdentifierChanged;

        /// <summary>
        /// When raised, indicates that the value of CodonConverterIdentifier has changed which fires the CodonConverterIdentifierChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the CodonConverterIdentifierChanged event.</param>
        private void OnCodonConverterIdentifierChanged(RowValueChangedEventArgs<StrongEnums.CodonConverterIdentifier> e)
        {
            if (CodonConverterIdentifierChanged != null)
                CodonConverterIdentifierChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of ParentFunction has changed.<para></para><para></para>This will only fire when the value of the property ParentFunction is set. If the corresponding value is set through the underlying row or through the property ParentFunctionColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> ParentFunctionChanged;

        /// <summary>
        /// When raised, indicates that the value of ParentFunction has changed which fires the ParentFunctionChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ParentFunctionChanged event.</param>
        private void OnParentFunctionChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (ParentFunctionChanged != null)
                ParentFunctionChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of ParameterIndex has changed.<para></para><para></para>This will only fire when the value of the property ParameterIndex is set. If the corresponding value is set through the underlying row or through the property ParameterIndexColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> ParameterIndexChanged;

        /// <summary>
        /// When raised, indicates that the value of ParameterIndex has changed which fires the ParameterIndexChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ParameterIndexChanged event.</param>
        private void OnParameterIndexChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (ParameterIndexChanged != null)
                ParameterIndexChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of GeneticCode has changed.<para></para><para></para>This will only fire when the value of the property GeneticCode is set. If the corresponding value is set through the underlying row or through the property GeneticCodeColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> GeneticCodeChanged;

        /// <summary>
        /// When raised, indicates that the value of GeneticCode has changed which fires the GeneticCodeChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the GeneticCodeChanged event.</param>
        private void OnGeneticCodeChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (GeneticCodeChanged != null)
                GeneticCodeChanged(this, e);
        }



        /// <summary>
        /// PK_ParameterID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public System.Int32 PK_ParameterID
        {
            get { return this.PK_ParameterIDColumn.Value.ToInt(); }
            set { this.PK_ParameterIDColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnPK_ParameterIDChanged when the value of PK_ParameterID in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PK_ParameterID_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasPK_ParameterIDValueChanged = true;

            // Find the Foreign Key that refers to this Column (if there is any)
            var foreignKeyStrongRows = this.GetForeignKeyColumnsReferringToColumn(PK_ParameterIDColumn);
            if (foreignKeyStrongRows != null)
                foreach (var foreignKeyStrongRow in foreignKeyStrongRows)
                    this.Parent.GetStrongRowColumn(foreignKeyStrongRow.ForeignKeyColumn).Value = e.NewValue;

            OnPK_ParameterIDChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.PK_ParameterIDColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of PK_ParameterID in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.PK_ParameterID) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsPK_ParameterIDNullOrEmpty
        {
            get { return this.PK_ParameterIDColumn.Value.IsNullOrDBNull() || this.PK_ParameterID == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets PK_ParameterID as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PK_ParameterIDNullable
        {
            get { return IsPK_ParameterIDNullOrEmpty ? null as System.Int32? : this.PK_ParameterID; }
        }

        /// <summary>
        /// The Parameter Type of the Parameter.
        /// </summary>
        public StrongEnums.ParameterType ParameterType
        {
            get
            {
                if (this.ParameterTypeColumn.Value != null)
                    return (StrongEnums.ParameterType)this.ParameterTypeColumn.Value.ToString();
                else
                    return null;
            }
            set
            {
                if (value == null)
                    throw new Exception("ParameterType cannot be null.");

                this.ParameterTypeColumn.Value = value;
            }
        }

        /// <summary>
        /// Raises OnParameterTypeChanged when the value of ParameterType in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ParameterType_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasParameterTypeValueChanged = true;

            // Only update the primary key of the Foreign Row if we need to (so that we don't circularly update the primary keys).
            if (this._parameterTypeRow != null && this.ParameterType != null)
                if (this.ParameterTypeRow.PrimaryKey != this.ParameterType)
                    this.ParameterTypeRow.PrimaryKey = e.NewValue.ToString();

            OnParameterTypeChanged(new RowValueChangedEventArgs<StrongEnums.ParameterType>(e.PreviousValue.IsNullOrDBNull() ? null : (StrongEnums.ParameterType)e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : (StrongEnums.ParameterType)e.NewValue.ToString(), this.ParameterTypeColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of ParameterType in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.ParameterType) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsParameterTypeNullOrEmpty
        {
            get { return this.ParameterTypeColumn.Value.IsNullOrDBNull() || this.ParameterType == String.Empty; }
        }

        /// <summary>
        /// Only used if the ParameterType is ParameterType.ConvertedCodon. The ICodonConverter as identified by this ICodonConverterIdentifier will be used to convert an ICodon and will then be passed to the IArgument that this IParameter defines.
        /// </summary>
        public StrongEnums.CodonConverterIdentifier CodonConverterIdentifier
        {
            get
            {
                if (this.CodonConverterIdentifierColumn.Value != null)
                    return (StrongEnums.CodonConverterIdentifier)this.CodonConverterIdentifierColumn.Value.ToString();
                else
                    return null;
            }
            set { this.CodonConverterIdentifierColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnCodonConverterIdentifierChanged when the value of CodonConverterIdentifier in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CodonConverterIdentifier_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasCodonConverterIdentifierValueChanged = true;

            // Only update the primary key of the Foreign Row if we need to (so that we don't circularly update the primary keys).
            if (this._codonConverterIdentifierRow != null && this.CodonConverterIdentifier != null)
                if (this.CodonConverterIdentifierRow.PrimaryKey != this.CodonConverterIdentifier)
                    this.CodonConverterIdentifierRow.PrimaryKey = e.NewValue.ToString();

            OnCodonConverterIdentifierChanged(new RowValueChangedEventArgs<StrongEnums.CodonConverterIdentifier>(e.PreviousValue.IsNullOrDBNull() ? null : (StrongEnums.CodonConverterIdentifier)e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : (StrongEnums.CodonConverterIdentifier)e.NewValue.ToString(), this.CodonConverterIdentifierColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of CodonConverterIdentifier in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.CodonConverterIdentifier) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsCodonConverterIdentifierNullOrEmpty
        {
            get { return this.CodonConverterIdentifierColumn.Value.IsNullOrDBNull() || this.CodonConverterIdentifier == String.Empty; }
        }

        /// <summary>
        /// The function to which the Parameter belongs.
        /// </summary>
        public System.Int32 ParentFunction
        {
            get { return this.ParentFunctionColumn.Value.ToInt(); }
            set { this.ParentFunctionColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnParentFunctionChanged when the value of ParentFunction in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ParentFunction_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasParentFunctionValueChanged = true;

            // Only update the primary key of the Foreign Row if we need to (so that we don't circularly update the primary keys).
            if (this._parentFunctionRow != null)
                if (this.ParentFunctionRow.PrimaryKey != this.ParentFunction)
                    this.ParentFunctionRow.PrimaryKey = this.ParentFunction;

            OnParentFunctionChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.ParentFunctionColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of ParentFunction in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.ParentFunction) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsParentFunctionNullOrEmpty
        {
            get { return this.ParentFunctionColumn.Value.IsNullOrDBNull() || this.ParentFunction == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets ParentFunction as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? ParentFunctionNullable
        {
            get { return IsParentFunctionNullOrEmpty ? null as System.Int32? : this.ParentFunction; }
        }

        /// <summary>
        /// The index of the Parameter in the parent Function.
        /// </summary>
        public System.Int32 ParameterIndex
        {
            get { return this.ParameterIndexColumn.Value.ToInt(); }
            set { this.ParameterIndexColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnParameterIndexChanged when the value of ParameterIndex in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ParameterIndex_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasParameterIndexValueChanged = true;

            OnParameterIndexChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.ParameterIndexColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of ParameterIndex in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.ParameterIndex) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsParameterIndexNullOrEmpty
        {
            get { return this.ParameterIndexColumn.Value.IsNullOrDBNull() || this.ParameterIndex == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets ParameterIndex as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? ParameterIndexNullable
        {
            get { return IsParameterIndexNullOrEmpty ? null as System.Int32? : this.ParameterIndex; }
        }

        /// <summary>
        /// The GeneticCode to which this Function applies.
        /// </summary>
        public System.Int32 GeneticCode
        {
            get { return this.GeneticCodeColumn.Value.ToInt(); }
            set { this.GeneticCodeColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnGeneticCodeChanged when the value of GeneticCode in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void GeneticCode_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasGeneticCodeValueChanged = true;

            // Only update the primary key of the Foreign Row if we need to (so that we don't circularly update the primary keys).
            if (this._geneticCodeRow != null)
                if (this.GeneticCodeRow.PrimaryKey != this.GeneticCode)
                    this.GeneticCodeRow.PrimaryKey = this.GeneticCode;

            OnGeneticCodeChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.GeneticCodeColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of GeneticCode in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.GeneticCode) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsGeneticCodeNullOrEmpty
        {
            get { return this.GeneticCodeColumn.Value.IsNullOrDBNull() || this.GeneticCode == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets GeneticCode as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? GeneticCodeNullable
        {
            get { return IsGeneticCodeNullOrEmpty ? null as System.Int32? : this.GeneticCode; }
        }

        /// <summary>
        /// Indicates whether any value in this ParameterRow that is not a Row (ForeignStrongRow or ForeignKeyStrongRow) is null or DBNull.Value or Empty. If false, all non-row values have values (i.e. are not null).
        /// </summary>
        public override bool IsAnyNonRowValueNullOrEmpty
        {
            get
            {
                if (this.IsPK_ParameterIDNullOrEmpty)
                    return true;
                if (this.IsParameterTypeNullOrEmpty)
                    return true;
                if (this.IsCodonConverterIdentifierNullOrEmpty)
                    return true;
                if (this.IsParentFunctionNullOrEmpty)
                    return true;
                if (this.IsParameterIndexNullOrEmpty)
                    return true;
                if (this.IsGeneticCodeNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Indicates whether the value of PK_ParameterID has changed since either this ParameterRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasPK_ParameterIDValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of ParameterType has changed since either this ParameterRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasParameterTypeValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of CodonConverterIdentifier has changed since either this ParameterRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasCodonConverterIdentifierValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of ParentFunction has changed since either this ParameterRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasParentFunctionValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of ParameterIndex has changed since either this ParameterRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasParameterIndexValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of GeneticCode has changed since either this ParameterRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasGeneticCodeValueChanged { get; private set; }

        /// <summary>
        /// An instance of the ParameterTypeRow that stores the values that are referenced by the foreign key column "ParameterType".
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow _parameterTypeRow;
        /// <summary>
        /// /// An instance of the ParameterTypeRow that stores the values that are referenced by the foreign key column "ParameterType".
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow ParameterTypeRow
        {
            get
            {
                if (this._parameterTypeRow == null)
                {
                    this._parameterTypeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow();
                    this.InitializeParameterTypeRow();
                }

                return _parameterTypeRow;
            }
            set
            {
                var originalValue = this.ParameterTypeRow;
                this._parameterTypeRow = value;


                this.InitializeParameterTypeRow();

                OnParameterTypeRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this ParameterRow to the foreign ParameterTypeRow. This contains the ForeignKeyColumn of this ParameterRow and the referenced ForeignColumn that will be used to join the ParameterTypeRow.
        /// </summary>
        private StrongRowForeignKeyColumn _parameterTypeRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this ParameterRow to the foreign ParameterTypeRow. This contains the ForeignKeyColumn of this ParameterRow and the referenced ForeignColumn that will be used to join the ParameterTypeRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn ParameterTypeRowColumn
        {
            get
            {
                if (this._parameterTypeRowColumn == null)
                    this.ParameterTypeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.ParameterTypeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType);

                return this._parameterTypeRowColumn;
            }
            private set { this._parameterTypeRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ParameterTypeRow has changed (is NOT raised when a value inside ParameterTypeRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow>> ParameterTypeRowChanged;

        /// <summary>
        /// Indicates that the value of ParameterType has changed which fires the ParameterTypeChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ParameterTypeRowChanged event.</param>
        private void OnParameterTypeRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow> e)
        {
            if (ParameterTypeRowChanged != null)
                ParameterTypeRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignStrongRow ParameterTypeRow.
        /// </summary>
        private void SubscribeToValueChangesOfParameterTypeRow()
        {
            if (this.ParameterTypeRow != null)
                this.ParameterTypeRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when initializing the value of ParameterTypeRow.
        /// </summary>
        private void InitializeParameterTypeRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ParameterTypeRow))
                this.OtherRowTableAliases.Remove(this.ParameterTypeRow);

            this.ParameterTypeRowColumn.ForeignRow = this.ParameterTypeRow;

            this.OtherRowTableAliases.Add(this.ParameterTypeRow, "parameterType");
            this.ParameterTypeRow.Parent = this;
            if (this.ParameterType != null)
                this.ParameterTypeRow.PrimaryKey = this.ParameterType;
            SubscribeToValueChangesOfParameterTypeRow();
        }

        /// <summary>
        /// Indicates whether the value of the ParameterTypeRow is null or DBNull.Value (does not Initialize the ParameterTypeRow if it is currently null).
        /// </summary>
        public bool IsParameterTypeRowNull
        {
            get { return this._parameterTypeRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// An instance of the CodonConverterIdentifierRow that stores the values that are referenced by the foreign key column "CodonConverterIdentifier".
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow _codonConverterIdentifierRow;
        /// <summary>
        /// /// An instance of the CodonConverterIdentifierRow that stores the values that are referenced by the foreign key column "CodonConverterIdentifier".
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow CodonConverterIdentifierRow
        {
            get
            {
                if (this._codonConverterIdentifierRow == null)
                {
                    this._codonConverterIdentifierRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow();
                    this.InitializeCodonConverterIdentifierRow();
                }

                return _codonConverterIdentifierRow;
            }
            set
            {
                var originalValue = this.CodonConverterIdentifierRow;
                this._codonConverterIdentifierRow = value;


                this.InitializeCodonConverterIdentifierRow();

                OnCodonConverterIdentifierRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this ParameterRow to the foreign CodonConverterIdentifierRow. This contains the ForeignKeyColumn of this ParameterRow and the referenced ForeignColumn that will be used to join the CodonConverterIdentifierRow.
        /// </summary>
        private StrongRowForeignKeyColumn _codonConverterIdentifierRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this ParameterRow to the foreign CodonConverterIdentifierRow. This contains the ForeignKeyColumn of this ParameterRow and the referenced ForeignColumn that will be used to join the CodonConverterIdentifierRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn CodonConverterIdentifierRowColumn
        {
            get
            {
                if (this._codonConverterIdentifierRowColumn == null)
                    this.CodonConverterIdentifierRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.CodonConverterIdentifierRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier);

                return this._codonConverterIdentifierRowColumn;
            }
            private set { this._codonConverterIdentifierRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of CodonConverterIdentifierRow has changed (is NOT raised when a value inside CodonConverterIdentifierRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow>> CodonConverterIdentifierRowChanged;

        /// <summary>
        /// Indicates that the value of CodonConverterIdentifier has changed which fires the CodonConverterIdentifierChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the CodonConverterIdentifierRowChanged event.</param>
        private void OnCodonConverterIdentifierRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow> e)
        {
            if (CodonConverterIdentifierRowChanged != null)
                CodonConverterIdentifierRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignStrongRow CodonConverterIdentifierRow.
        /// </summary>
        private void SubscribeToValueChangesOfCodonConverterIdentifierRow()
        {
            if (this.CodonConverterIdentifierRow != null)
                this.CodonConverterIdentifierRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when initializing the value of CodonConverterIdentifierRow.
        /// </summary>
        private void InitializeCodonConverterIdentifierRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.CodonConverterIdentifierRow))
                this.OtherRowTableAliases.Remove(this.CodonConverterIdentifierRow);

            this.CodonConverterIdentifierRowColumn.ForeignRow = this.CodonConverterIdentifierRow;

            this.OtherRowTableAliases.Add(this.CodonConverterIdentifierRow, "codonConverterIdentifier");
            this.CodonConverterIdentifierRow.Parent = this;
            if (!this.CodonConverterIdentifier.IsNullOrDBNull())
                this.CodonConverterIdentifierRow.PrimaryKey = this.CodonConverterIdentifier;
            SubscribeToValueChangesOfCodonConverterIdentifierRow();
        }

        /// <summary>
        /// Indicates whether the value of the CodonConverterIdentifierRow is null or DBNull.Value (does not Initialize the CodonConverterIdentifierRow if it is currently null).
        /// </summary>
        public bool IsCodonConverterIdentifierRowNull
        {
            get { return this._codonConverterIdentifierRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// An instance of the ParentFunctionRow that stores the values that are referenced by the foreign key column "ParentFunction".
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow _parentFunctionRow;
        /// <summary>
        /// /// An instance of the ParentFunctionRow that stores the values that are referenced by the foreign key column "ParentFunction".
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow ParentFunctionRow
        {
            get
            {
                if (this._parentFunctionRow == null)
                {
                    this._parentFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
                    this.InitializeParentFunctionRow();
                }

                return _parentFunctionRow;
            }
            set
            {
                var originalValue = this.ParentFunctionRow;
                this._parentFunctionRow = value;


                this.InitializeParentFunctionRow();

                OnParentFunctionRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParentFunction, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParentFunction, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this ParameterRow to the foreign ParentFunctionRow. This contains the ForeignKeyColumn of this ParameterRow and the referenced ForeignColumn that will be used to join the ParentFunctionRow.
        /// </summary>
        private StrongRowForeignKeyColumn _parentFunctionRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this ParameterRow to the foreign ParentFunctionRow. This contains the ForeignKeyColumn of this ParameterRow and the referenced ForeignColumn that will be used to join the ParentFunctionRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn ParentFunctionRowColumn
        {
            get
            {
                if (this._parentFunctionRowColumn == null)
                    this.ParentFunctionRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.ParentFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParentFunction);

                return this._parentFunctionRowColumn;
            }
            private set { this._parentFunctionRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ParentFunctionRow has changed (is NOT raised when a value inside ParentFunctionRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow>> ParentFunctionRowChanged;

        /// <summary>
        /// Indicates that the value of ParentFunction has changed which fires the ParentFunctionChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ParentFunctionRowChanged event.</param>
        private void OnParentFunctionRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow> e)
        {
            if (ParentFunctionRowChanged != null)
                ParentFunctionRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignStrongRow ParentFunctionRow.
        /// </summary>
        private void SubscribeToValueChangesOfParentFunctionRow()
        {
            if (this.ParentFunctionRow != null)
                this.ParentFunctionRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when initializing the value of ParentFunctionRow.
        /// </summary>
        private void InitializeParentFunctionRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ParentFunctionRow))
                this.OtherRowTableAliases.Remove(this.ParentFunctionRow);

            this.ParentFunctionRowColumn.ForeignRow = this.ParentFunctionRow;

            this.OtherRowTableAliases.Add(this.ParentFunctionRow, "parentFunction");
            this.ParentFunctionRow.Parent = this;
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParentFunction].Value.IsInt() && this.ParentFunction != null)
                this.ParentFunctionRow.PrimaryKey = this.ParentFunction;
            SubscribeToValueChangesOfParentFunctionRow();
        }

        /// <summary>
        /// Indicates whether the value of the ParentFunctionRow is null or DBNull.Value (does not Initialize the ParentFunctionRow if it is currently null).
        /// </summary>
        public bool IsParentFunctionRowNull
        {
            get { return this._parentFunctionRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// An instance of the GeneticCodeRow that stores the values that are referenced by the foreign key column "GeneticCode".
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow _geneticCodeRow;
        /// <summary>
        /// /// An instance of the GeneticCodeRow that stores the values that are referenced by the foreign key column "GeneticCode".
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow GeneticCodeRow
        {
            get
            {
                if (this._geneticCodeRow == null)
                {
                    this._geneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow();
                    this.InitializeGeneticCodeRow();
                }

                return _geneticCodeRow;
            }
            set
            {
                var originalValue = this.GeneticCodeRow;
                this._geneticCodeRow = value;


                this.InitializeGeneticCodeRow();

                OnGeneticCodeRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.GeneticCode, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.GeneticCode, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this ParameterRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this ParameterRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// </summary>
        private StrongRowForeignKeyColumn _geneticCodeRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this ParameterRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this ParameterRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn GeneticCodeRowColumn
        {
            get
            {
                if (this._geneticCodeRowColumn == null)
                    this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.GeneticCode);

                return this._geneticCodeRowColumn;
            }
            private set { this._geneticCodeRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of GeneticCodeRow has changed (is NOT raised when a value inside GeneticCodeRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow>> GeneticCodeRowChanged;

        /// <summary>
        /// Indicates that the value of GeneticCode has changed which fires the GeneticCodeChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the GeneticCodeRowChanged event.</param>
        private void OnGeneticCodeRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow> e)
        {
            if (GeneticCodeRowChanged != null)
                GeneticCodeRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignStrongRow GeneticCodeRow.
        /// </summary>
        private void SubscribeToValueChangesOfGeneticCodeRow()
        {
            if (this.GeneticCodeRow != null)
                this.GeneticCodeRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when initializing the value of GeneticCodeRow.
        /// </summary>
        private void InitializeGeneticCodeRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.GeneticCodeRow))
                this.OtherRowTableAliases.Remove(this.GeneticCodeRow);

            this.GeneticCodeRowColumn.ForeignRow = this.GeneticCodeRow;

            this.OtherRowTableAliases.Add(this.GeneticCodeRow, "geneticCode");
            this.GeneticCodeRow.Parent = this;
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.GeneticCode].Value.IsInt() && this.GeneticCode != null)
                this.GeneticCodeRow.PrimaryKey = this.GeneticCode;
            SubscribeToValueChangesOfGeneticCodeRow();
        }

        /// <summary>
        /// Indicates whether the value of the GeneticCodeRow is null or DBNull.Value (does not Initialize the GeneticCodeRow if it is currently null).
        /// </summary>
        public bool IsGeneticCodeRowNull
        {
            get { return this._geneticCodeRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// Indicates whether any Foreign StrongRow in this ParameterRow is null or DBNull.Value or empty.
        /// </summary>
        public override bool IsAnyForeignRowNull
        {
            get
            {
                if (this.IsParameterTypeNullOrEmpty)
                    return true;
                if (this.IsCodonConverterIdentifierNullOrEmpty)
                    return true;
                if (this.IsParentFunctionNullOrEmpty)
                    return true;
                if (this.IsGeneticCodeNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Constructs an instance of this ParameterRow from a specified Row.<para></para><para></para>NO STRONG ROW COLUMNS WILL BE INITIALIZED. This simply creates a wrapper around the Row in order to access the Row Values. It is helpful for performance.
        /// </summary>
        /// <param name="parameterRow">A Parameter to a Function.</param>
        public ParameterRow(Row parameterRow)
            : this()
        {
            this.Row = parameterRow;
        }

        /// <summary>
        /// Constructs an instance of this ParameterRow from a specified global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.ParameterRowSerializableContainer.
        /// </summary>
        /// <param name="parameterRowSerializableContainer">A Parameter to a Function.</param>
        public ParameterRow(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.ParameterRowSerializableContainer parameterRowSerializableContainer)
            : this()
        {
            this.Row = new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable);

            this.PK_ParameterID = parameterRowSerializableContainer.PK_ParameterID;
            this.ParameterType = parameterRowSerializableContainer.ParameterType;
            this.CodonConverterIdentifier = parameterRowSerializableContainer.CodonConverterIdentifier;
            this.ParentFunction = parameterRowSerializableContainer.ParentFunction;
            this.ParameterIndex = parameterRowSerializableContainer.ParameterIndex;
            this.GeneticCode = parameterRowSerializableContainer.GeneticCode;
            if (parameterRowSerializableContainer.ParentFunctionRowSerializableContainer != null)
                this.ParentFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow(parameterRowSerializableContainer.ParentFunctionRowSerializableContainer);
            if (parameterRowSerializableContainer.GeneticCodeRowSerializableContainer != null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow(parameterRowSerializableContainer.GeneticCodeRowSerializableContainer);
        }

        /// <summary>
        /// Constructs an instance of this ParameterRow from a set of values for the Row.
        /// </summary>
        /// <param name="parameterType">The Parameter Type of the Parameter.</param>
        /// <param name="parentFunction">The function to which the Parameter belongs.</param>
        /// <param name="parameterIndex">The index of the Parameter in the parent Function.</param>
        /// <param name="geneticCode">The GeneticCode to which this Function applies.</param>
        /// <param name="codonConverterIdentifier">Only used if the ParameterType is ParameterType.ConvertedCodon. The ICodonConverter as identified by this ICodonConverterIdentifier will be used to convert an ICodon and will then be passed to the IArgument that this IParameter defines.</param>
        /// <param name="parameterTypeRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow that holds the values of the row that the foreign key "ParameterType" is referencing. Row Description: A Parameter to a Function.</param>
        /// <param name="codonConverterIdentifierRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow that holds the values of the row that the foreign key "CodonConverterIdentifier" is referencing. Row Description: A Parameter to a Function.</param>
        /// <param name="parentFunctionRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow that holds the values of the row that the foreign key "ParentFunction" is referencing. Row Description: A Parameter to a Function.</param>
        /// <param name="geneticCodeRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow that holds the values of the row that the foreign key "GeneticCode" is referencing. Row Description: A Parameter to a Function.</param>
        public ParameterRow(StrongEnums.ParameterType parameterType, System.Int32 parentFunction, System.Int32 parameterIndex, System.Int32 geneticCode, StrongEnums.CodonConverterIdentifier codonConverterIdentifier = null, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow parameterTypeRow = null, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow codonConverterIdentifierRow = null, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow parentFunctionRow = null, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow geneticCodeRow = null)
            : this()
        {
            if (this.Row != null)
                this.Row = global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ToRow(parameterType: parameterType, parentFunction: parentFunction, parameterIndex: parameterIndex, geneticCode: geneticCode, codonConverterIdentifier: codonConverterIdentifier);
            this.ParameterTypeRow = parameterTypeRow;
            this.CodonConverterIdentifierRow = codonConverterIdentifierRow;
            this.ParentFunctionRow = parentFunctionRow;
            this.GeneticCodeRow = geneticCodeRow;
        }

        /// <summary>
        /// Constructs an instance of a ParameterRow
        /// </summary>
        public ParameterRow()
            : base(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable)
        {
            this.Values = new ParameterRowValues(this);
        }

        /// <summary>
        /// The TableDefinition of this ParameterRow
        /// </summary>
        public override TableDefinition TableDefinition
        {
            get { return this.GetTableDefinition(); }
        }

        /// <summary>
        /// Gets the TableDefinition of this ParameterRow
        /// </summary>
        public override TableDefinition GetTableDefinition()
        {
            return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable;
        }

        /// <summary>
        /// The TableDefinition of this ParameterRow
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.ParameterTable ParameterTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTable; }
        }

        /// <summary>
        /// Given a table alias (compressed or non-compressed), initializes the proper child StrongRow that has the given alias.
        /// </summary>
        /// <param name="tableAlias">The table alias (compressed or non-compressed) that will indicate which child StrongRow to initialize.</param>
        public override void InitializeChildStrongRowWithAlias(string tableAlias)
        {
            switch (tableAlias)
            {
                case "parameterType":
                    if (this._parameterTypeRow == null)
                    {
                        this._parameterTypeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow();
                        this.InitializeParameterTypeRow();
                    }
                    return;
                case "PT13tma30":
                    if (this._parameterTypeRow == null)
                    {
                        this._parameterTypeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow();
                        this.InitializeParameterTypeRow();
                    }
                    return;
                case "codonConverterIdentifier":
                    if (this._codonConverterIdentifierRow == null)
                    {
                        this._codonConverterIdentifierRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow();
                        this.InitializeCodonConverterIdentifierRow();
                    }
                    return;
                case "CCI24ono31":
                    if (this._codonConverterIdentifierRow == null)
                    {
                        this._codonConverterIdentifierRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow();
                        this.InitializeCodonConverterIdentifierRow();
                    }
                    return;
                case "parentFunction":
                    if (this._parentFunctionRow == null)
                    {
                        this._parentFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
                        this.InitializeParentFunctionRow();
                    }
                    return;
                case "PF14Fna29":
                    if (this._parentFunctionRow == null)
                    {
                        this._parentFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
                        this.InitializeParentFunctionRow();
                    }
                    return;
                case "geneticCode":
                    if (this._geneticCodeRow == null)
                    {
                        this._geneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow();
                        this.InitializeGeneticCodeRow();
                    }
                    return;
                case "GC11cte28":
                    if (this._geneticCodeRow == null)
                    {
                        this._geneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow();
                        this.InitializeGeneticCodeRow();
                    }
                    return;
                default:
                    throw new Exception("The given table alias does not refer to any child StrongRow in this ParameterRow.");
                    return;

            }
        }

        /// <summary>
        /// Initializes all of the Foreign Strong Rows and Foreign Key StrongRows in this ParameterRow that are currently null. Calls the parameterless constructor for each Strong Row that is null.
        /// </summary>
        public override void InitializeChildStrongRows()
        {
            if (this.ParameterTypeRow == null)
                this.ParameterTypeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow();
            if (this.CodonConverterIdentifierRow == null)
                this.CodonConverterIdentifierRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow();
            if (this.ParentFunctionRow == null)
                this.ParentFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
            if (this.GeneticCodeRow == null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow();

        }

        /// <summary>
        /// Initializes all of the StrongRowColumns in this ParameterRow that are currently null. Also handles the necessary event subscriptions.
        /// </summary>
        public override void InitializeStrongRowColumns()
        {
            if (this.PK_ParameterIDColumn == null)
            {
                this.PK_ParameterIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.PK_ParameterID);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.PK_ParameterID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_ParameterID_ValueChanged);
            }
            if (this.ParameterTypeColumn == null)
            {
                this.ParameterTypeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(ParameterType_ValueChanged);
            }
            if (this.CodonConverterIdentifierColumn == null)
            {
                this.CodonConverterIdentifierColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(CodonConverterIdentifier_ValueChanged);
            }
            if (this.ParentFunctionColumn == null)
            {
                this.ParentFunctionColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParentFunction);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParentFunction].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(ParentFunction_ValueChanged);
            }
            if (this.ParameterIndexColumn == null)
            {
                this.ParameterIndexColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterIndex);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterIndex].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(ParameterIndex_ValueChanged);
            }
            if (this.GeneticCodeColumn == null)
            {
                this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.GeneticCode);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
            }
        }

        /// <summary>
        /// Initializes all of the ForeignStrongRowColumns in this ParameterRow that are null.
        /// </summary>
        public override void InitializeForeignStrongRowColumns()
        {
            if (this.ParameterTypeRowColumn == null)
                this.ParameterTypeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.ParameterTypeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType);
            if (this.CodonConverterIdentifierRowColumn == null)
                this.CodonConverterIdentifierRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.CodonConverterIdentifierRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier);
            if (this.ParentFunctionRowColumn == null)
                this.ParentFunctionRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.ParentFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParentFunction);
            if (this.GeneticCodeRowColumn == null)
                this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.GeneticCode);
        }

        /// <summary>
        /// Initializes all of the ForeignKeyToThisStrongRowColumns in this ParameterRow that are null.
        /// </summary>
        public override void InitializeForeignKeyToThisStrongRowColumns()
        {

        }

        /// <summary>
        /// Inserts the Row into the database immediately (if it is not currently in the database. This method first checks to ensure that the Row is not in the database). Returns true if the Row was inserted. Returns false if not. Out's the primary key.
        /// </summary>
        /// <param name="primaryKey">PK_ParameterID int IDENTITY (1,1) PRIMARY KEY,</param>
        public bool InsertOnlyIfNecessary(out System.Int32 primaryKey)
        {
            object primaryKeyObject;
            var result = this.Row.InsertOnlyIfNecessary(out primaryKeyObject);
            primaryKey = primaryKeyObject.ToInt();
            return result;
        }

        /// <summary>
        /// Out's primary key of null if not in database. If the ColumnGroupDefiningUniqueness is null, this returns IsInDatabaseResult.None
        /// </summary>
        /// <param name="primaryKey">PK_ParameterID int IDENTITY (1,1) PRIMARY KEY,</param>
        public IsInDatabaseResult IsAnyInDatabase(out System.Int32? primaryKey)
        {
            object primaryKeyObject;
            var result = this.Row.IsAnyInDatabase(out primaryKeyObject);
            if (primaryKeyObject == null)
                primaryKey = null;
            else
                primaryKey = (System.Int32)primaryKeyObject;
            return result;
        }

        /// <summary>
        /// Inserts this Row into the database immediately and then retrieves the primary key value of the Row.
        /// </summary>
        public System.Int32 InsertIntoDatabase()
        {
            return this.Row.InsertIntoDatabase().ToInt();
        }

        /// <summary>
        /// Asserts that this StrongRow is in the database and gets the primary key. If the row does not exist in the database, throws a DataIntegrityException exception.
        /// </summary>
        /// <param name="senderIdentifierForErrors">Errors will be registered under this Sender Identifier in the Logger.</param>
        /// <param name="referenceNumberForErrors">The reference number that will be catalogued if an error occurs.</param>
        public System.Int32 AssertRowInDatabase(SenderIdentifier senderIdentifierForErrors, string referenceNumberForErrors)
        {
            return this.Row.AssertRowInDatabase(senderIdentifierForErrors, referenceNumberForErrors).ToInt();
        }

        /// <summary>
        /// Indicates whether the Primary Key PK_ParameterID is null or DBNull.Value or is an Empty value.
        /// </summary>
        public override bool IsPrimaryKeyNullOrEmpty
        {
            get { return this.IsPK_ParameterIDNullOrEmpty; }
        }

        /// <summary>
        /// The Primary Key PK_ParameterID for this Parameter.
        /// </summary>
        public System.Int32 PrimaryKey
        {
            get { return this.PK_ParameterID; }
            set { this.PK_ParameterID = value; }
        }

        /// <summary>
        /// The Primary Key Column for this Parameter.
        /// </summary>
        public override StrongRowColumn PrimaryKeyColumn
        {
            get { return this.PK_ParameterIDColumn; }
        }

        /// <summary>
        /// Gets the Primary Key as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PrimaryKeyNullable
        {
            get { return this.IsPrimaryKeyNullOrEmpty ? null as System.Int32? : this.PrimaryKey; }
        }

        /// <summary>
        /// Returns all of the Columns in the ParameterRow whose values have changed according to their HasChanged flags.
        /// </summary>
        public override List<Column> GetColumnsWithChangedValues()
        {
            // If no value in this row has changed then return an empty list.
            if (!this.HasAnyNonRowValueInRowChanged)
                return new List<Column>(0);

            // We will collect the columns whose values have changed.
            var columns = new List<Column>();

            if (HasPK_ParameterIDValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.PK_ParameterID);
            if (HasParameterTypeValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType);
            if (HasCodonConverterIdentifierValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier);
            if (HasParentFunctionValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParentFunction);
            if (HasParameterIndexValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterIndex);
            if (HasGeneticCodeValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.GeneticCode);

            return columns;
        }

        /// <summary>
        /// Calls ResetAllHasAnyValueChangedFlags() for this ParameterRow and ResetAllThisAndChildrenHasAnyValueChangedFlags() for all children Foreign StrongRows and Foreign Key Strong Rows that are not null.
        /// </summary>
        public override void ResetAllThisAndChildrenHasAnyValueChangedFlags()
        {
            this.ResetAllHasAnyValueChangedFlags();

            if (this._parameterTypeRow != null)
                this.ParameterTypeRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._codonConverterIdentifierRow != null)
                this.CodonConverterIdentifierRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._parentFunctionRow != null)
                this.ParentFunctionRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._geneticCodeRow != null)
                this.GeneticCodeRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
        }

        /// <summary>
        /// Resets all of the HasAnyValuesChanged for each of the values in this ParameterRow. Also calls the base.ResetAllHasAnyValueChangedFlags().
        /// </summary>
        public override void ResetAllHasAnyValueChangedFlags()
        {
            base.ResetAllHasAnyValueChangedFlags();

            this.HasPK_ParameterIDValueChanged = false;
            this.HasParameterTypeValueChanged = false;
            this.HasCodonConverterIdentifierValueChanged = false;
            this.HasParentFunctionValueChanged = false;
            this.HasParameterIndexValueChanged = false;
            this.HasGeneticCodeValueChanged = false;
        }

        /// <summary>
        /// Gets all of the StrongRowColumns in this ParameterRow.
        /// </summary>
        public override StrongRowColumn[] GetAllStrongRowColumns()
        {
            return new StrongRowColumn[] { PK_ParameterIDColumn, ParameterTypeColumn, CodonConverterIdentifierColumn, ParentFunctionColumn, ParameterIndexColumn, GeneticCodeColumn };
        }

        /// <summary>
        /// Gets all of the StrongRowForeignKeyColumns in this ParameterRow.
        /// </summary>
        public override StrongRowForeignKeyColumn[] GetAllStrongRowForeignKeyColumns()
        {
            return new StrongRowForeignKeyColumn[] { ParameterTypeRowColumn, CodonConverterIdentifierRowColumn, ParentFunctionRowColumn, GeneticCodeRowColumn };
        }

        /// <summary>
        /// Gets all of the ForeignKeyToThisStrongRowColumn in this ParameterRow.
        /// </summary>
        public override ForeignKeyToThisStrongRowColumn[] GetAllForeignKeyToThisStrongRowColumns()
        {
            return new ForeignKeyToThisStrongRowColumn[] { };
        }

        /// <summary>
        /// Converts the ParameterRow to a ParameterRowSerializableContainer.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.ParameterRowSerializableContainer ToParameterRowSerializableContainer()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.ParameterRowSerializableContainer(this);
        }

        /// <summary>
        /// Converts the StrongRow to the appropriate StrongRowSerializableContainer.
        /// </summary>
        public override StrongRowSerializableContainer ToStrongRowSerializableContainer()
        {
            return this.ToParameterRowSerializableContainer();
        }

        #region IStrongRowDescendant<T>
        /// <summary>
        /// Fills any empty values in this ParameterRow with the corresponding values from the given ParameterRow. Does NOT fill the Primary Key.
        /// </summary>
        /// <param name="sourceOfFilling">The ParameterRow from which we will gather values in order to fill any empty values in this ParameterRow.</param>
        public void FillEmptyValues(ParameterRow sourceOfFilling)
        {
            if (sourceOfFilling == null)
                return;

            if (this.IsParameterTypeNullOrEmpty)
                this.ParameterType = sourceOfFilling.ParameterType;
            if (this.IsCodonConverterIdentifierNullOrEmpty)
                this.CodonConverterIdentifier = sourceOfFilling.CodonConverterIdentifier;
            if (this.IsParentFunctionNullOrEmpty)
                this.ParentFunction = sourceOfFilling.ParentFunction;
            if (this.IsParameterIndexNullOrEmpty)
                this.ParameterIndex = sourceOfFilling.ParameterIndex;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
            if (this.IsParameterTypeNullOrEmpty)
                this.ParameterType = sourceOfFilling.ParameterType;
            if (this.IsCodonConverterIdentifierNullOrEmpty)
                this.CodonConverterIdentifier = sourceOfFilling.CodonConverterIdentifier;
            if (this.IsParentFunctionNullOrEmpty)
                this.ParentFunction = sourceOfFilling.ParentFunction;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
        }

        /// <summary>
        /// This ParameterRow used to fulfill the IStrongRowDescendent<T> contact.
        /// </summary>
        public ParameterRow Self
        {
            get { return this; }
        }

        /// <summary>
        /// Creates a deep copy of the given other ParameterRow. Fills this ParameterRow with the values, Foreign StrongRows and ForeignKey StrongRows of the given other ParameterRow. Fills each child row's children as well.
        /// </summary>
        /// <param name="other">The StrongRow from which values will be populated</param>
        public void PopulateFromRow(ParameterRow other)
        {
            this.PK_ParameterID = other.PK_ParameterID;
            this.ParameterType = other.ParameterType;
            this.CodonConverterIdentifier = other.CodonConverterIdentifier;
            this.ParentFunction = other.ParentFunction;
            this.ParameterIndex = other.ParameterIndex;
            this.GeneticCode = other.GeneticCode;

            if (other._parameterTypeRow != null)
            {
                var parameterType = other.ParameterTypeRow;
                this.ParameterTypeRow.PopulateFromRow(parameterType);
            }
            if (other._codonConverterIdentifierRow != null)
            {
                var codonConverterIdentifier = other.CodonConverterIdentifierRow;
                this.CodonConverterIdentifierRow.PopulateFromRow(codonConverterIdentifier);
            }
            if (other._parentFunctionRow != null)
            {
                var parentFunction = other.ParentFunctionRow;
                this.ParentFunctionRow.PopulateFromRow(parentFunction);
            }
            if (other._geneticCodeRow != null)
            {
                var geneticCode = other.GeneticCodeRow;
                this.GeneticCodeRow.PopulateFromRow(geneticCode);
            }
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Gets the ParameterRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the ParameterRow</param>
        public static ParameterRow GetParameterRowByID(object ID)
        {
            var parameterRow = new ParameterRow();
            Qry.SelectAllFrom(parameterRow).Where(parameterRow.PrimaryKeyColumn, ID).Go().ExtractStrongRow(ref parameterRow);
            return parameterRow;
        }

        /// <summary>
        /// Gets all of the ParameterRows in the database.
        /// </summary>
        public static IEnumerable<ParameterRow> GetAllParameterRows()
        {
            return Qry.SelectAllFrom(new ParameterRow()).Go().ExtractStrongRows<ParameterRow>();
        }
        #endregion

        #region StrongRow Overrides
        /// <summary>
        /// Gets the ParameterRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the ParameterRow</param>
        public override StrongRow GetByID(object ID)
        {
            return ParameterRow.GetParameterRowByID(ID);
        }

        /// <summary>
        /// Gets all of the ParameterRows in the database.
        /// </summary>
        public override IEnumerable<StrongRow> GetAll()
        {
            return ParameterRow.GetAllParameterRows();
        }
        #endregion

        #region IRepository
        /// <summary>
        /// Gets the ParameterRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the ParameterRow</param>
        ParameterRow IRepository<ParameterRow>.GetByID(object ID)
        {
            return ParameterRow.GetParameterRowByID(ID);
        }

        /// <summary>
        /// Gets all of the ParameterRows in the database.
        /// </summary>
        IEnumerable<ParameterRow> IRepository<ParameterRow>.GetAll()
        {
            return ParameterRow.GetAllParameterRows();
        }
        #endregion

        /// <summary>
        /// Validates all of the underlying enum values in this ParameterRow. If there are any errors in the Enum Values, they will be registered with the given SenderIdentifier.
        /// </summary>
        /// <param name="senderIdentifier">The SenderIdentifier used to register Errors in the enum values if any errors exist.</param>
        /// <param name="referenceNumberForErrors">The reference number that will be registered with any Errors.</param>
        public override void ValidateEnumValues(SenderIdentifier senderIdentifier, string referenceNumberForErrors)
        {
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType].Value != null && !StrongEnums.ParameterType.IsValidEnum(this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType].Value.ToString()))
            {
                senderIdentifier.RegisterError(new Error(referenceNumberForErrors, "Invalid Value for ParameterType. Value: " + this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType].Value.ToString() + "."));
            }
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier].Value != null && !StrongEnums.CodonConverterIdentifier.IsValidEnum(this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier].Value.ToString()))
            {
                senderIdentifier.RegisterError(new Error(referenceNumberForErrors, "Invalid Value for CodonConverterIdentifier. Value: " + this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier].Value.ToString() + "."));
            }
        }
    }
}