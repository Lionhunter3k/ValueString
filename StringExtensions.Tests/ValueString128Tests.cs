﻿using NUnit.Framework;
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

        [Test]
        public void HashCode_Should_Be_The_Same_For_Two_Objects_With_Same_Content()
        {
            var valueString1 = new ValueString128 { 'a', 'b', 'a', 'b', 'c' };
            var valueString2 = new ValueString128 { 'a', 'b', 'a', 'b', 'c' };
            Assert.AreEqual(valueString1.GetHashCode(), valueString2.GetHashCode());
        }

        [Test]
        public void HashCode_Should_Not_Be_The_Same_For_Two_Objects_With_Different_Content()
        {
            var valueString1 = new ValueString128 { 'a', 'b', 'a', 'b', 'c' };
            var valueString2 = new ValueString128 { 'a', 'b', 'a', 'b', 'd' };
            Assert.AreNotEqual(valueString1.GetHashCode(), valueString2.GetHashCode());
        }

        [Test]
        public void ToString_Should_Have_Same_Content_And_Length_As_Count()
        {
            var referenceString = "abcdabcd";
            var valueString1 = new ValueString128();
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
            var referenceString = "aese2";
            var valueString1 = new ValueString128();
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
