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
    /// The type of a Codon.
    /// </summary>
    [Serializable]
    public sealed partial class CodonTypeRow : StrongRow, IRepository<CodonTypeRow>, IStrongRowDescendant<CodonTypeRow>
    {
        /// <summary>
        /// This class provides redundant access to the values of the underlying Row in a CodonTypeRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        [Serializable]
        public sealed partial class CodonTypeRowValues
        {
            /// <summary>
            /// PK_CodonTypeID varchar(20) UNIQUE PRIMARY KEY,
            /// </summary>
            public System.String PK_CodonTypeID
            {
                get { return this.Parent.PK_CodonTypeID; }
                set { this.Parent.PK_CodonTypeID = value; }
            }

            /// <summary>
            /// PK_CodonTypeID varchar(20) UNIQUE PRIMARY KEY,
            /// </summary>
            public System.String PrimaryKey
            {
                get { return this.PK_CodonTypeID; }
                set { this.PK_CodonTypeID = value; }
            }

            /// <summary>
            /// The parent CodonTypeRow whose values will be viewed and manipulated through this CodonTypeRowValues.
            /// </summary>
            public CodonTypeRow Parent { get; private set; }

            /// <summary>
            /// Constructs a CodonTypeRowValues from a parent CodonTypeRow.
            /// </summary>
            /// <param name="parent">The parent CodonTypeRow whose values will be viewed and manipulated through this CodonTypeRowValues.</param>
            public CodonTypeRowValues(CodonTypeRow parent)
            {
                this.Parent = parent;
            }
        }

        /// <summary>
        /// This property provides redundant access to the values of the underlying Row in this CodonTypeRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow.CodonTypeRowValues Values { get; private set; }

        /// <summary>
        /// The StrongRowColumn where the value of PK_CodonTypeID is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _pK_CodonTypeIDColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of PK_CodonTypeID is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn PK_CodonTypeIDColumn
        {
            get
            {
                if (this._pK_CodonTypeIDColumn == null)
                {
                    this.PK_CodonTypeIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonType.PK_CodonTypeID);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonType.PK_CodonTypeID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_CodonTypeID_ValueChanged);
                }

                return this._pK_CodonTypeIDColumn;
            }
            private set { this._pK_CodonTypeIDColumn = value; }
        }



        /// <summary>
        /// Raised when the value of PK_CodonTypeID has changed.<para></para><para></para>This will only fire when the value of the property PK_CodonTypeID is set. If the corresponding value is set through the underlying row or through the property PK_CodonTypeIDColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.String>> PK_CodonTypeIDChanged;

        /// <summary>
        /// When raised, indicates that the value of PK_CodonTypeID has changed which fires the PK_CodonTypeIDChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PK_CodonTypeIDChanged event.</param>
        private void OnPK_CodonTypeIDChanged(RowValueChangedEventArgs<System.String> e)
        {
            if (PK_CodonTypeIDChanged != null)
                PK_CodonTypeIDChanged(this, e);
        }



        /// <summary>
        /// PK_CodonTypeID varchar(20) UNIQUE PRIMARY KEY,
        /// </summary>
        public System.String PK_CodonTypeID
        {
            get
            {
                if (this.PK_CodonTypeIDColumn.Value != null)
                    return this.PK_CodonTypeIDColumn.Value.ToString();
                else
                    return null;
            }
            set
            {
                if (value == null)
                    throw new Exception("PK_CodonTypeID cannot be null.");

                this.PK_CodonTypeIDColumn.Value = value;
            }
        }

        /// <summary>
        /// Raises OnPK_CodonTypeIDChanged when the value of PK_CodonTypeID in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PK_CodonTypeID_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasPK_CodonTypeIDValueChanged = true;

            // Find the Foreign Key that refers to this Column (if there is any)
            var foreignKeyStrongRows = this.GetForeignKeyColumnsReferringToColumn(PK_CodonTypeIDColumn);
            if (foreignKeyStrongRows != null)
                foreach (var foreignKeyStrongRow in foreignKeyStrongRows)
                    this.Parent.GetStrongRowColumn(foreignKeyStrongRow.ForeignKeyColumn).Value = e.NewValue;

            OnPK_CodonTypeIDChanged(new RowValueChangedEventArgs<System.String>(e.PreviousValue.IsNullOrDBNull() ? null : e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : e.NewValue.ToString(), this.PK_CodonTypeIDColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of PK_CodonTypeID in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.PK_CodonTypeID) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsPK_CodonTypeIDNullOrEmpty
        {
            get { return this.PK_CodonTypeIDColumn.Value.IsNullOrDBNull() || this.PK_CodonTypeID == String.Empty; }
        }

        /// <summary>
        /// Indicates whether any value in this CodonTypeRow that is not a Row (ForeignStrongRow or ForeignKeyStrongRow) is null or DBNull.Value or Empty. If false, all non-row values have values (i.e. are not null).
        /// </summary>
        public override bool IsAnyNonRowValueNullOrEmpty
        {
            get
            {
                if (this.IsPK_CodonTypeIDNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Indicates whether the value of PK_CodonTypeID has changed since either this CodonTypeRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasPK_CodonTypeIDValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether any Foreign StrongRow in this CodonTypeRow is null or DBNull.Value or empty.
        /// </summary>
        public override bool IsAnyForeignRowNull
        {
            get { return false; }
        }

        /// <summary>
        /// Constructs an instance of this CodonTypeRow from a specified Row.<para></para><para></para>NO STRONG ROW COLUMNS WILL BE INITIALIZED. This simply creates a wrapper around the Row in order to access the Row Values. It is helpful for performance.
        /// </summary>
        /// <param name="codonTypeRow">The type of a Codon.</param>
        public CodonTypeRow(Row codonTypeRow)
            : this()
        {
            this.Row = codonTypeRow;
        }

        /// <summary>
        /// Constructs an instance of this CodonTypeRow from a specified global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonTypeRowSerializableContainer.
        /// </summary>
        /// <param name="codonTypeRowSerializableContainer">The type of a Codon.</param>
        public CodonTypeRow(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonTypeRowSerializableContainer codonTypeRowSerializableContainer)
            : this()
        {
            this.Row = new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTypeTable);

            this.PK_CodonTypeID = codonTypeRowSerializableContainer.PK_CodonTypeID;
        }

        /// <summary>
        /// Constructs an instance of this CodonTypeRow from a set of values for the Row.
        /// </summary>
        public CodonTypeRow()
            : base(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTypeTable)
        {
            if (this.Row != null)
                this.Row = global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonType.ToRow();
            this.Values = new CodonTypeRowValues(this);
        }

        /// <summary>
        /// The TableDefinition of this CodonTypeRow
        /// </summary>
        public override TableDefinition TableDefinition
        {
            get { return this.GetTableDefinition(); }
        }

        /// <summary>
        /// Gets the TableDefinition of this CodonTypeRow
        /// </summary>
        public override TableDefinition GetTableDefinition()
        {
            return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTypeTable;
        }

        /// <summary>
        /// The TableDefinition of this CodonTypeRow
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.CodonTypeTable CodonTypeTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTypeTable; }
        }

        /// <summary>
        /// Given a table alias (compressed or non-compressed), initializes the proper child StrongRow that has the given alias.
        /// </summary>
        /// <param name="tableAlias">The table alias (compressed or non-compressed) that will indicate which child StrongRow to initialize.</param>
        public override void InitializeChildStrongRowWithAlias(string tableAlias)
        {
            switch (tableAlias)
            {
                default:
                    throw new Exception("The given table alias does not refer to any child StrongRow in this CodonTypeRow.");
                    return;

            }
        }

        /// <summary>
        /// Initializes all of the Foreign Strong Rows and Foreign Key StrongRows in this CodonTypeRow that are currently null. Calls the parameterless constructor for each Strong Row that is null.
        /// </summary>
        public override void InitializeChildStrongRows()
        {

        }

        /// <summary>
        /// Initializes all of the StrongRowColumns in this CodonTypeRow that are currently null. Also handles the necessary event subscriptions.
        /// </summary>
        public override void InitializeStrongRowColumns()
        {
            if (this.PK_CodonTypeIDColumn == null)
            {
                this.PK_CodonTypeIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonType.PK_CodonTypeID);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonType.PK_CodonTypeID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_CodonTypeID_ValueChanged);
            }
        }

        /// <summary>
        /// Initializes all of the ForeignStrongRowColumns in this CodonTypeRow that are null.
        /// </summary>
        public override void InitializeForeignStrongRowColumns()
        {

        }

        /// <summary>
        /// Initializes all of the ForeignKeyToThisStrongRowColumns in this CodonTypeRow that are null.
        /// </summary>
        public override void InitializeForeignKeyToThisStrongRowColumns()
        {

        }

        /// <summary>
        /// Inserts the Row into the database immediately (if it is not currently in the database. This method first checks to ensure that the Row is not in the database). Returns true if the Row was inserted. Returns false if not. Out's the primary key.
        /// </summary>
        /// <param name="primaryKey">PK_CodonTypeID varchar(20) UNIQUE PRIMARY KEY,</param>
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
        /// <param name="primaryKey">PK_CodonTypeID varchar(20) UNIQUE PRIMARY KEY,</param>
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
        /// Indicates whether the Primary Key PK_CodonTypeID is null or DBNull.Value or is an Empty value.
        /// </summary>
        public override bool IsPrimaryKeyNullOrEmpty
        {
            get { return this.IsPK_CodonTypeIDNullOrEmpty; }
        }

        /// <summary>
        /// The Primary Key PK_CodonTypeID for this CodonType.
        /// </summary>
        public System.String PrimaryKey
        {
            get { return this.PK_CodonTypeID; }
            set { this.PK_CodonTypeID = value; }
        }

        /// <summary>
        /// The Primary Key Column for this CodonType.
        /// </summary>
        public override StrongRowColumn PrimaryKeyColumn
        {
            get { return this.PK_CodonTypeIDColumn; }
        }

        /// <summary>
        /// Returns all of the Columns in the CodonTypeRow whose values have changed according to their HasChanged flags.
        /// </summary>
        public override List<Column> GetColumnsWithChangedValues()
        {
            // If no value in this row has changed then return an empty list.
            if (!this.HasAnyNonRowValueInRowChanged)
                return new List<Column>(0);

            // We will collect the columns whose values have changed.
            var columns = new List<Column>();

            if (HasPK_CodonTypeIDValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonType.PK_CodonTypeID);

            return columns;
        }

        /// <summary>
        /// Calls ResetAllHasAnyValueChangedFlags() for this CodonTypeRow and ResetAllThisAndChildrenHasAnyValueChangedFlags() for all children Foreign StrongRows and Foreign Key Strong Rows that are not null.
        /// </summary>
        public override void ResetAllThisAndChildrenHasAnyValueChangedFlags()
        {
            this.ResetAllHasAnyValueChangedFlags();

        }

        /// <summary>
        /// Resets all of the HasAnyValuesChanged for each of the values in this CodonTypeRow. Also calls the base.ResetAllHasAnyValueChangedFlags().
        /// </summary>
        public override void ResetAllHasAnyValueChangedFlags()
        {
            base.ResetAllHasAnyValueChangedFlags();

            this.HasPK_CodonTypeIDValueChanged = false;
        }

        /// <summary>
        /// Gets all of the StrongRowColumns in this CodonTypeRow.
        /// </summary>
        public override StrongRowColumn[] GetAllStrongRowColumns()
        {
            return new StrongRowColumn[] { PK_CodonTypeIDColumn };
        }

        /// <summary>
        /// Gets all of the StrongRowForeignKeyColumns in this CodonTypeRow.
        /// </summary>
        public override StrongRowForeignKeyColumn[] GetAllStrongRowForeignKeyColumns()
        {
            return new StrongRowForeignKeyColumn[] { };
        }

        /// <summary>
        /// Gets all of the ForeignKeyToThisStrongRowColumn in this CodonTypeRow.
        /// </summary>
        public override ForeignKeyToThisStrongRowColumn[] GetAllForeignKeyToThisStrongRowColumns()
        {
            return new ForeignKeyToThisStrongRowColumn[] { };
        }

        /// <summary>
        /// Converts the CodonTypeRow to a CodonTypeRowSerializableContainer.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonTypeRowSerializableContainer ToCodonTypeRowSerializableContainer()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonTypeRowSerializableContainer(this);
        }

        /// <summary>
        /// Converts the StrongRow to the appropriate StrongRowSerializableContainer.
        /// </summary>
        public override StrongRowSerializableContainer ToStrongRowSerializableContainer()
        {
            return this.ToCodonTypeRowSerializableContainer();
        }

        #region IStrongRowDescendant<T>
        /// <summary>
        /// Fills any empty values in this CodonTypeRow with the corresponding values from the given CodonTypeRow. Does NOT fill the Primary Key.
        /// </summary>
        /// <param name="sourceOfFilling">The CodonTypeRow from which we will gather values in order to fill any empty values in this CodonTypeRow.</param>
        public void FillEmptyValues(CodonTypeRow sourceOfFilling)
        {
            if (sourceOfFilling == null)
                return;

        }

        /// <summary>
        /// This CodonTypeRow used to fulfill the IStrongRowDescendent<T> contact.
        /// </summary>
        public CodonTypeRow Self
        {
            get { return this; }
        }

        /// <summary>
        /// Creates a deep copy of the given other CodonTypeRow. Fills this CodonTypeRow with the values, Foreign StrongRows and ForeignKey StrongRows of the given other CodonTypeRow. Fills each child row's children as well.
        /// </summary>
        /// <param name="other">The StrongRow from which values will be populated</param>
        public void PopulateFromRow(CodonTypeRow other)
        {
            this.PK_CodonTypeID = other.PK_CodonTypeID;

        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Gets the CodonTypeRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the CodonTypeRow</param>
        public static CodonTypeRow GetCodonTypeRowByID(object ID)
        {
            var codonTypeRow = new CodonTypeRow();
            Qry.SelectAllFrom(codonTypeRow).Where(codonTypeRow.PrimaryKeyColumn, ID).Go().ExtractStrongRow(ref codonTypeRow);
            return codonTypeRow;
        }

        /// <summary>
        /// Gets all of the CodonTypeRows in the database.
        /// </summary>
        public static IEnumerable<CodonTypeRow> GetAllCodonTypeRows()
        {
            return Qry.SelectAllFrom(new CodonTypeRow()).Go().ExtractStrongRows<CodonTypeRow>();
        }
        #endregion

        #region StrongRow Overrides
        /// <summary>
        /// Gets the CodonTypeRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the CodonTypeRow</param>
        public override StrongRow GetByID(object ID)
        {
            return CodonTypeRow.GetCodonTypeRowByID(ID);
        }

        /// <summary>
        /// Gets all of the CodonTypeRows in the database.
        /// </summary>
        public override IEnumerable<StrongRow> GetAll()
        {
            return CodonTypeRow.GetAllCodonTypeRows();
        }
        #endregion

        #region IRepository
        /// <summary>
        /// Gets the CodonTypeRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the CodonTypeRow</param>
        CodonTypeRow IRepository<CodonTypeRow>.GetByID(object ID)
        {
            return CodonTypeRow.GetCodonTypeRowByID(ID);
        }

        /// <summary>
        /// Gets all of the CodonTypeRows in the database.
        /// </summary>
        IEnumerable<CodonTypeRow> IRepository<CodonTypeRow>.GetAll()
        {
            return CodonTypeRow.GetAllCodonTypeRows();
        }
        #endregion

        /// <summary>
        /// Validates all of the underlying enum values in this CodonTypeRow. If there are any errors in the Enum Values, they will be registered with the given SenderIdentifier. Also validates the primary key since this StrongRow is an Enum.
        /// </summary>
        /// <param name="senderIdentifier">The SenderIdentifier used to register Errors in the enum values if any errors exist.</param>
        /// <param name="referenceNumberForErrors">The reference number that will be registered with any Errors.</param>
        public override void ValidateEnumValues(SenderIdentifier senderIdentifier, string referenceNumberForErrors)
        {
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonType.PK_CodonTypeID].Value != null && !StrongEnums.CodonType.IsValidEnum(this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonType.PK_CodonTypeID].Value.ToString()))
            {
                senderIdentifier.RegisterError(new Error(referenceNumberForErrors, "Invalid Value for PK_CodonTypeID. Value: " + this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonType.PK_CodonTypeID].Value.ToString() + "."));
            }
        }
    }
}