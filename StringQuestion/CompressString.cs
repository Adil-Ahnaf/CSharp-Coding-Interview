using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.StringQuestion
{
    public class CompressString
    {
        public static void Run()
        {
            string str = "aaabbcddd";
            StringBuilder sb = new StringBuilder();

            int count = 1;
            int index = 0;
            foreach (char item in str)
            {
                index++;

                if (index < str.Length && str[index] == item)
                    count++;
                else
                {
                    sb.Append(item);
                    sb.Append(count);
                    count = 1;
                }    
            }

            Console.WriteLine($"Input String: {str}");
            Console.WriteLine($"Result is: {sb}");
        }
    }
}
