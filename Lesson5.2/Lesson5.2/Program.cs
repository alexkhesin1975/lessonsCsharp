using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Lesson5._2
{
    class Program
    {
        static void P(string args)
        {
           string workdir = @"D:\Users\sasha\Documents\GitHub\home\lessonsCsharp\Lesson5.2\Lesson5.2\";
            //string file = @"cmd.exe" + "ping.exe";
            Process p = new Process();
            p.StartInfo.FileName = @"ping.exe";
            p.StartInfo.Arguments = args;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();
            StreamReader reader;
            reader = p.StandardOutput;
            string result = reader.ReadToEnd();
            Console.WriteLine(result);
            System.IO.File.WriteAllText(@"D:\Users\sasha\Documents\GitHub\home\lessonsCsharp\Lesson5.2\Lesson5.2\ping.txt", result);
            p.WaitForExit();
        }
        static void parseFile()
        {
            string[] pf = File.ReadAllLines(@"D:\Users\sasha\Documents\GitHub\home\lessonsCsharp\Lesson5.2\Lesson5.2\ping.txt");

            foreach (string a in pf)
            {
                string[] words = a.Split(' ');
                foreach (var word in words)
                {


                    if (word.Contains("TTL<"))
                    {
                        Console.WriteLine("Super Greate Ping Speed " + word);
                    }
                    else if (word.Contains("TTL="))
                    {
                        string TTL = "";
                        foreach (char c in word)
                        {
                            if (c >= '0' && c <= '9')
                            {
                                TTL += c;
                            }
                        }
                        int i = int.Parse(TTL);
                        if ( i <= 10 )
                        {
                            Console.WriteLine("Greate Ping Speed " + word);
                        }
                        else if (i >= 10 && i <= 60)
                        {
                            Console.WriteLine("Also Good Ping Speed " + word);
                        }
                        else if ( i > 60)
                        {
                            Console.WriteLine("Average Ping Speed " + word);
                        }
                    }
                }
                
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose task");
            Console.WriteLine("Task 1. is ping ");
            Console.WriteLine("Task 2. is checking pin results");
            int i = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                parseFile();
            }
            else if (i == 2)
            {
                Console.WriteLine("Plese insert ping parameters");
                P(Console.ReadLine());
            }
        }
    }
}
