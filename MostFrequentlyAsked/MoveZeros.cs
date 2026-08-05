using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class MoveZeros
    {
        public static void Run()
        {
            Console.WriteLine("==> Move Zero to the End <==");
            /*
                Move all the 0s in an array to the end while,
                maintaining the relative order of the non-zero elements.
            */

            int[] myArray = { 1, 0, 0, 2, 0, 3, 4, 0 };
            
            Console.WriteLine("Input: " + string.Join(", ", myArray));

            int index = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] != 0)
                {
                    myArray[index] = myArray[i];
                    index++;
                }
            }

            while (index < myArray.Length)
            {
                myArray[index] = 0;
                index++;
            }
            
            Console.WriteLine("Output: " + string.Join(", ", myArray));

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }
}
