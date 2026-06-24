using static System.Console;

namespace CreationalDesign;

public class Product
{
    public string PartA {   get; set; } = string.Empty;
    public string PartB {   get; set; } = string.Empty;
}

public interface IBuilder
{
    IBuilder BuildPartA();
    IBuilder BuildPartB();
    Product GetProduct();
}

public class ConcreteBuilder : IBuilder
{
    public Product _product = new();

    public IBuilder BuildPartA()
    {
        _product.PartA = "Part A";
        return this;
    }

    public IBuilder BuildPartB()
    {
        _product.PartB = "Part B";
        return this;
    }

    public Product GetProduct()
    {
        return _product;
    }
}

public class Director
{
    private readonly IBuilder _builder;

    public Director(IBuilder builder)
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.BuildPartA();
        _builder.BuildPartB();
    }
}

public class Builder
{
    static void Main()
    {
        var builder = new ConcreteBuilder();
        
        var director = new Director(builder);
        director.Construct();

        var product = builder.GetProduct();
        WriteLine($"Product Parts: {product.PartA}, {product.PartB}");
    }
}