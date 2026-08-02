using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class RemoveDuplicate
    {
        public static void Run()
        {
            Console.WriteLine("==> Remove Duplicate in an Array <==");

            int[] myArray = { 1, 2, 3, 2, 4, 1, 5, 3 }; // Expected Output: 1, 2, 3, 4, 5
            var result = new List<int>();
            var duplicate = new List<int>();

            foreach (int num in myArray)
            {
                if (!result.Contains(num))
                    result.Add(num);
                else
                    duplicate.Add(num);
            }

            Console.WriteLine($"Result is: {string.Join(", ", result)}");
            Console.WriteLine($"Duplicate is: {string.Join(", ", duplicate)}");

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }
}
