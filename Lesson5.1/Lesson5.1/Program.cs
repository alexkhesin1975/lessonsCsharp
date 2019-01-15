using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;

namespace Lesson5._1
{
    class Program
    {
        static void calc(char num)
            {
            string[] vs = File.ReadAllLines("D:\\Users\\sasha\\Documents\\GitHub\\home\\lessonsCsharp\\Lesson5.1\\Lesson5.1\\CalcView.txt");
            char x = num;
            foreach (string curLine in vs)
            {
                if (curLine.Contains(x))
                {
                    foreach (char num2 in curLine)
                    {

                        if (num2 == x)
                        {
                            Console.ForegroundColor = System.ConsoleColor.Red;
                            Console.Write(num2);
                        }
                        else
                        {
                            Console.ForegroundColor = System.ConsoleColor.White;
                            Console.Write(num2);
                        }

                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(curLine);
                }
            }
            
        }
        static void Main(string[] args)
        {
            char i;
            i = char.Parse(Console.ReadLine());
            
                calc(i);
            
            
            
        }
    }
}
