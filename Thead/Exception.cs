using System;
using System.Diagnostics;
using System.Threading;

namespace Thead
{
    public class Exception
    {
        public static void Main()
        {
            try
            {
                var task = System.Threading.Tasks.Task.Run<decimal>(() => Divide(10, 5));
                var result = task.Result;
                Console.WriteLine($"Result: {result}");
            }catch(AggregateException ae)
            {
                ae.Flatten().Handle(e =>
                {
                    if(e is DivideByZeroException)
                    {
                        Console.WriteLine(e.Message);
                        return true;
                    }
                    else
                    {
                        throw e;
                    }
                });
            }
        }

        static decimal Divide(decimal a, decimal b)
        {
            Thread.Sleep(1000);
            return a / b;
        }
    }
}