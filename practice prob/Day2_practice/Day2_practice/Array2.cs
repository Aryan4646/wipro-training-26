using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_practice
{
    internal class Array2
    {
        public void show()
        {
            int[] a = new int[10];
            Console.WriteLine("Enter size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter {n} elements into the array: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1} element of array is: ");
                Console.WriteLine(a[i]);
            }

            int x;
            Console.WriteLine("Enter element to search: ");
            x = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for(int i= 0; i < n; i++)
            {
               if (a[i] == x)
                {
                    Console.WriteLine($"Element found at {i} positon");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Element Not Found...!");
            }
        } 
          public static void Main()
              {
            Array2 arr = new Array2();
            arr.show();
            }
   
    }
}
