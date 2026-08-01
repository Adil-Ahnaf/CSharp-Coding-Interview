using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class LargestNumber
    {
        public static void Run()
        {
            Console.WriteLine("==> Find Largest Number in an Array <==");

            int[] myArray = { 5, 10, 20, 15, 30, 25, 1 };
            int max = 0; // Assume

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
            }

            Console.WriteLine($"Largest Number is: {max}");

            Console.WriteLine("Program Finished!");
            Console.ReadKey();
        }
    }
}
