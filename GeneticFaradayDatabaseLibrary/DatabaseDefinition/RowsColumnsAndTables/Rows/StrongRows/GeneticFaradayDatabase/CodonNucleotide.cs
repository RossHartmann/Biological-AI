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
    /// Ties a Nucleotide to a Codon
    /// </summary>
    [Serializable]
    public sealed partial class CodonNucleotideRow : StrongRow, IRepository<CodonNucleotideRow>, IStrongRowDescendant<CodonNucleotideRow>
    {
        /// <summary>
        /// This class provides redundant access to the values of the underlying Row in a CodonNucleotideRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        [Serializable]
        public sealed partial class CodonNucleotideRowValues
        {
            /// <summary>
            /// PK_CodonNucleotideID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PK_CodonNucleotideID
            {
                get { return this.Parent.PK_CodonNucleotideID; }
                set { this.Parent.PK_CodonNucleotideID = value; }
            }

            /// <summary>
            /// The Codon to which the Nucleotide belongs.
            /// </summary>
            public System.Int32 Codon
            {
                get { return this.Parent.Codon; }
                set { this.Parent.Codon = value; }
            }

            /// <summary>
            /// The Nucleotide that belongs to the Codon.
            /// </summary>
            public System.Int32 Nucleotide
            {
                get { return this.Parent.Nucleotide; }
                set { this.Parent.Nucleotide = value; }
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
            /// PK_CodonNucleotideID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PrimaryKey
            {
                get { return this.PK_CodonNucleotideID; }
                set { this.PK_CodonNucleotideID = value; }
            }

            /// <summary>
            /// The parent CodonNucleotideRow whose values will be viewed and manipulated through this CodonNucleotideRowValues.
            /// </summary>
            public CodonNucleotideRow Parent { get; private set; }

            /// <summary>
            /// Constructs a CodonNucleotideRowValues from a parent CodonNucleotideRow.
            /// </summary>
            /// <param name="parent">The parent CodonNucleotideRow whose values will be viewed and manipulated through this CodonNucleotideRowValues.</param>
            public CodonNucleotideRowValues(CodonNucleotideRow parent)
            {
                this.Parent = parent;
            }
        }

        /// <summary>
        /// This property provides redundant access to the values of the underlying Row in this CodonNucleotideRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow.CodonNucleotideRowValues Values { get; private set; }

        /// <summary>
        /// The StrongRowColumn where the value of PK_CodonNucleotideID is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _pK_CodonNucleotideIDColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of PK_CodonNucleotideID is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn PK_CodonNucleotideIDColumn
        {
            get
            {
                if (this._pK_CodonNucleotideIDColumn == null)
                {
                    this.PK_CodonNucleotideIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.PK_CodonNucleotideID);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.PK_CodonNucleotideID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_CodonNucleotideID_ValueChanged);
                }

                return this._pK_CodonNucleotideIDColumn;
            }
            private set { this._pK_CodonNucleotideIDColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of Codon is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _codonColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of Codon is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn CodonColumn
        {
            get
            {
                if (this._codonColumn == null)
                {
                    this.CodonColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Codon);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Codon].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Codon_ValueChanged);
                }

                return this._codonColumn;
            }
            private set { this._codonColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of Nucleotide is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _nucleotideColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of Nucleotide is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn NucleotideColumn
        {
            get
            {
                if (this._nucleotideColumn == null)
                {
                    this.NucleotideColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Nucleotide);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Nucleotide].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Nucleotide_ValueChanged);
                }

                return this._nucleotideColumn;
            }
            private set { this._nucleotideColumn = value; }
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
                    this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.GeneticCode);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
                }

                return this._geneticCodeColumn;
            }
            private set { this._geneticCodeColumn = value; }
        }



        /// <summary>
        /// Raised when the value of PK_CodonNucleotideID has changed.<para></para><para></para>This will only fire when the value of the property PK_CodonNucleotideID is set. If the corresponding value is set through the underlying row or through the property PK_CodonNucleotideIDColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> PK_CodonNucleotideIDChanged;

        /// <summary>
        /// When raised, indicates that the value of PK_CodonNucleotideID has changed which fires the PK_CodonNucleotideIDChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PK_CodonNucleotideIDChanged event.</param>
        private void OnPK_CodonNucleotideIDChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (PK_CodonNucleotideIDChanged != null)
                PK_CodonNucleotideIDChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of Codon has changed.<para></para><para></para>This will only fire when the value of the property Codon is set. If the corresponding value is set through the underlying row or through the property CodonColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> CodonChanged;

        /// <summary>
        /// When raised, indicates that the value of Codon has changed which fires the CodonChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the CodonChanged event.</param>
        private void OnCodonChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (CodonChanged != null)
                CodonChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of Nucleotide has changed.<para></para><para></para>This will only fire when the value of the property Nucleotide is set. If the corresponding value is set through the underlying row or through the property NucleotideColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> NucleotideChanged;

        /// <summary>
        /// When raised, indicates that the value of Nucleotide has changed which fires the NucleotideChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the NucleotideChanged event.</param>
        private void OnNucleotideChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (NucleotideChanged != null)
                NucleotideChanged(this, e);
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
        /// PK_CodonNucleotideID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public System.Int32 PK_CodonNucleotideID
        {
            get { return this.PK_CodonNucleotideIDColumn.Value.ToInt(); }
            set { this.PK_CodonNucleotideIDColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnPK_CodonNucleotideIDChanged when the value of PK_CodonNucleotideID in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PK_CodonNucleotideID_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasPK_CodonNucleotideIDValueChanged = true;

            // Find the Foreign Key that refers to this Column (if there is any)
            var foreignKeyStrongRows = this.GetForeignKeyColumnsReferringToColumn(PK_CodonNucleotideIDColumn);
            if (foreignKeyStrongRows != null)
                foreach (var foreignKeyStrongRow in foreignKeyStrongRows)
                    this.Parent.GetStrongRowColumn(foreignKeyStrongRow.ForeignKeyColumn).Value = e.NewValue;

            OnPK_CodonNucleotideIDChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.PK_CodonNucleotideIDColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of PK_CodonNucleotideID in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.PK_CodonNucleotideID) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsPK_CodonNucleotideIDNullOrEmpty
        {
            get { return this.PK_CodonNucleotideIDColumn.Value.IsNullOrDBNull() || this.PK_CodonNucleotideID == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets PK_CodonNucleotideID as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PK_CodonNucleotideIDNullable
        {
            get { return IsPK_CodonNucleotideIDNullOrEmpty ? null as System.Int32? : this.PK_CodonNucleotideID; }
        }

        /// <summary>
        /// The Codon to which the Nucleotide belongs.
        /// </summary>
        public System.Int32 Codon
        {
            get { return this.CodonColumn.Value.ToInt(); }
            set { this.CodonColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnCodonChanged when the value of Codon in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Codon_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasCodonValueChanged = true;

            // Only update the primary key of the Foreign Row if we need to (so that we don't circularly update the primary keys).
            if (this._codonRow != null)
                if (this.CodonRow.PrimaryKey != this.Codon)
                    this.CodonRow.PrimaryKey = this.Codon;

            OnCodonChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.CodonColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of Codon in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.Codon) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsCodonNullOrEmpty
        {
            get { return this.CodonColumn.Value.IsNullOrDBNull() || this.Codon == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets Codon as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? CodonNullable
        {
            get { return IsCodonNullOrEmpty ? null as System.Int32? : this.Codon; }
        }

        /// <summary>
        /// The Nucleotide that belongs to the Codon.
        /// </summary>
        public System.Int32 Nucleotide
        {
            get { return this.NucleotideColumn.Value.ToInt(); }
            set { this.NucleotideColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnNucleotideChanged when the value of Nucleotide in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Nucleotide_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasNucleotideValueChanged = true;

            // Only update the primary key of the Foreign Row if we need to (so that we don't circularly update the primary keys).
            if (this._nucleotideRow != null)
                if (this.NucleotideRow.PrimaryKey != this.Nucleotide)
                    this.NucleotideRow.PrimaryKey = this.Nucleotide;

            OnNucleotideChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.NucleotideColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of Nucleotide in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.Nucleotide) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsNucleotideNullOrEmpty
        {
            get { return this.NucleotideColumn.Value.IsNullOrDBNull() || this.Nucleotide == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets Nucleotide as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? NucleotideNullable
        {
            get { return IsNucleotideNullOrEmpty ? null as System.Int32? : this.Nucleotide; }
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
        /// Indicates whether any value in this CodonNucleotideRow that is not a Row (ForeignStrongRow or ForeignKeyStrongRow) is null or DBNull.Value or Empty. If false, all non-row values have values (i.e. are not null).
        /// </summary>
        public override bool IsAnyNonRowValueNullOrEmpty
        {
            get
            {
                if (this.IsPK_CodonNucleotideIDNullOrEmpty)
                    return true;
                if (this.IsCodonNullOrEmpty)
                    return true;
                if (this.IsNucleotideNullOrEmpty)
                    return true;
                if (this.IsGeneticCodeNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Indicates whether the value of PK_CodonNucleotideID has changed since either this CodonNucleotideRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasPK_CodonNucleotideIDValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of Codon has changed since either this CodonNucleotideRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasCodonValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of Nucleotide has changed since either this CodonNucleotideRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasNucleotideValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of GeneticCode has changed since either this CodonNucleotideRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasGeneticCodeValueChanged { get; private set; }

        /// <summary>
        /// An instance of the CodonRow that stores the values that are referenced by the foreign key column "Codon".
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow _codonRow;
        /// <summary>
        /// /// An instance of the CodonRow that stores the values that are referenced by the foreign key column "Codon".
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow CodonRow
        {
            get
            {
                if (this._codonRow == null)
                {
                    this._codonRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow();
                    this.InitializeCodonRow();
                }

                return _codonRow;
            }
            set
            {
                var originalValue = this.CodonRow;
                this._codonRow = value;


                this.InitializeCodonRow();

                OnCodonRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Codon, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Codon, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this CodonNucleotideRow to the foreign CodonRow. This contains the ForeignKeyColumn of this CodonNucleotideRow and the referenced ForeignColumn that will be used to join the CodonRow.
        /// </summary>
        private StrongRowForeignKeyColumn _codonRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this CodonNucleotideRow to the foreign CodonRow. This contains the ForeignKeyColumn of this CodonNucleotideRow and the referenced ForeignColumn that will be used to join the CodonRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn CodonRowColumn
        {
            get
            {
                if (this._codonRowColumn == null)
                    this.CodonRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.CodonRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Codon);

                return this._codonRowColumn;
            }
            private set { this._codonRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of CodonRow has changed (is NOT raised when a value inside CodonRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow>> CodonRowChanged;

        /// <summary>
        /// Indicates that the value of Codon has changed which fires the CodonChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the CodonRowChanged event.</param>
        private void OnCodonRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow> e)
        {
            if (CodonRowChanged != null)
                CodonRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignStrongRow CodonRow.
        /// </summary>
        private void SubscribeToValueChangesOfCodonRow()
        {
            if (this.CodonRow != null)
                this.CodonRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when initializing the value of CodonRow.
        /// </summary>
        private void InitializeCodonRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.CodonRow))
                this.OtherRowTableAliases.Remove(this.CodonRow);

            this.CodonRowColumn.ForeignRow = this.CodonRow;

            this.OtherRowTableAliases.Add(this.CodonRow, "codon");
            this.CodonRow.Parent = this;
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Codon].Value.IsInt() && this.Codon != null)
                this.CodonRow.PrimaryKey = this.Codon;
            SubscribeToValueChangesOfCodonRow();
        }

        /// <summary>
        /// Indicates whether the value of the CodonRow is null or DBNull.Value (does not Initialize the CodonRow if it is currently null).
        /// </summary>
        public bool IsCodonRowNull
        {
            get { return this._codonRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// An instance of the NucleotideRow that stores the values that are referenced by the foreign key column "Nucleotide".
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow _nucleotideRow;
        /// <summary>
        /// /// An instance of the NucleotideRow that stores the values that are referenced by the foreign key column "Nucleotide".
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow NucleotideRow
        {
            get
            {
                if (this._nucleotideRow == null)
                {
                    this._nucleotideRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow();
                    this.InitializeNucleotideRow();
                }

                return _nucleotideRow;
            }
            set
            {
                var originalValue = this.NucleotideRow;
                this._nucleotideRow = value;


                this.InitializeNucleotideRow();

                OnNucleotideRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Nucleotide, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Nucleotide, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this CodonNucleotideRow to the foreign NucleotideRow. This contains the ForeignKeyColumn of this CodonNucleotideRow and the referenced ForeignColumn that will be used to join the NucleotideRow.
        /// </summary>
        private StrongRowForeignKeyColumn _nucleotideRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this CodonNucleotideRow to the foreign NucleotideRow. This contains the ForeignKeyColumn of this CodonNucleotideRow and the referenced ForeignColumn that will be used to join the NucleotideRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn NucleotideRowColumn
        {
            get
            {
                if (this._nucleotideRowColumn == null)
                    this.NucleotideRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.NucleotideRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Nucleotide);

                return this._nucleotideRowColumn;
            }
            private set { this._nucleotideRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of NucleotideRow has changed (is NOT raised when a value inside NucleotideRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow>> NucleotideRowChanged;

        /// <summary>
        /// Indicates that the value of Nucleotide has changed which fires the NucleotideChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the NucleotideRowChanged event.</param>
        private void OnNucleotideRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow> e)
        {
            if (NucleotideRowChanged != null)
                NucleotideRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignStrongRow NucleotideRow.
        /// </summary>
        private void SubscribeToValueChangesOfNucleotideRow()
        {
            if (this.NucleotideRow != null)
                this.NucleotideRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when initializing the value of NucleotideRow.
        /// </summary>
        private void InitializeNucleotideRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.NucleotideRow))
                this.OtherRowTableAliases.Remove(this.NucleotideRow);

            this.NucleotideRowColumn.ForeignRow = this.NucleotideRow;

            this.OtherRowTableAliases.Add(this.NucleotideRow, "nucleotide");
            this.NucleotideRow.Parent = this;
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Nucleotide].Value.IsInt() && this.Nucleotide != null)
                this.NucleotideRow.PrimaryKey = this.Nucleotide;
            SubscribeToValueChangesOfNucleotideRow();
        }

        /// <summary>
        /// Indicates whether the value of the NucleotideRow is null or DBNull.Value (does not Initialize the NucleotideRow if it is currently null).
        /// </summary>
        public bool IsNucleotideRowNull
        {
            get { return this._nucleotideRow.IsNullOrDBNull(); }
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

                OnGeneticCodeRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.GeneticCode, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.GeneticCode, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this CodonNucleotideRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this CodonNucleotideRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// </summary>
        private StrongRowForeignKeyColumn _geneticCodeRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this CodonNucleotideRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this CodonNucleotideRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn GeneticCodeRowColumn
        {
            get
            {
                if (this._geneticCodeRowColumn == null)
                    this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.GeneticCode);

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
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.GeneticCode].Value.IsInt() && this.GeneticCode != null)
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
        /// Indicates whether any Foreign StrongRow in this CodonNucleotideRow is null or DBNull.Value or empty.
        /// </summary>
        public override bool IsAnyForeignRowNull
        {
            get
            {
                if (this.IsCodonNullOrEmpty)
                    return true;
                if (this.IsNucleotideNullOrEmpty)
                    return true;
                if (this.IsGeneticCodeNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Constructs an instance of this CodonNucleotideRow from a specified Row.<para></para><para></para>NO STRONG ROW COLUMNS WILL BE INITIALIZED. This simply creates a wrapper around the Row in order to access the Row Values. It is helpful for performance.
        /// </summary>
        /// <param name="codonNucleotideRow">Ties a Nucleotide to a Codon</param>
        public CodonNucleotideRow(Row codonNucleotideRow)
            : this()
        {
            this.Row = codonNucleotideRow;
        }

        /// <summary>
        /// Constructs an instance of this CodonNucleotideRow from a specified global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonNucleotideRowSerializableContainer.
        /// </summary>
        /// <param name="codonNucleotideRowSerializableContainer">Ties a Nucleotide to a Codon</param>
        public CodonNucleotideRow(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonNucleotideRowSerializableContainer codonNucleotideRowSerializableContainer)
            : this()
        {
            this.Row = new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotideTable);

            this.PK_CodonNucleotideID = codonNucleotideRowSerializableContainer.PK_CodonNucleotideID;
            this.Codon = codonNucleotideRowSerializableContainer.Codon;
            this.Nucleotide = codonNucleotideRowSerializableContainer.Nucleotide;
            this.GeneticCode = codonNucleotideRowSerializableContainer.GeneticCode;
            if (codonNucleotideRowSerializableContainer.CodonRowSerializableContainer != null)
                this.CodonRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow(codonNucleotideRowSerializableContainer.CodonRowSerializableContainer);
            if (codonNucleotideRowSerializableContainer.NucleotideRowSerializableContainer != null)
                this.NucleotideRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow(codonNucleotideRowSerializableContainer.NucleotideRowSerializableContainer);
            if (codonNucleotideRowSerializableContainer.GeneticCodeRowSerializableContainer != null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow(codonNucleotideRowSerializableContainer.GeneticCodeRowSerializableContainer);
        }

        /// <summary>
        /// Constructs an instance of this CodonNucleotideRow from a set of values for the Row.
        /// </summary>
        /// <param name="codon">The Codon to which the Nucleotide belongs.</param>
        /// <param name="nucleotide">The Nucleotide that belongs to the Codon.</param>
        /// <param name="geneticCode">The GeneticCode to which this Function applies.</param>
        /// <param name="codonRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow that holds the values of the row that the foreign key "Codon" is referencing. Row Description: Ties a Nucleotide to a Codon</param>
        /// <param name="nucleotideRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow that holds the values of the row that the foreign key "Nucleotide" is referencing. Row Description: Ties a Nucleotide to a Codon</param>
        /// <param name="geneticCodeRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow that holds the values of the row that the foreign key "GeneticCode" is referencing. Row Description: Ties a Nucleotide to a Codon</param>
        public CodonNucleotideRow(System.Int32 codon, System.Int32 nucleotide, System.Int32 geneticCode, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow codonRow = null, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow nucleotideRow = null, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow geneticCodeRow = null)
            : this()
        {
            if (this.Row != null)
                this.Row = global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.ToRow(codon: codon, nucleotide: nucleotide, geneticCode: geneticCode);
            this.CodonRow = codonRow;
            this.NucleotideRow = nucleotideRow;
            this.GeneticCodeRow = geneticCodeRow;
        }

        /// <summary>
        /// Constructs an instance of a CodonNucleotideRow
        /// </summary>
        public CodonNucleotideRow()
            : base(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotideTable)
        {
            this.Values = new CodonNucleotideRowValues(this);
        }

        /// <summary>
        /// The TableDefinition of this CodonNucleotideRow
        /// </summary>
        public override TableDefinition TableDefinition
        {
            get { return this.GetTableDefinition(); }
        }

        /// <summary>
        /// Gets the TableDefinition of this CodonNucleotideRow
        /// </summary>
        public override TableDefinition GetTableDefinition()
        {
            return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotideTable;
        }

        /// <summary>
        /// The TableDefinition of this CodonNucleotideRow
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.CodonNucleotideTable CodonNucleotideTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotideTable; }
        }

        /// <summary>
        /// Given a table alias (compressed or non-compressed), initializes the proper child StrongRow that has the given alias.
        /// </summary>
        /// <param name="tableAlias">The table alias (compressed or non-compressed) that will indicate which child StrongRow to initialize.</param>
        public override void InitializeChildStrongRowWithAlias(string tableAlias)
        {
            switch (tableAlias)
            {
                case "codon":
                    if (this._codonRow == null)
                    {
                        this._codonRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow();
                        this.InitializeCodonRow();
                    }
                    return;
                case "co5no30":
                    if (this._codonRow == null)
                    {
                        this._codonRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow();
                        this.InitializeCodonRow();
                    }
                    return;
                case "nucleotide":
                    if (this._nucleotideRow == null)
                    {
                        this._nucleotideRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow();
                        this.InitializeNucleotideRow();
                    }
                    return;
                case "nu10teu29":
                    if (this._nucleotideRow == null)
                    {
                        this._nucleotideRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow();
                        this.InitializeNucleotideRow();
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
                    throw new Exception("The given table alias does not refer to any child StrongRow in this CodonNucleotideRow.");
                    return;

            }
        }

        /// <summary>
        /// Initializes all of the Foreign Strong Rows and Foreign Key StrongRows in this CodonNucleotideRow that are currently null. Calls the parameterless constructor for each Strong Row that is null.
        /// </summary>
        public override void InitializeChildStrongRows()
        {
            if (this.CodonRow == null)
                this.CodonRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow();
            if (this.NucleotideRow == null)
                this.NucleotideRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow();
            if (this.GeneticCodeRow == null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow();

        }

        /// <summary>
        /// Initializes all of the StrongRowColumns in this CodonNucleotideRow that are currently null. Also handles the necessary event subscriptions.
        /// </summary>
        public override void InitializeStrongRowColumns()
        {
            if (this.PK_CodonNucleotideIDColumn == null)
            {
                this.PK_CodonNucleotideIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.PK_CodonNucleotideID);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.PK_CodonNucleotideID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_CodonNucleotideID_ValueChanged);
            }
            if (this.CodonColumn == null)
            {
                this.CodonColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Codon);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Codon].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Codon_ValueChanged);
            }
            if (this.NucleotideColumn == null)
            {
                this.NucleotideColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Nucleotide);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Nucleotide].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Nucleotide_ValueChanged);
            }
            if (this.GeneticCodeColumn == null)
            {
                this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.GeneticCode);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
            }
        }

        /// <summary>
        /// Initializes all of the ForeignStrongRowColumns in this CodonNucleotideRow that are null.
        /// </summary>
        public override void InitializeForeignStrongRowColumns()
        {
            if (this.CodonRowColumn == null)
                this.CodonRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.CodonRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Codon);
            if (this.NucleotideRowColumn == null)
                this.NucleotideRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.NucleotideRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Nucleotide);
            if (this.GeneticCodeRowColumn == null)
                this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.GeneticCode);
        }

        /// <summary>
        /// Initializes all of the ForeignKeyToThisStrongRowColumns in this CodonNucleotideRow that are null.
        /// </summary>
        public override void InitializeForeignKeyToThisStrongRowColumns()
        {

        }

        /// <summary>
        /// Inserts the Row into the database immediately (if it is not currently in the database. This method first checks to ensure that the Row is not in the database). Returns true if the Row was inserted. Returns false if not. Out's the primary key.
        /// </summary>
        /// <param name="primaryKey">PK_CodonNucleotideID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// <param name="primaryKey">PK_CodonNucleotideID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// Indicates whether the Primary Key PK_CodonNucleotideID is null or DBNull.Value or is an Empty value.
        /// </summary>
        public override bool IsPrimaryKeyNullOrEmpty
        {
            get { return this.IsPK_CodonNucleotideIDNullOrEmpty; }
        }

        /// <summary>
        /// The Primary Key PK_CodonNucleotideID for this CodonNucleotide.
        /// </summary>
        public System.Int32 PrimaryKey
        {
            get { return this.PK_CodonNucleotideID; }
            set { this.PK_CodonNucleotideID = value; }
        }

        /// <summary>
        /// The Primary Key Column for this CodonNucleotide.
        /// </summary>
        public override StrongRowColumn PrimaryKeyColumn
        {
            get { return this.PK_CodonNucleotideIDColumn; }
        }

        /// <summary>
        /// Gets the Primary Key as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PrimaryKeyNullable
        {
            get { return this.IsPrimaryKeyNullOrEmpty ? null as System.Int32? : this.PrimaryKey; }
        }

        /// <summary>
        /// Returns all of the Columns in the CodonNucleotideRow whose values have changed according to their HasChanged flags.
        /// </summary>
        public override List<Column> GetColumnsWithChangedValues()
        {
            // If no value in this row has changed then return an empty list.
            if (!this.HasAnyNonRowValueInRowChanged)
                return new List<Column>(0);

            // We will collect the columns whose values have changed.
            var columns = new List<Column>();

            if (HasPK_CodonNucleotideIDValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.PK_CodonNucleotideID);
            if (HasCodonValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Codon);
            if (HasNucleotideValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Nucleotide);
            if (HasGeneticCodeValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.GeneticCode);

            return columns;
        }

        /// <summary>
        /// Calls ResetAllHasAnyValueChangedFlags() for this CodonNucleotideRow and ResetAllThisAndChildrenHasAnyValueChangedFlags() for all children Foreign StrongRows and Foreign Key Strong Rows that are not null.
        /// </summary>
        public override void ResetAllThisAndChildrenHasAnyValueChangedFlags()
        {
            this.ResetAllHasAnyValueChangedFlags();

            if (this._codonRow != null)
                this.CodonRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._nucleotideRow != null)
                this.NucleotideRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._geneticCodeRow != null)
                this.GeneticCodeRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
        }

        /// <summary>
        /// Resets all of the HasAnyValuesChanged for each of the values in this CodonNucleotideRow. Also calls the base.ResetAllHasAnyValueChangedFlags().
        /// </summary>
        public override void ResetAllHasAnyValueChangedFlags()
        {
            base.ResetAllHasAnyValueChangedFlags();

            this.HasPK_CodonNucleotideIDValueChanged = false;
            this.HasCodonValueChanged = false;
            this.HasNucleotideValueChanged = false;
            this.HasGeneticCodeValueChanged = false;
        }

        /// <summary>
        /// Gets all of the StrongRowColumns in this CodonNucleotideRow.
        /// </summary>
        public override StrongRowColumn[] GetAllStrongRowColumns()
        {
            return new StrongRowColumn[] { PK_CodonNucleotideIDColumn, CodonColumn, NucleotideColumn, GeneticCodeColumn };
        }

        /// <summary>
        /// Gets all of the StrongRowForeignKeyColumns in this CodonNucleotideRow.
        /// </summary>
        public override StrongRowForeignKeyColumn[] GetAllStrongRowForeignKeyColumns()
        {
            return new StrongRowForeignKeyColumn[] { CodonRowColumn, NucleotideRowColumn, GeneticCodeRowColumn };
        }

        /// <summary>
        /// Gets all of the ForeignKeyToThisStrongRowColumn in this CodonNucleotideRow.
        /// </summary>
        public override ForeignKeyToThisStrongRowColumn[] GetAllForeignKeyToThisStrongRowColumns()
        {
            return new ForeignKeyToThisStrongRowColumn[] { };
        }

        /// <summary>
        /// Converts the CodonNucleotideRow to a CodonNucleotideRowSerializableContainer.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonNucleotideRowSerializableContainer ToCodonNucleotideRowSerializableContainer()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonNucleotideRowSerializableContainer(this);
        }

        /// <summary>
        /// Converts the StrongRow to the appropriate StrongRowSerializableContainer.
        /// </summary>
        public override StrongRowSerializableContainer ToStrongRowSerializableContainer()
        {
            return this.ToCodonNucleotideRowSerializableContainer();
        }

        #region IStrongRowDescendant<T>
        /// <summary>
        /// Fills any empty values in this CodonNucleotideRow with the corresponding values from the given CodonNucleotideRow. Does NOT fill the Primary Key.
        /// </summary>
        /// <param name="sourceOfFilling">The CodonNucleotideRow from which we will gather values in order to fill any empty values in this CodonNucleotideRow.</param>
        public void FillEmptyValues(CodonNucleotideRow sourceOfFilling)
        {
            if (sourceOfFilling == null)
                return;

            if (this.IsCodonNullOrEmpty)
                this.Codon = sourceOfFilling.Codon;
            if (this.IsNucleotideNullOrEmpty)
                this.Nucleotide = sourceOfFilling.Nucleotide;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
            if (this.IsCodonNullOrEmpty)
                this.Codon = sourceOfFilling.Codon;
            if (this.IsNucleotideNullOrEmpty)
                this.Nucleotide = sourceOfFilling.Nucleotide;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
        }

        /// <summary>
        /// This CodonNucleotideRow used to fulfill the IStrongRowDescendent<T> contact.
        /// </summary>
        public CodonNucleotideRow Self
        {
            get { return this; }
        }

        /// <summary>
        /// Creates a deep copy of the given other CodonNucleotideRow. Fills this CodonNucleotideRow with the values, Foreign StrongRows and ForeignKey StrongRows of the given other CodonNucleotideRow. Fills each child row's children as well.
        /// </summary>
        /// <param name="other">The StrongRow from which values will be populated</param>
        public void PopulateFromRow(CodonNucleotideRow other)
        {
            this.PK_CodonNucleotideID = other.PK_CodonNucleotideID;
            this.Codon = other.Codon;
            this.Nucleotide = other.Nucleotide;
            this.GeneticCode = other.GeneticCode;

            if (other._codonRow != null)
            {
                var codon = other.CodonRow;
                this.CodonRow.PopulateFromRow(codon);
            }
            if (other._nucleotideRow != null)
            {
                var nucleotide = other.NucleotideRow;
                this.NucleotideRow.PopulateFromRow(nucleotide);
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
        /// Gets the CodonNucleotideRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the CodonNucleotideRow</param>
        public static CodonNucleotideRow GetCodonNucleotideRowByID(object ID)
        {
            var codonNucleotideRow = new CodonNucleotideRow();
            Qry.SelectAllFrom(codonNucleotideRow).Where(codonNucleotideRow.PrimaryKeyColumn, ID).Go().ExtractStrongRow(ref codonNucleotideRow);
            return codonNucleotideRow;
        }

        /// <summary>
        /// Gets all of the CodonNucleotideRows in the database.
        /// </summary>
        public static IEnumerable<CodonNucleotideRow> GetAllCodonNucleotideRows()
        {
            return Qry.SelectAllFrom(new CodonNucleotideRow()).Go().ExtractStrongRows<CodonNucleotideRow>();
        }
        #endregion

        #region StrongRow Overrides
        /// <summary>
        /// Gets the CodonNucleotideRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the CodonNucleotideRow</param>
        public override StrongRow GetByID(object ID)
        {
            return CodonNucleotideRow.GetCodonNucleotideRowByID(ID);
        }

        /// <summary>
        /// Gets all of the CodonNucleotideRows in the database.
        /// </summary>
        public override IEnumerable<StrongRow> GetAll()
        {
            return CodonNucleotideRow.GetAllCodonNucleotideRows();
        }
        #endregion

        #region IRepository
        /// <summary>
        /// Gets the CodonNucleotideRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the CodonNucleotideRow</param>
        CodonNucleotideRow IRepository<CodonNucleotideRow>.GetByID(object ID)
        {
            return CodonNucleotideRow.GetCodonNucleotideRowByID(ID);
        }

        /// <summary>
        /// Gets all of the CodonNucleotideRows in the database.
        /// </summary>
        IEnumerable<CodonNucleotideRow> IRepository<CodonNucleotideRow>.GetAll()
        {
            return CodonNucleotideRow.GetAllCodonNucleotideRows();
        }
        #endregion

        /// <summary>
        /// Validates all of the underlying enum values in this CodonNucleotideRow. If there are any errors in the Enum Values, they will be registered with the given SenderIdentifier.
        /// </summary>
        /// <param name="senderIdentifier">The SenderIdentifier used to register Errors in the enum values if any errors exist.</param>
        /// <param name="referenceNumberForErrors">The reference number that will be registered with any Errors.</param>
        public override void ValidateEnumValues(SenderIdentifier senderIdentifier, string referenceNumberForErrors)
        {

        }
    }
}