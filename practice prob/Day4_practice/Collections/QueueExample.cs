using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColleectionsExample
{
    internal class QueueExample
    {
        static void Main()
        {
            Queue queue = new Queue();
            queue.Enqueue("Abhishek");
            queue.Enqueue("Harsh");
            queue.Enqueue("Ritwik");
            queue.Enqueue("Eshwar");
            queue.Enqueue("Akarsh");

            Console.WriteLine("Queue Data is  ");
            foreach(object ob in queue)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
