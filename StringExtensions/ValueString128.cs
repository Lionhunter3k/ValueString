using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace StringExtensions
{
    public struct ValueString128<T> : IValueStringBuffer, IEnumerable, IEquatable<ValueString512<T>>, IEquatable<ValueString256<T>>, IEquatable<ValueString128<T>>, IEquatable<ValueString64<T>>, IEquatable<ValueString32<T>>,
        IComparable<ValueString512<T>>, IComparable<ValueString256<T>>, IComparable<ValueString128<T>>, IComparable<ValueString64<T>>, IComparable<ValueString32<T>>
        where T: IValueStringHelper, new()
    {
        private ValueString64<T> char_1;

        private ValueString64<T> char_2;

        public int Length => char_1.Length + char_2.Length;

        public ReadOnlySpan<char> Buffer => ValueStringOperations<T>.Helper.CreateReference(ref this);

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return char_1.Count + char_2.Count; ;
            }
        }

        public ValueStringReference Reference { [MethodImpl(MethodImplOptions.AggressiveInlining)]get => new ValueStringReference(ValueStringOperations<T>.Helper.CreateReference(ref this), ValueStringOperations<T>.Helper); set => value.Buffer.CopyTo(ValueStringOperations<T>.Helper.CreateReference(ref this, Length)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Add(char value)
        {
            return char_1.Add(value) || char_2.Add(value);
        }

        public char this[int index]
        {
            get
            {
                if (index < char_1.Count)
                    return char_1[index];
                var indexOffset = index - char_1.Count;
                if (indexOffset < char_2.Count)
                    return char_2[indexOffset];
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < char_1.Count)
                    char_1[index] = value;
                var indexOffset = index - char_1.Count;
                if (indexOffset < char_2.Count)
                    char_2[indexOffset] = value;
                throw new IndexOutOfRangeException();
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is IValueStringBuffer objValueString))
                return false;
            return ValueStringOperations<T>.Helper.ValueEquals(this.Buffer, objValueString.Buffer);
        }

        public override string ToString()
        {
            return ValueStringOperations<T>.Helper.GetHeapString(ref this);
        }

        public override int GetHashCode()
        {
            return ValueStringOperations<T>.Helper.GetHashCode(this.Buffer);
        }

        public ValueStringEnumerator GetEnumerator()
        {
            return new ValueStringEnumerator(this.Buffer);
        }

        public bool Equals(ValueString512<T> other)
        {
            return ValueStringOperations<T>.Helper.ValueEquals(this.Buffer, other.Buffer);
        }

        public bool Equals(ValueString256<T> other)
        {
            return ValueStringOperations<T>.Helper.ValueEquals(this.Buffer, other.Buffer);
        }

        public bool Equals(ValueString128<T> other)
        {
            return ValueStringOperations<T>.Helper.ValueEquals(this.Buffer, other.Buffer);
        }

        public bool Equals(ValueString64<T> other)
        {
            return ValueStringOperations<T>.Helper.ValueEquals(this.Buffer, other.Buffer);
        }

        public bool Equals(ValueString32<T> other)
        {
            return ValueStringOperations<T>.Helper.ValueEquals(this.Buffer, other.Buffer);
        }

        public void Clear()
        {
            char_1.Clear();
            char_2.Clear();
        }

        public bool Remove(char value)
        {
            return char_1.Remove(value) || char_2.Remove(value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (var i = 0; i < this.Count; i++)
            {
                yield return this[i];
            }
        }

        public int CompareTo(ValueString512<T> other)
        {
            return ValueStringOperations<T>.Helper.ValueCompare(this.Buffer, other.Buffer);
        }

        public int CompareTo(ValueString256<T> other)
        {
            return ValueStringOperations<T>.Helper.ValueCompare(this.Buffer, other.Buffer);
        }

        public int CompareTo(ValueString128<T> other)
        {
            return ValueStringOperations<T>.Helper.ValueCompare(this.Buffer, other.Buffer);
        }

        public int CompareTo(ValueString64<T> other)
        {
            return ValueStringOperations<T>.Helper.ValueCompare(this.Buffer, other.Buffer);
        }

        public int CompareTo(ValueString32<T> other)
        {
            return ValueStringOperations<T>.Helper.ValueCompare(this.Buffer, other.Buffer);
        }
    }

    public struct ValueString128 : IValueStringBuffer, IEnumerable, IEquatable<ValueString512>, IEquatable<ValueString256>, IEquatable<ValueString128>, IEquatable<ValueString64>, IEquatable<ValueString32>,
        IComparable<ValueString512>, IComparable<ValueString256>, IComparable<ValueString128>, IComparable<ValueString64>, IComparable<ValueString32>
    {
        private ValueString64 char_1;

        private ValueString64 char_2;

        public int Length => char_1.Length + char_2.Length;

        public ReadOnlySpan<char> Buffer => ValueStringOperations.Helper.CreateReference(ref this);

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return char_1.Count + char_2.Count; ;
            }
        }

        public ValueStringReference Reference { [MethodImpl(MethodImplOptions.AggressiveInlining)]get => new ValueStringReference(ValueStringOperations.Helper.CreateReference(ref this)); set => value.Buffer.CopyTo(ValueStringOperations.Helper.CreateReference(ref this, Length)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Add(char value)
        {
            return char_1.Add(value) || char_2.Add(value);
        }

        public char this[int index]
        {
            get
            {
                if (index < char_1.Count)
                    return char_1[index];
                var indexOffset = index - char_1.Count;
                if (indexOffset < char_2.Count)
                    return char_2[indexOffset];
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < char_1.Count)
                    char_1[index] = value;
                var indexOffset = index - char_1.Count;
                if (indexOffset < char_2.Count)
                    char_2[indexOffset] = value;
                throw new IndexOutOfRangeException();
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is IValueStringBuffer objValueString))
                return false;
            return ValueStringOperations.Helper.ValueEquals(this.Buffer, objValueString.Buffer);
        }

        public override string ToString()
        {
            return ValueStringOperations.Helper.GetHeapString(ref this);
        }

        public override int GetHashCode()
        {
            return ValueStringOperations.Helper.GetHashCode(this.Buffer);
        }

        public ValueStringEnumerator GetEnumerator()
        {
            return new ValueStringEnumerator(this.Buffer);
        }

        public bool Equals(ValueString512 other)
        {
            return ValueStringOperations.Helper.ValueEquals(this.Buffer, other.Buffer);
        }

        public bool Equals(ValueString256 other)
        {
            return ValueStringOperations.Helper.ValueEquals(this.Buffer, other.Buffer);
        }

        public bool Equals(ValueString128 other)
        {
            return ValueStringOperations.Helper.ValueEquals(this.Buffer, other.Buffer);
        }

        public bool Equals(ValueString64 other)
        {
            return ValueStringOperations.Helper.ValueEquals(this.Buffer, other.Buffer);
        }

        public bool Equals(ValueString32 other)
        {
            return ValueStringOperations.Helper.ValueEquals(this.Buffer, other.Buffer);
        }

        public void Clear()
        {
            char_1.Clear();
            char_2.Clear();
        }

        public bool Remove(char value)
        {
            return char_1.Remove(value) || char_2.Remove(value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (var i = 0; i < this.Count; i++)
            {
                yield return this[i];
            }
        }

        public int CompareTo(ValueString512 other)
        {
            return ValueStringOperations.Helper.ValueCompare(this.Buffer, other.Buffer);
        }

        public int CompareTo(ValueString256 other)
        {
            return ValueStringOperations.Helper.ValueCompare(this.Buffer, other.Buffer);
        }

        public int CompareTo(ValueString128 other)
        {
            return ValueStringOperations.Helper.ValueCompare(this.Buffer, other.Buffer);
        }

        public int CompareTo(ValueString64 other)
        {
            return ValueStringOperations.Helper.ValueCompare(this.Buffer, other.Buffer);
        }

        public int CompareTo(ValueString32 other)
        {
            return ValueStringOperations.Helper.ValueCompare(this.Buffer, other.Buffer);
        }
    }
}