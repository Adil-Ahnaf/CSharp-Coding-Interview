using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.ArrayQuestion
{
    public class FindSmallest
    {
        public static void Run()
        {
            int[] myArray = { 2, 4, 1, 9, 3, 6, 5 };
            Console.WriteLine($"Input Array: {string.Join(", ", myArray)}");

            Array.Sort( myArray );

            Console.WriteLine($"Smallest Value: { myArray.GetValue(0) }");
            Console.WriteLine($"2nd Smallest: { myArray.GetValue(1) }");
        }
    }
}
