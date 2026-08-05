using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class Anagram
    {
        public static void Run()
        {
            Console.WriteLine("==> Check Anagram <==");
            /*
                Two strings are anagrams if they contain the same characters with the same frequencies 
            */

            string? str1 = "listen";
            string? str2 = "silent";

            if (str1.Length == str2.Length)
            {
                bool isAnagram = true;
                foreach (char item in str1)
                {
                    if (str1.Count(x => x.Equals(item)) != str2.Count(x => x.Equals(item)))
                    {
                        isAnagram = false;
                        break;
                    }
                }

                Console.WriteLine(isAnagram ? "Anagram" : "Not Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }
}
