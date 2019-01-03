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
            string exersise = Console.ReadLine();

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
                /*i = 0;
                result = (num1[i] + sign1[i]);
                i++;*/
                Console.Write(num[i]+sign[i]);
                i++;
            }
            
        }
    }
}
