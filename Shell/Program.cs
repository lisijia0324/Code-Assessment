using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyChemistCodeAssessment;

namespace Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            string foo = Solution1.StringBetween("I love my dog Dash!", "love", "dog");
            Console.WriteLine(foo);
            string bar = Solution2.CustomFormatDateTime(DateTime.Now);
            Console.WriteLine(bar);
        }
    }
}
