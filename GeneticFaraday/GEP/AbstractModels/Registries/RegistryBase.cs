using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Registries;
using GeneticFaraday.GEP.Models.Exceptions;
using GeneticFaraday.GEP.Models.Organisms.GeneticCodes.DNAs.AminoAcids;

namespace GeneticFaraday.GEP.AbstractModels.Registries
{
    public abstract class RegistryBase : IRegistry
    {
        /// <summary>
        /// The Identifier of this IRegistry.
        /// </summary>
        public IRegistryIdentifier Identifier { get; private set; }

        /// <summary>
        /// The type of the Registry.
        /// </summary>
        public RegistryType RegistryType { get; private set; }

        /// <summary>
        /// Indicates whether the IRegistry is ReadOnly. If true, an exception will be thrown if the IRegistry
        /// attempts a write.
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// The current position of the "needle head" that is reading 
        /// and writing the values to and from the registry.
        /// </summary>
        public int CurrentNeedlePosition { get; protected set; }

        /// <summary>
        /// The values in the Registry when the CurrentNeedlePosition has a positive value.
        /// </summary>
        public List<IAminoAcidResult> UpperValues { get; protected set; }

        /// <summary>
        /// The values in the Registry when the CurrentNeedlePosition has a negative value.
        /// 
        /// If, for instance, the CurrentNeedlePosition is at -1, then that position would
        /// correspond with LowerValues[1] (notice that the value at LowerValues[0] will NEVER be read--instead
        /// the value at UpperValues[0] will be used for CurrentNeedlePosition==0).
        /// </summary>
        public List<IAminoAcidResult> LowerValues { get; protected set; }

