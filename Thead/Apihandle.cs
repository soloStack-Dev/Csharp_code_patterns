using System.Diagnostics;
using System;
using static System.Console;

namespace Thead
{
    public class ApiHandle
    {
        static void CheckHttpStatus(string url)
        {
            //create http request(simple get request)
            HttpClient client = new();
            var response = client.GetAsync(url).Result;
            Console.WriteLine($"The HTTP Status Code {url} is {response.StatusCode}");
        }
        public static void Main(String[] args)
        {
            List<string> urls = new(){ 
                "https://www.google.com/",
                "https://www.duckduckgo.com/",
                "https://www.yahoo.com/",
            };
            List<Thread> threads = new();
            urls.ForEach(url => threads.Add(new Thread(() => CheckHttpStatus(url))));

            //mesure the time how much it take to response all the urls
            var watch = Stopwatch.StartNew();

            threads.ForEach(thread => thread.Start());
            threads.ForEach(thread => thread.Join());

            watch.Stop();
            Console.WriteLine($"Total time: {watch.ElapsedMilliseconds}ms");

        }
    }
}
