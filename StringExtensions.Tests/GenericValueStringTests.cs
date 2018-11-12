using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace StringExtensions.Tests
{
    [TestFixture]
    public class GenericValueStringTests
    {
        [Test]
        public void Length_And_Count_Should_Be_The_Same_128()
        {
            var valueString = new ValueString<ValueString64, ValueString64> { 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b' };
            Assert.AreEqual(8, valueString.Length);
            Assert.AreEqual(8, valueString.Count);
        }

        [Test]
        public void Length_And_Count_Can_Be_Different_128()
        {
            var valueString = new ValueString<ValueString64, ValueString64> { 'a', 'b', 'c', 'a', 'b', 'c' };
            Assert.AreEqual(8, valueString.Length);
            Assert.AreEqual(6, valueString.Count);
        }

        [Test]
        public void Length_And_Count_Can_Be_Different_Empty_String_128()
        {
            var valueString = new ValueString<ValueString64, ValueString64>();
            Assert.AreEqual(8, valueString.Length);
            Assert.AreEqual(0, valueString.Count);
        }

        [Test]
        public void Length_In_Bytes_128()
        {
            var size = Unsafe.SizeOf<ValueString<ValueString64, ValueString64>>();
            Assert.AreEqual(16, size);
        }

        [Test]
        public void HashCode_Should_Be_The_Same_For_Two_Objects_With_Same_Content_128()
        {
            var valueString1 = new ValueString<ValueString64, ValueString64> { 'a', 'b', 'a', 'b', 'c' };
            var valueString2 = new ValueString<ValueString64, ValueString64> { 'a', 'b', 'a', 'b', 'c' };
            Assert.AreEqual(valueString1.GetHashCode(), valueString2.GetHashCode());
        }

        [Test]
        public void HashCode_Should_Not_Be_The_Same_For_Two_Objects_With_Different_Content_128()
        {
            var valueString1 = new ValueString<ValueString64, ValueString64> { 'a', 'b', 'a', 'b', 'c' };
            var valueString2 = new ValueString<ValueString64, ValueString64> { 'a', 'b', 'a', 'b', 'd' };
            Assert.AreNotEqual(valueString1.GetHashCode(), valueString2.GetHashCode());
        }

        [Test]
        public void ToString_Should_Have_Same_Content_And_Length_As_Count_128()
        {
            var referenceString = "abcdabcd";
            var valueString1 = new ValueString<ValueString64, ValueString64>();
            foreach (var refChar in referenceString)
            {
                valueString1.Add(refChar);
            }
            var toString = valueString1.ToString();
            Assert.AreEqual(referenceString, toString);
            Assert.AreEqual(valueString1.Count, toString.Length);
        }

        [Test]
        public void ToString_Should_Have_Same_Content_And_Length_As_Count_Partial_ValueString_128()
        {
            var referenceString = "aese2";
            var valueString1 = new ValueString<ValueString64, ValueString64>();
            foreach (var refChar in referenceString)
            {
                valueString1.Add(refChar);
            }
            var toString = valueString1.ToString();
            Assert.AreEqual(referenceString, toString);
            Assert.AreEqual(valueString1.Count, toString.Length);
        }

        [Test]
        public void Length_And_Count_Should_Be_The_Same_192()
        {
            var valueString = new ValueString<ValueString128, ValueString64> { 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b' };
            Assert.AreEqual(12, valueString.Length);
            Assert.AreEqual(12, valueString.Count);
        }

        [Test]
        public void Length_And_Count_Can_Be_Different_192()
        {
            var valueString = new ValueString<ValueString128, ValueString64> { 'a', 'b', 'c', 'a', 'b', 'c' };
            Assert.AreEqual(12, valueString.Length);
            Assert.AreEqual(6, valueString.Count);
        }

        [Test]
        public void Length_And_Count_Can_Be_Different_Empty_String_192()
        {
            var valueString = new ValueString<ValueString128, ValueString64>();
            Assert.AreEqual(12, valueString.Length);
            Assert.AreEqual(0, valueString.Count);
        }

        [Test]
        public void Length_In_Bytes_192()
        {
            var size = Unsafe.SizeOf<ValueString<ValueString128, ValueString64>>();
            Assert.AreEqual(24, size);
        }

        [Test]
        public void HashCode_Should_Be_The_Same_For_Two_Objects_With_Same_Content_192()
        {
            var valueString1 = new ValueString<ValueString128, ValueString64> { 'a', 'b', 'a', 'b', 'c', 'b', 'c' };
            var valueString2 = new ValueString<ValueString128, ValueString64> { 'a', 'b', 'a', 'b', 'c', 'b', 'c' };
            Assert.AreEqual(valueString1.GetHashCode(), valueString2.GetHashCode());
        }

        [Test]
        public void HashCode_Should_Not_Be_The_Same_For_Two_Objects_With_Different_Content_192()
        {
            var valueString1 = new ValueString<ValueString128, ValueString64> { 'a', 'b', 'a', 'b', 'c', 'b', 'c' };
            var valueString2 = new ValueString<ValueString128, ValueString64> { 'a', 'b', 'a', 'b', 'd', 'b', 'c' };
            Assert.AreNotEqual(valueString1.GetHashCode(), valueString2.GetHashCode());
        }

        [Test]
        public void ToString_Should_Have_Same_Content_And_Length_As_Count_192()
        {
            var referenceString = "abcdabcdeedd";
            var valueString1 = new ValueString<ValueString128, ValueString64>();
            foreach (var refChar in referenceString)
            {
                valueString1.Add(refChar);
            }
            var toString = valueString1.ToString();
            Assert.AreEqual(referenceString, toString);
            Assert.AreEqual(valueString1.Count, toString.Length);
        }

        [Test]
        public void ToString_Should_Have_Same_Content_And_Length_As_Count_Partial_ValueString_192()
        {
            var referenceString = "abcdabcdeed";
            var valueString1 = new ValueString<ValueString128, ValueString64>();
            foreach (var refChar in referenceString)
            {
                valueString1.Add(refChar);
            }
            var toString = valueString1.ToString();
            Assert.AreEqual(referenceString, toString);
            Assert.AreEqual(valueString1.Count, toString.Length);
        }

        [Test]
        public void Length_And_Count_Should_Be_The_Same_Nested_192()
        {
            var valueString = new ValueString<ValueString<ValueString64, ValueString64>, ValueString64> { 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b' };
            Assert.AreEqual(12, valueString.Length);
            Assert.AreEqual(8, valueString.Count);
        }

        [Test]
        public void Length_And_Count_Can_Be_Different_Nested_192()
        {
            var valueString = new ValueString<ValueString<ValueString64, ValueString64>, ValueString64> { 'a', 'b', 'c', 'a', 'b', 'c' };
            Assert.AreEqual(12, valueString.Length);
            Assert.AreEqual(6, valueString.Count);
        }

        [Test]
        public void Length_And_Count_Can_Be_Different_Empty_String_Nested_192()
        {
            var valueString = new ValueString<ValueString<ValueString64, ValueString64>, ValueString64>();
            Assert.AreEqual(12, valueString.Length);
            Assert.AreEqual(0, valueString.Count);
        }

        [Test]
        public void Length_In_Bytes_Nested_192()
        {
            var size = Unsafe.SizeOf<ValueString<ValueString<ValueString64, ValueString64>, ValueString64>>();
            Assert.AreEqual(24, size);
        }
    }
}
