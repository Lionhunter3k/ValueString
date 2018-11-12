using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions
{
    public class ValueStringOperations<T> where T : IValueStringHelper, new()
    {
        protected ValueStringOperations() { }

        public static T Helper = new T();
    }

    public class ValueStringOperations : ValueStringOperations<DefaultValueStringHelper>
    {
    }
}
