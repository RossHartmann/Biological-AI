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
    /// A pair of functions where the second function is parameterless.
    /// </summary>
    [Serializable]
    public sealed partial class FunctionPairRow : StrongRow, IRepository<FunctionPairRow>, IStrongRowDescendant<FunctionPairRow>
    {
        /// <summary>
        /// This class provides redundant access to the values of the underlying Row in a FunctionPairRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        [Serializable]
        public sealed partial class FunctionPairRowValues
        {
            /// <summary>
            /// PK_FunctionPairID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PK_FunctionPairID
            {
                get { return this.Parent.PK_FunctionPairID; }
                set { this.Parent.PK_FunctionPairID = value; }
            }

            /// <summary>
            /// The identifier of the Primary Function in this IFunctionPair. The IFunction can have any number of parameters (or no parameters). This is the IFunction for which the ICodon primarily encodes.
            /// </summary>
            public System.Int32 PrimaryFunction
            {
                get { return this.Parent.PrimaryFunction; }
                set { this.Parent.PrimaryFunction = value; }
            }

            /// <summary>
            /// The identifier of a Parameterless IFunction that will be used if a parameterless IFunction is required. If a ICodon is in the \"tail\" of the IDNA (i.e. in the portion of the IDNA that will only accept \"terminal\" IFunctions), it will use this parameterless IFunction.
            /// </summary>
            public System.Int32 ParameterlessFunction
            {
                get { return this.Parent.ParameterlessFunction; }
                set { this.Parent.ParameterlessFunction = value; }
            }

            /// <summary>
            /// The unique FunctionIdentifier of the Primary Function.
            /// </summary>
            public System.String PrimaryFunctionIdentifier
            {
                get { return this.Parent.PrimaryFunctionIdentifier; }
                set { this.Parent.PrimaryFunctionIdentifier = value; }
            }

            /// <summary>
            /// The unique FunctionIdentifier of the Parameterless Function.
            /// </summary>
            public System.String ParameterlessFunctionIdentifier
            {
                get { return this.Parent.ParameterlessFunctionIdentifier; }
                set { this.Parent.ParameterlessFunctionIdentifier = value; }
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
            /// PK_FunctionPairID int IDENTITY (1,1) PRIMARY KEY,
            /// </summary>
            public System.Int32 PrimaryKey
            {
                get { return this.PK_FunctionPairID; }
                set { this.PK_FunctionPairID = value; }
            }

            /// <summary>
            /// The parent FunctionPairRow whose values will be viewed and manipulated through this FunctionPairRowValues.
            /// </summary>
            public FunctionPairRow Parent { get; private set; }

            /// <summary>
            /// Constructs a FunctionPairRowValues from a parent FunctionPairRow.
            /// </summary>
            /// <param name="parent">The parent FunctionPairRow whose values will be viewed and manipulated through this FunctionPairRowValues.</param>
            public FunctionPairRowValues(FunctionPairRow parent)
            {
                this.Parent = parent;
            }
        }

        /// <summary>
        /// This property provides redundant access to the values of the underlying Row in this FunctionPairRow. It is used to easily view and manipulate the Row values and only the Row values.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.FunctionPairRow.FunctionPairRowValues Values { get; private set; }

        /// <summary>
        /// The StrongRowColumn where the value of PK_FunctionPairID is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _pK_FunctionPairIDColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of PK_FunctionPairID is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn PK_FunctionPairIDColumn
        {
            get
            {
                if (this._pK_FunctionPairIDColumn == null)
                {
                    this.PK_FunctionPairIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PK_FunctionPairID);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PK_FunctionPairID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_FunctionPairID_ValueChanged);
                }

                return this._pK_FunctionPairIDColumn;
            }
            private set { this._pK_FunctionPairIDColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of PrimaryFunction is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _primaryFunctionColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of PrimaryFunction is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn PrimaryFunctionColumn
        {
            get
            {
                if (this._primaryFunctionColumn == null)
                {
                    this.PrimaryFunctionColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunction);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunction].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PrimaryFunction_ValueChanged);
                }

                return this._primaryFunctionColumn;
            }
            private set { this._primaryFunctionColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of ParameterlessFunction is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _parameterlessFunctionColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of ParameterlessFunction is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn ParameterlessFunctionColumn
        {
            get
            {
                if (this._parameterlessFunctionColumn == null)
                {
                    this.ParameterlessFunctionColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunction);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunction].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(ParameterlessFunction_ValueChanged);
                }

                return this._parameterlessFunctionColumn;
            }
            private set { this._parameterlessFunctionColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of PrimaryFunctionIdentifier is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _primaryFunctionIdentifierColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of PrimaryFunctionIdentifier is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn PrimaryFunctionIdentifierColumn
        {
            get
            {
                if (this._primaryFunctionIdentifierColumn == null)
                {
                    this.PrimaryFunctionIdentifierColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunctionIdentifier);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunctionIdentifier].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PrimaryFunctionIdentifier_ValueChanged);
                }

                return this._primaryFunctionIdentifierColumn;
            }
            private set { this._primaryFunctionIdentifierColumn = value; }
        }

        /// <summary>
        /// The StrongRowColumn where the value of ParameterlessFunctionIdentifier is stored in the underlying Row.
        /// </summary>
        private StrongRowColumn _parameterlessFunctionIdentifierColumn;
        /// <summary>
        /// /// The StrongRowColumn where the value of ParameterlessFunctionIdentifier is stored in the underlying Row.
        /// /// </summary>
        public StrongRowColumn ParameterlessFunctionIdentifierColumn
        {
            get
            {
                if (this._parameterlessFunctionIdentifierColumn == null)
                {
                    this.ParameterlessFunctionIdentifierColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunctionIdentifier);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunctionIdentifier].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(ParameterlessFunctionIdentifier_ValueChanged);
                }

                return this._parameterlessFunctionIdentifierColumn;
            }
            private set { this._parameterlessFunctionIdentifierColumn = value; }
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
                    this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.GeneticCode);
                    this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
                }

                return this._geneticCodeColumn;
            }
            private set { this._geneticCodeColumn = value; }
        }



        /// <summary>
        /// Raised when the value of PK_FunctionPairID has changed.<para></para><para></para>This will only fire when the value of the property PK_FunctionPairID is set. If the corresponding value is set through the underlying row or through the property PK_FunctionPairIDColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> PK_FunctionPairIDChanged;

        /// <summary>
        /// When raised, indicates that the value of PK_FunctionPairID has changed which fires the PK_FunctionPairIDChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PK_FunctionPairIDChanged event.</param>
        private void OnPK_FunctionPairIDChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (PK_FunctionPairIDChanged != null)
                PK_FunctionPairIDChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of PrimaryFunction has changed.<para></para><para></para>This will only fire when the value of the property PrimaryFunction is set. If the corresponding value is set through the underlying row or through the property PrimaryFunctionColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> PrimaryFunctionChanged;

        /// <summary>
        /// When raised, indicates that the value of PrimaryFunction has changed which fires the PrimaryFunctionChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PrimaryFunctionChanged event.</param>
        private void OnPrimaryFunctionChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (PrimaryFunctionChanged != null)
                PrimaryFunctionChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of ParameterlessFunction has changed.<para></para><para></para>This will only fire when the value of the property ParameterlessFunction is set. If the corresponding value is set through the underlying row or through the property ParameterlessFunctionColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.Int32>> ParameterlessFunctionChanged;

        /// <summary>
        /// When raised, indicates that the value of ParameterlessFunction has changed which fires the ParameterlessFunctionChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ParameterlessFunctionChanged event.</param>
        private void OnParameterlessFunctionChanged(RowValueChangedEventArgs<System.Int32> e)
        {
            if (ParameterlessFunctionChanged != null)
                ParameterlessFunctionChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of PrimaryFunctionIdentifier has changed.<para></para><para></para>This will only fire when the value of the property PrimaryFunctionIdentifier is set. If the corresponding value is set through the underlying row or through the property PrimaryFunctionIdentifierColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.String>> PrimaryFunctionIdentifierChanged;

        /// <summary>
        /// When raised, indicates that the value of PrimaryFunctionIdentifier has changed which fires the PrimaryFunctionIdentifierChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PrimaryFunctionIdentifierChanged event.</param>
        private void OnPrimaryFunctionIdentifierChanged(RowValueChangedEventArgs<System.String> e)
        {
            if (PrimaryFunctionIdentifierChanged != null)
                PrimaryFunctionIdentifierChanged(this, e);
        }

        /// <summary>
        /// Raised when the value of ParameterlessFunctionIdentifier has changed.<para></para><para></para>This will only fire when the value of the property ParameterlessFunctionIdentifier is set. If the corresponding value is set through the underlying row or through the property ParameterlessFunctionIdentifierColumn, this event will not fire.
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<System.String>> ParameterlessFunctionIdentifierChanged;

        /// <summary>
        /// When raised, indicates that the value of ParameterlessFunctionIdentifier has changed which fires the ParameterlessFunctionIdentifierChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ParameterlessFunctionIdentifierChanged event.</param>
        private void OnParameterlessFunctionIdentifierChanged(RowValueChangedEventArgs<System.String> e)
        {
            if (ParameterlessFunctionIdentifierChanged != null)
                ParameterlessFunctionIdentifierChanged(this, e);
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
        /// PK_FunctionPairID int IDENTITY (1,1) PRIMARY KEY,
        /// </summary>
        public System.Int32 PK_FunctionPairID
        {
            get { return this.PK_FunctionPairIDColumn.Value.ToInt(); }
            set { this.PK_FunctionPairIDColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnPK_FunctionPairIDChanged when the value of PK_FunctionPairID in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PK_FunctionPairID_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasPK_FunctionPairIDValueChanged = true;

            // Find the Foreign Key that refers to this Column (if there is any)
            var foreignKeyStrongRows = this.GetForeignKeyColumnsReferringToColumn(PK_FunctionPairIDColumn);
            if (foreignKeyStrongRows != null)
                foreach (var foreignKeyStrongRow in foreignKeyStrongRows)
                    this.Parent.GetStrongRowColumn(foreignKeyStrongRow.ForeignKeyColumn).Value = e.NewValue;

            OnPK_FunctionPairIDChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.PK_FunctionPairIDColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of PK_FunctionPairID in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.PK_FunctionPairID) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsPK_FunctionPairIDNullOrEmpty
        {
            get { return this.PK_FunctionPairIDColumn.Value.IsNullOrDBNull() || this.PK_FunctionPairID == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets PK_FunctionPairID as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PK_FunctionPairIDNullable
        {
            get { return IsPK_FunctionPairIDNullOrEmpty ? null as System.Int32? : this.PK_FunctionPairID; }
        }

        /// <summary>
        /// The identifier of the Primary Function in this IFunctionPair. The IFunction can have any number of parameters (or no parameters). This is the IFunction for which the ICodon primarily encodes.
        /// </summary>
        public System.Int32 PrimaryFunction
        {
            get { return this.PrimaryFunctionColumn.Value.ToInt(); }
            set { this.PrimaryFunctionColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnPrimaryFunctionChanged when the value of PrimaryFunction in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PrimaryFunction_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasPrimaryFunctionValueChanged = true;

            // Only update the primary key of the Foreign Row if we need to (so that we don't circularly update the primary keys).
            if (this._primaryFunctionRow != null)
                if (this.PrimaryFunctionRow.PrimaryKey != this.PrimaryFunction)
                    this.PrimaryFunctionRow.PrimaryKey = this.PrimaryFunction;

            OnPrimaryFunctionChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.PrimaryFunctionColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of PrimaryFunction in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.PrimaryFunction) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsPrimaryFunctionNullOrEmpty
        {
            get { return this.PrimaryFunctionColumn.Value.IsNullOrDBNull() || this.PrimaryFunction == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets PrimaryFunction as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PrimaryFunctionNullable
        {
            get { return IsPrimaryFunctionNullOrEmpty ? null as System.Int32? : this.PrimaryFunction; }
        }

        /// <summary>
        /// The identifier of a Parameterless IFunction that will be used if a parameterless IFunction is required. If a ICodon is in the \"tail\" of the IDNA (i.e. in the portion of the IDNA that will only accept \"terminal\" IFunctions), it will use this parameterless IFunction.
        /// </summary>
        public System.Int32 ParameterlessFunction
        {
            get { return this.ParameterlessFunctionColumn.Value.ToInt(); }
            set { this.ParameterlessFunctionColumn.Value = value; }
        }

        /// <summary>
        /// Raises OnParameterlessFunctionChanged when the value of ParameterlessFunction in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ParameterlessFunction_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasParameterlessFunctionValueChanged = true;

            // Only update the primary key of the Foreign Row if we need to (so that we don't circularly update the primary keys).
            if (this._parameterlessFunctionRow != null)
                if (this.ParameterlessFunctionRow.PrimaryKey != this.ParameterlessFunction)
                    this.ParameterlessFunctionRow.PrimaryKey = this.ParameterlessFunction;

            OnParameterlessFunctionChanged(new RowValueChangedEventArgs<System.Int32>(e.PreviousValue.ToInt(), e.NewValue.ToInt(), this.ParameterlessFunctionColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of ParameterlessFunction in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.ParameterlessFunction) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsParameterlessFunctionNullOrEmpty
        {
            get { return this.ParameterlessFunctionColumn.Value.IsNullOrDBNull() || this.ParameterlessFunction == SQLer.EmptyInt; }
        }

        /// <summary>
        /// Gets ParameterlessFunction as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? ParameterlessFunctionNullable
        {
            get { return IsParameterlessFunctionNullOrEmpty ? null as System.Int32? : this.ParameterlessFunction; }
        }

        /// <summary>
        /// The unique FunctionIdentifier of the Primary Function.
        /// </summary>
        public System.String PrimaryFunctionIdentifier
        {
            get
            {
                if (this.PrimaryFunctionIdentifierColumn.Value != null)
                    return this.PrimaryFunctionIdentifierColumn.Value.ToString();
                else
                    return null;
            }
            set
            {
                if (value == null)
                    throw new Exception("PrimaryFunctionIdentifier cannot be null.");

                this.PrimaryFunctionIdentifierColumn.Value = value;
            }
        }

        /// <summary>
        /// Raises OnPrimaryFunctionIdentifierChanged when the value of PrimaryFunctionIdentifier in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PrimaryFunctionIdentifier_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasPrimaryFunctionIdentifierValueChanged = true;

            OnPrimaryFunctionIdentifierChanged(new RowValueChangedEventArgs<System.String>(e.PreviousValue.IsNullOrDBNull() ? null : e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : e.NewValue.ToString(), this.PrimaryFunctionIdentifierColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of PrimaryFunctionIdentifier in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.PrimaryFunctionIdentifier) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsPrimaryFunctionIdentifierNullOrEmpty
        {
            get { return this.PrimaryFunctionIdentifierColumn.Value.IsNullOrDBNull() || this.PrimaryFunctionIdentifier == String.Empty; }
        }

        /// <summary>
        /// The unique FunctionIdentifier of the Parameterless Function.
        /// </summary>
        public System.String ParameterlessFunctionIdentifier
        {
            get
            {
                if (this.ParameterlessFunctionIdentifierColumn.Value != null)
                    return this.ParameterlessFunctionIdentifierColumn.Value.ToString();
                else
                    return null;
            }
            set
            {
                if (value == null)
                    throw new Exception("ParameterlessFunctionIdentifier cannot be null.");

                this.ParameterlessFunctionIdentifierColumn.Value = value;
            }
        }

        /// <summary>
        /// Raises OnParameterlessFunctionIdentifierChanged when the value of ParameterlessFunctionIdentifier in the underlying Row changes.
        /// </summary>
        /// <param name="sender">The sender that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ParameterlessFunctionIdentifier_ValueChanged(object sender, RowValueChangedEventArgs<object> e)
        {
            this.HasParameterlessFunctionIdentifierValueChanged = true;

            OnParameterlessFunctionIdentifierChanged(new RowValueChangedEventArgs<System.String>(e.PreviousValue.IsNullOrDBNull() ? null : e.PreviousValue.ToString(), e.NewValue.IsNullOrDBNull() ? null : e.NewValue.ToString(), this.ParameterlessFunctionIdentifierColumn.Column, this));
        }

        /// <summary>
        /// Indicates whether the value of ParameterlessFunctionIdentifier in the underlying row is null or DBNull.Value or Empty.<para></para><para></para>Some values may be null (such as the primary key) and therefore can't be accessed through the strongly-typed property (such as this.ParameterlessFunctionIdentifier) without an exception being thrown in the conversion to a non-null type.
        /// </summary>
        public bool IsParameterlessFunctionIdentifierNullOrEmpty
        {
            get { return this.ParameterlessFunctionIdentifierColumn.Value.IsNullOrDBNull() || this.ParameterlessFunctionIdentifier == String.Empty; }
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
        /// Indicates whether any value in this FunctionPairRow that is not a Row (ForeignStrongRow or ForeignKeyStrongRow) is null or DBNull.Value or Empty. If false, all non-row values have values (i.e. are not null).
        /// </summary>
        public override bool IsAnyNonRowValueNullOrEmpty
        {
            get
            {
                if (this.IsPK_FunctionPairIDNullOrEmpty)
                    return true;
                if (this.IsPrimaryFunctionNullOrEmpty)
                    return true;
                if (this.IsParameterlessFunctionNullOrEmpty)
                    return true;
                if (this.IsPrimaryFunctionIdentifierNullOrEmpty)
                    return true;
                if (this.IsParameterlessFunctionIdentifierNullOrEmpty)
                    return true;
                if (this.IsGeneticCodeNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Indicates whether the value of PK_FunctionPairID has changed since either this FunctionPairRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasPK_FunctionPairIDValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of PrimaryFunction has changed since either this FunctionPairRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasPrimaryFunctionValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of ParameterlessFunction has changed since either this FunctionPairRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasParameterlessFunctionValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of PrimaryFunctionIdentifier has changed since either this FunctionPairRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasPrimaryFunctionIdentifierValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of ParameterlessFunctionIdentifier has changed since either this FunctionPairRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasParameterlessFunctionIdentifierValueChanged { get; private set; }

        /// <summary>
        /// Indicates whether the value of GeneticCode has changed since either this FunctionPairRow was created or since the last time ResetAllHasAnyValueChangedFlags() or ResetAllThisAndChildrenHasAnyValueChangedFlags() was called.
        /// </summary>
        public bool HasGeneticCodeValueChanged { get; private set; }

        /// <summary>
        /// An instance of the PrimaryFunctionRow that stores the values that are referenced by the foreign key column "PrimaryFunction".
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow _primaryFunctionRow;
        /// <summary>
        /// /// An instance of the PrimaryFunctionRow that stores the values that are referenced by the foreign key column "PrimaryFunction".
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow PrimaryFunctionRow
        {
            get
            {
                if (this._primaryFunctionRow == null)
                {
                    this._primaryFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
                    this.InitializePrimaryFunctionRow();
                }

                return _primaryFunctionRow;
            }
            set
            {
                var originalValue = this.PrimaryFunctionRow;
                this._primaryFunctionRow = value;


                this.InitializePrimaryFunctionRow();

                OnPrimaryFunctionRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunction, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunction, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this FunctionPairRow to the foreign PrimaryFunctionRow. This contains the ForeignKeyColumn of this FunctionPairRow and the referenced ForeignColumn that will be used to join the PrimaryFunctionRow.
        /// </summary>
        private StrongRowForeignKeyColumn _primaryFunctionRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this FunctionPairRow to the foreign PrimaryFunctionRow. This contains the ForeignKeyColumn of this FunctionPairRow and the referenced ForeignColumn that will be used to join the PrimaryFunctionRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn PrimaryFunctionRowColumn
        {
            get
            {
                if (this._primaryFunctionRowColumn == null)
                    this.PrimaryFunctionRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.PrimaryFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunction);

                return this._primaryFunctionRowColumn;
            }
            private set { this._primaryFunctionRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of PrimaryFunctionRow has changed (is NOT raised when a value inside PrimaryFunctionRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow>> PrimaryFunctionRowChanged;

        /// <summary>
        /// Indicates that the value of PrimaryFunction has changed which fires the PrimaryFunctionChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the PrimaryFunctionRowChanged event.</param>
        private void OnPrimaryFunctionRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow> e)
        {
            if (PrimaryFunctionRowChanged != null)
                PrimaryFunctionRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignStrongRow PrimaryFunctionRow.
        /// </summary>
        private void SubscribeToValueChangesOfPrimaryFunctionRow()
        {
            if (this.PrimaryFunctionRow != null)
                this.PrimaryFunctionRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when initializing the value of PrimaryFunctionRow.
        /// </summary>
        private void InitializePrimaryFunctionRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.PrimaryFunctionRow))
                this.OtherRowTableAliases.Remove(this.PrimaryFunctionRow);

            this.PrimaryFunctionRowColumn.ForeignRow = this.PrimaryFunctionRow;

            this.OtherRowTableAliases.Add(this.PrimaryFunctionRow, "primaryFunction");
            this.PrimaryFunctionRow.Parent = this;
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunction].Value.IsInt() && this.PrimaryFunction != null)
                this.PrimaryFunctionRow.PrimaryKey = this.PrimaryFunction;
            SubscribeToValueChangesOfPrimaryFunctionRow();
        }

        /// <summary>
        /// Indicates whether the value of the PrimaryFunctionRow is null or DBNull.Value (does not Initialize the PrimaryFunctionRow if it is currently null).
        /// </summary>
        public bool IsPrimaryFunctionRowNull
        {
            get { return this._primaryFunctionRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// An instance of the ParameterlessFunctionRow that stores the values that are referenced by the foreign key column "ParameterlessFunction".
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow _parameterlessFunctionRow;
        /// <summary>
        /// /// An instance of the ParameterlessFunctionRow that stores the values that are referenced by the foreign key column "ParameterlessFunction".
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow ParameterlessFunctionRow
        {
            get
            {
                if (this._parameterlessFunctionRow == null)
                {
                    this._parameterlessFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
                    this.InitializeParameterlessFunctionRow();
                }

                return _parameterlessFunctionRow;
            }
            set
            {
                var originalValue = this.ParameterlessFunctionRow;
                this._parameterlessFunctionRow = value;


                this.InitializeParameterlessFunctionRow();

                OnParameterlessFunctionRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunction, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunction, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this FunctionPairRow to the foreign ParameterlessFunctionRow. This contains the ForeignKeyColumn of this FunctionPairRow and the referenced ForeignColumn that will be used to join the ParameterlessFunctionRow.
        /// </summary>
        private StrongRowForeignKeyColumn _parameterlessFunctionRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this FunctionPairRow to the foreign ParameterlessFunctionRow. This contains the ForeignKeyColumn of this FunctionPairRow and the referenced ForeignColumn that will be used to join the ParameterlessFunctionRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn ParameterlessFunctionRowColumn
        {
            get
            {
                if (this._parameterlessFunctionRowColumn == null)
                    this.ParameterlessFunctionRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.ParameterlessFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunction);

                return this._parameterlessFunctionRowColumn;
            }
            private set { this._parameterlessFunctionRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ParameterlessFunctionRow has changed (is NOT raised when a value inside ParameterlessFunctionRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow>> ParameterlessFunctionRowChanged;

        /// <summary>
        /// Indicates that the value of ParameterlessFunction has changed which fires the ParameterlessFunctionChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ParameterlessFunctionRowChanged event.</param>
        private void OnParameterlessFunctionRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow> e)
        {
            if (ParameterlessFunctionRowChanged != null)
                ParameterlessFunctionRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignStrongRow ParameterlessFunctionRow.
        /// </summary>
        private void SubscribeToValueChangesOfParameterlessFunctionRow()
        {
            if (this.ParameterlessFunctionRow != null)
                this.ParameterlessFunctionRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when initializing the value of ParameterlessFunctionRow.
        /// </summary>
        private void InitializeParameterlessFunctionRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ParameterlessFunctionRow))
                this.OtherRowTableAliases.Remove(this.ParameterlessFunctionRow);

            this.ParameterlessFunctionRowColumn.ForeignRow = this.ParameterlessFunctionRow;

            this.OtherRowTableAliases.Add(this.ParameterlessFunctionRow, "parameterlessFunction");
            this.ParameterlessFunctionRow.Parent = this;
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunction].Value.IsInt() && this.ParameterlessFunction != null)
                this.ParameterlessFunctionRow.PrimaryKey = this.ParameterlessFunction;
            SubscribeToValueChangesOfParameterlessFunctionRow();
        }

        /// <summary>
        /// Indicates whether the value of the ParameterlessFunctionRow is null or DBNull.Value (does not Initialize the ParameterlessFunctionRow if it is currently null).
        /// </summary>
        public bool IsParameterlessFunctionRowNull
        {
            get { return this._parameterlessFunctionRow.IsNullOrDBNull(); }
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

                OnGeneticCodeRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.GeneticCode, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.GeneticCode, this, RowValueType.ForeignStrongRow));
            }
        }

        /// <summary>
        /// A StrongRowForeignKeyColumn that can be used to join this FunctionPairRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this FunctionPairRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// </summary>
        private StrongRowForeignKeyColumn _geneticCodeRowColumn;
        /// <summary>
        /// /// A StrongRowForeignKeyColumn that can be used to join this FunctionPairRow to the foreign GeneticCodeRow. This contains the ForeignKeyColumn of this FunctionPairRow and the referenced ForeignColumn that will be used to join the GeneticCodeRow.
        /// /// </summary>
        public StrongRowForeignKeyColumn GeneticCodeRowColumn
        {
            get
            {
                if (this._geneticCodeRowColumn == null)
                    this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.GeneticCode);

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
            if (this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.GeneticCode].Value.IsInt() && this.GeneticCode != null)
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
        /// Indicates whether any Foreign StrongRow in this FunctionPairRow is null or DBNull.Value or empty.
        /// </summary>
        public override bool IsAnyForeignRowNull
        {
            get
            {
                if (this.IsPrimaryFunctionNullOrEmpty)
                    return true;
                if (this.IsParameterlessFunctionNullOrEmpty)
                    return true;
                if (this.IsGeneticCodeNullOrEmpty)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow that stores the values of the ForeignKey Strong Row if it were joined to this FunctionPairRow on the Foreign Key Column "FunctionPair". This FunctionPairRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Codon_FunctionPairRow ForeignKeyStrongRow.
        /// </summary>
        private global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow _foreignKeyRow_Codon_FunctionPairRow;
        /// <summary>
        /// /// An instance of the global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow that stores the values of the ForeignKey Strong Row if it were joined to this FunctionPairRow on the Foreign Key Column "FunctionPair". This FunctionPairRow acts as though it were a ForeignStrongRow to the ForeignKeyRow_Codon_FunctionPairRow ForeignKeyStrongRow.
        /// /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow ForeignKeyRow_Codon_FunctionPairRow
        {
            get
            {
                if (this._foreignKeyRow_Codon_FunctionPairRow == null)
                {
                    this._foreignKeyRow_Codon_FunctionPairRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow();
                    this.InitializeForeignKeyRow_Codon_FunctionPairRow();
                }

                return _foreignKeyRow_Codon_FunctionPairRow;
            }
            set
            {
                var originalValue = this.ForeignKeyRow_Codon_FunctionPairRow;
                this._foreignKeyRow_Codon_FunctionPairRow = value;


                this.InitializeForeignKeyRow_Codon_FunctionPairRow();

                OnForeignKeyRow_Codon_FunctionPairRowChanged(new RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow>(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.FunctionPair, this));
                OnAnyValueOfRowChanged(new AnyValueOfRowChangedEventArgs(originalValue, value, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.FunctionPair, this, RowValueType.ForeignKeyStrongRow));
            }
        }

        /// <summary>
        /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "FunctionPair" that belongs to ForeignKey StrongRow "ForeignKeyRow_Codon_FunctionPairRow" (which is a different StrongRow than this FunctionPairRow). This ForeignKeyToThisStrongRowColumn that can be used to join this FunctionPairRow to the ForeignKeyStrongRow "ForeignKeyRow_Codon_FunctionPairRow.
        /// </summary>
        private ForeignKeyToThisStrongRowColumn _foreignKeyRow_Codon_FunctionPairRowColumn;
        /// <summary>
        /// /// A ForeignKeyToThisStrongRowColumn that Contains information about the ForeignKey "FunctionPair" that belongs to ForeignKey StrongRow "ForeignKeyRow_Codon_FunctionPairRow" (which is a different StrongRow than this FunctionPairRow). This ForeignKeyToThisStrongRowColumn that can be used to join this FunctionPairRow to the ForeignKeyStrongRow "ForeignKeyRow_Codon_FunctionPairRow.
        /// /// </summary>
        public ForeignKeyToThisStrongRowColumn ForeignKeyRow_Codon_FunctionPairRowColumn
        {
            get
            {
                if (this._foreignKeyRow_Codon_FunctionPairRowColumn == null)
                    this.ForeignKeyRow_Codon_FunctionPairRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_Codon_FunctionPairRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.FunctionPair);

                return this._foreignKeyRow_Codon_FunctionPairRowColumn;
            }
            private set { this._foreignKeyRow_Codon_FunctionPairRowColumn = value; }
        }

        /// <summary>
        /// Raised when the value of ForeignKeyRow_Codon_FunctionPairRow has changed (is NOT raised when a value inside ForeignKeyRow_Codon_FunctionPairRow has changed).
        /// </summary>
        public event EventHandler<RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow>> ForeignKeyRow_Codon_FunctionPairRowChanged;

        /// <summary>
        /// Indicates that the value of FunctionPair has changed which fires the FunctionPairChanged Event.
        /// </summary>
        /// <param name="e">Event Arguments for the ForeignKeyRow_Codon_FunctionPairRowChanged event.</param>
        private void OnForeignKeyRow_Codon_FunctionPairRowChanged(RowValueChangedEventArgs<global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow> e)
        {
            if (ForeignKeyRow_Codon_FunctionPairRowChanged != null)
                ForeignKeyRow_Codon_FunctionPairRowChanged(this, e);
        }

        /// <summary>
        /// This method subscribes to the "AnyValueOfRowOrForeignRowOrForeignKeyRowChanged" event of the ForeignKeyStrongRow ForeignKeyRow_Codon_FunctionPairRow.
        /// </summary>
        private void SubscribeToValueChangesOfForeignKeyRow_Codon_FunctionPairRow()
        {
            if (this.ForeignKeyRow_Codon_FunctionPairRow != null)
                this.ForeignKeyRow_Codon_FunctionPairRow.AnyValueOfRowOrForeignRowOrForeignKeyRowChanged += new EventHandler<AnyValueOfRowOrForeignRowOrForeignKeyRowChangedEventArgs>(RaiseForeignKeyStrongRowValueChanged);
        }

        /// <summary>
        /// Handles the necessary work when setting the value of ForeignKeyRow_Codon_FunctionPairRow.
        /// </summary>
        private void InitializeForeignKeyRow_Codon_FunctionPairRow()
        {
            if (this.OtherRowTableAliases.ContainsKey(this.ForeignKeyRow_Codon_FunctionPairRow))
                this.OtherRowTableAliases.Remove(this.ForeignKeyRow_Codon_FunctionPairRow);

            this.ForeignKeyRow_Codon_FunctionPairRowColumn.ForeignKeyRow = this.ForeignKeyRow_Codon_FunctionPairRow;

            this.OtherRowTableAliases.Add(this.ForeignKeyRow_Codon_FunctionPairRow, "foreignKey_Codon_FunctionPair");
            this.ForeignKeyRow_Codon_FunctionPairRow.Parent = this;
            SubscribeToValueChangesOfForeignKeyRow_Codon_FunctionPairRow();
        }

        /// <summary>
        /// Indicates whether the value of the ForeignKeyRow_Codon_FunctionPairRow is null or DBNull.Value (does not Initialize the ForeignKeyRow_Codon_FunctionPairRow if it is currently null).
        /// </summary>
        public bool IsForeignKeyRow_Codon_FunctionPairRowNull
        {
            get { return this._foreignKeyRow_Codon_FunctionPairRow.IsNullOrDBNull(); }
        }

        /// <summary>
        /// Constructs an instance of this FunctionPairRow from a specified Row.<para></para><para></para>NO STRONG ROW COLUMNS WILL BE INITIALIZED. This simply creates a wrapper around the Row in order to access the Row Values. It is helpful for performance.
        /// </summary>
        /// <param name="functionPairRow">A pair of functions where the second function is parameterless.</param>
        public FunctionPairRow(Row functionPairRow)
            : this()
        {
            this.Row = functionPairRow;
        }

        /// <summary>
        /// Constructs an instance of this FunctionPairRow from a specified global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionPairRowSerializableContainer.
        /// </summary>
        /// <param name="functionPairRowSerializableContainer">A pair of functions where the second function is parameterless.</param>
        public FunctionPairRow(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionPairRowSerializableContainer functionPairRowSerializableContainer)
            : this()
        {
            this.Row = new Row(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable);

            this.PK_FunctionPairID = functionPairRowSerializableContainer.PK_FunctionPairID;
            this.PrimaryFunction = functionPairRowSerializableContainer.PrimaryFunction;
            this.ParameterlessFunction = functionPairRowSerializableContainer.ParameterlessFunction;
            this.PrimaryFunctionIdentifier = functionPairRowSerializableContainer.PrimaryFunctionIdentifier;
            this.ParameterlessFunctionIdentifier = functionPairRowSerializableContainer.ParameterlessFunctionIdentifier;
            this.GeneticCode = functionPairRowSerializableContainer.GeneticCode;
            if (functionPairRowSerializableContainer.PrimaryFunctionRowSerializableContainer != null)
                this.PrimaryFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow(functionPairRowSerializableContainer.PrimaryFunctionRowSerializableContainer);
            if (functionPairRowSerializableContainer.ParameterlessFunctionRowSerializableContainer != null)
                this.ParameterlessFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow(functionPairRowSerializableContainer.ParameterlessFunctionRowSerializableContainer);
            if (functionPairRowSerializableContainer.GeneticCodeRowSerializableContainer != null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow(functionPairRowSerializableContainer.GeneticCodeRowSerializableContainer);
            if (functionPairRowSerializableContainer.ForeignKeyRow_Codon_FunctionPairRowSerializableContainer != null)
                this.ForeignKeyRow_Codon_FunctionPairRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow(functionPairRowSerializableContainer.ForeignKeyRow_Codon_FunctionPairRowSerializableContainer);
        }

        /// <summary>
        /// Constructs an instance of this FunctionPairRow from a set of values for the Row.
        /// </summary>
        /// <param name="primaryFunction">The identifier of the Primary Function in this IFunctionPair. The IFunction can have any number of parameters (or no parameters). This is the IFunction for which the ICodon primarily encodes.</param>
        /// <param name="parameterlessFunction">The identifier of a Parameterless IFunction that will be used if a parameterless IFunction is required. If a ICodon is in the \"tail\" of the IDNA (i.e. in the portion of the IDNA that will only accept \"terminal\" IFunctions), it will use this parameterless IFunction.</param>
        /// <param name="primaryFunctionIdentifier">The unique FunctionIdentifier of the Primary Function.</param>
        /// <param name="parameterlessFunctionIdentifier">The unique FunctionIdentifier of the Parameterless Function.</param>
        /// <param name="geneticCode">The GeneticCode to which this Function applies.</param>
        /// <param name="primaryFunctionRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow that holds the values of the row that the foreign key "PrimaryFunction" is referencing. Row Description: A pair of functions where the second function is parameterless.</param>
        /// <param name="parameterlessFunctionRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow that holds the values of the row that the foreign key "ParameterlessFunction" is referencing. Row Description: A pair of functions where the second function is parameterless.</param>
        /// <param name="geneticCodeRow">An instance of a global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow that holds the values of the row that the foreign key "GeneticCode" is referencing. Row Description: A pair of functions where the second function is parameterless.</param>
        public FunctionPairRow(System.Int32 primaryFunction, System.Int32 parameterlessFunction, System.String primaryFunctionIdentifier, System.String parameterlessFunctionIdentifier, System.Int32 geneticCode, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow primaryFunctionRow = null, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow parameterlessFunctionRow = null, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow geneticCodeRow = null)
            : this()
        {
            if (this.Row != null)
                this.Row = global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ToRow(primaryFunction: primaryFunction, parameterlessFunction: parameterlessFunction, primaryFunctionIdentifier: primaryFunctionIdentifier, parameterlessFunctionIdentifier: parameterlessFunctionIdentifier, geneticCode: geneticCode);
            this.PrimaryFunctionRow = primaryFunctionRow;
            this.ParameterlessFunctionRow = parameterlessFunctionRow;
            this.GeneticCodeRow = geneticCodeRow;
        }

        /// <summary>
        /// Constructs an instance of a FunctionPairRow
        /// </summary>
        public FunctionPairRow()
            : base(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable)
        {
            this.Values = new FunctionPairRowValues(this);
        }

        /// <summary>
        /// The TableDefinition of this FunctionPairRow
        /// </summary>
        public override TableDefinition TableDefinition
        {
            get { return this.GetTableDefinition(); }
        }

        /// <summary>
        /// Gets the TableDefinition of this FunctionPairRow
        /// </summary>
        public override TableDefinition GetTableDefinition()
        {
            return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable;
        }

        /// <summary>
        /// The TableDefinition of this FunctionPairRow
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.FunctionPairTable FunctionPairTable
        {
            get { return global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPairTable; }
        }

        /// <summary>
        /// Given a table alias (compressed or non-compressed), initializes the proper child StrongRow that has the given alias.
        /// </summary>
        /// <param name="tableAlias">The table alias (compressed or non-compressed) that will indicate which child StrongRow to initialize.</param>
        public override void InitializeChildStrongRowWithAlias(string tableAlias)
        {
            switch (tableAlias)
            {
                case "primaryFunction":
                    if (this._primaryFunctionRow == null)
                    {
                        this._primaryFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
                        this.InitializePrimaryFunctionRow();
                    }
                    return;
                case "PF15yar28":
                    if (this._primaryFunctionRow == null)
                    {
                        this._primaryFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
                        this.InitializePrimaryFunctionRow();
                    }
                    return;
                case "parameterlessFunction":
                    if (this._parameterlessFunctionRow == null)
                    {
                        this._parameterlessFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
                        this.InitializeParameterlessFunctionRow();
                    }
                    return;
                case "PF21tma30":
                    if (this._parameterlessFunctionRow == null)
                    {
                        this._parameterlessFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
                        this.InitializeParameterlessFunctionRow();
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
                case "foreignKey_Codon_FunctionPair":
                    if (this._foreignKeyRow_Codon_FunctionPairRow == null)
                    {
                        this._foreignKeyRow_Codon_FunctionPairRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow();
                        this.InitializeForeignKeyRow_Codon_FunctionPairRow();
                    }
                    return;
                case "_CFP29nio30":
                    if (this._foreignKeyRow_Codon_FunctionPairRow == null)
                    {
                        this._foreignKeyRow_Codon_FunctionPairRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow();
                        this.InitializeForeignKeyRow_Codon_FunctionPairRow();
                    }
                    return;
                default:
                    throw new Exception("The given table alias does not refer to any child StrongRow in this FunctionPairRow.");
                    return;

            }
        }

        /// <summary>
        /// Initializes all of the Foreign Strong Rows and Foreign Key StrongRows in this FunctionPairRow that are currently null. Calls the parameterless constructor for each Strong Row that is null.
        /// </summary>
        public override void InitializeChildStrongRows()
        {
            if (this.PrimaryFunctionRow == null)
                this.PrimaryFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
            if (this.ParameterlessFunctionRow == null)
                this.ParameterlessFunctionRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.TheFunctionRow();
            if (this.GeneticCodeRow == null)
                this.GeneticCodeRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.GeneticCodeRow();

            if (this.ForeignKeyRow_Codon_FunctionPairRow == null)
                this.ForeignKeyRow_Codon_FunctionPairRow = new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRows.CodonRow();
        }

        /// <summary>
        /// Initializes all of the StrongRowColumns in this FunctionPairRow that are currently null. Also handles the necessary event subscriptions.
        /// </summary>
        public override void InitializeStrongRowColumns()
        {
            if (this.PK_FunctionPairIDColumn == null)
            {
                this.PK_FunctionPairIDColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PK_FunctionPairID);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PK_FunctionPairID].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PK_FunctionPairID_ValueChanged);
            }
            if (this.PrimaryFunctionColumn == null)
            {
                this.PrimaryFunctionColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunction);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunction].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PrimaryFunction_ValueChanged);
            }
            if (this.ParameterlessFunctionColumn == null)
            {
                this.ParameterlessFunctionColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunction);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunction].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(ParameterlessFunction_ValueChanged);
            }
            if (this.PrimaryFunctionIdentifierColumn == null)
            {
                this.PrimaryFunctionIdentifierColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunctionIdentifier);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunctionIdentifier].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(PrimaryFunctionIdentifier_ValueChanged);
            }
            if (this.ParameterlessFunctionIdentifierColumn == null)
            {
                this.ParameterlessFunctionIdentifierColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunctionIdentifier);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunctionIdentifier].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(ParameterlessFunctionIdentifier_ValueChanged);
            }
            if (this.GeneticCodeColumn == null)
            {
                this.GeneticCodeColumn = new StrongRowColumn(this, global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.GeneticCode);
                this.Row[global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.GeneticCode].ValueChanged += new EventHandler<RowValueChangedEventArgs<object>>(GeneticCode_ValueChanged);
            }
        }

        /// <summary>
        /// Initializes all of the ForeignStrongRowColumns in this FunctionPairRow that are null.
        /// </summary>
        public override void InitializeForeignStrongRowColumns()
        {
            if (this.PrimaryFunctionRowColumn == null)
                this.PrimaryFunctionRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.PrimaryFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunction);
            if (this.ParameterlessFunctionRowColumn == null)
                this.ParameterlessFunctionRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.ParameterlessFunctionRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunction);
            if (this.GeneticCodeRowColumn == null)
                this.GeneticCodeRowColumn = new StrongRowForeignKeyColumn(foreignRow: this.GeneticCodeRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.GeneticCode);
        }

        /// <summary>
        /// Initializes all of the ForeignKeyToThisStrongRowColumns in this FunctionPairRow that are null.
        /// </summary>
        public override void InitializeForeignKeyToThisStrongRowColumns()
        {
            if (this.ForeignKeyRow_Codon_FunctionPairRowColumn == null)
                this.ForeignKeyRow_Codon_FunctionPairRowColumn = new ForeignKeyToThisStrongRowColumn(foreignKeyRow: this.ForeignKeyRow_Codon_FunctionPairRow, foreignKeyColumn: global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.Codon.FunctionPair);
        }

        /// <summary>
        /// Inserts the Row into the database immediately (if it is not currently in the database. This method first checks to ensure that the Row is not in the database). Returns true if the Row was inserted. Returns false if not. Out's the primary key.
        /// </summary>
        /// <param name="primaryKey">PK_FunctionPairID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// <param name="primaryKey">PK_FunctionPairID int IDENTITY (1,1) PRIMARY KEY,</param>
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
        /// Indicates whether the Primary Key PK_FunctionPairID is null or DBNull.Value or is an Empty value.
        /// </summary>
        public override bool IsPrimaryKeyNullOrEmpty
        {
            get { return this.IsPK_FunctionPairIDNullOrEmpty; }
        }

        /// <summary>
        /// The Primary Key PK_FunctionPairID for this FunctionPair.
        /// </summary>
        public System.Int32 PrimaryKey
        {
            get { return this.PK_FunctionPairID; }
            set { this.PK_FunctionPairID = value; }
        }

        /// <summary>
        /// The Primary Key Column for this FunctionPair.
        /// </summary>
        public override StrongRowColumn PrimaryKeyColumn
        {
            get { return this.PK_FunctionPairIDColumn; }
        }

        /// <summary>
        /// Gets the Primary Key as a nullable System.Int32. Has no setter.
        /// </summary>
        public System.Int32? PrimaryKeyNullable
        {
            get { return this.IsPrimaryKeyNullOrEmpty ? null as System.Int32? : this.PrimaryKey; }
        }

        /// <summary>
        /// Returns all of the Columns in the FunctionPairRow whose values have changed according to their HasChanged flags.
        /// </summary>
        public override List<Column> GetColumnsWithChangedValues()
        {
            // If no value in this row has changed then return an empty list.
            if (!this.HasAnyNonRowValueInRowChanged)
                return new List<Column>(0);

            // We will collect the columns whose values have changed.
            var columns = new List<Column>();

            if (HasPK_FunctionPairIDValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PK_FunctionPairID);
            if (HasPrimaryFunctionValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunction);
            if (HasParameterlessFunctionValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunction);
            if (HasPrimaryFunctionIdentifierValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.PrimaryFunctionIdentifier);
            if (HasParameterlessFunctionIdentifierValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.ParameterlessFunctionIdentifier);
            if (HasGeneticCodeValueChanged)
                columns.Add(global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables.DM.FunctionPair.GeneticCode);

            return columns;
        }

        /// <summary>
        /// Calls ResetAllHasAnyValueChangedFlags() for this FunctionPairRow and ResetAllThisAndChildrenHasAnyValueChangedFlags() for all children Foreign StrongRows and Foreign Key Strong Rows that are not null.
        /// </summary>
        public override void ResetAllThisAndChildrenHasAnyValueChangedFlags()
        {
            this.ResetAllHasAnyValueChangedFlags();

            if (this._primaryFunctionRow != null)
                this.PrimaryFunctionRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._parameterlessFunctionRow != null)
                this.ParameterlessFunctionRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._geneticCodeRow != null)
                this.GeneticCodeRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
            if (this._foreignKeyRow_Codon_FunctionPairRow != null)
                this.ForeignKeyRow_Codon_FunctionPairRow.ResetAllThisAndChildrenHasAnyValueChangedFlags();
        }

        /// <summary>
        /// Resets all of the HasAnyValuesChanged for each of the values in this FunctionPairRow. Also calls the base.ResetAllHasAnyValueChangedFlags().
        /// </summary>
        public override void ResetAllHasAnyValueChangedFlags()
        {
            base.ResetAllHasAnyValueChangedFlags();

            this.HasPK_FunctionPairIDValueChanged = false;
            this.HasPrimaryFunctionValueChanged = false;
            this.HasParameterlessFunctionValueChanged = false;
            this.HasPrimaryFunctionIdentifierValueChanged = false;
            this.HasParameterlessFunctionIdentifierValueChanged = false;
            this.HasGeneticCodeValueChanged = false;
        }

        /// <summary>
        /// Gets all of the StrongRowColumns in this FunctionPairRow.
        /// </summary>
        public override StrongRowColumn[] GetAllStrongRowColumns()
        {
            return new StrongRowColumn[] { PK_FunctionPairIDColumn, PrimaryFunctionColumn, ParameterlessFunctionColumn, PrimaryFunctionIdentifierColumn, ParameterlessFunctionIdentifierColumn, GeneticCodeColumn };
        }

        /// <summary>
        /// Gets all of the StrongRowForeignKeyColumns in this FunctionPairRow.
        /// </summary>
        public override StrongRowForeignKeyColumn[] GetAllStrongRowForeignKeyColumns()
        {
            return new StrongRowForeignKeyColumn[] { PrimaryFunctionRowColumn, ParameterlessFunctionRowColumn, GeneticCodeRowColumn };
        }

        /// <summary>
        /// Gets all of the ForeignKeyToThisStrongRowColumn in this FunctionPairRow.
        /// </summary>
        public override ForeignKeyToThisStrongRowColumn[] GetAllForeignKeyToThisStrongRowColumns()
        {
            return new ForeignKeyToThisStrongRowColumn[] { ForeignKeyRow_Codon_FunctionPairRowColumn };
        }

        /// <summary>
        /// Converts the FunctionPairRow to a FunctionPairRowSerializableContainer.
        /// </summary>
        public global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionPairRowSerializableContainer ToFunctionPairRowSerializableContainer()
        {
            return new global::GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongRowSerializableContainers.FunctionPairRowSerializableContainer(this);
        }

        /// <summary>
        /// Converts the StrongRow to the appropriate StrongRowSerializableContainer.
        /// </summary>
        public override StrongRowSerializableContainer ToStrongRowSerializableContainer()
        {
            return this.ToFunctionPairRowSerializableContainer();
        }

        #region IStrongRowDescendant<T>
        /// <summary>
        /// Fills any empty values in this FunctionPairRow with the corresponding values from the given FunctionPairRow. Does NOT fill the Primary Key.
        /// </summary>
        /// <param name="sourceOfFilling">The FunctionPairRow from which we will gather values in order to fill any empty values in this FunctionPairRow.</param>
        public void FillEmptyValues(FunctionPairRow sourceOfFilling)
        {
            if (sourceOfFilling == null)
                return;

            if (this.IsPrimaryFunctionNullOrEmpty)
                this.PrimaryFunction = sourceOfFilling.PrimaryFunction;
            if (this.IsParameterlessFunctionNullOrEmpty)
                this.ParameterlessFunction = sourceOfFilling.ParameterlessFunction;
            if (this.IsPrimaryFunctionIdentifierNullOrEmpty)
                this.PrimaryFunctionIdentifier = sourceOfFilling.PrimaryFunctionIdentifier;
            if (this.IsParameterlessFunctionIdentifierNullOrEmpty)
                this.ParameterlessFunctionIdentifier = sourceOfFilling.ParameterlessFunctionIdentifier;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
            if (this.IsPrimaryFunctionNullOrEmpty)
                this.PrimaryFunction = sourceOfFilling.PrimaryFunction;
            if (this.IsParameterlessFunctionNullOrEmpty)
                this.ParameterlessFunction = sourceOfFilling.ParameterlessFunction;
            if (this.IsGeneticCodeNullOrEmpty)
                this.GeneticCode = sourceOfFilling.GeneticCode;
        }

        /// <summary>
        /// This FunctionPairRow used to fulfill the IStrongRowDescendent<T> contact.
        /// </summary>
        public FunctionPairRow Self
        {
            get { return this; }
        }

        /// <summary>
        /// Creates a deep copy of the given other FunctionPairRow. Fills this FunctionPairRow with the values, Foreign StrongRows and ForeignKey StrongRows of the given other FunctionPairRow. Fills each child row's children as well.
        /// </summary>
        /// <param name="other">The StrongRow from which values will be populated</param>
        public void PopulateFromRow(FunctionPairRow other)
        {
            this.PK_FunctionPairID = other.PK_FunctionPairID;
            this.PrimaryFunction = other.PrimaryFunction;
            this.ParameterlessFunction = other.ParameterlessFunction;
            this.PrimaryFunctionIdentifier = other.PrimaryFunctionIdentifier;
            this.ParameterlessFunctionIdentifier = other.ParameterlessFunctionIdentifier;
            this.GeneticCode = other.GeneticCode;

            if (other._primaryFunctionRow != null)
            {
                var primaryFunction = other.PrimaryFunctionRow;
                this.PrimaryFunctionRow.PopulateFromRow(primaryFunction);
            }
            if (other._parameterlessFunctionRow != null)
            {
                var parameterlessFunction = other.ParameterlessFunctionRow;
                this.ParameterlessFunctionRow.PopulateFromRow(parameterlessFunction);
            }
            if (other._geneticCodeRow != null)
            {
                var geneticCode = other.GeneticCodeRow;
                this.GeneticCodeRow.PopulateFromRow(geneticCode);
            }
            if (other._foreignKeyRow_Codon_FunctionPairRow != null)
            {
                var codon_FunctionPairRow = other.ForeignKeyRow_Codon_FunctionPairRow;
                this.ForeignKeyRow_Codon_FunctionPairRow.PopulateFromRow(codon_FunctionPairRow);
            }
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Gets the FunctionPairRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the FunctionPairRow</param>
        public static FunctionPairRow GetFunctionPairRowByID(object ID)
        {
            var functionPairRow = new FunctionPairRow();
            Qry.SelectAllFrom(functionPairRow).Where(functionPairRow.PrimaryKeyColumn, ID).Go().ExtractStrongRow(ref functionPairRow);
            return functionPairRow;
        }

        /// <summary>
        /// Gets all of the FunctionPairRows in the database.
        /// </summary>
        public static IEnumerable<FunctionPairRow> GetAllFunctionPairRows()
        {
            return Qry.SelectAllFrom(new FunctionPairRow()).Go().ExtractStrongRows<FunctionPairRow>();
        }
        #endregion

        #region StrongRow Overrides
        /// <summary>
        /// Gets the FunctionPairRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the FunctionPairRow</param>
        public override StrongRow GetByID(object ID)
        {
            return FunctionPairRow.GetFunctionPairRowByID(ID);
        }

        /// <summary>
        /// Gets all of the FunctionPairRows in the database.
        /// </summary>
        public override IEnumerable<StrongRow> GetAll()
        {
            return FunctionPairRow.GetAllFunctionPairRows();
        }
        #endregion

        #region IRepository
        /// <summary>
        /// Gets the FunctionPairRow in the database with the given primary key.
        /// </summary>
        /// <param name="ID">The primary key of the FunctionPairRow</param>
        FunctionPairRow IRepository<FunctionPairRow>.GetByID(object ID)
        {
            return FunctionPairRow.GetFunctionPairRowByID(ID);
        }

        /// <summary>
        /// Gets all of the FunctionPairRows in the database.
        /// </summary>
        IEnumerable<FunctionPairRow> IRepository<FunctionPairRow>.GetAll()
        {
            return FunctionPairRow.GetAllFunctionPairRows();
        }
        #endregion

        /// <summary>
        /// Validates all of the underlying enum values in this FunctionPairRow. If there are any errors in the Enum Values, they will be registered with the given SenderIdentifier.
        /// </summary>
        /// <param name="senderIdentifier">The SenderIdentifier used to register Errors in the enum values if any errors exist.</param>
        /// <param name="referenceNumberForErrors">The reference number that will be registered with any Errors.</param>
        public override void ValidateEnumValues(SenderIdentifier senderIdentifier, string referenceNumberForErrors)
        {

        }
    }
}