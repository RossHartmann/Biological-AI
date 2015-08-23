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
    /// The name of the Nucleotide.
    /// </summary>
    [Serializable]
    public sealed partial class NucleotideRow : StrongRow, IRepository<NucleotideRow>, IStrongRowDescendant<NucleotideRow>
    {
        /// <summary>
        /// This class provides redundant access to the values of the underlying Row in a NucleotideRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        [Serializable]
        public sealed partial class NucleotideRowValues
        {
            /// <summary>
            /// PK_NucleotideID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PK_NucleotideID
            {
                get { return this.Parent.PK_NucleotideID; }
                set { this.Parent.PK_NucleotideID = value; }
            }

            /// <summary>
            /// The name of the Nucleotide.
            /// </summary>
            public System.String Name
            {
                get { return this.Parent.Name; }
                set { this.Parent.Name = value; }
            }

            /// <summary>
            /// The GeneticCode to which this Nucleotide applies.
            /// </summary>
            public System.Int32 GeneticCode
            {
                get { return this.Parent.GeneticCode; }
                set { this.Parent.GeneticCode = value; }
            }

            /// <summary>
            /// PK_NucleotideID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PrimaryKey
            {
                get { return this.PK_NucleotideID; }
                set { this.PK_NucleotideID = value; }
            }

            /// <summary>
            /// The parent NucleotideRow whose values will be viewed and manipulated through this NucleotideRowValues.
            /// </summary>
            public NucleotideRow Parent { get; private set; }

            /// <summary>
            /// Constructs a NucleotideRowValues from a parent NucleotideRow.
            /// </summary>
            /// <param name="parent">The parent NucleotideRow whose values will be viewed and manipulated through this NucleotideRowValues.</param>
            public NucleotideRowValues(NucleotideRow parent)
            {
                this.Parent = parent;
            }
        }

        /// <summary>
        /// This property provides redundant access to the values of the underlying Row in this NucleotideRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow.NucleotideRowValues Values { get; private set; }

        /// <summary>
        /// The StrongRowColumn where the value of PK_NucleotideID is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _pK_NucleotideIDColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of PK_NucleotideID is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn PK_NucleotideIDColumn
        {
            get
            {
                if (this._pK_NucleotideIDColumn == null)
                {
                    this.PK_NucleotideIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.PK_NucleotideID);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.PK_NucleotideID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_NucleotideID_ValueChanged);
                }

                return this._pK_NucleotideIDColumn;
            }
            private set { this._pK_NucleotideIDColumn = value; }
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
                    this.NameColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.Name);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.Name].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Name_ValueChanged);
                }

                return this._nameColumn;
            }
            private set { this._nameColumn = value; }
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
                    this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.GeneticCode);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
                }

                return this._geneticCodeColumn;
            }
            private set { this._geneticCodeColumn = value; }
        }



        /// <summary>
        /// Raised when the value of PK_NucleotideID has changed.<para></para><para></para>This will only fire when the value of the property PK_NucleotideID is set. If the corresponding value is set through the underlying row or through the property PK_NucleotideIDColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> PK_NucleotideIDChanged;

        /// <summary>
        /// When raised, indicates that the value of PK_NucleotideID has changed which fires the PK_NucleotideIDChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PK_NucleotideIDChanged event.</param>
        private void OnPK_NucleotideIDChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (PK_NucleotideIDChanged != null)
                PK_NucleotideIDChanged(this, e);
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
        /// PK_NucleotideID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public System.Int32 PK_NucleotideID
        {
            get { return this.PK_NucleotideIDColumn.Value.ToInt(); }
            set { this.PK_NucleotideIDColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnPK_NucleotideIDChanged when the value of PK_NucleotideID in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PK_NucleotideID_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasPK_NucleotideIDValueChanged = true;

            // Find the Foreign Key that refers to this Column (if there is any)
            var foreignKeyStrongRows = this.GetForeignKeyColumnsReferringToColumn(PK_NucleotideIDColumn);
            if (foreignKeyStrongRows != null)
                foreach (var foreignKeyStrongRow in foreignKeyStrongRows)
                    this.Parent.GetStrongRowColumn(foreignKeyStrongRow.ForeignKeyColumn).Value = e.NewValue;

            OnPK_NucleotideIDChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.PK_NucleotideIDColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of PK_NucleotideID in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.PK_NucleotideID) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsPK_NucleotideIDNullOrEmpty
        {
            get { return this.PK_NucleotideIDColumn.Value.IsNullOrDBNull() || this.PK_NucleotideID == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets PK_NucleotideID as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PK_NucleotideIDNullable
        {
            get { return IsPK_NucleotideIDNullOrEmpty ? null as System.Int32? : this.PK_NucleotideID; }
        }

        /// <summary>
        /// The name of the Nucleotide.
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
        /// The GeneticCode to which this Nucleotide applies.
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
        /// Indicates whether any value in this NucleotideRow that is not a Row (ForeignStrongRow or ForeignKeyStrongRow) is null or DBNull.Value or Empty. If false, all non-row values have values (i.e. are not null).
        /// </summary>
        public override bool IsAnyNonRowValueNullOrEmpty
        {
            get
            {
                if (this.IsPK_NucleotideIDNullOrEmpty)
                    return true;
                if (this.IsNameNullOrEmpty)
                    return true;
                if (this.IsGeneticCodeNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Indicates whether the value of PK_NucleotideID has changed since either this NucleotideRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasPK_NucleotideIDValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of Name has changed since either this NucleotideRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasNameValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of GeneticCode has changed since either this NucleotideRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
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

                OnGeneticCodeRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.GeneticCode, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.GeneticCode, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this NucleotideRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this NucleotideRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// </summary>
        private StrongRowForeignKeyColumn _geneticCodeRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this NucleotideRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this NucleotideRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn GeneticCodeRowColumn
        {
            get
            {
                if (this._geneticCodeRowColumn == null)
                    this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.GeneticCode);

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
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.GeneticCode].Value.IsInt() && this.GeneticCode != null)
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
        /// Indicates whether any Foreign StrongRow in this NucleotideRow is null or DBNull.Value or empty.
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
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow that stores the values of the ForeignKey Strong Row if it were joined to this NucleotideRow on the Foreign Key Column "Nucleotide". This NucleotideRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_CodonNucleotide_NucleotideRow ForeignKeyStrongRow.
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow _foreignKeyRow_CodonNucleotide_NucleotideRow;
        /// <summary>
        /// /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow that stores the values of the ForeignKey Strong Row if it were joined to this NucleotideRow on the Foreign Key Column "Nucleotide". This NucleotideRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_CodonNucleotide_NucleotideRow ForeignKeyStrongRow.
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow ForeignKeyRow_CodonNucleotide_NucleotideRow
        {
            get
            {
                if (this._foreignKeyRow_CodonNucleotide_NucleotideRow == null)
                {
                    this._foreignKeyRow_CodonNucleotide_NucleotideRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow();
                    this.InitializeForeignKeyRow_CodonNucleotide_NucleotideRow();
                }

                return _foreignKeyRow_CodonNucleotide_NucleotideRow;
            }
            set
            {
                var originalValue = this.ForeignKeyRow_CodonNucleotide_NucleotideRow;
                this._foreignKeyRow_CodonNucleotide_NucleotideRow = value;


                this.InitializeForeignKeyRow_CodonNucleotide_NucleotideRow();

                OnForeignKeyRow_CodonNucleotide_NucleotideRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Nucleotide, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Nucleotide, this, RowValueType.ForeignKeyStrongRow));
            }
        }

        /// <summary>
        /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "Nucleotide" that belongs to ForeignKey StrongRow "ForeignKeyRow_CodonNucleotide_NucleotideRow" (which is a different StrongRow than this NucleotideRow). This ForeignKeyToThisStrongRowColumn that can be used to join this NucleotideRow to the ForeignKeyStrongRow "ForeignKeyRow_CodonNucleotide_NucleotideRow.
        /// </summary>
        private ForeignKeyToThisStrongRowColumn _foreignKeyRow_CodonNucleotide_NucleotideRowColumn;
        /// <summary>
        /// /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "Nucleotide" that belongs to ForeignKey StrongRow "ForeignKeyRow_CodonNucleotide_NucleotideRow" (which is a different StrongRow than this NucleotideRow). This ForeignKeyToThisStrongRowColumn that can be used to join this NucleotideRow to the ForeignKeyStrongRow "ForeignKeyRow_CodonNucleotide_NucleotideRow.
        /// /// </summary>
        public ForeignKeyToThisStrongRowColumn ForeignKeyRow_CodonNucleotide_NucleotideRowColumn
        {
            get
            {
                if (this._foreignKeyRow_CodonNucleotide_NucleotideRowColumn == null)
                    this.ForeignKeyRow_CodonNucleotide_NucleotideRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_CodonNucleotide_NucleotideRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Nucleotide);

                return this._foreignKeyRow_CodonNucleotide_NucleotideRowColumn;
            }
            private set { this._foreignKeyRow_CodonNucleotide_NucleotideRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ForeignKeyRow_CodonNucleotide_NucleotideRow has changed (is NOT raised when a value inside ForeignKeyRow_CodonNucleotide_NucleotideRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow>> ForeignKeyRow_CodonNucleotide_NucleotideRowChanged;

        /// <summary>
        /// Indicates that the value of Nucleotide has changed which fires the NucleotideChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ForeignKeyRow_CodonNucleotide_NucleotideRowChanged event.</param>
        private void OnForeignKeyRow_CodonNucleotide_NucleotideRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow> e)
        {
            if (ForeignKeyRow_CodonNucleotide_NucleotideRowChanged != null)
                ForeignKeyRow_CodonNucleotide_NucleotideRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignKeyStrongRow ForeignKeyRow_CodonNucleotide_NucleotideRow.
        /// </summary>
        private void SubscribeToValueChangesOfForeignKeyRow_CodonNucleotide_NucleotideRow()
        {
            if (this.ForeignKeyRow_CodonNucleotide_NucleotideRow != null)
                this.ForeignKeyRow_CodonNucleotide_NucleotideRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignKeyStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when setting the value of ForeignKeyRow_CodonNucleotide_NucleotideRow.
        /// </summary>
        private void InitializeForeignKeyRow_CodonNucleotide_NucleotideRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ForeignKeyRow_CodonNucleotide_NucleotideRow))
                this.OtherRowTableAliases.Remove(this.ForeignKeyRow_CodonNucleotide_NucleotideRow);

            this.ForeignKeyRow_CodonNucleotide_NucleotideRowColumn.ForeignKeyRow = this.ForeignKeyRow_CodonNucleotide_NucleotideRow;

            this.OtherRowTableAliases.Add(this.ForeignKeyRow_CodonNucleotide_NucleotideRow, "foreignKey_CodonNucleotide_Nucleotide");
            this.ForeignKeyRow_CodonNucleotide_NucleotideRow.Parent = this;
            SubscribeToValueChangesOfForeignKeyRow_CodonNucleotide_NucleotideRow();
        }

        /// <summary>
        /// Indicates whether the value of the ForeignKeyRow_CodonNucleotide_NucleotideRow is null or DBNull.Value (does not Initialize the ForeignKeyRow_CodonNucleotide_NucleotideRow if it is currently null).
        /// </summary>
        public bool IsForeignKeyRow_CodonNucleotide_NucleotideRowNull
        {
            get { return this._foreignKeyRow_CodonNucleotide_NucleotideRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// Constructs an instance of this NucleotideRow from a specified Row.<para></para><para></para>NO STRONG ROW COLUMNS WILL BE INITIALIZED. This simply creates a wrapper around the Row in order to access the Row Values. It is helpful for performance.
        /// </summary>
        /// <param name="nucleotideRow">The name of the Nucleotide.</param>
        public NucleotideRow(Row nucleotideRow)
            : this()
        {
            this.Row = nucleotideRow;
        }

        /// <summary>
        /// Constructs an instance of this NucleotideRow from a specified global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.NucleotideRowSerializableContainer.
        /// </summary>
        /// <param name="nucleotideRowSerializableContainer">The name of the Nucleotide.</param>
        public NucleotideRow(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.NucleotideRowSerializableContainer nucleotideRowSerializableContainer)
            : this()
        {
            this.Row = new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.NucleotideTable);

            this.PK_NucleotideID = nucleotideRowSerializableContainer.PK_NucleotideID;
            this.Name = nucleotideRowSerializableContainer.Name;
            this.GeneticCode = nucleotideRowSerializableContainer.GeneticCode;
            if (nucleotideRowSerializableContainer.GeneticCodeRowSerializableContainer != null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow(nucleotideRowSerializableContainer.GeneticCodeRowSerializableContainer);
            if (nucleotideRowSerializableContainer.ForeignKeyRow_CodonNucleotide_NucleotideRowSerializableContainer != null)
                this.ForeignKeyRow_CodonNucleotide_NucleotideRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow(nucleotideRowSerializableContainer.ForeignKeyRow_CodonNucleotide_NucleotideRowSerializableContainer);
        }

        /// <summary>
        /// Constructs an instance of this NucleotideRow from a set of values for the Row.
        /// </summary>
        /// <param name="name">The name of the Nucleotide.</param>
        /// <param name="geneticCode">The GeneticCode to which this Nucleotide applies.</param>
        /// <param name="geneticCodeRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow that holds the values of the row that the foreign key "GeneticCode" is referencing. Row Description: The name of the Nucleotide.</param>
        public NucleotideRow(System.String name, System.Int32 geneticCode, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow geneticCodeRow = null)
            : this()
        {
            if (this.Row != null)
                this.Row = global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.ToRow(name: name, geneticCode: geneticCode);
            this.GeneticCodeRow = geneticCodeRow;
        }

        /// <summary>
        /// Constructs an instance of a NucleotideRow
        /// </summary>
        public NucleotideRow()
            : base(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.NucleotideTable)
        {
            this.Values = new NucleotideRowValues(this);
        }

        /// <summary>
        /// The TableDefinition of this NucleotideRow
        /// </summary>
        public override TableDefinition TableDefinition
        {
            get { return this.GetTableDefinition(); }
        }

        /// <summary>
        /// Gets the TableDefinition of this NucleotideRow
        /// </summary>
        public override TableDefinition GetTableDefinition()
        {
            return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.NucleotideTable;
        }

        /// <summary>
        /// The TableDefinition of this NucleotideRow
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.NucleotideTable NucleotideTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.NucleotideTable; }
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
                case "foreignKey_CodonNucleotide_Nucleotide":
                    if (this._foreignKeyRow_CodonNucleotide_NucleotideRow == null)
                    {
                        this._foreignKeyRow_CodonNucleotide_NucleotideRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow();
                        this.InitializeForeignKeyRow_CodonNucleotide_NucleotideRow();
                    }
                    return;
                case "_CNN37nio62":
                    if (this._foreignKeyRow_CodonNucleotide_NucleotideRow == null)
                    {
                        this._foreignKeyRow_CodonNucleotide_NucleotideRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow();
                        this.InitializeForeignKeyRow_CodonNucleotide_NucleotideRow();
                    }
                    return;
                default:
                    throw new Exception("The given table alias does not refer to any child StrongRow in this NucleotideRow.");
                    return;

            }
        }

        /// <summary>
        /// Initializes all of the Foreign Strong Rows and Foreign Key StrongRows in this NucleotideRow that are currently null. Calls the parameterless constructor for each Strong Row that is null.
        /// </summary>
        public override void InitializeChildStrongRows()
        {
            if (this.GeneticCodeRow == null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow();

            if (this.ForeignKeyRow_CodonNucleotide_NucleotideRow == null)
                this.ForeignKeyRow_CodonNucleotide_NucleotideRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow();
        }

        /// <summary>
        /// Initializes all of the StrongRowColumns in this NucleotideRow that are currently null. Also handles the necessary event subscriptions.
        /// </summary>
        public override void InitializeStrongRowColumns()
        {
            if (this.PK_NucleotideIDColumn == null)
            {
                this.PK_NucleotideIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.PK_NucleotideID);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.PK_NucleotideID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_NucleotideID_ValueChanged);
            }
            if (this.NameColumn == null)
            {
                this.NameColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.Name);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.Name].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Name_ValueChanged);
            }
            if (this.GeneticCodeColumn == null)
            {
                this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.GeneticCode);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
            }
        }

        /// <summary>
        /// Initializes all of the ForeignStrongRowColumns in this NucleotideRow that are null.
        /// </summary>
        public override void InitializeForeignStrongRowColumns()
        {
            if (this.GeneticCodeRowColumn == null)
                this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.GeneticCode);
        }

        /// <summary>
        /// Initializes all of the ForeignKeyToThisStrongRowColumns in this NucleotideRow that are null.
        /// </summary>
        public override void InitializeForeignKeyToThisStrongRowColumns()
        {
            if (this.ForeignKeyRow_CodonNucleotide_NucleotideRowColumn == null)
                this.ForeignKeyRow_CodonNucleotide_NucleotideRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_CodonNucleotide_NucleotideRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Nucleotide);
        }

        /// <summary>
        /// Inserts the Row into the database immediately (if it is not currently in the database. This method first checks to ensure that the Row is not in the database). Returns true if the Row was inserted. Returns false if not. Out's the primary key.
        /// </summary>
        /// <param name="primaryKey">PK_NucleotideID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// <param name="primaryKey">PK_NucleotideID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// Indicates whether the Primary Key PK_NucleotideID is null or DBNull.Value or is an Empty value.
        /// </summary>
        public override bool IsPrimaryKeyNullOrEmpty
        {
            get { return this.IsPK_NucleotideIDNullOrEmpty; }
        }

        /// <summary>
        /// The Primary Key PK_NucleotideID for this Nucleotide.
        /// </summary>
        public System.Int32 PrimaryKey
        {
            get { return this.PK_NucleotideID; }
            set { this.PK_NucleotideID = value; }
        }

        /// <summary>
        /// The Primary Key Column for this Nucleotide.
        /// </summary>
        public override StrongRowColumn PrimaryKeyColumn
        {
            get { return this.PK_NucleotideIDColumn; }
        }

        /// <summary>
        /// Gets the Primary Key as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PrimaryKeyNullable
        {
            get { return this.IsPrimaryKeyNullOrEmpty ? null as System.Int32? : this.PrimaryKey; }
        }

        /// <summary>
        /// Returns all of the Columns in the NucleotideRow whose values have changed according to their HasChanged flags.
        /// </summary>
        public override List<Column> GetColumnsWithChangedValues()
        {
            // If no value in this row has changed then return an empty list.
            if (!this.HasAnyNonRowValueInRowChanged)
                return new List<Column>(0);

            // We will collect the columns whose values have changed.
            var columns = new List<Column>();

            if (HasPK_NucleotideIDValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.PK_NucleotideID);
            if (HasNameValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.Name);
            if (HasGeneticCodeValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.GeneticCode);

            return columns;
        }

        /// <summary>
        /// Calls ResetAllHasAnyValueChangedFlags() for this NucleotideRow and ResetAllThisAndChildrenHasAnyValueChangedFlags() for all children Foreign StrongRows and Foreign Key Strong Rows that are not null.
        /// </summary>
        public override void ResetAllThisAndChildrenHasAnyValueChangedFlags()
        {
            this.ResetAllHasAnyValueChangedFlags();

            if (this._geneticCodeRow != null)
                this.GeneticCodeRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._foreignKeyRow_CodonNucleotide_NucleotideRow != null)
                this.ForeignKeyRow_CodonNucleotide_NucleotideRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
        }

        /// <summary>
        /// Resets all of the HasAnyValuesChanged for each of the values in this NucleotideRow. Also calls the base.ResetAllHasAnyValueChangedFlags().
        /// </summary>
        public override void ResetAllHasAnyValueChangedFlags()
        {
            base.ResetAllHasAnyValueChangedFlags();

            this.HasPK_NucleotideIDValueChanged = false;
            this.HasNameValueChanged = false;
            this.HasGeneticCodeValueChanged = false;
        }

        /// <summary>
        /// Gets all of the StrongRowColumns in this NucleotideRow.
        /// </summary>
        public override StrongRowColumn[] GetAllStrongRowColumns()
        {
            return new StrongRowColumn[] { PK_NucleotideIDColumn, NameColumn, GeneticCodeColumn };
        }

        /// <summary>
        /// Gets all of the StrongRowForeignKeyColumns in this NucleotideRow.
        /// </summary>
        public override StrongRowForeignKeyColumn[] GetAllStrongRowForeignKeyColumns()
        {
            return new StrongRowForeignKeyColumn[] { GeneticCodeRowColumn };
        }

        /// <summary>
        /// Gets all of the ForeignKeyToThisStrongRowColumn in this NucleotideRow.
        /// </summary>
        public override ForeignKeyToThisStrongRowColumn[] GetAllForeignKeyToThisStrongRowColumns()
        {
            return new ForeignKeyToThisStrongRowColumn[] { ForeignKeyRow_CodonNucleotide_NucleotideRowColumn };
        }

        /// <summary>
        /// Converts the NucleotideRow to a NucleotideRowSerializableContainer.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.NucleotideRowSerializableContainer ToNucleotideRowSerializableContainer()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.NucleotideRowSerializableContainer(this);
        }

        /// <summary>
        /// Converts the StrongRow to the appropriate StrongRowSerializableContainer.
        /// </summary>
        public override StrongRowSerializableContainer ToStrongRowSerializableContainer()
        {
            return this.ToNucleotideRowSerializableContainer();
        }

        #region IStrongRowDescendant<T>
        /// <summary>
        /// Fills any empty values in this NucleotideRow with the corresponding values from the given NucleotideRow. Does NOT fill the Primary Key.
        /// </summary>
        /// <param name="sourceOfFilling">The NucleotideRow from which we will gather values in order to fill any empty values in this NucleotideRow.</param>
        public void FillEmptyValues(NucleotideRow sourceOfFilling)
        {
            if (sourceOfFilling == null)
                return;

            if (this.IsNameNullOrEmpty)
                this.Name = sourceOfFilling.Name;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
        }

        /// <summary>
        /// This NucleotideRow used to fulfill the IStrongRowDescendent<T> contact.
        /// </summary>
        public NucleotideRow Self
        {
            get { return this; }
        }

        /// <summary>
        /// Creates a deep copy of the given other NucleotideRow. Fills this NucleotideRow with the values, Foreign StrongRows and ForeignKey StrongRows of the given other NucleotideRow. Fills each child row's children as well.
        /// </summary>
        /// <param name="other">The StrongRow from which values will be populated</param>
        public void PopulateFromRow(NucleotideRow other)
        {
            this.PK_NucleotideID = other.PK_NucleotideID;
            this.Name = other.Name;
            this.GeneticCode = other.GeneticCode;

            if (other._geneticCodeRow != null)
            {
                var geneticCode = other.GeneticCodeRow;
                this.GeneticCodeRow.PopulateFromRow(geneticCode);
            }
            if (other._foreignKeyRow_CodonNucleotide_NucleotideRow != null)
            {
                var codonNucleotide_NucleotideRow = other.ForeignKeyRow_CodonNucleotide_NucleotideRow;
                this.ForeignKeyRow_CodonNucleotide_NucleotideRow.PopulateFromRow(codonNucleotide_NucleotideRow);
            }
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Gets the NucleotideRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the NucleotideRow</param>
        public static NucleotideRow GetNucleotideRowByID(object ID)
        {
            var nucleotideRow = new NucleotideRow();
            Qry.SelectAllFrom(nucleotideRow).Where(nucleotideRow.PrimaryKeyColumn, ID).Go().ExtractStrongRow(ref nucleotideRow);
            return nucleotideRow;
        }

        /// <summary>
        /// Gets all of the NucleotideRows in the database.
        /// </summary>
        public static IEnumerable<NucleotideRow> GetAllNucleotideRows()
        {
            return Qry.SelectAllFrom(new NucleotideRow()).Go().ExtractStrongRows<NucleotideRow>();
        }
        #endregion

        #region StrongRow Overrides
        /// <summary>
        /// Gets the NucleotideRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the NucleotideRow</param>
        public override StrongRow GetByID(object ID)
        {
            return NucleotideRow.GetNucleotideRowByID(ID);
        }

        /// <summary>
        /// Gets all of the NucleotideRows in the database.
        /// </summary>
        public override IEnumerable<StrongRow> GetAll()
        {
            return NucleotideRow.GetAllNucleotideRows();
        }
        #endregion

        #region IRepository
        /// <summary>
        /// Gets the NucleotideRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the NucleotideRow</param>
        NucleotideRow IRepository<NucleotideRow>.GetByID(object ID)
        {
            return NucleotideRow.GetNucleotideRowByID(ID);
        }

        /// <summary>
        /// Gets all of the NucleotideRows in the database.
        /// </summary>
        IEnumerable<NucleotideRow> IRepository<NucleotideRow>.GetAll()
        {
            return NucleotideRow.GetAllNucleotideRows();
        }
        #endregion

        /// <summary>
        /// Validates all of the underlying enum values in this NucleotideRow. If there are any errors in the Enum Values, they will be registered with the given SenderIdentifier.
        /// </summary>
        /// <param name="senderIdentifier">The SenderIdentifier used to register Errors in the enum values if any errors exist.</param>
        /// <param name="referenceNumberForErrors">The reference number that will be registered with any Errors.</param>
        public override void ValidateEnumValues(SenderIdentifier senderIdentifier, string referenceNumberForErrors)
        {

        }
    }
}