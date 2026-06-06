using System;
using System.Diagnostics;
using static System.Console;
using System.Threading;

namespace Thead
{
    public class Task
    {
        public static void Main(String[] args)
        {
            var task = new System.Threading.Tasks.Task<int>(() => GetRandomNumber());
            task.Start();

            WriteLine("Start the program");
            ReadLine();
        }

        static int GetRandomNumber()
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;
            var threadPool = Thread.CurrentThread.IsThreadPoolThread;
            WriteLine($"The thread #{threadId}, use a thread pool {threadPool}");
            Thread.Sleep(1000);
            int randomNumber = (new Random()).Next(1, 100);
            WriteLine($"Random Number: {randomNumber}");
            return randomNumber;
        }
    }
}