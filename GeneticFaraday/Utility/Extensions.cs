using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Utility;

namespace GeneticFaraday.Utility
{
    public static class Extensions
    {
        public static List<T> SubList<T>(this IList<T> source, int startIndex)
        {
            return source.SubList(startIndex, source.Count - startIndex);
        }

        public static List<T> SubList<T>(this IList<T> source, int startIndex, int length)
        {
            var newList = new List<T>();
            for (var i = startIndex; i < length + startIndex; i++)
                newList.Add(source[i]);
            return newList;
        }
    }
}
