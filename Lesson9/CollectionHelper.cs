using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    internal static class CollectionHelper
    {
        public static T CustomLastOrDefault<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            T result = default;
            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    result = item;   
                }
            }
            return result;
        }
    }
}
