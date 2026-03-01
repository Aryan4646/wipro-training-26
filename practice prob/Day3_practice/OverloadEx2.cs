using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class OverloadEx2
    {
        public int Sum()
        {
            return 10;
        }

        public int Sum(int x)
        {
            return x + 10;
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main()
        {
            OverloadEx2 overloadEx2 = new OverloadEx2();
            Console.WriteLine("Sum w.r.t. Zero Args " +overloadEx2.Sum());
            Console.WriteLine("Sum w.r.t. One Arg   " +overloadEx2.Sum(82));
            Console.WriteLine("Sum w.r.t. Two Args  " +overloadEx2.Sum(81,62));
        }
    }
}
