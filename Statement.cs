using System;

class Statement
{
    public void StatementDemo()
    {
        Console.WriteLine("----Switch Statement----");
        Console.WriteLine("Enter a number between 1 and 3:");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You chose option 1 Buy a Car.");
                break;
            case 2:
                Console.WriteLine("You chose option 2 Buy a House.");
                break;
            case 3:
                Console.WriteLine("You chose option 3 Buy a Vacation.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                break;
        }
    }
}