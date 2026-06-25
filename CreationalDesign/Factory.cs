using System;

namespace CreationalDesign;

public class Factory
{
    static void Main()
    {
        OrderSystem orderSystem = new OrderSystem();
        orderSystem.PlaceOrder("Chicken");
    }
}

//The Product
public interface IBurger
{
    string GetDescription();
    decimal GetPrice();
}

public class CheeseBurger : IBurger
{
    public string GetDescription()
    {
        return "🍔 Cheese Burger with beef patty";
    }

    public decimal GetPrice()
    {
        return 8.99m;
    }
}

public class VeggieBurger : IBurger
{
    public string GetDescription()
    {
        return "🥬 Veggie Burger with black bean patty";
    }

    public decimal GetPrice()
    {
        return 9.49m;
    }
}

public class ChickenBurger : IBurger
{
    public string GetDescription()
    {
        return "🐔 Chicken Burger with grilled chicken";
    }

    public decimal GetPrice()
    {
        return 9.99m;
    }
}

public class BurgerFactory
{
    public static IBurger CreateBurger(string type)
    {
        return type.ToLower() switch
        {
            "cheese" => new CheeseBurger(),
            "veggie" => new VeggieBurger(),
            "chicken" => new ChickenBurger(),
            _ => throw new ArgumentException($"Invalid burger type: {type}"),
        };
    }
}

public class OrderSystem
{
    public void PlaceOrder(string burgerType)
    {
        IBurger burger = BurgerFactory.CreateBurger(burgerType);

        Console.WriteLine($"Order placed: {burger.GetDescription()} for {burger.GetPrice()}");
    }
}