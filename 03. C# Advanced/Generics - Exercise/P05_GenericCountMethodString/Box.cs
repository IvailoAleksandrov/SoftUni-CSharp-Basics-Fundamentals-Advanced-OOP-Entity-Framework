using System;
using System.Collections.Generic;
using System.Text;

namespace P05_GenericCountMethodString
{
    public class Box<T> : IComparable<T>
        where T : IComparable<T>
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }
        public override string ToString()
        {
            return $"{Value.GetType().FullName}: {Value}";
        }
    }
}
