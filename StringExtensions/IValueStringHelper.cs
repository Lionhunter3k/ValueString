using System;

namespace StringExtensions
{
    public interface IValueStringHelper
    {
        int GetHashCode(ReadOnlySpan<char> obj);
        Span<char> CreateReference<TReadOnlyIndexedBuffer>(ref TReadOnlyIndexedBuffer valueString, int? length = null) where TReadOnlyIndexedBuffer : struct, IValueStringBuffer;
        string GetHeapString(ReadOnlySpan<char> valueString, int? length = null);
        string GetHeapString<TReadOnlyIndexedBuffer>(ref TReadOnlyIndexedBuffer valueString, int? length = null) where TReadOnlyIndexedBuffer : struct, IValueStringBuffer;
        bool ValueEquals(ReadOnlySpan<char> obj1, ReadOnlySpan<char> obj2);
        int ValueCompare(ReadOnlySpan<char> obj1, ReadOnlySpan<char> obj2);
    }
}