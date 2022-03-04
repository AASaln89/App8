using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = "Logs";
            //if (Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}
            //DirectoryInfo directory = new DirectoryInfo(path);
            //if (!directory.Exists)
            //{
            //    directory.Create();
            //}
            string path1 = "D:/Log.txt";
            if (!File.Exists(path1))
            {
                File.Create(path1);
            }
            using (StreamWriter streamWriter = new StreamWriter(path1, true))
            {
                int[] array = new int[10];
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(-5, 5);
                    streamWriter.WriteLine("{0} ", array[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
