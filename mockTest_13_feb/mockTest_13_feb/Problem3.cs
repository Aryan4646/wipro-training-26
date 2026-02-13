using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace mockTest_13_feb
{
    internal class Problem3
    {
        static void Main()
        {
            string str;
            Console.WriteLine("Enter the string: ");
            str = Console.ReadLine();
            Console.WriteLine("\n\nThe string is: " + str);
            int k;
            Console.WriteLine("Enter number of consecutive character you want to remove: ");
            k = Convert.ToInt32(Console.ReadLine());

            string new_str = RemoveConsecutive(str, k);
        }
        public static string RemoveConsecutive(string s, int k)
        {
            string removed = "";
            int count = 1;
            
            for (int i =0; i < s.Length-k; i++)
            {
                char ch = s[i];
                for (int j = i; j < i+k; j++)
                {
                    if (ch == s[j])
                    {
                        count += 1;
                    }
                    else
                    {
                        break;
                    }

                if (count == k) {
                     continue;
                }
                else
                {
                    removed += s[i];
                }

                }

            }
 
            return removed;
        }
    }
}
