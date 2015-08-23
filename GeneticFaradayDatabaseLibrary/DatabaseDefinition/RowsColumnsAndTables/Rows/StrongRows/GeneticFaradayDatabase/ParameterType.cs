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
    /// The type of Parameter.
    /// </summary>
    [Serializable]
    public sealed partial class ParameterTypeRow : StrongRow, IRepository<ParameterTypeRow>, IStrongRowDescendant<ParameterTypeRow>
    {
        /// <summary>
        /// This class provides redundant access to the values of the underlying Row in a ParameterTypeRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        [Serializable]
        public sealed partial class ParameterTypeRowValues
        {
            /// <summary>
            /// PK_ParameterTypeID varchar(50) UNIQUE PRIMARY KEY,
            /// </summary>
            public System.String PK_ParameterTypeID
            {
                get { return this.Parent.PK_ParameterTypeID; }
                set { this.Parent.PK_ParameterTypeID = value; }
            }

            /// <summary>
            /// PK_ParameterTypeID varchar(50) UNIQUE PRIMARY KEY,
            /// </summary>
            public System.String PrimaryKey
            {
                get { return this.PK_ParameterTypeID; }
                set { this.PK_ParameterTypeID = value; }
            }

            /// <summary>
            /// The parent ParameterTypeRow whose values will be viewed and manipulated through this ParameterTypeRowValues.
            /// </summary>
            public ParameterTypeRow Parent { get; private set; }

            /// <summary>
            /// Constructs a ParameterTypeRowValues from a parent ParameterTypeRow.
            /// </summary>
            /// <param name="parent">The parent ParameterTypeRow whose values will be viewed and manipulated through this ParameterTypeRowValues.</param>
            public ParameterTypeRowValues(ParameterTypeRow parent)
            {
                this.Parent = parent;
            }
        }

        /// <summary>
        /// This property provides redundant access to the values of the underlying Row in this ParameterTypeRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterTypeRow.ParameterTypeRowValues Values { get; private set; }

        /// <summary>
        /// The StrongRowColumn where the value of PK_ParameterTypeID is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _pK_ParameterTypeIDColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of PK_ParameterTypeID is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn PK_ParameterTypeIDColumn
        {
            get
            {
                if (this._pK_ParameterTypeIDColumn == null)
                {
                    this.PK_ParameterTypeIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterType.PK_ParameterTypeID);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterType.PK_ParameterTypeID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_ParameterTypeID_ValueChanged);
                }

                return this._pK_ParameterTypeIDColumn;
            }
            private set { this._pK_ParameterTypeIDColumn = value; }
        }



        /// <summary>
        /// Raised when the value of PK_ParameterTypeID has changed.<para></para><para></para>This will only fire when the value of the property PK_ParameterTypeID is set. If the corresponding value is set through the underlying row or through the property PK_ParameterTypeIDColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.String>> PK_ParameterTypeIDChanged;

        /// <summary>
        /// When raised, indicates that the value of PK_ParameterTypeID has changed which fires the PK_ParameterTypeIDChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PK_ParameterTypeIDChanged event.</param>
        private void OnPK_ParameterTypeIDChanged(RowValueChangedEventArgs<System.String> e)
        {
            if (PK_ParameterTypeIDChanged != null)
                PK_ParameterTypeIDChanged(this, e);
        }



        /// <summary>
        /// PK_ParameterTypeID varchar(50) UNIQUE PRIMARY KEY,
        /// </summary>
        public System.String PK_ParameterTypeID
        {
            get
            {
                if (this.PK_ParameterTypeIDColumn.Value != null)
                    return this.PK_ParameterTypeIDColumn.Value.ToString();
                else
                    return null;
            }
            set
            {
                if (value == null)
                    throw new Exception("PK_ParameterTypeID cannot be null.");

                this.PK_ParameterTypeIDColumn.Value = value;
            }
        }

        /// <summary>
        /// Raises OnPK_ParameterTypeIDChanged when the value of PK_ParameterTypeID in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PK_ParameterTypeID_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasPK_ParameterTypeIDValueChanged = true;

            // Find the Foreign Key that refers to this Column (if there is any)
            var foreignKeyStrongRows = this.GetForeignKeyColumnsReferringToColumn(PK_ParameterTypeIDColumn);
            if (foreignKeyStrongRows != null)
                foreach (var foreignKeyStrongRow in foreignKeyStrongRows)
                    this.Parent.GetStrongRowColumn(foreignKeyStrongRow.ForeignKeyColumn).Value = e.NewValue;

            OnPK_ParameterTypeIDChanged(new RowValueChangedEventArgs<System.String>(e.PreviousValue.IsNullOrDBNull() ? null : e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : e.NewValue.ToString(), this.PK_ParameterTypeIDColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of PK_ParameterTypeID in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.PK_ParameterTypeID) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsPK_ParameterTypeIDNullOrEmpty
        {
            get { return this.PK_ParameterTypeIDColumn.Value.IsNullOrDBNull() || this.PK_ParameterTypeID == String.Empty; }
        }

        /// <summary>
        /// Indicates whether any value in this ParameterTypeRow that is not a Row (ForeignStrongRow or ForeignKeyStrongRow) is null or DBNull.Value or Empty. If false, all non-row values have values (i.e. are not null).
        /// </summary>
        public override bool IsAnyNonRowValueNullOrEmpty
        {
            get
            {
                if (this.IsPK_ParameterTypeIDNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Indicates whether the value of PK_ParameterTypeID has changed since either this ParameterTypeRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasPK_ParameterTypeIDValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether any Foreign StrongRow in this ParameterTypeRow is null or DBNull.Value or empty.
        /// </summary>
        public override bool IsAnyForeignRowNull
        {
            get { return false; }
        }

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow that stores the values of the ForeignKey Strong Row if it were joined to this ParameterTypeRow on the Foreign Key Column "ParameterType". This ParameterTypeRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Parameter_ParameterTypeRow ForeignKeyStrongRow.
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow _foreignKeyRow_Parameter_ParameterTypeRow;
        /// <summary>
        /// /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow that stores the values of the ForeignKey Strong Row if it were joined to this ParameterTypeRow on the Foreign Key Column "ParameterType". This ParameterTypeRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Parameter_ParameterTypeRow ForeignKeyStrongRow.
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow ForeignKeyRow_Parameter_ParameterTypeRow
        {
            get
            {
                if (this._foreignKeyRow_Parameter_ParameterTypeRow == null)
                {
                    this._foreignKeyRow_Parameter_ParameterTypeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow();
                    this.InitializeForeignKeyRow_Parameter_ParameterTypeRow();
                }

                return _foreignKeyRow_Parameter_ParameterTypeRow;
            }
            set
            {
                var originalValue = this.ForeignKeyRow_Parameter_ParameterTypeRow;
                this._foreignKeyRow_Parameter_ParameterTypeRow = value;


                this.InitializeForeignKeyRow_Parameter_ParameterTypeRow();

                OnForeignKeyRow_Parameter_ParameterTypeRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType, this, RowValueType.ForeignKeyStrongRow));
            }
        }

        /// <summary>
        /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "ParameterType" that belongs to ForeignKey StrongRow "ForeignKeyRow_Parameter_ParameterTypeRow" (which is a different StrongRow than this ParameterTypeRow). This ForeignKeyToThisStrongRowColumn that can be used to join this ParameterTypeRow to the ForeignKeyStrongRow "ForeignKeyRow_Parameter_ParameterTypeRow.
        /// </summary>
        private ForeignKeyToThisStrongRowColumn _foreignKeyRow_Parameter_ParameterTypeRowColumn;
        /// <summary>
        /// /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "ParameterType" that belongs to ForeignKey StrongRow "ForeignKeyRow_Parameter_ParameterTypeRow" (which is a different StrongRow than this ParameterTypeRow). This ForeignKeyToThisStrongRowColumn that can be used to join this ParameterTypeRow to the ForeignKeyStrongRow "ForeignKeyRow_Parameter_ParameterTypeRow.
        /// /// </summary>
        public ForeignKeyToThisStrongRowColumn ForeignKeyRow_Parameter_ParameterTypeRowColumn
        {
            get
            {
                if (this._foreignKeyRow_Parameter_ParameterTypeRowColumn == null)
                    this.ForeignKeyRow_Parameter_ParameterTypeRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_Parameter_ParameterTypeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType);

                return this._foreignKeyRow_Parameter_ParameterTypeRowColumn;
            }
            private set { this._foreignKeyRow_Parameter_ParameterTypeRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ForeignKeyRow_Parameter_ParameterTypeRow has changed (is NOT raised when a value inside ForeignKeyRow_Parameter_ParameterTypeRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow>> ForeignKeyRow_Parameter_ParameterTypeRowChanged;

        /// <summary>
        /// Indicates that the value of ParameterType has changed which fires the ParameterTypeChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ForeignKeyRow_Parameter_ParameterTypeRowChanged event.</param>
        private void OnForeignKeyRow_Parameter_ParameterTypeRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow> e)
        {
            if (ForeignKeyRow_Parameter_ParameterTypeRowChanged != null)
                ForeignKeyRow_Parameter_ParameterTypeRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignKeyStrongRow ForeignKeyRow_Parameter_ParameterTypeRow.
        /// </summary>
        private void SubscribeToValueChangesOfForeignKeyRow_Parameter_ParameterTypeRow()
        {
            if (this.ForeignKeyRow_Parameter_ParameterTypeRow != null)
                this.ForeignKeyRow_Parameter_ParameterTypeRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignKeyStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when setting the value of ForeignKeyRow_Parameter_ParameterTypeRow.
        /// </summary>
        private void InitializeForeignKeyRow_Parameter_ParameterTypeRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ForeignKeyRow_Parameter_ParameterTypeRow))
                this.OtherRowTableAliases.Remove(this.ForeignKeyRow_Parameter_ParameterTypeRow);

            this.ForeignKeyRow_Parameter_ParameterTypeRowColumn.ForeignKeyRow = this.ForeignKeyRow_Parameter_ParameterTypeRow;

            this.OtherRowTableAliases.Add(this.ForeignKeyRow_Parameter_ParameterTypeRow, "foreignKey_Parameter_ParameterType");
            this.ForeignKeyRow_Parameter_ParameterTypeRow.Parent = this;
            SubscribeToValueChangesOfForeignKeyRow_Parameter_ParameterTypeRow();
        }

        /// <summary>
        /// Indicates whether the value of the ForeignKeyRow_Parameter_ParameterTypeRow is null or DBNull.Value (does not Initialize the ForeignKeyRow_Parameter_ParameterTypeRow if it is currently null).
        /// </summary>
        public bool IsForeignKeyRow_Parameter_ParameterTypeRowNull
        {
            get { return this._foreignKeyRow_Parameter_ParameterTypeRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// Constructs an instance of this ParameterTypeRow from a specified Row.<para></para><para></para>NO STRONG ROW COLUMNS WILL BE INITIALIZED. This simply creates a wrapper around the Row in order to access the Row Values. It is helpful for performance.
        /// </summary>
        /// <param name="parameterTypeRow">The type of Parameter.</param>
        public ParameterTypeRow(Row parameterTypeRow)
            : this()
        {
            this.Row = parameterTypeRow;
        }

        /// <summary>
        /// Constructs an instance of this ParameterTypeRow from a specified global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.ParameterTypeRowSerializableContainer.
        /// </summary>
        /// <param name="parameterTypeRowSerializableContainer">The type of Parameter.</param>
        public ParameterTypeRow(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.ParameterTypeRowSerializableContainer parameterTypeRowSerializableContainer)
            : this()
        {
            this.Row = new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTypeTable);

            this.PK_ParameterTypeID = parameterTypeRowSerializableContainer.PK_ParameterTypeID;
        }

        /// <summary>
        /// Constructs an instance of this ParameterTypeRow from a set of values for the Row.
        /// </summary>
        public ParameterTypeRow()
            : base(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTypeTable)
        {
            if (this.Row != null)
                this.Row = global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterType.ToRow();
            this.Values = new ParameterTypeRowValues(this);
        }

        /// <summary>
        /// The TableDefinition of this ParameterTypeRow
        /// </summary>
        public override TableDefinition TableDefinition
        {
            get { return this.GetTableDefinition(); }
        }

        /// <summary>
        /// Gets the TableDefinition of this ParameterTypeRow
        /// </summary>
        public override TableDefinition GetTableDefinition()
        {
            return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTypeTable;
        }

        /// <summary>
        /// The TableDefinition of this ParameterTypeRow
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.ParameterTypeTable ParameterTypeTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterTypeTable; }
        }

        /// <summary>
        /// Given a table alias (compressed or non-compressed), initializes the proper child StrongRow that has the given alias.
        /// </summary>
        /// <param name="tableAlias">The table alias (compressed or non-compressed) that will indicate which child StrongRow to initialize.</param>
        public override void InitializeChildStrongRowWithAlias(string tableAlias)
        {
            switch (tableAlias)
            {
                case "foreignKey_Parameter_ParameterType":
                    if (this._foreignKeyRow_Parameter_ParameterTypeRow == null)
                    {
                        this._foreignKeyRow_Parameter_ParameterTypeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow();
                        this.InitializeForeignKeyRow_Parameter_ParameterTypeRow();
                    }
                    return;
                case "_PPT34nia61":
                    if (this._foreignKeyRow_Parameter_ParameterTypeRow == null)
                    {
                        this._foreignKeyRow_Parameter_ParameterTypeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow();
                        this.InitializeForeignKeyRow_Parameter_ParameterTypeRow();
                    }
                    return;
                default:
                    throw new Exception("The given table alias does not refer to any child StrongRow in this ParameterTypeRow.");
                    return;

            }
        }

        /// <summary>
        /// Initializes all of the Foreign Strong Rows and Foreign Key StrongRows in this ParameterTypeRow that are currently null. Calls the parameterless constructor for each Strong Row that is null.
        /// </summary>
        public override void InitializeChildStrongRows()
        {

            if (this.ForeignKeyRow_Parameter_ParameterTypeRow == null)
                this.ForeignKeyRow_Parameter_ParameterTypeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow();
        }

        /// <summary>
        /// Initializes all of the StrongRowColumns in this ParameterTypeRow that are currently null. Also handles the necessary event subscriptions.
        /// </summary>
        public override void InitializeStrongRowColumns()
        {
            if (this.PK_ParameterTypeIDColumn == null)
            {
                this.PK_ParameterTypeIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterType.PK_ParameterTypeID);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterType.PK_ParameterTypeID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_ParameterTypeID_ValueChanged);
            }
        }

        /// <summary>
        /// Initializes all of the ForeignStrongRowColumns in this ParameterTypeRow that are null.
        /// </summary>
        public override void InitializeForeignStrongRowColumns()
        {

        }

        /// <summary>
        /// Initializes all of the ForeignKeyToThisStrongRowColumns in this ParameterTypeRow that are null.
        /// </summary>
        public override void InitializeForeignKeyToThisStrongRowColumns()
        {
            if (this.ForeignKeyRow_Parameter_ParameterTypeRowColumn == null)
                this.ForeignKeyRow_Parameter_ParameterTypeRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_Parameter_ParameterTypeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.ParameterType);
        }

        /// <summary>
        /// Inserts the Row into the database immediately (if it is not currently in the database. This method first checks to ensure that the Row is not in the database). Returns true if the Row was inserted. Returns false if not. Out's the primary key.
        /// </summary>
        /// <param name="primaryKey">PK_ParameterTypeID varchar(50) UNIQUE PRIMARY KEY,</param>
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
        /// <param name="primaryKey">PK_ParameterTypeID varchar(50) UNIQUE PRIMARY KEY,</param>
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
        /// Indicates whether the Primary Key PK_ParameterTypeID is null or DBNull.Value or is an Empty value.
        /// </summary>
        public override bool IsPrimaryKeyNullOrEmpty
        {
            get { return this.IsPK_ParameterTypeIDNullOrEmpty; }
        }

        /// <summary>
        /// The Primary Key PK_ParameterTypeID for this ParameterType.
        /// </summary>
        public System.String PrimaryKey
        {
            get { return this.PK_ParameterTypeID; }
            set { this.PK_ParameterTypeID = value; }
        }

        /// <summary>
        /// The Primary Key Column for this ParameterType.
        /// </summary>
        public override StrongRowColumn PrimaryKeyColumn
        {
            get { return this.PK_ParameterTypeIDColumn; }
        }

        /// <summary>
        /// Returns all of the Columns in the ParameterTypeRow whose values have changed according to their HasChanged flags.
        /// </summary>
        public override List<Column> GetColumnsWithChangedValues()
        {
            // If no value in this row has changed then return an empty list.
            if (!this.HasAnyNonRowValueInRowChanged)
                return new List<Column>(0);

            // We will collect the columns whose values have changed.
            var columns = new List<Column>();

            if (HasPK_ParameterTypeIDValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterType.PK_ParameterTypeID);

            return columns;
        }

        /// <summary>
        /// Calls ResetAllHasAnyValueChangedFlags() for this ParameterTypeRow and ResetAllThisAndChildrenHasAnyValueChangedFlags() for all children Foreign StrongRows and Foreign Key Strong Rows that are not null.
        /// </summary>
        public override void ResetAllThisAndChildrenHasAnyValueChangedFlags()
        {
            this.ResetAllHasAnyValueChangedFlags();

            if (this._foreignKeyRow_Parameter_ParameterTypeRow != null)
                this.ForeignKeyRow_Parameter_ParameterTypeRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
        }

        /// <summary>
        /// Resets all of the HasAnyValuesChanged for each of the values in this ParameterTypeRow. Also calls the base.ResetAllHasAnyValueChangedFlags().
        /// </summary>
        public override void ResetAllHasAnyValueChangedFlags()
        {
            base.ResetAllHasAnyValueChangedFlags();

            this.HasPK_ParameterTypeIDValueChanged = false;
        }

        /// <summary>
        /// Gets all of the StrongRowColumns in this ParameterTypeRow.
        /// </summary>
        public override StrongRowColumn[] GetAllStrongRowColumns()
        {
            return new StrongRowColumn[] { PK_ParameterTypeIDColumn };
        }

        /// <summary>
        /// Gets all of the StrongRowForeignKeyColumns in this ParameterTypeRow.
        /// </summary>
        public override StrongRowForeignKeyColumn[] GetAllStrongRowForeignKeyColumns()
        {
            return new StrongRowForeignKeyColumn[] { };
        }

        /// <summary>
        /// Gets all of the ForeignKeyToThisStrongRowColumn in this ParameterTypeRow.
        /// </summary>
        public override ForeignKeyToThisStrongRowColumn[] GetAllForeignKeyToThisStrongRowColumns()
        {
            return new ForeignKeyToThisStrongRowColumn[] { ForeignKeyRow_Parameter_ParameterTypeRowColumn };
        }

        /// <summary>
        /// Converts the ParameterTypeRow to a ParameterTypeRowSerializableContainer.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.ParameterTypeRowSerializableContainer ToParameterTypeRowSerializableContainer()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.ParameterTypeRowSerializableContainer(this);
        }

        /// <summary>
        /// Converts the StrongRow to the appropriate StrongRowSerializableContainer.
        /// </summary>
        public override StrongRowSerializableContainer ToStrongRowSerializableContainer()
        {
            return this.ToParameterTypeRowSerializableContainer();
        }

        #region IStrongRowDescendant<T>
        /// <summary>
        /// Fills any empty values in this ParameterTypeRow with the corresponding values from the given ParameterTypeRow. Does NOT fill the Primary Key.
        /// </summary>
        /// <param name="sourceOfFilling">The ParameterTypeRow from which we will gather values in order to fill any empty values in this ParameterTypeRow.</param>
        public void FillEmptyValues(ParameterTypeRow sourceOfFilling)
        {
            if (sourceOfFilling == null)
                return;

        }

        /// <summary>
        /// This ParameterTypeRow used to fulfill the IStrongRowDescendent<T> contact.
        /// </summary>
        public ParameterTypeRow Self
        {
            get { return this; }
        }

        /// <summary>
        /// Creates a deep copy of the given other ParameterTypeRow. Fills this ParameterTypeRow with the values, Foreign StrongRows and ForeignKey StrongRows of the given other ParameterTypeRow. Fills each child row's children as well.
        /// </summary>
        /// <param name="other">The StrongRow from which values will be populated</param>
        public void PopulateFromRow(ParameterTypeRow other)
        {
            this.PK_ParameterTypeID = other.PK_ParameterTypeID;

            if (other._foreignKeyRow_Parameter_ParameterTypeRow != null)
            {
                var parameter_ParameterTypeRow = other.ForeignKeyRow_Parameter_ParameterTypeRow;
                this.ForeignKeyRow_Parameter_ParameterTypeRow.PopulateFromRow(parameter_ParameterTypeRow);
            }
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Gets the ParameterTypeRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the ParameterTypeRow</param>
        public static ParameterTypeRow GetParameterTypeRowByID(object ID)
        {
            var parameterTypeRow = new ParameterTypeRow();
            Qry.SelectAllFrom(parameterTypeRow).Where(parameterTypeRow.PrimaryKeyColumn, ID).Go().ExtractStrongRow(ref parameterTypeRow);
            return parameterTypeRow;
        }

        /// <summary>
        /// Gets all of the ParameterTypeRows in the database.
        /// </summary>
        public static IEnumerable<ParameterTypeRow> GetAllParameterTypeRows()
        {
            return Qry.SelectAllFrom(new ParameterTypeRow()).Go().ExtractStrongRows<ParameterTypeRow>();
        }
        #endregion

        #region StrongRow Overrides
        /// <summary>
        /// Gets the ParameterTypeRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the ParameterTypeRow</param>
        public override StrongRow GetByID(object ID)
        {
            return ParameterTypeRow.GetParameterTypeRowByID(ID);
        }

        /// <summary>
        /// Gets all of the ParameterTypeRows in the database.
        /// </summary>
        public override IEnumerable<StrongRow> GetAll()
        {
            return ParameterTypeRow.GetAllParameterTypeRows();
        }
        #endregion

        #region IRepository
        /// <summary>
        /// Gets the ParameterTypeRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the ParameterTypeRow</param>
        ParameterTypeRow IRepository<ParameterTypeRow>.GetByID(object ID)
        {
            return ParameterTypeRow.GetParameterTypeRowByID(ID);
        }

        /// <summary>
        /// Gets all of the ParameterTypeRows in the database.
        /// </summary>
        IEnumerable<ParameterTypeRow> IRepository<ParameterTypeRow>.GetAll()
        {
            return ParameterTypeRow.GetAllParameterTypeRows();
        }
        #endregion

        /// <summary>
        /// Validates all of the underlying enum values in this ParameterTypeRow. If there are any errors in the Enum Values, they will be registered with the given SenderIdentifier. Also validates the primary key since this StrongRow is an Enum.
        /// </summary>
        /// <param name="senderIdentifier">The SenderIdentifier used to register Errors in the enum values if any errors exist.</param>
        /// <param name="referenceNumberForErrors">The reference number that will be registered with any Errors.</param>
        public override void ValidateEnumValues(SenderIdentifier senderIdentifier, string referenceNumberForErrors)
        {
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterType.PK_ParameterTypeID].Value != null && !StrongEnums.ParameterType.IsValidEnum(this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterType.PK_ParameterTypeID].Value.ToString()))
            {
                senderIdentifier.RegisterError(new Error(referenceNumberForErrors, "Invalid Value for PK_ParameterTypeID. Value: " + this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.ParameterType.PK_ParameterTypeID].Value.ToString() + "."));
            }
        }
    }
}