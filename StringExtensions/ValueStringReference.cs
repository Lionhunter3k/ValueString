using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace StringExtensions
{
    public readonly ref struct ValueStringReference
    {
        private readonly IValueStringHelper helper;

        public ValueStringReference(ReadOnlySpan<char> buffer) : this()
        {
            this.helper = ValueStringOperations.Helper;
            this.Buffer = buffer;
        }

        public ValueStringReference(ReadOnlySpan<char> buffer, IValueStringHelper helper) : this(buffer)
        {
            this.helper = helper;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            if (!(obj is IValueStringBuffer objValueString))
                return false;
            return helper.ValueEquals(this.Buffer, objValueString.Buffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return helper.GetHashCode(Buffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return helper.GetHeapString(Buffer);
        }

        public char this[int index] => Buffer[index];

        public int Length => Buffer.Length;

        public ReadOnlySpan<char> Buffer { [MethodImpl(MethodImplOptions.AggressiveInlining)]get; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(ValueStringReference other)
        {
            return helper.ValueEquals(Buffer, other.Buffer);
        }
    }
}