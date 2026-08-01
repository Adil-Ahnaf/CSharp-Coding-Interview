using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class SecondLargest
    {
        public static void Run()
        {
            Console.WriteLine("==> Find Second Largest Number in an Array <==");

            int[] myArray = { 5, 10, 25, 15, 30, 20, 1 };
            int largest = myArray.Max();
            int secondLargest = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < largest && myArray[i] > secondLargest)
                {
                    secondLargest = myArray[i];
                }
            }

            Console.WriteLine($"Second Largest is: {secondLargest}");

            Console.WriteLine("Program Finished!");
            Console.ReadKey();
        }
    }
}
