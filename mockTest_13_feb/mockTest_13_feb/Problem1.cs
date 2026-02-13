using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mockTest_13_feb
{   internal class Problem1
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter the string: ");
            str = Console.ReadLine();
            Console.WriteLine("\n\nThe string is: "+ str);

            str = str.ToLower();

            char x = NonRepeating(str);

            if (x == '$')
            {
                Console.WriteLine("All the characters in the given string are repeating.");
            }
        else
            {
                Console.WriteLine($"\'{x}\' is the first character in the string which does not repeat.");
            }
        }
        public static char NonRepeating(string sh)
        {
            for (int i = 0; i < sh.Length; i++)
            {
                bool charrepeat = false;
                for (int j = 0; j < sh.Length; j++)
                {
                    if (sh[i] == sh[j])
                    {
                        charrepeat = true;
                        break;
                    }
                }
                if (charrepeat == false)
                {
                    return sh[i];
                }
            }
            return '$';
        }
    }
}
