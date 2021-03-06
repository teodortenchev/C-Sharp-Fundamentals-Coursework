﻿namespace P6GenericCountMethodDoubles
{
    using System;

    public class Box<T> : IComparable<T>
         where T : IComparable<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public int CompareTo(T other)
        {
            return value.CompareTo(other);
        }
    }
}
