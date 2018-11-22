using System;

namespace AstroBit
{
    public static class Monad
    {
        public static Monad<T> CreateMonad<T>(this T value) =>
            new Monad<T>(value);

        public static Monad<TTarget> Apply<TSource, TTarget>(this Monad<TSource> monad, Func<TSource, TTarget> func) =>
            func(monad.Value).CreateMonad();

        public static Monad<T> Apply<T>(this Monad<T> monad, Action<T> action)
        {
            action(monad.Value);
            return monad;
        }
    }

    public struct Monad<T>
    {
        public Monad(T value)
        {
            Value = value;
        }

        public T Value { get; }
    }
}
