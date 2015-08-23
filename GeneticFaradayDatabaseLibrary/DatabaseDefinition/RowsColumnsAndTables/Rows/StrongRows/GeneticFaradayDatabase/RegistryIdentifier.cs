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
    /// The identifier of a Registry.
    /// </summary>
    [Serializable]
    public sealed partial class RegistryIdentifierRow : StrongRow, IRepository<RegistryIdentifierRow>, IStrongRowDescendant<RegistryIdentifierRow>
    {
        /// <summary>
        /// This class provides redundant access to the values of the underlying Row in a RegistryIdentifierRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        [Serializable]
        public sealed partial class RegistryIdentifierRowValues
        {
            /// <summary>
            /// The ID of a Registry
            /// </summary>
            public System.String PK_RegistryIdentifierID
            {
                get { return this.Parent.PK_RegistryIdentifierID; }
                set { this.Parent.PK_RegistryIdentifierID = value; }
            }

            /// <summary>
            /// The ID of a Registry
            /// </summary>
            public System.String PrimaryKey
            {
                get { return this.PK_RegistryIdentifierID; }
                set { this.PK_RegistryIdentifierID = value; }
            }

            /// <summary>
            /// The parent RegistryIdentifierRow whose values will be viewed and manipulated through this RegistryIdentifierRowValues.
            /// </summary>
            public RegistryIdentifierRow Parent { get; private set; }

            /// <summary>
            /// Constructs a RegistryIdentifierRowValues from a parent RegistryIdentifierRow.
            /// </summary>
            /// <param name="parent">The parent RegistryIdentifierRow whose values will be viewed and manipulated through this RegistryIdentifierRowValues.</param>
            public RegistryIdentifierRowValues(RegistryIdentifierRow parent)
            {
                this.Parent = parent;
            }
        }

        /// <summary>
        /// This property provides redundant access to the values of the underlying Row in this RegistryIdentifierRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.RegistryIdentifierRow.RegistryIdentifierRowValues Values { get; private set; }

        /// <summary>
        /// The StrongRowColumn where the value of PK_RegistryIdentifierID is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _pK_RegistryIdentifierIDColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of PK_RegistryIdentifierID is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn PK_RegistryIdentifierIDColumn
        {
            get
            {
                if (this._pK_RegistryIdentifierIDColumn == null)
                {
                    this.PK_RegistryIdentifierIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifier.PK_RegistryIdentifierID);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifier.PK_RegistryIdentifierID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_RegistryIdentifierID_ValueChanged);
                }

                return this._pK_RegistryIdentifierIDColumn;
            }
            private set { this._pK_RegistryIdentifierIDColumn = value; }
        }



        /// <summary>
        /// Raised when the value of PK_RegistryIdentifierID has changed.<para></para><para></para>This will only fire when the value of the property PK_RegistryIdentifierID is set. If the corresponding value is set through the underlying row or through the property PK_RegistryIdentifierIDColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.String>> PK_RegistryIdentifierIDChanged;

        /// <summary>
        /// When raised, indicates that the value of PK_RegistryIdentifierID has changed which fires the PK_RegistryIdentifierIDChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PK_RegistryIdentifierIDChanged event.</param>
        private void OnPK_RegistryIdentifierIDChanged(RowValueChangedEventArgs<System.String> e)
        {
            if (PK_RegistryIdentifierIDChanged != null)
                PK_RegistryIdentifierIDChanged(this, e);
        }



        /// <summary>
        /// The ID of a Registry
        /// </summary>
        public System.String PK_RegistryIdentifierID
        {
            get
            {
                if (this.PK_RegistryIdentifierIDColumn.Value != null)
                    return this.PK_RegistryIdentifierIDColumn.Value.ToString();
                else
                    return null;
            }
            set
            {
                if (value == null)
                    throw new Exception("PK_RegistryIdentifierID cannot be null.");

                this.PK_RegistryIdentifierIDColumn.Value = value;
            }
        }

        /// <summary>
        /// Raises OnPK_RegistryIdentifierIDChanged when the value of PK_RegistryIdentifierID in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PK_RegistryIdentifierID_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasPK_RegistryIdentifierIDValueChanged = true;

            // Find the Foreign Key that refers to this Column (if there is any)
            var foreignKeyStrongRows = this.GetForeignKeyColumnsReferringToColumn(PK_RegistryIdentifierIDColumn);
            if (foreignKeyStrongRows != null)
                foreach (var foreignKeyStrongRow in foreignKeyStrongRows)
                    this.Parent.GetStrongRowColumn(foreignKeyStrongRow.ForeignKeyColumn).Value = e.NewValue;

            OnPK_RegistryIdentifierIDChanged(new RowValueChangedEventArgs<System.String>(e.PreviousValue.IsNullOrDBNull() ? null : e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : e.NewValue.ToString(), this.PK_RegistryIdentifierIDColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of PK_RegistryIdentifierID in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.PK_RegistryIdentifierID) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsPK_RegistryIdentifierIDNullOrEmpty
        {
            get { return this.PK_RegistryIdentifierIDColumn.Value.IsNullOrDBNull() || this.PK_RegistryIdentifierID == String.Empty; }
        }

        /// <summary>
        /// Indicates whether any value in this RegistryIdentifierRow that is not a Row (ForeignStrongRow or ForeignKeyStrongRow) is null or DBNull.Value or Empty. If false, all non-row values have values (i.e. are not null).
        /// </summary>
        public override bool IsAnyNonRowValueNullOrEmpty
        {
            get
            {
                if (this.IsPK_RegistryIdentifierIDNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Indicates whether the value of PK_RegistryIdentifierID has changed since either this RegistryIdentifierRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasPK_RegistryIdentifierIDValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether any Foreign StrongRow in this RegistryIdentifierRow is null or DBNull.Value or empty.
        /// </summary>
        public override bool IsAnyForeignRowNull
        {
            get { return false; }
        }

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow that stores the values of the ForeignKey Strong Row if it were joined to this RegistryIdentifierRow on the Foreign Key Column "Registry". This RegistryIdentifierRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_FunctionRegistry_RegistryRow ForeignKeyStrongRow.
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow _foreignKeyRow_FunctionRegistry_RegistryRow;
        /// <summary>
        /// /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow that stores the values of the ForeignKey Strong Row if it were joined to this RegistryIdentifierRow on the Foreign Key Column "Registry". This RegistryIdentifierRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_FunctionRegistry_RegistryRow ForeignKeyStrongRow.
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow ForeignKeyRow_FunctionRegistry_RegistryRow
        {
            get
            {
                if (this._foreignKeyRow_FunctionRegistry_RegistryRow == null)
                {
                    this._foreignKeyRow_FunctionRegistry_RegistryRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow();
                    this.InitializeForeignKeyRow_FunctionRegistry_RegistryRow();
                }

                return _foreignKeyRow_FunctionRegistry_RegistryRow;
            }
            set
            {
                var originalValue = this.ForeignKeyRow_FunctionRegistry_RegistryRow;
                this._foreignKeyRow_FunctionRegistry_RegistryRow = value;


                this.InitializeForeignKeyRow_FunctionRegistry_RegistryRow();

                OnForeignKeyRow_FunctionRegistry_RegistryRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry, this, RowValueType.ForeignKeyStrongRow));
            }
        }

        /// <summary>
        /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "Registry" that belongs to ForeignKey StrongRow "ForeignKeyRow_FunctionRegistry_RegistryRow" (which is a different StrongRow than this RegistryIdentifierRow). This ForeignKeyToThisStrongRowColumn that can be used to join this RegistryIdentifierRow to the ForeignKeyStrongRow "ForeignKeyRow_FunctionRegistry_RegistryRow.
        /// </summary>
        private ForeignKeyToThisStrongRowColumn _foreignKeyRow_FunctionRegistry_RegistryRowColumn;
        /// <summary>
        /// /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "Registry" that belongs to ForeignKey StrongRow "ForeignKeyRow_FunctionRegistry_RegistryRow" (which is a different StrongRow than this RegistryIdentifierRow). This ForeignKeyToThisStrongRowColumn that can be used to join this RegistryIdentifierRow to the ForeignKeyStrongRow "ForeignKeyRow_FunctionRegistry_RegistryRow.
        /// /// </summary>
        public ForeignKeyToThisStrongRowColumn ForeignKeyRow_FunctionRegistry_RegistryRowColumn
        {
            get
            {
                if (this._foreignKeyRow_FunctionRegistry_RegistryRowColumn == null)
                    this.ForeignKeyRow_FunctionRegistry_RegistryRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_FunctionRegistry_RegistryRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry);

                return this._foreignKeyRow_FunctionRegistry_RegistryRowColumn;
            }
            private set { this._foreignKeyRow_FunctionRegistry_RegistryRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ForeignKeyRow_FunctionRegistry_RegistryRow has changed (is NOT raised when a value inside ForeignKeyRow_FunctionRegistry_RegistryRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow>> ForeignKeyRow_FunctionRegistry_RegistryRowChanged;

        /// <summary>
        /// Indicates that the value of Registry has changed which fires the RegistryChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ForeignKeyRow_FunctionRegistry_RegistryRowChanged event.</param>
        private void OnForeignKeyRow_FunctionRegistry_RegistryRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow> e)
        {
            if (ForeignKeyRow_FunctionRegistry_RegistryRowChanged != null)
                ForeignKeyRow_FunctionRegistry_RegistryRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignKeyStrongRow ForeignKeyRow_FunctionRegistry_RegistryRow.
        /// </summary>
        private void SubscribeToValueChangesOfForeignKeyRow_FunctionRegistry_RegistryRow()
        {
            if (this.ForeignKeyRow_FunctionRegistry_RegistryRow != null)
                this.ForeignKeyRow_FunctionRegistry_RegistryRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignKeyStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when setting the value of ForeignKeyRow_FunctionRegistry_RegistryRow.
        /// </summary>
        private void InitializeForeignKeyRow_FunctionRegistry_RegistryRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ForeignKeyRow_FunctionRegistry_RegistryRow))
                this.OtherRowTableAliases.Remove(this.ForeignKeyRow_FunctionRegistry_RegistryRow);

            this.ForeignKeyRow_FunctionRegistry_RegistryRowColumn.ForeignKeyRow = this.ForeignKeyRow_FunctionRegistry_RegistryRow;

            this.OtherRowTableAliases.Add(this.ForeignKeyRow_FunctionRegistry_RegistryRow, "foreignKey_FunctionRegistry_Registry");
            this.ForeignKeyRow_FunctionRegistry_RegistryRow.Parent = this;
            SubscribeToValueChangesOfForeignKeyRow_FunctionRegistry_RegistryRow();
        }

        /// <summary>
        /// Indicates whether the value of the ForeignKeyRow_FunctionRegistry_RegistryRow is null or DBNull.Value (does not Initialize the ForeignKeyRow_FunctionRegistry_RegistryRow if it is currently null).
        /// </summary>
        public bool IsForeignKeyRow_FunctionRegistry_RegistryRowNull
        {
            get { return this._foreignKeyRow_FunctionRegistry_RegistryRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// Constructs an instance of this RegistryIdentifierRow from a specified Row.<para></para><para></para>NO STRONG ROW COLUMNS WILL BE INITIALIZED. This simply creates a wrapper around the Row in order to access the Row Values. It is helpful for performance.
        /// </summary>
        /// <param name="registryIdentifierRow">The identifier of a Registry.</param>
        public RegistryIdentifierRow(Row registryIdentifierRow)
            : this()
        {
            this.Row = registryIdentifierRow;
        }

        /// <summary>
        /// Constructs an instance of this RegistryIdentifierRow from a specified global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.RegistryIdentifierRowSerializableContainer.
        /// </summary>
        /// <param name="registryIdentifierRowSerializableContainer">The identifier of a Registry.</param>
        public RegistryIdentifierRow(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.RegistryIdentifierRowSerializableContainer registryIdentifierRowSerializableContainer)
            : this()
        {
            this.Row = new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifierTable);

            this.PK_RegistryIdentifierID = registryIdentifierRowSerializableContainer.PK_RegistryIdentifierID;
        }

        /// <summary>
        /// Constructs an instance of this RegistryIdentifierRow from a set of values for the Row.
        /// </summary>
        public RegistryIdentifierRow()
            : base(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifierTable)
        {
            if (this.Row != null)
                this.Row = global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifier.ToRow();
            this.Values = new RegistryIdentifierRowValues(this);
        }

        /// <summary>
        /// The TableDefinition of this RegistryIdentifierRow
        /// </summary>
        public override TableDefinition TableDefinition
        {
            get { return this.GetTableDefinition(); }
        }

        /// <summary>
        /// Gets the TableDefinition of this RegistryIdentifierRow
        /// </summary>
        public override TableDefinition GetTableDefinition()
        {
            return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifierTable;
        }

        /// <summary>
        /// The TableDefinition of this RegistryIdentifierRow
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.RegistryIdentifierTable RegistryIdentifierTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifierTable; }
        }

        /// <summary>
        /// Given a table alias (compressed or non-compressed), initializes the proper child StrongRow that has the given alias.
        /// </summary>
        /// <param name="tableAlias">The table alias (compressed or non-compressed) that will indicate which child StrongRow to initialize.</param>
        public override void InitializeChildStrongRowWithAlias(string tableAlias)
        {
            switch (tableAlias)
            {
                case "foreignKey_FunctionRegistry_Registry":
                    if (this._foreignKeyRow_FunctionRegistry_RegistryRow == null)
                    {
                        this._foreignKeyRow_FunctionRegistry_RegistryRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow();
                        this.InitializeForeignKeyRow_FunctionRegistry_RegistryRow();
                    }
                    return;
                case "_FRR36niu63":
                    if (this._foreignKeyRow_FunctionRegistry_RegistryRow == null)
                    {
                        this._foreignKeyRow_FunctionRegistry_RegistryRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow();
                        this.InitializeForeignKeyRow_FunctionRegistry_RegistryRow();
                    }
                    return;
                default:
                    throw new Exception("The given table alias does not refer to any child StrongRow in this RegistryIdentifierRow.");
                    return;

            }
        }

        /// <summary>
        /// Initializes all of the Foreign Strong Rows and Foreign Key StrongRows in this RegistryIdentifierRow that are currently null. Calls the parameterless constructor for each Strong Row that is null.
        /// </summary>
        public override void InitializeChildStrongRows()
        {

            if (this.ForeignKeyRow_FunctionRegistry_RegistryRow == null)
                this.ForeignKeyRow_FunctionRegistry_RegistryRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionRegistryRow();
        }

        /// <summary>
        /// Initializes all of the StrongRowColumns in this RegistryIdentifierRow that are currently null. Also handles the necessary event subscriptions.
        /// </summary>
        public override void InitializeStrongRowColumns()
        {
            if (this.PK_RegistryIdentifierIDColumn == null)
            {
                this.PK_RegistryIdentifierIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifier.PK_RegistryIdentifierID);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifier.PK_RegistryIdentifierID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_RegistryIdentifierID_ValueChanged);
            }
        }

        /// <summary>
        /// Initializes all of the ForeignStrongRowColumns in this RegistryIdentifierRow that are null.
        /// </summary>
        public override void InitializeForeignStrongRowColumns()
        {

        }

        /// <summary>
        /// Initializes all of the ForeignKeyToThisStrongRowColumns in this RegistryIdentifierRow that are null.
        /// </summary>
        public override void InitializeForeignKeyToThisStrongRowColumns()
        {
            if (this.ForeignKeyRow_FunctionRegistry_RegistryRowColumn == null)
                this.ForeignKeyRow_FunctionRegistry_RegistryRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_FunctionRegistry_RegistryRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionRegistry.Registry);
        }

        /// <summary>
        /// Inserts the Row into the database immediately (if it is not currently in the database. This method first checks to ensure that the Row is not in the database). Returns true if the Row was inserted. Returns false if not. Out's the primary key.
        /// </summary>
        /// <param name="primaryKey">The ID of a Registry</param>
        public bool InsertOnlyIfNecessary(out System.String primaryKey)
        {
            object primaryKeyObject;
            var result = this.Row.InsertOnlyIfNecessary(out primaryKeyObject);
            primaryKey = primaryKeyObject.ToString();
            return result;
        }

        /// <summary>
        /// Out's primary key of null if not in database. If the ColumnGroupDefiningUniqueness is null, this returns IsInDatabaseResult.None
        /// </summary>
        /// <param name="primaryKey">The ID of a Registry</param>
        public IsInDatabaseResult IsAnyInDatabase(out System.String primaryKey)
        {
            object primaryKeyObject;
            var result = this.Row.IsAnyInDatabase(out primaryKeyObject);
            if (primaryKeyObject == null)
                primaryKey = null;
            else
                primaryKey = primaryKeyObject.ToString();
            return result;
        }

        /// <summary>
        /// Inserts this Row into the database immediately and then retrieves the primary key value of the Row.
        /// </summary>
        public System.String InsertIntoDatabase()
        {
            return this.Row.InsertIntoDatabase().ToString();
        }

        /// <summary>
        /// Asserts that this StrongRow is in the database and gets the primary key. If the row does not exist in the database, throws a DataIntegrityException exception.
        /// </summary>
        /// <param name="senderIdentifierForErrors">Errors will be registered under this Sender Identifier in the Logger.</param>
        /// <param name="referenceNumberForErrors">The reference number that will be catalogued if an error occurs.</param>
        public System.String AssertRowInDatabase(SenderIdentifier senderIdentifierForErrors, string referenceNumberForErrors)
        {
            return this.Row.AssertRowInDatabase(senderIdentifierForErrors, referenceNumberForErrors).ToString();
        }

        /// <summary>
        /// Indicates whether the Primary Key PK_RegistryIdentifierID is null or DBNull.Value or is an Empty value.
        /// </summary>
        public override bool IsPrimaryKeyNullOrEmpty
        {
            get { return this.IsPK_RegistryIdentifierIDNullOrEmpty; }
        }

        /// <summary>
        /// The Primary Key PK_RegistryIdentifierID for this RegistryIdentifier.
        /// </summary>
        public System.String PrimaryKey
        {
            get { return this.PK_RegistryIdentifierID; }
            set { this.PK_RegistryIdentifierID = value; }
        }

        /// <summary>
        /// The Primary Key Column for this RegistryIdentifier.
        /// </summary>
        public override StrongRowColumn PrimaryKeyColumn
        {
            get { return this.PK_RegistryIdentifierIDColumn; }
        }

        /// <summary>
        /// Returns all of the Columns in the RegistryIdentifierRow whose values have changed according to their HasChanged flags.
        /// </summary>
        public override List<Column> GetColumnsWithChangedValues()
        {
            // If no value in this row has changed then return an empty list.
            if (!this.HasAnyNonRowValueInRowChanged)
                return new List<Column>(0);

            // We will collect the columns whose values have changed.
            var columns = new List<Column>();

            if (HasPK_RegistryIdentifierIDValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifier.PK_RegistryIdentifierID);

            return columns;
        }

        /// <summary>
        /// Calls ResetAllHasAnyValueChangedFlags() for this RegistryIdentifierRow and ResetAllThisAndChildrenHasAnyValueChangedFlags() for all children Foreign StrongRows and Foreign Key Strong Rows that are not null.
        /// </summary>
        public override void ResetAllThisAndChildrenHasAnyValueChangedFlags()
        {
            this.ResetAllHasAnyValueChangedFlags();

            if (this._foreignKeyRow_FunctionRegistry_RegistryRow != null)
                this.ForeignKeyRow_FunctionRegistry_RegistryRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
        }

        /// <summary>
        /// Resets all of the HasAnyValuesChanged for each of the values in this RegistryIdentifierRow. Also calls the base.ResetAllHasAnyValueChangedFlags().
        /// </summary>
        public override void ResetAllHasAnyValueChangedFlags()
        {
            base.ResetAllHasAnyValueChangedFlags();

            this.HasPK_RegistryIdentifierIDValueChanged = false;
        }

        /// <summary>
        /// Gets all of the StrongRowColumns in this RegistryIdentifierRow.
        /// </summary>
        public override StrongRowColumn[] GetAllStrongRowColumns()
        {
            return new StrongRowColumn[] { PK_RegistryIdentifierIDColumn };
        }

        /// <summary>
        /// Gets all of the StrongRowForeignKeyColumns in this RegistryIdentifierRow.
        /// </summary>
        public override StrongRowForeignKeyColumn[] GetAllStrongRowForeignKeyColumns()
        {
            return new StrongRowForeignKeyColumn[] { };
        }

        /// <summary>
        /// Gets all of the ForeignKeyToThisStrongRowColumn in this RegistryIdentifierRow.
        /// </summary>
        public override ForeignKeyToThisStrongRowColumn[] GetAllForeignKeyToThisStrongRowColumns()
        {
            return new ForeignKeyToThisStrongRowColumn[] { ForeignKeyRow_FunctionRegistry_RegistryRowColumn };
        }

        /// <summary>
        /// Converts the RegistryIdentifierRow to a RegistryIdentifierRowSerializableContainer.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.RegistryIdentifierRowSerializableContainer ToRegistryIdentifierRowSerializableContainer()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.RegistryIdentifierRowSerializableContainer(this);
        }

        /// <summary>
        /// Converts the StrongRow to the appropriate StrongRowSerializableContainer.
        /// </summary>
        public override StrongRowSerializableContainer ToStrongRowSerializableContainer()
        {
            return this.ToRegistryIdentifierRowSerializableContainer();
        }

        #region IStrongRowDescendant<T>
        /// <summary>
        /// Fills any empty values in this RegistryIdentifierRow with the corresponding values from the given RegistryIdentifierRow. Does NOT fill the Primary Key.
        /// </summary>
        /// <param name="sourceOfFilling">The RegistryIdentifierRow from which we will gather values in order to fill any empty values in this RegistryIdentifierRow.</param>
        public void FillEmptyValues(RegistryIdentifierRow sourceOfFilling)
        {
            if (sourceOfFilling == null)
                return;

        }

        /// <summary>
        /// This RegistryIdentifierRow used to fulfill the IStrongRowDescendent<T> contact.
        /// </summary>
        public RegistryIdentifierRow Self
        {
            get { return this; }
        }

        /// <summary>
        /// Creates a deep copy of the given other RegistryIdentifierRow. Fills this RegistryIdentifierRow with the values, Foreign StrongRows and ForeignKey StrongRows of the given other RegistryIdentifierRow. Fills each child row's children as well.
        /// </summary>
        /// <param name="other">The StrongRow from which values will be populated</param>
        public void PopulateFromRow(RegistryIdentifierRow other)
        {
            this.PK_RegistryIdentifierID = other.PK_RegistryIdentifierID;

            if (other._foreignKeyRow_FunctionRegistry_RegistryRow != null)
            {
                var functionRegistry_RegistryRow = other.ForeignKeyRow_FunctionRegistry_RegistryRow;
                this.ForeignKeyRow_FunctionRegistry_RegistryRow.PopulateFromRow(functionRegistry_RegistryRow);
            }
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Gets the RegistryIdentifierRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the RegistryIdentifierRow</param>
        public static RegistryIdentifierRow GetRegistryIdentifierRowByID(object ID)
        {
            var registryIdentifierRow = new RegistryIdentifierRow();
            Qry.SelectAllFrom(registryIdentifierRow).Where(registryIdentifierRow.PrimaryKeyColumn, ID).Go().ExtractStrongRow(ref registryIdentifierRow);
            return registryIdentifierRow;
        }

        /// <summary>
        /// Gets all of the RegistryIdentifierRows in the database.
        /// </summary>
        public static IEnumerable<RegistryIdentifierRow> GetAllRegistryIdentifierRows()
        {
            return Qry.SelectAllFrom(new RegistryIdentifierRow()).Go().ExtractStrongRows<RegistryIdentifierRow>();
        }
        #endregion

        #region StrongRow Overrides
        /// <summary>
        /// Gets the RegistryIdentifierRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the RegistryIdentifierRow</param>
        public override StrongRow GetByID(object ID)
        {
            return RegistryIdentifierRow.GetRegistryIdentifierRowByID(ID);
        }

        /// <summary>
        /// Gets all of the RegistryIdentifierRows in the database.
        /// </summary>
        public override IEnumerable<StrongRow> GetAll()
        {
            return RegistryIdentifierRow.GetAllRegistryIdentifierRows();
        }
        #endregion

        #region IRepository
        /// <summary>
        /// Gets the RegistryIdentifierRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the RegistryIdentifierRow</param>
        RegistryIdentifierRow IRepository<RegistryIdentifierRow>.GetByID(object ID)
        {
            return RegistryIdentifierRow.GetRegistryIdentifierRowByID(ID);
        }

        /// <summary>
        /// Gets all of the RegistryIdentifierRows in the database.
        /// </summary>
        IEnumerable<RegistryIdentifierRow> IRepository<RegistryIdentifierRow>.GetAll()
        {
            return RegistryIdentifierRow.GetAllRegistryIdentifierRows();
        }
        #endregion

        /// <summary>
        /// Validates all of the underlying enum values in this RegistryIdentifierRow. If there are any errors in the Enum Values, they will be registered with the given SenderIdentifier. Also validates the primary key since this StrongRow is an Enum.
        /// </summary>
        /// <param name="senderIdentifier">The SenderIdentifier used to register Errors in the enum values if any errors exist.</param>
        /// <param name="referenceNumberForErrors">The reference number that will be registered with any Errors.</param>
        public override void ValidateEnumValues(SenderIdentifier senderIdentifier, string referenceNumberForErrors)
        {
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifier.PK_RegistryIdentifierID].Value != null && !StrongEnums.RegistryIdentifier.IsValidEnum(this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifier.PK_RegistryIdentifierID].Value.ToString()))
            {
                senderIdentifier.RegisterError(new Error(referenceNumberForErrors, "Invalid Value for PK_RegistryIdentifierID. Value: " + this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.RegistryIdentifier.PK_RegistryIdentifierID].Value.ToString() + "."));
            }
        }
    }
}