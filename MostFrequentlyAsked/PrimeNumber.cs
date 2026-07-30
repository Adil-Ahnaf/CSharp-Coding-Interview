using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class PrimeNumber
    {
        public static void Run()
        {
            Console.WriteLine("==> Find Prime Number <==");
            /*
                The first few prime numbers are: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, etc.
                If the number is less than or equal to 1, it is not prime.
                If the number is 2, it is prime.
                Check if the number is divisible by any number from 2 to n - 1.
                If it is divisible by any number, it is not prime. Otherwise, it is prime.
            */

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var primeNumbers = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 2)
                {
                    if (numbers[i] == 2)
                    {
                        primeNumbers.Add(numbers[i]);
                    }
                    else
                    {
                        bool isPrime = true;

                        for (int fact = 2; fact < numbers[i]; fact++)
                        {
                            if (numbers[i] % fact == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }

                        if (isPrime)
                        {
                            primeNumbers.Add(numbers[i]);
                        }
                    }
                }
            }

            var result = string.Join(", ", primeNumbers);
            Console.WriteLine($"Prime Numbers: {result}");

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }
}