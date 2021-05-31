using System;

namespace TechCafé.PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool IsLetter(char c)
        {
            return c is >= 'a' and <= 'z' or >= 'A' and <= 'Z'; 
        } 
    }
}