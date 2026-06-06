using System;

class ListPrint
{
    public void Demo()
    {
        string[] fruits = new string[] { "Apple", "Banana", "Orange" };

        Console.WriteLine("Fruits:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        int[] numbers = new int[] { 1, 2, 3, 4, 5 };

        Console.WriteLine("\nNumbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        int[] score = { 80, 90, 75, 95, 88 };
        Console.WriteLine("\nScores:");

        for(int i = 0; i < score.Length; i++)
        {
            Console.WriteLine($"{score[i]}");
        }
    }

    public void PrintArray(decimal[] elements)
    {
        Console.WriteLine("\nElements:");
        foreach (var element in elements)
        {
            Console.WriteLine($"{element:0.##}");
        }
    }
}