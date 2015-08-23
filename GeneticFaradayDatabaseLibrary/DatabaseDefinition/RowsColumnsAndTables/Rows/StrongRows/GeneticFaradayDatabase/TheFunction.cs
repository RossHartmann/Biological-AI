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
    /// A Function.
    /// </summary>
    [Serializable]
    public sealed partial class TheFunctionRow : StrongRow, IRepository<TheFunctionRow>, IStrongRowDescendant<TheFunctionRow>
    {
        /// <summary>
        /// This class provides redundant access to the values of the underlying Row in a TheFunctionRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        [Serializable]
        public sealed partial class TheFunctionRowValues
        {
            /// <summary>
            /// PK_FunctionID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PK_FunctionID
            {
                get { return this.Parent.PK_FunctionID; }
                set { this.Parent.PK_FunctionID = value; }
            }

            /// <summary>
            /// The unique FunctionIdentifier of the Function.
            /// </summary>
            public System.String FunctionIdentifier
            {
                get { return this.Parent.FunctionIdentifier; }
                set { this.Parent.FunctionIdentifier = value; }
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
            /// The human-readable name of the Function. Doesn't necessarily uniquely identify this Function.
            /// </summary>
            public System.String Name
            {
                get { return this.Parent.Name; }
                set { this.Parent.Name = value; }
            }

            /// <summary>
            /// The base human-readable name of the Function. this is a more general name for the Function (than this.Name).
            /// </summary>
            public System.String BaseName
            {
                get { return this.Parent.BaseName; }
                set { this.Parent.BaseName = value; }
            }

            /// <summary>
            /// The Weight of the Function in the GeneticCode. The higher the weight, the more Codons that will encode for this Function.
            /// </summary>
            public System.Double WeightInGeneticCode
            {
                get { return this.Parent.WeightInGeneticCode; }
                set { this.Parent.WeightInGeneticCode = value; }
            }

            /// <summary>
            /// The name of the ExecuteMethod delegate that will be used to execute this Function.
            /// </summary>
            public System.String ExecuteMethodName
            {
                get { return this.Parent.ExecuteMethodName; }
                set { this.Parent.ExecuteMethodName = value; }
            }

            /// <summary>
            /// The area of the IFunction such as \"Arithmetic\" or \"
            /// </summary>
            public System.String Area
            {
                get { return this.Parent.Area; }
                set { this.Parent.Area = value; }
            }

            /// <summary>
            /// PK_FunctionID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PrimaryKey
            {
                get { return this.PK_FunctionID; }
                set { this.PK_FunctionID = value; }
            }

            /// <summary>
            /// The parent TheFunctionRow whose values will be viewed and manipulated through this TheFunctionRowValues.
            /// </summary>
            public TheFunctionRow Parent { get; private set; }

            /// <summary>
            /// Constructs a TheFunctionRowValues from a parent TheFunctionRow.
            /// </summary>
            /// <param name="parent">The parent TheFunctionRow whose values will be viewed and manipulated through this TheFunctionRowValues.</param>
            public TheFunctionRowValues(TheFunctionRow parent)
            {
                this.Parent = parent;
            }
        }

        /// <summary>
        /// This property provides redundant access to the values of the underlying Row in this TheFunctionRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow.TheFunctionRowValues Values { get; private set; }

        /// <summary>
        /// The StrongRowColumn where the value of PK_FunctionID is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _pK_FunctionIDColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of PK_FunctionID is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn PK_FunctionIDColumn
        {
            get
            {
                if (this._pK_FunctionIDColumn == null)
                {
                    this.PK_FunctionIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.PK_FunctionID);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.PK_FunctionID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_FunctionID_ValueChanged);
                }

                return this._pK_FunctionIDColumn;
            }
            private set { this._pK_FunctionIDColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of FunctionIdentifier is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _functionIdentifierColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of FunctionIdentifier is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn FunctionIdentifierColumn
        {
            get
            {
                if (this._functionIdentifierColumn == null)
                {
                    this.FunctionIdentifierColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.FunctionIdentifier);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.FunctionIdentifier].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(FunctionIdentifier_ValueChanged);
                }

                return this._functionIdentifierColumn;
            }
            private set { this._functionIdentifierColumn = value; }
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
                    this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.GeneticCode);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
                }

                return this._geneticCodeColumn;
            }
            private set { this._geneticCodeColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of Name is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _nameColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of Name is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn NameColumn
        {
            get
            {
                if (this._nameColumn == null)
                {
                    this.NameColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.Name);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.Name].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Name_ValueChanged);
                }

                return this._nameColumn;
            }
            private set { this._nameColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of BaseName is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _baseNameColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of BaseName is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn BaseNameColumn
        {
            get
            {
                if (this._baseNameColumn == null)
                {
                    this.BaseNameColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.BaseName);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.BaseName].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(BaseName_ValueChanged);
                }

                return this._baseNameColumn;
            }
            private set { this._baseNameColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of WeightInGeneticCode is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _weightInGeneticCodeColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of WeightInGeneticCode is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn WeightInGeneticCodeColumn
        {
            get
            {
                if (this._weightInGeneticCodeColumn == null)
                {
                    this.WeightInGeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.WeightInGeneticCode);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.WeightInGeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(WeightInGeneticCode_ValueChanged);
                }

                return this._weightInGeneticCodeColumn;
            }
            private set { this._weightInGeneticCodeColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of ExecuteMethodName is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _executeMethodNameColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of ExecuteMethodName is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn ExecuteMethodNameColumn
        {
            get
            {
                if (this._executeMethodNameColumn == null)
                {
                    this.ExecuteMethodNameColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.ExecuteMethodName);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.ExecuteMethodName].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(ExecuteMethodName_ValueChanged);
                }

                return this._executeMethodNameColumn;
            }
            private set { this._executeMethodNameColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of Area is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _areaColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of Area is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn AreaColumn
        {
            get
            {
                if (this._areaColumn == null)
                {
                    this.AreaColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.Area);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.Area].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Area_ValueChanged);
                }

                return this._areaColumn;
            }
            private set { this._areaColumn = value; }
        }



        /// <summary>
        /// Raised when the value of PK_FunctionID has changed.<para></para><para></para>This will only fire when the value of the property PK_FunctionID is set. If the corresponding value is set through the underlying row or through the property PK_FunctionIDColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> PK_FunctionIDChanged;

        /// <summary>
        /// When raised, indicates that the value of PK_FunctionID has changed which fires the PK_FunctionIDChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PK_FunctionIDChanged event.</param>
        private void OnPK_FunctionIDChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (PK_FunctionIDChanged != null)
                PK_FunctionIDChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of FunctionIdentifier has changed.<para></para><para></para>This will only fire when the value of the property FunctionIdentifier is set. If the corresponding value is set through the underlying row or through the property FunctionIdentifierColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.String>> FunctionIdentifierChanged;

        /// <summary>
        /// When raised, indicates that the value of FunctionIdentifier has changed which fires the FunctionIdentifierChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the FunctionIdentifierChanged event.</param>
        private void OnFunctionIdentifierChanged(RowValueChangedEventArgs<System.String> e)
        {
            if (FunctionIdentifierChanged != null)
                FunctionIdentifierChanged(this, e);
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
        /// Raised when the value of Name has changed.<para></para><para></para>This will only fire when the value of the property Name is set. If the corresponding value is set through the underlying row or through the property NameColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.String>> NameChanged;

        /// <summary>
        /// When raised, indicates that the value of Name has changed which fires the NameChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the NameChanged event.</param>
        private void OnNameChanged(RowValueChangedEventArgs<System.String> e)
        {
            if (NameChanged != null)
                NameChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of BaseName has changed.<para></para><para></para>This will only fire when the value of the property BaseName is set. If the corresponding value is set through the underlying row or through the property BaseNameColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.String>> BaseNameChanged;

        /// <summary>
        /// When raised, indicates that the value of BaseName has changed which fires the BaseNameChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the BaseNameChanged event.</param>
        private void OnBaseNameChanged(RowValueChangedEventArgs<System.String> e)
        {
            if (BaseNameChanged != null)
                BaseNameChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of WeightInGeneticCode has changed.<para></para><para></para>This will only fire when the value of the property WeightInGeneticCode is set. If the corresponding value is set through the underlying row or through the property WeightInGeneticCodeColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Double>> WeightInGeneticCodeChanged;

        /// <summary>
        /// When raised, indicates that the value of WeightInGeneticCode has changed which fires the WeightInGeneticCodeChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the WeightInGeneticCodeChanged event.</param>
        private void OnWeightInGeneticCodeChanged(RowValueChangedEventArgs<System.Double> e)
        {
            if (WeightInGeneticCodeChanged != null)
                WeightInGeneticCodeChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of ExecuteMethodName has changed.<para></para><para></para>This will only fire when the value of the property ExecuteMethodName is set. If the corresponding value is set through the underlying row or through the property ExecuteMethodNameColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.String>> ExecuteMethodNameChanged;

        /// <summary>
        /// When raised, indicates that the value of ExecuteMethodName has changed which fires the ExecuteMethodNameChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ExecuteMethodNameChanged event.</param>
        private void OnExecuteMethodNameChanged(RowValueChangedEventArgs<System.String> e)
        {
            if (ExecuteMethodNameChanged != null)
                ExecuteMethodNameChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of Area has changed.<para></para><para></para>This will only fire when the value of the property Area is set. If the corresponding value is set through the underlying row or through the property AreaColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.String>> AreaChanged;

        /// <summary>
        /// When raised, indicates that the value of Area has changed which fires the AreaChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the AreaChanged event.</param>
        private void OnAreaChanged(RowValueChangedEventArgs<System.String> e)
        {
            if (AreaChanged != null)
                AreaChanged(this, e);
        }



        /// <summary>
        /// PK_FunctionID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public System.Int32 PK_FunctionID
        {
            get { return this.PK_FunctionIDColumn.Value.ToInt(); }
            set { this.PK_FunctionIDColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnPK_FunctionIDChanged when the value of PK_FunctionID in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PK_FunctionID_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasPK_FunctionIDValueChanged = true;

            // Find the Foreign Key that refers to this Column (if there is any)
            var foreignKeyStrongRows = this.GetForeignKeyColumnsReferringToColumn(PK_FunctionIDColumn);
            if (foreignKeyStrongRows != null)
                foreach (var foreignKeyStrongRow in foreignKeyStrongRows)
                    this.Parent.GetStrongRowColumn(foreignKeyStrongRow.ForeignKeyColumn).Value = e.NewValue;

            OnPK_FunctionIDChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.PK_FunctionIDColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of PK_FunctionID in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.PK_FunctionID) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsPK_FunctionIDNullOrEmpty
        {
            get { return this.PK_FunctionIDColumn.Value.IsNullOrDBNull() || this.PK_FunctionID == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets PK_FunctionID as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PK_FunctionIDNullable
        {
            get { return IsPK_FunctionIDNullOrEmpty ? null as System.Int32? : this.PK_FunctionID; }
        }

        /// <summary>
        /// The unique FunctionIdentifier of the Function.
        /// </summary>
        public System.String FunctionIdentifier
        {
            get
            {
                if (this.FunctionIdentifierColumn.Value != null)
                    return this.FunctionIdentifierColumn.Value.ToString();
                else
                    return null;
            }
            set
            {
                if (value == null)
                    throw new Exception("FunctionIdentifier cannot be null.");

                this.FunctionIdentifierColumn.Value = value;
            }
        }

        /// <summary>
        /// Raises OnFunctionIdentifierChanged when the value of FunctionIdentifier in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void FunctionIdentifier_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasFunctionIdentifierValueChanged = true;

            OnFunctionIdentifierChanged(new RowValueChangedEventArgs<System.String>(e.PreviousValue.IsNullOrDBNull() ? null : e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : e.NewValue.ToString(), this.FunctionIdentifierColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of FunctionIdentifier in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.FunctionIdentifier) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsFunctionIdentifierNullOrEmpty
        {
            get { return this.FunctionIdentifierColumn.Value.IsNullOrDBNull() || this.FunctionIdentifier == String.Empty; }
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
        /// The human-readable name of the Function. Doesn't necessarily uniquely identify this Function.
        /// </summary>
        public System.String Name
        {
            get
            {
                if (this.NameColumn.Value != null)
                    return this.NameColumn.Value.ToString();
                else
                    return null;
            }
            set
            {
                if (value == null)
                    throw new Exception("Name cannot be null.");

                this.NameColumn.Value = value;
            }
        }

        /// <summary>
        /// Raises OnNameChanged when the value of Name in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Name_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasNameValueChanged = true;

            OnNameChanged(new RowValueChangedEventArgs<System.String>(e.PreviousValue.IsNullOrDBNull() ? null : e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : e.NewValue.ToString(), this.NameColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of Name in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.Name) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsNameNullOrEmpty
        {
            get { return this.NameColumn.Value.IsNullOrDBNull() || this.Name == String.Empty; }
        }

        /// <summary>
        /// The base human-readable name of the Function. this is a more general name for the Function (than this.Name).
        /// </summary>
        public System.String BaseName
        {
            get
            {
                if (this.BaseNameColumn.Value != null)
                    return this.BaseNameColumn.Value.ToString();
                else
                    return null;
            }
            set
            {
                if (value == null)
                    throw new Exception("BaseName cannot be null.");

                this.BaseNameColumn.Value = value;
            }
        }

        /// <summary>
        /// Raises OnBaseNameChanged when the value of BaseName in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void BaseName_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasBaseNameValueChanged = true;

            OnBaseNameChanged(new RowValueChangedEventArgs<System.String>(e.PreviousValue.IsNullOrDBNull() ? null : e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : e.NewValue.ToString(), this.BaseNameColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of BaseName in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.BaseName) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsBaseNameNullOrEmpty
        {
            get { return this.BaseNameColumn.Value.IsNullOrDBNull() || this.BaseName == String.Empty; }
        }

        /// <summary>
        /// The Weight of the Function in the GeneticCode. The higher the weight, the more Codons that will encode for this Function.
        /// </summary>
        public System.Double WeightInGeneticCode
        {
            get { return this.WeightInGeneticCodeColumn.Value.ToDouble(); }
            set { this.WeightInGeneticCodeColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnWeightInGeneticCodeChanged when the value of WeightInGeneticCode in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void WeightInGeneticCode_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasWeightInGeneticCodeValueChanged = true;

            OnWeightInGeneticCodeChanged(new RowValueChangedEventArgs<System.Double>(e.PreviousValue.ToDouble(), e.NewValue.ToDouble(), this.WeightInGeneticCodeColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of WeightInGeneticCode in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.WeightInGeneticCode) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsWeightInGeneticCodeNullOrEmpty
        {
            get { return this.WeightInGeneticCodeColumn.Value.IsNullOrDBNull() || this.WeightInGeneticCode == SQLer.EmptyDouble; }
        }

        /// <summary>
        /// Gets WeightInGeneticCode as a nullable System.Double. Has no setter.
        /// </summary>
        public System.Double? WeightInGeneticCodeNullable
        {
            get { return IsWeightInGeneticCodeNullOrEmpty ? null as System.Double? : this.WeightInGeneticCode; }
        }

        /// <summary>
        /// The name of the ExecuteMethod delegate that will be used to execute this Function.
        /// </summary>
        public System.String ExecuteMethodName
        {
            get
            {
                if (this.ExecuteMethodNameColumn.Value != null)
                    return this.ExecuteMethodNameColumn.Value.ToString();
                else
                    return null;
            }
            set
            {
                if (value == null)
                    throw new Exception("ExecuteMethodName cannot be null.");

                this.ExecuteMethodNameColumn.Value = value;
            }
        }

        /// <summary>
        /// Raises OnExecuteMethodNameChanged when the value of ExecuteMethodName in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ExecuteMethodName_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasExecuteMethodNameValueChanged = true;

            OnExecuteMethodNameChanged(new RowValueChangedEventArgs<System.String>(e.PreviousValue.IsNullOrDBNull() ? null : e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : e.NewValue.ToString(), this.ExecuteMethodNameColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of ExecuteMethodName in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.ExecuteMethodName) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsExecuteMethodNameNullOrEmpty
        {
            get { return this.ExecuteMethodNameColumn.Value.IsNullOrDBNull() || this.ExecuteMethodName == String.Empty; }
        }

        /// <summary>
        /// The area of the IFunction such as \"Arithmetic\" or \"
        /// </summary>
        public System.String Area
        {
            get
            {
                if (this.AreaColumn.Value != null)
                    return this.AreaColumn.Value.ToString();
                else
                    return null;
            }
            set
            {
                if (value == null)
                    throw new Exception("Area cannot be null.");

                this.AreaColumn.Value = value;
            }
        }

        /// <summary>
        /// Raises OnAreaChanged when the value of Area in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Area_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasAreaValueChanged = true;

            OnAreaChanged(new RowValueChangedEventArgs<System.String>(e.PreviousValue.IsNullOrDBNull() ? null : e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : e.NewValue.ToString(), this.AreaColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of Area in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.Area) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsAreaNullOrEmpty
        {
            get { return this.AreaColumn.Value.IsNullOrDBNull() || this.Area == String.Empty; }
        }

        /// <summary>
        /// Indicates whether any value in this TheFunctionRow that is not a Row (ForeignStrongRow or ForeignKeyStrongRow) is null or DBNull.Value or Empty. If false, all non-row values have values (i.e. are not null).
        /// </summary>
        public override bool IsAnyNonRowValueNullOrEmpty
        {
            get
            {
                if (this.IsPK_FunctionIDNullOrEmpty)
                    return true;
                if (this.IsFunctionIdentifierNullOrEmpty)
                    return true;
                if (this.IsGeneticCodeNullOrEmpty)
                    return true;
                if (this.IsNameNullOrEmpty)
                    return true;
                if (this.IsBaseNameNullOrEmpty)
                    return true;
                if (this.IsWeightInGeneticCodeNullOrEmpty)
                    return true;
                if (this.IsExecuteMethodNameNullOrEmpty)
                    return true;
                if (this.IsAreaNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Indicates whether the value of PK_FunctionID has changed since either this TheFunctionRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasPK_FunctionIDValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of FunctionIdentifier has changed since either this TheFunctionRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasFunctionIdentifierValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of GeneticCode has changed since either this TheFunctionRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasGeneticCodeValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of Name has changed since either this TheFunctionRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasNameValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of BaseName has changed since either this TheFunctionRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasBaseNameValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of WeightInGeneticCode has changed since either this TheFunctionRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasWeightInGeneticCodeValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of ExecuteMethodName has changed since either this TheFunctionRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasExecuteMethodNameValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of Area has changed since either this TheFunctionRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasAreaValueChanged { get; private set; }

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

                OnGeneticCodeRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.GeneticCode, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.GeneticCode, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this TheFunctionRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this TheFunctionRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// </summary>
        private StrongRowForeignKeyColumn _geneticCodeRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this TheFunctionRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this TheFunctionRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn GeneticCodeRowColumn
        {
            get
            {
                if (this._geneticCodeRowColumn == null)
                    this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.GeneticCode);

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
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.GeneticCode].Value.IsInt() && this.GeneticCode != null)
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
        /// Indicates whether any Foreign StrongRow in this TheFunctionRow is null or DBNull.Value or empty.
        /// </summary>
        public override bool IsAnyForeignRowNull
        {
            get
            {
                if (this.IsGeneticCodeNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow that stores the values of the ForeignKey Strong Row if it were joined to this TheFunctionRow on the Foreign Key Column "ParentFunction". This TheFunctionRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Parameter_ParentFunctionRow ForeignKeyStrongRow.
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow _foreignKeyRow_Parameter_ParentFunctionRow;
        /// <summary>
        /// /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow that stores the values of the ForeignKey Strong Row if it were joined to this TheFunctionRow on the Foreign Key Column "ParentFunction". This TheFunctionRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Parameter_ParentFunctionRow ForeignKeyStrongRow.
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow ForeignKeyRow_Parameter_ParentFunctionRow
        {
            get
            {
                if (this._foreignKeyRow_Parameter_ParentFunctionRow == null)
                {
                    this._foreignKeyRow_Parameter_ParentFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow();
                    this.InitializeForeignKeyRow_Parameter_ParentFunctionRow();
                }

                return _foreignKeyRow_Parameter_ParentFunctionRow;
            }
            set
            {
                var originalValue = this.ForeignKeyRow_Parameter_ParentFunctionRow;
                this._foreignKeyRow_Parameter_ParentFunctionRow = value;


                this.InitializeForeignKeyRow_Parameter_ParentFunctionRow();

                OnForeignKeyRow_Parameter_ParentFunctionRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParentFunction, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParentFunction, this, RowValueType.ForeignKeyStrongRow));
            }
        }

        /// <summary>
        /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "ParentFunction" that belongs to ForeignKey StrongRow "ForeignKeyRow_Parameter_ParentFunctionRow" (which is a different StrongRow than this TheFunctionRow). This ForeignKeyToThisStrongRowColumn that can be used to join this TheFunctionRow to the ForeignKeyStrongRow "ForeignKeyRow_Parameter_ParentFunctionRow.
        /// </summary>
        private ForeignKeyToThisStrongRowColumn _foreignKeyRow_Parameter_ParentFunctionRowColumn;
        /// <summary>
        /// /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "ParentFunction" that belongs to ForeignKey StrongRow "ForeignKeyRow_Parameter_ParentFunctionRow" (which is a different StrongRow than this TheFunctionRow). This ForeignKeyToThisStrongRowColumn that can be used to join this TheFunctionRow to the ForeignKeyStrongRow "ForeignKeyRow_Parameter_ParentFunctionRow.
        /// /// </summary>
        public ForeignKeyToThisStrongRowColumn ForeignKeyRow_Parameter_ParentFunctionRowColumn
        {
            get
            {
                if (this._foreignKeyRow_Parameter_ParentFunctionRowColumn == null)
                    this.ForeignKeyRow_Parameter_ParentFunctionRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_Parameter_ParentFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParentFunction);

                return this._foreignKeyRow_Parameter_ParentFunctionRowColumn;
            }
            private set { this._foreignKeyRow_Parameter_ParentFunctionRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ForeignKeyRow_Parameter_ParentFunctionRow has changed (is NOT raised when a value inside ForeignKeyRow_Parameter_ParentFunctionRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow>> ForeignKeyRow_Parameter_ParentFunctionRowChanged;

        /// <summary>
        /// Indicates that the value of ParentFunction has changed which fires the ParentFunctionChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ForeignKeyRow_Parameter_ParentFunctionRowChanged event.</param>
        private void OnForeignKeyRow_Parameter_ParentFunctionRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow> e)
        {
            if (ForeignKeyRow_Parameter_ParentFunctionRowChanged != null)
                ForeignKeyRow_Parameter_ParentFunctionRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignKeyStrongRow ForeignKeyRow_Parameter_ParentFunctionRow.
        /// </summary>
        private void SubscribeToValueChangesOfForeignKeyRow_Parameter_ParentFunctionRow()
        {
            if (this.ForeignKeyRow_Parameter_ParentFunctionRow != null)
                this.ForeignKeyRow_Parameter_ParentFunctionRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignKeyStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when setting the value of ForeignKeyRow_Parameter_ParentFunctionRow.
        /// </summary>
        private void InitializeForeignKeyRow_Parameter_ParentFunctionRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ForeignKeyRow_Parameter_ParentFunctionRow))
                this.OtherRowTableAliases.Remove(this.ForeignKeyRow_Parameter_ParentFunctionRow);

            this.ForeignKeyRow_Parameter_ParentFunctionRowColumn.ForeignKeyRow = this.ForeignKeyRow_Parameter_ParentFunctionRow;

            this.OtherRowTableAliases.Add(this.ForeignKeyRow_Parameter_ParentFunctionRow, "foreignKey_Parameter_ParentFunction");
            this.ForeignKeyRow_Parameter_ParentFunctionRow.Parent = this;
            SubscribeToValueChangesOfForeignKeyRow_Parameter_ParentFunctionRow();
        }

        /// <summary>
        /// Indicates whether the value of the ForeignKeyRow_Parameter_ParentFunctionRow is null or DBNull.Value (does not Initialize the ForeignKeyRow_Parameter_ParentFunctionRow if it is currently null).
        /// </summary>
        public bool IsForeignKeyRow_Parameter_ParentFunctionRowNull
        {
            get { return this._foreignKeyRow_Parameter_ParentFunctionRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow that stores the values of the ForeignKey Strong Row if it were joined to this TheFunctionRow on the Foreign Key Column "TheFunction". This TheFunctionRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_FunctionRegistry_TheFunctionRow ForeignKeyStrongRow.
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow _foreignKeyRow_FunctionRegistry_TheFunctionRow;
        /// <summary>
        /// /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow that stores the values of the ForeignKey Strong Row if it were joined to this TheFunctionRow on the Foreign Key Column "TheFunction". This TheFunctionRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_FunctionRegistry_TheFunctionRow ForeignKeyStrongRow.
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow ForeignKeyRow_FunctionRegistry_TheFunctionRow
        {
            get
            {
                if (this._foreignKeyRow_FunctionRegistry_TheFunctionRow == null)
                {
                    this._foreignKeyRow_FunctionRegistry_TheFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow();
                    this.InitializeForeignKeyRow_FunctionRegistry_TheFunctionRow();
                }

                return _foreignKeyRow_FunctionRegistry_TheFunctionRow;
            }
            set
            {
                var originalValue = this.ForeignKeyRow_FunctionRegistry_TheFunctionRow;
                this._foreignKeyRow_FunctionRegistry_TheFunctionRow = value;


                this.InitializeForeignKeyRow_FunctionRegistry_TheFunctionRow();

                OnForeignKeyRow_FunctionRegistry_TheFunctionRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.TheFunction, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.TheFunction, this, RowValueType.ForeignKeyStrongRow));
            }
        }

        /// <summary>
        /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "TheFunction" that belongs to ForeignKey StrongRow "ForeignKeyRow_FunctionRegistry_TheFunctionRow" (which is a different StrongRow than this TheFunctionRow). This ForeignKeyToThisStrongRowColumn that can be used to join this TheFunctionRow to the ForeignKeyStrongRow "ForeignKeyRow_FunctionRegistry_TheFunctionRow.
        /// </summary>
        private ForeignKeyToThisStrongRowColumn _foreignKeyRow_FunctionRegistry_TheFunctionRowColumn;
        /// <summary>
        /// /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "TheFunction" that belongs to ForeignKey StrongRow "ForeignKeyRow_FunctionRegistry_TheFunctionRow" (which is a different StrongRow than this TheFunctionRow). This ForeignKeyToThisStrongRowColumn that can be used to join this TheFunctionRow to the ForeignKeyStrongRow "ForeignKeyRow_FunctionRegistry_TheFunctionRow.
        /// /// </summary>
        public ForeignKeyToThisStrongRowColumn ForeignKeyRow_FunctionRegistry_TheFunctionRowColumn
        {
            get
            {
                if (this._foreignKeyRow_FunctionRegistry_TheFunctionRowColumn == null)
                    this.ForeignKeyRow_FunctionRegistry_TheFunctionRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_FunctionRegistry_TheFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.TheFunction);

                return this._foreignKeyRow_FunctionRegistry_TheFunctionRowColumn;
            }
            private set { this._foreignKeyRow_FunctionRegistry_TheFunctionRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ForeignKeyRow_FunctionRegistry_TheFunctionRow has changed (is NOT raised when a value inside ForeignKeyRow_FunctionRegistry_TheFunctionRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow>> ForeignKeyRow_FunctionRegistry_TheFunctionRowChanged;

        /// <summary>
        /// Indicates that the value of TheFunction has changed which fires the TheFunctionChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ForeignKeyRow_FunctionRegistry_TheFunctionRowChanged event.</param>
        private void OnForeignKeyRow_FunctionRegistry_TheFunctionRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow> e)
        {
            if (ForeignKeyRow_FunctionRegistry_TheFunctionRowChanged != null)
                ForeignKeyRow_FunctionRegistry_TheFunctionRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignKeyStrongRow ForeignKeyRow_FunctionRegistry_TheFunctionRow.
        /// </summary>
        private void SubscribeToValueChangesOfForeignKeyRow_FunctionRegistry_TheFunctionRow()
        {
            if (this.ForeignKeyRow_FunctionRegistry_TheFunctionRow != null)
                this.ForeignKeyRow_FunctionRegistry_TheFunctionRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignKeyStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when setting the value of ForeignKeyRow_FunctionRegistry_TheFunctionRow.
        /// </summary>
        private void InitializeForeignKeyRow_FunctionRegistry_TheFunctionRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ForeignKeyRow_FunctionRegistry_TheFunctionRow))
                this.OtherRowTableAliases.Remove(this.ForeignKeyRow_FunctionRegistry_TheFunctionRow);

            this.ForeignKeyRow_FunctionRegistry_TheFunctionRowColumn.ForeignKeyRow = this.ForeignKeyRow_FunctionRegistry_TheFunctionRow;

            this.OtherRowTableAliases.Add(this.ForeignKeyRow_FunctionRegistry_TheFunctionRow, "foreignKey_FunctionRegistry_TheFunction");
            this.ForeignKeyRow_FunctionRegistry_TheFunctionRow.Parent = this;
            SubscribeToValueChangesOfForeignKeyRow_FunctionRegistry_TheFunctionRow();
        }

        /// <summary>
        /// Indicates whether the value of the ForeignKeyRow_FunctionRegistry_TheFunctionRow is null or DBNull.Value (does not Initialize the ForeignKeyRow_FunctionRegistry_TheFunctionRow if it is currently null).
        /// </summary>
        public bool IsForeignKeyRow_FunctionRegistry_TheFunctionRowNull
        {
            get { return this._foreignKeyRow_FunctionRegistry_TheFunctionRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow that stores the values of the ForeignKey Strong Row if it were joined to this TheFunctionRow on the Foreign Key Column "PrimaryFunction". This TheFunctionRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_FunctionPair_PrimaryFunctionRow ForeignKeyStrongRow.
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow _foreignKeyRow_FunctionPair_PrimaryFunctionRow;
        /// <summary>
        /// /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow that stores the values of the ForeignKey Strong Row if it were joined to this TheFunctionRow on the Foreign Key Column "PrimaryFunction". This TheFunctionRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_FunctionPair_PrimaryFunctionRow ForeignKeyStrongRow.
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow ForeignKeyRow_FunctionPair_PrimaryFunctionRow
        {
            get
            {
                if (this._foreignKeyRow_FunctionPair_PrimaryFunctionRow == null)
                {
                    this._foreignKeyRow_FunctionPair_PrimaryFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow();
                    this.InitializeForeignKeyRow_FunctionPair_PrimaryFunctionRow();
                }

                return _foreignKeyRow_FunctionPair_PrimaryFunctionRow;
            }
            set
            {
                var originalValue = this.ForeignKeyRow_FunctionPair_PrimaryFunctionRow;
                this._foreignKeyRow_FunctionPair_PrimaryFunctionRow = value;


                this.InitializeForeignKeyRow_FunctionPair_PrimaryFunctionRow();

                OnForeignKeyRow_FunctionPair_PrimaryFunctionRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunction, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunction, this, RowValueType.ForeignKeyStrongRow));
            }
        }

        /// <summary>
        /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "PrimaryFunction" that belongs to ForeignKey StrongRow "ForeignKeyRow_FunctionPair_PrimaryFunctionRow" (which is a different StrongRow than this TheFunctionRow). This ForeignKeyToThisStrongRowColumn that can be used to join this TheFunctionRow to the ForeignKeyStrongRow "ForeignKeyRow_FunctionPair_PrimaryFunctionRow.
        /// </summary>
        private ForeignKeyToThisStrongRowColumn _foreignKeyRow_FunctionPair_PrimaryFunctionRowColumn;
        /// <summary>
        /// /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "PrimaryFunction" that belongs to ForeignKey StrongRow "ForeignKeyRow_FunctionPair_PrimaryFunctionRow" (which is a different StrongRow than this TheFunctionRow). This ForeignKeyToThisStrongRowColumn that can be used to join this TheFunctionRow to the ForeignKeyStrongRow "ForeignKeyRow_FunctionPair_PrimaryFunctionRow.
        /// /// </summary>
        public ForeignKeyToThisStrongRowColumn ForeignKeyRow_FunctionPair_PrimaryFunctionRowColumn
        {
            get
            {
                if (this._foreignKeyRow_FunctionPair_PrimaryFunctionRowColumn == null)
                    this.ForeignKeyRow_FunctionPair_PrimaryFunctionRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_FunctionPair_PrimaryFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunction);

                return this._foreignKeyRow_FunctionPair_PrimaryFunctionRowColumn;
            }
            private set { this._foreignKeyRow_FunctionPair_PrimaryFunctionRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ForeignKeyRow_FunctionPair_PrimaryFunctionRow has changed (is NOT raised when a value inside ForeignKeyRow_FunctionPair_PrimaryFunctionRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow>> ForeignKeyRow_FunctionPair_PrimaryFunctionRowChanged;

        /// <summary>
        /// Indicates that the value of PrimaryFunction has changed which fires the PrimaryFunctionChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ForeignKeyRow_FunctionPair_PrimaryFunctionRowChanged event.</param>
        private void OnForeignKeyRow_FunctionPair_PrimaryFunctionRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow> e)
        {
            if (ForeignKeyRow_FunctionPair_PrimaryFunctionRowChanged != null)
                ForeignKeyRow_FunctionPair_PrimaryFunctionRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignKeyStrongRow ForeignKeyRow_FunctionPair_PrimaryFunctionRow.
        /// </summary>
        private void SubscribeToValueChangesOfForeignKeyRow_FunctionPair_PrimaryFunctionRow()
        {
            if (this.ForeignKeyRow_FunctionPair_PrimaryFunctionRow != null)
                this.ForeignKeyRow_FunctionPair_PrimaryFunctionRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignKeyStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when setting the value of ForeignKeyRow_FunctionPair_PrimaryFunctionRow.
        /// </summary>
        private void InitializeForeignKeyRow_FunctionPair_PrimaryFunctionRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ForeignKeyRow_FunctionPair_PrimaryFunctionRow))
                this.OtherRowTableAliases.Remove(this.ForeignKeyRow_FunctionPair_PrimaryFunctionRow);

            this.ForeignKeyRow_FunctionPair_PrimaryFunctionRowColumn.ForeignKeyRow = this.ForeignKeyRow_FunctionPair_PrimaryFunctionRow;

            this.OtherRowTableAliases.Add(this.ForeignKeyRow_FunctionPair_PrimaryFunctionRow, "foreignKey_FunctionPair_PrimaryFunction");
            this.ForeignKeyRow_FunctionPair_PrimaryFunctionRow.Parent = this;
            SubscribeToValueChangesOfForeignKeyRow_FunctionPair_PrimaryFunctionRow();
        }

        /// <summary>
        /// Indicates whether the value of the ForeignKeyRow_FunctionPair_PrimaryFunctionRow is null or DBNull.Value (does not Initialize the ForeignKeyRow_FunctionPair_PrimaryFunctionRow if it is currently null).
        /// </summary>
        public bool IsForeignKeyRow_FunctionPair_PrimaryFunctionRowNull
        {
            get { return this._foreignKeyRow_FunctionPair_PrimaryFunctionRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow that stores the values of the ForeignKey Strong Row if it were joined to this TheFunctionRow on the Foreign Key Column "ParameterlessFunction". This TheFunctionRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_FunctionPair_ParameterlessFunctionRow ForeignKeyStrongRow.
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow _foreignKeyRow_FunctionPair_ParameterlessFunctionRow;
        /// <summary>
        /// /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow that stores the values of the ForeignKey Strong Row if it were joined to this TheFunctionRow on the Foreign Key Column "ParameterlessFunction". This TheFunctionRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_FunctionPair_ParameterlessFunctionRow ForeignKeyStrongRow.
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow ForeignKeyRow_FunctionPair_ParameterlessFunctionRow
        {
            get
            {
                if (this._foreignKeyRow_FunctionPair_ParameterlessFunctionRow == null)
                {
                    this._foreignKeyRow_FunctionPair_ParameterlessFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow();
                    this.InitializeForeignKeyRow_FunctionPair_ParameterlessFunctionRow();
                }

                return _foreignKeyRow_FunctionPair_ParameterlessFunctionRow;
            }
            set
            {
                var originalValue = this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow;
                this._foreignKeyRow_FunctionPair_ParameterlessFunctionRow = value;


                this.InitializeForeignKeyRow_FunctionPair_ParameterlessFunctionRow();

                OnForeignKeyRow_FunctionPair_ParameterlessFunctionRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunction, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunction, this, RowValueType.ForeignKeyStrongRow));
            }
        }

        /// <summary>
        /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "ParameterlessFunction" that belongs to ForeignKey StrongRow "ForeignKeyRow_FunctionPair_ParameterlessFunctionRow" (which is a different StrongRow than this TheFunctionRow). This ForeignKeyToThisStrongRowColumn that can be used to join this TheFunctionRow to the ForeignKeyStrongRow "ForeignKeyRow_FunctionPair_ParameterlessFunctionRow.
        /// </summary>
        private ForeignKeyToThisStrongRowColumn _foreignKeyRow_FunctionPair_ParameterlessFunctionRowColumn;
        /// <summary>
        /// /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "ParameterlessFunction" that belongs to ForeignKey StrongRow "ForeignKeyRow_FunctionPair_ParameterlessFunctionRow" (which is a different StrongRow than this TheFunctionRow). This ForeignKeyToThisStrongRowColumn that can be used to join this TheFunctionRow to the ForeignKeyStrongRow "ForeignKeyRow_FunctionPair_ParameterlessFunctionRow.
        /// /// </summary>
        public ForeignKeyToThisStrongRowColumn ForeignKeyRow_FunctionPair_ParameterlessFunctionRowColumn
        {
            get
            {
                if (this._foreignKeyRow_FunctionPair_ParameterlessFunctionRowColumn == null)
                    this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunction);

                return this._foreignKeyRow_FunctionPair_ParameterlessFunctionRowColumn;
            }
            private set { this._foreignKeyRow_FunctionPair_ParameterlessFunctionRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ForeignKeyRow_FunctionPair_ParameterlessFunctionRow has changed (is NOT raised when a value inside ForeignKeyRow_FunctionPair_ParameterlessFunctionRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow>> ForeignKeyRow_FunctionPair_ParameterlessFunctionRowChanged;

        /// <summary>
        /// Indicates that the value of ParameterlessFunction has changed which fires the ParameterlessFunctionChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ForeignKeyRow_FunctionPair_ParameterlessFunctionRowChanged event.</param>
        private void OnForeignKeyRow_FunctionPair_ParameterlessFunctionRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow> e)
        {
            if (ForeignKeyRow_FunctionPair_ParameterlessFunctionRowChanged != null)
                ForeignKeyRow_FunctionPair_ParameterlessFunctionRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignKeyStrongRow ForeignKeyRow_FunctionPair_ParameterlessFunctionRow.
        /// </summary>
        private void SubscribeToValueChangesOfForeignKeyRow_FunctionPair_ParameterlessFunctionRow()
        {
            if (this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow != null)
                this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignKeyStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when setting the value of ForeignKeyRow_FunctionPair_ParameterlessFunctionRow.
        /// </summary>
        private void InitializeForeignKeyRow_FunctionPair_ParameterlessFunctionRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow))
                this.OtherRowTableAliases.Remove(this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow);

            this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRowColumn.ForeignKeyRow = this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow;

            this.OtherRowTableAliases.Add(this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow, "foreignKey_FunctionPair_ParameterlessFunction");
            this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow.Parent = this;
            SubscribeToValueChangesOfForeignKeyRow_FunctionPair_ParameterlessFunctionRow();
        }

        /// <summary>
        /// Indicates whether the value of the ForeignKeyRow_FunctionPair_ParameterlessFunctionRow is null or DBNull.Value (does not Initialize the ForeignKeyRow_FunctionPair_ParameterlessFunctionRow if it is currently null).
        /// </summary>
        public bool IsForeignKeyRow_FunctionPair_ParameterlessFunctionRowNull
        {
            get { return this._foreignKeyRow_FunctionPair_ParameterlessFunctionRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// Constructs an instance of this TheFunctionRow from a specified Row.<para></para><para></para>NO STRONG ROW COLUMNS WILL BE INITIALIZED. This simply creates a wrapper around the Row in order to access the Row Values. It is helpful for performance.
        /// </summary>
        /// <param name="theFunctionRow">A Function.</param>
        public TheFunctionRow(Row theFunctionRow)
            : this()
        {
            this.Row = theFunctionRow;
        }

        /// <summary>
        /// Constructs an instance of this TheFunctionRow from a specified global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.TheFunctionRowSerializableContainer.
        /// </summary>
        /// <param name="theFunctionRowSerializableContainer">A Function.</param>
        public TheFunctionRow(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.TheFunctionRowSerializableContainer theFunctionRowSerializableContainer)
            : this()
        {
            this.Row = new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable);

            this.PK_FunctionID = theFunctionRowSerializableContainer.PK_FunctionID;
            this.FunctionIdentifier = theFunctionRowSerializableContainer.FunctionIdentifier;
            this.GeneticCode = theFunctionRowSerializableContainer.GeneticCode;
            this.Name = theFunctionRowSerializableContainer.Name;
            this.BaseName = theFunctionRowSerializableContainer.BaseName;
            this.WeightInGeneticCode = theFunctionRowSerializableContainer.WeightInGeneticCode;
            this.ExecuteMethodName = theFunctionRowSerializableContainer.ExecuteMethodName;
            this.Area = theFunctionRowSerializableContainer.Area;
            if (theFunctionRowSerializableContainer.GeneticCodeRowSerializableContainer != null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow(theFunctionRowSerializableContainer.GeneticCodeRowSerializableContainer);
            if (theFunctionRowSerializableContainer.ForeignKeyRow_Parameter_ParentFunctionRowSerializableContainer != null)
                this.ForeignKeyRow_Parameter_ParentFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow(theFunctionRowSerializableContainer.ForeignKeyRow_Parameter_ParentFunctionRowSerializableContainer);
            if (theFunctionRowSerializableContainer.ForeignKeyRow_FunctionRegistry_TheFunctionRowSerializableContainer != null)
                this.ForeignKeyRow_FunctionRegistry_TheFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow(theFunctionRowSerializableContainer.ForeignKeyRow_FunctionRegistry_TheFunctionRowSerializableContainer);
            if (theFunctionRowSerializableContainer.ForeignKeyRow_FunctionPair_PrimaryFunctionRowSerializableContainer != null)
                this.ForeignKeyRow_FunctionPair_PrimaryFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow(theFunctionRowSerializableContainer.ForeignKeyRow_FunctionPair_PrimaryFunctionRowSerializableContainer);
            if (theFunctionRowSerializableContainer.ForeignKeyRow_FunctionPair_ParameterlessFunctionRowSerializableContainer != null)
                this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow(theFunctionRowSerializableContainer.ForeignKeyRow_FunctionPair_ParameterlessFunctionRowSerializableContainer);
        }

        /// <summary>
        /// Constructs an instance of this TheFunctionRow from a set of values for the Row.
        /// </summary>
        /// <param name="functionIdentifier">The unique FunctionIdentifier of the Function.</param>
        /// <param name="geneticCode">The GeneticCode to which this Function applies.</param>
        /// <param name="name">The human-readable name of the Function. Doesn't necessarily uniquely identify this Function.</param>
        /// <param name="baseName">The base human-readable name of the Function. this is a more general name for the Function (than this.Name).</param>
        /// <param name="weightInGeneticCode">The Weight of the Function in the GeneticCode. The higher the weight, the more Codons that will encode for this Function.</param>
        /// <param name="executeMethodName">The name of the ExecuteMethod delegate that will be used to execute this Function.</param>
        /// <param name="area">The area of the IFunction such as \"Arithmetic\" or \"</param>
        /// <param name="geneticCodeRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow that holds the values of the row that the foreign key "GeneticCode" is referencing. Row Description: A Function.</param>
        public TheFunctionRow(System.String functionIdentifier, System.Int32 geneticCode, System.String name, System.String baseName, System.Double weightInGeneticCode, System.String executeMethodName, System.String area, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow geneticCodeRow = null)
            : this()
        {
            if (this.Row != null)
                this.Row = global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.ToRow(functionIdentifier: functionIdentifier, geneticCode: geneticCode, name: name, baseName: baseName, weightInGeneticCode: weightInGeneticCode, executeMethodName: executeMethodName, area: area);
            this.GeneticCodeRow = geneticCodeRow;
        }

        /// <summary>
        /// Constructs an instance of a TheFunctionRow
        /// </summary>
        public TheFunctionRow()
            : base(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable)
        {
            this.Values = new TheFunctionRowValues(this);
        }

        /// <summary>
        /// The TableDefinition of this TheFunctionRow
        /// </summary>
        public override TableDefinition TableDefinition
        {
            get { return this.GetTableDefinition(); }
        }

        /// <summary>
        /// Gets the TableDefinition of this TheFunctionRow
        /// </summary>
        public override TableDefinition GetTableDefinition()
        {
            return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable;
        }

        /// <summary>
        /// The TableDefinition of this TheFunctionRow
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.TheFunctionTable TheFunctionTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunctionTable; }
        }

        /// <summary>
        /// Given a table alias (compressed or non-compressed), initializes the proper child StrongRow that has the given alias.
        /// </summary>
        /// <param name="tableAlias">The table alias (compressed or non-compressed) that will indicate which child StrongRow to initialize.</param>
        public override void InitializeChildStrongRowWithAlias(string tableAlias)
        {
            switch (tableAlias)
            {
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
                case "foreignKey_Parameter_ParentFunction":
                    if (this._foreignKeyRow_Parameter_ParentFunctionRow == null)
                    {
                        this._foreignKeyRow_Parameter_ParentFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow();
                        this.InitializeForeignKeyRow_Parameter_ParentFunctionRow();
                    }
                    return;
                case "_PPF35nia60":
                    if (this._foreignKeyRow_Parameter_ParentFunctionRow == null)
                    {
                        this._foreignKeyRow_Parameter_ParentFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow();
                        this.InitializeForeignKeyRow_Parameter_ParentFunctionRow();
                    }
                    return;
                case "foreignKey_FunctionRegistry_TheFunction":
                    if (this._foreignKeyRow_FunctionRegistry_TheFunctionRow == null)
                    {
                        this._foreignKeyRow_FunctionRegistry_TheFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow();
                        this.InitializeForeignKeyRow_FunctionRegistry_TheFunctionRow();
                    }
                    return;
                case "_FRTF39niu60":
                    if (this._foreignKeyRow_FunctionRegistry_TheFunctionRow == null)
                    {
                        this._foreignKeyRow_FunctionRegistry_TheFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow();
                        this.InitializeForeignKeyRow_FunctionRegistry_TheFunctionRow();
                    }
                    return;
                case "foreignKey_FunctionPair_PrimaryFunction":
                    if (this._foreignKeyRow_FunctionPair_PrimaryFunctionRow == null)
                    {
                        this._foreignKeyRow_FunctionPair_PrimaryFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow();
                        this.InitializeForeignKeyRow_FunctionPair_PrimaryFunctionRow();
                    }
                    return;
                case "_FPPF39niu60":
                    if (this._foreignKeyRow_FunctionPair_PrimaryFunctionRow == null)
                    {
                        this._foreignKeyRow_FunctionPair_PrimaryFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow();
                        this.InitializeForeignKeyRow_FunctionPair_PrimaryFunctionRow();
                    }
                    return;
                case "foreignKey_FunctionPair_ParameterlessFunction":
                    if (this._foreignKeyRow_FunctionPair_ParameterlessFunctionRow == null)
                    {
                        this._foreignKeyRow_FunctionPair_ParameterlessFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow();
                        this.InitializeForeignKeyRow_FunctionPair_ParameterlessFunctionRow();
                    }
                    return;
                case "_FPPF45niu62":
                    if (this._foreignKeyRow_FunctionPair_ParameterlessFunctionRow == null)
                    {
                        this._foreignKeyRow_FunctionPair_ParameterlessFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow();
                        this.InitializeForeignKeyRow_FunctionPair_ParameterlessFunctionRow();
                    }
                    return;
                default:
                    throw new Exception("The given table alias does not refer to any child StrongRow in this TheFunctionRow.");
                    return;

            }
        }

        /// <summary>
        /// Initializes all of the Foreign Strong Rows and Foreign Key StrongRows in this TheFunctionRow that are currently null. Calls the parameterless constructor for each Strong Row that is null.
        /// </summary>
        public override void InitializeChildStrongRows()
        {
            if (this.GeneticCodeRow == null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow();

            if (this.ForeignKeyRow_Parameter_ParentFunctionRow == null)
                this.ForeignKeyRow_Parameter_ParentFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow();
            if (this.ForeignKeyRow_FunctionRegistry_TheFunctionRow == null)
                this.ForeignKeyRow_FunctionRegistry_TheFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow();
            if (this.ForeignKeyRow_FunctionPair_PrimaryFunctionRow == null)
                this.ForeignKeyRow_FunctionPair_PrimaryFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow();
            if (this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow == null)
                this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow();
        }

        /// <summary>
        /// Initializes all of the StrongRowColumns in this TheFunctionRow that are currently null. Also handles the necessary event subscriptions.
        /// </summary>
        public override void InitializeStrongRowColumns()
        {
            if (this.PK_FunctionIDColumn == null)
            {
                this.PK_FunctionIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.PK_FunctionID);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.PK_FunctionID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_FunctionID_ValueChanged);
            }
            if (this.FunctionIdentifierColumn == null)
            {
                this.FunctionIdentifierColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.FunctionIdentifier);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.FunctionIdentifier].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(FunctionIdentifier_ValueChanged);
            }
            if (this.GeneticCodeColumn == null)
            {
                this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.GeneticCode);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
            }
            if (this.NameColumn == null)
            {
                this.NameColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.Name);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.Name].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Name_ValueChanged);
            }
            if (this.BaseNameColumn == null)
            {
                this.BaseNameColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.BaseName);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.BaseName].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(BaseName_ValueChanged);
            }
            if (this.WeightInGeneticCodeColumn == null)
            {
                this.WeightInGeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.WeightInGeneticCode);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.WeightInGeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(WeightInGeneticCode_ValueChanged);
            }
            if (this.ExecuteMethodNameColumn == null)
            {
                this.ExecuteMethodNameColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.ExecuteMethodName);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.ExecuteMethodName].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(ExecuteMethodName_ValueChanged);
            }
            if (this.AreaColumn == null)
            {
                this.AreaColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.Area);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.Area].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Area_ValueChanged);
            }
        }

        /// <summary>
        /// Initializes all of the ForeignStrongRowColumns in this TheFunctionRow that are null.
        /// </summary>
        public override void InitializeForeignStrongRowColumns()
        {
            if (this.GeneticCodeRowColumn == null)
                this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.GeneticCode);
        }

        /// <summary>
        /// Initializes all of the ForeignKeyToThisStrongRowColumns in this TheFunctionRow that are null.
        /// </summary>
        public override void InitializeForeignKeyToThisStrongRowColumns()
        {
            if (this.ForeignKeyRow_Parameter_ParentFunctionRowColumn == null)
                this.ForeignKeyRow_Parameter_ParentFunctionRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_Parameter_ParentFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParentFunction);
            if (this.ForeignKeyRow_FunctionRegistry_TheFunctionRowColumn == null)
                this.ForeignKeyRow_FunctionRegistry_TheFunctionRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_FunctionRegistry_TheFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.TheFunction);
            if (this.ForeignKeyRow_FunctionPair_PrimaryFunctionRowColumn == null)
                this.ForeignKeyRow_FunctionPair_PrimaryFunctionRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_FunctionPair_PrimaryFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunction);
            if (this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRowColumn == null)
                this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunction);
        }

        /// <summary>
        /// Inserts the Row into the database immediately (if it is not currently in the database. This method first checks to ensure that the Row is not in the database). Returns true if the Row was inserted. Returns false if not. Out's the primary key.
        /// </summary>
        /// <param name="primaryKey">PK_FunctionID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// <param name="primaryKey">PK_FunctionID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// Indicates whether the Primary Key PK_FunctionID is null or DBNull.Value or is an Empty value.
        /// </summary>
        public override bool IsPrimaryKeyNullOrEmpty
        {
            get { return this.IsPK_FunctionIDNullOrEmpty; }
        }

        /// <summary>
        /// The Primary Key PK_FunctionID for this TheFunction.
        /// </summary>
        public System.Int32 PrimaryKey
        {
            get { return this.PK_FunctionID; }
            set { this.PK_FunctionID = value; }
        }

        /// <summary>
        /// The Primary Key Column for this TheFunction.
        /// </summary>
        public override StrongRowColumn PrimaryKeyColumn
        {
            get { return this.PK_FunctionIDColumn; }
        }

        /// <summary>
        /// Gets the Primary Key as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PrimaryKeyNullable
        {
            get { return this.IsPrimaryKeyNullOrEmpty ? null as System.Int32? : this.PrimaryKey; }
        }

        /// <summary>
        /// Returns all of the Columns in the TheFunctionRow whose values have changed according to their HasChanged flags.
        /// </summary>
        public override List<Column> GetColumnsWithChangedValues()
        {
            // If no value in this row has changed then return an empty list.
            if (!this.HasAnyNonRowValueInRowChanged)
                return new List<Column>(0);

            // We will collect the columns whose values have changed.
            var columns = new List<Column>();

            if (HasPK_FunctionIDValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.PK_FunctionID);
            if (HasFunctionIdentifierValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.FunctionIdentifier);
            if (HasGeneticCodeValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.GeneticCode);
            if (HasNameValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.Name);
            if (HasBaseNameValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.BaseName);
            if (HasWeightInGeneticCodeValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.WeightInGeneticCode);
            if (HasExecuteMethodNameValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.ExecuteMethodName);
            if (HasAreaValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.Area);

            return columns;
        }

        /// <summary>
        /// Calls ResetAllHasAnyValueChangedFlags() for this TheFunctionRow and ResetAllThisAndChildrenHasAnyValueChangedFlags() for all children Foreign StrongRows and Foreign Key Strong Rows that are not null.
        /// </summary>
        public override void ResetAllThisAndChildrenHasAnyValueChangedFlags()
        {
            this.ResetAllHasAnyValueChangedFlags();

            if (this._geneticCodeRow != null)
                this.GeneticCodeRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._foreignKeyRow_Parameter_ParentFunctionRow != null)
                this.ForeignKeyRow_Parameter_ParentFunctionRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._foreignKeyRow_FunctionRegistry_TheFunctionRow != null)
                this.ForeignKeyRow_FunctionRegistry_TheFunctionRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._foreignKeyRow_FunctionPair_PrimaryFunctionRow != null)
                this.ForeignKeyRow_FunctionPair_PrimaryFunctionRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._foreignKeyRow_FunctionPair_ParameterlessFunctionRow != null)
                this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
        }

        /// <summary>
        /// Resets all of the HasAnyValuesChanged for each of the values in this TheFunctionRow. Also calls the base.ResetAllHasAnyValueChangedFlags().
        /// </summary>
        public override void ResetAllHasAnyValueChangedFlags()
        {
            base.ResetAllHasAnyValueChangedFlags();

            this.HasPK_FunctionIDValueChanged = false;
            this.HasFunctionIdentifierValueChanged = false;
            this.HasGeneticCodeValueChanged = false;
            this.HasNameValueChanged = false;
            this.HasBaseNameValueChanged = false;
            this.HasWeightInGeneticCodeValueChanged = false;
            this.HasExecuteMethodNameValueChanged = false;
            this.HasAreaValueChanged = false;
        }

        /// <summary>
        /// Gets all of the StrongRowColumns in this TheFunctionRow.
        /// </summary>
        public override StrongRowColumn[] GetAllStrongRowColumns()
        {
            return new StrongRowColumn[] { PK_FunctionIDColumn, FunctionIdentifierColumn, GeneticCodeColumn, NameColumn, BaseNameColumn, WeightInGeneticCodeColumn, ExecuteMethodNameColumn, AreaColumn };
        }

        /// <summary>
        /// Gets all of the StrongRowForeignKeyColumns in this TheFunctionRow.
        /// </summary>
        public override StrongRowForeignKeyColumn[] GetAllStrongRowForeignKeyColumns()
        {
            return new StrongRowForeignKeyColumn[] { GeneticCodeRowColumn };
        }

        /// <summary>
        /// Gets all of the ForeignKeyToThisStrongRowColumn in this TheFunctionRow.
        /// </summary>
        public override ForeignKeyToThisStrongRowColumn[] GetAllForeignKeyToThisStrongRowColumns()
        {
            return new ForeignKeyToThisStrongRowColumn[] { ForeignKeyRow_Parameter_ParentFunctionRowColumn, ForeignKeyRow_FunctionRegistry_TheFunctionRowColumn, ForeignKeyRow_FunctionPair_PrimaryFunctionRowColumn, ForeignKeyRow_FunctionPair_ParameterlessFunctionRowColumn };
        }

        /// <summary>
        /// Converts the TheFunctionRow to a TheFunctionRowSerializableContainer.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.TheFunctionRowSerializableContainer ToTheFunctionRowSerializableContainer()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.TheFunctionRowSerializableContainer(this);
        }

        /// <summary>
        /// Converts the StrongRow to the appropriate StrongRowSerializableContainer.
        /// </summary>
        public override StrongRowSerializableContainer ToStrongRowSerializableContainer()
        {
            return this.ToTheFunctionRowSerializableContainer();
        }

        #region IStrongRowDescendant<T>
        /// <summary>
        /// Fills any empty values in this TheFunctionRow with the corresponding values from the given TheFunctionRow. Does NOT fill the Primary Key.
        /// </summary>
        /// <param name="sourceOfFilling">The TheFunctionRow from which we will gather values in order to fill any empty values in this TheFunctionRow.</param>
        public void FillEmptyValues(TheFunctionRow sourceOfFilling)
        {
            if (sourceOfFilling == null)
                return;

            if (this.IsFunctionIdentifierNullOrEmpty)
                this.FunctionIdentifier = sourceOfFilling.FunctionIdentifier;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
            if (this.IsNameNullOrEmpty)
                this.Name = sourceOfFilling.Name;
            if (this.IsBaseNameNullOrEmpty)
                this.BaseName = sourceOfFilling.BaseName;
            if (this.IsWeightInGeneticCodeNullOrEmpty)
                this.WeightInGeneticCode = sourceOfFilling.WeightInGeneticCode;
            if (this.IsExecuteMethodNameNullOrEmpty)
                this.ExecuteMethodName = sourceOfFilling.ExecuteMethodName;
            if (this.IsAreaNullOrEmpty)
                this.Area = sourceOfFilling.Area;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
        }

        /// <summary>
        /// This TheFunctionRow used to fulfill the IStrongRowDescendent<T> contact.
        /// </summary>
        public TheFunctionRow Self
        {
            get { return this; }
        }

        /// <summary>
        /// Creates a deep copy of the given other TheFunctionRow. Fills this TheFunctionRow with the values, Foreign StrongRows and ForeignKey StrongRows of the given other TheFunctionRow. Fills each child row's children as well.
        /// </summary>
        /// <param name="other">The StrongRow from which values will be populated</param>
        public void PopulateFromRow(TheFunctionRow other)
        {
            this.PK_FunctionID = other.PK_FunctionID;
            this.FunctionIdentifier = other.FunctionIdentifier;
            this.GeneticCode = other.GeneticCode;
            this.Name = other.Name;
            this.BaseName = other.BaseName;
            this.WeightInGeneticCode = other.WeightInGeneticCode;
            this.ExecuteMethodName = other.ExecuteMethodName;
            this.Area = other.Area;

            if (other._geneticCodeRow != null)
            {
                var geneticCode = other.GeneticCodeRow;
                this.GeneticCodeRow.PopulateFromRow(geneticCode);
            }
            if (other._foreignKeyRow_Parameter_ParentFunctionRow != null)
            {
                var parameter_ParentFunctionRow = other.ForeignKeyRow_Parameter_ParentFunctionRow;
                this.ForeignKeyRow_Parameter_ParentFunctionRow.PopulateFromRow(parameter_ParentFunctionRow);
            }
            if (other._foreignKeyRow_FunctionRegistry_TheFunctionRow != null)
            {
                var functionRegistry_TheFunctionRow = other.ForeignKeyRow_FunctionRegistry_TheFunctionRow;
                this.ForeignKeyRow_FunctionRegistry_TheFunctionRow.PopulateFromRow(functionRegistry_TheFunctionRow);
            }
            if (other._foreignKeyRow_FunctionPair_PrimaryFunctionRow != null)
            {
                var functionPair_PrimaryFunctionRow = other.ForeignKeyRow_FunctionPair_PrimaryFunctionRow;
                this.ForeignKeyRow_FunctionPair_PrimaryFunctionRow.PopulateFromRow(functionPair_PrimaryFunctionRow);
            }
            if (other._foreignKeyRow_FunctionPair_ParameterlessFunctionRow != null)
            {
                var functionPair_ParameterlessFunctionRow = other.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow;
                this.ForeignKeyRow_FunctionPair_ParameterlessFunctionRow.PopulateFromRow(functionPair_ParameterlessFunctionRow);
            }
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Gets the TheFunctionRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the TheFunctionRow</param>
        public static TheFunctionRow GetTheFunctionRowByID(object ID)
        {
            var theFunctionRow = new TheFunctionRow();
            Qry.SelectAllFrom(theFunctionRow).Where(theFunctionRow.PrimaryKeyColumn, ID).Go().ExtractStrongRow(ref theFunctionRow);
            return theFunctionRow;
        }

        /// <summary>
        /// Gets all of the TheFunctionRows in the database.
        /// </summary>
        public static IEnumerable<TheFunctionRow> GetAllTheFunctionRows()
        {
            return Qry.SelectAllFrom(new TheFunctionRow()).Go().ExtractStrongRows<TheFunctionRow>();
        }
        #endregion

        #region StrongRow Overrides
        /// <summary>
        /// Gets the TheFunctionRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the TheFunctionRow</param>
        public override StrongRow GetByID(object ID)
        {
            return TheFunctionRow.GetTheFunctionRowByID(ID);
        }

        /// <summary>
        /// Gets all of the TheFunctionRows in the database.
        /// </summary>
        public override IEnumerable<StrongRow> GetAll()
        {
            return TheFunctionRow.GetAllTheFunctionRows();
        }
        #endregion

        #region IRepository
        /// <summary>
        /// Gets the TheFunctionRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the TheFunctionRow</param>
        TheFunctionRow IRepository<TheFunctionRow>.GetByID(object ID)
        {
            return TheFunctionRow.GetTheFunctionRowByID(ID);
        }

        /// <summary>
        /// Gets all of the TheFunctionRows in the database.
        /// </summary>
        IEnumerable<TheFunctionRow> IRepository<TheFunctionRow>.GetAll()
        {
            return TheFunctionRow.GetAllTheFunctionRows();
        }
        #endregion

        /// <summary>
        /// Validates all of the underlying enum values in this TheFunctionRow. If there are any errors in the Enum Values, they will be registered with the given SenderIdentifier.
        /// </summary>
        /// <param name="senderIdentifier">The SenderIdentifier used to register Errors in the enum values if any errors exist.</param>
        /// <param name="referenceNumberForErrors">The reference number that will be registered with any Errors.</param>
        public override void ValidateEnumValues(SenderIdentifier senderIdentifier, string referenceNumberForErrors)
        {

        }
    }
}