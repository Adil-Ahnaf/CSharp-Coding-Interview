using CSharp_Coding_Interview.MostFrequentlyAsked;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.String
{
    public class FindDuplicate
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string duplicate = GetDuplicate(input);
            Console.WriteLine($"Duplicates are: { duplicate }");
        }

        public static string GetDuplicate(string input)
        {
            var duplicate = new List<char>();            
            foreach (char letter in input)
            {
                if (input.Count(x => x.Equals(letter)) > 1 && !duplicate.Contains(letter))
                    duplicate.Add(letter);
            }
            return string.Join(", ", duplicate);
        }
    }
}
