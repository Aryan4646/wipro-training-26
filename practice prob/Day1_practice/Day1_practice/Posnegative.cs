using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_practice
{
    internal class Posnegative
    {
        public  void Check(int n)
        {
            if (n >= 0)
            {
                Console.WriteLine("Positive Number...");
            }
            else
            {
                Console.WriteLine("Negative Number...");
            }
        }

        public static void Main()
        {
            int n;
            Console.WriteLine("Enter N value   ");
            n = Convert.ToInt32(Console.ReadLine());
            Posnegative posn = new Posnegative();
            posn.Check(n);
        }
    }
}
