using System;

class Conditional
{
    public void ConditionalDemo()
    {
        Console.WriteLine("----Conditional----");

        Console.WriteLine("Enter a weather condition (sunny, cloudy): ");
        string? input;
        input = Console.ReadLine();

        if (input == "sunny")
        {
            Console.WriteLine("It's a bright and sunny day!");
        }
        else if (input == "rainy")
        {
            Console.WriteLine("Don't forget your umbrella, it's raining!");
        }
        if (input == "cloudy")
        {
            Console.WriteLine("It's a bit gloomy with all the clouds.");
        }

        Console.WriteLine("----Leap year finder----");
        Console.WriteLine("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 2 == 0)
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }

        Console.WriteLine("----Grade calculator----");
        Console.WriteLine("Enter a score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        if (score >= 80)
        {
            Console.WriteLine("You got an A!");
        }
        else if (score >= 70)
        {
            Console.WriteLine("You got a B!");
        }
        else
        {
            Console.WriteLine("You got a C or lower.");
        }
    }
}