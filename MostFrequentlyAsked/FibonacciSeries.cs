using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class FibonacciSeries
    {
        public static void Run()
        {
            Console.WriteLine("==> Fibonacci Series <==");
            /* 
               Fibonacci Series : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 and keeps going forever
            */

            var fibonacciSeries = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                if (i < 2)
                {
                    fibonacciSeries.Add(i);
                }
                else
                {
                    int value = fibonacciSeries[i - 1] + fibonacciSeries[i - 2];
                    fibonacciSeries.Add(value);
                }
            }

            var result = string.Join(", ", fibonacciSeries);
            Console.WriteLine($"Fibonacci Series: {result}");

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();

        }
    }
}
