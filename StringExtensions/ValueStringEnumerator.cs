using System;

namespace StringExtensions
{
    public ref struct ValueStringEnumerator
    {
        private readonly ReadOnlySpan<char> buffer;

        private int index;

        public ValueStringEnumerator(ReadOnlySpan<char> buffer)
        {
            this.buffer = buffer;
            this.index = -1;
        }

        public bool TryYield(out char value)
        {
            if (++index < buffer.Length)
            {
                value = buffer[index];
                return true;
            }
            value = default;
            return false;
        }

        public char Current
        {
            get
            {
                return buffer[index];
            }
        }

        public bool MoveNext()
        {
            if (++index < buffer.Length)
            {
                return true;
            }
            return false;
        }
    }
}