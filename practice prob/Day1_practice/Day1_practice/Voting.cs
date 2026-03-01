using System;

namespace Day1_practice
{
    internal class Voting
    {
        public void Check(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are Eligible for Voting...");
            }
            else
            {
                Console.WriteLine("You Cannot Vote...");
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Voting voting = new Voting();
            voting.Check(age);
        }
    }
}
