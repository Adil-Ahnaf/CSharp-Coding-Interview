using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.MostFrequentlyAsked
{
    public class CharacterFrequencies
    {
        public static void Run()
        {
            Console.WriteLine("==> Find Character Frequencies <==");

            Console.Write("Enter a String: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please enter a valid string");
                return;
            }

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char item in input.ToLower())
            {
                if (item == ' ')
                    continue;
                if (!frequency.ContainsKey(item))
                    frequency[item] = 1;
                else
                    frequency[item]++;
            }

            Console.WriteLine("Character Frequencies:");

            foreach (var item in frequency)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.WriteLine("\nProgram Finished!");
            Console.ReadKey();
        }
    }
}
