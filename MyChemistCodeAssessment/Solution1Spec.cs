using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace MyChemistCodeAssessment
{
    class Solution1Spec
    {
        [Test]
        public void shouldExtractStringBetween()
        {
            Assert.AreEqual(" my dog ", Solution1.StringBetween("I love my dog Dash!", "love", "Dash!"));
        }

        [Test]
        public void shouldReturnSameStringIfString1IsNull()
        {
            Assert.AreEqual("I love my dog Dash!", Solution1.StringBetween("I love my dog Dash!", null, "Dash!"));
        }

        [Test]
        public void shouldReturnSameStringIfString2IsNull()
        {
            Assert.AreEqual("I love my dog Dash!", Solution1.StringBetween("I love my dog Dash!", "love", null));
        }

        [Test]
        public void shouldReturnSameStringIfString1AndString2AreNull()
        {
            Assert.AreEqual("I love my dog Dash!", Solution1.StringBetween("I love my dog Dash!", null, null));
        }

        [Test]
        public void shouldReturnSameStringIfString1IsEmpty()
        {
            Assert.AreEqual("I love my dog Dash!", Solution1.StringBetween("I love my dog Dash!", "", "Dash!"));
        }

        [Test]
        public void shouldReturnSameStringIfString2IsEmpty()
        {
            Assert.AreEqual("I love my dog Dash!", Solution1.StringBetween("I love my dog Dash!", "love", ""));
        }

        [Test]
        public void shouldReturnSameStringIfString1AndString2AreEmpty()
        {
            Assert.AreEqual("I love my dog Dash!", Solution1.StringBetween("I love my dog Dash!", "", ""));
        }

        [Test]
        public void shouldReturnSameStringIfString1IsWhiteSpace()
        {
            Assert.AreEqual("I love my dog Dash!", Solution1.StringBetween("I love my dog Dash!", " ", "Dash!"));
        }

        [Test]
        public void shouldReturnSameStringIfString2IsWhiteSpace()
        {
            Assert.AreEqual("I love my dog Dash!", Solution1.StringBetween("I love my dog Dash!", "love", " "));
        }

        [Test]
        public void shouldReturnSameStringIfString1AndString2AreWhiteSpace()
        {
            Assert.AreEqual("I love my dog Dash!", Solution1.StringBetween("I love my dog Dash!", " ", " "));
        }

        [Test]
        public void shouldReturnSameStringIfString1NotExist()
        {
            Assert.AreEqual("I love my dog Dash!", Solution1.StringBetween("I love my dog Dash!", "like", "Dash!"));
        }

        [Test]
        public void shouldReturnSameStringIfString2NotExist()
        {
            Assert.AreEqual("I love my dog Dash!", Solution1.StringBetween("I love my dog Dash!", "love", "Kimi!"));
        }

        [Test]
        public void shouldReturnSameStringIfString1AndString2NotExist()
        {
            Assert.AreEqual("I love my dog Dash!", Solution1.StringBetween("I love my dog Dash!", "like", "Kimi!"));
        }

        [Test]
        public void shouldReturnSameStringIfString2IsAheadOfString1()
        {
            Assert.AreEqual("I love my dog Dash!", Solution1.StringBetween("I love my dog Dash!", "Dash!", "love"));
        }

    }
}
