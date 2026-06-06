using System;
using System.Diagnostics;
using System.Threading;

namespace Thead
{
    public class ContinueWith
    {
        public static void Main()
        {
            var result = 0;
            var task = System.Threading.Tasks.Task.Run<int>(() => GetSquareNumber(5));

            task.ContinueWith((taskResult) =>
            {
                result = taskResult.Result;
                Console.WriteLine($"Result: {result}");
            });

            while(result == 0)
            {
                Console.WriteLine("Waiting for the result...");
                Thread.Sleep(1000);
            }
        }

        static int GetSquareNumber(int number)
        {
            Thread.Sleep(3000);
            return number * number;
        }
    }
}