        /// <summary>
        /// Gets the Total Length of the Registry.
        /// </summary>
        public int TotalLength { get { return this.UpperValues.Count + this.LowerValues.Count - 1; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="readOnly">Indicates whether the IRegistry is ReadOnly. If true, an exception will be thrown if the IRegistry
        /// attempts a write.</param>
        /// <param name="registryType"></param>
        protected RegistryBase(IRegistryIdentifier identifier, RegistryType registryType, bool readOnly)
        {
            this.Clear();
            this.Identifier = identifier;
            this.ReadOnly = readOnly;
            this.RegistryType = registryType;
        }

        /// <summary>
        /// Clears the Registry and sets it back to the first position.
        /// </summary>
        public void Clear()
        {
            this.CurrentNeedlePosition = 0;
            this.LowerValues = new List<IAminoAcidResult>() { this.GetEmptyIAminoAcidResult() };
            this.UpperValues = new List<IAminoAcidResult>() { this.GetEmptyIAminoAcidResult() };
        }

        /// <summary>
        /// Reads the current value as designated by the position of the "needle head".
        /// </summary>
        /// <returns></returns>
        public IAminoAcidResult Read()
        {
            return this.ReadAt(this.CurrentNeedlePosition);
        }

        /// <summary>
        /// Reads the value at the specified position.
        /// </summary>
        /// <returns></returns>
        public IAminoAcidResult ReadAt(int position)
        {
            // Make sure we'll be able to read from this position
            this.AssertValueAtPosition(position);

            return position < 0
                       ? this.LowerValues[-position]
                       : this.UpperValues[position];
        }

        /// <summary>
        /// Gets an empty (i.e. default) IAminoAcidResult.
        /// </summary>
        /// <returns></returns>
        public IAminoAcidResult GetEmptyIAminoAcidResult()
        {
            return new AminoAcidResult();
        }

        /// <summary>
        /// Writes the specified value to the current Needle position.
        /// </summary>
        /// <param name="value"></param>
        public void Write(IAminoAcidResult value)
        {
            this.WriteAt(this.CurrentNeedlePosition, value);
        }

        /// <summary>
        /// Writes the specified value to the specified position.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="value"></param>
        public void WriteAt(int position, IAminoAcidResult value)
        {
            if(this.ReadOnly)
                throw new RegistryException("A ReadOnly Registry cannot be written.");

            // Make sure we'll be able to write to this position
            this.AssertValueAtPosition(position);

            if (position < 0)
                this.LowerValues[-position] = value;
            else
                this.UpperValues[position] = value;
        }

        /// <summary>
        /// Asserts that there is a value in the Registry for the Current Needle Position.
        /// If there is no value, it will be created and set to 0.
        /// </summary>
        public void AssertValueAtCurrentNeedlePosition()
        {
            this.AssertValueAtPosition(this.CurrentNeedlePosition);
        }

        /// <summary>
        /// Asserts that there is a value in the Registry for the given position.
        /// If there is no value, it will be created and set to 0.
        /// </summary>
        public void AssertValueAtPosition(int position)
        {
            // Is the position in the lower values or upper values?
            if (position < 0)
                this.AssertValueAtLowerPosition(position: position);
            else
                this.AssertValueAtUpperPosition(position: position);
        }

        protected virtual void AssertValueAtLowerPosition(int position)
        {
            while (this.LowerValues.Count <= (-position))
                this.LowerValues.Add(this.GetEmptyIAminoAcidResult());
        }

        protected virtual void AssertValueAtUpperPosition(int position)
        {
            while (this.UpperValues.Count <= position)
                this.UpperValues.Add(this.GetEmptyIAminoAcidResult());
        }

        /// <summary>
        /// Moves the Needle Head the specified number of positions.
        /// </summary>
        /// <param name="numberOfPositions">If positive, the needle head will be moved forward.
        /// If negative, the needle head will be moved backward.</param>
        public void Move(int numberOfPositions)
        {
            var absNumberOfPositions = Math.Abs(numberOfPositions);
            for (var i = 0; i < absNumberOfPositions; i++)
            {
                if (numberOfPositions > 0)
                    this.CurrentNeedlePosition++;
                else
                    this.CurrentNeedlePosition--;

                this.AssertValueAtCurrentNeedlePosition();
            }
        }

        /// <summary>
        /// Moves the Needle Head forward by the specified number of positions
        /// </summary>
        /// <param name="numberOfPositionsForward"></param>
        public void MoveForward(ushort numberOfPositionsForward)
        {
            this.Move(numberOfPositionsForward);
        }

        /// <summary>
        /// Moves the Needle Head backward by the specified number of positions
        /// </summary>
        /// <param name="numberOfPositionsBackward"></param>
        public void MoveBackward(ushort numberOfPositionsBackward)
        {
            this.Move(-numberOfPositionsBackward);
        }

        /// <summary>
        /// Moves the Needle forward by 1 position.
        /// </summary>
        public void MoveForward()
        {
            this.MoveTo(this.GetNextPosition());
        }

        /// <summary>
        /// Moves the Needle backward by 1 position.
        /// </summary>
        public void MoveBackward()
        {
            this.MoveTo(this.GetPreviousPosition());
        }

        /// <summary>
        /// Gets the next position of the Registry if moving forward.
        /// </summary>
        /// <returns></returns>
        public int GetNextPosition()
        {
            return this.CurrentNeedlePosition + 1;
        }

        /// <summary>
        /// Gets the previous position of the Registry if moving forward.
        /// </summary>
        /// <returns></returns>
        public int GetPreviousPosition()
        {
            return this.CurrentNeedlePosition - 1;
        }

        /// <summary>
        /// Moves the Needle Head to the specified position.
        /// </summary>
        /// <param name="position"></param>
        public void MoveTo(int position)
        {
            this.CurrentNeedlePosition = position;
            this.AssertValueAtCurrentNeedlePosition();
        }

        /// <summary>
        /// Moves the needle to the 0th position of the Registry.
        /// </summary>
        public void MoveToZero()
        {
            this.MoveTo(this.GetZeroPosition());
        }
        /// <summary>
        /// Gets the 0th position of the Registry.
        /// </summary>
        /// <returns></returns>
        public int GetZeroPosition()
        {
            return 0;
        }

        /// <summary>
        /// Moves the needle to existing upper bound of the Registry.
        /// </summary>
        public void MoveToEndOfRegistry()
        {
            this.CurrentNeedlePosition = this.GetEndPosition();
        }

        /// <summary>
        /// Returns the End of the Registry position.
        /// </summary>
        /// <returns></returns>
        public int GetEndPosition()
        {
            return this.UpperValues.Count - 1;
        }

        /// <summary>
        /// Moves the needle to the existing lower bound of the Registry.
        /// </summary>
        public void MoveToStartOfRegistry()
        {
            this.CurrentNeedlePosition = this.GetStartPosition();
        }

        /// <summary>
        /// Returns the Start of the Registry position.
        /// </summary>
        /// <returns></returns>
        public int GetStartPosition()
        {
            return -(this.LowerValues.Count - 1);
        }

        /// <summary>
        /// Moves the needle to the middle position of the Registry.
        /// </summary>
        public void MoveToMiddleOfRegistry()
        {
            this.CurrentNeedlePosition = this.GetMiddlePosition();
        }

        /// <summary>
        /// Returns the middle position of the Registry.
        /// </summary>
        /// <returns></returns>
        public int GetMiddlePosition()
        {
            var middlePosition = this.TotalLength / 2;

            if (this.UpperValues.Count > middlePosition)
            {
                // The middle position will be set to be in the upper values
                return this.UpperValues.Count - middlePosition - 1;
            }
            else
            {
                // The middle position will be set to be in the lower values
                return -(this.LowerValues.Count - middlePosition - 1);
            }
        }

        /// <summary>
        /// Indicates whether the needle is at the end of the Registry
        /// </summary>
        /// <returns></returns>
        public bool IsAtEndOfRegistry()
        {
            return this.CurrentNeedlePosition == this.GetEndPosition();
        }

        /// <summary>
        /// Indicates whether the needle is at the start of the Registry
        /// </summary>
        /// <returns></returns>
        public bool IsAtStartOfRegistry()
        {
            return this.CurrentNeedlePosition == this.GetStartPosition();
        }

        /// <summary>
        /// Indicates whether the needle is at the middle of the Registry
        /// </summary>
        /// <returns></returns>
        public bool IsAtMiddleOfRegistry()
        {
            return this.CurrentNeedlePosition == this.GetMiddlePosition();
        }

        /// <summary>
        /// Indicates whether the needle is at the 0th position of the Registry
        /// </summary>
        /// <returns></returns>
        public bool IsAtZero()
        {
            return this.CurrentNeedlePosition == this.GetZeroPosition();
        }

        public abstract IRegistry ShallowCopy();
    }
}
