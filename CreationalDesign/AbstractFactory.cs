using System;

namespace CreationalDesign;

public class AbstractFactory
{
    static void Main()
    {
        MealConbo mealConbo = new MealConbo(new USAFactory());
        mealConbo.ShowMeal();
        mealConbo.ServeCostumer("India");
    }
}


public interface IBurgers
{
    string Describe();
}

public interface IDrink
{
    string Describe();
}

public interface IFries
{
    string Describe();
}

public class USABurger : IBurgers
{
    public string Describe()
    {
        return "🍔 Beef Burger";
    }
}

public class USADrink : IDrink
{
    public string Describe()
    {
        return "🥤 Coca-Cola";
    }
}

public class USAFries : IFries
{
    public string Describe()
    {
        return "🍟 Regular Fries";
    }
}

public class IndiaBurger : IBurgers
{
    public string Describe()
    {
        return "🧀 Paneer Burger";
    }
}

public class IndiaDrink : IDrink
{
    public string Describe()
    {
        return "🥤 Thums Up";
    }
}

public class IndiaFries : IFries
{
    public string Describe()
    {
        return "🍟 Masala Fries";
    }
}

public interface IRestaurantFactory
{
    IBurgers CreateBurger();
    IDrink CreateDrink();
    IFries CreateFries();
}

public class USAFactory : IRestaurantFactory
{
    public IBurgers CreateBurger()
    {
        return new USABurger();
    }

    public IDrink CreateDrink()
    {
        return new USADrink();
    }

    public IFries CreateFries()
    {
        return new USAFries();
    }
}

public class IndiaFactory : IRestaurantFactory
{
    public IBurgers CreateBurger()
    {
        return new IndiaBurger();
    }

    public IDrink CreateDrink()
    {
        return new IndiaDrink();
    }

    public IFries CreateFries()
    {
        return new IndiaFries();
    }
}

public class MealConbo
{
    private readonly IBurgers _burger;
    private readonly IDrink _drink;
    private readonly IFries _fries;

    public MealConbo(IRestaurantFactory factory)
    {
        _burger = factory.CreateBurger();
        _drink = factory.CreateDrink();
        _fries = factory.CreateFries();
    }

    public void ShowMeal()
    {
        Console.WriteLine("=== Your Meal Combo ===");
        Console.WriteLine($"Burger: {_burger.Describe()}");
        Console.WriteLine($"Drink: {_drink.Describe()}");
        Console.WriteLine($"Fries: {_fries.Describe()}");
    }

    public void ServeCostumer(string country)
    {
        IRestaurantFactory factory = country switch
        {
            "USA" => new USAFactory(),
            "India" => new IndiaFactory(),
            _ => throw new ArgumentException("Invalid country")
        };

        MealConbo meal = new MealConbo(factory);
        meal.ShowMeal();
    }
}


