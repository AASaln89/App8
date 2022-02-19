using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Downloads\\";
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (var papka in di.GetDirectories())
            {
                Console.WriteLine(papka.FullName);
                DirectoryInfo di2 = new DirectoryInfo(path + papka.Name);
                foreach (var papka2 in di2.GetDirectories())
                {
                    Console.WriteLine(papka2.FullName);
                }
            }
            Console.ReadLine();
        }
    }
}
