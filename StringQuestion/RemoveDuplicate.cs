using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.StringQuestion
{
    public class RemoveDuplicate
    {
        public static void Run()
        {
            string? str = "bookkeeper";

            var uniqueChar = str.Distinct();
            string result = new string(uniqueChar.ToArray());

            Console.WriteLine($"Orginal String: {str}");
            Console.WriteLine($"Unique String: {result}");
        }
    }
}
