using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColleectionsExample
{
    internal class ArrayListEx1
    {
        static void Main()
        {
            ArrayList array = new ArrayList();
            array.Add("Abhishek");
            array.Add("Pranav");
            array.Add("Yash");
            array.Add("Ganesh");
            array.Add("Aryan");
            array.Add("Kishore");
            Console.WriteLine("ArrayList Elements are ");
            foreach(object obj in array)
            {
                Console.WriteLine(obj);
            }
            array.Insert(3, "Vinay");
            Console.WriteLine("ArrayList after Insertion  ");
            foreach (object obj in array)
            {
                Console.WriteLine(obj);
            }
            array.RemoveAt(3);
            Console.WriteLine("Removing Element at 3rd Position  ");
            foreach (object obj in array)
            {
                Console.WriteLine(obj);
            }
            array.Remove("Yash");
            Console.WriteLine("Removing Element by Object Name  ");
            foreach (object obj in array)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
