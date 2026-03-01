using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsCalculation;

namespace CalcMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter 2 Numbers  ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Calculation calculation = new Calculation();
            Console.WriteLine("Sum  " + calculation.Sum(a, b));
            Console.WriteLine("Sub  " + calculation.Sub(a, b));
            Console.WriteLine("Mult " + calculation.Mult(a, b));

        }
    }
}
