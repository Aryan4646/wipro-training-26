using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_practice
{
    internal class Day1_5
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the number a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number b: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.WriteLine($"The sum of {a} and {b}: {c}");
            c = a - b;
            Console.WriteLine($"The diff of {a} and {b}: {c}");
            c = a * b;
            Console.WriteLine($"The mult of {a} and {b}: {c}");

        }
    }
}
