using System;

namespace TechCafé.LambdaInput
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            
            worker.DoWork(_ =>
            {
                
            });
        }
    }
    
    public class Worker
    {
        public void DoWork(Action<string> doSomething)
        {
            doSomething.Invoke("");
        }
    }
}