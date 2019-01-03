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

            Console.WriteLine("please write foreground colour");
            string foregroundtemp = Console.ReadLine();
            ConsoleColor foreground = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), foregroundtemp, true);
            Console.WriteLine("please write background colour");
            string backgroundtemp = Console.ReadLine();

            ConsoleColor background = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), backgroundtemp, true);

            Console.BackgroundColor = background;
            Console.ForegroundColor = foreground;


            Console.WriteLine();
            Console.WriteLine("Hello world");
            Console.WriteLine("that is my first self writed program");
            Console.WriteLine("whaoo!!!");
            Console.WriteLine();
            Console.ResetColor();

            char x = 'a';
            Console.WriteLine((int)'a');
            Console.WriteLine((int)x);
            Console.WriteLine(x);
        }
    }
}
