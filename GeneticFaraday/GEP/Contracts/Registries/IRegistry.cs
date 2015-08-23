using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;

namespace GeneticFaraday.GEP.Contracts.Registries
{
    public interface IRegistry : IShallowCopyable<IRegistry>
    {
        /// <summary>
        /// The Identifier of this IRegistry.
        /// </summary>
        IRegistryIdentifier Identifier { get; }

        /// <summary>
        /// The type of the Registry.
        /// </summary>
        RegistryType RegistryType { get; }

        /// <summary>
        /// Indicates whether the IRegistry is ReadOnly. If true, an exception will be thrown if the IRegistry
        /// attempts a write.
        /// </summary>
        bool ReadOnly { get; }

        /// <summary>
        /// The current position of the "needle head" that is reading 
        /// and writing the values to and from the registry.
        /// </summary>
        int CurrentNeedlePosition { get; }

        /// <summary>
        /// The values in the Registry when the CurrentNeedlePosition has a positive value.
        /// </summary>
        List<IAminoAcidResult> UpperValues { get; }

        /// <summary>
        /// The values in the Registry when the CurrentNeedlePosition has a negative value.
        /// 
        /// If, for instance, the CurrentNeedlePosition is at -1, then that position would
        /// correspond with LowerValues[1] (notice that the value at LowerValues[0] will NEVER be read--instead
        /// the value at UpperValues[0] will be used for CurrentNeedlePosition==0).
        /// </summary>
        List<IAminoAcidResult> LowerValues { get; }

        /// <summary>
        /// Gets the Total Length of the Registry.
        /// </summary>
        int TotalLength { get; }

        /// <summary>
        /// Clears the Registry and sets it back to the first position.
        /// </summary>
        void Clear();

        /// <summary>
        /// Reads the current value as designated by the position of the "needle head".
        /// </summary>
        /// <returns></returns>
        IAminoAcidResult Read();

        /// <summary>
        /// Reads the value at the specified position.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        IAminoAcidResult ReadAt(int position);

        /// <summary>
        /// Gets an empty (i.e. default) IAminoAcidResult.
        /// </summary>
        /// <returns></returns>
        IAminoAcidResult GetEmptyIAminoAcidResult();

        /// <summary>
        /// Writes the specified value to the current Needle position.
        /// </summary>
        /// <param name="value"></param>
        void Write(IAminoAcidResult value);

        /// <summary>
        /// Writes the specified value to the specified position.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="value"></param>
        void WriteAt(int position, IAminoAcidResult value);

        /// <summary>
        /// Asserts that there is a value in the Registry for the Current Needle Position.
        /// If there is no value, it will be created and set to 0.
        /// </summary>
        void AssertValueAtCurrentNeedlePosition();

        /// <summary>
        /// Asserts that there is a value in the Registry for the given position.
        /// If there is no value, it will be created and set to 0.
        /// </summary>
        /// <param name="position"></param>
        void AssertValueAtPosition(int position);

        /// <summary>
        /// Moves the Needle Head the specified number of positions.
        /// </summary>
        /// <param name="numberOfPositions">If positive, the needle head will be moved forward.
        /// If negative, the needle head will be moved backward.</param>
        void Move(int numberOfPositions);

        /// <summary>
        /// Moves the Needle Head forward by the specified number of positions.
        /// </summary>
        /// <param name="numberOfPositionsForward"></param>
        void MoveForward(ushort numberOfPositionsForward);

        /// <summary>
        /// Moves the Needle Head backward by the specified number of positions.
        /// </summary>
        /// <param name="numberOfPositionsBackward"></param>
        void MoveBackward(ushort numberOfPositionsBackward);

        /// <summary>
        /// Moves the Needle forward by 1 position.
        /// </summary>
        void MoveForward();

        /// <summary>
        /// Moves the Needle backward by 1 position.
        /// </summary>
        void MoveBackward();

        /// <summary>
        /// Gets the next position of the Registry if moving forward.
        /// </summary>
        /// <returns></returns>
        int GetNextPosition();

        /// <summary>
        /// Gets the previous position of the Registry if moving forward.
        /// </summary>
        /// <returns></returns>
        int GetPreviousPosition();

        /// <summary>
        /// Moves the Needle Head to the specified position.
        /// </summary>
        /// <param name="position"></param>
        void MoveTo(int position);

        /// <summary>
        /// Moves the needle to the 0th position of the Registry.
        /// </summary>
        void MoveToZero();

        /// <summary>
        /// Gets the 0th position of the Registry.
        /// </summary>
        /// <returns></returns>
        int GetZeroPosition();

        /// <summary>
        /// Moves the needle to existing upper bound of the Registry.
        /// </summary>
        void MoveToEndOfRegistry();

        /// <summary>
        /// Returns the End of the Registry position.
        /// </summary>
        /// <returns></returns>
        int GetEndPosition();

        /// <summary>
        /// Moves the needle to the existing lower bound of the Registry.
        /// </summary>
        void MoveToStartOfRegistry();

        /// <summary>
        /// Returns the Start of the Registry position.
        /// </summary>
        /// <returns></returns>
        int GetStartPosition();

        /// <summary>
        /// Moves the needle to the middle position of the Registry.
        /// </summary>
        void MoveToMiddleOfRegistry();

        /// <summary>
        /// Returns the middle position of the Registry.
        /// </summary>
        /// <returns></returns>
        int GetMiddlePosition();

        /// <summary>
        /// Indicates whether the needle is at the end of the Registry.
        /// </summary>
        /// <returns></returns>
        bool IsAtEndOfRegistry();

        /// <summary>
        /// Indicates whether the needle is at the start of the Registry.
        /// </summary>
        /// <returns></returns>
        bool IsAtStartOfRegistry();

        /// <summary>
        /// Indicates whether the needle is at the middle of the Registry.
        /// </summary>
        /// <returns></returns>
        bool IsAtMiddleOfRegistry();

        /// <summary>
        /// Indicates whether the needle is at the 0th position of the Registry.
        /// </summary>
        /// <returns></returns>
        bool IsAtZero();


    }
}
