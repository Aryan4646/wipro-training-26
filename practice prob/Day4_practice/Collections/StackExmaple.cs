using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColleectionsExample
{
    internal class StackExmaple
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push("Abhishek");
            stack.Push("Harsh");
            stack.Push("Ritwik");
            stack.Push("Eshwar");
            stack.Push("Akarsh");

            Console.WriteLine("Stack Data  ");
            foreach(object ob in stack)
            {
                Console.WriteLine(ob);
            }
            stack.Pop();
            stack.Pop();
            Console.WriteLine("Stack Data After Pop Operation  ");
            foreach (object ob in stack)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
