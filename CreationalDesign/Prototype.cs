using static System.Console;

namespace CreationalDesign;

public interface IPrototype<T>
{
    T Clone();
}

public class Warrior : IPrototype<Warrior>
{
    public string Name  {  get; set;  }
    public int Health {  get; set; }
    public int AttackPower {   get; set;  }

    public Warrior(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }

    public override string ToString() 
        => $"Name: {Name}, Health:{Health}, AttackPower: {AttackPower}";

    public Warrior Clone() => (Warrior)MemberwiseClone();

}

public class Prototype
{
    public static void Main(string[] args)
    {
        // Create an instance of the Warrior prototype
        var loki = new Warrior("Loki", 100, 20);

        // Clone the Loki warrior to create
        // a new warrior named Thor
        var thor = loki.Clone();
        thor.Name = "Thor";
        thor.Health = 120;

        // Now we have two different warrior objects with
        // similar properties but with some differences
        WriteLine(loki);
        WriteLine(thor);
    }
}