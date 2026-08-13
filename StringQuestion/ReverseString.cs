using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.StringQuestion
{
    public class ReverseString
    {
        public static void Run()
        {
            Console.Write("Enter a string to reverse: ");
            string input = Console.ReadLine();
            string reversed = Reverse(input);
            Console.WriteLine($"Reversed string: {reversed}");
        }

        private static string Reverse(string input)
        {
            char[] charArray = input.ToCharArray(); 
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
