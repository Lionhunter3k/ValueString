using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions
{
    public interface IValueStringBuffer
    {
        bool TryAdd(char value);

        void Clear();

        void Add(char value);

        bool Remove(char value);

        int Length { get; }

        int Count { get; }

        char this[int index] { get; set; }

        ValueStringReference Reference { get; set; }

        ReadOnlySpan<char> Buffer { get; }
    }
}
