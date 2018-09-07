using System;

namespace AstroBit
{
    /// <summary>
    /// Extensions for doing fluent and functional expressions.
    /// </summary>
    public static class FunctionalApplication
    {
        /// <summary>
        /// Applies the function given by <paramref name="func"/> on the value given by <paramref name="value"/>.
        /// </summary>
        /// <typeparam name="T">The type of the value to apply the function on.</typeparam>
        /// <typeparam name="TResult">The type of the result of applying the function on the value.</typeparam>
        /// <param name="value">The value to apply the function on.</param>
        /// <param name="func">The function to apply on the value.</param>
        /// <returns>Returns the result of applying the function <paramref name="func"/> on the value <paramref name="value"/>.</returns>
        /// <exception cref="ArgumentNullException">if <paramref name="func"/> is <see langword="null"/>.</exception>
        /// <example>
        /// The following shows how to use the <see cref="Apply{T, TResult}(T, Func{T, TResult})"/> extension method.
        /// <code>
        /// var stringTimesTen = "100"
        ///     .Apply(x => int.Parse(x))
        ///     .Apply(x => x * 10)
        ///     .Apply(x => x.ToString());
        /// </code>
        /// </example>
        public static TResult Apply<T, TResult>(this T value, Func<T, TResult> func)
        {
            return func
                .NotNull(nameof(func))
                .Invoke(value);
        }
    }
}
