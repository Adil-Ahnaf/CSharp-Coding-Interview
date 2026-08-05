using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class ReverseWord
    {
        public static void Run()
        {
            Console.WriteLine("==> Reverse Word in a Sentence <==");

            string? sentence = "I Love CSharp Programing";
            var words = sentence.Split(' ');

            StringBuilder result = new StringBuilder();
            
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result.Append(words[i] + " ");
            }

            Console.WriteLine("Input: " + sentence);
            Console.WriteLine("Output: " + result.ToString());

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }
}
