using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter exersise");
            /*     double i = double.Parse(Console.ReadLine());
                 i = 2 + 5;
                 Console.WriteLine(i);
                 double x = double.Parse("2+5*9=");

                         */
            string exersise = Console.ReadLine();
            string num1;
            string num2;
            double dNum1, dNum2;

            char sign;
            int index = 0;
            double result = 0;
            char currChar = exersise[index];

            num1 = "";
            while (currChar >= '0' && currChar <= '9')
            {
                num1 += currChar;

                index++;
                currChar = exersise[index];
            }
            result = double.Parse(num1);

            while (currChar != '=')
            {
 
                sign = currChar;
                index++;
                currChar = exersise[index];

                num2 = "";
                while (currChar >= '0' && currChar <= '9')
                {
                    num2 += currChar;

                    index++;
                    currChar = exersise[index];
                }

                dNum1 = result;
                dNum2 = double.Parse(num2);

                if (sign == '*')
                {
                    result = dNum1 * dNum2;
                }
                else if (sign == '/')
                {
                    result = dNum1 / dNum2;
                }
                else if (sign == '+')
                {
                    result = dNum1 + dNum2;
                }
                else
                {
                    result = dNum1 - dNum2;
                }
                
            }

            Console.WriteLine(exersise + result);
        }
/*

            int index = 0;
            double[] num = new double[exersise.Length];
            string[] sign = new string[exersise.Length];
            string n = "";
            int b = 0;
            int i = 0;
            int r = 0;
            double result;

            for (int count = 0; count < exersise.Length; count++)
               { 
            while ( (exersise[index] >= '0' && exersise[index] <= '9') || exersise[index] ==',')
            {
                n += exersise[index].ToString();
                index++;
                    r = index;
            }
            num[i] = double.Parse(n);
            i = i++;
            while ((exersise[index] < '0' && exersise[index] > '9') || exersise[index] != ',')
            {
                n += exersise[index].ToString();
                index++;
                    r = index;
            }
            sign[b] = n;
            b++;
                }
            double[] num1 = new double[r];
            string[] sign1 = new string[r-1];
            for (int count = 0; count <= r; count++)
            {
                i = 0;
                result = (num1[i] + sign1[i]);
                i++;
                Console.Write(num[i]+sign[i]);
                i++; 
            }
            
        }
        */
    }
}
