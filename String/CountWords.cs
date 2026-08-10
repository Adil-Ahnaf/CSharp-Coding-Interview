using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.String
{
    public class CountWords
    {
        public static void Run()
        {
            Console.Write("Enter a string to count words: ");
            string input = Console.ReadLine();
            int wordCount = Count(input);
            Console.WriteLine($"Word count: {wordCount}");
        }
        private static int Count(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;
            return input.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
