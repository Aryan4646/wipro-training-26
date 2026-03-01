using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class OverloadEx1
    {
        public void Show(int x)
        {
            Console.WriteLine("Show Method w.r.t. Integer  " +x);
        }

        public void Show(double x)
        {
            Console.WriteLine("Show Method w.r.t. Double  " +x);
        }

        public void Show(string x)
        {
            Console.WriteLine("Show Method w.r.t. String  " +x);
        }
        static void Main()
        {
            OverloadEx1 overloadEx1 = new OverloadEx1();
            overloadEx1.Show(12);
            overloadEx1.Show(12.5);
            overloadEx1.Show("Wipro");
        }
    }
}
