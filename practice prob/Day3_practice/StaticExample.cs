using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    static class Demo
    {
        public static void Show()
        {
            Console.WriteLine("Wipro Training...");
        }

        public static void Trainer()
        {
            Console.WriteLine("Trainer is Prasanna P...");
        }
    }
    internal class StaticExample
    {
        static void Main()
        {
           Demo.Show();
           Demo.Trainer();
        }
    }
}
