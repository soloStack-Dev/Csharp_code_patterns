using System;
using System.Diagnostics;
using System.Threading;

namespace Thead
{
    public class Async
    {
        public static void Main()
        {
            ShowFileContent("C:\\temp\\readme.txt");
            Console.Read();
        }

        static void ShowFileContent(string filePath)
        {
            var task = File.ReadAllLinesAsync(filePath);

            task.ContinueWith(t =>
            {
                var lines = t.Result;
                foreach(var line in lines)
                {
                    Console.WriteLine(line);
                }
            });
        }
    }
}