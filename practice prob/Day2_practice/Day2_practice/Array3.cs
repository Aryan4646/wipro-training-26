using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_practice
{
    internal class Array3
    {
        public void Show()
        {
            int[] a = new int[10];
            int n;
            Console.WriteLine("Enter Size of Array  ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} Elements into Array  ", n);
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int x;
            Console.WriteLine("Enter the Element to Delete  ");
            x = Convert.ToInt32(Console.ReadLine());
            bool flag = false;

            for(int i =0; i<n; i++)
            {
                if (a[i] == x)
                {
                    flag = true;
                    for (int j = i; j<n; j++)
                    {
                        a[j] = a[j + 1];
                    }
                    n--;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("List after Delete Operation  ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }
            else
            {
                Console.WriteLine("Element to be deleted dont exist.");
            }
        }

        public static void Main()
        {
            Array3 ar = new Array3();
            ar.Show();
        }
    }
}
