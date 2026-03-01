using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColleectionsExample
{
    internal class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Employ No {Empno} Employ Name {Name} Salary {Salary}";
        }
    }
}
