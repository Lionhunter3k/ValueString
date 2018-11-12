using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace StringExtensions.Tests
{
    [TestFixture]
    public class ValueString32Tests
    {
        [Test]
        public void Length_And_Count_Should_Be_The_Same()
        {
            var valueString = new ValueString32 { 'a', 'b' };
            Assert.AreEqual(2, valueString.Length);
            Assert.AreEqual(2, valueString.Count);
        }

        [Test]
        public void Length_And_Count_Can_Be_Different()
        {
            var valueString = new ValueString32 { 'a' };
            Assert.AreEqual(2, valueString.Length);
            Assert.AreEqual(1, valueString.Count);
        }

        [Test]
        public void Length_And_Count_Can_Be_Different_Empty_String()
        {
            var valueString = new ValueString32();
            Assert.AreEqual(2, valueString.Length);
            Assert.AreEqual(0, valueString.Count);
        }

        [Test]
        public void Length_In_Bytes()
        {
            var size = Unsafe.SizeOf<ValueString32>();
            Assert.AreEqual(4, size);
        }

        [Test]
        public void HashCode_Should_Be_The_Same_For_Two_Objects_With_Same_Content()
        {
            var valueString1 = new ValueString32 { 'a', 'b' };
            var valueString2 = new ValueString32 { 'a', 'b' };
            Assert.AreEqual(valueString1.GetHashCode(), valueString2.GetHashCode());
        }

        [Test]
        public void HashCode_Should_Not_Be_The_Same_For_Two_Objects_With_Different_Content()
        {
            var valueString1 = new ValueString32 { 'a', 'c' };
            var valueString2 = new ValueString32 { 'a', 'b' };
            Assert.AreNotEqual(valueString1.GetHashCode(), valueString2.GetHashCode());
        }

        [Test]
        public void ToString_Should_Have_Same_Content_And_Length_As_Count()
        {
            var referenceString = "ab";
            var valueString1 = new ValueString32();
            foreach(var refChar in referenceString)
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
            var referenceString = "a";
            var valueString1 = new ValueString32();
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
