using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.String
{
    public class RemoveDuplicate
    {
        public static void Run()
        {
            Console.Write("Enter a String: ");
            string input = Console.ReadLine();

            string output = RemovingDuplicateChar(input);
            Console.WriteLine($"After Removing Duplicate: {output}");
        }

        public static string RemovingDuplicateChar(string input)
        {
            string result = string.Empty;

            foreach (char c in input)
            {
                if (!result.Contains(c))
                    result += c;
            }
            return result;
        }
    }
}
