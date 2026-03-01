using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_practice
{
    internal class Array1
    {
        public void show()
        {
            int[] a = new int[6];
            int n;
            Console.WriteLine("Enter Size of array: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} elements in array: ", n);
            for(int i  =0; i<n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements of Array Are  ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }

        }

        public static void Main()
        {
            Array1 arr = new Array1();
            arr.show();
        }
    }
}
