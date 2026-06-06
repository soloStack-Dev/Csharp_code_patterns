using System;

class Method
{
    public void Greeting()
    {
        Console.WriteLine("Hello, This is C# was invented by Microsoft.");
    }

    public void Game(string game="Unknown")
    {
        Console.WriteLine($"Your favorite Unity Game is: {game}");
    }

    public int Add(int a, int b)
    {
        return a + b;
    }
}