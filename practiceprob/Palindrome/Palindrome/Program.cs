using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Welcome to liril what is the case madam";
            string[] each_word = str.Split(' ');
            string new_str = "";
            int count = 0;
            foreach (string i in each_word)
            {
                string new_ch = "";
                for (int j = (i.Length) - 1; j >= 0; j--)
                {
                    new_ch = new_ch + i[j];
                }
                if (new_ch == i)
                {
                    count += 1;
                }
            }
            Console.WriteLine("String is: " + str);
            Console.WriteLine("Number of palindrome: " + count);
        }
    }
}
