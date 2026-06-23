using System;

interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Console] {message}");
    }
}


public class FileLogger : ILogger
{
    public void Log(string message)
    {
        // Simulate writing to a file
        Console.WriteLine($"[File] {message}");
    }
}

