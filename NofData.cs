using System;

class NofData
{
    public void Demo()
    {
        string[] fruits;
        fruits = new string[3];

        fruits[0] = "Apple";
        fruits[1] = "Banana";
        fruits[2] = "Orange";

        Console.WriteLine($"Fruit 1: {fruits[0]}");
        Console.WriteLine($"Fruit 2: {fruits[1]}");
        Console.WriteLine($"Fruit 3: {fruits[2]}");

        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Number 1: {numbers[0]}");
        Console.WriteLine($"Number 2: {numbers[1]}");
        Console.WriteLine($"Number 3: {numbers[2]}");
        Console.WriteLine($"Number 4: {numbers[3]}");
        Console.WriteLine($"Number 5: {numbers[4]}");
        Console.WriteLine($"Number of fruits: {fruits.Length}");
        Console.WriteLine($"Number of numbers: {numbers.Length}");

        string[] colors = new string[] { "Red", "Green", "Blue" };
        Console.WriteLine($"Color 1: {colors[0]}");

        double[] prices = { 9.99, 19.99, 29.99 };
        Console.WriteLine($"Price 1: {prices[0]}");
        Console.WriteLine($"Price 2: {prices[1]}");
        Console.WriteLine($"Price 3: {prices[2]}");

        for (int i = 0; i < fruits.Length; i++)
        {
            Console.WriteLine($"Fruit {i + 1} Name is : {fruits[i]}");
        }
    }
}