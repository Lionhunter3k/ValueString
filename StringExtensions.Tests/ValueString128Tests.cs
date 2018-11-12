using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace StringExtensions.Tests
{
    [TestFixture]
    public class ValueString128Tests
    {
        [Test]
        public void Length_And_Count_Should_Be_The_Same()
        {
            var valueString = new ValueString128 { 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b' };
            Assert.AreEqual(8, valueString.Length);
            Assert.AreEqual(8, valueString.Count);
        }

        [Test]
        public void Length_And_Count_Can_Be_Different()
        {
            var valueString = new ValueString128 { 'a', 'b', 'c', 'a', 'b', 'c' };
            Assert.AreEqual(8, valueString.Length);
            Assert.AreEqual(6, valueString.Count);
        }

        [Test]
        public void Length_And_Count_Can_Be_Different_Empty_String()
        {
            var valueString = new ValueString128();
            Assert.AreEqual(8, valueString.Length);
            Assert.AreEqual(0, valueString.Count);
        }

        [Test]
        public void Length_In_Bytes()
        {
            var size = Unsafe.SizeOf<ValueString128>();
            Assert.AreEqual(16, size);
        }
    }
}
