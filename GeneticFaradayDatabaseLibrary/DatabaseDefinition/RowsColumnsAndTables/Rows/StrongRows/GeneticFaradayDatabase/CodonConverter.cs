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
    /// Converts a Codon.
    /// </summary>
    [Serializable]
    public sealed partial class CodonConverterRow : StrongRow, IRepository<CodonConverterRow>, IStrongRowDescendant<CodonConverterRow>
    {
        /// <summary>
        /// This class provides redundant access to the values of the underlying Row in a CodonConverterRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        [Serializable]
        public sealed partial class CodonConverterRowValues
        {
            /// <summary>
            /// PK_CodonConverterID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PK_CodonConverterID
            {
                get { return this.Parent.PK_CodonConverterID; }
                set { this.Parent.PK_CodonConverterID = value; }
            }

            /// <summary>
            /// The CodonConverterIdentifier of the Codon Converter.
            /// </summary>
            public System.String CodonConverterIdentifier
            {
                get { return this.Parent.CodonConverterIdentifier; }
                set { this.Parent.CodonConverterIdentifier = value; }
            }

            /// <summary>
            /// The GeneticCode to which this CodonConverter applies.
            /// </summary>
            public System.Int32 GeneticCode
            {
                get { return this.Parent.GeneticCode; }
                set { this.Parent.GeneticCode = value; }
            }

            /// <summary>
            /// PK_CodonConverterID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PrimaryKey
            {
                get { return this.PK_CodonConverterID; }
                set { this.PK_CodonConverterID = value; }
            }

            /// <summary>
            /// The parent CodonConverterRow whose values will be viewed and manipulated through this CodonConverterRowValues.
            /// </summary>
            public CodonConverterRow Parent { get; private set; }

            /// <summary>
            /// Constructs a CodonConverterRowValues from a parent CodonConverterRow.
            /// </summary>
            /// <param name="parent">The parent CodonConverterRow whose values will be viewed and manipulated through this CodonConverterRowValues.</param>
            public CodonConverterRowValues(CodonConverterRow parent)
            {
                this.Parent = parent;
            }
        }

        /// <summary>
        /// This property provides redundant access to the values of the underlying Row in this CodonConverterRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow.CodonConverterRowValues Values { get; private set; }

        /// <summary>
        /// The StrongRowColumn where the value of PK_CodonConverterID is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _pK_CodonConverterIDColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of PK_CodonConverterID is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn PK_CodonConverterIDColumn
        {
            get
            {
                if (this._pK_CodonConverterIDColumn == null)
                {
                    this.PK_CodonConverterIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.PK_CodonConverterID);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.PK_CodonConverterID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_CodonConverterID_ValueChanged);
                }

                return this._pK_CodonConverterIDColumn;
            }
            private set { this._pK_CodonConverterIDColumn = value; }
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
                    this.CodonConverterIdentifierColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.CodonConverterIdentifier);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.CodonConverterIdentifier].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(CodonConverterIdentifier_ValueChanged);
                }

                return this._codonConverterIdentifierColumn;
            }
            private set { this._codonConverterIdentifierColumn = value; }
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
                    this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.GeneticCode);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
                }

                return this._geneticCodeColumn;
            }
            private set { this._geneticCodeColumn = value; }
        }



        /// <summary>
        /// Raised when the value of PK_CodonConverterID has changed.<para></para><para></para>This will only fire when the value of the property PK_CodonConverterID is set. If the corresponding value is set through the underlying row or through the property PK_CodonConverterIDColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> PK_CodonConverterIDChanged;

        /// <summary>
        /// When raised, indicates that the value of PK_CodonConverterID has changed which fires the PK_CodonConverterIDChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PK_CodonConverterIDChanged event.</param>
        private void OnPK_CodonConverterIDChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (PK_CodonConverterIDChanged != null)
                PK_CodonConverterIDChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of CodonConverterIdentifier has changed.<para></para><para></para>This will only fire when the value of the property CodonConverterIdentifier is set. If the corresponding value is set through the underlying row or through the property CodonConverterIdentifierColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.String>> CodonConverterIdentifierChanged;

        /// <summary>
        /// When raised, indicates that the value of CodonConverterIdentifier has changed which fires the CodonConverterIdentifierChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the CodonConverterIdentifierChanged event.</param>
        private void OnCodonConverterIdentifierChanged(RowValueChangedEventArgs<System.String> e)
        {
            if (CodonConverterIdentifierChanged != null)
                CodonConverterIdentifierChanged(this, e);
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
        /// PK_CodonConverterID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public System.Int32 PK_CodonConverterID
        {
            get { return this.PK_CodonConverterIDColumn.Value.ToInt(); }
            set { this.PK_CodonConverterIDColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnPK_CodonConverterIDChanged when the value of PK_CodonConverterID in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PK_CodonConverterID_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasPK_CodonConverterIDValueChanged = true;

            // Find the Foreign Key that refers to this Column (if there is any)
            var foreignKeyStrongRows = this.GetForeignKeyColumnsReferringToColumn(PK_CodonConverterIDColumn);
            if (foreignKeyStrongRows != null)
                foreach (var foreignKeyStrongRow in foreignKeyStrongRows)
                    this.Parent.GetStrongRowColumn(foreignKeyStrongRow.ForeignKeyColumn).Value = e.NewValue;

            OnPK_CodonConverterIDChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.PK_CodonConverterIDColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of PK_CodonConverterID in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.PK_CodonConverterID) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsPK_CodonConverterIDNullOrEmpty
        {
            get { return this.PK_CodonConverterIDColumn.Value.IsNullOrDBNull() || this.PK_CodonConverterID == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets PK_CodonConverterID as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PK_CodonConverterIDNullable
        {
            get { return IsPK_CodonConverterIDNullOrEmpty ? null as System.Int32? : this.PK_CodonConverterID; }
        }

        /// <summary>
        /// The CodonConverterIdentifier of the Codon Converter.
        /// </summary>
        public System.String CodonConverterIdentifier
        {
            get
            {
                if (this.CodonConverterIdentifierColumn.Value != null)
                    return this.CodonConverterIdentifierColumn.Value.ToString();
                else
                    return null;
            }
            set
            {
                if (value == null)
                    throw new Exception("CodonConverterIdentifier cannot be null.");

                this.CodonConverterIdentifierColumn.Value = value;
            }
        }

        /// <summary>
        /// Raises OnCodonConverterIdentifierChanged when the value of CodonConverterIdentifier in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CodonConverterIdentifier_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasCodonConverterIdentifierValueChanged = true;

            OnCodonConverterIdentifierChanged(new RowValueChangedEventArgs<System.String>(e.PreviousValue.IsNullOrDBNull() ? null : e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : e.NewValue.ToString(), this.CodonConverterIdentifierColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of CodonConverterIdentifier in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.CodonConverterIdentifier) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsCodonConverterIdentifierNullOrEmpty
        {
            get { return this.CodonConverterIdentifierColumn.Value.IsNullOrDBNull() || this.CodonConverterIdentifier == String.Empty; }
        }

        /// <summary>
        /// The GeneticCode to which this CodonConverter applies.
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
        /// Indicates whether any value in this CodonConverterRow that is not a Row (ForeignStrongRow or ForeignKeyStrongRow) is null or DBNull.Value or Empty. If false, all non-row values have values (i.e. are not null).
        /// </summary>
        public override bool IsAnyNonRowValueNullOrEmpty
        {
            get
            {
                if (this.IsPK_CodonConverterIDNullOrEmpty)
                    return true;
                if (this.IsCodonConverterIdentifierNullOrEmpty)
                    return true;
                if (this.IsGeneticCodeNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Indicates whether the value of PK_CodonConverterID has changed since either this CodonConverterRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasPK_CodonConverterIDValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of CodonConverterIdentifier has changed since either this CodonConverterRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasCodonConverterIdentifierValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of GeneticCode has changed since either this CodonConverterRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasGeneticCodeValueChanged { get; private set; }

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

                OnGeneticCodeRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.GeneticCode, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.GeneticCode, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this CodonConverterRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this CodonConverterRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// </summary>
        private StrongRowForeignKeyColumn _geneticCodeRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this CodonConverterRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this CodonConverterRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn GeneticCodeRowColumn
        {
            get
            {
                if (this._geneticCodeRowColumn == null)
                    this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.GeneticCode);

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
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.GeneticCode].Value.IsInt() && this.GeneticCode != null)
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
        /// Indicates whether any Foreign StrongRow in this CodonConverterRow is null or DBNull.Value or empty.
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
        /// Constructs an instance of this CodonConverterRow from a specified Row.<para></para><para></para>NO STRONG ROW COLUMNS WILL BE INITIALIZED. This simply creates a wrapper around the Row in order to access the Row Values. It is helpful for performance.
        /// </summary>
        /// <param name="codonConverterRow">Converts a Codon.</param>
        public CodonConverterRow(Row codonConverterRow)
            : this()
        {
            this.Row = codonConverterRow;
        }

        /// <summary>
        /// Constructs an instance of this CodonConverterRow from a specified global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonConverterRowSerializableContainer.
        /// </summary>
        /// <param name="codonConverterRowSerializableContainer">Converts a Codon.</param>
        public CodonConverterRow(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonConverterRowSerializableContainer codonConverterRowSerializableContainer)
            : this()
        {
            this.Row = new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterTable);

            this.PK_CodonConverterID = codonConverterRowSerializableContainer.PK_CodonConverterID;
            this.CodonConverterIdentifier = codonConverterRowSerializableContainer.CodonConverterIdentifier;
            this.GeneticCode = codonConverterRowSerializableContainer.GeneticCode;
            if (codonConverterRowSerializableContainer.GeneticCodeRowSerializableContainer != null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow(codonConverterRowSerializableContainer.GeneticCodeRowSerializableContainer);
        }

        /// <summary>
        /// Constructs an instance of this CodonConverterRow from a set of values for the Row.
        /// </summary>
        /// <param name="codonConverterIdentifier">The CodonConverterIdentifier of the Codon Converter.</param>
        /// <param name="geneticCode">The GeneticCode to which this CodonConverter applies.</param>
        /// <param name="geneticCodeRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow that holds the values of the row that the foreign key "GeneticCode" is referencing. Row Description: Converts a Codon.</param>
        public CodonConverterRow(System.String codonConverterIdentifier, System.Int32 geneticCode, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow geneticCodeRow = null)
            : this()
        {
            if (this.Row != null)
                this.Row = global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.ToRow(codonConverterIdentifier: codonConverterIdentifier, geneticCode: geneticCode);
            this.GeneticCodeRow = geneticCodeRow;
        }

        /// <summary>
        /// Constructs an instance of a CodonConverterRow
        /// </summary>
        public CodonConverterRow()
            : base(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterTable)
        {
            this.Values = new CodonConverterRowValues(this);
        }

        /// <summary>
        /// The TableDefinition of this CodonConverterRow
        /// </summary>
        public override TableDefinition TableDefinition
        {
            get { return this.GetTableDefinition(); }
        }

        /// <summary>
        /// Gets the TableDefinition of this CodonConverterRow
        /// </summary>
        public override TableDefinition GetTableDefinition()
        {
            return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterTable;
        }

        /// <summary>
        /// The TableDefinition of this CodonConverterRow
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.CodonConverterTable CodonConverterTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverterTable; }
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
                default:
                    throw new Exception("The given table alias does not refer to any child StrongRow in this CodonConverterRow.");
                    return;

            }
        }

        /// <summary>
        /// Initializes all of the Foreign Strong Rows and Foreign Key StrongRows in this CodonConverterRow that are currently null. Calls the parameterless constructor for each Strong Row that is null.
        /// </summary>
        public override void InitializeChildStrongRows()
        {
            if (this.GeneticCodeRow == null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow();

        }

        /// <summary>
        /// Initializes all of the StrongRowColumns in this CodonConverterRow that are currently null. Also handles the necessary event subscriptions.
        /// </summary>
        public override void InitializeStrongRowColumns()
        {
            if (this.PK_CodonConverterIDColumn == null)
            {
                this.PK_CodonConverterIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.PK_CodonConverterID);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.PK_CodonConverterID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_CodonConverterID_ValueChanged);
            }
            if (this.CodonConverterIdentifierColumn == null)
            {
                this.CodonConverterIdentifierColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.CodonConverterIdentifier);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.CodonConverterIdentifier].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(CodonConverterIdentifier_ValueChanged);
            }
            if (this.GeneticCodeColumn == null)
            {
                this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.GeneticCode);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
            }
        }

        /// <summary>
        /// Initializes all of the ForeignStrongRowColumns in this CodonConverterRow that are null.
        /// </summary>
        public override void InitializeForeignStrongRowColumns()
        {
            if (this.GeneticCodeRowColumn == null)
                this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.GeneticCode);
        }

        /// <summary>
        /// Initializes all of the ForeignKeyToThisStrongRowColumns in this CodonConverterRow that are null.
        /// </summary>
        public override void InitializeForeignKeyToThisStrongRowColumns()
        {

        }

        /// <summary>
        /// Inserts the Row into the database immediately (if it is not currently in the database. This method first checks to ensure that the Row is not in the database). Returns true if the Row was inserted. Returns false if not. Out's the primary key.
        /// </summary>
        /// <param name="primaryKey">PK_CodonConverterID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// <param name="primaryKey">PK_CodonConverterID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// Indicates whether the Primary Key PK_CodonConverterID is null or DBNull.Value or is an Empty value.
        /// </summary>
        public override bool IsPrimaryKeyNullOrEmpty
        {
            get { return this.IsPK_CodonConverterIDNullOrEmpty; }
        }

        /// <summary>
        /// The Primary Key PK_CodonConverterID for this CodonConverter.
        /// </summary>
        public System.Int32 PrimaryKey
        {
            get { return this.PK_CodonConverterID; }
            set { this.PK_CodonConverterID = value; }
        }

        /// <summary>
        /// The Primary Key Column for this CodonConverter.
        /// </summary>
        public override StrongRowColumn PrimaryKeyColumn
        {
            get { return this.PK_CodonConverterIDColumn; }
        }

        /// <summary>
        /// Gets the Primary Key as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PrimaryKeyNullable
        {
            get { return this.IsPrimaryKeyNullOrEmpty ? null as System.Int32? : this.PrimaryKey; }
        }

        /// <summary>
        /// Returns all of the Columns in the CodonConverterRow whose values have changed according to their HasChanged flags.
        /// </summary>
        public override List<Column> GetColumnsWithChangedValues()
        {
            // If no value in this row has changed then return an empty list.
            if (!this.HasAnyNonRowValueInRowChanged)
                return new List<Column>(0);

            // We will collect the columns whose values have changed.
            var columns = new List<Column>();

            if (HasPK_CodonConverterIDValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.PK_CodonConverterID);
            if (HasCodonConverterIdentifierValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.CodonConverterIdentifier);
            if (HasGeneticCodeValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.GeneticCode);

            return columns;
        }

        /// <summary>
        /// Calls ResetAllHasAnyValueChangedFlags() for this CodonConverterRow and ResetAllThisAndChildrenHasAnyValueChangedFlags() for all children Foreign StrongRows and Foreign Key Strong Rows that are not null.
        /// </summary>
        public override void ResetAllThisAndChildrenHasAnyValueChangedFlags()
        {
            this.ResetAllHasAnyValueChangedFlags();

            if (this._geneticCodeRow != null)
                this.GeneticCodeRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
        }

        /// <summary>
        /// Resets all of the HasAnyValuesChanged for each of the values in this CodonConverterRow. Also calls the base.ResetAllHasAnyValueChangedFlags().
        /// </summary>
        public override void ResetAllHasAnyValueChangedFlags()
        {
            base.ResetAllHasAnyValueChangedFlags();

            this.HasPK_CodonConverterIDValueChanged = false;
            this.HasCodonConverterIdentifierValueChanged = false;
            this.HasGeneticCodeValueChanged = false;
        }

        /// <summary>
        /// Gets all of the StrongRowColumns in this CodonConverterRow.
        /// </summary>
        public override StrongRowColumn[] GetAllStrongRowColumns()
        {
            return new StrongRowColumn[] { PK_CodonConverterIDColumn, CodonConverterIdentifierColumn, GeneticCodeColumn };
        }

        /// <summary>
        /// Gets all of the StrongRowForeignKeyColumns in this CodonConverterRow.
        /// </summary>
        public override StrongRowForeignKeyColumn[] GetAllStrongRowForeignKeyColumns()
        {
            return new StrongRowForeignKeyColumn[] { GeneticCodeRowColumn };
        }

        /// <summary>
        /// Gets all of the ForeignKeyToThisStrongRowColumn in this CodonConverterRow.
        /// </summary>
        public override ForeignKeyToThisStrongRowColumn[] GetAllForeignKeyToThisStrongRowColumns()
        {
            return new ForeignKeyToThisStrongRowColumn[] { };
        }

        /// <summary>
        /// Converts the CodonConverterRow to a CodonConverterRowSerializableContainer.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonConverterRowSerializableContainer ToCodonConverterRowSerializableContainer()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonConverterRowSerializableContainer(this);
        }

        /// <summary>
        /// Converts the StrongRow to the appropriate StrongRowSerializableContainer.
        /// </summary>
        public override StrongRowSerializableContainer ToStrongRowSerializableContainer()
        {
            return this.ToCodonConverterRowSerializableContainer();
        }

        #region IStrongRowDescendant<T>
        /// <summary>
        /// Fills any empty values in this CodonConverterRow with the corresponding values from the given CodonConverterRow. Does NOT fill the Primary Key.
        /// </summary>
        /// <param name="sourceOfFilling">The CodonConverterRow from which we will gather values in order to fill any empty values in this CodonConverterRow.</param>
        public void FillEmptyValues(CodonConverterRow sourceOfFilling)
        {
            if (sourceOfFilling == null)
                return;

            if (this.IsCodonConverterIdentifierNullOrEmpty)
                this.CodonConverterIdentifier = sourceOfFilling.CodonConverterIdentifier;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
        }

        /// <summary>
        /// This CodonConverterRow used to fulfill the IStrongRowDescendent<T> contact.
        /// </summary>
        public CodonConverterRow Self
        {
            get { return this; }
        }

        /// <summary>
        /// Creates a deep copy of the given other CodonConverterRow. Fills this CodonConverterRow with the values, Foreign StrongRows and ForeignKey StrongRows of the given other CodonConverterRow. Fills each child row's children as well.
        /// </summary>
        /// <param name="other">The StrongRow from which values will be populated</param>
        public void PopulateFromRow(CodonConverterRow other)
        {
            this.PK_CodonConverterID = other.PK_CodonConverterID;
            this.CodonConverterIdentifier = other.CodonConverterIdentifier;
            this.GeneticCode = other.GeneticCode;

            if (other._geneticCodeRow != null)
            {
                var geneticCode = other.GeneticCodeRow;
                this.GeneticCodeRow.PopulateFromRow(geneticCode);
            }
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Gets the CodonConverterRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the CodonConverterRow</param>
        public static CodonConverterRow GetCodonConverterRowByID(object ID)
        {
            var codonConverterRow = new CodonConverterRow();
            Qry.SelectAllFrom(codonConverterRow).Where(codonConverterRow.PrimaryKeyColumn, ID).Go().ExtractStrongRow(ref codonConverterRow);
            return codonConverterRow;
        }

        /// <summary>
        /// Gets all of the CodonConverterRows in the database.
        /// </summary>
        public static IEnumerable<CodonConverterRow> GetAllCodonConverterRows()
        {
            return Qry.SelectAllFrom(new CodonConverterRow()).Go().ExtractStrongRows<CodonConverterRow>();
        }
        #endregion

        #region StrongRow Overrides
        /// <summary>
        /// Gets the CodonConverterRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the CodonConverterRow</param>
        public override StrongRow GetByID(object ID)
        {
            return CodonConverterRow.GetCodonConverterRowByID(ID);
        }

        /// <summary>
        /// Gets all of the CodonConverterRows in the database.
        /// </summary>
        public override IEnumerable<StrongRow> GetAll()
        {
            return CodonConverterRow.GetAllCodonConverterRows();
        }
        #endregion

        #region IRepository
        /// <summary>
        /// Gets the CodonConverterRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the CodonConverterRow</param>
        CodonConverterRow IRepository<CodonConverterRow>.GetByID(object ID)
        {
            return CodonConverterRow.GetCodonConverterRowByID(ID);
        }

        /// <summary>
        /// Gets all of the CodonConverterRows in the database.
        /// </summary>
        IEnumerable<CodonConverterRow> IRepository<CodonConverterRow>.GetAll()
        {
            return CodonConverterRow.GetAllCodonConverterRows();
        }
        #endregion

        /// <summary>
        /// Validates all of the underlying enum values in this CodonConverterRow. If there are any errors in the Enum Values, they will be registered with the given SenderIdentifier.
        /// </summary>
        /// <param name="senderIdentifier">The SenderIdentifier used to register Errors in the enum values if any errors exist.</param>
        /// <param name="referenceNumberForErrors">The reference number that will be registered with any Errors.</param>
        public override void ValidateEnumValues(SenderIdentifier senderIdentifier, string referenceNumberForErrors)
        {

        }
    }
}