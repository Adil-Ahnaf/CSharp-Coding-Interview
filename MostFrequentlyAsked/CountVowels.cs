using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class CountVowels
    {
        public static void Run()
        {
            Console.WriteLine("==> Count Vowels in a String <==");

            string? myString = "hello";
            string? vowels = "aeiou";
            int count = 0;

            foreach (var item in myString)
            {
                if (vowels.Contains(item))
                {
                    count++;
                }
            }

            Console.WriteLine($"Vowels: {count}");

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }
}
