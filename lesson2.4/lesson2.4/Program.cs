using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //כתבו תוכנית שבונה מערך כזה (בעזרת קטע הקוד המצורף), ואז מאפשרת למשתמש לבדוק אם מספר מסויים מופיע בו. התוכנית תחפש כל מספר שהמשתמש יבקש, עד שהוא יקיש מספר שלא נמצא בטווח - מספר קטן מ-1 או מספר גדול מ-100. אם מספר מופיע - יודפס מספר התא בו הוא מופיע לראשונה, ואם לא - תודפס הודעה מתאימה.
            Random r = new Random();
            Console.WriteLine("please insert array length between 1 to 100");
            int[] array = new int[int.Parse(Console.ReadLine())];
            if (array.Length <= 0 || array.Length > 100)
            {
                Console.WriteLine("please insert correct array lenght");
            }
            else
            {
                for (int i = 0; i < array.Length -1; i++)
                {
                    array[i] = r.Next(1,101);
                    Console.WriteLine(array[i]);
                }
                Console.WriteLine("please insert number for check");
                int test = int.Parse(Console.ReadLine());
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
