using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //שפרו את התוכנית: במקום 10 מספרים, תבקש התוכנית מהמשתמש להכניס את גודל המערך שיווצר, ואז תבצע את הפעולות שכבר ראינו. דאגו לטפל במקרה בו המשתמש מכניס מספר בלתי הגיוני או גדול מדי, כאשר הגודל המקסימלי הוא 100.
            Console.WriteLine("please insert array lenth between 1 to 100");
            int[] intar = new int[int.Parse(Console.ReadLine())];
            if ( intar.Length <= 0 || intar.Length > 100)
            {
                Console.WriteLine("wrong array lenght");
            }
            else
            {
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
}
