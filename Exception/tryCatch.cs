using System;

class tryCatch
{
    public void withOutTryCatch()
    {
        int a = 10;
        int b = 0;
        int result = a / b;
        Console.WriteLine($"Result: {result}");
    }

    public void withTryCatch()
    {
        try
        {
            int a = 10;
            int b = 0;
            int result = a / b;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("----[Error: Division by zero is not allowed.]----");
        }
        finally
        {
            Console.WriteLine("----[Program continued.]----");
        }
    }
}
