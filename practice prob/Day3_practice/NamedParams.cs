using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class NamedParams
    {
        public void Show(string firstName, string lastName,string city, string state)
        {
            Console.WriteLine($"First Name {firstName} Last Name {lastName} " +
                $" City  {city}  State {state}");
        }
        static void Main()
        {
            NamedParams namedParams = new NamedParams();
            namedParams.Show("Delhi", "UP", "Abhishek", "Palli");
            namedParams.Show(city: "Delhi", state: "UP", firstName: "Abhishek", lastName: "Palli");
        }
    }
}
