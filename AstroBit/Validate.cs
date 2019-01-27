using System;

namespace AstroBit
{
    /// <summary>
    /// Argument validation methods.
    /// Use these for validation arguments passed to a method, like not <see langword="null"/> checks.
    /// </summary>
    public static class Validate
    {
        /// <summary>
        /// Validates that the given <paramref name="value"/> is not <see langword="null" />.
        /// If <paramref name="value"/> is not <see langword="null" /> then <paramref name="value"/> is returned.
        /// If <paramref name="value"/> is <see langword="null" /> then a <see cref="ArgumentNullException"/> is
        /// thrown with the optional given <paramref name="name"/>.
        /// </summary>
        /// <typeparam name="TValue">The type of the <paramref name="value"/>.</typeparam>
        /// <param name="value">The value to check if it is <see langword="null"/> or not.</param>
        /// <param name="name">The optional name to use in the <see cref="ArgumentNullException"/></param>
        /// <returns>Returns the given <paramref name="value"/> if not <see langword="null"/>.</returns>
        /// <exception cref="ArgumentNullException">value is <see langword="null"/></exception>
        /// <example>
        /// The following shows how to use this validation method.
        /// <code>
        /// public void MyMethod(Person customer)
        /// {
        ///     string name = customer
        ///         .NotNull(nameof(customer))
        ///         .Name;
        /// }
        /// </code>
        /// </example>
        public static TValue NotNull<TValue>(this TValue value, string name = null) =>
            value.NotNull(() => new ArgumentNullException(name ?? string.Empty));

        /// <summary>
        /// Validates that the given <paramref name="value"/> is not <see langword="null" />.
        /// If <paramref name="value"/> is not <see langword="null" /> then <paramref name="value"/> is returned.
        /// If <paramref name="value"/> is <see langword="null" /> then the <paramref name="exceptionFactory"/>
        /// is called an the returned exception is thrown.
        /// </summary>
        /// <typeparam name="TValue">The type of the <paramref name="value"/>.</typeparam>
        /// <param name="value">The value to check if it is <see langword="null"/> or not.</param>
        /// <param name="exceptionFactory">Function that will be called to created the exception.</param>
        /// <returns>Returns the given <paramref name="value"/> if not <see langword="null"/>.</returns>
        /// <example>
        /// The following shows how to use this validation method.
        /// <code>
        /// public void MyMethod(Person customer)
        /// {
        ///     string name = customer
        ///         .NotNull(() => new InvalidOperationException("Bad!"))
        ///         .Name;
        /// }
        /// </code>
        /// </example>
        public static TValue NotNull<TValue>(this TValue value, Func<Exception> exceptionFactory) =>
            value != null
            ? value
            : throw exceptionFactory();

#if NETCOREAPP2_0
        /// <summary>
        /// Validates that the given <paramref name="value1"/> and <paramref name="value2"/> is not <see langword="null"/>.
        /// If <paramref name="value1"/> and <paramref name="value2"/> is not <see langword="null" /> then
        /// <paramref name="value1"/> and <paramref name="value2"/> is returned in a tuple.
        /// If <paramref name="value1"/> or <paramref name="value2"/> is <see langword="null" /> then
        /// <see cref="ArgumentNullException"/> is thrown with <paramref name="name1"/> or <paramref name="name2"/>.
        /// </summary>
        /// <typeparam name="TValue1">The type of the <paramref name="value1"/>.</typeparam>
        /// <typeparam name="TValue2">The type of the <paramref name="value2"/>.</typeparam>
        /// <param name="value1">The first value to check if it is <see langword="null"/>.</param>
        /// <param name="name1">The first name to use in the <see cref="ArgumentNullException"/>.</param>
        /// <param name="value2">The second value to check if it is <see langword="null"/>.</param>
        /// <param name="name2">The second name to use in the <see cref="ArgumentNullException"/>.</param>
        /// <returns>Returns the given <paramref name="value1"/> and <paramref name="value2"/> in a tuple if none of them is <see langword="null"/>.</returns>
        /// <exception cref="ArgumentNullException">if any of <paramref name="value1"/> and <paramref name="value2"/> is <see langword="null"/>.</exception>
        public static(TValue1, TValue2) NotNull<TValue1, TValue2>(TValue1 value1, string name1, TValue2 value2, string name2) =>
            (value1.NotNull(name1), value2.NotNull(name2));
#endif

        /// <summary>
        /// Validates the given <paramref name="value"/> by calling the given <paramref name="validator"/>.
        /// If the validator returns <see langword="true"/> then the given value <paramref name="value"/> is returned.
        /// If the validator returns <see langword="false"/> then an <see cref="ArgumentException"/> is thrown
        /// with the given <paramref name="message"/>.
        /// </summary>
        /// <typeparam name="TValue">The type of the <paramref name="value"/>.</typeparam>
        /// <param name="value">The value to validate.</param>
        /// <param name="message">The message to throw is the value is not valid.</param>
        /// <param name="validator">The function that validates the value.</param>
        /// <returns>The given value after validation.</returns>
        /// <example>if <paramref name="value"/> is not valid.</example>
        public static TValue Check<TValue>(this TValue value, Func<TValue, bool> validator, string message = "") =>
            validator(value)
            ? value
            : throw new ArgumentException(message);

        public static double IsNumber(this double value, string message = "") =>
            !double.IsInfinity(value) && !double.IsNaN(value) && !double.IsNegativeInfinity(value) && !double.IsPositiveInfinity(value)
            ? value
            : throw new ArgumentException($"Expected a real number: {message}");
    }
}
