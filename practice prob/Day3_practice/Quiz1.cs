using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Quiz1
    {
        public void Show(double x)
        {
            Console.WriteLine("Show w.r.t. Double  " +x);
        }

        public void Show(object x)
        {
            Console.WriteLine("Show w.r.t. Object  " +x);
        }
        static void Main()
        {
            Quiz1 quiz1 = new Quiz1();
            quiz1.Show(12);
        }
    }
}
