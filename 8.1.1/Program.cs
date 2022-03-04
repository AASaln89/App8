using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "D:/Log.txt";
            using (StreamReader sr = new StreamReader(path1))
            {
                Console.Write(sr.ReadToEnd());
                Console.ReadKey();
            }
        }
    }
}
