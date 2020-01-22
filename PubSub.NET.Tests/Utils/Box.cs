using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace PubSubNET.Tests.Utils
{
    internal class Box<T> : IEquatable<Box<T>> where T : struct
    {
        internal T Value;

        public Box(T value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Box<T>);
        }

        public bool Equals([AllowNull] Box<T> other)
        {
            return other != null &&
                   EqualityComparer<T>.Default.Equals(Value, other.Value);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }

        public static bool operator ==(Box<T> left, Box<T> right)
        {
            return EqualityComparer<Box<T>>.Default.Equals(left, right);
        }

        public static bool operator !=(Box<T> left, Box<T> right)
        {
            return !(left == right);
        }
    }
}
