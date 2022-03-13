using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendLab1
{
    public class FileActions
    {
        public void WriteLines()
        {
            var lines = File.ReadAllLines(@"D:\Users\artur.zorawski\source\repos\BackendLab1\BackendLab1\TextFile1.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"{i+1}: {lines[i]}");
            }
        }
    }
}
