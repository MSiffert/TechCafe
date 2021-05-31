using System;

namespace TechCafé.SwitchExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string GetRgbNew(Color colorBand)
        {
            return colorBand switch
            {
                Color.Red => "255:0:0",
                Color.Orange => "255:128:0",
                Color.Yellow => "255:255:0",
                Color.Green => "128:255:0",
                _ => throw new ArgumentOutOfRangeException(nameof(colorBand))
            };
        }

        public static string GetRgbOld(Color colorBand)
        {
            switch (colorBand)
            {
                case Color.Red: return "255:0:0";
                case Color.Orange: return "255:128:0";
                case Color.Yellow: return "255:255:0";
                case Color.Green: return "128:255:0";
                default: throw new ArgumentOutOfRangeException(nameof(colorBand));
            }
        }
    }
}