using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static Random r = new Random();

        // 1. no return, no parameters
        static void f1()
        {
            Console.WriteLine();
            Console.WriteLine("Hello to f1");
            Console.WriteLine("Hello again to f1");
            Console.WriteLine("Hello again again to f1");
        }

        // 2. return value, no params
        static int addRandomNumber()
        {          
            int n1 = r.Next(100);
            int n2 = r.Next(100);
            if (n1 + n2 > 100)
            {
                return n1 + n2;
            }
            else
            {
                return n1 - n2;
            }            
        }

        // 3. no return , yes params
        static void f3(int p1, string s)
        {
            Console.WriteLine("The number is: " + p1);
            Console.WriteLine("The string is: " + s);
        }


        static void printAddNumber(int num1, int num2)
        {
            Console.WriteLine("result is : " + (num1+num2));
        }

        // 4. return value, yes params
        static int add(int n1, int n2)
        {
            return n1 + n2;
        }

        static int add(int n1, int n2, int n3)
        {
            return add(add(n1,n2),n3);
        }

        static double getNumberFromString(string s)
        {
            double d= double.Parse(s); 
            return d;
        }

        static void Main(string[] args)
        {
            //string[,] array; //2D array
            //string[,,] array2; //3D array
            Console.WriteLine("Before");
            f1();
            Console.WriteLine("After");

            f1();

            printAddNumber(4, 5);

          /*  Console.WriteLine("Please enter 2 numbers:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            
            printAddNumber(n1, n2);
            */
            int z = addRandomNumber();
            Console.WriteLine("z = " + z);
            z = addRandomNumber();
            Console.WriteLine("z = " + z);


            Console.WriteLine("4+6 = " + add(4,6));
            Console.WriteLine("1+3 = " + add(1, 3));
            Console.WriteLine("1+3+6 = " + add(1, 3, 6));
        }
    }
}
