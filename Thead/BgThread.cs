using System;
using System.Diagnostics;
using static System.Console;

namespace Thead
{
    public class BgThread
    {
        public static void Main(String[] args)
        {
            var t1 = new Thread(Dowork);
            t1.IsBackground = true;
            t1.Start();

            for(int i = 0;i < 2; i++)
            {
                //main thread have 2 num loop was executed so it was create two thread
                //to execute the Dowork method
                Thread.Sleep(100);
                WriteLine("Main Thread was running");
            }
        }

        static void Dowork()
        {
            for(int i = 0; i < 5; i++)
            {
                //but this loop execute 5 times so created the 5 thread take some seconds
                Thread.Sleep(100);
                WriteLine("Foreground Thread was running");
            }
        }
    }
}