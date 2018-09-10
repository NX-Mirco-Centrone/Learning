namespace RygelOrionis.Exercise
{
    using System;

    public static class NegatePredicate
    {
        public static Func<T, bool> Negate<T>(this Func<T, bool> f, Func<T, bool> pred) => t => !pred(t);
    }
}