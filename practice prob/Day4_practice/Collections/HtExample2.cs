using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColleectionsExample
{
    internal class HtExample2
    {
        static void Main()
        {
            Hashtable users = new Hashtable();
            users.Add("Aman", "Lingwal");
            users.Add("Tushar", "Rajput");
            users.Add("Karthik", "Mamidanna");
            users.Add("Uday", "Pratap");
            string user, pwd;
            Console.WriteLine("Enter UserName and Password ");
            user = Console.ReadLine();
            pwd = Console.ReadLine();
            string res =(string) users[user];
            if (res == null)
            {
                Console.WriteLine("User Name Not Found...");
                return;
            } 
            if (res.Equals(pwd))
            {
                Console.WriteLine("Correct Credentials...");
            }
            else
            {
                Console.WriteLine("Invalid Credentials...");
            }
        }
    }
}
