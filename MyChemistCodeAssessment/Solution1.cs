using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyChemistCodeAssessment
{
    public class Solution1
    {
        public static string StringBetween(string inputString, string string1, string string2)
        {
            if (String.IsNullOrWhiteSpace(string1) || String.IsNullOrWhiteSpace(string2))
            {
                return inputString;
            }

            if (inputString.IndexOf(string1) == -1 || inputString.IndexOf(string2) == -1)
            {
                return inputString;
            }

            if (inputString.IndexOf(string2) <= inputString.IndexOf(string1)) {
                return inputString;
            }

            inputString = chopHead(inputString, string1);
            inputString = chopRear(inputString, string2);
            return inputString;
        }

        private static string chopHead(string inputString, string string1)
        {
            int startIndex = inputString.IndexOf(string1) + string1.Length;
            return inputString.Substring(startIndex, inputString.Length - startIndex);
        }

        private static string chopRear(string inputString, string string2)
        {
            int endIndex = inputString.IndexOf(string2);
            return inputString.Substring(0, endIndex);
        }
    }
}
