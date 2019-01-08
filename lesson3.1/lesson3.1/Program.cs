using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3._1
{
    class Program
    {
        static string[,] alex(string str, out int newSize)
        {
            bool isLastIsDigit = false; //checks if las sighn was not number
            string[,] arrst = new string[2, str.Length];
            int n = 0;
            for (int y = 0; y < str.Length; y++)
            {
                if (str[y] >= '0' && str[y] <= '9')
                {
                    arrst[0, n] += str[y];
                    arrst[1, n] = "1";
                    isLastIsDigit = true;
                }
                else
                {     
                    if (isLastIsDigit)
                    {
                        n++;                        
                    }
             
                    arrst[0, n] += str[y];
                    arrst[1, n] = "0";
                    n++;
                    isLastIsDigit = false;
                }
            }

            newSize = n;
            
            return arrst;
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter exercise");
            string s = Console.ReadLine();
            string[,] a;
            int size;
            a = alex(s, out size); // recieve ARRST array from alex functon

            int j;
            for (int i = 0; i < a.GetLength(0); i++) //for 2D array
            {
                for (j = 0; j <= size; j++)
                {
                    Console.Write(a[i, j] + ", ");
                }
                Console.WriteLine();
            }
            /*
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a0," + i + " = " + a[0, i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i <= n; i++)
            {
                Console.Write("a1," + n + " = " + a[1,i] + " ");
            }
            Console.WriteLine();
            */
        }
        
    }
}
