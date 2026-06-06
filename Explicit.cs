using System;

interface Logger
{
    void Log(string message);
}

class ConsoleLoggers : Logger
{
    public void Log(string message) => Console.WriteLine($"Console Logger: {message}");
}