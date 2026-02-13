using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mockTest_13_feb
{
    internal class Problem2
    {
        static void Main()
        {
            string str;
            Console.WriteLine("Enter the string: ");
            str = Console.ReadLine();
            string real_Str = str;
            Console.WriteLine("\n\nThe string is: " + str);
            str = str.ToLower();
           

            bool isPalindrome = Palindrome(str);

            if (isPalindrome)
            {
                Console.WriteLine($"String {real_Str} is palindrome.");
            }
            else
            {
                Console.WriteLine($"String {real_Str} is not palindrome.");
            }

        }
        public static bool Palindrome(string s)
        { 
            string result = "";

            foreach (char c in s)
            {
                if (char.IsLetter(c) || char.IsDigit(c))
                {
                    result += c;
                }
            }

            string checkstr = "";
            for (int i = result.Length-1; i >= 0; i--)
            {
                checkstr += result[i];
            }

            if (checkstr == result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
