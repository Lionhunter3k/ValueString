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
    }
}
