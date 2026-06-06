using System;

class ListPattern
{
    public void Demo()
    {
        //Discard Patterns
        Console.WriteLine("----Discard Patterns----");
        int[] numbers = { 1, 2, 3, 4, 5 };

        if (numbers is [1, 2, 3, 4, 5])
        {
            Console.WriteLine("Matched");
        }else
        {
            Console.WriteLine("Not Matched");
        }

        //Range Patterns
        Console.WriteLine("----Range Patterns----");
        int[] num = { 1, 2, 3, 4, 5 };
        if(num is [1, ..])
        {
            Console.WriteLine("Matched");
        }else
        {
            Console.WriteLine("Not Matched");
        }

        if(num is [6,..])
        {
            Console.WriteLine("Matched");
        }else
        {
            Console.WriteLine("Not Matched");
        }
        var scores = new[] { 1, 5, 3, 4, 2 };

        if (scores is [1, _, 3, ..])
        {
            Console.WriteLine("Matched");
        }
        else
        {
            Console.WriteLine("Not Matched");
        }
        var scored = new[] { 1, 2 };

        if (scored is [>= 1, .., <= 3])
        {
            Console.WriteLine("Matched");
        }

        //Var Patterns
        Console.WriteLine("----Var Patterns----");

        int[] nofval = { 1, 2, 3, 4, 5 };
        if (nofval is [var first, var second, var third, var fourth, var fifth])
        {
            Console.WriteLine($"First: {first}, Second: {second}, Third: {third}, Fourth: {fourth}, Fifth: {fifth}");
        }
    }
}