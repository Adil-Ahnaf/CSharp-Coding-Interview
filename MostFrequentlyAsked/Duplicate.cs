using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class Duplicate
    {
        public static void Run()
        {
            Console.WriteLine("==> Find Duplicates in an Array <==");

            int[] myArray = { 1, 3, 5, 4, 3, 4, 5, 5, 6, 7 }; // Duplicates: 3, 5, 4
            var result = new List<int>();

            for (int i = 0; i < myArray.Length; i++)
            {
                int j = i + 1;
                while (j < myArray.Length)
                {
                    if (myArray[i] == myArray[j] && result.Contains(myArray[i]) == false)
                    {
                        result.Add(myArray[i]);
                    }
                    j++;
                }
            }

            Console.WriteLine($"Duplicate Numbers: {string.Join(", ", result)}");

            Console.WriteLine("\nPrograme Finished!");
            Console.ReadKey();
        }
    }
}
