using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyChemistCodeAssessment
{
    public class Solution2
    {
        public static string CustomFormatDateTime(DateTime inputDate)
        {
            string result = String.Format("{0:dddd}, {1} {0:MMMM yyyy (H:mm tt}, {2} hours and {3} minutes {4} midday)", 
                inputDate, getOrdinalSuffix(inputDate), getTimeSpan(inputDate).Duration().Hours, 
                getTimeSpan(inputDate).Duration().Minutes, getTimeSpanDecorator(inputDate));
            return result;
        }

        private static TimeSpan getTimeSpan(DateTime inputDate)
        {
            return inputDate - getMiddayFrom(inputDate);
        }

        private static DateTime getMiddayFrom(DateTime inputDate)
        {
            return new DateTime(inputDate.Year, inputDate.Month, inputDate.Day, 12, 0, 0);
        }

        private static String getTimeSpanDecorator(DateTime inputDate)
        {
            if (inputDate >= getMiddayFrom(inputDate))
            {
                return "passed";
            }
            else
            {
                return "before";
            }
        }

        private static string getOrdinalSuffix(DateTime inputDate)
        {
            int day = inputDate.Day;

            if (day % 100 >= 11 && day % 100 <= 13)
                return String.Concat(day, "th");

            switch (day % 10)
            {
                case 1:
                    return String.Concat(day, "st");
                case 2:
                    return String.Concat(day, "nd");
                case 3:
                    return String.Concat(day, "rd");
                default:
                    return String.Concat(day, "th");
            }
        }
    }
}
