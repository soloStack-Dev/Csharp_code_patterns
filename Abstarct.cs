using System;

abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public void Info()
    {
        Console.WriteLine($"Area: {GetArea():F2} and Perimeter: {GetPerimeter():F2}");
    }
}

class Rectangle : Shape
{
    readonly double Length;
    readonly double Width;

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double GetArea()
    {
        return Length * Width;
    }

    public override double GetPerimeter()
    {
        return 2 * (Length + Width);
    }
}

class Circle : Shape
{
    readonly double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}