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
    /// A Registry that is available to a Function.
    /// </summary>
    [Serializable]
    public sealed partial class FunctionRegistryRow : StrongRow, IRepository<FunctionRegistryRow>, IStrongRowDescendant<FunctionRegistryRow>
    {
        /// <summary>
        /// This class provides redundant access to the values of the underlying Row in a FunctionRegistryRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        [Serializable]
        public sealed partial class FunctionRegistryRowValues
        {
            /// <summary>
            /// PK_FunctionRegistryID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PK_FunctionRegistryID
            {
                get { return this.Parent.PK_FunctionRegistryID; }
                set { this.Parent.PK_FunctionRegistryID = value; }
            }

            /// <summary>
            /// The Function to which the Registry is available.
            /// </summary>
            public System.Int32 TheFunction
            {
                get { return this.Parent.TheFunction; }
                set { this.Parent.TheFunction = value; }
            }

            /// <summary>
            /// The identifier of the Registry that is available to the Function.
            /// </summary>
            public StrongEnums.RegistryIdentifier Registry
            {
                get { return this.Parent.Registry; }
                set { this.Parent.Registry = value; }
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
            /// PK_FunctionRegistryID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PrimaryKey
            {
                get { return this.PK_FunctionRegistryID; }
                set { this.PK_FunctionRegistryID = value; }
            }

            /// <summary>
            /// The parent FunctionRegistryRow whose values will be viewed and manipulated through this FunctionRegistryRowValues.
            /// </summary>
            public FunctionRegistryRow Parent { get; private set; }

            /// <summary>
            /// Constructs a FunctionRegistryRowValues from a parent FunctionRegistryRow.
            /// </summary>
            /// <param name="parent">The parent FunctionRegistryRow whose values will be viewed and manipulated through this FunctionRegistryRowValues.</param>
            public FunctionRegistryRowValues(FunctionRegistryRow parent)
            {
                this.Parent = parent;
            }
        }

        /// <summary>
        /// This property provides redundant access to the values of the underlying Row in this FunctionRegistryRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow.FunctionRegistryRowValues Values { get; private set; }

        /// <summary>
        /// The StrongRowColumn where the value of PK_FunctionRegistryID is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _pK_FunctionRegistryIDColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of PK_FunctionRegistryID is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn PK_FunctionRegistryIDColumn
        {
            get
            {
                if (this._pK_FunctionRegistryIDColumn == null)
                {
                    this.PK_FunctionRegistryIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.PK_FunctionRegistryID);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.PK_FunctionRegistryID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_FunctionRegistryID_ValueChanged);
                }

                return this._pK_FunctionRegistryIDColumn;
            }
            private set { this._pK_FunctionRegistryIDColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of TheFunction is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _theFunctionColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of TheFunction is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn TheFunctionColumn
        {
            get
            {
                if (this._theFunctionColumn == null)
                {
                    this.TheFunctionColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.TheFunction);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.TheFunction].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(TheFunction_ValueChanged);
                }

                return this._theFunctionColumn;
            }
            private set { this._theFunctionColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of Registry is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _registryColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of Registry is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn RegistryColumn
        {
            get
            {
                if (this._registryColumn == null)
                {
                    this.RegistryColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Registry_ValueChanged);
                }

                return this._registryColumn;
            }
            private set { this._registryColumn = value; }
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
                    this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.GeneticCode);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
                }

                return this._geneticCodeColumn;
            }
            private set { this._geneticCodeColumn = value; }
        }



        /// <summary>
        /// Raised when the value of PK_FunctionRegistryID has changed.<para></para><para></para>This will only fire when the value of the property PK_FunctionRegistryID is set. If the corresponding value is set through the underlying row or through the property PK_FunctionRegistryIDColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> PK_FunctionRegistryIDChanged;

        /// <summary>
        /// When raised, indicates that the value of PK_FunctionRegistryID has changed which fires the PK_FunctionRegistryIDChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PK_FunctionRegistryIDChanged event.</param>
        private void OnPK_FunctionRegistryIDChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (PK_FunctionRegistryIDChanged != null)
                PK_FunctionRegistryIDChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of TheFunction has changed.<para></para><para></para>This will only fire when the value of the property TheFunction is set. If the corresponding value is set through the underlying row or through the property TheFunctionColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> TheFunctionChanged;

        /// <summary>
        /// When raised, indicates that the value of TheFunction has changed which fires the TheFunctionChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the TheFunctionChanged event.</param>
        private void OnTheFunctionChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (TheFunctionChanged != null)
                TheFunctionChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of Registry has changed.<para></para><para></para>This will only fire when the value of the property Registry is set. If the corresponding value is set through the underlying row or through the property RegistryColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<StrongEnums.RegistryIdentifier>> RegistryChanged;

        /// <summary>
        /// When raised, indicates that the value of Registry has changed which fires the RegistryChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the RegistryChanged event.</param>
        private void OnRegistryChanged(RowValueChangedEventArgs<StrongEnums.RegistryIdentifier> e)
        {
            if (RegistryChanged != null)
                RegistryChanged(this, e);
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
        /// PK_FunctionRegistryID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public System.Int32 PK_FunctionRegistryID
        {
            get { return this.PK_FunctionRegistryIDColumn.Value.ToInt(); }
            set { this.PK_FunctionRegistryIDColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnPK_FunctionRegistryIDChanged when the value of PK_FunctionRegistryID in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PK_FunctionRegistryID_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasPK_FunctionRegistryIDValueChanged = true;

            // Find the Foreign Key that refers to this Column (if there is any)
            var foreignKeyStrongRows = this.GetForeignKeyColumnsReferringToColumn(PK_FunctionRegistryIDColumn);
            if (foreignKeyStrongRows != null)
                foreach (var foreignKeyStrongRow in foreignKeyStrongRows)
                    this.Parent.GetStrongRowColumn(foreignKeyStrongRow.ForeignKeyColumn).Value = e.NewValue;

            OnPK_FunctionRegistryIDChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.PK_FunctionRegistryIDColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of PK_FunctionRegistryID in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.PK_FunctionRegistryID) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsPK_FunctionRegistryIDNullOrEmpty
        {
            get { return this.PK_FunctionRegistryIDColumn.Value.IsNullOrDBNull() || this.PK_FunctionRegistryID == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets PK_FunctionRegistryID as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PK_FunctionRegistryIDNullable
        {
            get { return IsPK_FunctionRegistryIDNullOrEmpty ? null as System.Int32? : this.PK_FunctionRegistryID; }
        }

        /// <summary>
        /// The Function to which the Registry is available.
        /// </summary>
        public System.Int32 TheFunction
        {
            get { return this.TheFunctionColumn.Value.ToInt(); }
            set { this.TheFunctionColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnTheFunctionChanged when the value of TheFunction in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void TheFunction_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasTheFunctionValueChanged = true;

            // Only update the primary key of the Foreign Row if we need to (so that we don't circularly update the primary keys).
            if (this._theFunctionRow != null)
                if (this.TheFunctionRow.PrimaryKey != this.TheFunction)
                    this.TheFunctionRow.PrimaryKey = this.TheFunction;

            OnTheFunctionChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.TheFunctionColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of TheFunction in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.TheFunction) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsTheFunctionNullOrEmpty
        {
            get { return this.TheFunctionColumn.Value.IsNullOrDBNull() || this.TheFunction == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets TheFunction as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? TheFunctionNullable
        {
            get { return IsTheFunctionNullOrEmpty ? null as System.Int32? : this.TheFunction; }
        }

        /// <summary>
        /// The identifier of the Registry that is available to the Function.
        /// </summary>
        public StrongEnums.RegistryIdentifier Registry
        {
            get
            {
                if (this.RegistryColumn.Value != null)
                    return (StrongEnums.RegistryIdentifier)this.RegistryColumn.Value.ToString();
                else
                    return null;
            }
            set
            {
                if (value == null)
                    throw new Exception("Registry cannot be null.");

                this.RegistryColumn.Value = value;
            }
        }

        /// <summary>
        /// Raises OnRegistryChanged when the value of Registry in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Registry_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasRegistryValueChanged = true;

            // Only update the primary key of the Foreign Row if we need to (so that we don't circularly update the primary keys).
            if (this._registryRow != null && this.Registry != null)
                if (this.RegistryRow.PrimaryKey != this.Registry)
                    this.RegistryRow.PrimaryKey = e.NewValue.ToString();

            OnRegistryChanged(new RowValueChangedEventArgs<StrongEnums.RegistryIdentifier>(e.PreviousValue.IsNullOrDBNull() ? null : (StrongEnums.RegistryIdentifier)e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : (StrongEnums.RegistryIdentifier)e.NewValue.ToString(), this.RegistryColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of Registry in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.Registry) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsRegistryNullOrEmpty
        {
            get { return this.RegistryColumn.Value.IsNullOrDBNull() || this.Registry == String.Empty; }
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
        /// Indicates whether any value in this FunctionRegistryRow that is not a Row (ForeignStrongRow or ForeignKeyStrongRow) is null or DBNull.Value or Empty. If false, all non-row values have values (i.e. are not null).
        /// </summary>
        public override bool IsAnyNonRowValueNullOrEmpty
        {
            get
            {
                if (this.IsPK_FunctionRegistryIDNullOrEmpty)
                    return true;
                if (this.IsTheFunctionNullOrEmpty)
                    return true;
                if (this.IsRegistryNullOrEmpty)
                    return true;
                if (this.IsGeneticCodeNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Indicates whether the value of PK_FunctionRegistryID has changed since either this FunctionRegistryRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasPK_FunctionRegistryIDValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of TheFunction has changed since either this FunctionRegistryRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasTheFunctionValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of Registry has changed since either this FunctionRegistryRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasRegistryValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of GeneticCode has changed since either this FunctionRegistryRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasGeneticCodeValueChanged { get; private set; }

        /// <summary>
        /// An instance of the TheFunctionRow that stores the values that are referenced by the foreign key column "TheFunction".
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow _theFunctionRow;
        /// <summary>
        /// /// An instance of the TheFunctionRow that stores the values that are referenced by the foreign key column "TheFunction".
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow TheFunctionRow
        {
            get
            {
                if (this._theFunctionRow == null)
                {
                    this._theFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
                    this.InitializeTheFunctionRow();
                }

                return _theFunctionRow;
            }
            set
            {
                var originalValue = this.TheFunctionRow;
                this._theFunctionRow = value;


                this.InitializeTheFunctionRow();

                OnTheFunctionRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.TheFunction, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.TheFunction, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this FunctionRegistryRow to the foreign TheFunctionRow. This contains the ForeignKeyColumn of this FunctionRegistryRow and the referenced ForeignColumn that will be used to join the TheFunctionRow.
        /// </summary>
        private StrongRowForeignKeyColumn _theFunctionRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this FunctionRegistryRow to the foreign TheFunctionRow. This contains the ForeignKeyColumn of this FunctionRegistryRow and the referenced ForeignColumn that will be used to join the TheFunctionRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn TheFunctionRowColumn
        {
            get
            {
                if (this._theFunctionRowColumn == null)
                    this.TheFunctionRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.TheFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.TheFunction);

                return this._theFunctionRowColumn;
            }
            private set { this._theFunctionRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of TheFunctionRow has changed (is NOT raised when a value inside TheFunctionRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow>> TheFunctionRowChanged;

        /// <summary>
        /// Indicates that the value of TheFunction has changed which fires the TheFunctionChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the TheFunctionRowChanged event.</param>
        private void OnTheFunctionRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow> e)
        {
            if (TheFunctionRowChanged != null)
                TheFunctionRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignStrongRow TheFunctionRow.
        /// </summary>
        private void SubscribeToValueChangesOfTheFunctionRow()
        {
            if (this.TheFunctionRow != null)
                this.TheFunctionRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when initializing the value of TheFunctionRow.
        /// </summary>
        private void InitializeTheFunctionRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.TheFunctionRow))
                this.OtherRowTableAliases.Remove(this.TheFunctionRow);

            this.TheFunctionRowColumn.ForeignRow = this.TheFunctionRow;

            this.OtherRowTableAliases.Add(this.TheFunctionRow, "theFunction");
            this.TheFunctionRow.Parent = this;
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.TheFunction].Value.IsInt() && this.TheFunction != null)
                this.TheFunctionRow.PrimaryKey = this.TheFunction;
            SubscribeToValueChangesOfTheFunctionRow();
        }

        /// <summary>
        /// Indicates whether the value of the TheFunctionRow is null or DBNull.Value (does not Initialize the TheFunctionRow if it is currently null).
        /// </summary>
        public bool IsTheFunctionRowNull
        {
            get { return this._theFunctionRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// An instance of the RegistryRow that stores the values that are referenced by the foreign key column "Registry".
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow _registryRow;
        /// <summary>
        /// /// An instance of the RegistryRow that stores the values that are referenced by the foreign key column "Registry".
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow RegistryRow
        {
            get
            {
                if (this._registryRow == null)
                {
                    this._registryRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow();
                    this.InitializeRegistryRow();
                }

                return _registryRow;
            }
            set
            {
                var originalValue = this.RegistryRow;
                this._registryRow = value;


                this.InitializeRegistryRow();

                OnRegistryRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this FunctionRegistryRow to the foreign RegistryRow. This contains the ForeignKeyColumn of this FunctionRegistryRow and the referenced ForeignColumn that will be used to join the RegistryRow.
        /// </summary>
        private StrongRowForeignKeyColumn _registryRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this FunctionRegistryRow to the foreign RegistryRow. This contains the ForeignKeyColumn of this FunctionRegistryRow and the referenced ForeignColumn that will be used to join the RegistryRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn RegistryRowColumn
        {
            get
            {
                if (this._registryRowColumn == null)
                    this.RegistryRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.RegistryRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry);

                return this._registryRowColumn;
            }
            private set { this._registryRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of RegistryRow has changed (is NOT raised when a value inside RegistryRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow>> RegistryRowChanged;

        /// <summary>
        /// Indicates that the value of Registry has changed which fires the RegistryChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the RegistryRowChanged event.</param>
        private void OnRegistryRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow> e)
        {
            if (RegistryRowChanged != null)
                RegistryRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignStrongRow RegistryRow.
        /// </summary>
        private void SubscribeToValueChangesOfRegistryRow()
        {
            if (this.RegistryRow != null)
                this.RegistryRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when initializing the value of RegistryRow.
        /// </summary>
        private void InitializeRegistryRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.RegistryRow))
                this.OtherRowTableAliases.Remove(this.RegistryRow);

            this.RegistryRowColumn.ForeignRow = this.RegistryRow;

            this.OtherRowTableAliases.Add(this.RegistryRow, "registry");
            this.RegistryRow.Parent = this;
            if (this.Registry != null)
                this.RegistryRow.PrimaryKey = this.Registry;
            SubscribeToValueChangesOfRegistryRow();
        }

        /// <summary>
        /// Indicates whether the value of the RegistryRow is null or DBNull.Value (does not Initialize the RegistryRow if it is currently null).
        /// </summary>
        public bool IsRegistryRowNull
        {
            get { return this._registryRow.IsNullOrDBNull(); }
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

                OnGeneticCodeRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.GeneticCode, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.GeneticCode, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this FunctionRegistryRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this FunctionRegistryRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// </summary>
        private StrongRowForeignKeyColumn _geneticCodeRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this FunctionRegistryRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this FunctionRegistryRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn GeneticCodeRowColumn
        {
            get
            {
                if (this._geneticCodeRowColumn == null)
                    this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.GeneticCode);

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
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.GeneticCode].Value.IsInt() && this.GeneticCode != null)
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
        /// Indicates whether any Foreign StrongRow in this FunctionRegistryRow is null or DBNull.Value or empty.
        /// </summary>
        public override bool IsAnyForeignRowNull
        {
            get
            {
                if (this.IsTheFunctionNullOrEmpty)
                    return true;
                if (this.IsRegistryNullOrEmpty)
                    return true;
                if (this.IsGeneticCodeNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Constructs an instance of this FunctionRegistryRow from a specified Row.<para></para><para></para>NO STRONG ROW COLUMNS WILL BE INITIALIZED. This simply creates a wrapper around the Row in order to access the Row Values. It is helpful for performance.
        /// </summary>
        /// <param name="functionRegistryRow">A Registry that is available to a Function.</param>
        public FunctionRegistryRow(Row functionRegistryRow)
            : this()
        {
            this.Row = functionRegistryRow;
        }

        /// <summary>
        /// Constructs an instance of this FunctionRegistryRow from a specified global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionRegistryRowSerializableContainer.
        /// </summary>
        /// <param name="functionRegistryRowSerializableContainer">A Registry that is available to a Function.</param>
        public FunctionRegistryRow(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionRegistryRowSerializableContainer functionRegistryRowSerializableContainer)
            : this()
        {
            this.Row = new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistryTable);

            this.PK_FunctionRegistryID = functionRegistryRowSerializableContainer.PK_FunctionRegistryID;
            this.TheFunction = functionRegistryRowSerializableContainer.TheFunction;
            this.Registry = functionRegistryRowSerializableContainer.Registry;
            this.GeneticCode = functionRegistryRowSerializableContainer.GeneticCode;
            if (functionRegistryRowSerializableContainer.TheFunctionRowSerializableContainer != null)
                this.TheFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow(functionRegistryRowSerializableContainer.TheFunctionRowSerializableContainer);
            if (functionRegistryRowSerializableContainer.GeneticCodeRowSerializableContainer != null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow(functionRegistryRowSerializableContainer.GeneticCodeRowSerializableContainer);
        }

        /// <summary>
        /// Constructs an instance of this FunctionRegistryRow from a set of values for the Row.
        /// </summary>
        /// <param name="theFunction">The Function to which the Registry is available.</param>
        /// <param name="registry">The identifier of the Registry that is available to the Function.</param>
        /// <param name="geneticCode">The GeneticCode to which this Function applies.</param>
        /// <param name="theFunctionRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow that holds the values of the row that the foreign key "TheFunction" is referencing. Row Description: A Registry that is available to a Function.</param>
        /// <param name="registryRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow that holds the values of the row that the foreign key "Registry" is referencing. Row Description: A Registry that is available to a Function.</param>
        /// <param name="geneticCodeRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow that holds the values of the row that the foreign key "GeneticCode" is referencing. Row Description: A Registry that is available to a Function.</param>
        public FunctionRegistryRow(System.Int32 theFunction, StrongEnums.RegistryIdentifier registry, System.Int32 geneticCode, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow theFunctionRow = null, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow registryRow = null, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow geneticCodeRow = null)
            : this()
        {
            if (this.Row != null)
                this.Row = global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.ToRow(theFunction: theFunction, registry: registry, geneticCode: geneticCode);
            this.TheFunctionRow = theFunctionRow;
            this.RegistryRow = registryRow;
            this.GeneticCodeRow = geneticCodeRow;
        }

        /// <summary>
        /// Constructs an instance of a FunctionRegistryRow
        /// </summary>
        public FunctionRegistryRow()
            : base(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistryTable)
        {
            this.Values = new FunctionRegistryRowValues(this);
        }

        /// <summary>
        /// The TableDefinition of this FunctionRegistryRow
        /// </summary>
        public override TableDefinition TableDefinition
        {
            get { return this.GetTableDefinition(); }
        }

        /// <summary>
        /// Gets the TableDefinition of this FunctionRegistryRow
        /// </summary>
        public override TableDefinition GetTableDefinition()
        {
            return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistryTable;
        }

        /// <summary>
        /// The TableDefinition of this FunctionRegistryRow
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.FunctionRegistryTable FunctionRegistryTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistryTable; }
        }

        /// <summary>
        /// Given a table alias (compressed or non-compressed), initializes the proper child StrongRow that has the given alias.
        /// </summary>
        /// <param name="tableAlias">The table alias (compressed or non-compressed) that will indicate which child StrongRow to initialize.</param>
        public override void InitializeChildStrongRowWithAlias(string tableAlias)
        {
            switch (tableAlias)
            {
                case "theFunction":
                    if (this._theFunctionRow == null)
                    {
                        this._theFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
                        this.InitializeTheFunctionRow();
                    }
                    return;
                case "TF11cuh28":
                    if (this._theFunctionRow == null)
                    {
                        this._theFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
                        this.InitializeTheFunctionRow();
                    }
                    return;
                case "registry":
                    if (this._registryRow == null)
                    {
                        this._registryRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow();
                        this.InitializeRegistryRow();
                    }
                    return;
                case "re8rse31":
                    if (this._registryRow == null)
                    {
                        this._registryRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow();
                        this.InitializeRegistryRow();
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
                    throw new Exception("The given table alias does not refer to any child StrongRow in this FunctionRegistryRow.");
                    return;

            }
        }

        /// <summary>
        /// Initializes all of the Foreign Strong Rows and Foreign Key StrongRows in this FunctionRegistryRow that are currently null. Calls the parameterless constructor for each Strong Row that is null.
        /// </summary>
        public override void InitializeChildStrongRows()
        {
            if (this.TheFunctionRow == null)
                this.TheFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
            if (this.RegistryRow == null)
                this.RegistryRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow();
            if (this.GeneticCodeRow == null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow();

        }

        /// <summary>
        /// Initializes all of the StrongRowColumns in this FunctionRegistryRow that are currently null. Also handles the necessary event subscriptions.
        /// </summary>
        public override void InitializeStrongRowColumns()
        {
            if (this.PK_FunctionRegistryIDColumn == null)
            {
                this.PK_FunctionRegistryIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.PK_FunctionRegistryID);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.PK_FunctionRegistryID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_FunctionRegistryID_ValueChanged);
            }
            if (this.TheFunctionColumn == null)
            {
                this.TheFunctionColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.TheFunction);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.TheFunction].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(TheFunction_ValueChanged);
            }
            if (this.RegistryColumn == null)
            {
                this.RegistryColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Registry_ValueChanged);
            }
            if (this.GeneticCodeColumn == null)
            {
                this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.GeneticCode);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
            }
        }

        /// <summary>
        /// Initializes all of the ForeignStrongRowColumns in this FunctionRegistryRow that are null.
        /// </summary>
        public override void InitializeForeignStrongRowColumns()
        {
            if (this.TheFunctionRowColumn == null)
                this.TheFunctionRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.TheFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.TheFunction);
            if (this.RegistryRowColumn == null)
                this.RegistryRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.RegistryRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry);
            if (this.GeneticCodeRowColumn == null)
                this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.GeneticCode);
        }

        /// <summary>
        /// Initializes all of the ForeignKeyToThisStrongRowColumns in this FunctionRegistryRow that are null.
        /// </summary>
        public override void InitializeForeignKeyToThisStrongRowColumns()
        {

        }

        /// <summary>
        /// Inserts the Row into the database immediately (if it is not currently in the database. This method first checks to ensure that the Row is not in the database). Returns true if the Row was inserted. Returns false if not. Out's the primary key.
        /// </summary>
        /// <param name="primaryKey">PK_FunctionRegistryID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// <param name="primaryKey">PK_FunctionRegistryID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// Indicates whether the Primary Key PK_FunctionRegistryID is null or DBNull.Value or is an Empty value.
        /// </summary>
        public override bool IsPrimaryKeyNullOrEmpty
        {
            get { return this.IsPK_FunctionRegistryIDNullOrEmpty; }
        }

        /// <summary>
        /// The Primary Key PK_FunctionRegistryID for this FunctionRegistry.
        /// </summary>
        public System.Int32 PrimaryKey
        {
            get { return this.PK_FunctionRegistryID; }
            set { this.PK_FunctionRegistryID = value; }
        }

        /// <summary>
        /// The Primary Key Column for this FunctionRegistry.
        /// </summary>
        public override StrongRowColumn PrimaryKeyColumn
        {
            get { return this.PK_FunctionRegistryIDColumn; }
        }

        /// <summary>
        /// Gets the Primary Key as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PrimaryKeyNullable
        {
            get { return this.IsPrimaryKeyNullOrEmpty ? null as System.Int32? : this.PrimaryKey; }
        }

        /// <summary>
        /// Returns all of the Columns in the FunctionRegistryRow whose values have changed according to their HasChanged flags.
        /// </summary>
        public override List<Column> GetColumnsWithChangedValues()
        {
            // If no value in this row has changed then return an empty list.
            if (!this.HasAnyNonRowValueInRowChanged)
                return new List<Column>(0);

            // We will collect the columns whose values have changed.
            var columns = new List<Column>();

            if (HasPK_FunctionRegistryIDValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.PK_FunctionRegistryID);
            if (HasTheFunctionValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.TheFunction);
            if (HasRegistryValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry);
            if (HasGeneticCodeValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.GeneticCode);

            return columns;
        }

        /// <summary>
        /// Calls ResetAllHasAnyValueChangedFlags() for this FunctionRegistryRow and ResetAllThisAndChildrenHasAnyValueChangedFlags() for all children Foreign StrongRows and Foreign Key Strong Rows that are not null.
        /// </summary>
        public override void ResetAllThisAndChildrenHasAnyValueChangedFlags()
        {
            this.ResetAllHasAnyValueChangedFlags();

            if (this._theFunctionRow != null)
                this.TheFunctionRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._registryRow != null)
                this.RegistryRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._geneticCodeRow != null)
                this.GeneticCodeRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
        }

        /// <summary>
        /// Resets all of the HasAnyValuesChanged for each of the values in this FunctionRegistryRow. Also calls the base.ResetAllHasAnyValueChangedFlags().
        /// </summary>
        public override void ResetAllHasAnyValueChangedFlags()
        {
            base.ResetAllHasAnyValueChangedFlags();

            this.HasPK_FunctionRegistryIDValueChanged = false;
            this.HasTheFunctionValueChanged = false;
            this.HasRegistryValueChanged = false;
            this.HasGeneticCodeValueChanged = false;
        }

        /// <summary>
        /// Gets all of the StrongRowColumns in this FunctionRegistryRow.
        /// </summary>
        public override StrongRowColumn[] GetAllStrongRowColumns()
        {
            return new StrongRowColumn[] { PK_FunctionRegistryIDColumn, TheFunctionColumn, RegistryColumn, GeneticCodeColumn };
        }

        /// <summary>
        /// Gets all of the StrongRowForeignKeyColumns in this FunctionRegistryRow.
        /// </summary>
        public override StrongRowForeignKeyColumn[] GetAllStrongRowForeignKeyColumns()
        {
            return new StrongRowForeignKeyColumn[] { TheFunctionRowColumn, RegistryRowColumn, GeneticCodeRowColumn };
        }

        /// <summary>
        /// Gets all of the ForeignKeyToThisStrongRowColumn in this FunctionRegistryRow.
        /// </summary>
        public override ForeignKeyToThisStrongRowColumn[] GetAllForeignKeyToThisStrongRowColumns()
        {
            return new ForeignKeyToThisStrongRowColumn[] { };
        }

        /// <summary>
        /// Converts the FunctionRegistryRow to a FunctionRegistryRowSerializableContainer.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionRegistryRowSerializableContainer ToFunctionRegistryRowSerializableContainer()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionRegistryRowSerializableContainer(this);
        }

        /// <summary>
        /// Converts the StrongRow to the appropriate StrongRowSerializableContainer.
        /// </summary>
        public override StrongRowSerializableContainer ToStrongRowSerializableContainer()
        {
            return this.ToFunctionRegistryRowSerializableContainer();
        }

        #region IStrongRowDescendant<T>
        /// <summary>
        /// Fills any empty values in this FunctionRegistryRow with the corresponding values from the given FunctionRegistryRow. Does NOT fill the Primary Key.
        /// </summary>
        /// <param name="sourceOfFilling">The FunctionRegistryRow from which we will gather values in order to fill any empty values in this FunctionRegistryRow.</param>
        public void FillEmptyValues(FunctionRegistryRow sourceOfFilling)
        {
            if (sourceOfFilling == null)
                return;

            if (this.IsTheFunctionNullOrEmpty)
                this.TheFunction = sourceOfFilling.TheFunction;
            if (this.IsRegistryNullOrEmpty)
                this.Registry = sourceOfFilling.Registry;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
            if (this.IsTheFunctionNullOrEmpty)
                this.TheFunction = sourceOfFilling.TheFunction;
            if (this.IsRegistryNullOrEmpty)
                this.Registry = sourceOfFilling.Registry;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
        }

        /// <summary>
        /// This FunctionRegistryRow used to fulfill the IStrongRowDescendent<T> contact.
        /// </summary>
        public FunctionRegistryRow Self
        {
            get { return this; }
        }

        /// <summary>
        /// Creates a deep copy of the given other FunctionRegistryRow. Fills this FunctionRegistryRow with the values, Foreign StrongRows and ForeignKey StrongRows of the given other FunctionRegistryRow. Fills each child row's children as well.
        /// </summary>
        /// <param name="other">The StrongRow from which values will be populated</param>
        public void PopulateFromRow(FunctionRegistryRow other)
        {
            this.PK_FunctionRegistryID = other.PK_FunctionRegistryID;
            this.TheFunction = other.TheFunction;
            this.Registry = other.Registry;
            this.GeneticCode = other.GeneticCode;

            if (other._theFunctionRow != null)
            {
                var theFunction = other.TheFunctionRow;
                this.TheFunctionRow.PopulateFromRow(theFunction);
            }
            if (other._registryRow != null)
            {
                var registry = other.RegistryRow;
                this.RegistryRow.PopulateFromRow(registry);
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
        /// Gets the FunctionRegistryRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the FunctionRegistryRow</param>
        public static FunctionRegistryRow GetFunctionRegistryRowByID(object ID)
        {
            var functionRegistryRow = new FunctionRegistryRow();
            Qry.SelectAllFrom(functionRegistryRow).Where(functionRegistryRow.PrimaryKeyColumn, ID).Go().ExtractStrongRow(ref functionRegistryRow);
            return functionRegistryRow;
        }

        /// <summary>
        /// Gets all of the FunctionRegistryRows in the database.
        /// </summary>
        public static IEnumerable<FunctionRegistryRow> GetAllFunctionRegistryRows()
        {
            return Qry.SelectAllFrom(new FunctionRegistryRow()).Go().ExtractStrongRows<FunctionRegistryRow>();
        }
        #endregion

        #region StrongRow Overrides
        /// <summary>
        /// Gets the FunctionRegistryRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the FunctionRegistryRow</param>
        public override StrongRow GetByID(object ID)
        {
            return FunctionRegistryRow.GetFunctionRegistryRowByID(ID);
        }

        /// <summary>
        /// Gets all of the FunctionRegistryRows in the database.
        /// </summary>
        public override IEnumerable<StrongRow> GetAll()
        {
            return FunctionRegistryRow.GetAllFunctionRegistryRows();
        }
        #endregion

        #region IRepository
        /// <summary>
        /// Gets the FunctionRegistryRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the FunctionRegistryRow</param>
        FunctionRegistryRow IRepository<FunctionRegistryRow>.GetByID(object ID)
        {
            return FunctionRegistryRow.GetFunctionRegistryRowByID(ID);
        }

        /// <summary>
        /// Gets all of the FunctionRegistryRows in the database.
        /// </summary>
        IEnumerable<FunctionRegistryRow> IRepository<FunctionRegistryRow>.GetAll()
        {
            return FunctionRegistryRow.GetAllFunctionRegistryRows();
        }
        #endregion

        /// <summary>
        /// Validates all of the underlying enum values in this FunctionRegistryRow. If there are any errors in the Enum Values, they will be registered with the given SenderIdentifier.
        /// </summary>
        /// <param name="senderIdentifier">The SenderIdentifier used to register Errors in the enum values if any errors exist.</param>
        /// <param name="referenceNumberForErrors">The reference number that will be registered with any Errors.</param>
        public override void ValidateEnumValues(SenderIdentifier senderIdentifier, string referenceNumberForErrors)
        {
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry].Value != null && !StrongEnums.RegistryIdentifier.IsValidEnum(this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry].Value.ToString()))
            {
                senderIdentifier.RegisterError(new Error(referenceNumberForErrors, "Invalid Value for Registry. Value: " + this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry].Value.ToString() + "."));
            }
        }
    }
}