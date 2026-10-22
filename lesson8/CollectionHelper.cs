using System;
using System.Collections.Generic;
using System.Text;

namespace lesson8
{
    internal static class CollectionHelper
    {
        public static T CustomFirstorDefault<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default;
        }


        public static IEnumerable<T> CustomSelect<T>(this IEnumerable<T> collection, Func<T, T> convert)
        {
            List<T> result = new List<T>();
            foreach (var item in collection)
            {
                 result.Add(convert(item));
            }
            return result;
        }
    }
}
