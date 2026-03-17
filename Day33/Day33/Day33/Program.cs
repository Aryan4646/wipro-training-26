using System;

namespace Day33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by comma:");
            string input = Console.ReadLine();

            int[] numbers = ParseInput(input);

            if (numbers == null)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            // MENU
            Console.WriteLine("1. Median");
            Console.WriteLine("2. Second Largest");
            Console.WriteLine("3. Palindrome");
            Console.WriteLine("4. Rotate Left");

            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Median: " + CalculateMedian(numbers));
            }
            else if (choice == "2")
            {
                Console.WriteLine("Second Largest: " + FindSecondLargest(numbers));
            }
            else if (choice == "3")
            {
                Console.WriteLine("Is Palindrome: " + IsPalindrome(numbers));
            }
            else if (choice == "4")
            {
                RotateArrayLeft(numbers);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }

        // Convert input to array
        static int[] ParseInput(string input)
        {
            string[] parts = input.Split(',');
            int[] numbers = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out numbers[i]))
                {
                    return null;
                }
            }

            return numbers;
        }

        // MEDIAN using Array.Sort()
        static double CalculateMedian(int[] numbers)
        {
            Array.Sort(numbers);

            int n = numbers.Length;

            if (n % 2 == 1)
            {
                return numbers[n / 2];
            }
            else
            {
                return (numbers[n / 2 - 1] + numbers[n / 2]) / 2.0;
            }
        }

        // SECOND LARGEST (simple way)
        static int FindSecondLargest(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers[numbers.Length - 2];
        }

        // PALINDROME
        static bool IsPalindrome(int[] numbers)
        {
            int start = 0;
            int end = numbers.Length - 1;

            while (start < end)
            {
                if (numbers[start] != numbers[end])
                {
                    return false;
                }
                start++;
                end--;
            }

            return true;
        }

        // ROTATE LEFT
        static void RotateArrayLeft(int[] numbers)
        {
            int first = numbers[0];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }

            numbers[numbers.Length - 1] = first;

            Console.WriteLine("After rotation:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}