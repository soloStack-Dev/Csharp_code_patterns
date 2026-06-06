using System;

class Loops
{
    public void LoopDemo()
    {
        Console.WriteLine("----For Loop----");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Iteration {i}");
        }

        Console.WriteLine("----While Loop----");
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine($"Iteration {j}");
            j++;
        }

        Console.WriteLine("----Do-While Loop----");
        int k = 0;
        do
        {
            Console.WriteLine($"Iteration {k}");
            k++;
        } while (k < 5);

        Console.WriteLine("----Break and Continue----");
        for (int a = 0;a <= 50; a++)
        {
            if (a == 25)
            {
                Console.WriteLine("Reached 25, breaking the loop.");
                break;
            }
            Console.WriteLine($"Iteration {a}");
            if(a % 2 == 0)
            {
                Console.WriteLine("Even number, skipping the rest of the loop.");
                Console.WriteLine($"Current value of a: {a}");
                continue;
            }

        }
    }
}