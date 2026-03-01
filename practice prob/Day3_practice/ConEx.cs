using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ConEx
    {
        static ConEx()
        {
            Console.WriteLine("Static Constructor...");
        }

        ConEx()
        {
            Console.WriteLine("Instance Constructor...");
        }

        static void Main()
        {
            ConEx conEx = new ConEx();
        }
    }
}
