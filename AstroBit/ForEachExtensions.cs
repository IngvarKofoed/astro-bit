using System;
using System.Collections.Generic;

namespace AstroBit
{
    /// <summary>
    /// Extensions for doing fluent and functional for-each expressions.
    /// </summary>
    public static class ForEachExtensions
    {
        /// <summary>
        /// Enumerates over all items in <paramref name="source"/> and call <paramref name="action"/> with each items.
        /// </summary>
        /// <typeparam name="T">The type of the items in <paramref name="source"/>.</typeparam>
        /// <param name="source">The source to enumerate over.</param>
        /// <param name="action">The action to call on each item.</param>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var value in source)
            {
                action(value);
            }
        }

        /// <summary>
        /// Enumerates over all items in <paramref name="source"/> and call <paramref name="action"/> with each items
        /// with the index of the given item.
        /// </summary>
        /// <typeparam name="T">The type of the items in <paramref name="source"/>.</typeparam>
        /// <param name="source">The source to enumerate over.</param>
        /// <param name="action">The action to call on each item.</param>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T, int> action)
        {
            int index = 0;
            foreach (var value in source)
            {
                action(value, index++);
            }
        }
    }
}
