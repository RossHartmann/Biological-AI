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
    /// The rules to which an Organism must abide.
    /// </summary>
    [Serializable]
    public sealed partial class GeneticCodeRow : StrongRow, IRepository<GeneticCodeRow>, IStrongRowDescendant<GeneticCodeRow>
    {
        /// <summary>
        /// This class provides redundant access to the values of the underlying Row in a GeneticCodeRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        [Serializable]
        public sealed partial class GeneticCodeRowValues
        {
            /// <summary>
            /// PK_GeneticCodeID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PK_GeneticCodeID
            {
                get { return this.Parent.PK_GeneticCodeID; }
                set { this.Parent.PK_GeneticCodeID = value; }
            }

            /// <summary>
            /// The name of the Genetic Code.
            /// </summary>
            public System.String Name
            {
                get { return this.Parent.Name; }
                set { this.Parent.Name = value; }
            }

            /// <summary>
            /// The length of every Codon in the GeneticCode. All Codons must be of this length.
            /// </summary>
            public System.Int32 CodonLength
            {
                get { return this.Parent.CodonLength; }
                set { this.Parent.CodonLength = value; }
            }

            /// <summary>
            /// The maximum number of IFunctions that take parameters that can be used in an IAllele's IDNA. After (or before) this number of IFunctions (with parameters) have been called, the rest of the IFunctions in the IDNA will not accept any parameters (i.e. they  will be terminals).
            /// </summary>
            public System.Int32 MaxParameterfulFunctionsInDNA
            {
                get { return this.Parent.MaxParameterfulFunctionsInDNA; }
                set { this.Parent.MaxParameterfulFunctionsInDNA = value; }
            }

            /// <summary>
            /// The number of IParameters used by the IFunction that has the most parameters.
            /// </summary>
            public System.Int32 MaximumFunctionInputsUsed
            {
                get { return this.Parent.MaximumFunctionInputsUsed; }
                set { this.Parent.MaximumFunctionInputsUsed = value; }
            }

            /// <summary>
            /// The maximum recursion level that's allowable. If this value is reached by an IGEPGene, the execution of the IGEPGene will be aborted.
            /// </summary>
            public System.Int32 MaxRecursionLevel
            {
                get { return this.Parent.MaxRecursionLevel; }
                set { this.Parent.MaxRecursionLevel = value; }
            }

            /// <summary>
            /// PK_GeneticCodeID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PrimaryKey
            {
                get { return this.PK_GeneticCodeID; }
                set { this.PK_GeneticCodeID = value; }
            }

            /// <summary>
            /// The parent GeneticCodeRow whose values will be viewed and manipulated through this GeneticCodeRowValues.
            /// </summary>
            public GeneticCodeRow Parent { get; private set; }

            /// <summary>
            /// Constructs a GeneticCodeRowValues from a parent GeneticCodeRow.
            /// </summary>
            /// <param name="parent">The parent GeneticCodeRow whose values will be viewed and manipulated through this GeneticCodeRowValues.</param>
            public GeneticCodeRowValues(GeneticCodeRow parent)
            {
                this.Parent = parent;
            }
        }

        /// <summary>
        /// This property provides redundant access to the values of the underlying Row in this GeneticCodeRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow.GeneticCodeRowValues Values { get; private set; }

        /// <summary>
        /// The StrongRowColumn where the value of PK_GeneticCodeID is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _pK_GeneticCodeIDColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of PK_GeneticCodeID is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn PK_GeneticCodeIDColumn
        {
            get
            {
                if (this._pK_GeneticCodeIDColumn == null)
                {
                    this.PK_GeneticCodeIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.PK_GeneticCodeID);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.PK_GeneticCodeID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_GeneticCodeID_ValueChanged);
                }

                return this._pK_GeneticCodeIDColumn;
            }
            private set { this._pK_GeneticCodeIDColumn = value; }
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
                    this.NameColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.Name);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.Name].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Name_ValueChanged);
                }

                return this._nameColumn;
            }
            private set { this._nameColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of CodonLength is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _codonLengthColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of CodonLength is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn CodonLengthColumn
        {
            get
            {
                if (this._codonLengthColumn == null)
                {
                    this.CodonLengthColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.CodonLength);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.CodonLength].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(CodonLength_ValueChanged);
                }

                return this._codonLengthColumn;
            }
            private set { this._codonLengthColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of MaxParameterfulFunctionsInDNA is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _maxParameterfulFunctionsInDNAColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of MaxParameterfulFunctionsInDNA is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn MaxParameterfulFunctionsInDNAColumn
        {
            get
            {
                if (this._maxParameterfulFunctionsInDNAColumn == null)
                {
                    this.MaxParameterfulFunctionsInDNAColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.MaxParameterfulFunctionsInDNA);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.MaxParameterfulFunctionsInDNA].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(MaxParameterfulFunctionsInDNA_ValueChanged);
                }

                return this._maxParameterfulFunctionsInDNAColumn;
            }
            private set { this._maxParameterfulFunctionsInDNAColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of MaximumFunctionInputsUsed is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _maximumFunctionInputsUsedColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of MaximumFunctionInputsUsed is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn MaximumFunctionInputsUsedColumn
        {
            get
            {
                if (this._maximumFunctionInputsUsedColumn == null)
                {
                    this.MaximumFunctionInputsUsedColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.MaximumFunctionInputsUsed);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.MaximumFunctionInputsUsed].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(MaximumFunctionInputsUsed_ValueChanged);
                }

                return this._maximumFunctionInputsUsedColumn;
            }
            private set { this._maximumFunctionInputsUsedColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of MaxRecursionLevel is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _maxRecursionLevelColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of MaxRecursionLevel is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn MaxRecursionLevelColumn
        {
            get
            {
                if (this._maxRecursionLevelColumn == null)
                {
                    this.MaxRecursionLevelColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.MaxRecursionLevel);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.MaxRecursionLevel].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(MaxRecursionLevel_ValueChanged);
                }

                return this._maxRecursionLevelColumn;
            }
            private set { this._maxRecursionLevelColumn = value; }
        }



        /// <summary>
        /// Raised when the value of PK_GeneticCodeID has changed.<para></para><para></para>This will only fire when the value of the property PK_GeneticCodeID is set. If the corresponding value is set through the underlying row or through the property PK_GeneticCodeIDColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> PK_GeneticCodeIDChanged;

        /// <summary>
        /// When raised, indicates that the value of PK_GeneticCodeID has changed which fires the PK_GeneticCodeIDChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PK_GeneticCodeIDChanged event.</param>
        private void OnPK_GeneticCodeIDChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (PK_GeneticCodeIDChanged != null)
                PK_GeneticCodeIDChanged(this, e);
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
        /// Raised when the value of CodonLength has changed.<para></para><para></para>This will only fire when the value of the property CodonLength is set. If the corresponding value is set through the underlying row or through the property CodonLengthColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> CodonLengthChanged;

        /// <summary>
        /// When raised, indicates that the value of CodonLength has changed which fires the CodonLengthChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the CodonLengthChanged event.</param>
        private void OnCodonLengthChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (CodonLengthChanged != null)
                CodonLengthChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of MaxParameterfulFunctionsInDNA has changed.<para></para><para></para>This will only fire when the value of the property MaxParameterfulFunctionsInDNA is set. If the corresponding value is set through the underlying row or through the property MaxParameterfulFunctionsInDNAColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> MaxParameterfulFunctionsInDNAChanged;

        /// <summary>
        /// When raised, indicates that the value of MaxParameterfulFunctionsInDNA has changed which fires the MaxParameterfulFunctionsInDNAChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the MaxParameterfulFunctionsInDNAChanged event.</param>
        private void OnMaxParameterfulFunctionsInDNAChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (MaxParameterfulFunctionsInDNAChanged != null)
                MaxParameterfulFunctionsInDNAChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of MaximumFunctionInputsUsed has changed.<para></para><para></para>This will only fire when the value of the property MaximumFunctionInputsUsed is set. If the corresponding value is set through the underlying row or through the property MaximumFunctionInputsUsedColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> MaximumFunctionInputsUsedChanged;

        /// <summary>
        /// When raised, indicates that the value of MaximumFunctionInputsUsed has changed which fires the MaximumFunctionInputsUsedChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the MaximumFunctionInputsUsedChanged event.</param>
        private void OnMaximumFunctionInputsUsedChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (MaximumFunctionInputsUsedChanged != null)
                MaximumFunctionInputsUsedChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of MaxRecursionLevel has changed.<para></para><para></para>This will only fire when the value of the property MaxRecursionLevel is set. If the corresponding value is set through the underlying row or through the property MaxRecursionLevelColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> MaxRecursionLevelChanged;

        /// <summary>
        /// When raised, indicates that the value of MaxRecursionLevel has changed which fires the MaxRecursionLevelChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the MaxRecursionLevelChanged event.</param>
        private void OnMaxRecursionLevelChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (MaxRecursionLevelChanged != null)
                MaxRecursionLevelChanged(this, e);
        }



        /// <summary>
        /// PK_GeneticCodeID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public System.Int32 PK_GeneticCodeID
        {
            get { return this.PK_GeneticCodeIDColumn.Value.ToInt(); }
            set { this.PK_GeneticCodeIDColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnPK_GeneticCodeIDChanged when the value of PK_GeneticCodeID in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PK_GeneticCodeID_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasPK_GeneticCodeIDValueChanged = true;

            // Find the Foreign Key that refers to this Column (if there is any)
            var foreignKeyStrongRows = this.GetForeignKeyColumnsReferringToColumn(PK_GeneticCodeIDColumn);
            if (foreignKeyStrongRows != null)
                foreach (var foreignKeyStrongRow in foreignKeyStrongRows)
                    this.Parent.GetStrongRowColumn(foreignKeyStrongRow.ForeignKeyColumn).Value = e.NewValue;

            OnPK_GeneticCodeIDChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.PK_GeneticCodeIDColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of PK_GeneticCodeID in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.PK_GeneticCodeID) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsPK_GeneticCodeIDNullOrEmpty
        {
            get { return this.PK_GeneticCodeIDColumn.Value.IsNullOrDBNull() || this.PK_GeneticCodeID == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets PK_GeneticCodeID as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PK_GeneticCodeIDNullable
        {
            get { return IsPK_GeneticCodeIDNullOrEmpty ? null as System.Int32? : this.PK_GeneticCodeID; }
        }

        /// <summary>
        /// The name of the Genetic Code.
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
        /// The length of every Codon in the GeneticCode. All Codons must be of this length.
        /// </summary>
        public System.Int32 CodonLength
        {
            get { return this.CodonLengthColumn.Value.ToInt(); }
            set { this.CodonLengthColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnCodonLengthChanged when the value of CodonLength in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CodonLength_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasCodonLengthValueChanged = true;

            OnCodonLengthChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.CodonLengthColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of CodonLength in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.CodonLength) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsCodonLengthNullOrEmpty
        {
            get { return this.CodonLengthColumn.Value.IsNullOrDBNull() || this.CodonLength == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets CodonLength as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? CodonLengthNullable
        {
            get { return IsCodonLengthNullOrEmpty ? null as System.Int32? : this.CodonLength; }
        }

        /// <summary>
        /// The maximum number of IFunctions that take parameters that can be used in an IAllele's IDNA. After (or before) this number of IFunctions (with parameters) have been called, the rest of the IFunctions in the IDNA will not accept any parameters (i.e. they  will be terminals).
        /// </summary>
        public System.Int32 MaxParameterfulFunctionsInDNA
        {
            get { return this.MaxParameterfulFunctionsInDNAColumn.Value.ToInt(); }
            set { this.MaxParameterfulFunctionsInDNAColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnMaxParameterfulFunctionsInDNAChanged when the value of MaxParameterfulFunctionsInDNA in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MaxParameterfulFunctionsInDNA_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasMaxParameterfulFunctionsInDNAValueChanged = true;

            OnMaxParameterfulFunctionsInDNAChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.MaxParameterfulFunctionsInDNAColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of MaxParameterfulFunctionsInDNA in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.MaxParameterfulFunctionsInDNA) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsMaxParameterfulFunctionsInDNANullOrEmpty
        {
            get { return this.MaxParameterfulFunctionsInDNAColumn.Value.IsNullOrDBNull() || this.MaxParameterfulFunctionsInDNA == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets MaxParameterfulFunctionsInDNA as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? MaxParameterfulFunctionsInDNANullable
        {
            get { return IsMaxParameterfulFunctionsInDNANullOrEmpty ? null as System.Int32? : this.MaxParameterfulFunctionsInDNA; }
        }

        /// <summary>
        /// The number of IParameters used by the IFunction that has the most parameters.
        /// </summary>
        public System.Int32 MaximumFunctionInputsUsed
        {
            get { return this.MaximumFunctionInputsUsedColumn.Value.ToInt(); }
            set { this.MaximumFunctionInputsUsedColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnMaximumFunctionInputsUsedChanged when the value of MaximumFunctionInputsUsed in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MaximumFunctionInputsUsed_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasMaximumFunctionInputsUsedValueChanged = true;

            OnMaximumFunctionInputsUsedChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.MaximumFunctionInputsUsedColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of MaximumFunctionInputsUsed in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.MaximumFunctionInputsUsed) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsMaximumFunctionInputsUsedNullOrEmpty
        {
            get { return this.MaximumFunctionInputsUsedColumn.Value.IsNullOrDBNull() || this.MaximumFunctionInputsUsed == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets MaximumFunctionInputsUsed as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? MaximumFunctionInputsUsedNullable
        {
            get { return IsMaximumFunctionInputsUsedNullOrEmpty ? null as System.Int32? : this.MaximumFunctionInputsUsed; }
        }

        /// <summary>
        /// The maximum recursion level that's allowable. If this value is reached by an IGEPGene, the execution of the IGEPGene will be aborted.
        /// </summary>
        public System.Int32 MaxRecursionLevel
        {
            get { return this.MaxRecursionLevelColumn.Value.ToInt(); }
            set { this.MaxRecursionLevelColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnMaxRecursionLevelChanged when the value of MaxRecursionLevel in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MaxRecursionLevel_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasMaxRecursionLevelValueChanged = true;

            OnMaxRecursionLevelChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.MaxRecursionLevelColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of MaxRecursionLevel in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.MaxRecursionLevel) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsMaxRecursionLevelNullOrEmpty
        {
            get { return this.MaxRecursionLevelColumn.Value.IsNullOrDBNull() || this.MaxRecursionLevel == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets MaxRecursionLevel as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? MaxRecursionLevelNullable
        {
            get { return IsMaxRecursionLevelNullOrEmpty ? null as System.Int32? : this.MaxRecursionLevel; }
        }

        /// <summary>
        /// Indicates whether any value in this GeneticCodeRow that is not a Row (ForeignStrongRow or ForeignKeyStrongRow) is null or DBNull.Value or Empty. If false, all non-row values have values (i.e. are not null).
        /// </summary>
        public override bool IsAnyNonRowValueNullOrEmpty
        {
            get
            {
                if (this.IsPK_GeneticCodeIDNullOrEmpty)
                    return true;
                if (this.IsNameNullOrEmpty)
                    return true;
                if (this.IsCodonLengthNullOrEmpty)
                    return true;
                if (this.IsMaxParameterfulFunctionsInDNANullOrEmpty)
                    return true;
                if (this.IsMaximumFunctionInputsUsedNullOrEmpty)
                    return true;
                if (this.IsMaxRecursionLevelNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Indicates whether the value of PK_GeneticCodeID has changed since either this GeneticCodeRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasPK_GeneticCodeIDValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of Name has changed since either this GeneticCodeRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasNameValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of CodonLength has changed since either this GeneticCodeRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasCodonLengthValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of MaxParameterfulFunctionsInDNA has changed since either this GeneticCodeRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasMaxParameterfulFunctionsInDNAValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of MaximumFunctionInputsUsed has changed since either this GeneticCodeRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasMaximumFunctionInputsUsedValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of MaxRecursionLevel has changed since either this GeneticCodeRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasMaxRecursionLevelValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether any Foreign StrongRow in this GeneticCodeRow is null or DBNull.Value or empty.
        /// </summary>
        public override bool IsAnyForeignRowNull
        {
            get { return false; }
        }

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow that stores the values of the ForeignKey Strong Row if it were joined to this GeneticCodeRow on the Foreign Key Column "GeneticCode". This GeneticCodeRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_TheFunction_GeneticCodeRow ForeignKeyStrongRow.
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow _foreignKeyRow_TheFunction_GeneticCodeRow;
        /// <summary>
        /// /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow that stores the values of the ForeignKey Strong Row if it were joined to this GeneticCodeRow on the Foreign Key Column "GeneticCode". This GeneticCodeRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_TheFunction_GeneticCodeRow ForeignKeyStrongRow.
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow ForeignKeyRow_TheFunction_GeneticCodeRow
        {
            get
            {
                if (this._foreignKeyRow_TheFunction_GeneticCodeRow == null)
                {
                    this._foreignKeyRow_TheFunction_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
                    this.InitializeForeignKeyRow_TheFunction_GeneticCodeRow();
                }

                return _foreignKeyRow_TheFunction_GeneticCodeRow;
            }
            set
            {
                var originalValue = this.ForeignKeyRow_TheFunction_GeneticCodeRow;
                this._foreignKeyRow_TheFunction_GeneticCodeRow = value;


                this.InitializeForeignKeyRow_TheFunction_GeneticCodeRow();

                OnForeignKeyRow_TheFunction_GeneticCodeRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.GeneticCode, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.GeneticCode, this, RowValueType.ForeignKeyStrongRow));
            }
        }

        /// <summary>
        /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "GeneticCode" that belongs to ForeignKey StrongRow "ForeignKeyRow_TheFunction_GeneticCodeRow" (which is a different StrongRow than this GeneticCodeRow). This ForeignKeyToThisStrongRowColumn that can be used to join this GeneticCodeRow to the ForeignKeyStrongRow "ForeignKeyRow_TheFunction_GeneticCodeRow.
        /// </summary>
        private ForeignKeyToThisStrongRowColumn _foreignKeyRow_TheFunction_GeneticCodeRowColumn;
        /// <summary>
        /// /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "GeneticCode" that belongs to ForeignKey StrongRow "ForeignKeyRow_TheFunction_GeneticCodeRow" (which is a different StrongRow than this GeneticCodeRow). This ForeignKeyToThisStrongRowColumn that can be used to join this GeneticCodeRow to the ForeignKeyStrongRow "ForeignKeyRow_TheFunction_GeneticCodeRow.
        /// /// </summary>
        public ForeignKeyToThisStrongRowColumn ForeignKeyRow_TheFunction_GeneticCodeRowColumn
        {
            get
            {
                if (this._foreignKeyRow_TheFunction_GeneticCodeRowColumn == null)
                    this.ForeignKeyRow_TheFunction_GeneticCodeRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_TheFunction_GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.GeneticCode);

                return this._foreignKeyRow_TheFunction_GeneticCodeRowColumn;
            }
            private set { this._foreignKeyRow_TheFunction_GeneticCodeRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ForeignKeyRow_TheFunction_GeneticCodeRow has changed (is NOT raised when a value inside ForeignKeyRow_TheFunction_GeneticCodeRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow>> ForeignKeyRow_TheFunction_GeneticCodeRowChanged;

        /// <summary>
        /// Indicates that the value of GeneticCode has changed which fires the GeneticCodeChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ForeignKeyRow_TheFunction_GeneticCodeRowChanged event.</param>
        private void OnForeignKeyRow_TheFunction_GeneticCodeRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow> e)
        {
            if (ForeignKeyRow_TheFunction_GeneticCodeRowChanged != null)
                ForeignKeyRow_TheFunction_GeneticCodeRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignKeyStrongRow ForeignKeyRow_TheFunction_GeneticCodeRow.
        /// </summary>
        private void SubscribeToValueChangesOfForeignKeyRow_TheFunction_GeneticCodeRow()
        {
            if (this.ForeignKeyRow_TheFunction_GeneticCodeRow != null)
                this.ForeignKeyRow_TheFunction_GeneticCodeRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignKeyStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when setting the value of ForeignKeyRow_TheFunction_GeneticCodeRow.
        /// </summary>
        private void InitializeForeignKeyRow_TheFunction_GeneticCodeRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ForeignKeyRow_TheFunction_GeneticCodeRow))
                this.OtherRowTableAliases.Remove(this.ForeignKeyRow_TheFunction_GeneticCodeRow);

            this.ForeignKeyRow_TheFunction_GeneticCodeRowColumn.ForeignKeyRow = this.ForeignKeyRow_TheFunction_GeneticCodeRow;

            this.OtherRowTableAliases.Add(this.ForeignKeyRow_TheFunction_GeneticCodeRow, "foreignKey_TheFunction_GeneticCode");
            this.ForeignKeyRow_TheFunction_GeneticCodeRow.Parent = this;
            SubscribeToValueChangesOfForeignKeyRow_TheFunction_GeneticCodeRow();
        }

        /// <summary>
        /// Indicates whether the value of the ForeignKeyRow_TheFunction_GeneticCodeRow is null or DBNull.Value (does not Initialize the ForeignKeyRow_TheFunction_GeneticCodeRow if it is currently null).
        /// </summary>
        public bool IsForeignKeyRow_TheFunction_GeneticCodeRowNull
        {
            get { return this._foreignKeyRow_TheFunction_GeneticCodeRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow that stores the values of the ForeignKey Strong Row if it were joined to this GeneticCodeRow on the Foreign Key Column "GeneticCode". This GeneticCodeRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_CodonConverter_GeneticCodeRow ForeignKeyStrongRow.
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow _foreignKeyRow_CodonConverter_GeneticCodeRow;
        /// <summary>
        /// /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow that stores the values of the ForeignKey Strong Row if it were joined to this GeneticCodeRow on the Foreign Key Column "GeneticCode". This GeneticCodeRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_CodonConverter_GeneticCodeRow ForeignKeyStrongRow.
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow ForeignKeyRow_CodonConverter_GeneticCodeRow
        {
            get
            {
                if (this._foreignKeyRow_CodonConverter_GeneticCodeRow == null)
                {
                    this._foreignKeyRow_CodonConverter_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow();
                    this.InitializeForeignKeyRow_CodonConverter_GeneticCodeRow();
                }

                return _foreignKeyRow_CodonConverter_GeneticCodeRow;
            }
            set
            {
                var originalValue = this.ForeignKeyRow_CodonConverter_GeneticCodeRow;
                this._foreignKeyRow_CodonConverter_GeneticCodeRow = value;


                this.InitializeForeignKeyRow_CodonConverter_GeneticCodeRow();

                OnForeignKeyRow_CodonConverter_GeneticCodeRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.GeneticCode, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.GeneticCode, this, RowValueType.ForeignKeyStrongRow));
            }
        }

        /// <summary>
        /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "GeneticCode" that belongs to ForeignKey StrongRow "ForeignKeyRow_CodonConverter_GeneticCodeRow" (which is a different StrongRow than this GeneticCodeRow). This ForeignKeyToThisStrongRowColumn that can be used to join this GeneticCodeRow to the ForeignKeyStrongRow "ForeignKeyRow_CodonConverter_GeneticCodeRow.
        /// </summary>
        private ForeignKeyToThisStrongRowColumn _foreignKeyRow_CodonConverter_GeneticCodeRowColumn;
        /// <summary>
        /// /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "GeneticCode" that belongs to ForeignKey StrongRow "ForeignKeyRow_CodonConverter_GeneticCodeRow" (which is a different StrongRow than this GeneticCodeRow). This ForeignKeyToThisStrongRowColumn that can be used to join this GeneticCodeRow to the ForeignKeyStrongRow "ForeignKeyRow_CodonConverter_GeneticCodeRow.
        /// /// </summary>
        public ForeignKeyToThisStrongRowColumn ForeignKeyRow_CodonConverter_GeneticCodeRowColumn
        {
            get
            {
                if (this._foreignKeyRow_CodonConverter_GeneticCodeRowColumn == null)
                    this.ForeignKeyRow_CodonConverter_GeneticCodeRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_CodonConverter_GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.GeneticCode);

                return this._foreignKeyRow_CodonConverter_GeneticCodeRowColumn;
            }
            private set { this._foreignKeyRow_CodonConverter_GeneticCodeRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ForeignKeyRow_CodonConverter_GeneticCodeRow has changed (is NOT raised when a value inside ForeignKeyRow_CodonConverter_GeneticCodeRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow>> ForeignKeyRow_CodonConverter_GeneticCodeRowChanged;

        /// <summary>
        /// Indicates that the value of GeneticCode has changed which fires the GeneticCodeChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ForeignKeyRow_CodonConverter_GeneticCodeRowChanged event.</param>
        private void OnForeignKeyRow_CodonConverter_GeneticCodeRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow> e)
        {
            if (ForeignKeyRow_CodonConverter_GeneticCodeRowChanged != null)
                ForeignKeyRow_CodonConverter_GeneticCodeRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignKeyStrongRow ForeignKeyRow_CodonConverter_GeneticCodeRow.
        /// </summary>
        private void SubscribeToValueChangesOfForeignKeyRow_CodonConverter_GeneticCodeRow()
        {
            if (this.ForeignKeyRow_CodonConverter_GeneticCodeRow != null)
                this.ForeignKeyRow_CodonConverter_GeneticCodeRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignKeyStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when setting the value of ForeignKeyRow_CodonConverter_GeneticCodeRow.
        /// </summary>
        private void InitializeForeignKeyRow_CodonConverter_GeneticCodeRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ForeignKeyRow_CodonConverter_GeneticCodeRow))
                this.OtherRowTableAliases.Remove(this.ForeignKeyRow_CodonConverter_GeneticCodeRow);

            this.ForeignKeyRow_CodonConverter_GeneticCodeRowColumn.ForeignKeyRow = this.ForeignKeyRow_CodonConverter_GeneticCodeRow;

            this.OtherRowTableAliases.Add(this.ForeignKeyRow_CodonConverter_GeneticCodeRow, "foreignKey_CodonConverter_GeneticCode");
            this.ForeignKeyRow_CodonConverter_GeneticCodeRow.Parent = this;
            SubscribeToValueChangesOfForeignKeyRow_CodonConverter_GeneticCodeRow();
        }

        /// <summary>
        /// Indicates whether the value of the ForeignKeyRow_CodonConverter_GeneticCodeRow is null or DBNull.Value (does not Initialize the ForeignKeyRow_CodonConverter_GeneticCodeRow if it is currently null).
        /// </summary>
        public bool IsForeignKeyRow_CodonConverter_GeneticCodeRowNull
        {
            get { return this._foreignKeyRow_CodonConverter_GeneticCodeRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow that stores the values of the ForeignKey Strong Row if it were joined to this GeneticCodeRow on the Foreign Key Column "GeneticCode". This GeneticCodeRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Codon_GeneticCodeRow ForeignKeyStrongRow.
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow _foreignKeyRow_Codon_GeneticCodeRow;
        /// <summary>
        /// /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow that stores the values of the ForeignKey Strong Row if it were joined to this GeneticCodeRow on the Foreign Key Column "GeneticCode". This GeneticCodeRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Codon_GeneticCodeRow ForeignKeyStrongRow.
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow ForeignKeyRow_Codon_GeneticCodeRow
        {
            get
            {
                if (this._foreignKeyRow_Codon_GeneticCodeRow == null)
                {
                    this._foreignKeyRow_Codon_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow();
                    this.InitializeForeignKeyRow_Codon_GeneticCodeRow();
                }

                return _foreignKeyRow_Codon_GeneticCodeRow;
            }
            set
            {
                var originalValue = this.ForeignKeyRow_Codon_GeneticCodeRow;
                this._foreignKeyRow_Codon_GeneticCodeRow = value;


                this.InitializeForeignKeyRow_Codon_GeneticCodeRow();

                OnForeignKeyRow_Codon_GeneticCodeRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.GeneticCode, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.GeneticCode, this, RowValueType.ForeignKeyStrongRow));
            }
        }

        /// <summary>
        /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "GeneticCode" that belongs to ForeignKey StrongRow "ForeignKeyRow_Codon_GeneticCodeRow" (which is a different StrongRow than this GeneticCodeRow). This ForeignKeyToThisStrongRowColumn that can be used to join this GeneticCodeRow to the ForeignKeyStrongRow "ForeignKeyRow_Codon_GeneticCodeRow.
        /// </summary>
        private ForeignKeyToThisStrongRowColumn _foreignKeyRow_Codon_GeneticCodeRowColumn;
        /// <summary>
        /// /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "GeneticCode" that belongs to ForeignKey StrongRow "ForeignKeyRow_Codon_GeneticCodeRow" (which is a different StrongRow than this GeneticCodeRow). This ForeignKeyToThisStrongRowColumn that can be used to join this GeneticCodeRow to the ForeignKeyStrongRow "ForeignKeyRow_Codon_GeneticCodeRow.
        /// /// </summary>
        public ForeignKeyToThisStrongRowColumn ForeignKeyRow_Codon_GeneticCodeRowColumn
        {
            get
            {
                if (this._foreignKeyRow_Codon_GeneticCodeRowColumn == null)
                    this.ForeignKeyRow_Codon_GeneticCodeRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_Codon_GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.GeneticCode);

                return this._foreignKeyRow_Codon_GeneticCodeRowColumn;
            }
            private set { this._foreignKeyRow_Codon_GeneticCodeRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ForeignKeyRow_Codon_GeneticCodeRow has changed (is NOT raised when a value inside ForeignKeyRow_Codon_GeneticCodeRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow>> ForeignKeyRow_Codon_GeneticCodeRowChanged;

        /// <summary>
        /// Indicates that the value of GeneticCode has changed which fires the GeneticCodeChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ForeignKeyRow_Codon_GeneticCodeRowChanged event.</param>
        private void OnForeignKeyRow_Codon_GeneticCodeRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow> e)
        {
            if (ForeignKeyRow_Codon_GeneticCodeRowChanged != null)
                ForeignKeyRow_Codon_GeneticCodeRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignKeyStrongRow ForeignKeyRow_Codon_GeneticCodeRow.
        /// </summary>
        private void SubscribeToValueChangesOfForeignKeyRow_Codon_GeneticCodeRow()
        {
            if (this.ForeignKeyRow_Codon_GeneticCodeRow != null)
                this.ForeignKeyRow_Codon_GeneticCodeRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignKeyStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when setting the value of ForeignKeyRow_Codon_GeneticCodeRow.
        /// </summary>
        private void InitializeForeignKeyRow_Codon_GeneticCodeRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ForeignKeyRow_Codon_GeneticCodeRow))
                this.OtherRowTableAliases.Remove(this.ForeignKeyRow_Codon_GeneticCodeRow);

            this.ForeignKeyRow_Codon_GeneticCodeRowColumn.ForeignKeyRow = this.ForeignKeyRow_Codon_GeneticCodeRow;

            this.OtherRowTableAliases.Add(this.ForeignKeyRow_Codon_GeneticCodeRow, "foreignKey_Codon_GeneticCode");
            this.ForeignKeyRow_Codon_GeneticCodeRow.Parent = this;
            SubscribeToValueChangesOfForeignKeyRow_Codon_GeneticCodeRow();
        }

        /// <summary>
        /// Indicates whether the value of the ForeignKeyRow_Codon_GeneticCodeRow is null or DBNull.Value (does not Initialize the ForeignKeyRow_Codon_GeneticCodeRow if it is currently null).
        /// </summary>
        public bool IsForeignKeyRow_Codon_GeneticCodeRowNull
        {
            get { return this._foreignKeyRow_Codon_GeneticCodeRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow that stores the values of the ForeignKey Strong Row if it were joined to this GeneticCodeRow on the Foreign Key Column "GeneticCode". This GeneticCodeRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Nucleotide_GeneticCodeRow ForeignKeyStrongRow.
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow _foreignKeyRow_Nucleotide_GeneticCodeRow;
        /// <summary>
        /// /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow that stores the values of the ForeignKey Strong Row if it were joined to this GeneticCodeRow on the Foreign Key Column "GeneticCode". This GeneticCodeRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Nucleotide_GeneticCodeRow ForeignKeyStrongRow.
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow ForeignKeyRow_Nucleotide_GeneticCodeRow
        {
            get
            {
                if (this._foreignKeyRow_Nucleotide_GeneticCodeRow == null)
                {
                    this._foreignKeyRow_Nucleotide_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow();
                    this.InitializeForeignKeyRow_Nucleotide_GeneticCodeRow();
                }

                return _foreignKeyRow_Nucleotide_GeneticCodeRow;
            }
            set
            {
                var originalValue = this.ForeignKeyRow_Nucleotide_GeneticCodeRow;
                this._foreignKeyRow_Nucleotide_GeneticCodeRow = value;


                this.InitializeForeignKeyRow_Nucleotide_GeneticCodeRow();

                OnForeignKeyRow_Nucleotide_GeneticCodeRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.GeneticCode, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.GeneticCode, this, RowValueType.ForeignKeyStrongRow));
            }
        }

        /// <summary>
        /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "GeneticCode" that belongs to ForeignKey StrongRow "ForeignKeyRow_Nucleotide_GeneticCodeRow" (which is a different StrongRow than this GeneticCodeRow). This ForeignKeyToThisStrongRowColumn that can be used to join this GeneticCodeRow to the ForeignKeyStrongRow "ForeignKeyRow_Nucleotide_GeneticCodeRow.
        /// </summary>
        private ForeignKeyToThisStrongRowColumn _foreignKeyRow_Nucleotide_GeneticCodeRowColumn;
        /// <summary>
        /// /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "GeneticCode" that belongs to ForeignKey StrongRow "ForeignKeyRow_Nucleotide_GeneticCodeRow" (which is a different StrongRow than this GeneticCodeRow). This ForeignKeyToThisStrongRowColumn that can be used to join this GeneticCodeRow to the ForeignKeyStrongRow "ForeignKeyRow_Nucleotide_GeneticCodeRow.
        /// /// </summary>
        public ForeignKeyToThisStrongRowColumn ForeignKeyRow_Nucleotide_GeneticCodeRowColumn
        {
            get
            {
                if (this._foreignKeyRow_Nucleotide_GeneticCodeRowColumn == null)
                    this.ForeignKeyRow_Nucleotide_GeneticCodeRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_Nucleotide_GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.GeneticCode);

                return this._foreignKeyRow_Nucleotide_GeneticCodeRowColumn;
            }
            private set { this._foreignKeyRow_Nucleotide_GeneticCodeRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ForeignKeyRow_Nucleotide_GeneticCodeRow has changed (is NOT raised when a value inside ForeignKeyRow_Nucleotide_GeneticCodeRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow>> ForeignKeyRow_Nucleotide_GeneticCodeRowChanged;

        /// <summary>
        /// Indicates that the value of GeneticCode has changed which fires the GeneticCodeChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ForeignKeyRow_Nucleotide_GeneticCodeRowChanged event.</param>
        private void OnForeignKeyRow_Nucleotide_GeneticCodeRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow> e)
        {
            if (ForeignKeyRow_Nucleotide_GeneticCodeRowChanged != null)
                ForeignKeyRow_Nucleotide_GeneticCodeRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignKeyStrongRow ForeignKeyRow_Nucleotide_GeneticCodeRow.
        /// </summary>
        private void SubscribeToValueChangesOfForeignKeyRow_Nucleotide_GeneticCodeRow()
        {
            if (this.ForeignKeyRow_Nucleotide_GeneticCodeRow != null)
                this.ForeignKeyRow_Nucleotide_GeneticCodeRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignKeyStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when setting the value of ForeignKeyRow_Nucleotide_GeneticCodeRow.
        /// </summary>
        private void InitializeForeignKeyRow_Nucleotide_GeneticCodeRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ForeignKeyRow_Nucleotide_GeneticCodeRow))
                this.OtherRowTableAliases.Remove(this.ForeignKeyRow_Nucleotide_GeneticCodeRow);

            this.ForeignKeyRow_Nucleotide_GeneticCodeRowColumn.ForeignKeyRow = this.ForeignKeyRow_Nucleotide_GeneticCodeRow;

            this.OtherRowTableAliases.Add(this.ForeignKeyRow_Nucleotide_GeneticCodeRow, "foreignKey_Nucleotide_GeneticCode");
            this.ForeignKeyRow_Nucleotide_GeneticCodeRow.Parent = this;
            SubscribeToValueChangesOfForeignKeyRow_Nucleotide_GeneticCodeRow();
        }

        /// <summary>
        /// Indicates whether the value of the ForeignKeyRow_Nucleotide_GeneticCodeRow is null or DBNull.Value (does not Initialize the ForeignKeyRow_Nucleotide_GeneticCodeRow if it is currently null).
        /// </summary>
        public bool IsForeignKeyRow_Nucleotide_GeneticCodeRowNull
        {
            get { return this._foreignKeyRow_Nucleotide_GeneticCodeRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// Constructs an instance of this GeneticCodeRow from a specified Row.<para></para><para></para>NO STRONG ROW COLUMNS WILL BE INITIALIZED. This simply creates a wrapper around the Row in order to access the Row Values. It is helpful for performance.
        /// </summary>
        /// <param name="geneticCodeRow">The rules to which an Organism must abide.</param>
        public GeneticCodeRow(Row geneticCodeRow)
            : this()
        {
            this.Row = geneticCodeRow;
        }

        /// <summary>
        /// Constructs an instance of this GeneticCodeRow from a specified global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer.
        /// </summary>
        /// <param name="geneticCodeRowSerializableContainer">The rules to which an Organism must abide.</param>
        public GeneticCodeRow(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer geneticCodeRowSerializableContainer)
            : this()
        {
            this.Row = new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable);

            this.PK_GeneticCodeID = geneticCodeRowSerializableContainer.PK_GeneticCodeID;
            this.Name = geneticCodeRowSerializableContainer.Name;
            this.CodonLength = geneticCodeRowSerializableContainer.CodonLength;
            this.MaxParameterfulFunctionsInDNA = geneticCodeRowSerializableContainer.MaxParameterfulFunctionsInDNA;
            this.MaximumFunctionInputsUsed = geneticCodeRowSerializableContainer.MaximumFunctionInputsUsed;
            this.MaxRecursionLevel = geneticCodeRowSerializableContainer.MaxRecursionLevel;
            if (geneticCodeRowSerializableContainer.ForeignKeyRow_TheFunction_GeneticCodeRowSerializableContainer != null)
                this.ForeignKeyRow_TheFunction_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow(geneticCodeRowSerializableContainer.ForeignKeyRow_TheFunction_GeneticCodeRowSerializableContainer);
            if (geneticCodeRowSerializableContainer.ForeignKeyRow_CodonConverter_GeneticCodeRowSerializableContainer != null)
                this.ForeignKeyRow_CodonConverter_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow(geneticCodeRowSerializableContainer.ForeignKeyRow_CodonConverter_GeneticCodeRowSerializableContainer);
            if (geneticCodeRowSerializableContainer.ForeignKeyRow_Codon_GeneticCodeRowSerializableContainer != null)
                this.ForeignKeyRow_Codon_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow(geneticCodeRowSerializableContainer.ForeignKeyRow_Codon_GeneticCodeRowSerializableContainer);
            if (geneticCodeRowSerializableContainer.ForeignKeyRow_Nucleotide_GeneticCodeRowSerializableContainer != null)
                this.ForeignKeyRow_Nucleotide_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow(geneticCodeRowSerializableContainer.ForeignKeyRow_Nucleotide_GeneticCodeRowSerializableContainer);
        }

        /// <summary>
        /// Constructs an instance of this GeneticCodeRow from a set of values for the Row.
        /// </summary>
        /// <param name="name">The name of the Genetic Code.</param>
        /// <param name="codonLength">The length of every Codon in the GeneticCode. All Codons must be of this length.</param>
        /// <param name="maxParameterfulFunctionsInDNA">The maximum number of IFunctions that take parameters that can be used in an IAllele's IDNA. After (or before) this number of IFunctions (with parameters) have been called, the rest of the IFunctions in the IDNA will not accept any parameters (i.e. they  will be terminals).</param>
        /// <param name="maximumFunctionInputsUsed">The number of IParameters used by the IFunction that has the most parameters.</param>
        /// <param name="maxRecursionLevel">The maximum recursion level that's allowable. If this value is reached by an IGEPGene, the execution of the IGEPGene will be aborted.</param>
        public GeneticCodeRow(System.String name, System.Int32 codonLength, System.Int32 maxParameterfulFunctionsInDNA, System.Int32 maximumFunctionInputsUsed, System.Int32 maxRecursionLevel)
            : this()
        {
            if (this.Row != null)
                this.Row = global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.ToRow(name: name, codonLength: codonLength, maxParameterfulFunctionsInDNA: maxParameterfulFunctionsInDNA, maximumFunctionInputsUsed: maximumFunctionInputsUsed, maxRecursionLevel: maxRecursionLevel);
        }

        /// <summary>
        /// Constructs an instance of a GeneticCodeRow
        /// </summary>
        public GeneticCodeRow()
            : base(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable)
        {
            this.Values = new GeneticCodeRowValues(this);
        }

        /// <summary>
        /// The TableDefinition of this GeneticCodeRow
        /// </summary>
        public override TableDefinition TableDefinition
        {
            get { return this.GetTableDefinition(); }
        }

        /// <summary>
        /// Gets the TableDefinition of this GeneticCodeRow
        /// </summary>
        public override TableDefinition GetTableDefinition()
        {
            return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable;
        }

        /// <summary>
        /// The TableDefinition of this GeneticCodeRow
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.GeneticCodeTable GeneticCodeTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCodeTable; }
        }

        /// <summary>
        /// Given a table alias (compressed or non-compressed), initializes the proper child StrongRow that has the given alias.
        /// </summary>
        /// <param name="tableAlias">The table alias (compressed or non-compressed) that will indicate which child StrongRow to initialize.</param>
        public override void InitializeChildStrongRowWithAlias(string tableAlias)
        {
            switch (tableAlias)
            {
                case "foreignKey_TheFunction_GeneticCode":
                    if (this._foreignKeyRow_TheFunction_GeneticCodeRow == null)
                    {
                        this._foreignKeyRow_TheFunction_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
                        this.InitializeForeignKeyRow_TheFunction_GeneticCodeRow();
                    }
                    return;
                case "_TFGC34nih61":
                    if (this._foreignKeyRow_TheFunction_GeneticCodeRow == null)
                    {
                        this._foreignKeyRow_TheFunction_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
                        this.InitializeForeignKeyRow_TheFunction_GeneticCodeRow();
                    }
                    return;
                case "foreignKey_CodonConverter_GeneticCode":
                    if (this._foreignKeyRow_CodonConverter_GeneticCodeRow == null)
                    {
                        this._foreignKeyRow_CodonConverter_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow();
                        this.InitializeForeignKeyRow_CodonConverter_GeneticCodeRow();
                    }
                    return;
                case "_CCGC37nio62":
                    if (this._foreignKeyRow_CodonConverter_GeneticCodeRow == null)
                    {
                        this._foreignKeyRow_CodonConverter_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow();
                        this.InitializeForeignKeyRow_CodonConverter_GeneticCodeRow();
                    }
                    return;
                case "foreignKey_Codon_GeneticCode":
                    if (this._foreignKeyRow_Codon_GeneticCodeRow == null)
                    {
                        this._foreignKeyRow_Codon_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow();
                        this.InitializeForeignKeyRow_Codon_GeneticCodeRow();
                    }
                    return;
                case "_CGC28nio31":
                    if (this._foreignKeyRow_Codon_GeneticCodeRow == null)
                    {
                        this._foreignKeyRow_Codon_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow();
                        this.InitializeForeignKeyRow_Codon_GeneticCodeRow();
                    }
                    return;
                case "foreignKey_Nucleotide_GeneticCode":
                    if (this._foreignKeyRow_Nucleotide_GeneticCodeRow == null)
                    {
                        this._foreignKeyRow_Nucleotide_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow();
                        this.InitializeForeignKeyRow_Nucleotide_GeneticCodeRow();
                    }
                    return;
                case "_NGC33niu62":
                    if (this._foreignKeyRow_Nucleotide_GeneticCodeRow == null)
                    {
                        this._foreignKeyRow_Nucleotide_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow();
                        this.InitializeForeignKeyRow_Nucleotide_GeneticCodeRow();
                    }
                    return;
                default:
                    throw new Exception("The given table alias does not refer to any child StrongRow in this GeneticCodeRow.");
                    return;

            }
        }

        /// <summary>
        /// Initializes all of the Foreign Strong Rows and Foreign Key StrongRows in this GeneticCodeRow that are currently null. Calls the parameterless constructor for each Strong Row that is null.
        /// </summary>
        public override void InitializeChildStrongRows()
        {

            if (this.ForeignKeyRow_TheFunction_GeneticCodeRow == null)
                this.ForeignKeyRow_TheFunction_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
            if (this.ForeignKeyRow_CodonConverter_GeneticCodeRow == null)
                this.ForeignKeyRow_CodonConverter_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonConverterRow();
            if (this.ForeignKeyRow_Codon_GeneticCodeRow == null)
                this.ForeignKeyRow_Codon_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow();
            if (this.ForeignKeyRow_Nucleotide_GeneticCodeRow == null)
                this.ForeignKeyRow_Nucleotide_GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.NucleotideRow();
        }

        /// <summary>
        /// Initializes all of the StrongRowColumns in this GeneticCodeRow that are currently null. Also handles the necessary event subscriptions.
        /// </summary>
        public override void InitializeStrongRowColumns()
        {
            if (this.PK_GeneticCodeIDColumn == null)
            {
                this.PK_GeneticCodeIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.PK_GeneticCodeID);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.PK_GeneticCodeID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_GeneticCodeID_ValueChanged);
            }
            if (this.NameColumn == null)
            {
                this.NameColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.Name);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.Name].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(Name_ValueChanged);
            }
            if (this.CodonLengthColumn == null)
            {
                this.CodonLengthColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.CodonLength);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.CodonLength].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(CodonLength_ValueChanged);
            }
            if (this.MaxParameterfulFunctionsInDNAColumn == null)
            {
                this.MaxParameterfulFunctionsInDNAColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.MaxParameterfulFunctionsInDNA);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.MaxParameterfulFunctionsInDNA].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(MaxParameterfulFunctionsInDNA_ValueChanged);
            }
            if (this.MaximumFunctionInputsUsedColumn == null)
            {
                this.MaximumFunctionInputsUsedColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.MaximumFunctionInputsUsed);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.MaximumFunctionInputsUsed].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(MaximumFunctionInputsUsed_ValueChanged);
            }
            if (this.MaxRecursionLevelColumn == null)
            {
                this.MaxRecursionLevelColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.MaxRecursionLevel);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.MaxRecursionLevel].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(MaxRecursionLevel_ValueChanged);
            }
        }

        /// <summary>
        /// Initializes all of the ForeignStrongRowColumns in this GeneticCodeRow that are null.
        /// </summary>
        public override void InitializeForeignStrongRowColumns()
        {

        }

        /// <summary>
        /// Initializes all of the ForeignKeyToThisStrongRowColumns in this GeneticCodeRow that are null.
        /// </summary>
        public override void InitializeForeignKeyToThisStrongRowColumns()
        {
            if (this.ForeignKeyRow_TheFunction_GeneticCodeRowColumn == null)
                this.ForeignKeyRow_TheFunction_GeneticCodeRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_TheFunction_GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.TheFunction.GeneticCode);
            if (this.ForeignKeyRow_CodonConverter_GeneticCodeRowColumn == null)
                this.ForeignKeyRow_CodonConverter_GeneticCodeRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_CodonConverter_GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.CodonConverter.GeneticCode);
            if (this.ForeignKeyRow_Codon_GeneticCodeRowColumn == null)
                this.ForeignKeyRow_Codon_GeneticCodeRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_Codon_GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.GeneticCode);
            if (this.ForeignKeyRow_Nucleotide_GeneticCodeRowColumn == null)
                this.ForeignKeyRow_Nucleotide_GeneticCodeRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_Nucleotide_GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Nucleotide.GeneticCode);
        }

        /// <summary>
        /// Inserts the Row into the database immediately (if it is not currently in the database. This method first checks to ensure that the Row is not in the database). Returns true if the Row was inserted. Returns false if not. Out's the primary key.
        /// </summary>
        /// <param name="primaryKey">PK_GeneticCodeID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// <param name="primaryKey">PK_GeneticCodeID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// Indicates whether the Primary Key PK_GeneticCodeID is null or DBNull.Value or is an Empty value.
        /// </summary>
        public override bool IsPrimaryKeyNullOrEmpty
        {
            get { return this.IsPK_GeneticCodeIDNullOrEmpty; }
        }

        /// <summary>
        /// The Primary Key PK_GeneticCodeID for this GeneticCode.
        /// </summary>
        public System.Int32 PrimaryKey
        {
            get { return this.PK_GeneticCodeID; }
            set { this.PK_GeneticCodeID = value; }
        }

        /// <summary>
        /// The Primary Key Column for this GeneticCode.
        /// </summary>
        public override StrongRowColumn PrimaryKeyColumn
        {
            get { return this.PK_GeneticCodeIDColumn; }
        }

        /// <summary>
        /// Gets the Primary Key as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PrimaryKeyNullable
        {
            get { return this.IsPrimaryKeyNullOrEmpty ? null as System.Int32? : this.PrimaryKey; }
        }

        /// <summary>
        /// Returns all of the Columns in the GeneticCodeRow whose values have changed according to their HasChanged flags.
        /// </summary>
        public override List<Column> GetColumnsWithChangedValues()
        {
            // If no value in this row has changed then return an empty list.
            if (!this.HasAnyNonRowValueInRowChanged)
                return new List<Column>(0);

            // We will collect the columns whose values have changed.
            var columns = new List<Column>();

            if (HasPK_GeneticCodeIDValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.PK_GeneticCodeID);
            if (HasNameValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.Name);
            if (HasCodonLengthValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.CodonLength);
            if (HasMaxParameterfulFunctionsInDNAValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.MaxParameterfulFunctionsInDNA);
            if (HasMaximumFunctionInputsUsedValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.MaximumFunctionInputsUsed);
            if (HasMaxRecursionLevelValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.GeneticCode.MaxRecursionLevel);

            return columns;
        }

        /// <summary>
        /// Calls ResetAllHasAnyValueChangedFlags() for this GeneticCodeRow and ResetAllThisAndChildrenHasAnyValueChangedFlags() for all children Foreign StrongRows and Foreign Key Strong Rows that are not null.
        /// </summary>
        public override void ResetAllThisAndChildrenHasAnyValueChangedFlags()
        {
            this.ResetAllHasAnyValueChangedFlags();

            if (this._foreignKeyRow_TheFunction_GeneticCodeRow != null)
                this.ForeignKeyRow_TheFunction_GeneticCodeRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._foreignKeyRow_CodonConverter_GeneticCodeRow != null)
                this.ForeignKeyRow_CodonConverter_GeneticCodeRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._foreignKeyRow_Codon_GeneticCodeRow != null)
                this.ForeignKeyRow_Codon_GeneticCodeRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._foreignKeyRow_Nucleotide_GeneticCodeRow != null)
                this.ForeignKeyRow_Nucleotide_GeneticCodeRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
        }

        /// <summary>
        /// Resets all of the HasAnyValuesChanged for each of the values in this GeneticCodeRow. Also calls the base.ResetAllHasAnyValueChangedFlags().
        /// </summary>
        public override void ResetAllHasAnyValueChangedFlags()
        {
            base.ResetAllHasAnyValueChangedFlags();

            this.HasPK_GeneticCodeIDValueChanged = false;
            this.HasNameValueChanged = false;
            this.HasCodonLengthValueChanged = false;
            this.HasMaxParameterfulFunctionsInDNAValueChanged = false;
            this.HasMaximumFunctionInputsUsedValueChanged = false;
            this.HasMaxRecursionLevelValueChanged = false;
        }

        /// <summary>
        /// Gets all of the StrongRowColumns in this GeneticCodeRow.
        /// </summary>
        public override StrongRowColumn[] GetAllStrongRowColumns()
        {
            return new StrongRowColumn[] { PK_GeneticCodeIDColumn, NameColumn, CodonLengthColumn, MaxParameterfulFunctionsInDNAColumn, MaximumFunctionInputsUsedColumn, MaxRecursionLevelColumn };
        }

        /// <summary>
        /// Gets all of the StrongRowForeignKeyColumns in this GeneticCodeRow.
        /// </summary>
        public override StrongRowForeignKeyColumn[] GetAllStrongRowForeignKeyColumns()
        {
            return new StrongRowForeignKeyColumn[] { };
        }

        /// <summary>
        /// Gets all of the ForeignKeyToThisStrongRowColumn in this GeneticCodeRow.
        /// </summary>
        public override ForeignKeyToThisStrongRowColumn[] GetAllForeignKeyToThisStrongRowColumns()
        {
            return new ForeignKeyToThisStrongRowColumn[] { ForeignKeyRow_TheFunction_GeneticCodeRowColumn, ForeignKeyRow_CodonConverter_GeneticCodeRowColumn, ForeignKeyRow_Codon_GeneticCodeRowColumn, ForeignKeyRow_Nucleotide_GeneticCodeRowColumn };
        }

        /// <summary>
        /// Converts the GeneticCodeRow to a GeneticCodeRowSerializableContainer.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer ToGeneticCodeRowSerializableContainer()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.GeneticCodeRowSerializableContainer(this);
        }

        /// <summary>
        /// Converts the StrongRow to the appropriate StrongRowSerializableContainer.
        /// </summary>
        public override StrongRowSerializableContainer ToStrongRowSerializableContainer()
        {
            return this.ToGeneticCodeRowSerializableContainer();
        }

        #region IStrongRowDescendant<T>
        /// <summary>
        /// Fills any empty values in this GeneticCodeRow with the corresponding values from the given GeneticCodeRow. Does NOT fill the Primary Key.
        /// </summary>
        /// <param name="sourceOfFilling">The GeneticCodeRow from which we will gather values in order to fill any empty values in this GeneticCodeRow.</param>
        public void FillEmptyValues(GeneticCodeRow sourceOfFilling)
        {
            if (sourceOfFilling == null)
                return;

            if (this.IsNameNullOrEmpty)
                this.Name = sourceOfFilling.Name;
            if (this.IsCodonLengthNullOrEmpty)
                this.CodonLength = sourceOfFilling.CodonLength;
            if (this.IsMaxParameterfulFunctionsInDNANullOrEmpty)
                this.MaxParameterfulFunctionsInDNA = sourceOfFilling.MaxParameterfulFunctionsInDNA;
            if (this.IsMaximumFunctionInputsUsedNullOrEmpty)
                this.MaximumFunctionInputsUsed = sourceOfFilling.MaximumFunctionInputsUsed;
            if (this.IsMaxRecursionLevelNullOrEmpty)
                this.MaxRecursionLevel = sourceOfFilling.MaxRecursionLevel;
        }

        /// <summary>
        /// This GeneticCodeRow used to fulfill the IStrongRowDescendent<T> contact.
        /// </summary>
        public GeneticCodeRow Self
        {
            get { return this; }
        }

        /// <summary>
        /// Creates a deep copy of the given other GeneticCodeRow. Fills this GeneticCodeRow with the values, Foreign StrongRows and ForeignKey StrongRows of the given other GeneticCodeRow. Fills each child row's children as well.
        /// </summary>
        /// <param name="other">The StrongRow from which values will be populated</param>
        public void PopulateFromRow(GeneticCodeRow other)
        {
            this.PK_GeneticCodeID = other.PK_GeneticCodeID;
            this.Name = other.Name;
            this.CodonLength = other.CodonLength;
            this.MaxParameterfulFunctionsInDNA = other.MaxParameterfulFunctionsInDNA;
            this.MaximumFunctionInputsUsed = other.MaximumFunctionInputsUsed;
            this.MaxRecursionLevel = other.MaxRecursionLevel;

            if (other._foreignKeyRow_TheFunction_GeneticCodeRow != null)
            {
                var theFunction_GeneticCodeRow = other.ForeignKeyRow_TheFunction_GeneticCodeRow;
                this.ForeignKeyRow_TheFunction_GeneticCodeRow.PopulateFromRow(theFunction_GeneticCodeRow);
            }
            if (other._foreignKeyRow_CodonConverter_GeneticCodeRow != null)
            {
                var codonConverter_GeneticCodeRow = other.ForeignKeyRow_CodonConverter_GeneticCodeRow;
                this.ForeignKeyRow_CodonConverter_GeneticCodeRow.PopulateFromRow(codonConverter_GeneticCodeRow);
            }
            if (other._foreignKeyRow_Codon_GeneticCodeRow != null)
            {
                var codon_GeneticCodeRow = other.ForeignKeyRow_Codon_GeneticCodeRow;
                this.ForeignKeyRow_Codon_GeneticCodeRow.PopulateFromRow(codon_GeneticCodeRow);
            }
            if (other._foreignKeyRow_Nucleotide_GeneticCodeRow != null)
            {
                var nucleotide_GeneticCodeRow = other.ForeignKeyRow_Nucleotide_GeneticCodeRow;
                this.ForeignKeyRow_Nucleotide_GeneticCodeRow.PopulateFromRow(nucleotide_GeneticCodeRow);
            }
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Gets the GeneticCodeRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the GeneticCodeRow</param>
        public static GeneticCodeRow GetGeneticCodeRowByID(object ID)
        {
            var geneticCodeRow = new GeneticCodeRow();
            Qry.SelectAllFrom(geneticCodeRow).Where(geneticCodeRow.PrimaryKeyColumn, ID).Go().ExtractStrongRow(ref geneticCodeRow);
            return geneticCodeRow;
        }

        /// <summary>
        /// Gets all of the GeneticCodeRows in the database.
        /// </summary>
        public static IEnumerable<GeneticCodeRow> GetAllGeneticCodeRows()
        {
            return Qry.SelectAllFrom(new GeneticCodeRow()).Go().ExtractStrongRows<GeneticCodeRow>();
        }
        #endregion

        #region StrongRow Overrides
        /// <summary>
        /// Gets the GeneticCodeRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the GeneticCodeRow</param>
        public override StrongRow GetByID(object ID)
        {
            return GeneticCodeRow.GetGeneticCodeRowByID(ID);
        }

        /// <summary>
        /// Gets all of the GeneticCodeRows in the database.
        /// </summary>
        public override IEnumerable<StrongRow> GetAll()
        {
            return GeneticCodeRow.GetAllGeneticCodeRows();
        }
        #endregion

        #region IRepository
        /// <summary>
        /// Gets the GeneticCodeRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the GeneticCodeRow</param>
        GeneticCodeRow IRepository<GeneticCodeRow>.GetByID(object ID)
        {
            return GeneticCodeRow.GetGeneticCodeRowByID(ID);
        }

        /// <summary>
        /// Gets all of the GeneticCodeRows in the database.
        /// </summary>
        IEnumerable<GeneticCodeRow> IRepository<GeneticCodeRow>.GetAll()
        {
            return GeneticCodeRow.GetAllGeneticCodeRows();
        }
        #endregion

        /// <summary>
        /// Validates all of the underlying enum values in this GeneticCodeRow. If there are any errors in the Enum Values, they will be registered with the given SenderIdentifier.
        /// </summary>
        /// <param name="senderIdentifier">The SenderIdentifier used to register Errors in the enum values if any errors exist.</param>
        /// <param name="referenceNumberForErrors">The reference number that will be registered with any Errors.</param>
        public override void ValidateEnumValues(SenderIdentifier senderIdentifier, string referenceNumberForErrors)
        {

        }
    }
}