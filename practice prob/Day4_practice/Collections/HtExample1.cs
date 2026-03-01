using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColleectionsExample
{
    internal class HtExample1
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Kabir");
            ht.Add(2, "Tushar");
            ht.Add(3, "Aman");
            ht.Add(4, "Uday");
            ht.Add(5, "Kishore");

            int key;
            Console.WriteLine("Enter Key  ");
            key = Convert.ToInt32(Console.ReadLine());
            string res = (string)ht[key];
            //Console.WriteLine(res.Length);
            if (res == null)
            {
                Console.WriteLine("Key Not Found");
            }
            else
            {
                Console.WriteLine(res);
            }
        }
    }
}
