using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4._1
{
    class Program
    {
        static string[,] strToArray(string str, out int newSize)
        {
            bool isLastIsDigit = false; //checks if las sighn was not number
            string[,] arrst = new string[2, str.Length];
            int n = 0;
            for (int y = 0; y < str.Length; y++)
            {
                if (str[y] >= '0' && str[y] <= '9' || str[y] == ',')
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

        static double strToNum(string num)
        {
            double x = double.Parse(num);
            return x;
        }

        static double addition(string num1, string num2)
        {
            double result = strToNum(num1) + strToNum(num2);
            return result;
        }

        static double subtraction(string num1, string num2)
        {
            double result = strToNum(num1) - strToNum(num2);
            return result;
        }


        static double multiplication(string num1, string num2)
        {
            double result = strToNum(num1) * strToNum(num2);
            return result;
        }

        static double division(string num1, string num2)
        {
            double result = strToNum(num1) * strToNum(num2);
            return result;
        }
        
        static void changeNine(string[,] mat, int i)
        {
            mat[1, i] = "9";
            mat[1, i - 1] = "9";
            mat[1, i + 1] = "9";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter exercise");
            string s = Console.ReadLine();
            string[,] a;
            int size;
            double result = 0;
            a = strToArray(s, out size);
            int i;
            string x;
            
            for (i = 0; i < size; i++) 
            {
                x = result.ToString();
                if (a[0 , i] == "+" && a[1 , i] == "0")
                {
                    if (i > 0 && a[1, i - 1] == "9")
                    {
                        result = addition(x, a[0, i + 1]);
                    }
                    else 
                    {
                        result = addition(a[0, i - 1], a[0, i + 1]);
                        changeNine(a, i);
                        //a[1, i] = "9";
                        //a[1, i - 1] = "9";
                        //a[1, i + 1] = "9";
                    }
                }
                else if (a[0, i] == "-" && a[1, i] == "0")
                {
                    if (i > 0 && a[1, i - 1] == "9")
                    {
                        result = subtraction(x, a[0, i + 1]);
                    }
                    else
                    {
                        result = subtraction(a[0, i - 1], a[0, i + 1]);
                        a[1, i] = "9";
                        a[1, i - 1] = "9";
                        a[1, i + 1] = "9";
                    }
                }
                else if (a[0, i] == "*" && a[1, i] == "0")
                {
                    if (i > 0 && a[1, i - 1] == "9")
                    {
                        result = multiplication(x, a[0, i + 1]);
                    }
                    else
                    {
                        result = multiplication(a[0, i - 1], a[0, i + 1]);
                        a[1, i] = "9";
                        a[1, i - 1] = "9";
                        a[1, i + 1] = "9";
                    }
                }
                else if (a[0, i] == "/" && a[1, i] == "0")
                {
                    if (i > 0 && a[1, i - 1] == "9")
                    {
                        result = division(x, a[0, i + 1]);
                    }
                    else
                    {
                        result = division(a[0, i - 1], a[0, i + 1]);
                        a[1, i] = "9";
                        a[1, i - 1] = "9";
                        a[1, i + 1] = "9";
                    }
                }
            }
            Console.WriteLine("result is = " + result);
            Main(null);
        }
    }
}
