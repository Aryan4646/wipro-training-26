using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
   
    internal class ParamsExample
    {
        public void Attendance(int dayNo, params string[] students)
        {
            Console.Write("Day  " + dayNo + "   ");
            foreach(string student in students)
            {
                Console.Write(student + "    ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            ParamsExample example = new ParamsExample();
            example.Attendance(1, "Ganesh", "Kabir", "Yash");
            example.Attendance(2, "Ganesh", "Yash", "Harsh", "Kishore");
            example.Attendance(3, "Tushar", "Uday", "Yash", "Eshwar", "Rithwik", "Vinay");
        }
    }
}
