using System;

namespace TechCafé.StaticLambda
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Worker
    {
        private readonly string _name = "Marco";

        public void DoWork()
        {
            Action lambda = () => Console.WriteLine(_name);
            // Action staticLambda = static () => Console.WriteLine(_name); // Does not compile
        }

        public void DoOtherWork(Action<string> doSomething)
        {
            doSomething.Invoke("");
        }
    }
}