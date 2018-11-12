using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace StringExtensions.Tests
{
    [TestFixture]
    public class valueStringTests
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
    }
}
