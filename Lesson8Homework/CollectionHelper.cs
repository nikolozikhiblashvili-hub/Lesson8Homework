using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8Homework
{
    internal static class CollectionHelper
    {
        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            List<T> result = new List<T>();
            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static T CustomFirstOrDefault<T>(this IEnumerable<T> collection, Predicate<T> predicate)
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

        public static bool CustomAny<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    return true;   
                }
            }
            return false;
        }

        public static bool CustomAll<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            foreach (var item in collection)
            {
                if (!predicate(item))
                {
                    return false;  
                }
            }
            return true;
        }

        public static int CustomCount<T>(this IEnumerable<T> collection, Predicate<T> predicate = null)
        {
            int count = 0;
            foreach (var item in collection)
            {
                if (predicate == null || predicate(item))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
