using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._2._3_7_datoteke
{
    class Program
    {
        class PrintString
        {
            static FileStream fs;
            static StreamWriter sw;

            // delegate declaration
            public delegate void printString(string s);

            // this method prints to the console
            public static void WriteToFileNoviRed(string s)
            {
                string[] red = s.Split(',');

                fs = new FileStream("3or7uNoviRed.txt",
                FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                foreach (var item in red)
                {
                  sw.WriteLine(item);
                }
                

                sw.Flush();
                sw.Close();
                fs.Close();
            }

            //this method prints to a file
            public static void WriteToFileZarez(string s)
            {
                fs = new FileStream("3or7Zarez.txt",
                FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(s);
                sw.Flush();
                sw.Close();
                fs.Close();
            }

            // this method takes the delegate as parameter and uses it to
            // call the methods as required
            public static void sendString(printString ps)
            {
                string trisedam="";
                for (int i = 0; i < 100; i++)
                {
                    if(i%3==0 || i % 7 == 0)
                    {
                        trisedam += i + ",";
                    }
                } 
                ps(trisedam);
            }
            static void Main(string[] args)
            {
                printString ps1 = new printString(WriteToFileZarez);
                printString ps2 = new printString(WriteToFileNoviRed);
                sendString(ps1);
                sendString(ps2);
                Console.ReadKey();
            }
        }
    }
}