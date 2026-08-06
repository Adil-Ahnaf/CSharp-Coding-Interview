using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class PairNumberSum
    {
        public static void Run()
        {
            Console.WriteLine("==> Find Pair with a Given Sum <==");

            int[] myArray = { 2, 7, 11, 15, 3, 6 };
            int targetValue = 9;

            Console.WriteLine($"Input Array: {string.Join(", ", myArray)}");

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (targetValue == (myArray[i] + myArray[i + 1]))
                {
                    Console.WriteLine($"Pair: {myArray[i]}, {myArray[i+1]}");
                }
            }

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }
}
