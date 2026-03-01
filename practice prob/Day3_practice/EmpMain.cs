using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class EmpMain
    {
        static void Main()
        {
            Emp emp1 = new Emp();
            Console.WriteLine(emp1);

            Emp emp2 = new Emp(12, "Vinay", 88323);
            Console.WriteLine(emp2);
        }
    }
}
