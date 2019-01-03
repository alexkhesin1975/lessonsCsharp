using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int x;
            x = 5;
            x = 2 + 3;
            x = 1 + 4 * 32;

            bool b;
            b = true;
            b = true || true;
            b = true && false;
            b = !(false || true) && !false;
            b = true;
            int a = 10;

            a = a * 10;
            a *= 10;
            a /= 10; // a = a / 10
            a += 2 * 4; // a = a + (2 * 4)
            a -= 10 * 2; // a = a - (10 * 2)

            a++; // a += 1    a = a + 1
            ++a;

            int x = a++;
            x = a;
            a++;

            int y = ++a;
            a++;
            y = a;

            int c = 32;
            if (a == 5 && c / 2 == 10 || a != 9 && !(a == c) )
            {

            }

            for (a = 0; a < 5; a++)
            {

            }

            a = 0;
            while (a < 5)
            {


                a++;
            }

            string[] arr = new string[5];
            arr[0]="55fr52";
            */
            /* string s = "56,655*44+2=";

             int index = 0;
             double num1;
             int num2;
             int result=0;
             string n = "";

             while ( (s[index] >= '0' && s[index] <= '9') || s[index] ==',')
             {
                 n += s[index].ToString();
                 index++;
             }
             num1 = double.Parse(n);
             Console.WriteLine(num1); */

            //string n = s[0].ToString() +s[1].ToString();            
            //int z = int.Parse(n);

            // int[] arrGrades = new int[10];
            /*arrGrades[0] = int.Parse(Console.ReadLine());
            arrGrades[1] = int.Parse(Console.ReadLine());
            arrGrades[2] = int.Parse(Console.ReadLine());
            arrGrades[3] = int.Parse(Console.ReadLine());
            */
            int i = 0;
            /* while ( i < 100 )
             {
                 arrGrades[i] = int.Parse(Console.ReadLine());
                 i++;
             }
             */
            /*   Console.WriteLine("please enter array lengh:");

               int arrLen = int.Parse(Console.ReadLine());
               int[] arrGrades = new int[arrLen];

               Console.WriteLine("Enter numbers:");
               for (i = 0; i < arrGrades.Length; i++)
               {
                   arrGrades[i] = int.Parse(Console.ReadLine());
               }
               Console.WriteLine();
               Console.WriteLine("The numbers are:");
               for (i = 0; i < arrGrades.Length; i++)
               {
                   Console.WriteLine(arrGrades[i]);
               }
               */
            Random r = new Random();
            bool yes = false; 
            int[] arr2 = new int[10];
            for (i =0; i < arr2.Length; i++)
            {
                arr2[i] = r.Next(1, 101);
            }
         
            Console.WriteLine("The numbers are:");
            for (i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            Console.WriteLine("please choose umber :");
            int num = int.Parse(Console.ReadLine());
            for (i = 0; i < arr2.Length; i++)
            {
              
                if (arr2[i] == num )
                {
                    yes = true;
                }
            }

            if ( yes == true )
            {
                Console.WriteLine("number exists");
            }
            else
            {
                Console.WriteLine("number not exists");
            }
        }
    }
}
