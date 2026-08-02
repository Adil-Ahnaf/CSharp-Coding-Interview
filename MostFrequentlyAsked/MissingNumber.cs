using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class MissingNumber
    {
        public static void Run()
        {
            Console.WriteLine("==> Find Missing Number in an Array <==");

            int[] myArray = { 1, 2, 3, 5, 6, 7 };
            int totalNumber = 7; // Expected 7 numbers exist in this array

            for (int i = 1; i <= totalNumber; i++)
            {
                if (!myArray.Contains(i))
                {
                    Console.WriteLine($"Missing Number: {i}");
                    break;
                }
            }

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }
}
