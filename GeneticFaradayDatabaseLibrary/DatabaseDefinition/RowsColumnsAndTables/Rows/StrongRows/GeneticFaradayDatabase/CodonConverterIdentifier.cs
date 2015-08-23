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
    /// The identifier of the Codon Converter.
    /// </summary>
    [Serializable]
    public sealed partial class CodonConverterIdentifierRow : StrongRow, IRepository<CodonConverterIdentifierRow>, IStrongRowDescendant<CodonConverterIdentifierRow>
    {
        /// <summary>
        /// This class provides redundant access to the values of the underlying Row in a CodonConverterIdentifierRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        [Serializable]
        public sealed partial class CodonConverterIdentifierRowValues
        {
            /// <summary>
            /// The ID of a Codon Converter
            /// </summary>
            public System.String PK_CodonConverterIdentifierID
            {
                get { return this.Parent.PK_CodonConverterIdentifierID; }
                set { this.Parent.PK_CodonConverterIdentifierID = value; }
            }

            /// <summary>
            /// The ID of a Codon Converter
            /// </summary>
            public System.String PrimaryKey
            {
                get { return this.PK_CodonConverterIdentifierID; }
                set { this.PK_CodonConverterIdentifierID = value; }
            }

            /// <summary>
            /// The parent CodonConverterIdentifierRow whose values will be viewed and manipulated through this CodonConverterIdentifierRowValues.
            /// </summary>
            public CodonConverterIdentifierRow Parent { get; private set; }

            /// <summary>
            /// Constructs a CodonConverterIdentifierRowValues from a parent CodonConverterIdentifierRow.
            /// </summary>
            /// <param name="parent">The parent CodonConverterIdentifierRow whose values will be viewed and manipulated through this CodonConverterIdentifierRowValues.</param>
            public CodonConverterIdentifierRowValues(CodonConverterIdentifierRow parent)
            {
                this.Parent = parent;
            }
        }

        /// <summary>
        /// This property provides redundant access to the values of the underlying Row in this CodonConverterIdentifierRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterIdentifierRow.CodonConverterIdentifierRowValues Values { get; private set; }

        /// <summary>
        /// The StrongRowColumn where the value of PK_CodonConverterIdentifierID is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _pK_CodonConverterIdentifierIDColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of PK_CodonConverterIdentifierID is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn PK_CodonConverterIdentifierIDColumn
        {
            get
            {
                if (this._pK_CodonConverterIdentifierIDColumn == null)
                {
                    this.PK_CodonConverterIdentifierIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifier.PK_CodonConverterIdentifierID);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifier.PK_CodonConverterIdentifierID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_CodonConverterIdentifierID_ValueChanged);
                }

                return this._pK_CodonConverterIdentifierIDColumn;
            }
            private set { this._pK_CodonConverterIdentifierIDColumn = value; }
        }



        /// <summary>
        /// Raised when the value of PK_CodonConverterIdentifierID has changed.<para></para><para></para>This will only fire when the value of the property PK_CodonConverterIdentifierID is set. If the corresponding value is set through the underlying row or through the property PK_CodonConverterIdentifierIDColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.String>> PK_CodonConverterIdentifierIDChanged;

        /// <summary>
        /// When raised, indicates that the value of PK_CodonConverterIdentifierID has changed which fires the PK_CodonConverterIdentifierIDChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PK_CodonConverterIdentifierIDChanged event.</param>
        private void OnPK_CodonConverterIdentifierIDChanged(RowValueChangedEventArgs<System.String> e)
        {
            if (PK_CodonConverterIdentifierIDChanged != null)
                PK_CodonConverterIdentifierIDChanged(this, e);
        }



        /// <summary>
        /// The ID of a Codon Converter
        /// </summary>
        public System.String PK_CodonConverterIdentifierID
        {
            get
            {
                if (this.PK_CodonConverterIdentifierIDColumn.Value != null)
                    return this.PK_CodonConverterIdentifierIDColumn.Value.ToString();
                else
                    return null;
            }
            set
            {
                if (value == null)
                    throw new Exception("PK_CodonConverterIdentifierID cannot be null.");

                this.PK_CodonConverterIdentifierIDColumn.Value = value;
            }
        }

        /// <summary>
        /// Raises OnPK_CodonConverterIdentifierIDChanged when the value of PK_CodonConverterIdentifierID in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PK_CodonConverterIdentifierID_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasPK_CodonConverterIdentifierIDValueChanged = true;

            // Find the Foreign Key that refers to this Column (if there is any)
            var foreignKeyStrongRows = this.GetForeignKeyColumnsReferringToColumn(PK_CodonConverterIdentifierIDColumn);
            if (foreignKeyStrongRows != null)
                foreach (var foreignKeyStrongRow in foreignKeyStrongRows)
                    this.Parent.GetStrongRowColumn(foreignKeyStrongRow.ForeignKeyColumn).Value = e.NewValue;

            OnPK_CodonConverterIdentifierIDChanged(new RowValueChangedEventArgs<System.String>(e.PreviousValue.IsNullOrDBNull() ? null : e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : e.NewValue.ToString(), this.PK_CodonConverterIdentifierIDColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of PK_CodonConverterIdentifierID in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.PK_CodonConverterIdentifierID) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsPK_CodonConverterIdentifierIDNullOrEmpty
        {
            get { return this.PK_CodonConverterIdentifierIDColumn.Value.IsNullOrDBNull() || this.PK_CodonConverterIdentifierID == String.Empty; }
        }

        /// <summary>
        /// Indicates whether any value in this CodonConverterIdentifierRow that is not a Row (ForeignStrongRow or ForeignKeyStrongRow) is null or DBNull.Value or Empty. If false, all non-row values have values (i.e. are not null).
        /// </summary>
        public override bool IsAnyNonRowValueNullOrEmpty
        {
            get
            {
                if (this.IsPK_CodonConverterIdentifierIDNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Indicates whether the value of PK_CodonConverterIdentifierID has changed since either this CodonConverterIdentifierRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasPK_CodonConverterIdentifierIDValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether any Foreign StrongRow in this CodonConverterIdentifierRow is null or DBNull.Value or empty.
        /// </summary>
        public override bool IsAnyForeignRowNull
        {
            get { return false; }
        }

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow that stores the values of the ForeignKey Strong Row if it were joined to this CodonConverterIdentifierRow on the Foreign Key Column "CodonConverterIdentifier". This CodonConverterIdentifierRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Parameter_CodonConverterIdentifierRow ForeignKeyStrongRow.
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow _foreignKeyRow_Parameter_CodonConverterIdentifierRow;
        /// <summary>
        /// /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow that stores the values of the ForeignKey Strong Row if it were joined to this CodonConverterIdentifierRow on the Foreign Key Column "CodonConverterIdentifier". This CodonConverterIdentifierRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Parameter_CodonConverterIdentifierRow ForeignKeyStrongRow.
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow ForeignKeyRow_Parameter_CodonConverterIdentifierRow
        {
            get
            {
                if (this._foreignKeyRow_Parameter_CodonConverterIdentifierRow == null)
                {
                    this._foreignKeyRow_Parameter_CodonConverterIdentifierRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow();
                    this.InitializeForeignKeyRow_Parameter_CodonConverterIdentifierRow();
                }

                return _foreignKeyRow_Parameter_CodonConverterIdentifierRow;
            }
            set
            {
                var originalValue = this.ForeignKeyRow_Parameter_CodonConverterIdentifierRow;
                this._foreignKeyRow_Parameter_CodonConverterIdentifierRow = value;


                this.InitializeForeignKeyRow_Parameter_CodonConverterIdentifierRow();

                OnForeignKeyRow_Parameter_CodonConverterIdentifierRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier, this, RowValueType.ForeignKeyStrongRow));
            }
        }

        /// <summary>
        /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "CodonConverterIdentifier" that belongs to ForeignKey StrongRow "ForeignKeyRow_Parameter_CodonConverterIdentifierRow" (which is a different StrongRow than this CodonConverterIdentifierRow). This ForeignKeyToThisStrongRowColumn that can be used to join this CodonConverterIdentifierRow to the ForeignKeyStrongRow "ForeignKeyRow_Parameter_CodonConverterIdentifierRow.
        /// </summary>
        private ForeignKeyToThisStrongRowColumn _foreignKeyRow_Parameter_CodonConverterIdentifierRowColumn;
        /// <summary>
        /// /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "CodonConverterIdentifier" that belongs to ForeignKey StrongRow "ForeignKeyRow_Parameter_CodonConverterIdentifierRow" (which is a different StrongRow than this CodonConverterIdentifierRow). This ForeignKeyToThisStrongRowColumn that can be used to join this CodonConverterIdentifierRow to the ForeignKeyStrongRow "ForeignKeyRow_Parameter_CodonConverterIdentifierRow.
        /// /// </summary>
        public ForeignKeyToThisStrongRowColumn ForeignKeyRow_Parameter_CodonConverterIdentifierRowColumn
        {
            get
            {
                if (this._foreignKeyRow_Parameter_CodonConverterIdentifierRowColumn == null)
                    this.ForeignKeyRow_Parameter_CodonConverterIdentifierRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_Parameter_CodonConverterIdentifierRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier);

                return this._foreignKeyRow_Parameter_CodonConverterIdentifierRowColumn;
            }
            private set { this._foreignKeyRow_Parameter_CodonConverterIdentifierRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ForeignKeyRow_Parameter_CodonConverterIdentifierRow has changed (is NOT raised when a value inside ForeignKeyRow_Parameter_CodonConverterIdentifierRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow>> ForeignKeyRow_Parameter_CodonConverterIdentifierRowChanged;

        /// <summary>
        /// Indicates that the value of CodonConverterIdentifier has changed which fires the CodonConverterIdentifierChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ForeignKeyRow_Parameter_CodonConverterIdentifierRowChanged event.</param>
        private void OnForeignKeyRow_Parameter_CodonConverterIdentifierRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow> e)
        {
            if (ForeignKeyRow_Parameter_CodonConverterIdentifierRowChanged != null)
                ForeignKeyRow_Parameter_CodonConverterIdentifierRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignKeyStrongRow ForeignKeyRow_Parameter_CodonConverterIdentifierRow.
        /// </summary>
        private void SubscribeToValueChangesOfForeignKeyRow_Parameter_CodonConverterIdentifierRow()
        {
            if (this.ForeignKeyRow_Parameter_CodonConverterIdentifierRow != null)
                this.ForeignKeyRow_Parameter_CodonConverterIdentifierRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignKeyStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when setting the value of ForeignKeyRow_Parameter_CodonConverterIdentifierRow.
        /// </summary>
        private void InitializeForeignKeyRow_Parameter_CodonConverterIdentifierRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ForeignKeyRow_Parameter_CodonConverterIdentifierRow))
                this.OtherRowTableAliases.Remove(this.ForeignKeyRow_Parameter_CodonConverterIdentifierRow);

            this.ForeignKeyRow_Parameter_CodonConverterIdentifierRowColumn.ForeignKeyRow = this.ForeignKeyRow_Parameter_CodonConverterIdentifierRow;

            this.OtherRowTableAliases.Add(this.ForeignKeyRow_Parameter_CodonConverterIdentifierRow, "foreignKey_Parameter_CodonConverterIdentifier");
            this.ForeignKeyRow_Parameter_CodonConverterIdentifierRow.Parent = this;
            SubscribeToValueChangesOfForeignKeyRow_Parameter_CodonConverterIdentifierRow();
        }

        /// <summary>
        /// Indicates whether the value of the ForeignKeyRow_Parameter_CodonConverterIdentifierRow is null or DBNull.Value (does not Initialize the ForeignKeyRow_Parameter_CodonConverterIdentifierRow if it is currently null).
        /// </summary>
        public bool IsForeignKeyRow_Parameter_CodonConverterIdentifierRowNull
        {
            get { return this._foreignKeyRow_Parameter_CodonConverterIdentifierRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// Constructs an instance of this CodonConverterIdentifierRow from a specified Row.<para></para><para></para>NO STRONG ROW COLUMNS WILL BE INITIALIZED. This simply creates a wrapper around the Row in order to access the Row Values. It is helpful for performance.
        /// </summary>
        /// <param name="codonConverterIdentifierRow">The identifier of the Codon Converter.</param>
        public CodonConverterIdentifierRow(Row codonConverterIdentifierRow)
            : this()
        {
            this.Row = codonConverterIdentifierRow;
        }

        /// <summary>
        /// Constructs an instance of this CodonConverterIdentifierRow from a specified global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonConverterIdentifierRowSerializableContainer.
        /// </summary>
        /// <param name="codonConverterIdentifierRowSerializableContainer">The identifier of the Codon Converter.</param>
        public CodonConverterIdentifierRow(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonConverterIdentifierRowSerializableContainer codonConverterIdentifierRowSerializableContainer)
            : this()
        {
            this.Row = new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifierTable);

            this.PK_CodonConverterIdentifierID = codonConverterIdentifierRowSerializableContainer.PK_CodonConverterIdentifierID;
        }

        /// <summary>
        /// Constructs an instance of this CodonConverterIdentifierRow from a set of values for the Row.
        /// </summary>
        public CodonConverterIdentifierRow()
            : base(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifierTable)
        {
            if (this.Row != null)
                this.Row = global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifier.ToRow();
            this.Values = new CodonConverterIdentifierRowValues(this);
        }

        /// <summary>
        /// The TableDefinition of this CodonConverterIdentifierRow
        /// </summary>
        public override TableDefinition TableDefinition
        {
            get { return this.GetTableDefinition(); }
        }

        /// <summary>
        /// Gets the TableDefinition of this CodonConverterIdentifierRow
        /// </summary>
        public override TableDefinition GetTableDefinition()
        {
            return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifierTable;
        }

        /// <summary>
        /// The TableDefinition of this CodonConverterIdentifierRow
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.CodonConverterIdentifierTable CodonConverterIdentifierTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifierTable; }
        }

        /// <summary>
        /// Given a table alias (compressed or non-compressed), initializes the proper child StrongRow that has the given alias.
        /// </summary>
        /// <param name="tableAlias">The table alias (compressed or non-compressed) that will indicate which child StrongRow to initialize.</param>
        public override void InitializeChildStrongRowWithAlias(string tableAlias)
        {
            switch (tableAlias)
            {
                case "foreignKey_Parameter_CodonConverterIdentifier":
                    if (this._foreignKeyRow_Parameter_CodonConverterIdentifierRow == null)
                    {
                        this._foreignKeyRow_Parameter_CodonConverterIdentifierRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow();
                        this.InitializeForeignKeyRow_Parameter_CodonConverterIdentifierRow();
                    }
                    return;
                case "_PCCI45nia62":
                    if (this._foreignKeyRow_Parameter_CodonConverterIdentifierRow == null)
                    {
                        this._foreignKeyRow_Parameter_CodonConverterIdentifierRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow();
                        this.InitializeForeignKeyRow_Parameter_CodonConverterIdentifierRow();
                    }
                    return;
                default:
                    throw new Exception("The given table alias does not refer to any child StrongRow in this CodonConverterIdentifierRow.");
                    return;

            }
        }

        /// <summary>
        /// Initializes all of the Foreign Strong Rows and Foreign Key StrongRows in this CodonConverterIdentifierRow that are currently null. Calls the parameterless constructor for each Strong Row that is null.
        /// </summary>
        public override void InitializeChildStrongRows()
        {

            if (this.ForeignKeyRow_Parameter_CodonConverterIdentifierRow == null)
                this.ForeignKeyRow_Parameter_CodonConverterIdentifierRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.ParameterRow();
        }

        /// <summary>
        /// Initializes all of the StrongRowColumns in this CodonConverterIdentifierRow that are currently null. Also handles the necessary event subscriptions.
        /// </summary>
        public override void InitializeStrongRowColumns()
        {
            if (this.PK_CodonConverterIdentifierIDColumn == null)
            {
                this.PK_CodonConverterIdentifierIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifier.PK_CodonConverterIdentifierID);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifier.PK_CodonConverterIdentifierID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_CodonConverterIdentifierID_ValueChanged);
            }
        }

        /// <summary>
        /// Initializes all of the ForeignStrongRowColumns in this CodonConverterIdentifierRow that are null.
        /// </summary>
        public override void InitializeForeignStrongRowColumns()
        {

        }

        /// <summary>
        /// Initializes all of the ForeignKeyToThisStrongRowColumns in this CodonConverterIdentifierRow that are null.
        /// </summary>
        public override void InitializeForeignKeyToThisStrongRowColumns()
        {
            if (this.ForeignKeyRow_Parameter_CodonConverterIdentifierRowColumn == null)
                this.ForeignKeyRow_Parameter_CodonConverterIdentifierRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_Parameter_CodonConverterIdentifierRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Parameter.CodonConverterIdentifier);
        }

        /// <summary>
        /// Inserts the Row into the database immediately (if it is not currently in the database. This method first checks to ensure that the Row is not in the database). Returns true if the Row was inserted. Returns false if not. Out's the primary key.
        /// </summary>
        /// <param name="primaryKey">The ID of a Codon Converter</param>
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
        /// <param name="primaryKey">The ID of a Codon Converter</param>
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
        /// Indicates whether the Primary Key PK_CodonConverterIdentifierID is null or DBNull.Value or is an Empty value.
        /// </summary>
        public override bool IsPrimaryKeyNullOrEmpty
        {
            get { return this.IsPK_CodonConverterIdentifierIDNullOrEmpty; }
        }

        /// <summary>
        /// The Primary Key PK_CodonConverterIdentifierID for this CodonConverterIdentifier.
        /// </summary>
        public System.String PrimaryKey
        {
            get { return this.PK_CodonConverterIdentifierID; }
            set { this.PK_CodonConverterIdentifierID = value; }
        }

        /// <summary>
        /// The Primary Key Column for this CodonConverterIdentifier.
        /// </summary>
        public override StrongRowColumn PrimaryKeyColumn
        {
            get { return this.PK_CodonConverterIdentifierIDColumn; }
        }

        /// <summary>
        /// Returns all of the Columns in the CodonConverterIdentifierRow whose values have changed according to their HasChanged flags.
        /// </summary>
        public override List<Column> GetColumnsWithChangedValues()
        {
            // If no value in this row has changed then return an empty list.
            if (!this.HasAnyNonRowValueInRowChanged)
                return new List<Column>(0);

            // We will collect the columns whose values have changed.
            var columns = new List<Column>();

            if (HasPK_CodonConverterIdentifierIDValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifier.PK_CodonConverterIdentifierID);

            return columns;
        }

        /// <summary>
        /// Calls ResetAllHasAnyValueChangedFlags() for this CodonConverterIdentifierRow and ResetAllThisAndChildrenHasAnyValueChangedFlags() for all children Foreign StrongRows and Foreign Key Strong Rows that are not null.
        /// </summary>
        public override void ResetAllThisAndChildrenHasAnyValueChangedFlags()
        {
            this.ResetAllHasAnyValueChangedFlags();

            if (this._foreignKeyRow_Parameter_CodonConverterIdentifierRow != null)
                this.ForeignKeyRow_Parameter_CodonConverterIdentifierRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
        }

        /// <summary>
        /// Resets all of the HasAnyValuesChanged for each of the values in this CodonConverterIdentifierRow. Also calls the base.ResetAllHasAnyValueChangedFlags().
        /// </summary>
        public override void ResetAllHasAnyValueChangedFlags()
        {
            base.ResetAllHasAnyValueChangedFlags();

            this.HasPK_CodonConverterIdentifierIDValueChanged = false;
        }

        /// <summary>
        /// Gets all of the StrongRowColumns in this CodonConverterIdentifierRow.
        /// </summary>
        public override StrongRowColumn[] GetAllStrongRowColumns()
        {
            return new StrongRowColumn[] { PK_CodonConverterIdentifierIDColumn };
        }

        /// <summary>
        /// Gets all of the StrongRowForeignKeyColumns in this CodonConverterIdentifierRow.
        /// </summary>
        public override StrongRowForeignKeyColumn[] GetAllStrongRowForeignKeyColumns()
        {
            return new StrongRowForeignKeyColumn[] { };
        }

        /// <summary>
        /// Gets all of the ForeignKeyToThisStrongRowColumn in this CodonConverterIdentifierRow.
        /// </summary>
        public override ForeignKeyToThisStrongRowColumn[] GetAllForeignKeyToThisStrongRowColumns()
        {
            return new ForeignKeyToThisStrongRowColumn[] { ForeignKeyRow_Parameter_CodonConverterIdentifierRowColumn };
        }

        /// <summary>
        /// Converts the CodonConverterIdentifierRow to a CodonConverterIdentifierRowSerializableContainer.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonConverterIdentifierRowSerializableContainer ToCodonConverterIdentifierRowSerializableContainer()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonConverterIdentifierRowSerializableContainer(this);
        }

        /// <summary>
        /// Converts the StrongRow to the appropriate StrongRowSerializableContainer.
        /// </summary>
        public override StrongRowSerializableContainer ToStrongRowSerializableContainer()
        {
            return this.ToCodonConverterIdentifierRowSerializableContainer();
        }

        #region IStrongRowDescendant<T>
        /// <summary>
        /// Fills any empty values in this CodonConverterIdentifierRow with the corresponding values from the given CodonConverterIdentifierRow. Does NOT fill the Primary Key.
        /// </summary>
        /// <param name="sourceOfFilling">The CodonConverterIdentifierRow from which we will gather values in order to fill any empty values in this CodonConverterIdentifierRow.</param>
        public void FillEmptyValues(CodonConverterIdentifierRow sourceOfFilling)
        {
            if (sourceOfFilling == null)
                return;

        }

        /// <summary>
        /// This CodonConverterIdentifierRow used to fulfill the IStrongRowDescendent<T> contact.
        /// </summary>
        public CodonConverterIdentifierRow Self
        {
            get { return this; }
        }

        /// <summary>
        /// Creates a deep copy of the given other CodonConverterIdentifierRow. Fills this CodonConverterIdentifierRow with the values, Foreign StrongRows and ForeignKey StrongRows of the given other CodonConverterIdentifierRow. Fills each child row's children as well.
        /// </summary>
        /// <param name="other">The StrongRow from which values will be populated</param>
        public void PopulateFromRow(CodonConverterIdentifierRow other)
        {
            this.PK_CodonConverterIdentifierID = other.PK_CodonConverterIdentifierID;

            if (other._foreignKeyRow_Parameter_CodonConverterIdentifierRow != null)
            {
                var parameter_CodonConverterIdentifierRow = other.ForeignKeyRow_Parameter_CodonConverterIdentifierRow;
                this.ForeignKeyRow_Parameter_CodonConverterIdentifierRow.PopulateFromRow(parameter_CodonConverterIdentifierRow);
            }
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Gets the CodonConverterIdentifierRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the CodonConverterIdentifierRow</param>
        public static CodonConverterIdentifierRow GetCodonConverterIdentifierRowByID(object ID)
        {
            var codonConverterIdentifierRow = new CodonConverterIdentifierRow();
            Qry.SelectAllFrom(codonConverterIdentifierRow).Where(codonConverterIdentifierRow.PrimaryKeyColumn, ID).Go().ExtractStrongRow(ref codonConverterIdentifierRow);
            return codonConverterIdentifierRow;
        }

        /// <summary>
        /// Gets all of the CodonConverterIdentifierRows in the database.
        /// </summary>
        public static IEnumerable<CodonConverterIdentifierRow> GetAllCodonConverterIdentifierRows()
        {
            return Qry.SelectAllFrom(new CodonConverterIdentifierRow()).Go().ExtractStrongRows<CodonConverterIdentifierRow>();
        }
        #endregion

        #region StrongRow Overrides
        /// <summary>
        /// Gets the CodonConverterIdentifierRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the CodonConverterIdentifierRow</param>
        public override StrongRow GetByID(object ID)
        {
            return CodonConverterIdentifierRow.GetCodonConverterIdentifierRowByID(ID);
        }

        /// <summary>
        /// Gets all of the CodonConverterIdentifierRows in the database.
        /// </summary>
        public override IEnumerable<StrongRow> GetAll()
        {
            return CodonConverterIdentifierRow.GetAllCodonConverterIdentifierRows();
        }
        #endregion

        #region IRepository
        /// <summary>
        /// Gets the CodonConverterIdentifierRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the CodonConverterIdentifierRow</param>
        CodonConverterIdentifierRow IRepository<CodonConverterIdentifierRow>.GetByID(object ID)
        {
            return CodonConverterIdentifierRow.GetCodonConverterIdentifierRowByID(ID);
        }

        /// <summary>
        /// Gets all of the CodonConverterIdentifierRows in the database.
        /// </summary>
        IEnumerable<CodonConverterIdentifierRow> IRepository<CodonConverterIdentifierRow>.GetAll()
        {
            return CodonConverterIdentifierRow.GetAllCodonConverterIdentifierRows();
        }
        #endregion

        /// <summary>
        /// Validates all of the underlying enum values in this CodonConverterIdentifierRow. If there are any errors in the Enum Values, they will be registered with the given SenderIdentifier. Also validates the primary key since this StrongRow is an Enum.
        /// </summary>
        /// <param name="senderIdentifier">The SenderIdentifier used to register Errors in the enum values if any errors exist.</param>
        /// <param name="referenceNumberForErrors">The reference number that will be registered with any Errors.</param>
        public override void ValidateEnumValues(SenderIdentifier senderIdentifier, string referenceNumberForErrors)
        {
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifier.PK_CodonConverterIdentifierID].Value != null && !StrongEnums.CodonConverterIdentifier.IsValidEnum(this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifier.PK_CodonConverterIdentifierID].Value.ToString()))
            {
                senderIdentifier.RegisterError(new Error(referenceNumberForErrors, "Invalid Value for PK_CodonConverterIdentifierID. Value: " + this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterIdentifier.PK_CodonConverterIdentifierID].Value.ToString() + "."));
            }
        }
    }
}