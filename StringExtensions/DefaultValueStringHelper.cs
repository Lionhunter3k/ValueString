using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace StringExtensions
{
    public delegate int ValueCompareDelegate(ReadOnlySpan<char> obj1, ReadOnlySpan<char> obj2);

    public delegate int GetHashCodeDelegate(ReadOnlySpan<char> obj);

    public delegate bool ValueEqualsDelegate(ReadOnlySpan<char> obj1, ReadOnlySpan<char> obj2);

    public delegate string GetHeapStringDelegate(ReadOnlySpan<char> valueString, int? length = null);

    public class DefaultValueStringHelper : IValueStringHelper
    {
        public ValueCompareDelegate ValueCompareFunc { get; set; }

        public int ValueCompare(ReadOnlySpan<char> obj1, ReadOnlySpan<char> obj2)
        {
            if(ValueCompareFunc == null)
                return obj1.SequenceCompareTo(obj2);
            return ValueCompareFunc(obj1, obj2);
        }

        public GetHashCodeDelegate GetHashCodeFunc { get; set; }

        public int GetHashCode(ReadOnlySpan<char> obj)
        {
            if(GetHashCodeFunc == null)
                return unchecked((int)Farmhash.Sharp.Farmhash.Hash32(MemoryMarshal.AsBytes(obj)));
            return GetHashCodeFunc(obj);
            //if (obj.Length == 0)
            //    return string.Empty.GetHashCode();
            //var index = 0;
            //var h = obj[index++].GetHashCode();
            //while (index < obj.Length)
            //{
            //    h = CombineHashCodes(h, obj[index++].GetHashCode());
            //}
            //return h;
        }

        //https://github.com/dotnet/corefx/blob/664d98b3dc83a56e1e6454591c585cc6a8e19b78/src/Common/src/CoreLib/System/Tuple.cs
        //public virtual int CombineHashCodes(int h1, int h2)
        //{
        //    return (((h1 << 5) + h1) ^ h2);
        //}

        public ValueEqualsDelegate ValueEqualsFunc { get; set; }

        public bool ValueEquals(ReadOnlySpan<char> obj1, ReadOnlySpan<char> obj2)
        {
            if(ValueEqualsFunc == null)
                return obj1.SequenceEqual(obj2);
            return ValueEqualsFunc(obj1, obj2);
            //if (obj1.Length != obj2.Length)
            //    return false;
            //var pointerOf1 = 0;
            //var pointerOf2 = 0;
            //while (pointerOf1 < obj1.Length && pointerOf2 < obj2.Length)
            //{
            //    if (!obj1[pointerOf1].Equals(obj2[pointerOf2]))
            //        return false;
            //}
            //return true;
        }

        public virtual unsafe Span<char> CreateReference<TReadOnlyIndexedBuffer>(ref TReadOnlyIndexedBuffer valueString, int? length = null)
             where TReadOnlyIndexedBuffer : struct, IValueStringBuffer
        {

            var pointer = Unsafe.AsPointer(ref valueString);
            // now through the implicit casting convert to a span<byte>
            var span = new Span<char>(pointer, length.GetValueOrDefault(valueString.Count));
            return span;
        }

        public virtual unsafe string GetHeapString<TReadOnlyIndexedBuffer>(ref TReadOnlyIndexedBuffer valueString, int? length = null)
           where TReadOnlyIndexedBuffer : struct, IValueStringBuffer
        {
            var pointer = (char*)Unsafe.AsPointer(ref valueString);
            // now through the implicit casting convert to a span<byte>
            return new string(pointer, 0, length.GetValueOrDefault(valueString.Count));
        }

        public GetHeapStringDelegate GetHeapStringFunc { get; set; }

        public unsafe string GetHeapString(ReadOnlySpan<char> valueString, int? length = null)
        {
            if(GetHeapStringFunc == null)
            {
                ref var refToFirstChar = ref MemoryMarshal.GetReference(valueString);
                var pointer = (char*)Unsafe.AsPointer(ref refToFirstChar);
                // now through the implicit casting convert to a span<byte>
                return new string(pointer, 0, length.GetValueOrDefault(valueString.Length));
            }
            return GetHeapStringFunc(valueString, length);
        }
    }
}
