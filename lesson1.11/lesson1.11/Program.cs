using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2, input3;

            Console.WriteLine();
            Console.WriteLine("that is my second self writed program");
            Console.WriteLine("whaoo!!!");
            Console.WriteLine("please choose color");
            Console.WriteLine("please choose Foreground color");
            string foregroundString = "Wite";
            foregroundString = Console.ReadLine();
            Type foreground = Type.GetType(foregroundString);
            Console.WriteLine("please choose background color");
            string backgroundString = "Black";
            backgroundString = Console.ReadLine();
            Type background = Type.GetType(backgroundString);
            Console.ForegroundColor = ConsoleColor(foreground);
            Console.BackgroundColor = ConsoleColor.background;

            Console.WriteLine("please insert some text");
            input1 = Console.ReadLine();
            Console.WriteLine("and another one please");
            input2 = Console.ReadLine();
            Console.WriteLine("and last one");
            input3 = Console.ReadLine();
            Console.WriteLine(input1);
            Console.WriteLine(input2);
            Console.WriteLine(input3);
            Console.WriteLine(input1 + "|" + input2);
            Console.WriteLine(input2 + "|" + input3);
            Console.WriteLine(input1 + "|" + input3);
            Console.WriteLine(input1 + "|" + input2 + "|" + input3);

            
        }
}
}
