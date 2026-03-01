using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_practice
{
    internal class StringEx1
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder("Welcome to C# Programming");
            Console.WriteLine($"String right now: {sb}");
            sb.Insert(5,"OKay");
            Console.WriteLine($"String right now: {sb}");
            sb.Remove(5, 4);
            Console.WriteLine($"String right now: {sb}");
            sb.Append("Akshay");
            Console.WriteLine($"String right now: {sb}");
            sb.AppendLine("Arnav");
            Console.WriteLine($"String right now: {sb}");
            sb.AppendLine("Arnav");
            Console.WriteLine($"String right now: {sb}");
        }
    }
}
