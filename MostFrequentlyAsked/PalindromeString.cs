using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class PalindromeString
    {
        public static void Run()
        {
            Console.WriteLine("==> Check Palindrome String <==");
            /*
            Palindrome: "radar", "noon", "civic", "kayak"
            Not Palindrome: "house", "computer", "hello"
            */

            Console.Write("Enter a string: ");
            string? str = Console.ReadLine();

            int middlePoint;
            bool isPalindrome = true;

            if (str.Length % 2 != 0)
            {
                middlePoint = str.Length / 2;
                int next = middlePoint + 1;
                int prev = middlePoint - 1;

                for (int i = 1; i <= middlePoint; i++)
                {
                    if (str[prev] != str[next])
                    {
                        isPalindrome = false;
                    }
                    next++;
                    prev--;
                }
            }
            else
            {
                middlePoint = str.Length / 2;
                int next = middlePoint;
                int prev = middlePoint - 1;

                for (int i = 1; i <= middlePoint; i++)
                {
                    if (str[prev] != str[next])
                    {
                        isPalindrome = false;
                    }
                    next++;
                    prev--;
                }
            }

            if (!isPalindrome)
            {
                Console.WriteLine($"{str} is not Palindrome");
            }
            else
            {
                Console.WriteLine($"{str} is Palindrome");
            }

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }
}
