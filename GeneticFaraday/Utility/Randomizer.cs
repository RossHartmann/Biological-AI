using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Utility
{
    public static class Randomizer
    {
        private static Random RandomGenerator { get; set; }
        private static readonly object RandomGeneratorLock = new object();

        private static bool Initialized { get; set; }

        /// <summary>
        /// Resets the random generator with a new seed based
        /// on the DateTime.Now.Ticks (therefore, ensure that enough
        /// ticks have passed before resetting the generator).
        /// </summary>
        public static void Reset()
        {
            lock (Randomizer.RandomGeneratorLock)
                Randomizer.RandomGenerator = new Random((int)((DateTime.Now.Ticks << 1) ^ 17 + (DateTime.Today.Month & DateTime.Today.Day)));

            Randomizer.Initialized = true;
        }

        public static int Next()
        {
            if (!Randomizer.Initialized)
                Randomizer.Reset();

            lock (Randomizer.RandomGeneratorLock)
                return Randomizer.RandomGenerator.Next();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="minimumValue">Inclusive lower bound</param>
        /// <param name="maximumValue">Exclusive upper bound</param>
        /// <returns></returns>
        public static int Next(int minimumValue, int maximumValue)
        {
            if (!Randomizer.Initialized)
                Randomizer.Reset();

            lock (Randomizer.RandomGeneratorLock)
                return Randomizer.RandomGenerator.Next(minimumValue, maximumValue);
        }

        public static double NextDouble()
        {
            if (!Randomizer.Initialized)
                Randomizer.Reset();

            lock (Randomizer.RandomGeneratorLock)
                return Randomizer.RandomGenerator.NextDouble();
        }


        public static bool NextBool()
        {
            if (!Randomizer.Initialized)
                Randomizer.Reset();

            return Randomizer.NextDouble() < .5 ? true : false;
        }

        /// <summary>
        /// Returns a random element in the source List.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T RandomElement<T>(this IList<T> source)
        {
            if (!Randomizer.Initialized)
                Randomizer.Reset();

            return source[source.RandomIndex()];
        }

        /// <summary>
        /// Returns a random index in the source List.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static int RandomIndex<T>(this IList<T> source)
        {
            if (!Randomizer.Initialized)
                Randomizer.Reset();

            return Randomizer.Next(0, source.Count);
        }
    }
}
