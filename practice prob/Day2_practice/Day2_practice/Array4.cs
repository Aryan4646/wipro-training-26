using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_practice
{
    internal class Array4
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
            Console.WriteLine("Enter the Element to Insert  ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Position to Insert  ");
            int p = Convert.ToInt32(Console.ReadLine());
            n++;

            for(int i=n-1; i > p ; i--)
            {
                a[i] = a[i - 1];
            }
            a[p] = x;
            Console.WriteLine("List after Insertion  ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

    public static void Main()
        {
            Array4 ar = new Array4();
            ar.Show();
        }
    }
}
