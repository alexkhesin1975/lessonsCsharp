using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //sorting array from smallest number to biggest
            Random r = new Random();
            Console.WriteLine("please insert array length between 1 to 100");
            int[] array = new int[int.Parse(Console.ReadLine())];
            if (array.Length <= 0 || array.Length > 100)
            {
                Console.WriteLine("please insert correct array lenght");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = r.Next(1, 101);
                    if ((i > 0) && (array[i] < array[i - 1]))
                    {
                        int x = i;
                        //somthing wrong here. if i use x>1 then first not sorted if use x>0 it fails
                        while ((array[x] < array[x - 1]) && (x > 1)) 
                        {
                            int temp = array[x];
                            array[x] = array[x - 1];
                            array[x - 1] = temp;
                            x--;
                        }
                    }
                    
                }
                //prints sorted array
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("location in array " + i + ": " + array[i]);
                }
                //looking for entered number in the array
                int test = 0;
                Console.WriteLine("please insert number for check");
                test = int.Parse(Console.ReadLine());
                bool yes = false;
                for (int i = 0; i <= array.Length - 1; i++)
                {
                    if (test == array[i])
                    {
                        yes = true;
                    }
                }
                if (yes == true)
                {
                    Console.WriteLine(test + "  number exists");
                }
                else
                {
                    Console.WriteLine(test + "  numer not exists");

                }
            }
        }
    }
}
