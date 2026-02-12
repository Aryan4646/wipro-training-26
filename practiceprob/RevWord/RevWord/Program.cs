using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string str = "Welcome to C# programming from wipro training";
                string[] each_word = str.Split(' ');
                string new_str = "";

                for (int i = 0; i < each_word.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        new_str = new_str + each_word[i] + " ";
                    }
                    else
                    {
                        string new_ch = "";
                        string word = each_word[i];
                        for (int j = (word.Length) - 1; j >= 0; j--)
                        {
                            new_ch = new_ch + word[j];
                        }
                        new_str = new_str + new_ch + " ";
                    }
                }
                Console.WriteLine(new_str);
            }
        }
    }
}
