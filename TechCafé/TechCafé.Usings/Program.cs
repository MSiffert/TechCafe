using System;
using System.Collections.Generic;
using System.IO;

namespace TechCafé.Using
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        static void WriteLinesToFile1(IEnumerable<string> lines)
        {
            using var file = new StreamWriter("WriteLines2.txt");
            
            foreach (string line in lines)
            {
                file.WriteLine(line);
            }
        }
        
        static void WriteLinesToFile2(IEnumerable<string> lines)
        {
            using (var file = new StreamWriter("WriteLines2.txt"))
            {
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
            }
        }
    }
}