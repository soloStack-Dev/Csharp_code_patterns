namespace DesignPatters
{
    public class LisKovSub
    {
        public static void TestDrive(Vehicle vehicle)
        {
            vehicle.Drive();
        }
        static void Main(String[] args)
        {
            var car = new Car();
            TestDrive(car);
            var truck = new Truck();
            TestDrive(truck);
            var aircraft = new Aircraft();
            TestDrive(aircraft);

            var sparrow = new Sparrow();
            sparrow.Eat();
            sparrow.Fly();
            var eagle = new Eagle();
            eagle.Eat();
            eagle.Fly();
            var penguin = new Penguin();
            penguin.Eat();
        }
    }
}

//Child class should be usable wherever parent class is expected
//This is called Liskov Substitution Principle
//LSP = Child Should Behave Like Parent

public abstract class Vehicle
{
    public abstract void Drive();
}

public class Car : Vehicle
{
    public override void Drive() => Console.WriteLine("Driving car...");
}

public class Truck : Vehicle
{
    public override void Drive() => Console.WriteLine("Driving truck...");
}

public class Aircraft : Vehicle
{
    public override void Drive() => throw new NotImplementedException();
}





public class Bird
{
    public void Eat()
    {
        Console.WriteLine("Bird was eating...");
    }
}

public abstract class FlyBird : Bird
{
    public abstract void Fly();
}

public class Sparrow : FlyBird
{
    public override void Fly() => Console.WriteLine("Sparrow is flying...");
}

public class Eagle : FlyBird
{
    public override void Fly() => Console.WriteLine("Eagle is flying...");
}

public class Penguin : Bird
{
    
}