using static System.Console;

namespace CreationalDesign;

public class Pizza
{
    public string Crust { get; set; } = string.Empty;
    public string Sauce { get; set; } = string.Empty;
    public List<string> Toppings { get; set; } = new();
    public bool IsExtraCheese { get; set; } = false;
    public bool IsSpicy { get; set; } = false;

    public void Display()
    {
        Console.WriteLine($"🍕 Pizza: {Crust} crust, {Sauce} sauce");
        Console.WriteLine($"Toppings: {string.Join(", ", Toppings)}");
        Console.WriteLine($"   Extras: {(IsExtraCheese ? "Extra Cheese" : "")} {(IsSpicy ? "Spicy" : "")}");
    }
}

public class PizzaBuilder
{
    private readonly Pizza _pizza = new();

    public PizzaBuilder SetCrust(string crust)
    {
        _pizza.Crust = crust;
        return this;
    }

    public PizzaBuilder SetSauce(string sauce)
    {
        _pizza.Sauce = sauce;
        return this;
    }

    public PizzaBuilder AddTopping(string topping)
    {
        _pizza.Toppings.Add(topping);
        return this;
    }

    public PizzaBuilder AddExtraCheese()
    {
        _pizza.IsExtraCheese = true;
        return this;
    }

    public PizzaBuilder MakeSpicy()
    {
        _pizza.IsSpicy = true;
        return this;
    }

    public Pizza Build()
    {
        return _pizza;
    }

    public void OrderPizza()
{
    var myPizza = new PizzaBuilder()
        .SetCrust("Stuffed")
        .SetSauce("BBQ")
        .AddTopping("Pepperoni")
        .AddTopping("Mushrooms")
        .AddTopping("Olives")
        .AddExtraCheese()
        .MakeSpicy()
        .Build();

    myPizza.Display();
    
    }

    

    
}