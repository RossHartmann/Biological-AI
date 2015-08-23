using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Utility
{
    public static class Algorithms
    {
        /// <summary>
        /// Finds all of the permutations for the given Elements of type T.
        /// Each permutation will have a "numberOfElementsInPermutations" number of elements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elementsToPermutate"></param>
        /// <param name="numberOfElementsInPermutations"></param>
        /// <returns></returns>
        public static List<List<T>> GetPermuations<T>(IEnumerable<T> elementsToPermutate, int numberOfElementsInPermutations)
        {
            return GetPermuations(currentPermutation: new List<T>(), elementsToPermutate: elementsToPermutate,
                                  currentDepth: 0, numberOfElementsInPermutations: numberOfElementsInPermutations);
        }

        private static List<List<T>> GetPermuations<T>(List<T> currentPermutation, IEnumerable<T> elementsToPermutate, int currentDepth, int numberOfElementsInPermutations)
        {
            var permutations = new List<List<T>>();
            foreach (var element in elementsToPermutate)
            {
                var permutationList = new List<T>(currentPermutation) { element };

                if (currentDepth + 1 < numberOfElementsInPermutations)
                {
                    permutations.AddRange(GetPermuations<T>(currentPermutation: permutationList,
                                                                   elementsToPermutate: elementsToPermutate,
                                                                   currentDepth: currentDepth + 1,
                                                                   numberOfElementsInPermutations:
                                                                       numberOfElementsInPermutations));
                }
                else
                {
                    permutations.Add(permutationList);
                }
            }

            return permutations;
        }
    }
}
