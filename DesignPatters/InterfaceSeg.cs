namespace DesignPatters
{
    public class InterfaceSeg
    {
        static void Main(String[] args)
        {
            Worker worker = new Worker();
            worker.Run();
            worker.Eat();
            RobotWorker robotWorker = new RobotWorker();
            robotWorker.Run();
            robotWorker.Eat(); //cannot eat its return NotImplementedException exception

            HumanWorker humanWorker = new HumanWorker();
            humanWorker.Work();
            humanWorker.Eat();
            RoboticWorker roboticWorker = new RoboticWorker();
            roboticWorker.Work(); // we use Interface Segeration Principle to don't force un usual methods in RoboticWorker class
        }
    }
}


//Bad design in Interface Segregation Principle
public interface Iworker
{
    void Run();
    void Eat();
}

public class Worker : Iworker
{
    public void Run()
    {
        Console.WriteLine("Worker is running");
    }

    public void Eat()
    {
        Console.WriteLine("Worker is eating");
    }
}

//so this is not good design

public class RobotWorker : Iworker
{
    public void Run()
    {
        Console.WriteLine("RobotWorker is running");
    }

    public void Eat()
    {
        //robot can't eat because it's a machine so we connect Iworker interface to force the method to be implemented
        //but we can't implement it in the RobotWorker class
        //so we throw a NotImplementedException exception
        throw new NotImplementedException();
    }
}

public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public class HumanWorker : IWorkable, IEatable
{
    public void Work()
    {
        Console.WriteLine("HumanWorker is working");
    }

    public void Eat()
    {
        Console.WriteLine("HumanWorker is eating");
    }
}
//In this scenario, we have a RoboticWorker class that implements IWorkable interface 
//so don't force to implement un usual methods in RoboticWorker class
public class RoboticWorker : IWorkable
{
    public void Work()
    {
        Console.WriteLine("RoboticWorker is working");
    }
}

//Don't force classes to implement unused methods