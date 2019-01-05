using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //כתבו תוכנית שתיצור מערך מסוג int ובו 10 איברים, ותכניס לתאיו את הערכים 1 עד 10, בהתאמה. לאחר מכן תדפיס התוכנית את תוכן המערך.
            int[] intar = new int[10];
            for (int i = 0; i <= intar.Length - 1; i++)
            {
                intar[i] = i;
            }
            for (int i = 0; i <= intar.Length - 1; i++)
            {
                Console.WriteLine(intar[i]);
            }
        }
    }
}
