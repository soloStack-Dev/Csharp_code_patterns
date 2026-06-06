using System;

static class ExtensionMethod
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
    public static bool IsOdd(this int number)
    {
        return !IsEven(number);
    }
}