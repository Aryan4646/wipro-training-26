using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class EmployArray
    {
        static void Main()
        {
            Employ emp1 = new Employ();
            emp1.empno = 1;
            emp1.name = "Pranav";
            emp1.basic = 88323;

            Employ emp2 = new Employ();
            emp2.empno = 2;
            emp2.name = "Neerav";
            emp2.basic = 90023;

            Employ emp3 = new Employ();
            emp3.empno = 3;
            emp3.name = "Tushar";
            emp3.basic = 90011;

            Employ[] employArray = new Employ[] { emp1, emp2, emp3 };
            foreach(Employ emp in employArray)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
