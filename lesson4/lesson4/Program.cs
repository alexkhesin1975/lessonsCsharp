using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static int f1( int s,int[] arr)
        {

            s = 20;

            arr[0] = f4(10);
            arr[1] = f4(4);
            arr[2] = f4(3);
            return 4;
            
        }

        static int f4( int x)
        {
            x = x * x;
            return x;
        }
        static void Main(string[] args)
        {
            int m = 5;
            int[] a = new int[3];
            
            int y = f1( m, a);
          
            Console.WriteLine(y);
            Console.WriteLine(m);
            Console.WriteLine("{0}, {1}, {2}", a[0],a[1],a[2]);
        }
    }
}


