using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class StEx1
    {
        static int count;
        public void Increment()
        {
            count++;
            Console.WriteLine($"Count {count}");
        }
        static void Main()
        {
            StEx1 obj1 = new StEx1();
            StEx1 obj2 = new StEx1();
            StEx1 obj3 = new StEx1();

            obj1.Increment();
            obj2.Increment();
            obj3.Increment();
        }
    }
}
