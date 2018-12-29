using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine();
            Console.WriteLine("Hello world");
            Console.WriteLine("that is my first self writed program");
            Console.WriteLine("whaoo!!!");
            Console.WriteLine();

            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine();
            Console.WriteLine("Hello world");
            Console.WriteLine("that is my first self writed program");
            Console.WriteLine("whaoo!!!");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
