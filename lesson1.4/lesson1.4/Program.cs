using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("that is my fifth self writed program");
            Console.WriteLine("Wahoo!!");
            Console.WriteLine();
            Console.WriteLine("please describe a count of numbers you'll be using");

             int count;
             count = 0;
             count = int.Parse(Console.ReadLine());
             if (count == 0)
             {
                 Console.WriteLine("wrong count . count can't be  = 0");
             }
             else if (count < 0)
             {
                 Console.WriteLine("wrong count . count can't be <  0");
             }

             else if (count > 0 )
             {
                 while (count > 0)
                 {
                     string num;
                     
                     
                     num = "num";
                     
                     Console.WriteLine((double)count + 0.1);
                     Console.WriteLine(num + count);
                                        
                     count = (--count);

                     
                 
                 }
             } 
            string value1 = "Dot";
            string value2 = "Net";
            string value3 = "Perls";

            
            Console.WriteLine("{0}, {1}, {2}",
                value1,
                value3,
                value2);

            char[] array = new char[] { 'a', 'b', 'c', 'd' };
            Console.WriteLine(array);
            Console.WriteLine(array, 1, 2);

                       


        }
    }
}
