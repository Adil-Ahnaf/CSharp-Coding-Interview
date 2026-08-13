using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Interview.String
{
    public class StringRotationCheck
    {
        public static void Run()
        {
            /*
                Determine whether one string is a rotation of the other. The trick is:
                    1. The two strings must have the same length.
                    2. Concatenate the first string with itself.
                    3. If the second string exists inside the concatenated string, it is a rotation.
            */

            string str1 = "abcd";
            string str2 = "acdb"; // for rotation: cdab, not rotation: acbd

            bool result = IsStringRotation(str1, str2);

            Console.WriteLine($"String1: {str1}\tString2: {str2}");
            Console.WriteLine(result ? "Rotation" : "Not Rotation");
        }

        public static bool IsStringRotation(string input1, string input2)
        {
            if (input1.Length == input2.Length)
            {
                string mystring = string.Concat(input1, input1);
                if (mystring.Contains(input2))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
