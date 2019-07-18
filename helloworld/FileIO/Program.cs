using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("D:\\ReadAllFiles\\testFIO.txt", "Hello! I am file input output operation");
            var result = File.ReadAllText("D:\\ReadAllFiles\\testFIO.txt");


            var files = Directory.GetFiles("D:\\ReadAllFiles\\");


            foreach (var item in files)
            {
                var tempText = File.ReadAllText(item);

                Console.WriteLine(tempText);
            }
            Console.ReadLine();

        }
    }
}
