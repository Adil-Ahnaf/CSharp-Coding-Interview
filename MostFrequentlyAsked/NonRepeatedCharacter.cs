using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class NonRepeatedCharacter
    {
        public static void Run()
        {
            Console.WriteLine("==> Find First Non-Repeated Character <==");

            Console.Write("Enter a String: ");
            string? input = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please enter a valid string");
                return;
            }

            foreach (char item in input)
            {
                if (input.Count(x => x.Equals(item)) == 1)
                {
                    Console.WriteLine($"First Non-Repeated Character: {item}");
                    break;
                }
            }

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }
}
