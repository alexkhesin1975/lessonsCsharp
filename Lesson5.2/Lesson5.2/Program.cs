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
            p.WaitForExit();
            
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Plese insert ping parameters");
            P(Console.ReadLine());
        }
    }
}
