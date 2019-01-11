using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    class Program
    {
        static void calc(char num)
        {
            string curLine = "16846e5casaxyunweofg86899321";
            char x = num;
                foreach (char num2 in curLine)
                {
                    if (num2 == x)
                    {
                        Console.ForegroundColor = System.ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = System.ConsoleColor.White;
                    }
                Console.Write(num2);
            }
            Console.WriteLine();



        }
        static void Main(string[] args)
        {
            char i;
            i = char.Parse(Console.ReadLine());

            calc(i);
        }
    }
}
