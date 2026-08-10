using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.String
{
    public class ReverseWord
    {
        public static void Run()
        {
            Console.Write("Enter a string to reverse the words: ");
            string input = Console.ReadLine();
            string reversedWords = ReverseWords(input);
            Console.WriteLine($"Reversed words: {reversedWords}");
        }
        private static string ReverseWords(string input)
        {
            string[] words = input.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
