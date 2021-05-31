using System;

namespace TechCafé.DefaultInterfaceImplementations
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokenClient = new TokenClient();
            var defaultClient = new DefaultClient();
            
            // Console.WriteLine(tokenClient.GetToken());
            // Console.WriteLine(defaultClient.GetToken());

            Console.ReadKey();
        }
    }
}