using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions
{
    public struct ValueString32<T> : IValueStringBuffer, IEnumerable, IEquatable<ValueString512<T>>, IEquatable<ValueString256<T>>, IEquatable<ValueString128<T>>, IEquatable<ValueString64<T>>, IEquatable<ValueString32<T>>,
        IComparable<ValueString512<T>>, IComparable<ValueString256<T>>, IComparable<ValueString128<T>>, IComparable<ValueString64<T>>, IComparable<ValueString32<T>>
        where T: IValueStringHelper, new()
    {
        private char char_1;

        private char char_2;

        public int Length => 2;

        public ReadOnlySpan<char> Buffer => ValueStringOperations<T>.Helper.CreateReference(ref this);

        public int Count
        {
            get
            {
                if (char_1 == char.MinValue)
                    return 0;
                if (char_2 == char.MinValue)
                    return 1;
                return 2;
            }
        }

        public ValueStringReference Reference { get => new ValueStringReference(ValueStringOperations<T>.Helper.CreateReference(ref this), ValueStringOperations<T>.Helper); set => value.Buffer.CopyTo(ValueStringOperations<T>.Helper.CreateReference(ref this, Length)); }

        public bool TryAdd(char value)
        {
            switch (Count)
            {
                case 0:
                    char_1 = value;
                    return true;
                case 1:
                    char_2 = value;
                    return true;
                default:
                    return false;
            }
        }

        public char this[int index]
        {
            get
            {
                if (index > Count)
                    throw new IndexOutOfRangeException();
                switch (index)
                {
                    case 0:
                        return char_1;
                    case 1:
                        return char_2;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index > Count)
                    throw new IndexOutOfRangeException();
                switch (index)
                {
                    case 0:
                        char_1 = value;
                        break;
                    case 1:
                        char_2 = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
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
            char_1 = char.MinValue;
            char_2 = char.MinValue;
        }

        public void Add(char value)
        {
            if (!TryAdd(value))
                throw new InvalidOperationException();
        }

        public bool Remove(char value)
        {
            if (char_1 == char.MinValue)
                return false;
            if (char_1 == value)
            {
                char_1 = char_2;
                char_2 = char.MinValue;
                return true;
            }
            if (char_2 == char.MinValue)
                return false;
            if (char_2 == value)
            {
                char_2 = char.MinValue;
                return true;
            }
            return false;
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

    public struct ValueString32 : IValueStringBuffer, IEnumerable, IEquatable<ValueString512>, IEquatable<ValueString256>, IEquatable<ValueString128>, IEquatable<ValueString64>, IEquatable<ValueString32>,
        IComparable<ValueString512>, IComparable<ValueString256>, IComparable<ValueString128>, IComparable<ValueString64>, IComparable<ValueString32>
    {
        private char char_1;

        private char char_2;

        public int Length => 2;

        public ReadOnlySpan<char> Buffer => ValueStringOperations.Helper.CreateReference(ref this);

        public int Count
        {
            get
            {
                if (char_1 == char.MinValue)
                    return 0;
                if (char_2 == char.MinValue)
                    return 1;
                return 2;
            }
        }

        public ValueStringReference Reference { get => new ValueStringReference(ValueStringOperations.Helper.CreateReference(ref this)); set => value.Buffer.CopyTo(ValueStringOperations.Helper.CreateReference(ref this, Length)); }

        public bool TryAdd(char value)
        {
            switch (Count)
            {
                case 0:
                    char_1 = value;
                    return true;
                case 1:
                    char_2 = value;
                    return true;
                default:
                    return false;
            }
        }

        public char this[int index]
        {
            get
            {
                if (index > Count)
                    throw new IndexOutOfRangeException();
                switch (index)
                {
                    case 0:
                        return char_1;
                    case 1:
                        return char_2;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index > Count)
                    throw new IndexOutOfRangeException();
                switch (index)
                {
                    case 0:
                        char_1 = value;
                        break;
                    case 1:
                        char_2 = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
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
            char_1 = char.MinValue;
            char_2 = char.MinValue;
        }

        public void Add(char value)
        {
            if (!TryAdd(value))
                throw new InvalidOperationException();
        }

        public bool Remove(char value)
        {
            if (char_1 == char.MinValue)
                return false;
            if (char_1 == value)
            {
                char_1 = char_2;
                char_2 = char.MinValue;
                return true;
            }
            if (char_2 == char.MinValue)
                return false;
            if(char_2 == value)
            {
                char_2 = char.MinValue;
                return true;
            }
            return false;
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
