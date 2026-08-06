using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class CountOccurrences
    {
        public static void Run()
        {
            Console.WriteLine("==> Count Occurrences <==");

            int[] myArray = { 1, 2, 2, 3, 1, 4, 2, 5, 3 };
            Dictionary<int, int> occurrences = new Dictionary<int, int>();

            foreach (int num in myArray)
            {
                if (occurrences.ContainsKey(num))
                {
                    occurrences[num]++;
                }
                else
                {
                    occurrences[num] = 1;
                }
            }

            Console.WriteLine($"Input Array: {string.Join(", ", myArray)}");
            Console.WriteLine("Occurrences:");

            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }
}
