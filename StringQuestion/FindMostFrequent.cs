using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.StringQuestion
{
    public class FindMostFrequent
    {
        public static void Run()
        {
            Console.Write("Enter a String: ");
            string input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char item in input.ToLower())
            {
                if(frequency.ContainsKey(item))
                    frequency[item]++;
                else
                    frequency[item] = 1;
            }

            var maxPair = frequency.MaxBy(x => x.Value);

            Console.WriteLine($"Most Frequent Character: {maxPair.Key}[{maxPair.Value}]");
        }
    }
}
