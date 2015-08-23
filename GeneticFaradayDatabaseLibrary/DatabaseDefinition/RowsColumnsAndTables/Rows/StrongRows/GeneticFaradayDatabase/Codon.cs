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
    /// A Codon in the Genetic Code.
    /// </summary>
    [Serializable]
    public sealed partial class CodonRow : StrongRow, IRepository<CodonRow>, IStrongRowDescendant<CodonRow>
    {
        /// <summary>
        /// This class provides redundant access to the values of the underlying Row in a CodonRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        [Serializable]
        public sealed partial class CodonRowValues
        {
            /// <summary>
            /// PK_CodonID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PK_CodonID
            {
                get { return this.Parent.PK_CodonID; }
                set { this.Parent.PK_CodonID = value; }
            }

            /// <summary>
            /// The CodonIdentifier of this Codon.
            /// </summary>
            public System.String Name
            {
                get { return this.Parent.Name; }
                set { this.Parent.Name = value; }
            }

            /// <summary>
            /// The GeneticCode to which this Codon applies.
            /// </summary>
            public System.Int32 GeneticCode
            {
                get { return this.Parent.GeneticCode; }
                set { this.Parent.GeneticCode = value; }
            }

            /// <summary>
            /// The pair of Functions for which this Codon encodes.
            /// </summary>
            public System.Int32 FunctionPair
            {
                get { return this.Parent.FunctionPair; }
                set { this.Parent.FunctionPair = value; }
            }

            /// <summary>
            /// The type of Codon.
            /// </summary>
            public StrongEnums.CodonType CodonType
            {
                get { return this.Parent.CodonType; }
                set { this.Parent.CodonType = value; }
            }

            /// <summary>
            /// PK_CodonID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PrimaryKey
            {
                get { return this.PK_CodonID; }
                set { this.PK_CodonID = value; }
            }

            /// <summary>
            /// The parent CodonRow whose values will be viewed and manipulated through this CodonRowValues.
            /// </summary>
            public CodonRow Parent { get; private set; }

            /// <summary>
            /// Constructs a CodonRowValues from a parent CodonRow.
            /// </summary>
            /// <param name="parent">The parent CodonRow whose values will be viewed and manipulated through this CodonRowValues.</param>
            public CodonRowValues(CodonRow parent)
            {
                this.Parent = parent;
            }
        }

        /// <summary>
        /// This property provides redundant access to the values of the underlying Row in this CodonRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow.CodonRowValues Values { get; private set; }

        /// <summary>
        /// The StrongRowColumn where the value of PK_CodonID is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _pK_CodonIDColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of PK_CodonID is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn PK_CodonIDColumn
        {
            get
            {
                if (this._pK_CodonIDColumn == null)
                {
                    this.PK_CodonIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.PK_CodonID);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.PK_CodonID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_CodonID_ValueChanged);
                }

                return this._pK_CodonIDColumn;
            }
            private set { this._pK_CodonIDColumn = value; }
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
                    this.NameColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.Name);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.Name].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Name_ValueChanged);
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
                    this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.GeneticCode);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
                }

                return this._geneticCodeColumn;
            }
            private set { this._geneticCodeColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of FunctionPair is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _functionPairColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of FunctionPair is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn FunctionPairColumn
        {
            get
            {
                if (this._functionPairColumn == null)
                {
                    this.FunctionPairColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.FunctionPair);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.FunctionPair].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(FunctionPair_ValueChanged);
                }

                return this._functionPairColumn;
            }
            private set { this._functionPairColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of CodonType is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _codonTypeColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of CodonType is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn CodonTypeColumn
        {
            get
            {
                if (this._codonTypeColumn == null)
                {
                    this.CodonTypeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.CodonType);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.CodonType].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(CodonType_ValueChanged);
                }

                return this._codonTypeColumn;
            }
            private set { this._codonTypeColumn = value; }
        }



        /// <summary>
        /// Raised when the value of PK_CodonID has changed.<para></para><para></para>This will only fire when the value of the property PK_CodonID is set. If the corresponding value is set through the underlying row or through the property PK_CodonIDColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> PK_CodonIDChanged;

        /// <summary>
        /// When raised, indicates that the value of PK_CodonID has changed which fires the PK_CodonIDChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PK_CodonIDChanged event.</param>
        private void OnPK_CodonIDChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (PK_CodonIDChanged != null)
                PK_CodonIDChanged(this, e);
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
        /// Raised when the value of FunctionPair has changed.<para></para><para></para>This will only fire when the value of the property FunctionPair is set. If the corresponding value is set through the underlying row or through the property FunctionPairColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> FunctionPairChanged;

        /// <summary>
        /// When raised, indicates that the value of FunctionPair has changed which fires the FunctionPairChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the FunctionPairChanged event.</param>
        private void OnFunctionPairChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (FunctionPairChanged != null)
                FunctionPairChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of CodonType has changed.<para></para><para></para>This will only fire when the value of the property CodonType is set. If the corresponding value is set through the underlying row or through the property CodonTypeColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<StrongEnums.CodonType>> CodonTypeChanged;

        /// <summary>
        /// When raised, indicates that the value of CodonType has changed which fires the CodonTypeChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the CodonTypeChanged event.</param>
        private void OnCodonTypeChanged(RowValueChangedEventArgs<StrongEnums.CodonType> e)
        {
            if (CodonTypeChanged != null)
                CodonTypeChanged(this, e);
        }



        /// <summary>
        /// PK_CodonID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public System.Int32 PK_CodonID
        {
            get { return this.PK_CodonIDColumn.Value.ToInt(); }
            set { this.PK_CodonIDColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnPK_CodonIDChanged when the value of PK_CodonID in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PK_CodonID_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasPK_CodonIDValueChanged = true;

            // Find the Foreign Key that refers to this Column (if there is any)
            var foreignKeyStrongRows = this.GetForeignKeyColumnsReferringToColumn(PK_CodonIDColumn);
            if (foreignKeyStrongRows != null)
                foreach (var foreignKeyStrongRow in foreignKeyStrongRows)
                    this.Parent.GetStrongRowColumn(foreignKeyStrongRow.ForeignKeyColumn).Value = e.NewValue;

            OnPK_CodonIDChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.PK_CodonIDColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of PK_CodonID in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.PK_CodonID) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsPK_CodonIDNullOrEmpty
        {
            get { return this.PK_CodonIDColumn.Value.IsNullOrDBNull() || this.PK_CodonID == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets PK_CodonID as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PK_CodonIDNullable
        {
            get { return IsPK_CodonIDNullOrEmpty ? null as System.Int32? : this.PK_CodonID; }
        }

        /// <summary>
        /// The CodonIdentifier of this Codon.
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
        /// The GeneticCode to which this Codon applies.
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
        /// The pair of Functions for which this Codon encodes.
        /// </summary>
        public System.Int32 FunctionPair
        {
            get { return this.FunctionPairColumn.Value.ToInt(); }
            set { this.FunctionPairColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnFunctionPairChanged when the value of FunctionPair in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void FunctionPair_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasFunctionPairValueChanged = true;

            // Only update the primary key of the Foreign Row if we need to (so that we don't circularly update the primary keys).
            if (this._functionPairRow != null)
                if (this.FunctionPairRow.PrimaryKey != this.FunctionPair)
                    this.FunctionPairRow.PrimaryKey = this.FunctionPair;

            OnFunctionPairChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.FunctionPairColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of FunctionPair in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.FunctionPair) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsFunctionPairNullOrEmpty
        {
            get { return this.FunctionPairColumn.Value.IsNullOrDBNull() || this.FunctionPair == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets FunctionPair as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? FunctionPairNullable
        {
            get { return IsFunctionPairNullOrEmpty ? null as System.Int32? : this.FunctionPair; }
        }

        /// <summary>
        /// The type of Codon.
        /// </summary>
        public StrongEnums.CodonType CodonType
        {
            get
            {
                if (this.CodonTypeColumn.Value != null)
                    return (StrongEnums.CodonType)this.CodonTypeColumn.Value.ToString();
                else
                    return null;
            }
            set
            {
                if (value == null)
                    throw new Exception("CodonType cannot be null.");

                this.CodonTypeColumn.Value = value;
            }
        }

        /// <summary>
        /// Raises OnCodonTypeChanged when the value of CodonType in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CodonType_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasCodonTypeValueChanged = true;

            // Only update the primary key of the Foreign Row if we need to (so that we don't circularly update the primary keys).
            if (this._codonTypeRow != null && this.CodonType != null)
                if (this.CodonTypeRow.PrimaryKey != this.CodonType)
                    this.CodonTypeRow.PrimaryKey = e.NewValue.ToString();

            OnCodonTypeChanged(new RowValueChangedEventArgs<StrongEnums.CodonType>(e.PreviousValue.IsNullOrDBNull() ? null : (StrongEnums.CodonType)e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : (StrongEnums.CodonType)e.NewValue.ToString(), this.CodonTypeColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of CodonType in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.CodonType) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsCodonTypeNullOrEmpty
        {
            get { return this.CodonTypeColumn.Value.IsNullOrDBNull() || this.CodonType == String.Empty; }
        }

        /// <summary>
        /// Indicates whether any value in this CodonRow that is not a Row (ForeignStrongRow or ForeignKeyStrongRow) is null or DBNull.Value or Empty. If false, all non-row values have values (i.e. are not null).
        /// </summary>
        public override bool IsAnyNonRowValueNullOrEmpty
        {
            get
            {
                if (this.IsPK_CodonIDNullOrEmpty)
                    return true;
                if (this.IsNameNullOrEmpty)
                    return true;
                if (this.IsGeneticCodeNullOrEmpty)
                    return true;
                if (this.IsFunctionPairNullOrEmpty)
                    return true;
                if (this.IsCodonTypeNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Indicates whether the value of PK_CodonID has changed since either this CodonRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasPK_CodonIDValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of Name has changed since either this CodonRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasNameValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of GeneticCode has changed since either this CodonRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasGeneticCodeValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of FunctionPair has changed since either this CodonRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasFunctionPairValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of CodonType has changed since either this CodonRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasCodonTypeValueChanged { get; private set; }

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

                OnGeneticCodeRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.GeneticCode, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.GeneticCode, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this CodonRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this CodonRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// </summary>
        private StrongRowForeignKeyColumn _geneticCodeRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this CodonRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this CodonRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn GeneticCodeRowColumn
        {
            get
            {
                if (this._geneticCodeRowColumn == null)
                    this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.GeneticCode);

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
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.GeneticCode].Value.IsInt() && this.GeneticCode != null)
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
        /// An instance of the FunctionPairRow that stores the values that are referenced by the foreign key column "FunctionPair".
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow _functionPairRow;
        /// <summary>
        /// /// An instance of the FunctionPairRow that stores the values that are referenced by the foreign key column "FunctionPair".
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow FunctionPairRow
        {
            get
            {
                if (this._functionPairRow == null)
                {
                    this._functionPairRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow();
                    this.InitializeFunctionPairRow();
                }

                return _functionPairRow;
            }
            set
            {
                var originalValue = this.FunctionPairRow;
                this._functionPairRow = value;


                this.InitializeFunctionPairRow();

                OnFunctionPairRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.FunctionPair, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.FunctionPair, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this CodonRow to the foreign FunctionPairRow. This contains the ForeignKeyColumn of this CodonRow and the referenced ForeignColumn that will be used to join the FunctionPairRow.
        /// </summary>
        private StrongRowForeignKeyColumn _functionPairRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this CodonRow to the foreign FunctionPairRow. This contains the ForeignKeyColumn of this CodonRow and the referenced ForeignColumn that will be used to join the FunctionPairRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn FunctionPairRowColumn
        {
            get
            {
                if (this._functionPairRowColumn == null)
                    this.FunctionPairRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.FunctionPairRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.FunctionPair);

                return this._functionPairRowColumn;
            }
            private set { this._functionPairRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of FunctionPairRow has changed (is NOT raised when a value inside FunctionPairRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow>> FunctionPairRowChanged;

        /// <summary>
        /// Indicates that the value of FunctionPair has changed which fires the FunctionPairChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the FunctionPairRowChanged event.</param>
        private void OnFunctionPairRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow> e)
        {
            if (FunctionPairRowChanged != null)
                FunctionPairRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignStrongRow FunctionPairRow.
        /// </summary>
        private void SubscribeToValueChangesOfFunctionPairRow()
        {
            if (this.FunctionPairRow != null)
                this.FunctionPairRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when initializing the value of FunctionPairRow.
        /// </summary>
        private void InitializeFunctionPairRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.FunctionPairRow))
                this.OtherRowTableAliases.Remove(this.FunctionPairRow);

            this.FunctionPairRowColumn.ForeignRow = this.FunctionPairRow;

            this.OtherRowTableAliases.Add(this.FunctionPairRow, "functionPair");
            this.FunctionPairRow.Parent = this;
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.FunctionPair].Value.IsInt() && this.FunctionPair != null)
                this.FunctionPairRow.PrimaryKey = this.FunctionPair;
            SubscribeToValueChangesOfFunctionPairRow();
        }

        /// <summary>
        /// Indicates whether the value of the FunctionPairRow is null or DBNull.Value (does not Initialize the FunctionPairRow if it is currently null).
        /// </summary>
        public bool IsFunctionPairRowNull
        {
            get { return this._functionPairRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// An instance of the CodonTypeRow that stores the values that are referenced by the foreign key column "CodonType".
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow _codonTypeRow;
        /// <summary>
        /// /// An instance of the CodonTypeRow that stores the values that are referenced by the foreign key column "CodonType".
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow CodonTypeRow
        {
            get
            {
                if (this._codonTypeRow == null)
                {
                    this._codonTypeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow();
                    this.InitializeCodonTypeRow();
                }

                return _codonTypeRow;
            }
            set
            {
                var originalValue = this.CodonTypeRow;
                this._codonTypeRow = value;


                this.InitializeCodonTypeRow();

                OnCodonTypeRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.CodonType, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.CodonType, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this CodonRow to the foreign CodonTypeRow. This contains the ForeignKeyColumn of this CodonRow and the referenced ForeignColumn that will be used to join the CodonTypeRow.
        /// </summary>
        private StrongRowForeignKeyColumn _codonTypeRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this CodonRow to the foreign CodonTypeRow. This contains the ForeignKeyColumn of this CodonRow and the referenced ForeignColumn that will be used to join the CodonTypeRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn CodonTypeRowColumn
        {
            get
            {
                if (this._codonTypeRowColumn == null)
                    this.CodonTypeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.CodonTypeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.CodonType);

                return this._codonTypeRowColumn;
            }
            private set { this._codonTypeRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of CodonTypeRow has changed (is NOT raised when a value inside CodonTypeRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow>> CodonTypeRowChanged;

        /// <summary>
        /// Indicates that the value of CodonType has changed which fires the CodonTypeChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the CodonTypeRowChanged event.</param>
        private void OnCodonTypeRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow> e)
        {
            if (CodonTypeRowChanged != null)
                CodonTypeRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignStrongRow CodonTypeRow.
        /// </summary>
        private void SubscribeToValueChangesOfCodonTypeRow()
        {
            if (this.CodonTypeRow != null)
                this.CodonTypeRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when initializing the value of CodonTypeRow.
        /// </summary>
        private void InitializeCodonTypeRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.CodonTypeRow))
                this.OtherRowTableAliases.Remove(this.CodonTypeRow);

            this.CodonTypeRowColumn.ForeignRow = this.CodonTypeRow;

            this.OtherRowTableAliases.Add(this.CodonTypeRow, "codonType");
            this.CodonTypeRow.Parent = this;
            if (this.CodonType != null)
                this.CodonTypeRow.PrimaryKey = this.CodonType;
            SubscribeToValueChangesOfCodonTypeRow();
        }

        /// <summary>
        /// Indicates whether the value of the CodonTypeRow is null or DBNull.Value (does not Initialize the CodonTypeRow if it is currently null).
        /// </summary>
        public bool IsCodonTypeRowNull
        {
            get { return this._codonTypeRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// Indicates whether any Foreign StrongRow in this CodonRow is null or DBNull.Value or empty.
        /// </summary>
        public override bool IsAnyForeignRowNull
        {
            get
            {
                if (this.IsGeneticCodeNullOrEmpty)
                    return true;
                if (this.IsFunctionPairNullOrEmpty)
                    return true;
                if (this.IsCodonTypeNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow that stores the values of the ForeignKey Strong Row if it were joined to this CodonRow on the Foreign Key Column "Codon". This CodonRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_CodonNucleotide_CodonRow ForeignKeyStrongRow.
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow _foreignKeyRow_CodonNucleotide_CodonRow;
        /// <summary>
        /// /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow that stores the values of the ForeignKey Strong Row if it were joined to this CodonRow on the Foreign Key Column "Codon". This CodonRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_CodonNucleotide_CodonRow ForeignKeyStrongRow.
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow ForeignKeyRow_CodonNucleotide_CodonRow
        {
            get
            {
                if (this._foreignKeyRow_CodonNucleotide_CodonRow == null)
                {
                    this._foreignKeyRow_CodonNucleotide_CodonRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow();
                    this.InitializeForeignKeyRow_CodonNucleotide_CodonRow();
                }

                return _foreignKeyRow_CodonNucleotide_CodonRow;
            }
            set
            {
                var originalValue = this.ForeignKeyRow_CodonNucleotide_CodonRow;
                this._foreignKeyRow_CodonNucleotide_CodonRow = value;


                this.InitializeForeignKeyRow_CodonNucleotide_CodonRow();

                OnForeignKeyRow_CodonNucleotide_CodonRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Codon, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Codon, this, RowValueType.ForeignKeyStrongRow));
            }
        }

        /// <summary>
        /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "Codon" that belongs to ForeignKey StrongRow "ForeignKeyRow_CodonNucleotide_CodonRow" (which is a different StrongRow than this CodonRow). This ForeignKeyToThisStrongRowColumn that can be used to join this CodonRow to the ForeignKeyStrongRow "ForeignKeyRow_CodonNucleotide_CodonRow.
        /// </summary>
        private ForeignKeyToThisStrongRowColumn _foreignKeyRow_CodonNucleotide_CodonRowColumn;
        /// <summary>
        /// /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "Codon" that belongs to ForeignKey StrongRow "ForeignKeyRow_CodonNucleotide_CodonRow" (which is a different StrongRow than this CodonRow). This ForeignKeyToThisStrongRowColumn that can be used to join this CodonRow to the ForeignKeyStrongRow "ForeignKeyRow_CodonNucleotide_CodonRow.
        /// /// </summary>
        public ForeignKeyToThisStrongRowColumn ForeignKeyRow_CodonNucleotide_CodonRowColumn
        {
            get
            {
                if (this._foreignKeyRow_CodonNucleotide_CodonRowColumn == null)
                    this.ForeignKeyRow_CodonNucleotide_CodonRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_CodonNucleotide_CodonRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Codon);

                return this._foreignKeyRow_CodonNucleotide_CodonRowColumn;
            }
            private set { this._foreignKeyRow_CodonNucleotide_CodonRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ForeignKeyRow_CodonNucleotide_CodonRow has changed (is NOT raised when a value inside ForeignKeyRow_CodonNucleotide_CodonRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow>> ForeignKeyRow_CodonNucleotide_CodonRowChanged;

        /// <summary>
        /// Indicates that the value of Codon has changed which fires the CodonChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ForeignKeyRow_CodonNucleotide_CodonRowChanged event.</param>
        private void OnForeignKeyRow_CodonNucleotide_CodonRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow> e)
        {
            if (ForeignKeyRow_CodonNucleotide_CodonRowChanged != null)
                ForeignKeyRow_CodonNucleotide_CodonRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignKeyStrongRow ForeignKeyRow_CodonNucleotide_CodonRow.
        /// </summary>
        private void SubscribeToValueChangesOfForeignKeyRow_CodonNucleotide_CodonRow()
        {
            if (this.ForeignKeyRow_CodonNucleotide_CodonRow != null)
                this.ForeignKeyRow_CodonNucleotide_CodonRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignKeyStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when setting the value of ForeignKeyRow_CodonNucleotide_CodonRow.
        /// </summary>
        private void InitializeForeignKeyRow_CodonNucleotide_CodonRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ForeignKeyRow_CodonNucleotide_CodonRow))
                this.OtherRowTableAliases.Remove(this.ForeignKeyRow_CodonNucleotide_CodonRow);

            this.ForeignKeyRow_CodonNucleotide_CodonRowColumn.ForeignKeyRow = this.ForeignKeyRow_CodonNucleotide_CodonRow;

            this.OtherRowTableAliases.Add(this.ForeignKeyRow_CodonNucleotide_CodonRow, "foreignKey_CodonNucleotide_Codon");
            this.ForeignKeyRow_CodonNucleotide_CodonRow.Parent = this;
            SubscribeToValueChangesOfForeignKeyRow_CodonNucleotide_CodonRow();
        }

        /// <summary>
        /// Indicates whether the value of the ForeignKeyRow_CodonNucleotide_CodonRow is null or DBNull.Value (does not Initialize the ForeignKeyRow_CodonNucleotide_CodonRow if it is currently null).
        /// </summary>
        public bool IsForeignKeyRow_CodonNucleotide_CodonRowNull
        {
            get { return this._foreignKeyRow_CodonNucleotide_CodonRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// Constructs an instance of this CodonRow from a specified Row.<para></para><para></para>NO STRONG ROW COLUMNS WILL BE INITIALIZED. This simply creates a wrapper around the Row in order to access the Row Values. It is helpful for performance.
        /// </summary>
        /// <param name="codonRow">A Codon in the Genetic Code.</param>
        public CodonRow(Row codonRow)
            : this()
        {
            this.Row = codonRow;
        }

        /// <summary>
        /// Constructs an instance of this CodonRow from a specified global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonRowSerializableContainer.
        /// </summary>
        /// <param name="codonRowSerializableContainer">A Codon in the Genetic Code.</param>
        public CodonRow(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonRowSerializableContainer codonRowSerializableContainer)
            : this()
        {
            this.Row = new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable);

            this.PK_CodonID = codonRowSerializableContainer.PK_CodonID;
            this.Name = codonRowSerializableContainer.Name;
            this.GeneticCode = codonRowSerializableContainer.GeneticCode;
            this.FunctionPair = codonRowSerializableContainer.FunctionPair;
            this.CodonType = codonRowSerializableContainer.CodonType;
            if (codonRowSerializableContainer.GeneticCodeRowSerializableContainer != null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow(codonRowSerializableContainer.GeneticCodeRowSerializableContainer);
            if (codonRowSerializableContainer.FunctionPairRowSerializableContainer != null)
                this.FunctionPairRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow(codonRowSerializableContainer.FunctionPairRowSerializableContainer);
            if (codonRowSerializableContainer.ForeignKeyRow_CodonNucleotide_CodonRowSerializableContainer != null)
                this.ForeignKeyRow_CodonNucleotide_CodonRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow(codonRowSerializableContainer.ForeignKeyRow_CodonNucleotide_CodonRowSerializableContainer);
        }

        /// <summary>
        /// Constructs an instance of this CodonRow from a set of values for the Row.
        /// </summary>
        /// <param name="name">The CodonIdentifier of this Codon.</param>
        /// <param name="geneticCode">The GeneticCode to which this Codon applies.</param>
        /// <param name="functionPair">The pair of Functions for which this Codon encodes.</param>
        /// <param name="codonType">The type of Codon.</param>
        /// <param name="geneticCodeRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow that holds the values of the row that the foreign key "GeneticCode" is referencing. Row Description: A Codon in the Genetic Code.</param>
        /// <param name="functionPairRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow that holds the values of the row that the foreign key "FunctionPair" is referencing. Row Description: A Codon in the Genetic Code.</param>
        /// <param name="codonTypeRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow that holds the values of the row that the foreign key "CodonType" is referencing. Row Description: A Codon in the Genetic Code.</param>
        public CodonRow(System.String name, System.Int32 geneticCode, System.Int32 functionPair, StrongEnums.CodonType codonType, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow geneticCodeRow = null, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow functionPairRow = null, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow codonTypeRow = null)
            : this()
        {
            if (this.Row != null)
                this.Row = global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.ToRow(name: name, geneticCode: geneticCode, functionPair: functionPair, codonType: codonType);
            this.GeneticCodeRow = geneticCodeRow;
            this.FunctionPairRow = functionPairRow;
            this.CodonTypeRow = codonTypeRow;
        }

        /// <summary>
        /// Constructs an instance of a CodonRow
        /// </summary>
        public CodonRow()
            : base(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable)
        {
            this.Values = new CodonRowValues(this);
        }

        /// <summary>
        /// The TableDefinition of this CodonRow
        /// </summary>
        public override TableDefinition TableDefinition
        {
            get { return this.GetTableDefinition(); }
        }

        /// <summary>
        /// Gets the TableDefinition of this CodonRow
        /// </summary>
        public override TableDefinition GetTableDefinition()
        {
            return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable;
        }

        /// <summary>
        /// The TableDefinition of this CodonRow
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.CodonTable CodonTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonTable; }
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
                case "functionPair":
                    if (this._functionPairRow == null)
                    {
                        this._functionPairRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow();
                        this.InitializeFunctionPairRow();
                    }
                    return;
                case "FP12otu31":
                    if (this._functionPairRow == null)
                    {
                        this._functionPairRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow();
                        this.InitializeFunctionPairRow();
                    }
                    return;
                case "codonType":
                    if (this._codonTypeRow == null)
                    {
                        this._codonTypeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow();
                        this.InitializeCodonTypeRow();
                    }
                    return;
                case "CT9yno30":
                    if (this._codonTypeRow == null)
                    {
                        this._codonTypeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow();
                        this.InitializeCodonTypeRow();
                    }
                    return;
                case "foreignKey_CodonNucleotide_Codon":
                    if (this._foreignKeyRow_CodonNucleotide_CodonRow == null)
                    {
                        this._foreignKeyRow_CodonNucleotide_CodonRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow();
                        this.InitializeForeignKeyRow_CodonNucleotide_CodonRow();
                    }
                    return;
                case "_CNC32nio63":
                    if (this._foreignKeyRow_CodonNucleotide_CodonRow == null)
                    {
                        this._foreignKeyRow_CodonNucleotide_CodonRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow();
                        this.InitializeForeignKeyRow_CodonNucleotide_CodonRow();
                    }
                    return;
                default:
                    throw new Exception("The given table alias does not refer to any child StrongRow in this CodonRow.");
                    return;

            }
        }

        /// <summary>
        /// Initializes all of the Foreign Strong Rows and Foreign Key StrongRows in this CodonRow that are currently null. Calls the parameterless constructor for each Strong Row that is null.
        /// </summary>
        public override void InitializeChildStrongRows()
        {
            if (this.GeneticCodeRow == null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow();
            if (this.FunctionPairRow == null)
                this.FunctionPairRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow();
            if (this.CodonTypeRow == null)
                this.CodonTypeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonTypeRow();

            if (this.ForeignKeyRow_CodonNucleotide_CodonRow == null)
                this.ForeignKeyRow_CodonNucleotide_CodonRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonNucleotideRow();
        }

        /// <summary>
        /// Initializes all of the StrongRowColumns in this CodonRow that are currently null. Also handles the necessary event subscriptions.
        /// </summary>
        public override void InitializeStrongRowColumns()
        {
            if (this.PK_CodonIDColumn == null)
            {
                this.PK_CodonIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.PK_CodonID);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.PK_CodonID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_CodonID_ValueChanged);
            }
            if (this.NameColumn == null)
            {
                this.NameColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.Name);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.Name].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Name_ValueChanged);
            }
            if (this.GeneticCodeColumn == null)
            {
                this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.GeneticCode);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
            }
            if (this.FunctionPairColumn == null)
            {
                this.FunctionPairColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.FunctionPair);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.FunctionPair].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(FunctionPair_ValueChanged);
            }
            if (this.CodonTypeColumn == null)
            {
                this.CodonTypeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.CodonType);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.CodonType].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(CodonType_ValueChanged);
            }
        }

        /// <summary>
        /// Initializes all of the ForeignStrongRowColumns in this CodonRow that are null.
        /// </summary>
        public override void InitializeForeignStrongRowColumns()
        {
            if (this.GeneticCodeRowColumn == null)
                this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.GeneticCode);
            if (this.FunctionPairRowColumn == null)
                this.FunctionPairRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.FunctionPairRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.FunctionPair);
            if (this.CodonTypeRowColumn == null)
                this.CodonTypeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.CodonTypeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.CodonType);
        }

        /// <summary>
        /// Initializes all of the ForeignKeyToThisStrongRowColumns in this CodonRow that are null.
        /// </summary>
        public override void InitializeForeignKeyToThisStrongRowColumns()
        {
            if (this.ForeignKeyRow_CodonNucleotide_CodonRowColumn == null)
                this.ForeignKeyRow_CodonNucleotide_CodonRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_CodonNucleotide_CodonRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonNucleotide.Codon);
        }

        /// <summary>
        /// Inserts the Row into the database immediately (if it is not currently in the database. This method first checks to ensure that the Row is not in the database). Returns true if the Row was inserted. Returns false if not. Out's the primary key.
        /// </summary>
        /// <param name="primaryKey">PK_CodonID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// <param name="primaryKey">PK_CodonID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// Indicates whether the Primary Key PK_CodonID is null or DBNull.Value or is an Empty value.
        /// </summary>
        public override bool IsPrimaryKeyNullOrEmpty
        {
            get { return this.IsPK_CodonIDNullOrEmpty; }
        }

        /// <summary>
        /// The Primary Key PK_CodonID for this Codon.
        /// </summary>
        public System.Int32 PrimaryKey
        {
            get { return this.PK_CodonID; }
            set { this.PK_CodonID = value; }
        }

        /// <summary>
        /// The Primary Key Column for this Codon.
        /// </summary>
        public override StrongRowColumn PrimaryKeyColumn
        {
            get { return this.PK_CodonIDColumn; }
        }

        /// <summary>
        /// Gets the Primary Key as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PrimaryKeyNullable
        {
            get { return this.IsPrimaryKeyNullOrEmpty ? null as System.Int32? : this.PrimaryKey; }
        }

        /// <summary>
        /// Returns all of the Columns in the CodonRow whose values have changed according to their HasChanged flags.
        /// </summary>
        public override List<Column> GetColumnsWithChangedValues()
        {
            // If no value in this row has changed then return an empty list.
            if (!this.HasAnyNonRowValueInRowChanged)
                return new List<Column>(0);

            // We will collect the columns whose values have changed.
            var columns = new List<Column>();

            if (HasPK_CodonIDValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.PK_CodonID);
            if (HasNameValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.Name);
            if (HasGeneticCodeValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.GeneticCode);
            if (HasFunctionPairValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.FunctionPair);
            if (HasCodonTypeValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.CodonType);

            return columns;
        }

        /// <summary>
        /// Calls ResetAllHasAnyValueChangedFlags() for this CodonRow and ResetAllThisAndChildrenHasAnyValueChangedFlags() for all children Foreign StrongRows and Foreign Key Strong Rows that are not null.
        /// </summary>
        public override void ResetAllThisAndChildrenHasAnyValueChangedFlags()
        {
            this.ResetAllHasAnyValueChangedFlags();

            if (this._geneticCodeRow != null)
                this.GeneticCodeRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._functionPairRow != null)
                this.FunctionPairRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._codonTypeRow != null)
                this.CodonTypeRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._foreignKeyRow_CodonNucleotide_CodonRow != null)
                this.ForeignKeyRow_CodonNucleotide_CodonRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
        }

        /// <summary>
        /// Resets all of the HasAnyValuesChanged for each of the values in this CodonRow. Also calls the base.ResetAllHasAnyValueChangedFlags().
        /// </summary>
        public override void ResetAllHasAnyValueChangedFlags()
        {
            base.ResetAllHasAnyValueChangedFlags();

            this.HasPK_CodonIDValueChanged = false;
            this.HasNameValueChanged = false;
            this.HasGeneticCodeValueChanged = false;
            this.HasFunctionPairValueChanged = false;
            this.HasCodonTypeValueChanged = false;
        }

        /// <summary>
        /// Gets all of the StrongRowColumns in this CodonRow.
        /// </summary>
        public override StrongRowColumn[] GetAllStrongRowColumns()
        {
            return new StrongRowColumn[] { PK_CodonIDColumn, NameColumn, GeneticCodeColumn, FunctionPairColumn, CodonTypeColumn };
        }

        /// <summary>
        /// Gets all of the StrongRowForeignKeyColumns in this CodonRow.
        /// </summary>
        public override StrongRowForeignKeyColumn[] GetAllStrongRowForeignKeyColumns()
        {
            return new StrongRowForeignKeyColumn[] { GeneticCodeRowColumn, FunctionPairRowColumn, CodonTypeRowColumn };
        }

        /// <summary>
        /// Gets all of the ForeignKeyToThisStrongRowColumn in this CodonRow.
        /// </summary>
        public override ForeignKeyToThisStrongRowColumn[] GetAllForeignKeyToThisStrongRowColumns()
        {
            return new ForeignKeyToThisStrongRowColumn[] { ForeignKeyRow_CodonNucleotide_CodonRowColumn };
        }

        /// <summary>
        /// Converts the CodonRow to a CodonRowSerializableContainer.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonRowSerializableContainer ToCodonRowSerializableContainer()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.CodonRowSerializableContainer(this);
        }

        /// <summary>
        /// Converts the StrongRow to the appropriate StrongRowSerializableContainer.
        /// </summary>
        public override StrongRowSerializableContainer ToStrongRowSerializableContainer()
        {
            return this.ToCodonRowSerializableContainer();
        }

        #region IStrongRowDescendant<T>
        /// <summary>
        /// Fills any empty values in this CodonRow with the corresponding values from the given CodonRow. Does NOT fill the Primary Key.
        /// </summary>
        /// <param name="sourceOfFilling">The CodonRow from which we will gather values in order to fill any empty values in this CodonRow.</param>
        public void FillEmptyValues(CodonRow sourceOfFilling)
        {
            if (sourceOfFilling == null)
                return;

            if (this.IsNameNullOrEmpty)
                this.Name = sourceOfFilling.Name;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
            if (this.IsFunctionPairNullOrEmpty)
                this.FunctionPair = sourceOfFilling.FunctionPair;
            if (this.IsCodonTypeNullOrEmpty)
                this.CodonType = sourceOfFilling.CodonType;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
            if (this.IsFunctionPairNullOrEmpty)
                this.FunctionPair = sourceOfFilling.FunctionPair;
            if (this.IsCodonTypeNullOrEmpty)
                this.CodonType = sourceOfFilling.CodonType;
        }

        /// <summary>
        /// This CodonRow used to fulfill the IStrongRowDescendent<T> contact.
        /// </summary>
        public CodonRow Self
        {
            get { return this; }
        }

        /// <summary>
        /// Creates a deep copy of the given other CodonRow. Fills this CodonRow with the values, Foreign StrongRows and ForeignKey StrongRows of the given other CodonRow. Fills each child row's children as well.
        /// </summary>
        /// <param name="other">The StrongRow from which values will be populated</param>
        public void PopulateFromRow(CodonRow other)
        {
            this.PK_CodonID = other.PK_CodonID;
            this.Name = other.Name;
            this.GeneticCode = other.GeneticCode;
            this.FunctionPair = other.FunctionPair;
            this.CodonType = other.CodonType;

            if (other._geneticCodeRow != null)
            {
                var geneticCode = other.GeneticCodeRow;
                this.GeneticCodeRow.PopulateFromRow(geneticCode);
            }
            if (other._functionPairRow != null)
            {
                var functionPair = other.FunctionPairRow;
                this.FunctionPairRow.PopulateFromRow(functionPair);
            }
            if (other._codonTypeRow != null)
            {
                var codonType = other.CodonTypeRow;
                this.CodonTypeRow.PopulateFromRow(codonType);
            }
            if (other._foreignKeyRow_CodonNucleotide_CodonRow != null)
            {
                var codonNucleotide_CodonRow = other.ForeignKeyRow_CodonNucleotide_CodonRow;
                this.ForeignKeyRow_CodonNucleotide_CodonRow.PopulateFromRow(codonNucleotide_CodonRow);
            }
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Gets the CodonRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the CodonRow</param>
        public static CodonRow GetCodonRowByID(object ID)
        {
            var codonRow = new CodonRow();
            Qry.SelectAllFrom(codonRow).Where(codonRow.PrimaryKeyColumn, ID).Go().ExtractStrongRow(ref codonRow);
            return codonRow;
        }

        /// <summary>
        /// Gets all of the CodonRows in the database.
        /// </summary>
        public static IEnumerable<CodonRow> GetAllCodonRows()
        {
            return Qry.SelectAllFrom(new CodonRow()).Go().ExtractStrongRows<CodonRow>();
        }
        #endregion

        #region StrongRow Overrides
        /// <summary>
        /// Gets the CodonRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the CodonRow</param>
        public override StrongRow GetByID(object ID)
        {
            return CodonRow.GetCodonRowByID(ID);
        }

        /// <summary>
        /// Gets all of the CodonRows in the database.
        /// </summary>
        public override IEnumerable<StrongRow> GetAll()
        {
            return CodonRow.GetAllCodonRows();
        }
        #endregion

        #region IRepository
        /// <summary>
        /// Gets the CodonRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the CodonRow</param>
        CodonRow IRepository<CodonRow>.GetByID(object ID)
        {
            return CodonRow.GetCodonRowByID(ID);
        }

        /// <summary>
        /// Gets all of the CodonRows in the database.
        /// </summary>
        IEnumerable<CodonRow> IRepository<CodonRow>.GetAll()
        {
            return CodonRow.GetAllCodonRows();
        }
        #endregion

        /// <summary>
        /// Validates all of the underlying enum values in this CodonRow. If there are any errors in the Enum Values, they will be registered with the given SenderIdentifier.
        /// </summary>
        /// <param name="senderIdentifier">The SenderIdentifier used to register Errors in the enum values if any errors exist.</param>
        /// <param name="referenceNumberForErrors">The reference number that will be registered with any Errors.</param>
        public override void ValidateEnumValues(SenderIdentifier senderIdentifier, string referenceNumberForErrors)
        {
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.CodonType].Value != null && !StrongEnums.CodonType.IsValidEnum(this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.CodonType].Value.ToString()))
            {
                senderIdentifier.RegisterError(new Error(referenceNumberForErrors, "Invalid Value for CodonType. Value: " + this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.CodonType].Value.ToString() + "."));
            }
        }
    }
}