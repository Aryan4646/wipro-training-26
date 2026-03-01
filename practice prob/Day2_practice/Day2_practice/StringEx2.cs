using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_practice
{
    internal class StringEx2
    {

        public static void Main()
        {
            string str = "Welcome to C# Programming...";
            Console.WriteLine(str);
            Console.WriteLine($"Length of string {str.Length}");
            Console.WriteLine($"The first index of 'e' is at + {str.IndexOf('e')}");
            string s1 = "Aman", s2 = "Neerav", s3 = "Aman";
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s2.Equals(s3));
            Console.WriteLine(s3.Equals(s1));
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s2.CompareTo(s3));
            Console.WriteLine(s3.CompareTo(s1));
            Console.WriteLine($"Substring {str.Substring(3, 7)}");
            Console.WriteLine("Replaced String " + str.Replace("C#", "ASP.NET"));

        }
    }
}
