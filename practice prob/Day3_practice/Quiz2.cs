using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Quiz2
    {
        public void Show(long x)
        {
            Console.WriteLine("Show w.r.t. Long  " +x);
        }
        public void Show(double x)
        {
            Console.WriteLine("Show w.r.t. Double  " + x);
        }

        public void Show(object x)
        {
            Console.WriteLine("Show w.r.t. Object  " + x);
        }
        static void Main()
        {
            Quiz2 quiz2 = new Quiz2();
            quiz2.Show(12);
        }
    }
}
