using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace MyChemistCodeAssessment
{
    class Solution2Spec
    {
        [Test]
        public void shouldFormatDateTimeAfterMidday()
        {
            DateTime dateTime = new DateTime(2011, 2, 21, 13, 27, 0);
            Assert.AreEqual("Monday, 21st February 2011 (13:27 PM, 1 hours and 27 minutes passed midday)", Solution2.CustomFormatDateTime(dateTime));
        }

        [Test]
        public void shouldFormatDateTimeBeforeMidday()
        {
            DateTime dateTime = new DateTime(2011, 2, 21, 9, 27, 0);
            Assert.AreEqual("Monday, 21st February 2011 (9:27 AM, 2 hours and 33 minutes before midday)", Solution2.CustomFormatDateTime(dateTime));
        }

        [Test]
        public void shouldFormatDateTimeWithOrdinalDayOfMonthWithST()
        {
            DateTime dateTime = new DateTime(2011, 2, 1, 9, 27, 0);
            Assert.AreEqual("Tuesday, 1st February 2011 (9:27 AM, 2 hours and 33 minutes before midday)", Solution2.CustomFormatDateTime(dateTime));
        }

        [Test]
        public void shouldFormatDateTimeWithOrdinalDayOfMonthWithND()
        {
            DateTime dateTime = new DateTime(2011, 2, 2, 9, 27, 0);
            Assert.AreEqual("Wednesday, 2nd February 2011 (9:27 AM, 2 hours and 33 minutes before midday)", Solution2.CustomFormatDateTime(dateTime));
        }

        [Test]
        public void shouldFormatDateTimeWithOrdinalDayOfMonthWithRD()
        {
            DateTime dateTime = new DateTime(2011, 2, 3, 9, 27, 0);
            Assert.AreEqual("Thursday, 3rd February 2011 (9:27 AM, 2 hours and 33 minutes before midday)", Solution2.CustomFormatDateTime(dateTime));
        }

        [Test]
        public void shouldFormatDateTimeWithOrdinalDayOfMonthWithTH()
        {
            DateTime dateTime = new DateTime(2011, 2, 4, 9, 27, 0);
            Assert.AreEqual("Friday, 4th February 2011 (9:27 AM, 2 hours and 33 minutes before midday)", Solution2.CustomFormatDateTime(dateTime));
        }
    }
}
