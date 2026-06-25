using System;

namespace StructuralDesign;

public class Decorator
{
    public static void OrderCoffee()
    {
        ICoffee coffee = new SimpleCoffe();
        Console.WriteLine($"{coffee.GetDescription()} = ${coffee.GetCost():F2()}");

        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} = ${coffee.GetCost():F2()}");

        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} = ${coffee.GetCost():F2()}");

        coffee = new WippedCream(coffee);
        Console.WriteLine($"{coffee.GetDescription()} = ${coffee.GetCost():F2()}");

        ICoffee blackCoffee = new SugarDecorator(new SimpleCoffe());
        Console.WriteLine($"{blackCoffee.GetDescription()} = ${blackCoffee.GetCost():F2()}");
    }
    static void Main()
    {
        OrderCoffee();
        Console.WriteLine("Coffee was Ordered Successfully!");
    }
}

public interface ICoffee
{
    string GetDescription();
    decimal GetCost();
}

public class SimpleCoffe : ICoffee
{
    public string GetDescription() => "☕ Simple Coffee";
    public decimal GetCost() => 2.00m;
}

public abstract class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee _coffee;
    protected CoffeeDecorator(ICoffee coffee) => _coffee = coffee;

    public virtual decimal GetCost()
    {
        return _coffee.GetCost();
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }
}

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Milk";
    }

    public override decimal GetCost()
    {
        return base.GetCost() + 0.50m;
    }
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Sugar";
    }

    public override decimal GetCost()
    {
        return base.GetCost() + 0.25m;
    }
}

public class WippedCream : CoffeeDecorator
{
    public WippedCream(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Wipped Cream";
    }

    public override decimal GetCost()
    {
        return base.GetCost() + 0.50m;
    }
}

