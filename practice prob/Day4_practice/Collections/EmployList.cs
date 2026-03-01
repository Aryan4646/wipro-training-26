using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColleectionsExample
{
    internal class EmployList
    {
        static void Main()
        {
            Employ employ1 = new Employ();
            employ1.Empno = 1;
            employ1.Name = "Nerav";
            employ1.Salary = 84724;

            Employ employ2 = new Employ();
            employ2.Empno = 2;
            employ2.Name = "Tushar";
            employ2.Salary = 99922;

            Employ employ3 = new Employ();
            employ3.Empno = 3;
            employ3.Name = "Kabir";
            employ3.Salary = 92211;

            ArrayList arrayList = new ArrayList();
            arrayList.Add(employ1);
            arrayList.Add(employ2);
            arrayList.Add(employ3);

            foreach(object obj in arrayList)
            {
                Employ employ = (Employ)obj;
                Console.WriteLine(employ);
            }
        }
    }
}
