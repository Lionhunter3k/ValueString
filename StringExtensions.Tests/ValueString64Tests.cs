using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace StringExtensions.Tests
{
    [TestFixture]
    public class ValueString64Tests
    {
        [Test]
        public void Length_And_Count_Should_Be_The_Same()
        {
            var valueString32 = new ValueString64 { 'a', 'b', 'a', 'b' };
            Assert.AreEqual(4, valueString32.Length);
            Assert.AreEqual(4, valueString32.Count);
        }

        [Test]
        public void Length_And_Count_Can_Be_Different()
        {
            var valueString32 = new ValueString64 { 'a', 'b', 'c' };
            Assert.AreEqual(4, valueString32.Length);
            Assert.AreEqual(3, valueString32.Count);
        }

        [Test]
        public void Length_And_Count_Can_Be_Different_Empty_String()
        {
            var valueString32 = new ValueString64();
            Assert.AreEqual(4, valueString32.Length);
            Assert.AreEqual(0, valueString32.Count);
        }

        [Test]
        public void Length_In_Bytes()
        {
            var size = Unsafe.SizeOf<ValueString64>();
            Assert.AreEqual(8, size);
        }

        [Test]
        public void HashCode_Should_Be_The_Same_For_Two_Objects_With_Same_Content()
        {
            var valueString1 = new ValueString64 { 'a', 'b', 'a', 'b' };
            var valueString2 = new ValueString64 { 'a', 'b', 'a', 'b' };
            Assert.AreEqual(valueString1.GetHashCode(), valueString2.GetHashCode());
        }

        [Test]
        public void HashCode_Should_Not_Be_The_Same_For_Two_Objects_With_Different_Content()
        {
            var valueString1 = new ValueString64 { 'a', 'b', 'a', 'b' };
            var valueString2 = new ValueString64 { 'a', 'b', 'e', 'b' };
            Assert.AreNotEqual(valueString1.GetHashCode(), valueString2.GetHashCode());
        }

        [Test]
        public void ToString_Should_Have_Same_Content_And_Length_As_Count()
        {
            var referenceString = "abce";
            var valueString1 = new ValueString64();
            foreach (var refChar in referenceString)
            {
                valueString1.Add(refChar);
            }
            var toString = valueString1.ToString();
            Assert.AreEqual(referenceString, toString);
            Assert.AreEqual(valueString1.Count, toString.Length);
        }

        [Test]
        public void ToString_Should_Have_Same_Content_And_Length_As_Count_Partial_ValueString()
        {
            var referenceString = "awe";
            var valueString1 = new ValueString64();
            foreach (var refChar in referenceString)
            {
                valueString1.Add(refChar);
            }
            var toString = valueString1.ToString();
            Assert.AreEqual(referenceString, toString);
            Assert.AreEqual(valueString1.Count, toString.Length);
        }
    }
}
