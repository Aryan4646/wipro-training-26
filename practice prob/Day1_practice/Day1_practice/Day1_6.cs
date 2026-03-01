using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day1_practice
{
    internal class Day1_6
    {
        static void Main()
        {
            int x = 10;
            int y = x++ + ++x;

            Console.WriteLine(y);

            int a = 10;
            int b = a++ + a++ + ++a + a++ + ++a; // 10 + 11 + 13 + 13 +15

            int z = 10;
            int s = z++ + --z + ++z + ++z + z-- + --z; // 10 + 10 + 11+ 12 + 12 + 10

            Console.WriteLine(s);
            Console.WriteLine(b);
        }
    }
}
