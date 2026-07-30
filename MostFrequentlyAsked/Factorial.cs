using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class Factorial
    {
        public static void Run()
        {
            Console.WriteLine("==> Find Factorial <==");
            /*
                Factorial Formula: n!=n×(n−1)×(n−2)×⋯×2×1
            */

            Console.Write("Enter a Positive Number: ");
            int number = Int32.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }

            Console.WriteLine($"Factorinal is: {result}");

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }
}
