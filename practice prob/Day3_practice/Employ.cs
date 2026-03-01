using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Employ
    {
        public int empno;
        public string name;
        public double basic;

        public override string ToString()
        {
            return $"Employ No {empno} Employ Name {name} Salary {basic}";
        }
    }
}
