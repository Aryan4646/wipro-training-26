using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class EmployMain
    {
        static void Main()
        {
            Employ emp1 = new Employ();
            emp1.empno = 1;
            emp1.name = "Pranav";
            emp1.basic = 88323;

            Console.WriteLine(emp1);
        }
    }
}
