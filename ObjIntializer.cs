using System;

class ObjInitializer
{
    public string FruitName { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public double Price { get; set; }

    public ObjInitializer()
    {
        
    }

    public ObjInitializer(string fruitName, string color, int quantity, double price)
    {
        FruitName = fruitName;
        Color = color;
        Quantity = quantity;
        Price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("----Object Initializer Demo----");
        Console.WriteLine($"Fruit: {FruitName}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Price: {Price:C}");
    }

    public static void FruitInfo(string fruitName,double price)
    {
        Console.WriteLine($"Fruit: {fruitName}, Price: {price:C}");
    }
}