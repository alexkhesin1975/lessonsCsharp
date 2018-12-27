using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("that is my forth self writed program");
            Console.WriteLine("Wahoo!!");
            Console.WriteLine();

            double num1, num2, num3;

            Console.WriteLine("please insert 3 numbers");
            Console.WriteLine();
            Console.WriteLine("please insert first number");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("please insert second number");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("please insert third number");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("now we do sum count");
            Console.WriteLine(num1 + num2 + num3);
            Console.WriteLine();
            Console.WriteLine("now we do multiplication count");
            Console.WriteLine(num1 * num2 * num3);
            Console.WriteLine();
            Console.WriteLine("now we do average count");
            Console.WriteLine((num1 + num2 + num3) / 3.0);
            Console.WriteLine();
            Console.WriteLine("now we do exponentiation count");
            Console.WriteLine(num1 * num1 + "|" + num2 * num2 + "|" + num3 * num3);
        }
    }
}
