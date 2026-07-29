using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class ReverseString
    {
        public static void Run()
        {
            Console.WriteLine("==> Reverse a string <==");
            Console.Write("Enter a string: ");

            string? str = Console.ReadLine();
            string? result = "";

            if (str != null)
            {
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    result += str[i];
                }
                Console.WriteLine($"Reverse string: {result}");
            }
            else
            {
                Console.WriteLine("Empty string");
            }

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }
}
