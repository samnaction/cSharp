using System;
using System.Collections.Generic;

namespace DeferredExecution
{
    public static class FilterExtension
    {
        public static IEnumerable<T> FilterWithoutYield<T>( this IEnumerable<T> source, Func<T, bool> predicate )
        {
            List<T> result = new List<T>();

            foreach (var item in source)
            {
                if(predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }


        public static IEnumerable<T> FilterWithYield<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }

        }
    }
}
