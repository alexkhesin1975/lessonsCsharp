using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Lesson5
{
    class Program
    {
        static int Main(string[] args)
        {
            string word = "hello,how are you!";

            string[] s1 = word.Split(' ', ',');
            // run ping
            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = "ping.exe";

            string path = @"D:\Users\sasha\Documents\GitHub\home\lessonsCsharp\Lesson5\Lesson5\bin\Debug\";
            process.StartInfo.Arguments = "-n 1 212.179.6.9";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;

            process.StartInfo.WindowStyle =   ProcessWindowStyle.Normal;
            process.Start();


            Console.WriteLine("waiting for ping!!");

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            StreamWriter sw =  File.CreateText("output.txt");
            sw.Write(output);
            sw.Close();

            
            TextReader sr = File.OpenText("output.txt");
            string result = sr.ReadToEnd();

            Console.WriteLine("file content is: ");
            Console.WriteLine(result);

            string o = File.ReadAllText("output.txt");
            string[] lines = File.ReadAllLines("output.txt");
            foreach (string currLine  in lines)
            {
                if (currLine.Contains("timeout"))
                {
                    Console.WriteLine("Connection didnt succeess");
                }
                else
                {
                    Console.WriteLine("Conecction is on!");
                }
            }
            
            // check the result

            // if succeed print message
            // if not try again
            return 0;
        }
    }
}
